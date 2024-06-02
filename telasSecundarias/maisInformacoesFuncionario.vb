Imports System.IO
Imports System.Runtime.CompilerServices
Imports Guna.UI2.WinForms

Public Class maisInformacoesFuncionario
    Dim btn As String
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Close()
    End Sub
    Public Sub alterarTipoFormMaisInfoFuncionario(tituloString As String, btnString As String)
        btn = btnString
    End Sub
    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub maisInfoFuncionario_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TopMost = True
        abreConexao()
    End Sub
    Private Sub maisInformacoesFuncionario_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If btn = "" Then
            btn_salvar.Text = "Salvar alterações"
            limparForm(Me)
            btn_excluirFuncionario.Visible = True
        Else
            btn_excluirFuncionario.Visible = False
            btn_salvar.Text = btn
        End If
    End Sub
    Private Sub pbx_imgFuncionario_Click(sender As Object, e As EventArgs) Handles pbx_imgFuncionario.Click
        Try
            With ofd_imagem
                .Title = "Selecione uma foto"
                .InitialDirectory = (Application.StartupPath & "\imgFuncionarios")
                .ShowDialog()
                caminhoImagem = .FileName
                pbx_imgFuncionario.Load(caminhoImagem)
            End With
            Dim randomNomeArquivo As Guid = Guid.NewGuid()
            Dim uuidString As String = $"{randomNomeArquivo}.jpg"

            Dim caminhoCopia As String = Path.Combine(Application.StartupPath, "imgFuncionarios", Path.GetFileName(uuidString))
            Directory.CreateDirectory(Path.GetDirectoryName(caminhoCopia))
            File.Copy(caminhoImagem, caminhoCopia, True)
            caminhoImagem = uuidString
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        If btn_salvar.Text = "Editar Produto" Then
            'gerenciadorEstoque.editarItemNoEstoque(btn_cadastrar.Tag)
        Else
            'gerenciadorEstoque.cadastrarItemNoEstoque()
        End If
    End Sub

    Private Sub btn_excluirFuncionario_Click(sender As Object, e As EventArgs) Handles btn_excluirFuncionario.Click
        abreConexao()
        Try
            sql = "DELETE * FROM tb_funcionarios WHERE cod_funcionario = " & lbl_codFuncionario.Tag & ""
            rs = db.Execute(sql)
            telaErro.setTexto("Funcionário excluído com sucesso!")
            telaErro.Show()
        Catch ex As Exception
            telaErro.setTexto("Erro ao excluir funcionário!")
            telaErro.Show()
        End Try
    End Sub
End Class