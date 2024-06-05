Public Class cadastrarFuncionario
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
    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        gerenciadorGerencia.gerenciaCadastrarFuncionario()
    End Sub

    Private Sub cadastrarFuncionario_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.TopMost = True
        gerenciadorGerencia.carregarCadastroFuncionario()
    End Sub
End Class