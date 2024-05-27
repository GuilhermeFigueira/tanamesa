Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.InteropServices.WindowsRuntime
Imports ADODB

Public Class estoque
    Public carregado As Boolean = False
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

    Private Sub btn_gerencia_Click(sender As Object, e As EventArgs) Handles btn_gerencia.Click
        gerencia.Show()
        Me.Hide()
    End Sub

    Private Sub btn_info_Click(sender As Object, e As EventArgs) Handles btn_info.Click
        infoUsuario.Show()
    End Sub

    Private Sub btn_cardapio_Click(sender As Object, e As EventArgs) Handles btn_cardapio.Click
        cardapio.Show()
        Me.Hide()
    End Sub
    Private Sub estoque_Click(sender As Object, e As EventArgs) Handles Me.Click
        cadastrarEstoque.Show()
    End Sub

    Private Sub btn_addProd_Click(sender As Object, e As EventArgs) Handles btn_addProd.Click
        cadastrarEstoque.Show()
    End Sub

    Private Sub estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abreConexao()
        gerenciadorEstoque.carregarEstoque()
        gerenciadorEstoque.Subscribe(AddressOf gerenciadorEstoque.carregarEstoque)
    End Sub

    Private Sub dgv_estoque_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_estoque.CellContentClick
        Try
            With dgv_estoque
                If e.ColumnIndex = 8 Then
                    gerenciadorEstoque.carregarEdicaoItemEstoque(.CurrentRow.Tag)
                ElseIf e.ColumnIndex = 9 Then
                    gerenciadorEstoque.apagarItemEstoque(.CurrentRow.Tag)
                End If
            End With
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar dados!")
            telaErro.Show()
        End Try
    End Sub

    Private Sub txt_pesquisa_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa.TextChanged
        gerenciadorEstoque.pesquisarEstoque(txt_pesquisa.Text)
    End Sub

    Private Sub dgv_estoque_Paint(sender As Object, e As PaintEventArgs) Handles dgv_estoque.Paint
        carregado = True
    End Sub
