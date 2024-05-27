Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Web.UI.Design

Imports Guna.UI2.WinForms

Public Class cardapio
    Dim gerenciadorCardapio As New criarCardapio
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

    Private Sub btn_mesas_Click(sender As Object, e As EventArgs) Handles btn_mesas.Click
        mesas.Show()
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


    Private Sub cardapio_Load(sender As Object, e As EventArgs) Handles Me.Load
        gerenciadorCardapio.carregarCardapio()
        'cardapio.carregarPedidos()
    End Sub

    Private Sub btn_addProd_Click(sender As Object, e As EventArgs) Handles btn_addProd.Click
        cadastrarCardapio.Show()
    End Sub
End Class
Public Class criarCardapio
    Public Delegate Sub ObserverFunction(ByVal command As Object)

    Private observers As New List(Of Action(Of Object))()

    Public Sub SubscribeCardapio(observerAction As Action(Of Object))
        observers.Add(observerAction)
    End Sub

    Public Sub NotifyAllCardapio(command As Object)
        For Each observerAction In observers
            observerAction.Invoke(command)
        Next
    End Sub
    Public Sub carregarCardapio()
        abreConexao()
        Try
            sql = "SELECT * FROM tb_cardapio ORDER BY nome ASC"
            rs = db.Execute(sql)
            count = 0
            Do While rs.EOF = False
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
                    .Image = Image.FromFile(Path.Combine(Application.StartupPath, "imgProdutos", rs.Fields(5).Value)),
                    .Dock = DockStyle.Top
                }

                Dim lbl_nomePrato As New Guna2HtmlLabel() With {
                    .Name = "lbl_nomePrato",
                    .Text = rs.Fields(1).Value,
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
                    .Text = rs.Fields(3).Value,
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
                    .Parent = pnl_prato,
                    .Tag = rs.Fields(0).Value
                }

                Dim btn_editar As New Guna2ImageButton() With {
                    .Name = "btn_editar",
                    .Location = New Point(226, 137),
                    .Size = New Size(36, 38),
                    .ImageSize = New Size(26, 26),
                    .BackColor = Color.Transparent,
                    .Cursor = Cursors.Hand,
                    .Parent = pnl_prato,
                    .Image = Image.FromFile(Application.StartupPath & "\imgs\pencil-line.png"),
                    .Tag = rs.Fields(0).Value
                }

                Dim btn_excluir As New Guna2ImageButton() With {
                    .Name = "btn_editar",
                    .Location = New Point(190, 137),
                    .Size = New Size(36, 38),
                    .ImageSize = New Size(26, 26),
                    .BackColor = Color.Transparent,
                    .Cursor = Cursors.Hand,
                    .Parent = pnl_prato,
                    .Image = Image.FromFile(Application.StartupPath & "\imgs\trash-2.png"),
                    .Tag = rs.Fields(0).Value
                }
                btn_editar.HoverState.ImageSize = New Size(24, 24)
                btn_editar.PressedState.ImageSize = New Size(28, 28)
                AddHandler btn_pedir.Click, AddressOf adicionarPratoAoPedido
                cardapio.flp_itemsCard.Controls.Add(pnl_prato)
                count += 1
                rs.MoveNext()
            Loop
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar pratos!")
            telaErro.Show()
            MessageBox.Show(String.Format("Error editar item estoque: {0}", ex.Message))
        End Try
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

    Public Sub cadastrarItemCardapio()
        abreConexao()
        Dim itensList As New List(Of String)
        Dim nomeItem As String = cadastrarEstoque.txt_nome.Text
        Dim categoriaItem As String = cadastrarEstoque.cmb_categoria.Text
        Dim unidadeItem As String = cadastrarEstoque.cmb_unidade.Text
        Dim qtdComprada As String = cadastrarEstoque.txt_qtd.Text
        Dim valorPagoUnidade As String = cadastrarEstoque.txt_vlrUnidade.Text
        Dim dataCompra As String = cadastrarEstoque.dtp_dataCompra.Value.Date
        Dim dataValidade As String = cadastrarEstoque.dtp_dataValidade.Value.Date
        itensList.Add(nomeItem)
        itensList.Add(categoriaItem)
        itensList.Add(unidadeItem)
        itensList.Add(qtdComprada)
        itensList.Add(valorPagoUnidade)
        itensList.Add(dataCompra)
        itensList.Add(dataValidade)
        Try
            If verificarVazio(itensList) = False Then
                sql = "SELECT * FROM tb_estoque WHERE nome ='" & nomeItem & "'"
                rs = db.Execute(sql)
                If rs.EOF = True Then
                    sql = "INSERT INTO tb_estoque (foto, nome, categoria, em_estoque, unidade, valor_pago, data_compra, data_validade) VALUES ('" & caminhoImagem & "', '" & nomeItem & "', '" & categoriaItem & "', '" & qtdComprada & "', '" & unidadeItem & "', '" & valorPagoUnidade & "', '" & dataCompra & "', '" & dataValidade & "')"
                    rs = db.Execute(sql)
                    telaErro.setTexto($"{nomeItem} foi cadastrado com sucesso!")
                    telaErro.Show()
                Else
                    telaErro.setTexto($"{nomeItem} já está cadastrado no estoque!")
                    telaErro.Show()
                End If
            Else
                telaErro.setTexto("Existem campos vazios!")
                telaErro.Show()
            End If
        Catch ex As Exception
            telaErro.setTexto("Erro ao cadastrar item no estoque!")
            telaErro.Show()
            'MessageBox.Show(String.Format("Error: {0}", sql))
        End Try
        'NotifyAll({})
    End Sub
    Public Sub carregarEdicaoPrato(itemId As Integer)
        abreConexao()
        Try
            carregarCategorias()
            carregarUnidades(cadastrarEstoque.cmb_unidade)
            sql = "SELECT * FROM tb_estoque WHERE id_item =" & itemId & " "
            rs = db.Execute(sql)
            With cadastrarEstoque
                If rs.EOF = False Then
                    .alterarTipoFormEstoque("Editar produto no Estoque", "Editar Produto")
                    .txt_nome.Text = rs.Fields(2).Value
                    .cmb_categoria.SelectedIndex = .cmb_categoria.FindStringExact(rs.Fields(3).Value)
                    .cmb_unidade.SelectedIndex = .cmb_unidade.FindStringExact(rs.Fields(5).Value)
                    .lbl_qtdComprada.Text = "Quantidade em Estoque"
                    .txt_qtd.Text = rs.Fields(4).Value
                    .txt_vlrUnidade.Text = rs.Fields(6).Value
                    .dtp_dataCompra.Value = rs.Fields(7).Value
                    .dtp_dataValidade.Text = rs.Fields(8).Value
                    .btn_cadastrar.Tag = itemId
                    .pbx_imagem.Load(Path.Combine(Application.StartupPath, "imgProdutos", rs.Fields(1).Value))
                    .Show()
                End If
            End With
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar dados!")
            telaErro.Show()
            'MessageBox.Show(String.Format("Error editar item estoque: {0}", ex.Message))
        End Try
        NotifyAll({})
    End Sub
End Class