Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Web.UI.Design
Imports Guna.UI2.WinForms

Public Class pedidos
    Dim pedidos As New criarPedidos
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        telaConfirmacao.setTexto("Deseja realmente sair?")
        telaConfirmacao.Show()
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
        pedidos.carregarPedidos()
    End Sub
End Class

Public Class criarPedidos
    Sub carregarProgresso()
        Dim count As Integer
        Do While count < 10
            Dim pnl_pedidoProgresso As New Guna2ShadowPanel With {
                .Name = "pnl_pedidoProgresso",
                .FillColor = Color.FromArgb(244, 187, 108),
                .Size = New Size(254, 70),
                .BackColor = Color.Transparent,
                .Radius = 6,
                .ShadowColor = Color.FromArgb(200, 200, 200),
                .ShadowShift = 6,
                .ShadowStyle = Guna2ShadowPanel.ShadowMode.ForwardDiagonal
            }

            Dim lbl_numeroPedido As New Guna2HtmlLabel With {
                .Name = "lbl_numeroPedido",
                .Text = "#12",
                .Font = New Font("Julius Sans One", 25),
                .Location = New Point(20, 16),
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
                .Text = "Tempo decorrido: 08:52",
                .Font = New Font("Libre Caslon Display", 10),
                .Location = New Point(95, 39),
                .Parent = pnl_pedidoProgresso
            }

            pedidos.flp_progressoPedidos.Controls.Add(pnl_pedidoProgresso)
            count += 1
        Loop
    End Sub

    Sub carregarPedidos()
        Dim count As Integer
        Do While count < 10
            Dim pnl_pedido As New Guna2ShadowPanel With {
                .Name = "pnl_pedido",
                .FillColor = Color.White,
                .Size = New Size(273, 329),
                .BackColor = Color.Transparent,
                .Radius = 6,
                .ShadowColor = Color.FromArgb(200, 200, 200),
                .ShadowShift = 2,
                .Padding = New Padding(8)
            }

            Dim pnl_info As New Guna2Panel With {
                .Name = "pnl_info",
                .FillColor = Color.White,
                .Size = New Size(241, 62),
                .BackColor = Color.Transparent,
                .Dock = DockStyle.Top,
                .Parent = pnl_pedido
            }

            Dim lbl_nomeCliente As New Guna2HtmlLabel With {
                .Name = "lbl_nomeCliente",
                .Text = "Nome do Cliente",
                .Font = New Font("Libre Caslon Display", 14),
                .Location = New Point(2, 4),
                .Parent = pnl_info
            }

            Dim lbl_numeroMesa As New Guna2HtmlLabel With {
                .Name = "lbl_numeroMesa",
                .Text = "Mesa 01",
                .Font = New Font("Libre Caslon Display", 12),
                .Location = New Point(2, 31),
                .Parent = pnl_info
            }

            Dim lbl_numeroPedido As New Guna2HtmlLabel With {
                .Name = "lbl_numeroPedido",
                .Text = "#12",
                .Font = New Font("Julius Sans One", 25),
                .Location = New Point(138, 13),
                .Parent = pnl_info
            }

            Dim flp_itensPedido As New FlowLayoutPanel With {
                .Name = "flp_itensPedido",
                .Dock = DockStyle.Fill,
                .Parent = pnl_pedido,
                .AutoScroll = True,
            .Padding = New Padding(8),
            .Size = New Size(241, 198)
            }
            '.BackColor = Color.White,

            Dim pnl_itemDoPedido As New Guna2Panel With {
                .FillColor = Color.FromArgb(239, 239, 239),
                .Margin = New Padding(4),
                .Size = New Size(210, 40),
                .BorderRadius = 12,
                .BackColor = Color.White,
                .Parent = flp_itensPedido
            }

            Dim lbl_nomeItem As New Guna2HtmlLabel With {
                .Name = "lbl_nomeItem",
                .ForeColor = Color.FromArgb(127, 127, 127),
                .Font = New Font("Libre Caslon Display", 12),
                .Location = New Point(11, 9),
                .Parent = pnl_itemDoPedido
            }

            Dim cbx_concluido As New Guna2CheckBox With {
                .CheckMarkColor = Color.FromArgb(127, 127, 127),
                .Location = New Point(155, 12),
                .Size = New Size(15, 17),
                .Parent = pnl_itemDoPedido
            }
            cbx_concluido.CheckedState.BorderColor = Color.FromArgb(127, 127, 127)
            cbx_concluido.CheckedState.BorderRadius = 2
            cbx_concluido.CheckedState.BorderThickness = 1
            cbx_concluido.CheckedState.FillColor = Color.FromArgb(239, 239, 239)
            cbx_concluido.UncheckedState.BorderColor = Color.FromArgb(127, 127, 127)
            cbx_concluido.UncheckedState.BorderRadius = 2
            cbx_concluido.UncheckedState.BorderThickness = 1
            cbx_concluido.UncheckedState.FillColor = Color.FromArgb(239, 239, 239)

            Dim btn_removerItem As New Guna2ImageButton() With {
            .Name = "btn_removerItem",
            .Location = New Point(176, 7),
            .Size = New Size(25, 25),
            .ImageSize = New Size(20, 20),
            .BackColor = Color.Transparent,
            .Cursor = Cursors.Hand,
            .Parent = pnl_itemDoPedido,
            .Image = Image.FromFile(Application.StartupPath & "\imgs\trash.png")
        }

            pedidos.flp_pedidos.Controls.Add(pnl_pedido)
            pnl_pedido.Controls.Add(flp_itensPedido)
            count += 1
        Loop
    End Sub
End Class