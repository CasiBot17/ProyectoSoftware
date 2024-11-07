Public Class Estudiante
    Private Sub ListadoDePrácticasProfesionalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDePrácticasProfesionalesToolStripMenuItem.Click
        panelFormularioPostulacion.Visible = Not panelFormularioPostulacion.Visible
    End Sub

    Private Sub BTNEnviarFormulario_Click(sender As Object, e As EventArgs) Handles BTNEnviarFormulario.Click
        PanelFormulario.Visible = Not PanelFormulario.Visible
    End Sub
End Class