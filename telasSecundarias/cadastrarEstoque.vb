﻿Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports Guna.UI2.WinForms
Imports System.IO
Public Class cadastrarEstoque
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Close()
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pbx_imagem_Click(sender As Object, e As EventArgs) Handles pbx_imagem.Click
        Try
            With ofd_imagem
                .Title = "Selecione uma foto"
                .InitialDirectory = (Application.StartupPath & "\imgProdutos")
                .ShowDialog()
                caminhoImagem = .FileName
                pbx_imagem.Load(caminhoImagem)
            End With
            Dim randomNomeArquivo As Guid = Guid.NewGuid()
            Dim uuidString As String = $"{randomNomeArquivo.ToString()}.jpg"

            Dim caminhoCopia As String = Path.Combine(Application.StartupPath, "imgProdutos", Path.GetFileName(uuidString))
            Directory.CreateDirectory(Path.GetDirectoryName(caminhoCopia))
            File.Copy(caminhoImagem, caminhoCopia, True)
            caminhoImagem = uuidString
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Public Sub alterarTipoFormEstoque(titulo As String, btn As String)
        lbl_titulo.Text = titulo
        btn_cadastrar.Text = btn
    End Sub

    Private Sub cadastrarEstoque_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TopMost = True
        gerenciadorEstoque.carregarCategorias()
        carregarUnidades(cmb_unidade)

    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        gerenciadorEstoque.cadastrarItemNoEstoque()
    End Sub
End Class