End Class
Public Class criarEstoque
    Public Delegate Sub ObserverFunction(ByVal command As Object)

    Private observers As New List(Of Action(Of Object))()

    Public Sub Subscribe(observerAction As Action(Of Object))
        observers.Add(observerAction)
    End Sub

    Public Sub NotifyAllEstoque(command As Object)
        For Each observerAction In observers
            observerAction.Invoke(command)
        Next
    End Sub

    Public Sub carregarEstoque()
        abreConexao()
        Try
            sql = "SELECT * FROM tb_estoque ORDER BY nome ASC"
            rs = db.Execute(sql)
            count = 0
            With estoque.dgv_estoque
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(Nothing, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, formatDate(rs.Fields(7).Value), formatDate(rs.Fields(8).Value), Nothing, Nothing)
                    If rs.Fields(1).Value IsNot "" Then
                        If File.Exists(Path.Combine(Application.StartupPath, "imgProdutos", rs.Fields(1).Value)) Then
                            Dim fotoProduto As Image = Image.FromFile(Path.Combine(Application.StartupPath, "imgProdutos", rs.Fields(1).Value))
                            If fotoProduto IsNot Nothing Then
                                .Rows(count).Cells("fotoProduto").Value = fotoProduto
                            End If
                        End If
                    End If
                    .Rows(count).Tag = rs.Fields(0).Value
                    count += 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar dados carrega!")
            telaErro.Show()
            MessageBox.Show(String.Format("Error editar item estoque: {0}", ex.Message))
        End Try
    End Sub

    Public Sub cadastrarItemNoEstoque()
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
        NotifyAllEstoque({})
    End Sub
    Public Sub carregarEdicaoItemEstoque(itemId As Integer)
        abreConexao()
        Try
            carregarCategorias("estoque", cadastrarEstoque.cmb_categoria)
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
                    If File.Exists(Path.Combine(Application.StartupPath, "imgProdutos", rs.Fields(1).Value)) Then
                        .pbx_imagem.Load(Path.Combine(Application.StartupPath, "imgProdutos", rs.Fields(1).Value))
                    End If
                    .Show()
                End If
            End With
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar dados!")
            telaErro.Show()
            'MessageBox.Show(String.Format("Error editar item estoque: {0}", ex.Message))
        End Try
        NotifyAllEstoque({})
    End Sub
    Public Sub editarItemNoEstoque(itemId)
        abreConexao()
        Dim itensList As New List(Of String)
        Dim nomeItem As String = cadastrarEstoque.txt_nome.Text
        Dim categoriaItem As String = cadastrarEstoque.cmb_categoria.Text
        Dim unidadeItem As String = cadastrarEstoque.cmb_unidade.Text
        Dim emEstoque As String = cadastrarEstoque.txt_qtd.Text
        Dim valorPagoUnidade As String = cadastrarEstoque.txt_vlrUnidade.Text
        Dim dataCompra As String = cadastrarEstoque.dtp_dataCompra.Value.Date
        Dim dataValidade As String = cadastrarEstoque.dtp_dataValidade.Value.Date
        itensList.Add(nomeItem)
        itensList.Add(categoriaItem)
        itensList.Add(unidadeItem)
        itensList.Add(emEstoque)
        itensList.Add(valorPagoUnidade)
        itensList.Add(dataCompra)
        itensList.Add(dataValidade)
        Try
            If verificarVazio(itensList) = False Then
                sql = "UPDATE tb_estoque SET foto='" & caminhoImagem & "', nome ='" & nomeItem & "', categoria='" & categoriaItem & "', em_estoque='" & emEstoque & "', unidade='" & unidadeItem & "', valor_pago='" & valorPagoUnidade & "', data_compra='" & dataCompra & "', data_validade='" & dataValidade & "' WHERE id_item=" & itemId & ""
                rs = db.Execute(sql)
                telaErro.setTexto($"{nomeItem} foi editado com sucesso!")
                telaErro.Show()
            Else
                telaErro.setTexto("Existem campos vazios!")
                telaErro.Show()
            End If
        Catch ex As Exception
            telaErro.setTexto("Erro ao editar item no estoque!")
            telaErro.Show()
            MessageBox.Show(String.Format("Error: {0}", sql))
        End Try
        NotifyAllEstoque({})
    End Sub

    Public Sub apagarItemEstoque(itemId As Integer)
        abreConexao()
        Try
            sql = "SELECT * FROM tb_estoque WHERE id_item =" & itemId & ""
            rs = db.Execute(sql)
            If rs.EOF = False Then
                telaConfirmacao.setTexto($"Deseja realmente apagar o item {rs.Fields(2).Value}?")
                telaConfirmacao.Show()
                telaConfirmacao.setSub(Sub()
                                           sql = "DELETE * FROM tb_estoque where id_item=" & itemId & ""
                                           rs = db.Execute(sql)
                                           gerenciadorEstoque.NotifyAllEstoque({})
                                           telaConfirmacao.Close()
                                       End Sub)
            Else
                telaErro.setTexto("Produto inválido!")
                telaErro.Show()
            End If
        Catch ex As Exception
            telaErro.setTexto("Erro ao excluir produto!")
            telaErro.Show()
            MessageBox.Show(String.Format("Error: {0}", ex.Message))

        End Try
    End Sub

    Public Sub pesquisarEstoque(pesquisa As String)
        abreConexao()
        Try
            sql = "SELECT * FROM tb_estoque WHERE nome LIKE '" & pesquisa & "%' ORDER BY nome ASC"
            rs = db.Execute(sql)
            count = 0
            If estoque.carregado = True And estoque.carregado <> Nothing Then
                With estoque.dgv_estoque
                    count = 0
                    .Rows.Clear()
                    Do While rs.EOF = False
                        .Rows.Add(Nothing, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, formatDate(rs.Fields(7).Value), formatDate(rs.Fields(8).Value), Nothing, Nothing)
                        If rs.Fields(1).Value IsNot "" Then
                            If File.Exists(Path.Combine(Application.StartupPath, "imgProdutos", rs.Fields(1).Value)) Then
                                Dim fotoProduto As Image = Image.FromFile(Path.Combine(Application.StartupPath, "imgProdutos", rs.Fields(1).Value))
                                If fotoProduto IsNot Nothing Then
                                    .Rows(count).Cells("fotoProduto").Value = fotoProduto
                                End If
                            End If
                        End If
                        .Rows(count).Tag = rs.Fields(0).Value
                        count += 1
                        rs.MoveNext()
                    Loop
                End With
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("Error editar item estoque: {0}", ex.Message))
            telaErro.setTexto("Erro ao carregar dados pesquisa!")
            telaErro.Show()
        End Try
    End Sub
    Public Class Categoria
        Public Property categoria As String
    End Class

End Class
