Imports System.IO
Imports Guna.UI2.WinForms

Public Class cardapio
    Private carregado As Boolean = False
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
        gerenciadorCardapio.SubscribeCardapio(AddressOf gerenciadorCardapio.definirNumeroPedido)
        gerenciadorCardapio.SubscribeCardapio(AddressOf gerenciadorCardapio.carregarCardapio)
        cmb_ordenar.SelectedIndex = 0
        carregado = True
        carregarCategorias("cardapio", cmb_ordenar)
        If funcionario.admin = True Then
            btn_addProd.Visible = True
            btn_gerencia.Visible = True
        Else
            btn_gerencia.Visible = False
            btn_addProd.Visible = False
        End If
    End Sub

    Public Sub verificarFuncionario()
        If funcionario.admin = True Then
            btn_addProd.Visible = True
            btn_gerencia.Visible = True
        Else
            btn_gerencia.Visible = False
            btn_addProd.Visible = False
        End If
        gerenciadorCardapio.carregarCardapio()
    End Sub
    Private Sub cmb_numeroMesa_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_numeroMesa.SelectedValueChanged
        gerenciadorCardapio.carregarInformacoesMesa()
    End Sub
    Private Sub btn_addProd_Click(sender As Object, e As EventArgs) Handles btn_addProd.Click
        cadastrarCardapio.Show()
    End Sub

    Private Sub btn_efetuarPedido_Click(sender As Object, e As EventArgs) Handles btn_efetuarPedido.Click
        gerenciadorCardapio.efetuarPedido()
    End Sub

    Private Sub cmb_ordenar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ordenar.SelectedIndexChanged
        '
        If cmb_ordenar.Text = "Mais baratos" Then
            gerenciadorCardapio.carregarCardapio("preco", "ASC")
        ElseIf cmb_ordenar.Text = "Mais caros" Then
            gerenciadorCardapio.carregarCardapio("preco", "DESC")
        ElseIf cmb_ordenar.Text = "Mais pedidos" Then
            gerenciadorCardapio.ordenarCardapio("Mais vendido")
        ElseIf cmb_ordenar.Text = "Menos pedidos" Then
            gerenciadorCardapio.ordenarCardapio("Menos vendido")
        End If

    End Sub

    Private Sub cardapio_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If funcionario.admin = True Then
            btn_addProd.Visible = True
            btn_gerencia.Visible = True
        Else
            btn_gerencia.Visible = False
            btn_addProd.Visible = False
        End If
        carregarFuncionario(btn_info, Guna2CirclePictureBox1)
    End Sub
    Private Sub txt_pesquisaCardapio_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisaCardapio.TextChanged
        If carregado Then gerenciadorCardapio.carregarCardapio(,, txt_pesquisaCardapio.Text)
    End Sub
End Class

