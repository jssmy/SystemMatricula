Public Class Form1

    Private Sub form_registrar_Click(sender As Object, e As EventArgs) Handles form_registrar.Click
        Dim frm_empleado As New REmpleado()
        frm_empleado.MdiParent = Me
        frm_empleado.Show()


    End Sub
End Class
