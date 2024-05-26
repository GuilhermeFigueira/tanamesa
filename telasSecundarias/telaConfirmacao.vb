Imports System.Runtime.CompilerServices
Imports Guna.UI2.WinForms

Public Class telaConfirmacao
    Delegate Sub DelegatedSub()

    Dim simSub As DelegatedSub
    Public Sub setTexto(texto As String)
        lbl_mensagem.Text = texto
    End Sub
    Public Sub setSub(subToSet As DelegatedSub)
        simSub = subToSet
    End Sub
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Hide()
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_sim_Click(sender As Object, e As EventArgs) Handles btn_sim.Click
        simSub?.Invoke()
        fechaConexao()
    End Sub

    Private Sub btn_nao_Click(sender As Object, e As EventArgs) Handles btn_nao.Click
        Hide()
    End Sub

    Private Sub telaConfirmacao_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TopMost = True
    End Sub
End Class