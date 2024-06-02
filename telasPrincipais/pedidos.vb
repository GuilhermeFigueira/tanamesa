Imports Guna.UI2.WinForms

Public Class pedidos
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        sair()
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

    Private Sub btn_mesas_Click(sender As Object, e As EventArgs) Handles btn_mesas.Click
        mesas.Show()
        Me.Hide()
    End Sub

    Private Sub pedidos_Load(sender As Object, e As EventArgs) Handles Me.Load
        gerenciadorPedidos.carregarProgresso()
        gerenciadorPedidos.carregarPedidos(False)
        cmb_progs.SelectedIndex = 0
        gerenciadorPedidos.SubscribePedidos(AddressOf gerenciadorPedidos.carregarProgresso)
    End Sub

    Private Sub cmb_progs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_progs.SelectedIndexChanged
        If cmb_progs.Text = "Pedidos Não Entregues" Then
            gerenciadorPedidos.carregarPedidos(False)
        Else
            gerenciadorPedidos.carregarPedidos(True)
        End If
    End Sub
End Class

Public Class criarPedidos
    Public Delegate Sub ObserverFunction(ByVal command As Object)

    Private observers As New List(Of Action(Of Object))()

    Public Sub SubscribePedidos(observerAction As Action(Of Object))
        observers.Add(observerAction)
    End Sub

    Public Sub NotifyAllPedidos(command As Object)
        For Each observerAction In observers
            observerAction.Invoke(command)
        Next
    End Sub

    Private _elapseTimerRunning As Boolean = False
    Private _elapseStartTime As DateTime

    Public Sub timerTick(sender As Object, e As EventArgs)
        Dim pedido As Control = DirectCast(sender, Control)

        txtTime.Text = Now.ToString("h:mm:ss tt")
        If _elapseTimerRunning = True Then
            Dim elapsedtime = DateTime.Now.Subtract(_elapseStartTime)
            txtElapsed.Text = String.Format("{0}hr : {1}min : {2}sec", elapsedtime.Hours, elapsedtime.Minutes, elapsedtime.Seconds)
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        _elapseStartTime = DateTime.Now
        _elapseTimerRunning = True
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        _elapseTimerRunning = False
    End Sub
    Sub carregarProgresso()
        abreConexao()
        Try
            sql = "SELECT numero_pedido, horario_pedido FROM tb_pedidos"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                Dim timer As New Timer With {
                    .Tag = rs.Fields(0).Value,
                    .Interval = 1000,
                    .Enabled = True
                }
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
                    .Text = $"#{rs.Fields(0).Value}",
                    .Font = New Font("Julius Sans One", 25),
                    .Location = New Point(20, 16),
                    .Parent = pnl_pedidoProgresso
                }

                Dim lbl_statusPedido As New Guna2HtmlLabel With {
                    .Name = "lbl_statusPedido",
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
                If rs.Fields(5).Value = True Then
                    lbl_statusPedido.Text = "Em andamento"
                Else
                    lbl_statusPedido.Text = "Entregue"
                End If
                pedidos.flp_progressoPedidos.Controls.Add(pnl_pedidoProgresso)
                AddHandler timer.Tick, AddressOf timerTick

            Loop
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar progresso dos pedidos!")
            telaErro.Show()
        End Try
    End Sub
    Sub carregarPedidos(Optional estadoPedido As Boolean = False)
        abreConexao()
        Try
            pedidos.flp_pedidos.Controls.Clear()
            sql = "SELECT tb_pedidos.*, tb_mesas.mesa, tb_mesas.cliente FROM tb_pedidos LEFT JOIN tb_mesas ON tb_pedidos.numero_mesa = tb_mesas.mesa  WHERE tb_pedidos.entregue = " & estadoPedido & " ORDER BY numero_pedido DESC "
            rs = db.Execute(sql)
            Do While rs.EOF = False
                Dim pnl_pedido As New Guna2ShadowPanel With {
                    .Name = "pnl_pedido",
                    .FillColor = Color.White,
                    .Size = New Size(273, 329),
                    .BackColor = Color.Transparent,
                    .Radius = 6,
                    .ShadowColor = Color.FromArgb(200, 200, 200),
                    .ShadowShift = 2,
                    .Padding = New Padding(16)
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
                    .Text = $"Mesa {rs.Fields(1).Value}",
                    .Font = New Font("Libre Caslon Display", 14),
                    .Location = New Point(2, 4),
                    .Parent = pnl_info
                }

                Dim lbl_numeroMesa As New Guna2HtmlLabel With {
                    .Name = "lbl_numeroMesa",
                    .Text = rs.Fields(8).Value,
                    .Font = New Font("Libre Caslon Display", 12),
                    .Location = New Point(2, 31),
                    .Parent = pnl_info
                }

                Dim lbl_numeroPedido As New Guna2HtmlLabel With {
                    .Name = "lbl_numeroPedido",
                    .Text = $"#{rs.Fields(0).Value}",
                    .Font = New Font("Julius Sans One", 25),
                    .Location = New Point(144, 13),
                    .Parent = pnl_info
                }

                Dim btn_excluirPedido As New Guna2ImageButton() With {
                    .Name = "btn_excluirPedido",
                    .Location = New Point(199, 12),
                    .Size = New Size(34, 34),
                    .ImageSize = New Size(34, 34),
                    .BackColor = Color.Transparent,
                    .Cursor = Cursors.Hand,
                    .Parent = pnl_info,
                    .Image = Image.FromFile(Application.StartupPath & "\imgs\trash.png"),
                    .Tag = rs.Fields(0).Value
                }
                btn_excluirPedido.HoverState.ImageSize = New Size(36, 36)
                btn_excluirPedido.PressedState.ImageSize = New Size(38, 38)
                AddHandler btn_excluirPedido.Click, AddressOf excluirPedido

                Dim flp_itensPedido As New FlowLayoutPanel With {
                    .Name = "flp_itensPedido",
                    .Dock = DockStyle.Fill,
                    .Parent = pnl_pedido,
                    .AutoScroll = True,
                    .Padding = New Padding(8),
                    .Size = New Size(241, 198)
                }
                If estadoPedido = False Then
                    Dim pnl_enviarPedido As New Guna2Panel() With {
                        .Name = "pnl_enviarPedido",
                        .Dock = DockStyle.Bottom,
                        .Size = New Size(241, 49),
                        .Parent = pnl_pedido
                    }
                    Dim btn_EnviarPedido As New Guna2Button() With {
                        .Name = "pnl_enviarPedido",
                        .Dock = DockStyle.Bottom,
                        .Size = New Size(241, 37),
                        .Parent = pnl_enviarPedido,
                        .FillColor = Color.FromArgb(46, 31, 39),
                        .Cursor = Cursors.Hand,
                        .Text = "Entregar pedido",
                        .Font = New Font("Libre Caslon Display", 15),
                        .ForeColor = Color.White,
                        .BorderRadius = 17,
                        .Tag = rs.Fields(0).Value
                    }
                    AddHandler btn_EnviarPedido.Click, AddressOf enviarPedido
                Else
                    Dim pnl_horarioEntregue As New Guna2Panel() With {
                       .Name = "pnl_horarioEntregue",
                       .Dock = DockStyle.Bottom,
                       .Size = New Size(241, 49),
                       .Parent = pnl_pedido
                   }
                    Dim lbl_horarioEntregue As New Guna2HtmlLabel() With {
                        .Name = "lbl_horarioEntregue",
                        .Dock = DockStyle.Bottom,
                        .Size = New Size(241, 37),
                        .Parent = pnl_horarioEntregue,
                        .Text = $"Entregue {rs.Fields(6).Value}",
                        .Font = New Font("Libre Caslon Display", 13),
                        .ForeColor = Color.Black
                    }
                End If
                carregarItensDoPedido(rs.Fields(0).Value, flp_itensPedido)
                pedidos.flp_pedidos.Controls.Add(pnl_pedido)
                pnl_pedido.Controls.Add(pnl_info)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            MessageBox.Show(String.Format("carregar pedidos: {0}", ex.Message))
            telaErro.setTexto("Erro ao carregar os pedidos!")
            telaErro.Show()
        End Try
    End Sub
    Public Sub carregarItensDoPedido(numeroPedido As String, panelPedido As FlowLayoutPanel)
        abreConexao()
        Try
            sql2 = "SELECT tb_itenspedido.*, tb_cardapio.nome FROM tb_itenspedido LEFT JOIN tb_cardapio ON tb_itenspedido.numero_item = tb_cardapio.numero_item WHERE numero_pedido = " & numeroPedido & ""
            rs2 = db.Execute(sql2)
            Do While rs2.EOF = False
                Dim pnl_itemDoPedido As New Guna2Panel With {
                    .FillColor = Color.FromArgb(239, 239, 239),
                    .Margin = New Padding(4),
                    .Size = New Size(210, 40),
                    .BorderRadius = 12,
                    .BackColor = Color.White,
                    .Parent = panelPedido,
                    .Tag = rs2.Fields(0).Value
                }
                Dim lbl_nomeItem As New Guna2HtmlLabel With {
                    .Name = "lbl_nomeItem",
                    .Text = rs2.Fields(4).Value,
                    .ForeColor = Color.FromArgb(127, 127, 127),
                    .Font = New Font("Libre Caslon Display", 12),
                    .Location = New Point(11, 9),
                    .Parent = pnl_itemDoPedido
                }
                Dim cbx_concluido As New Guna2CheckBox With {
                    .CheckMarkColor = Color.FromArgb(127, 127, 127),
                    .Location = New Point(155, 12),
                    .Size = New Size(15, 17),
                    .Parent = pnl_itemDoPedido,
                     .Tag = rs2.Fields(0).Value
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
                    .Image = Image.FromFile(Application.StartupPath & "\imgs\trash.png"),
                    .Tag = rs2.Fields(0).Value
                }
                btn_removerItem.HoverState.ImageSize = New Size(24, 24)
                btn_removerItem.PressedState.ImageSize = New Size(28, 28)
                AddHandler btn_removerItem.Click, AddressOf excluirItemPedido

                rs2.MoveNext()
            Loop
        Catch ex As Exception
            MessageBox.Show(String.Format("carregar pedidos: {0}", ex.Message))
            telaErro.setTexto("Erro ao carregar itens do pedido!")
            telaErro.Show()
        End Try
    End Sub

    Public Sub excluirPedido(sender As Object, e As EventArgs)
        Dim pedido As Control = DirectCast(sender, Control)
        abreConexao()
        Try
            sql = "SELECT * FROM tb_pedidos WHERE numero_pedido =" & pedido.Tag & ""
            rs = db.Execute(sql)
            If rs.EOF = False Then
                telaConfirmacao.setTexto($"Deseja realmente apagar o item {rs.Fields(0).Value}?")
                telaConfirmacao.Show()
                telaConfirmacao.setSub(Sub()
                                           sql = "DELETE * FROM tb_pedidos where numero_pedido=" & pedido.Tag & ""
                                           rs = db.Execute(sql)
                                           sql = "DELETE * FROM tb_itenspedido WHERE numero_pedido = " & pedido.Tag & ""
                                           rs = db.Execute(sql)
                                           gerenciadorPedidos.carregarPedidos()
                                           gerenciadorPedidos.NotifyAllPedidos({})
                                           gerenciadorCardapio.NotifyAllCardapio({})
                                           telaConfirmacao.Close()
                                       End Sub)
            Else
                telaErro.setTexto("Pedido inválido!")
                telaErro.Show()
            End If
        Catch ex As Exception
            telaErro.setTexto("Erro ao excluir pedido!")
            telaErro.Show()
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Public Sub enviarPedido(sender As Object, e As EventArgs)
        Dim pedido As Control = DirectCast(sender, Control)
        abreConexao()
        Try
            sql = "UPDATE tb_pedidos SET entregue = true, horario_entrega = '" & Now & "' WHERE numero_pedido = " & pedido.Tag & ""
            rs = db.Execute(sql)
            telaErro.setTexto("Pedido enviado!")
            telaErro.Show()
            carregarPedidos(False)
        Catch ex As Exception
            telaErro.setTexto("Erro ao enviar pedido!")
            telaErro.Show()
            MessageBox.Show(String.Format("Error: {0}", ex.Message))

        End Try
    End Sub

    Public Sub excluirItemPedido(sender As Object, e As EventArgs)
        Dim itemPedido As Control = DirectCast(sender, Control)
        abreConexao()
        Try
            sql = "DELETE * FROM tb_itensPedido WHERE cod_item = " & itemPedido.Tag & ""
            rs = db.Execute(sql)
            gerenciadorPedidos.NotifyAllPedidos({})
            gerenciadorCardapio.NotifyAllCardapio({})
        Catch ex As Exception
            telaErro.setTexto("Erro ao excluir item do pedido!")
            telaErro.Show()
        End Try
    End Sub
End Class