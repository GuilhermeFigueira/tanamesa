﻿Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Web.UI.Design

Imports Guna.UI2.WinForms

Public Class cardapio
    Dim cardapio As New criarCardapio
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

    Private Sub btn_mesas_Click(sender As Object, e As EventArgs) Handles btn_mesas.Click
        mesas.Show()
        Me.Hide()
    End Sub

    Private Sub btn_estoque_Click(sender As Object, e As EventArgs) Handles btn_estoque.Click
        estoque.Show()
        Me.Hide()
    End Sub

    Private Sub btn_gerencia_Click(sender As Object, e As EventArgs) Handles btn_gerencia.Click
        'gerencia.Show()
        Me.Hide()
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles Me.Load
        cardapio.carregarCardapio()
        'cardapio.carregarPedidos()
    End Sub

    Private Sub btn_info_Click(sender As Object, e As EventArgs) Handles btn_info.Click
        infoUsuario.Show()
    End Sub

    Private Sub Guna2Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel5.Paint

    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click

    End Sub
End Class
Public Class criarCardapio
    Public Sub carregarCardapio()
        Dim count As Integer
        Do While count < 5
            Dim pnl_prato As New Guna2ShadowPanel() With {
                .Name = "pnl_prato",
                .FillColor = Color.White,
                .Size = New Size(280, 300),
                .Margin = New Padding(6, 3, 6, 3),
                .BackColor = Control.DefaultBackColor,
                .Radius = 10,
                .ShadowShift = 4,
                .Padding = New Padding(16, 24, 16, 24),
                .ShadowColor = Color.FromArgb(200, 200, 200)
            }

            Dim pbx_fotoPrato As New Guna2PictureBox() With {
                .Name = "pbx_fotoPrato",
                .BackColor = Color.Transparent,
                .FillColor = Color.Transparent,
                .BorderRadius = 12,
                .Size = New Size(233, 107),
                .Parent = pnl_prato,
                .SizeMode = PictureBoxSizeMode.StretchImage,
                .Image = Image.FromFile(Application.StartupPath & "/imgs/download.jpg"),
                .Dock = DockStyle.Top
            }

            Dim lbl_nomePrato As New Guna2HtmlLabel() With {
                .Name = "lbl_nomePrato",
                .Text = "Arros e feijan",
                .Font = New Font("Libre Caslon Display", 18),
                .Location = New Point(19, 143),
                .ForeColor = Color.Black,
                .Parent = pnl_prato
            }

            Dim lbl_vezesPedido As New Guna2HtmlLabel() With {
                .Text = "Vezes pedido na semana: 10",
                .Font = New Font("Libre Caslon Display", 12),
                .Location = New Point(19, 176),
                .ForeColor = Color.FromArgb(127, 127, 127),
                .Parent = pnl_prato
            }

            Dim lbl_porcentagem As New Guna2HtmlLabel() With {
                .Text = "Porcentagem do total: 48%",
                .Font = New Font("Libre Caslon Display", 12),
                .Location = New Point(19, 203),
                .ForeColor = Color.FromArgb(127, 127, 127),
                .Parent = pnl_prato
            }

            Dim lbl_preco As New Guna2HtmlLabel() With {
                .Name = "lbl_preco",
                .Text = "24,30",
                .Font = New Font("Libre Caslon Display", 18),
                .Location = New Point(19, 245),
                .ForeColor = Color.Black,
                .Parent = pnl_prato
            }

            Dim btn_pedir As New Guna2Button() With {
                .Name = "btn_pedir",
                .Text = "Pedir",
                .Font = New Font("Libre Caslon Display", 16),
                .AutoRoundedCorners = True,
                .Location = New Point(150, 245),
                .ForeColor = Color.White,
                .Size = New Size(115, 35),
                .BackColor = Color.Transparent,
                .FillColor = Color.FromArgb(46, 31, 39),
                .Cursor = Cursors.Hand,
                .Parent = pnl_prato
            }

            Dim btn_editar As New Guna2ImageButton() With {
                .Name = "btn_editar",
                .Location = New Point(226, 137),
                .Size = New Size(36, 38),
                .ImageSize = New Size(26, 26),
                .BackColor = Color.Transparent,
                .Cursor = Cursors.Hand,
                .Parent = pnl_prato,
                .Image = Image.FromFile(Application.StartupPath & "\imgs\pencil-line.png")
            }
            btn_editar.HoverState.ImageSize = New Size(24, 24)
            btn_editar.PressedState.ImageSize = New Size(28, 28)
            AddHandler btn_pedir.Click, AddressOf adicionarPratoAoPedido
            cardapio.flp_itemsCard.Controls.Add(pnl_prato)
            count += 1
        Loop

    End Sub
    Public Sub adicionarPratoAoPedido(sender As Object, e As EventArgs)
        Dim prato As Control = DirectCast(sender, Control)
        Dim itemPrato As Control = prato.Parent

        Dim pnl_itemPedido As New Guna2Panel() With {
            .Name = "pnl_itemPedido",
            .FillColor = Color.White,
            .Size = New Size(210, 80),
            .Padding = New Padding(16, 16, 16, 16),
            .BackColor = Control.DefaultBackColor,
            .BorderRadius = 8,
            .Margin = New Padding(4, 4, 4, 4)
        }
        Dim pbx_fotoPrato As New Guna2PictureBox() With {
            .Name = "pbx_fotoPrato",
            .BackColor = Color.Transparent,
            .FillColor = Color.Transparent,
            .Size = New Size(56, 56),
            .AutoRoundedCorners = True,
            .Location = New Point(8, 12),
            .Parent = pnl_itemPedido,
            .SizeMode = PictureBoxSizeMode.StretchImage
        }
        Dim lbl_nomePrato As New Guna2HtmlLabel() With {
            .Name = "lbl_nomePrato",
            .Text = "Arros e feijan",
            .Font = New Font("Libre Caslon Display", 12),
            .Location = New Point(70, 18),
            .ForeColor = Color.Black,
            .Parent = pnl_itemPedido
        }

        Dim lbl_preco As New Guna2HtmlLabel() With {
            .Name = "lbl_preco",
            .Text = "24,30",
            .Font = New Font("Libre Caslon Display", 12),
            .Location = New Point(70, 45),
            .ForeColor = Color.Black,
            .Parent = pnl_itemPedido
        }

        Dim btn_removerItem As New Guna2ImageButton() With {
            .Name = "btn_removerItem",
            .Location = New Point(169, 30),
            .Size = New Size(36, 38),
            .ImageSize = New Size(26, 26),
            .BackColor = Color.Transparent,
            .Cursor = Cursors.Hand,
            .Parent = pnl_itemPedido,
            .Image = Image.FromFile(Application.StartupPath & "\imgs\trash.png")
        }
        btn_removerItem.HoverState.ImageSize = New Size(24, 24)
        btn_removerItem.PressedState.ImageSize = New Size(28, 28)
        AddHandler btn_removerItem.Click, AddressOf removerPratoDoPedido
        cardapio.flp_itemsPedido.Controls.Add(pnl_itemPedido)

        For Each ctrl As Control In itemPrato.Controls
            Select Case ctrl.Name
                Case "pbx_fotoPrato"
                    Dim image As Guna2PictureBox
                    image = ctrl
                    pbx_fotoPrato.Image = image.Image
                Case "lbl_nomePrato"
                    lbl_nomePrato.Text = ctrl.Text
                Case "lbl_preco"
                    lbl_preco.Text = ctrl.Text
            End Select
        Next ctrl
        'MessageBox.Show(String.Format("{0}", ctrl))
    End Sub
    Public Sub removerPratoDoPedido(sender As Object, e As EventArgs)
        Dim prato As Control = DirectCast(sender, Control)
        DirectCast(prato.Parent, Control).Dispose()
        RemoveHandler prato.Click, AddressOf removerPratoDoPedido
    End Sub
End Class