Public Class criarCardapio
    Public Class CardapioItem
        Public Property Panel As Guna2ShadowPanel
        Public Property VezesPedido As Integer

        Public Sub New(panel As Guna2ShadowPanel, vezesPedido As Integer)
            Me.Panel = panel
            Me.VezesPedido = vezesPedido
        End Sub
    End Class

    Dim cardapioList As New List(Of CardapioItem)

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
    Public Sub carregarCardapio(Optional orderBy As String = "nome", Optional ascDesc As String = "ASC", Optional pesquisa As String = "")
        abreConexao()
        Try
            sql = "SELECT * FROM tb_cardapio WHERE nome LIKE '" & pesquisa & "%' ORDER BY " & orderBy & " " & ascDesc & ""
            rs = db.Execute(sql)
            count = 0
            cardapio.flp_itemsCard.Controls.Clear()
            cardapioList.Clear()
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
                    .ShadowColor = Color.FromArgb(200, 200, 200),
                    .Tag = rs.Fields(0).Value
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

                If rs.Fields(5).Value IsNot "" Then
                    If File.Exists(Path.Combine(Application.StartupPath, "imgProdutos", rs.Fields(5).Value)) Then
                        Dim fotoProduto As Image = Image.FromFile(Path.Combine(Application.StartupPath, "imgProdutos", rs.Fields(5).Value))
                        If fotoProduto IsNot Nothing Then
                            pbx_fotoPrato.Image = fotoProduto
                        End If
                    End If
                End If

                Dim lbl_nomePrato As New Guna2HtmlLabel() With {
                    .Name = "lbl_nomePrato",
                    .Text = rs.Fields(1).Value,
                    .Font = New Font("Libre Caslon Display", 18),
                    .Location = New Point(19, 143),
                    .AutoSize = False,
                    .Size = New Size(177, 31),
                    .ForeColor = Color.Black,
                    .Parent = pnl_prato
                }

                Dim lbl_vezesPedido As New Guna2HtmlLabel() With {
                    .Text = $"Vezes pedido na semana: {calcularVezesPedido(rs.Fields(0).Value)}",
                    .Font = New Font("Libre Caslon Display", 12),
                    .Location = New Point(19, 176),
                    .ForeColor = Color.FromArgb(127, 127, 127),
                    .Parent = pnl_prato
                }

                Dim lbl_porcentagem As New Guna2HtmlLabel() With {
                    .Text = $"Porcentagem do total: {calcularPorcentagemTotal(rs.Fields(0).Value)}%",
                    .Font = New Font("Libre Caslon Display", 12),
                    .Location = New Point(19, 203),
                    .ForeColor = Color.FromArgb(127, 127, 127),
                    .Parent = pnl_prato
                }

                Dim lbl_preco As New Guna2HtmlLabel() With {
                    .Name = "lbl_preco",
                    .Text = Format(rs.Fields(3).Value, "0.00"),
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
                    .Tag = rs.Fields(0).Value,
                    .Visible = False
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
                    .Tag = rs.Fields(0).Value,
                    .Visible = False
                }
                btn_editar.HoverState.ImageSize = New Size(24, 24)
                btn_editar.PressedState.ImageSize = New Size(28, 28)
                btn_excluir.HoverState.ImageSize = New Size(24, 24)
                btn_excluir.PressedState.ImageSize = New Size(28, 28)

                AddHandler btn_pedir.Click, AddressOf adicionarPratoAoPedido
                AddHandler btn_excluir.Click, AddressOf excluirPratoDoCardapio
                AddHandler btn_editar.Click, AddressOf carregarEdicaoPrato
                cardapioList.Add(New CardapioItem(pnl_prato, calcularVezesPedido(rs.Fields(0).Value)))
                cardapio.flp_itemsCard.Controls.Add(pnl_prato)
                count += 1

                If funcionario.admin = True Then
                    btn_excluir.Visible = True
                    btn_editar.Visible = True
                Else
                    btn_excluir.Visible = False
                    btn_editar.Visible = False
                End If
                rs.MoveNext()
            Loop
            ordenarCardapio()
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar o cardápio!")
            telaErro.Show()
        End Try
    End Sub

    Public Sub ordenarCardapio(Optional tipoSort As String = "Mais Vendido")
        Try
            If tipoSort = "Mais vendido" Then
                cardapioList.Sort(Function(a, b) b.VezesPedido.CompareTo(a.VezesPedido))
            Else
                cardapioList.Sort(Function(a, b) a.VezesPedido.CompareTo(b.VezesPedido))
            End If

            While cardapio.flp_itemsCard.Controls.Count > 0
                cardapio.flp_itemsCard.Controls.RemoveAt(0)
            End While

            For Each item In cardapioList
                cardapio.flp_itemsCard.Controls.Add(item.Panel)
            Next
        Catch ex As Exception

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
            telaErro.setTexto("Erro ao calcular preço total do pedido!")
            telaErro.Show()
        End Try
    End Sub
    Public Sub removerPratoDoPedido(sender As Object, e As EventArgs)
        Dim prato As Control = DirectCast(sender, Control)
        prato.Parent.Dispose()
        RemoveHandler prato.Click, AddressOf removerPratoDoPedido
        calcularPrecoTotal()
    End Sub

    Public Sub cadastrarItemCardapio()
        abreConexao()
        Dim itensList As New List(Of String)
        Dim nomePrato As String = cadastrarCardapio.txt_nome.Text
        Dim categoriaPrato As String = cadastrarCardapio.cmb_categoria.Text
        Dim descricaoPrato As String = cadastrarCardapio.txt_descricao.Text
        Dim custoPrato As String = cadastrarCardapio.txt_custoPrato.Text
        Dim markup As String = cadastrarCardapio.txt_markup.Text
        Dim precoPrato As String = cadastrarCardapio.txt_preco.Text
        Dim dataCadastrado As Date = DateTime.Now
        itensList.Add(nomePrato)
        itensList.Add(categoriaPrato)
        itensList.Add(descricaoPrato)
        itensList.Add(custoPrato)
        itensList.Add(markup)
        itensList.Add(precoPrato)
        Try
            If verificarVazio(itensList) = False Then
                sql = "SELECT * FROM tb_cardapio WHERE nome ='" & nomePrato & "'"
                rs = db.Execute(sql)
                If rs.EOF = True Then
                    sql = "INSERT INTO tb_cardapio (nome, descricao, preco, markup, foto, data_cadastrado, categoria, custo_prato) VALUES ('" & nomePrato & "', '" & descricaoPrato & "', '" & precoPrato & "', '" & markup & "', '" & caminhoImagem & "', '" & dataCadastrado & "', '" & categoriaPrato & "', '" & custoPrato & "')"
                    rs = db.Execute(sql)
                    telaErro.setTexto($"{nomePrato} foi cadastrado com sucesso!")
                    telaErro.Show()
                Else
                    telaErro.setTexto($"{nomePrato} já está cadastrado no estoque!")
                    telaErro.Show()
                End If
            Else
                telaErro.setTexto("Existem campos vazios!")
                telaErro.Show()
            End If
        Catch ex As Exception
            telaErro.setTexto("Erro ao cadastrar prato no cardápio!")
            telaErro.Show()
        End Try
        carregarCardapio()
    End Sub
    Public Function calcularVezesPedido(numeroItem As String)
        abreConexao()
        Try
            Dim total As Integer = 0
            sql2 = "SELECT COUNT(*) FROM tb_itenspedido LEFT JOIN tb_pedidos ON tb_itenspedido.numero_Pedido = tb_pedidos.numero_pedido WHERE tb_itenspedido.numero_item = " & numeroItem & " AND tb_pedidos.horario_pedido >= DateAdd('d', -7, Now()) AND tb_pedidos.horario_pedido < Now() GROUP BY tb_pedidos.horario_pedido, tb_pedidos.numero_pedido"
            rs2 = db.Execute(sql2)
            If rs2.EOF = False Then
                Do While rs2.EOF = False
                    total += rs2.Fields(0).Value
                    rs2.MoveNext()
                Loop
                Return total
            Else
                Return 0
            End If
        Catch ex As Exception
            telaErro.setTexto("Erro ao calcular quantidade de vezes pedido na semana!")
            telaErro.Show()
            Return 0
        End Try
    End Function

    Public Function calcularPorcentagemTotal(numeroItem As String)
        Try
            Dim total As String = 0
            Dim vezesPedido As String = 0
            Dim porcentagem As String = 0
            sql2 = "SELECT tb_pedidos.horario_pedido, COUNT(tb_itenspedido.cod_item) AS total_items_ordered FROM tb_itenspedido LEFT JOIN tb_pedidos ON tb_itenspedido.numero_Pedido = tb_pedidos.numero_pedido WHERE tb_itenspedido.numero_item = " & numeroItem & " AND tb_pedidos.horario_pedido >= DateAdd('d', -7, Now()) AND tb_pedidos.horario_pedido < Now() GROUP BY tb_pedidos.horario_pedido, tb_pedidos.numero_pedido"
            rs2 = db.Execute(sql2)
            If rs2.EOF = False Then
                Do While rs2.EOF = False
                    vezesPedido += rs2.Fields(1).Value
                    rs2.MoveNext()
                Loop
                sql2 = "SELECT COUNT(tb_itenspedido.cod_item) AS total_items FROM tb_itenspedido LEFT JOIN tb_pedidos ON tb_itenspedido.numero_Pedido = tb_pedidos.numero_pedido WHERE tb_pedidos.horario_pedido >= DateAdd('d', -7, Now()) AND tb_pedidos.horario_pedido < Now() GROUP BY tb_pedidos.horario_pedido, tb_pedidos.numero_pedido"
                rs2 = db.Execute(sql2)
                If rs2.EOF = False Then
                    Do While rs2.EOF = False
                        total += rs2.Fields(0).Value
                        rs2.MoveNext()
                    Loop
                    porcentagem = Math.Floor(vezesPedido / total * 100)
                    If Not IsNumeric(porcentagem) Then
                        porcentagem = 0
                    ElseIf total = 0 Then
                        porcentagem = 0
                    End If
                    Return porcentagem
                End If
                Return 0
            End If
            Return 0
        Catch ex As Exception
            telaErro.setTexto("Erro ao calcular porcentagem do total!")
            telaErro.Show()
            Return 0
        End Try
    End Function
    Public Sub carregarEdicaoPrato(sender As Object, e As EventArgs)
        Dim prato As Control = DirectCast(sender, Control)
        Dim itemPrato As Control = prato.Parent
        abreConexao()
        Try
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
                    If File.Exists(Path.Combine(Application.StartupPath, "imgProdutos", rs.Fields(5).Value)) Then
                        .pbx_imagem.Load(Path.Combine(Application.StartupPath, "imgProdutos", rs.Fields(5).Value))
                        caminhoImagem = rs.Fields(5).Value
                    End If
                    .cmb_categoria.SelectedIndex = .cmb_categoria.FindStringExact(rs.Fields(7).Value)
                    .txt_custoPrato.Text = rs.Fields(8).Value
                    .btn_cadastrar.Tag = prato.Tag
                    .Show()
                End If
            End With
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar dados!")
            telaErro.Show()
        End Try
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
                                           sql = "DELETE * FROM tb_itenspedido where numero_item=" & prato.Tag & ""
                                           rs = db.Execute(sql)
                                           gerenciadorCardapio.carregarCardapio()
                                           gerenciadorPedidos.carregarPedidos()
                                           telaConfirmacao.Close()
                                       End Sub)
            Else
                telaErro.setTexto("Prato inválido!")
                telaErro.Show()
            End If
        Catch ex As Exception
            telaErro.setTexto("Erro ao excluir prato!")
            telaErro.Show()
        End Try
    End Sub

    Public Sub editarItemCardapio(itemId)
        abreConexao()
        Dim itensList As New List(Of String)
        Dim nomePrato As String = cadastrarCardapio.txt_nome.Text
        Dim categoriaPrato As String = cadastrarCardapio.cmb_categoria.Text
        Dim descricaoPrato As String = cadastrarCardapio.txt_descricao.Text
        Dim custoPrato As String = cadastrarCardapio.txt_custoPrato.Text
        Dim markup As String = cadastrarCardapio.txt_markup.Text
        Dim precoPrato As String = cadastrarCardapio.txt_preco.Text
        Dim dataEditado As Date = DateTime.Now
        itensList.Add(nomePrato)
        itensList.Add(categoriaPrato)
        itensList.Add(descricaoPrato)
        itensList.Add(custoPrato)
        itensList.Add(markup)
        itensList.Add(precoPrato)
        Try
            If verificarVazio(itensList) = False Then
                sql = "UPDATE tb_cardapio SET foto='" & caminhoImagem & "', nome ='" & nomePrato & "', descricao = '" & descricaoPrato & "', markup = '" & markup & "', custo_prato = '" & custoPrato & "', categoria='" & categoriaPrato & "',  preco='" & precoPrato & "', data_cadastrado='" & dataEditado & "' WHERE numero_item =" & itemId & ""
                rs = db.Execute(sql)
                telaErro.setTexto($"{nomePrato} foi editado com sucesso!")
                telaErro.Show()
                gerenciadorCardapio.carregarCardapio()
            Else
                telaErro.setTexto("Existem campos vazios!")
                telaErro.Show()
            End If
        Catch ex As Exception
            telaErro.setTexto("Erro ao editar item no cardápio!")
            telaErro.Show()
        End Try
        carregarCardapio()
    End Sub
    Public Sub efetuarPedido()
        abreConexao()
        Try
            Dim itensList As New List(Of String)
            Dim numeroMesa As String = cardapio.cmb_numeroMesa.Text
            Dim horarioPedido As DateTime = Now
            Dim valorTotal As Single = cardapio.lbl_total.Text
            Dim codigoFuncionario As Integer = funcionario.codFuncionario
            Dim numeroPedido As Integer = cardapio.lbl_numeroPedido.Text.Substring(1)
            itensList.Add(numeroMesa)
            itensList.Add(horarioPedido)
            itensList.Add(valorTotal)
            itensList.Add(codigoFuncionario)
            itensList.Add(numeroPedido)
            If verificarVazio(itensList) = False Then
                sql = "INSERT INTO tb_pedidos (numero_pedido, numero_mesa, horario_pedido, valor_total, cod_funcionario) VALUES('" & numeroPedido & "', '" & numeroMesa & "', '" & horarioPedido & "', '" & valorTotal & "', '" & codigoFuncionario & "')"
                rs = db.Execute(sql)
                If cardapio.flp_itemsPedido.Controls.Count > 1 Then
                    For Each prato As Control In cardapio.flp_itemsPedido.Controls
                        If prato.Tag IsNot Nothing Then
                            Dim pratoId As Integer = prato.Tag
                            Dim preco As String = 0
                            For Each ctrl As Control In prato.Controls
                                Select Case ctrl.Name
                                    Case "lbl_preco"
                                        preco = ctrl.Text
                                End Select
                            Next
                            sql = "INSERT INTO tb_itensPedido (numero_pedido, numero_item, preco) VALUES ('" & numeroPedido & "', '" & pratoId & "', '" & preco & "')"
                            rs = db.Execute(sql)
                        End If
                    Next
                    telaErro.setTexto("Pedido feito com sucesso!")
                    telaErro.Show()
                    definirNumeroPedido()
                    gerenciadorPedidos.carregarProgresso()
                    gerenciadorPedidos.carregarPedidos(False)
                    carregarCardapio()
                End If
                telaErro.setTexto("Não há itens no pedido!")
                telaErro.Show()
            Else
                telaErro.setTexto("Existem campos vazios!")
                telaErro.Show()
            End If
        Catch ex As Exception
            telaErro.setTexto("Erro ao efetuar pedido!")
            telaErro.Show()
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
    Public Sub carregarInformacoesMesa()
        abreConexao()
        Try
            sql = "SELECT * FROM tb_mesas WHERE mesa = '" & cardapio.cmb_numeroMesa.Text & "'"
            rs = db.Execute(sql)
            cardapio.txt_nomeCliente.Text = rs.Fields(2).Value
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar informações da mesa!")
            telaErro.Show()
        End Try
    End Sub
End Class