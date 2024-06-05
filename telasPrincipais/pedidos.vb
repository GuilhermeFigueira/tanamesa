Imports Guna.UI2.WinForms
Imports System.Text

Public Class pedidos
    Dim carregado As Boolean = False

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
        carregado = True
    End Sub

    Private Sub cmb_progs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_progs.SelectedIndexChanged
        If cmb_progs.Text = "Pedidos Não Entregues" Then
            gerenciadorPedidos.carregarPedidos(False)
            gerenciadorPedidos.carregarProgresso(False)
        Else
            gerenciadorPedidos.carregarPedidos(True)
            gerenciadorPedidos.carregarProgresso(True)
        End If
    End Sub

    Private Sub pedidos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If funcionario.admin = True Then
            btn_gerencia.Visible = True
        Else
            btn_gerencia.Visible = False
        End If
    End Sub
    Private Sub txt_pesquisaPedidos_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisaPedidos.TextChanged
        If carregado Then
            gerenciadorPedidos.carregarPedidos(, txt_pesquisaPedidos.Text)
            gerenciadorPedidos.carregarProgresso(, txt_pesquisaPedidos.Text)
        End If
    End Sub
End Class

Public Class criarPedidos
    Private timersProgresso As New List(Of Timer)

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


    Public Sub timerTick(sender As Object, e As EventArgs)
        Dim timer As Timer = DirectCast(sender, Timer)
        For Each ctrl As Guna2ShadowPanel In pedidos.flp_progressoPedidos.Controls
            If ctrl.Tag = timer.Tag Then
                For Each lbl As Control In ctrl.Controls
                    If lbl.Name = "lbl_tempoDecorrido" Then
                        Dim startTime As DateTime = lbl.Tag
                        Dim now As DateTime = DateTime.Now
                        Dim elapsedTime As TimeSpan = now - startTime
                        Dim formattedElapsedTime As String = elapsedTime.ToString("hh\:mm\:ss")

                        lbl.Text = $"Tempo decorrido: {formattedElapsedTime}"
                    End If
                Next lbl
            End If
        Next
    End Sub
    Public Sub carregarProgresso(Optional estadoPedido As Boolean = False, Optional pesquisa As String = "")

        abreConexao()
        Try
            Dim ultimoControl As Control = Nothing

            pedidos.flp_progressoPedidos.Controls.Clear()
            Dim comando As New StringBuilder("SELECT numero_pedido, horario_pedido, entregue, horario_entrega FROM tb_pedidos WHERE entregue = " & estadoPedido & "")

            If pesquisa <> "" Then
                comando.Append(" AND numero_pedido LIKE " & pesquisa & " ORDER BY numero_pedido ASC")
            Else
                comando.Append(" ORDER BY numero_pedido ASC")
            End If
            sql = comando.ToString()
            rs = db.Execute(sql)
            Do While rs.EOF = False
                Dim timer As New Timer With {
                    .Tag = rs.Fields(0).Value,
                    .Interval = 1000
                }
                Dim pnl_pedidoProgresso As New Guna2ShadowPanel With {
                    .Name = "pnl_pedidoProgresso",
                    .FillColor = Color.FromArgb(244, 187, 108),
                    .Size = New Size(254, 70),
                    .BackColor = Color.Transparent,
                    .Radius = 6,
                    .ShadowColor = Color.FromArgb(200, 200, 200),
                    .ShadowShift = 6,
                    .ShadowStyle = Guna2ShadowPanel.ShadowMode.ForwardDiagonal,
                    .Tag = rs.Fields(0).Value
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
                    .Name = "lbl_tempoDecorrido",
                    .Text = "Tempo decorrido: ",
                    .Font = New Font("Libre Caslon Display", 10),
                    .Location = New Point(95, 39),
                    .Parent = pnl_pedidoProgresso
                }
                timersProgresso.Add(timer)

                If rs.Fields(2).Value = False Then
                    lbl_statusPedido.Text = "Em andamento"
                    timer.Enabled = True
                    lbl_tempoDecorrido.Tag = rs.Fields(1).Value
                Else
                    lbl_statusPedido.Text = "Entregue"
                    timer.Enabled = False
                    Dim startTime As DateTime = rs.Fields(1).Value
                    Dim finishTime As DateTime = rs.Fields(3).Value
                    Dim elapsedTime As TimeSpan = startTime - finishTime
                    Dim formattedElapsedTime As String = elapsedTime.ToString("hh\:mm\:ss")
                    lbl_tempoDecorrido.Text = $"Tempo total: {formattedElapsedTime}"
                End If
                pedidos.flp_progressoPedidos.Controls.Add(pnl_pedidoProgresso)
                AddHandler timer.Tick, AddressOf timerTick
                rs.MoveNext()
                ultimoControl = pnl_pedidoProgresso
            Loop
            If Not ultimoControl Is Nothing Then
                ultimoControl.Margin = New Padding(ultimoControl.Margin.Left, ultimoControl.Margin.Top, 300, ultimoControl.Margin.Bottom)
            End If
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar progresso dos pedidos!")
            MessageBox.Show(String.Format("carregar progresso pedidos: {0}", ex.Message))

            telaErro.Show()
        End Try
    End Sub
    Sub carregarPedidos(Optional estadoPedido As Boolean = False, Optional pesquisa As String = "")
        abreConexao()
        Try
            Dim ultimoControl As Control = Nothing

            pedidos.flp_pedidos.Controls.Clear()
            Dim comando As New StringBuilder("SELECT tb_pedidos.*, tb_mesas.mesa, tb_mesas.cliente FROM tb_pedidos LEFT JOIN tb_mesas ON tb_pedidos.numero_mesa = tb_mesas.mesa  WHERE tb_pedidos.entregue = " & estadoPedido & "")
            If pesquisa <> "" Then
                comando.Append(" AND numero_pedido LIKE " & pesquisa & " ORDER BY numero_pedido ASC")
            Else
                comando.Append(" ORDER BY numero_pedido ASC")
            End If
            sql = comando.ToString()
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
                    .Padding = New Padding(7)
                }
                Dim pnl_funcionarioPediu As New Guna2Panel With {
                    .Name = "pnl_funcionarioPediu",
                    .Size = New Size(241, 20),
                    .Dock = DockStyle.Top,
                    .FillColor = Color.White,
                    .Parent = pnl_pedido
                }
                Dim lbl_funcionarioPediu As New Guna2HtmlLabel With {
                    .Name = "lbl_funcionarioPediu",
                    .Text = $"Funcionario: #{Format(CInt(rs.Fields(4).Value.ToString), "00")}",
                    .Font = New Font("Julius Sans One", 7),
                    .ForeColor = Color.FromArgb(46, 31, 39),
                    .Parent = pnl_funcionarioPediu,
                    .Dock = DockStyle.Fill,
                    .AutoSize = False,
                    .TextAlignment = ContentAlignment.MiddleCenter
                }
                Dim pnl_geral As New Guna2Panel With {
                    .Name = "pnl_geral",
                    .Padding = New Padding(16),
                    .FillColor = Color.White,
                    .Dock = DockStyle.Fill,
                    .Parent = pnl_pedido
                }
                Dim pnl_info As New Guna2Panel With {
                    .Name = "pnl_info",
                    .FillColor = Color.White,
                    .Size = New Size(241, 52),
                    .BackColor = Color.Transparent,
                    .Dock = DockStyle.Top,
                    .Parent = pnl_geral
                }

                Dim lbl_nomeCliente As New Guna2HtmlLabel With {
                    .Name = "lbl_nomeCliente",
                    .Text = $"Mesa {rs.Fields(1).Value}",
                    .Font = New Font("Libre Caslon Display", 14),
                    .Location = New Point(2, 5),
                    .Parent = pnl_info
                }

                Dim lbl_numeroMesa As New Guna2HtmlLabel With {
                    .Name = "lbl_numeroMesa",
                    .Text = rs.Fields(8).Value,
                    .Font = New Font("Libre Caslon Display", 12),
                    .Location = New Point(2, 30),
                    .Parent = pnl_info
                }
                'Copiar aqui
                Dim lbl_numeroPedido As New Guna2HtmlLabel With {
                    .Name = "lbl_numeroPedido",
                    .Text = $"#{Format(rs.Fields(0).Value, "000")}",
                    .Font = New Font("Julius Sans One", 25),
                    .Location = New Point(100, 13),
                    .Parent = pnl_info
                }

                Dim btn_excluirPedido As New Guna2ImageButton() With {
                    .Name = "btn_excluirPedido",
                    .Location = New Point(190, 13),
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
                Dim lbl_divisor As New Guna2HtmlLabel With {
                    .Size = New Size(100, 1),
                    .Dock = DockStyle.Bottom,
                    .BackColor = Color.FromArgb(146, 146, 146),
                    .Parent = pnl_info
                }
                lbl_divisor.BringToFront()
                Dim flp_itensPedido As New FlowLayoutPanel With {
                    .Name = "flp_itensPedido",
                    .Parent = pnl_geral,
                    .AutoScroll = True,
                    .Dock = DockStyle.Fill,
                    .Padding = New Padding(12, 0, 12, 0)
                }
                If estadoPedido = False Then
                    Dim pnl_enviarPedido As New Guna2Panel() With {
                        .Name = "pnl_enviarPedido",
                        .Dock = DockStyle.Bottom,
                        .Size = New Size(241, 49),
                        .Parent = pnl_geral
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
                       .Parent = pnl_geral
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
                flp_itensPedido.BringToFront()
                pedidos.flp_pedidos.Controls.Add(pnl_pedido)
                carregarItensDoPedido(rs.Fields(0).Value, flp_itensPedido, estadoPedido)
                rs.MoveNext()
                ultimoControl = pnl_pedido
            Loop
            If Not ultimoControl Is Nothing Then
                ultimoControl.Margin = New Padding(ultimoControl.Margin.Left, ultimoControl.Margin.Top, 300, ultimoControl.Margin.Bottom)
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("carregar pedidos: {0}", ex.Message))
            telaErro.setTexto("Erro ao carregar os pedidos!")
            telaErro.Show()
        End Try
    End Sub
    Public Sub carregarItensDoPedido(numeroPedido As String, panelPedido As FlowLayoutPanel, Optional entregue As Boolean = False)
        abreConexao()
        Try
            sql2 = "SELECT tb_itenspedido.*, tb_cardapio.nome FROM tb_itenspedido LEFT JOIN tb_cardapio ON tb_itenspedido.numero_item = tb_cardapio.numero_item WHERE numero_pedido = " & numeroPedido & ""
            rs2 = db.Execute(sql2)
            Do While rs2.EOF = False
                Dim pnl_itemDoPedido As New Guna2Panel With {
                    .FillColor = Color.FromArgb(239, 239, 239),
                    .Margin = New Padding(4),
                    .Size = New Size(190, 40),
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
                If entregue = False Then
                    Dim cbx_concluido As New Guna2CheckBox With {
                        .CheckMarkColor = Color.FromArgb(127, 127, 127),
                        .Location = New Point(135, 12),
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
                    .Location = New Point(154, 7),
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
                End If
                rs2.MoveNext()
            Loop
        Catch ex As Exception
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
                                           pedido.Parent.Parent.Dispose()
                                           gerenciadorCardapio.carregarCardapio()
                                           gerenciadorPedidos.carregarProgresso()
                                           gerenciadorMesa.atualizarInformacoesMesa()
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
            carregarProgresso()

            For Each timer In timersProgresso
                If timer.Tag = pedido.Tag Then
                    timer.Stop()
                    timer.Enabled = False
                End If
            Next
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
            itemPedido.Parent.Dispose()
            gerenciadorPedidos.NotifyAllPedidos({})
            gerenciadorCardapio.NotifyAllCardapio({})
        Catch ex As Exception
            telaErro.setTexto("Erro ao excluir item do pedido!")
            telaErro.Show()
        End Try
    End Sub
End Class