Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Web.UI.Design

Imports Guna.UI2.WinForms

Public Class mesas
    Dim paginaDefault1 As New criarCardapio
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        sair.Show()
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Private Sub btn_pedidos_Click(sender As Object, e As EventArgs) Handles btn_pedidos.Click
    '  pedidos.Show()
    'Me.Hide()
    'End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        deslogar.Show()
    End Sub

    Private Sub btn_cardapio_Click(sender As Object, e As EventArgs) Handles btn_cardapio.Click
        cardapio.Show()
        Me.Hide()
    End Sub
    ' Private Sub btn_mesas_Click(sender As Object, e As EventArgs) Handles btn_mesas.Click
    '    mesas.Show()
    ' Me.Hide()
    'End Sub 

    'Private Sub btn_estoque_Click(sender As Object, e As EventArgs) Handles btn_estoque.Click
    '   estoque.Show()
    'Me.Hide()
    'End Sub

    'Private Sub btn_gerencia_Click(sender As Object, e As EventArgs) Handles btn_gerencia.Click
    '    gerencia.Show()
    '  Me.Hide()
    'End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles Me.Load
        paginaDefault1.carregarCardapio()
        'paginaDefault1.carregarPedidos()
    End Sub

    Private Sub btn_info_Click(sender As Object, e As EventArgs) Handles btn_info.Click
        infoUsuario.Show()

    End Sub

    Private Sub Guna2Panel21_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2Panel25_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2Panel29_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2Panel15_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2Panel31_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2Panel37_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
