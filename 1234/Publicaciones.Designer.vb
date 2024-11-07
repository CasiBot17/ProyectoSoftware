<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Publicaciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPublicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarPublicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPublicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PanelOfertasAprobadas2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_SiguientePub = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelOfertasAprobadas2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(722, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Publicaciones de ofertas de Práctica Profesionales"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Purple
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1040, 38)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPublicaciónToolStripMenuItem, Me.EditarPublicaciónToolStripMenuItem, Me.EliminarPublicaciónToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcionesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OpcionesToolStripMenuItem.Image = Global._1234.My.Resources.Resources.publicaciones1
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(152, 34)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'AgregarPublicaciónToolStripMenuItem
        '
        Me.AgregarPublicaciónToolStripMenuItem.BackColor = System.Drawing.Color.DarkMagenta
        Me.AgregarPublicaciónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AgregarPublicaciónToolStripMenuItem.Image = Global._1234.My.Resources.Resources.add_circle_create_expand_new_plus_icon_123218
        Me.AgregarPublicaciónToolStripMenuItem.Name = "AgregarPublicaciónToolStripMenuItem"
        Me.AgregarPublicaciónToolStripMenuItem.Size = New System.Drawing.Size(337, 40)
        Me.AgregarPublicaciónToolStripMenuItem.Text = "Agregar Publicación"
        '
        'EditarPublicaciónToolStripMenuItem
        '
        Me.EditarPublicaciónToolStripMenuItem.BackColor = System.Drawing.Color.DarkMagenta
        Me.EditarPublicaciónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EditarPublicaciónToolStripMenuItem.Image = Global._1234.My.Resources.Resources.editar
        Me.EditarPublicaciónToolStripMenuItem.Name = "EditarPublicaciónToolStripMenuItem"
        Me.EditarPublicaciónToolStripMenuItem.Size = New System.Drawing.Size(337, 40)
        Me.EditarPublicaciónToolStripMenuItem.Text = "Editar Publicación"
        '
        'EliminarPublicaciónToolStripMenuItem
        '
        Me.EliminarPublicaciónToolStripMenuItem.BackColor = System.Drawing.Color.DarkMagenta
        Me.EliminarPublicaciónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EliminarPublicaciónToolStripMenuItem.Name = "EliminarPublicaciónToolStripMenuItem"
        Me.EliminarPublicaciónToolStripMenuItem.Size = New System.Drawing.Size(337, 40)
        Me.EliminarPublicaciónToolStripMenuItem.Text = "Eliminar Publicación"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(56, 130)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 72
        Me.DataGridView1.RowTemplate.Height = 31
        Me.DataGridView1.Size = New System.Drawing.Size(927, 463)
        Me.DataGridView1.TabIndex = 2
        '
        'PanelOfertasAprobadas2
        '
        Me.PanelOfertasAprobadas2.Controls.Add(Me.Label2)
        Me.PanelOfertasAprobadas2.Controls.Add(Me.BTN_SiguientePub)
        Me.PanelOfertasAprobadas2.Controls.Add(Me.DataGridView2)
        Me.PanelOfertasAprobadas2.Location = New System.Drawing.Point(56, 81)
        Me.PanelOfertasAprobadas2.Name = "PanelOfertasAprobadas2"
        Me.PanelOfertasAprobadas2.Size = New System.Drawing.Size(948, 549)
        Me.PanelOfertasAprobadas2.TabIndex = 3
        Me.PanelOfertasAprobadas2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Swis721 BlkCn BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(391, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Seleccione una oferta aprobada"
        '
        'BTN_SiguientePub
        '
        Me.BTN_SiguientePub.BackColor = System.Drawing.Color.DarkMagenta
        Me.BTN_SiguientePub.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SiguientePub.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_SiguientePub.Location = New System.Drawing.Point(370, 452)
        Me.BTN_SiguientePub.Name = "BTN_SiguientePub"
        Me.BTN_SiguientePub.Size = New System.Drawing.Size(178, 58)
        Me.BTN_SiguientePub.TabIndex = 1
        Me.BTN_SiguientePub.Text = "Siguiente"
        Me.BTN_SiguientePub.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(58, 92)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 72
        Me.DataGridView2.RowTemplate.Height = 31
        Me.DataGridView2.Size = New System.Drawing.Size(822, 354)
        Me.DataGridView2.TabIndex = 0
        '
        'Publicaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 650)
        Me.Controls.Add(Me.PanelOfertasAprobadas2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Publicaciones"
        Me.Text = "Publicaciones"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelOfertasAprobadas2.ResumeLayout(False)
        Me.PanelOfertasAprobadas2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarPublicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarPublicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarPublicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PanelOfertasAprobadas2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_SiguientePub As Button
    Friend WithEvents DataGridView2 As DataGridView
End Class
