Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Web.UI.Design
Imports Guna.UI2.WinForms

Public Class pedidos
    Dim pedidos As New criarPedidos
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        sair.Show()
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        deslogar.Show()
    End Sub

    Private Sub btn_cardapio_Click(sender As Object, e As EventArgs) Handles btn_cardapio.Click
        cardapio.Show()
        Me.Hide()
    End Sub

    Private Sub btn_estoque_Click(sender As Object, e As EventArgs) Handles btn_estoque.Click
        'estoque.Show()
        Me.Hide()
    End Sub

    Private Sub btn_gerencia_Click(sender As Object, e As EventArgs) Handles btn_gerencia.Click
        'gerencia.Show()
        Me.Hide()
    End Sub

    Private Sub btn_info_Click(sender As Object, e As EventArgs) Handles btn_info.Click
        infoUsuario.Show()

    End Sub

    Private Sub btn_mesas_Click(sender As Object, e As EventArgs) Handles btn_mesas.Click
        mesas.Show()
        Me.Hide()
    End Sub

    Private Sub pedidos_Load(sender As Object, e As EventArgs) Handles Me.Load
        pedidos.carregarProgresso()
    End Sub
End Class

Public Class criarPedidos
    Sub carregarProgresso()
        Dim pnl_pedidoProgresso As New Guna2Panel With {
            .Name = "pnl_pedidoProgresso",
            .FillColor = Color.FromArgb(244, 187, 108),
            .Size = New Size(254, 70),
            .BackColor = Color.Transparent
        }

        Dim lbl_numeroPedido As New Guna2HtmlLabel With {
            .Name = "lbl_numeroPedido",
            .Text = "12",
            .Font = New Font("Julius Sans One", 25),
            .Location = New Point(30, 18),
            .Parent = pnl_pedidoProgresso
        }

        Dim lbl_statusPedido As New Guna2HtmlLabel With {
            .Name = "lbl_statusPedido",
            .Text = "Em andamento",
            .Font = New Font("Libre Caslon Display", 15),
            .Location = New Point(95, 6),
            .Parent = pnl_pedidoProgresso
        }
        Dim lbl_tempoDecorrido As New Guna2HtmlLabel With {
            .Name = "lbl_numeroPedido",
            .Text = "08:52",
            .Font = New Font("Libre Caslon Display", 10),
            .Location = New Point(95, 39),
            .Parent = pnl_pedidoProgresso
        }

        pedidos.flp_progressoPedidos.Controls.Add(pnl_pedidoProgresso)
    End Sub
End Class