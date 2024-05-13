Public Class login

    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        sair.Show()
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        cardapio.Show()
        Me.Hide()
    End Sub
End Class
