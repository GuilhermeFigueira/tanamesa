Imports System.Runtime.CompilerServices
Imports Guna.UI2.WinForms
Imports System.IO


Public Class cadastrarCardapio
    Dim titulo As String
    Dim btn As String
    Public Sub alterarTipoFormCardapio(tituloString As String, btnString As String)
        titulo = tituloString
        btn = btnString
    End Sub
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
            Dim uuidString As String = $"{randomNomeArquivo}.jpg"

            Dim caminhoCopia As String = Path.Combine(Application.StartupPath, "imgProdutos", Path.GetFileName(uuidString))
            Directory.CreateDirectory(Path.GetDirectoryName(caminhoCopia))
            File.Copy(caminhoImagem, caminhoCopia, True)
            caminhoImagem = uuidString
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub



    Private Sub cadastrarCardapio_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TopMost = True
        abreConexao()
        carregarCategorias("cardapio", cmb_categoria)

    End Sub
    Private Sub cadastrarCardapio_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If btn = "" And titulo = "" Then
            lbl_titulo.Text = "Salvar Prato no Cardápio"
            btn_cadastrar.Text = "Adicionar Produto"
            limparForm(Me)
        Else
            lbl_titulo.Text = titulo
            btn_cadastrar.Text = btn
        End If
    End Sub

    Private Sub txt_markup_LostFocus(sender As Object, e As EventArgs) Handles txt_markup.TextChanged
        calcularPreco()
    End Sub
    Private Sub txt_custoPrato_LostFocus(sender As Object, e As EventArgs) Handles txt_custoPrato.TextChanged
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

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        If btn_cadastrar.Text = "Editar Prato" Then
            gerenciadorCardapio.editarItemCardapio(btn_cadastrar.Tag)
        Else
            gerenciadorCardapio.cadastrarItemCardapio()
        End If
    End Sub
End Class