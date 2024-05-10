Imports System.Runtime.CompilerServices

Public Class home
    Dim moveFormInstance As New MoveForm()

    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click

    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pnl_title_MouseDown(sender As Object, e As MouseEventArgs) Handles pnl_title.MouseDown
        moveFormInstance.MouseDown(e)
    End Sub
    Private Sub pnl_title_MouseMove(sender As Object, e As MouseEventArgs) Handles pnl_title.MouseMove
        moveFormInstance.MouseMove(Me)
    End Sub
    Private Sub pnl_title_MouseUp(sender As Object, e As MouseEventArgs) Handles pnl_title.MouseUp
        moveFormInstance.MouseUp(e)
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_pedidos_Click(sender As Object, e As EventArgs) Handles btn_pedidos.Click

    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub btn_cardapio_Click(sender As Object, e As EventArgs) Handles btn_cardapio.Click
        form_base.Show()
    End Sub
End Class