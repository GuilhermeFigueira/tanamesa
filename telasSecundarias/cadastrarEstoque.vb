Imports System.Runtime.CompilerServices
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

    Private Sub pbx_imagem_Click(sender As Object, e As EventArgs)
        Try
            With ofd_imagem
                .Title = "Selecione uma foto"
                .InitialDirectory = (Application.StartupPath & "\imgProdutos")
                .ShowDialog()
                caminhoImagem = .FileName
                pbx_imagem.Load(caminhoImagem)
            End With
            Dim randomNomeArquivo As Guid = Guid.NewGuid()
            Dim uuidString As String = $"{randomNomeArquivo}.jpg"

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
        gerenciadorEstoque.carregarCategorias()
        carregarUnidades(cmb_unidade)
        dtp_dataCompra.Value = Date.Now
        dtp_dataValidade.Value = Date.Now
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        gerenciadorEstoque.cadastrarItemNoEstoque()
    End Sub

    Private Sub cmb_unidade_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_unidade.SelectedValueChanged
        If cmb_unidade.Text IsNot "" Then
            lbl_mudancaUnidade.Text = cmb_unidade.Text
            lbl_precoPorUnidade.Text = $"reais / {cmb_unidade.Text}"
        End If
    End Sub
End Class