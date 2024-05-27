Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Web.UI.Design

Imports Guna.UI2.WinForms

Public Class mesas
    Dim gerenciarMesas As New criarMesas
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        sair()
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
        estoque.Show()
        Me.Hide()
    End Sub

    Private Sub btn_gerencia_Click(sender As Object, e As EventArgs) Handles btn_gerencia.Click
        gerencia.Show()
        Me.Hide()
    End Sub

    Private Sub btn_info_Click(sender As Object, e As EventArgs) Handles btn_info.Click
        infoUsuario.Show()

    End Sub

    Private Sub mesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gerenciarMesas.carregarMesas()
        gerenciarMesas.atualizarMesa()
        carregarMesas(cmb_numeroMesa, "Ocupada", "Livre")
    End Sub

End Class

Public Class criarMesas
    Public Sub carregarMesas()
        Try
            sql = "SELECT * FROM tb_mesas"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                Dim corMesa As Color
                If rs.Fields(1).Value = "Livre" Then
                    corMesa = Color.FromArgb(48, 107, 52)
                Else
                    corMesa = Color.FromArgb(0, 0, 0)
                End If
                Dim pnl_mesa As New Guna2Panel() With {
                .Name = "pnl_mesa",
                .FillColor = Color.White,
                .Size = New Size(155, 80),
                .Margin = New Padding(8, 6, 8, 6),
                .BackColor = Control.DefaultBackColor,
                .CustomBorderColor = corMesa,
                .CustomBorderThickness = New Padding(15, 0, 0, 0),
                .BorderRadius = 8,
                .Cursor = Cursors.Hand,
                .Tag = rs.Fields(0).Value
                }
                pnl_mesa.ShadowDecoration.BorderRadius = 8
                pnl_mesa.ShadowDecoration.Enabled = True
                pnl_mesa.ShadowDecoration.Depth = 20
                pnl_mesa.ShadowDecoration.Color = Color.FromArgb(200, 200, 200)

                Dim lbl_numeroMesa As New Guna2HtmlLabel() With {
                .Name = "lbl_numeroMesa",
                .Text = "Mesa " & rs.Fields(0).Value,
                .Font = New Font("Julius Sans One", 16),
                .ForeColor = Color.FromArgb(127, 127, 127),
                .Parent = pnl_mesa,
                .Location = New Point(23, 13)
                }


                Dim lbl_statusMesa As New Guna2HtmlLabel() With {
                    .Name = "lbl_statusMesa",
                    .Text = rs.Fields(1).Value,
                    .Font = New Font("Libre Caslon Display", 14),
                    .ForeColor = Color.FromArgb(46, 31, 39),
                    .Parent = pnl_mesa,
                    .Location = New Point(23, 52)
                }

                AddHandler pnl_mesa.Click, AddressOf atualizarMesa
                mesas.flp_mesas.Controls.Add(pnl_mesa)
                count += 1
                rs.MoveNext()
            Loop
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar as mesas!")
            telaErro.Show()
        End Try
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
