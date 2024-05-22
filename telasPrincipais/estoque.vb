Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Web.UI.Design
Imports Guna.UI2.WinForms

Public Class estoque
    Dim estoque As New criarEstoque
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
        conecta_banco_access()
        estoque.carregarEstoque()

    End Sub

End Class
Class criarEstoque
    Public Sub carregarEstoque()
        'MessageBox.Show(String.Format("Error: {0}", "bomba"))
        Try
            sql = "SELECT * FROM tb_estoque ORDER BY nome ASC"
            rs = db.Execute(sql)
            count = 0
            With estoque.dgv_estoque
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(Nothing, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(8).Value, rs.Fields(4), rs.Fields(6), rs.Fields(5), Nothing, Nothing)
                    'Dim fotoProduto As Image = Image.FromFile(rs.Fields(7).Value)
                    MessageBox.Show(String.Format("Error: {0}", rs.RecordCount))
                    '.Rows(count).Cells("fotoProduto").Value = fotoProduto
                    count += 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar dados!")
            telaErro.Show()
        End Try
    End Sub


End Class
