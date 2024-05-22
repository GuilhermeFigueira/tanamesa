Imports System.Runtime.CompilerServices
Imports Guna.UI2.WinForms

Public Class cadastrarCardapio
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Close()
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pbx_imagem_Click(sender As Object, e As EventArgs) Handles pbx_imagem.Click
        Try
            With ofd_imagem
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = (Application.StartupPath & "\Fotos")
                .ShowDialog()
                caminhoImagem = .FileName
                pbx_imagem.Load(caminhoImagem)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Public Sub alterarTipoFormCardapio(titulo As String, btn As String)
        lbl_titulo.Text = titulo
        btn_cadastrar.Text = btn
    End Sub

    Private Sub cadastrarCardapio_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TopMost = True
    End Sub
End Class