Imports System.Data.SqlClient
Imports System.Configuration
Public Class Form1
    Private Sub SolicitudesDePracProfeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitudesDePracProfeToolStripMenuItem.Click
        ' Si el panel está visible, lo oculta; si está oculto, lo muestra
        PanerlSolicitudPP.Visible = Not PanerlSolicitudPP.Visible
        ' Cadena de conexión
        Dim connString As String = ConfigurationManager.ConnectionStrings("formularios1._0.My.MySettings.PracticasProfesionalesConnectionString").ConnectionString

        Using conn As New SqlConnection(connString)
            ' Consulta para seleccionar los datos que deseas mostrar en el DataGridView
            Dim querySelect As String = "SELECT COD_Oferta, Titulo, Descripcion,Estado,FechaEnvio, Requisitos, FechaInicio, FechaFin,ID_Facultad, ID_Empresa  FROM OfertasEnviadas"



            ' Crear el adaptador de datos y llenar el DataTable
            Dim adapter As New SqlDataAdapter(querySelect, conn)
            Dim dataTable As New DataTable()

            conn.Open()
            adapter.Fill(dataTable)
            conn.Close()

            ' Asignar el DataTable al DataGridView
            DGVSolicitudPracticasProfesionales.DataSource = dataTable
        End Using

    End Sub

    Private Sub PublicacionesDePracticasProfesionalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PublicacionesDePracticasProfesionalesToolStripMenuItem.Click
        Publicaciones.Visible = Not Publicaciones.Visible
    End Sub

    Private Sub BTNSiguiente_Click(sender As Object, e As EventArgs)
        'PanelPublicacionPP.Visible = False
        PanerlOfertapublicada.Visible = Not PanerlOfertapublicada.Visible
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connString As String = ConfigurationManager.ConnectionStrings("formularios1._0.My.MySettings.PracticasProfesionalesConnectionString").ConnectionString
        Dim query As String = "SELECT * FROM OfertasEnviadas WHERE Estado = 'Enviada'"
        Using conn As New SqlConnection(connString)
            Dim cmd As New SqlCommand(query, conn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGVSolicitudPracticasProfesionales.DataSource = table
        End Using
    End Sub

    Private Sub AprobacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AprobacionesToolStripMenuItem.Click
        Panel_OfertasAprobadas.Visible = Not Panel_OfertasAprobadas.Visible
    End Sub

    Private Sub BTN_Aprobar_Click(sender As Object, e As EventArgs) Handles BTN_Aprobar.Click
        If DGVSolicitudPracticasProfesionales.SelectedRows.Count > 0 Then
            ' Verifica si DGV_OfertasAprobadas tiene columnas; si no, las agrega.
            If DGV_OfertasAprobadas.ColumnCount = 0 Then
                For Each columna As DataGridViewColumn In DGVSolicitudPracticasProfesionales.Columns
                    DGV_OfertasAprobadas.Columns.Add(CType(columna.Clone(), DataGridViewColumn))
                Next
            End If

            ' Verifica si la columna FechaEnvio está en DGV_OfertasAprobadas
            If Not DGV_OfertasAprobadas.Columns.Contains("FechaEnvio") Then
                DGV_OfertasAprobadas.Columns.Add("FechaEnvio", "FechaEnvio")
            End If

            ' Obtiene la fila seleccionada
            Dim filaSeleccionada As DataGridViewRow = DGVSolicitudPracticasProfesionales.SelectedRows(0)
            Dim codOferta As Integer = Convert.ToInt32(filaSeleccionada.Cells("COD_Oferta").Value)
            'ejemplo para convertir al formato de fecha
            'Dim ejemplo_fecha As String = "2024-05-03"
            Dim a As Date = Convert.ToDateTime(filaSeleccionada.Cells(4).Value)

            'Dim val_fecha_envio As String = DateTime.ParseExact(filaSeleccionada.Cells(4).Value, "yyyy-mm-dd", Globalization.CultureInfo.InvariantCulture)
            'Dim val_fecha_inicio As String = DateTime.ParseExact(filaSeleccionada.Cells(6).Value, "yyyy-mm-dd", Globalization.CultureInfo.InvariantCulture)
            'Dim val_fecha_fin As String = DateTime.ParseExact(filaSeleccionada.Cells(7).Value, "yyyy-mm-dd", Globalization.CultureInfo.InvariantCulture)


            ' Cadena de conexión
            Dim connString As String = ConfigurationManager.ConnectionStrings("formularios1._0.My.MySettings.PracticasProfesionalesConnectionString").ConnectionString
            Using conn As New SqlConnection(connString)
                ' Elimina la fila de la base de datos de la tabla OfertasEnviadas
                Dim queryDelete As String = "DELETE FROM OfertasEnviadas WHERE COD_Oferta = @COD_Oferta"
                Dim cmdDelete As New SqlCommand(queryDelete, conn)
                cmdDelete.Parameters.AddWithValue("@COD_Oferta", codOferta)

                conn.Open()
                Dim filasAfectadas As Integer = cmdDelete.ExecuteNonQuery()

                If filasAfectadas > 0 Then
                    ' Agrega los valores a DGV_OfertasAprobadas
                    Dim nuevaFila As Object() = New Object(filaSeleccionada.Cells.Count - 1) {}
                    For i As Integer = 0 To filaSeleccionada.Cells.Count - 1
                        nuevaFila(i) = filaSeleccionada.Cells(i).Value
                    Next

                    ' Inserta la nueva oferta en la base de datos en la tabla OfertasAprobadas
                    Dim queryInsert As String = "INSERT INTO OfertasAprobadas (Titulo, Descripcion, Estado, FechaEnvio, Requisitos, FechaInicio, FechaFin, ID_Facultad, ID_Empresa) 
                                             VALUES (@Titulo, @Descripcion, @Estado, @FechaEnvio, @Requisitos, @FechaInicio, @FechaFin, @ID_Facultad, @ID_Empresa)"
                    Dim cmdInsert As New SqlCommand(queryInsert, conn)

                    cmdInsert.Parameters.AddWithValue("@Titulo", filaSeleccionada.Cells("Titulo").Value)
                    cmdInsert.Parameters.AddWithValue("@Descripcion", filaSeleccionada.Cells("Descripcion").Value)
                    cmdInsert.Parameters.AddWithValue("@Estado", filaSeleccionada.Cells("Estado").Value)
                    cmdInsert.Parameters.AddWithValue("@FechaEnvio", filaSeleccionada.Cells(3).Value)
                    cmdInsert.Parameters.AddWithValue("@Requisitos", filaSeleccionada.Cells("Requisitos").Value)
                    cmdInsert.Parameters.AddWithValue("@FechaInicio", a)
                    cmdInsert.Parameters.AddWithValue("@FechaFin", filaSeleccionada.Cells("FechaFin").Value)
                    cmdInsert.Parameters.AddWithValue("@ID_Facultad", filaSeleccionada.Cells(8).Value)
                    cmdInsert.Parameters.AddWithValue("@ID_Empresa", filaSeleccionada.Cells(9).Value)




                    ' Ejecuta la inserción
                    cmdInsert.ExecuteNonQuery()

                    ' Agrega la nueva fila al DataGridView DGV_OfertasAprobadas
                    DGV_OfertasAprobadas.Rows.Add(nuevaFila)

                    ' Elimina la fila del DataGridView DGVSolicitudPracticasProfesionales
                    DGVSolicitudPracticasProfesionales.Rows.Remove(filaSeleccionada)

                    MessageBox.Show("Oferta aprobada y movida a la lista de ofertas aprobadas.")
                Else
                    MessageBox.Show("No se pudo eliminar la oferta de la base de datos.")
                End If

                conn.Close()
            End Using
        Else
            MessageBox.Show("Por favor, selecciona una fila.")
        End If
    End Sub

End Class
