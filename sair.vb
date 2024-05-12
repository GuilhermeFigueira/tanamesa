Imports System.Runtime.CompilerServices
Imports Guna.UI.WinForms
Imports Guna.UI2.WinForms

Public Class sair
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Close()
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn__Click(sender As Object, e As EventArgs) Handles btn_sim.Click
        Application.Exit()
    End Sub

    Private Sub btn_nao_Click(sender As Object, e As EventArgs) Handles btn_nao.Click
        Close()
        Dim penis As New Guna2PictureBox() With {
            .Image = Image.FromFile("")
        }
    End Sub
End Class