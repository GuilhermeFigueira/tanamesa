Imports System.IO
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

    Private Sub cmb_numeroMesa_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_numeroMesa.SelectedValueChanged
        gerenciadorMesa.atualizarInformacoesMesa()
    End Sub

    Private Sub mesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gerenciarMesas.carregarTodasMesas()
        carregarMesas(cmb_numeroMesa, "Ocupada", "Livre")
    End Sub

    Private Sub btn_abrirMesa_Click(sender As Object, e As EventArgs) Handles btn_abrirMesa.Click
        If btn_abrirMesa.Text = "Fechar Mesa" Then
            gerenciadorMesa.fecharMesa()
        Else
            gerenciadorMesa.abrirMesa()
        End If
    End Sub

    Private Sub cmb_pedido_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_pedido.SelectedIndexChanged
        gerenciadorMesa.atualizarPedidoMesa(cmb_pedido.Text)
    End Sub
End Class

Public Class criarMesas
    Public Delegate Sub ObserverFunction(ByVal command As Object)

    Private observers As New List(Of Action(Of Object))()

    Public Sub SubscribeMesas(observerAction As Action(Of Object))
        observers.Add(observerAction)
    End Sub

    Public Sub NotifyAllMesas(command As Object)
        For Each observerAction In observers
            observerAction.Invoke(command)
        Next
    End Sub
    Public Sub carregarTodasMesas()
        Try
            sql = "SELECT * FROM tb_mesas"
            rs = db.Execute(sql)
            mesas.flp_mesas.Controls.Clear()
            Do While rs.EOF = False
                Dim corMesa As Color
                If rs.Fields(1).Value = "Livre" Then
                    corMesa = Color.FromArgb(48, 107, 52)
                Else
                    corMesa = Color.FromArgb(255, 67, 101)
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

                AddHandler pnl_mesa.Click, AddressOf atualizarMesaSelecionada
                mesas.flp_mesas.Controls.Add(pnl_mesa)
                count += 1
                rs.MoveNext()
            Loop
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar as mesas!")
            telaErro.Show()
        End Try
    End Sub
    Public Sub atualizarMesaSelecionada(sender As Object, e As EventArgs)
        Try
            Dim mesa As Integer = DirectCast(sender, Control).Tag
            mesas.cmb_numeroMesa.SelectedIndex = mesas.cmb_numeroMesa.FindStringExact(mesa)
        Catch ex As Exception
            telaErro.setTexto("Erro ao atualizar a mesa selecionada!")
            telaErro.Show()
        End Try
    End Sub

    Public Sub atualizarInformacoesMesa()
        Try
            Dim numeroMesa As String = mesas.cmb_numeroMesa.Text
            Dim statusMesa As String

            With mesas
                .txt_nomeCliente.Clear()
                .lbl_horario.Text = ""
                .lbl_total.Text = ""
            End With

            For Each ctrl As Control In mesas.flp_mesas.Controls
                If ctrl.Tag = numeroMesa Then
                    For Each lbl As Control In ctrl.Controls
                        If lbl.Name = "lbl_statusMesa" Then
                            statusMesa = lbl.Text
                        End If
                    Next lbl
                End If
            Next ctrl
            mesas.flp_itemsPedido.Controls.Clear()
            mesas.cmb_pedido.Controls.Clear()
            If statusMesa = "Ocupada" Then
                mesas.pnl_infoMesa.Visible = True
                mesas.pnl_infoMesa.Size = New Size(324, 389)
                atualizarNomeCliente(numeroMesa)
                mesas.btn_abrirMesa.Text = "Abrir Mesa"
                sql = "SELECT numero_pedido, valor_total, horario_pedido FROM tb_pedidos WHERE numero_mesa= '" & numeroMesa & "'"
                rs = db.Execute(sql)
                mesas.cmb_pedido.Items.Clear()
                mesas.lbl_total.Tag = 0
                With mesas.cmb_pedido
                    Do While rs.EOF = False
                        Dim horarioMesaAberta As DateTime = mesas.lbl_horario.Tag
                        Dim horarioPedido As DateTime = rs.Fields(2).Value
                        If horarioMesaAberta < horarioPedido Then
                            .Items.Add(rs.Fields(0).Value)
                            mesas.lbl_total.Tag += rs.Fields(1).Value
                        End If
                        rs.MoveNext()
                    Loop
                    If .Items.Count > 0 Then
                        .SelectedIndex = 0
                    End If
                    mesas.lbl_total.Text = $"R$ {mesas.lbl_total.Tag}"
                End With
            ElseIf statusMesa = "Livre" Then
                mesas.pnl_infoMesa.Visible = False
                mesas.pnl_infoMesa.Size = New Size(0, 0)
                mesas.txt_nomeCliente.Enabled = True
                mesas.btn_abrirMesa.Text = "Fechar Mesa"
            End If
        Catch ex As Exception
            telaErro.setTexto("Erro ao atualizar informações da mesa!")
            telaErro.Show()
            MessageBox.Show(String.Format("Error: {0}", ex.Message))

        End Try
    End Sub

    Public Sub atualizarNomeCliente(numeroMesa As Integer)
        Try
            mesas.txt_nomeCliente.Clear()
            sql = "SELECT cliente, horario_entrada FROM tb_mesas WHERE mesa = '" & numeroMesa & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                mesas.txt_nomeCliente.Text = rs.Fields(0).Value
                mesas.txt_nomeCliente.Enabled = False
                Dim horarioEntrada As String = rs.Fields(1).Value
                Dim dateTime As DateTime = DateTime.Parse(horarioEntrada)
                Dim timeOfDay As TimeSpan = dateTime.TimeOfDay
                Dim timeString As String = timeOfDay.ToString("hh\:mm")
                mesas.lbl_horario.Text = timeString
                mesas.lbl_horario.Tag = horarioEntrada
            End If
        Catch ex As Exception
            telaErro.setTexto("Erro ao atualizar informações do cliente!")
            telaErro.Show()
        End Try
    End Sub

    Public Sub atualizarPedidoMesa(numeroPedido As Integer)
        Try
            Dim itensList As New List(Of List(Of String))
            sql = "SELECT numero_item, preco FROM tb_itensPedido WHERE numero_pedido = '" & numeroPedido & "'"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                itensList.Add(New List(Of String) From {rs.Fields(0).Value, rs.Fields(1).Value})
                rs.MoveNext()
            Loop
            mesas.flp_itemsPedido.Controls.Clear()
            count = 0
            For Each item As List(Of String) In itensList
                sql = "SELECT nome FROM tb_cardapio WHERE numero_item = " & itensList(count)(0) & ""
                rs = db.Execute(sql)
                If rs.EOF = False Then
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
                        .Text = rs.Fields(0).Value,
                        .Font = New Font("Libre Caslon Display", 12),
                        .Location = New Point(19, 9),
                        .ForeColor = Color.FromArgb(127, 127, 127),
                        .Parent = pnl_pedido
                    }
                    Dim lbl_preco As New Guna2HtmlLabel() With {
                        .Name = "lbl_preco",
                        .Text = $"R$ {itensList(count)(1)}",
                        .Font = New Font("Libre Caslon Display", 12),
                        .Location = New Point(163, 9),
                        .ForeColor = Color.FromArgb(127, 127, 127),
                        .Parent = pnl_pedido
                    }
                    mesas.flp_itemsPedido.Controls.Add(pnl_pedido)
                    count += 1
                End If
            Next item
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar pedidos da mesa!")
            telaErro.Show()
        End Try
    End Sub

    Public Sub abrirMesa()
        Try
            With mesas
                Dim numeroMesa As String = .cmb_numeroMesa.Text
                sql = "UPDATE tb_mesas SET status = 'Livre', cliente = '', horario_entrada = '' WHERE mesa = '" & numeroMesa & "'"
                rs = db.Execute(sql)
                For Each ctrl As Guna2Panel In mesas.flp_mesas.Controls
                    If ctrl.Tag = numeroMesa Then
                        For Each lbl As Control In ctrl.Controls
                            If lbl.Name = "lbl_statusMesa" Then
                                lbl.Text = "Livre"
                            End If
                        Next lbl
                        ctrl.CustomBorderColor = Color.FromArgb(48, 107, 52)
                    End If
                Next
                carregarMesas(cardapio.cmb_numeroMesa, "Ocupada", "Ocupada")
                atualizarInformacoesMesa()
            End With
        Catch ex As Exception
            telaErro.setTexto("Erro ao abrir mesa!")
            telaErro.Show()
        End Try
    End Sub

    Public Sub fecharMesa()
        Try
            With mesas
                Dim itensList As New List(Of String)
                Dim numeroMesa As String = .cmb_numeroMesa.Text
                Dim nomeCliente As String = .txt_nomeCliente.Text
                Dim horarioEntrada As Date = Now
                itensList.Add(numeroMesa)
                itensList.Add(nomeCliente)
                If verificarVazio(itensList) = False Then
                    sql = "UPDATE tb_mesas SET status = 'Ocupada', cliente = '" & nomeCliente & "', horario_entrada = '" & horarioEntrada & "' WHERE mesa = '" & numeroMesa & "' "
                    rs = db.Execute(sql)
                    For Each ctrl As Guna2Panel In mesas.flp_mesas.Controls
                        If ctrl.Tag = numeroMesa Then
                            For Each lbl As Control In ctrl.Controls
                                If lbl.Name = "lbl_statusMesa" Then
                                    lbl.Text = "Ocupada"
                                End If
                            Next lbl
                            ctrl.CustomBorderColor = Color.FromArgb(255, 67, 101)
                        End If
                    Next
                    carregarMesas(cardapio.cmb_numeroMesa, "Ocupada", "Ocupada")
                    atualizarInformacoesMesa()
                Else
                    telaErro.setTexto("Existem campos vazios!")
                    telaErro.Show()
                End If
            End With
        Catch ex As Exception
            telaErro.setTexto("Erro ao fechar mesa!")
            telaErro.Show()
        End Try
    End Sub
End Class
