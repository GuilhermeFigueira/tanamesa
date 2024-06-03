Public Class login

    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        sair()
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click

        abreConexao()
        Try

        Catch ex As Exception

        End Try
        cardapio.Show()
        Me.Hide()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TopMost = True
    End Sub

    Public Class criarLogin
        Public Sub efetuarLogin()
            abreConexao()
            Try
                Dim itensList As List(Of String)
                Dim cpf As String = login.txt_cpf.Text
                Dim senha As String = login.txt_senha.Text

                If verificarVazio(itensList) = False Then
                    sql = "SELECT * FROM tb_funcionarios WHERE cpf = '" & login.txt_cpf.Text & "' AND senha = '" & login.txt_senha.Text & "' "
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        funcionario.codFuncionario
                        funcionario.foto
                        funcionario.funcao
                        funcionario.nome
                        funcionario.admin = rs.Fields()
                    Else
                        telaErro.setTexto("Usuário ou senha inválidos!")
                        telaErro.Show()
                    End If
                End If
            Catch ex As Exception
                telaErro.setTexto("Erro ao efetuar login!")
                telaErro.Show()
            End Try
        End Sub
    End Class
End Class
