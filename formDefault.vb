Imports System.Runtime.CompilerServices

Public Class form_base
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Close()
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_.SelectedIndexChanged

    End Sub

    Private Sub form_base_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs)

    End Sub

    Private Sub btn__Click(sender As Object, e As EventArgs) Handles btn_.Click

    End Sub
End Class