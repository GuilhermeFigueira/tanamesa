﻿Imports System.Runtime.CompilerServices
Imports Guna.UI2.WinForms

Public Class telaErro
    Public Sub setTexto(texto As String)
        lbl_mensagem.Text = texto
    End Sub
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Close()
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_sim_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Close()
    End Sub

End Class