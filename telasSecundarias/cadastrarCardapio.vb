Imports System.Runtime.CompilerServices
Imports Guna.UI2.WinForms

Public Class cadastrarCardapio
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Hide()
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
    End Sub

    Private Sub txt_markup_LostFocus(sender As Object, e As EventArgs) Handles txt_markup.LostFocus
        calcularPreco()
    End Sub
    Private Sub txt_custoPrato_LostFocus(sender As Object, e As EventArgs) Handles txt_custoPrato.LostFocus
        calcularPreco()
    End Sub

    Private Sub calcularPreco()
        Try
            If txt_markup.Text IsNot "" And txt_custoPrato.Text IsNot "" Then
                Dim markup As Single = CSng(txt_markup.Text)
                Dim custoPrato As Single = CSng(txt_custoPrato.Text)
                Dim preco As Single
                preco = custoPrato / markup
                txt_precoRecomendado.Text = $"R$ {preco.ToString("N2")}"
            End If
        Catch ex As Exception
            telaErro.setTexto("Erro ao calcular preço!")
            telaErro.Show()
        End Try
    End Sub

End Class