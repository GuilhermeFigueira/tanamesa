Imports System.IO
Imports System.Runtime.CompilerServices
Imports Guna.UI2.WinForms

Public Class infoUsuario
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Close()
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub infoUsuario_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TopMost = True
    End Sub

    Private Sub infoUsuario_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txt_cpf.Text = funcionario.cpf
        txt_nome.Text = funcionario.nome
        txt_funcao.Text = funcionario.funcao
        If funcionario.foto <> Nothing Then
            pbx_imgFuncionario.Load(Path.Combine(Application.StartupPath, "imgFuncionarios", funcionario.foto))
        End If
    End Sub
End Class