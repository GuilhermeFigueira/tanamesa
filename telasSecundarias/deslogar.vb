Public Class deslogar
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Close()
    End Sub
    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btn_nao_Click(sender As Object, e As EventArgs) Handles btn_nao.Click
        Close()
    End Sub
    Private Sub btn_sim_Click(sender As Object, e As EventArgs) Handles btn_sim.Click
        login.Show()
        Dim frm As Form
        For Each frm In Application.OpenForms
            If frm.Name <> "login" Then
                frm.Visible = False
            End If
        Next
    End Sub
End Class