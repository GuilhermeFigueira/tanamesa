Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Web.UI.Design

Imports Guna.UI2.WinForms

Public Class cardapio
    Dim cardapio As New criarCardapio
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

    ' Private Sub btn_cardapio_Click(sender As Object, e As EventArgs) Handles btn_cardapio.Click
    '    form_base.Show()
    ' End Sub
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
        cardapio.carregarCardapio()
        'cardapio.carregarPedidos()
    End Sub

    Private Sub btn_info_Click(sender As Object, e As EventArgs) Handles btn_info.Click
        infoUsuario.Show()

    End Sub
End Class
Public Class criarCardapio
    Public Sub carregarCardapio()
        Dim count As Integer
        Do While count < 5
            Dim pnl_prato As New Guna2Panel() With {
                .Name = "pnl_prato",
                .FillColor = Color.White,
                .Size = New Size(270, 285),
                .Padding = New Padding(16, 16, 16, 16),
                .BackColor = Control.DefaultBackColor,
                .BorderRadius = 32,
                .Margin = New Padding(8, 8, 8, 8)
            }

            Dim pbx_fotoPrato As New Guna2PictureBox() With {
                .Name = "pbx_fotoPrato",
                .BackColor = Color.Transparent,
                .FillColor = Color.Transparent,
                .Size = New Size(232, 107),
                .BorderRadius = 12,
                .Location = New Point(19, 19),
                .Parent = pnl_prato,
                .SizeMode = PictureBoxSizeMode.StretchImage,
                .Image = Image.FromFile("C:\Users\guibf\Desktop\Minhas Coisas\Fotos\cachoro sus.png")
            }

            Dim lbl_nomePrato As New Guna2HtmlLabel() With {
                .Name = "lbl_nomePrato",
                .Text = "Arros e feijan",
                .Font = New Font("Libre Caslon Display", 18),
                .Location = New Point(19, 136),
                .ForeColor = Color.Black,
                .Parent = pnl_prato
            }

            Dim lbl_vezesPedido As New Guna2HtmlLabel() With {
                .Text = "Vezes pedido na semana: 10",
                .Font = New Font("Libre Caslon Display", 12),
                .Location = New Point(19, 170),
                .ForeColor = Color.FromArgb(127, 127, 127),
                .Parent = pnl_prato
            }

            Dim lbl_porcentagem As New Guna2HtmlLabel() With {
                .Text = "Porcentagem do total: 48%",
                .Font = New Font("Libre Caslon Display", 12),
                .Location = New Point(19, 197),
                .ForeColor = Color.FromArgb(127, 127, 127),
                .Parent = pnl_prato
            }

            Dim lbl_preco As New Guna2HtmlLabel() With {
                .Name = "lbl_preco",
                .Text = "24,30",
                .Font = New Font("Libre Caslon Display", 18),
                .Location = New Point(19, 235),
                .ForeColor = Color.Black,
                .Parent = pnl_prato
            }

            Dim btn_pedir As New Guna2Button() With {
                .Name = "btn_pedir",
                .Text = "Pedir",
                .Font = New Font("Libre Caslon Display", 18),
                .AutoRoundedCorners = True,
                .Location = New Point(122, 228),
                .ForeColor = Color.White,
                .Size = New Size(129, 40),
                .BackColor = Color.Transparent,
                .FillColor = Color.FromArgb(46, 31, 39),
                .Cursor = Cursors.Hand,
                .Parent = pnl_prato
            }
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
            .Size = New Size(193, 80),
            .Padding = New Padding(16, 16, 16, 16),
            .BackColor = Control.DefaultBackColor,
            .BorderRadius = 8,
            .Margin = New Padding(8, 8, 8, 8)
        }
        Dim pbx_fotoPrato As New Guna2PictureBox() With {
            .Name = "pbx_fotoPrato",
            .BackColor = Color.Transparent,
            .FillColor = Color.Transparent,
            .Size = New Size(62, 62),
            .AutoRoundedCorners = True,
            .Location = New Point(12, 9),
            .Parent = pnl_itemPedido,
            .SizeMode = PictureBoxSizeMode.StretchImage,
            .Image = Image.FromFile("C:\Users\guibf\Desktop\Minhas Coisas\Fotos\cachoro sus.png")
        }
        Dim lbl_nomePrato As New Guna2HtmlLabel() With {
            .Name = "lbl_nomePrato",
            .Text = "Arros e feijan",
            .Font = New Font("Libre Caslon Display", 12),
            .Location = New Point(84, 15),
            .ForeColor = Color.Black,
            .Parent = pnl_itemPedido
        }

        Dim lbl_preco As New Guna2HtmlLabel() With {
            .Name = "lbl_preco",
            .Text = "24,30",
            .Font = New Font("Libre Caslon Display", 12),
            .Location = New Point(84, 42),
            .ForeColor = Color.Black,
            .Parent = pnl_itemPedido
        }

        Dim btn_removerItem As New Guna2ImageButton() With {
            .Name = "btn_removerItem",
            .Location = New Point(144, 33),
            .Size = New Size(36, 38),
            .ImageSize = New Size(18, 18),
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
                    pbx_fotoPrato = ctrl
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