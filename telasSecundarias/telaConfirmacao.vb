﻿Imports System.Runtime.CompilerServices
Imports Guna.UI2.WinForms

Public Class telaConfirmacao
    Public Sub setTexto(texto As String)
        lbl_mensagem.Text = texto
    End Sub
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Close()
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_sim_Click(sender As Object, e As EventArgs) Handles btn_sim.Click
        Application.Exit()
    End Sub

    Private Sub btn_nao_Click(sender As Object, e As EventArgs) Handles btn_nao.Click
        Close()
    End Sub

    Private Sub telaConfirmacao_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TopMost = True
    End Sub
End Class