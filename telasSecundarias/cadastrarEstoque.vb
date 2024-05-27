Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports Guna.UI2.WinForms
Imports System.IO
Public Class cadastrarEstoque
    Dim titulo As String
    Dim btn As String
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Close()
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Public Sub alterarTipoFormEstoque(tituloString As String, btnString As String)
        titulo = tituloString
        btn = btnString
    End Sub

    Public Sub cadastrarEstoque_Load(sender As Object, e As EventArgs) Handles Me.Load
        abreConexao()
        carregarCategorias("estoque", cmb_categoria)
        carregarUnidades(cmb_unidade)
    End Sub
    Public Sub cadastrarEstoque_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        dtp_dataCompra.Value = Date.Now
        dtp_dataValidade.Value = Date.Now
        If btn = "" And titulo = "" Then
            lbl_titulo.Text = "Salvar Produto no Estoque"
            btn_cadastrar.Text = "Adicionar Produto"
            limparForm(Me)
        Else
            lbl_titulo.Text = titulo
            btn_cadastrar.Text = btn
        End If
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        If btn_cadastrar.Text = "Editar Produto" Then
            gerenciadorEstoque.editarItemNoEstoque(btn_cadastrar.Tag)
        Else
            gerenciadorEstoque.cadastrarItemNoEstoque()
        End If
    End Sub

    Private Sub cmb_unidade_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_unidade.SelectedValueChanged
        If cmb_unidade.Text IsNot "" Then
            lbl_mudancaUnidade.Text = cmb_unidade.Text
            lbl_precoPorUnidade.Text = $"reais / {cmb_unidade.Text}"
        End If
    End Sub

    Private Sub pbx_imagem_Click_1(sender As Object, e As EventArgs) Handles pbx_imagem.Click
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

End Class