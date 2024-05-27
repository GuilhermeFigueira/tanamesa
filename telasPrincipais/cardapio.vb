Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Web.UI.Design

Imports Guna.UI2.WinForms

Public Class cardapio
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
        gerenciadorCardapio.calcularPrecoTotal()
        gerenciadorCardapio.definirNumeroPedido()
        carregarMesas(cmb_numeroMesa, "Ocupada", "Ocupada")
        gerenciadorCardapio.SubscribeCardapio(AddressOf gerenciadorCardapio.carregarCardapio)
        'cardapio.carregarPedidos()
    End Sub

    Private Sub btn_addProd_Click(sender As Object, e As EventArgs) Handles btn_addProd.Click
        cadastrarCardapio.Show()
    End Sub

    Private Sub cmb_numeroMesa_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_numeroMesa.SelectedValueChanged
        gerenciadorCardapio.carregarInformacoesMesa(cmb_numeroMesa.Text, txt_nomeCliente)
    End Sub

    Private Sub btn_efetuarPedido_Click(sender As Object, e As EventArgs) Handles btn_efetuarPedido.Click
        gerenciadorCardapio.efetuarPedido()
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
            cardapio.flp_itemsCard.Controls.Clear()
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
                    .Image = Image.FromFile(Application.StartupPath & "\imgs\trash.png"),
                    .Tag = rs.Fields(0).Value
                }
                btn_editar.HoverState.ImageSize = New Size(24, 24)
                btn_editar.PressedState.ImageSize = New Size(28, 28)
                btn_excluir.HoverState.ImageSize = New Size(24, 24)
                btn_excluir.PressedState.ImageSize = New Size(28, 28)
                AddHandler btn_pedir.Click, AddressOf adicionarPratoAoPedido
                AddHandler btn_excluir.Click, AddressOf excluirPratoDoCardapio
                AddHandler btn_editar.Click, AddressOf carregarEdicaoPrato
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
            .Margin = New Padding(4, 4, 4, 4),
            .Tag = prato.Tag
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
        calcularPrecoTotal()
        'MessageBox.Show(String.Format("{0}", ctrl))
    End Sub
    Public Sub calcularPrecoTotal()
        Try
            Dim total As Single
            For Each prato As Control In cardapio.flp_itemsPedido.Controls
                For Each ctrl As Control In prato.Controls
                    Select Case ctrl.Name
                        Case "lbl_preco"
                            total += ctrl.Text
                    End Select
                Next
            Next
            cardapio.lbl_total.Text = $"R$ {total.ToString("N2")}"
        Catch ex As Exception
            telaErro.setTexto("Erro ao calcular preço!")
            telaErro.Show()
        End Try
    End Sub
    Public Sub removerPratoDoPedido(sender As Object, e As EventArgs)
        Dim prato As Control = DirectCast(sender, Control)
        DirectCast(prato.Parent, Control).Dispose()
        RemoveHandler prato.Click, AddressOf removerPratoDoPedido
        calcularPrecoTotal()
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
        NotifyAllCardapio({})
    End Sub
    Public Sub carregarEdicaoPrato(sender As Object, e As EventArgs)
        Dim prato As Control = DirectCast(sender, Control)
        Dim itemPrato As Control = prato.Parent
        abreConexao()
        Try
            limparForm(cadastrarCardapio)
            carregarCategorias("cardapio", cadastrarCardapio.cmb_categoria)
            sql = "SELECT * FROM tb_cardapio WHERE numero_item =" & prato.Tag & " "
            rs = db.Execute(sql)
            With cadastrarCardapio
                If rs.EOF = False Then
                    .alterarTipoFormCardapio("Editar Prato no Cardápio", "Editar Prato")
                    .txt_nome.Text = rs.Fields(1).Value
                    .txt_descricao.Text = rs.Fields(2).Value
                    .txt_preco.Text = rs.Fields(3).Value
                    .txt_markup.Text = rs.Fields(4).Value
                    .pbx_imagem.Load(Path.Combine(Application.StartupPath, "imgProdutos", rs.Fields(5).Value))
                    .cmb_categoria.SelectedIndex = .cmb_categoria.FindStringExact(rs.Fields(7).Value)
                    .txt_custoPrato.Text = rs.Fields(8).Value
                    .btn_cadastrar.Tag = prato.Tag
                    .Show()
                End If
            End With
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar dados!")
            telaErro.Show()
            'MessageBox.Show(String.Format("Error editar item estoque: {0}", ex.Message))
        End Try
        NotifyAllCardapio({})
    End Sub
    Public Sub excluirPratoDoCardapio(sender As Object, e As EventArgs)
        Dim prato As Control = DirectCast(sender, Control)
        Dim itemPrato As Control = prato.Parent
        abreConexao()
        Try
            sql = "SELECT * FROM tb_cardapio WHERE numero_item =" & prato.Tag & ""
            rs = db.Execute(sql)
            If rs.EOF = False Then
                telaConfirmacao.setTexto($"Deseja realmente apagar o item {rs.Fields(1).Value}?")
                telaConfirmacao.Show()
                telaConfirmacao.setSub(Sub()
                                           sql = "DELETE * FROM tb_cardapio where numero_item=" & prato.Tag & ""
                                           rs = db.Execute(sql)
                                           gerenciadorEstoque.NotifyAllEstoque({})
                                           telaConfirmacao.Close()
                                           gerenciadorCardapio.NotifyAllCardapio({})
                                       End Sub)
            Else
                telaErro.setTexto("Prato inválido!")
                telaErro.Show()
            End If
        Catch ex As Exception
            telaErro.setTexto("Erro ao excluir prato!")
            telaErro.Show()
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Public Sub efetuarPedido()
        abreConexao()
        Try
            sql = "SELECT TOP 1 * FROM tb_pedidos ORDER BY numero_pedido DESC"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                Dim itensList As New List(Of String)
                Dim numeroMesa As Integer = cardapio.cmb_numeroMesa.Text
                Dim horarioPedido As DateTime = TimeOfDay
                Dim valorTotal As Single = cardapio.lbl_total.Text
                Dim codigoFuncionario As Integer = 1
                Dim numeroPedido As Integer = rs.Fields(0).Value + 1
                itensList.Add(numeroMesa)
                itensList.Add(horarioPedido)
                itensList.Add(valorTotal)
                itensList.Add(codigoFuncionario)
                itensList.Add(numeroPedido)
                If verificarVazio(itensList) = False Then
                    sql = "INSERT INTO tb_pedidos (numero_pedido, numero_mesa, horario_pedido, valor_total, cod_funcionario) VALUES('" & numeroPedido & "', '" & numeroMesa & "', '" & horarioPedido & "', '" & valorTotal & "', '" & codigoFuncionario & "')"
                    rs = db.Execute(sql)
                    For Each prato As Control In cardapio.flp_itemsPedido.Controls
                        If prato.Tag IsNot Nothing Then
                            Dim pratoId As Integer = prato.Tag
                            'sql = "INSERT INTO tb_itensPedido (numero_pedido, numero_item, preco) VALUES ('" & numeroPedido & "', '" & pratoId & "', '" & preco & "')"
                            'rs = db.Execute(sql)
                        End If
                    Next
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Public Sub definirNumeroPedido()
        abreConexao()
        Try
            Dim numeroPedido As Integer
            sql = "SELECT TOP 1 * FROM tb_pedidos ORDER BY numero_pedido DESC"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                numeroPedido = rs.Fields(0).Value + 1
            Else
                numeroPedido = 1
            End If
            cardapio.lbl_numeroPedido.Text = $"#{numeroPedido}"
        Catch ex As Exception
            telaErro.setTexto("Erro ao definir o numero do pedido!")
            telaErro.Show()
        End Try
    End Sub
    Public Sub carregarInformacoesMesa(numeroMesa As Integer, txt As Guna.UI2.WinForms.Guna2TextBox)
        abreConexao()
        Try
            sql = "SELECT * FROM tb_mesas WHERE mesa = " & numeroMesa & ""
            rs = db.Execute(sql)
            txt.Text = rs.Fields(2).Value
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar dados!")
            telaErro.Show()
        End Try
    End Sub
    Function verificarVazio(itensArray As List(Of String))
        For Each item As String In itensArray
            If item = "" Then
                Return True
            End If
        Next
        Return False
    End Function
End Class