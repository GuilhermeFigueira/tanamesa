Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Web.UI.Design

Imports Guna.UI2.WinForms

Public Class mesas
    Dim mesas As New criarMesas
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        telaConfirmacao.setTexto("Deseja realmente sair?")
        telaConfirmacao.Show()
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_pedidos_Click(sender As Object, e As EventArgs) Handles btn_pedidos.Click
        pedidos.Show()
        Me.Hide()
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

    Private Sub mesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mesas.carregarMesas()
        mesas.atualizarMesa()
    End Sub

End Class

Public Class criarMesas
    Public Sub carregarMesas()
        Dim count As Integer = 1
        Do While count <= 21
            Dim pnl_mesa As New Guna2Panel() With {
                .Name = "pnl_mesa",
                .FillColor = Color.White,
                .Size = New Size(155, 80),
                .Margin = New Padding(8, 6, 8, 6),
                .BackColor = Control.DefaultBackColor,
                .CustomBorderColor = Color.FromArgb(48, 107, 52),
                .CustomBorderThickness = New Padding(15, 0, 0, 0),
                .BorderRadius = 8
            }
            pnl_mesa.ShadowDecoration.BorderRadius = 8
            pnl_mesa.ShadowDecoration.Enabled = True
            pnl_mesa.ShadowDecoration.Depth = 20
            pnl_mesa.ShadowDecoration.Color = Color.FromArgb(200, 200, 200)

            Dim lbl_numeroMesa As New Guna2HtmlLabel() With {
                .Name = "lbl_numeroMesa",
                .Text = "Mesa " & count,
                .Font = New Font("Julius Sans One", 16),
                .ForeColor = Color.FromArgb(127, 127, 127),
                .Parent = pnl_mesa,
                .Location = New Point(23, 13)
            }

            Dim lbl_statusMesa As New Guna2HtmlLabel() With {
                .Name = "lbl_statusMesa",
                .Text = "Livre",
                .Font = New Font("Libre Caslon Display", 14),
                .ForeColor = Color.FromArgb(46, 31, 39),
                .Parent = pnl_mesa,
                .Location = New Point(23, 52)
            }

            AddHandler pnl_mesa.Click, AddressOf atualizarMesa
            mesas.flp_mesas.Controls.Add(pnl_mesa)
            count += 1
        Loop

    End Sub
    Public Sub atualizarMesa()
        Dim pnl_pedido As New Guna2Panel With {
            .Name = "pnl_pedido",
            .BackColor = Color.FromArgb(239, 239, 239),
            .FillColor = Color.White,
            .Padding = New Padding(16, 16, 16, 16),
            .Size = New Size(250, 40),
            .BorderRadius = 8
        }
        Dim lbl_nomePedido As New Guna2HtmlLabel() With {
            .Name = "lbl_nomePedido",
            .Text = "Nome do prato",
            .Font = New Font("Libre Caslon Display", 12),
            .Location = New Point(19, 9),
            .ForeColor = Color.FromArgb(127, 127, 127),
            .Parent = pnl_pedido
        }
        Dim lbl_preco As New Guna2HtmlLabel() With {
            .Name = "lbl_preco",
            .Text = "R$ 24,90",
            .Font = New Font("Libre Caslon Display", 12),
            .Location = New Point(163, 9),
            .ForeColor = Color.FromArgb(127, 127, 127),
            .Parent = pnl_pedido
        }
        mesas.flp_itemsPedido.Controls.Add(pnl_pedido)
    End Sub
End Class
