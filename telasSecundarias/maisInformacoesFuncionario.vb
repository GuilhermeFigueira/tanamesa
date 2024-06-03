Imports System.IO
Imports System.Runtime.CompilerServices
Imports Guna.UI2.WinForms

Public Class maisInformacoesFuncionario
    Dim btn As String
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Close()
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub maisInfoFuncionario_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TopMost = True
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
        gerenciadorGerencia.excluirFuncionario(lbl_codFuncionario.Tag)
    End Sub
End Class