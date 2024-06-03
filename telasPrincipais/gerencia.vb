Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Web.UI.Design

Imports Guna.UI2.WinForms

Public Class gerencia
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

    Private Sub btn_info_Click(sender As Object, e As EventArgs) Handles btn_info.Click
        infoUsuario.Show()
    End Sub

    Private Sub btn_cardapio_Click(sender As Object, e As EventArgs) Handles btn_cardapio.Click
        cardapio.Show()
        Me.Hide()
    End Sub

    Private Sub btn_estoque_Click(sender As Object, e As EventArgs) Handles btn_estoque.Click
        estoque.Show()
        Me.Hide()
    End Sub

    Private Sub gerencia_Load(sender As Object, e As EventArgs) Handles Me.Load
        gerenciadorGerencia.carregarFuncionarios()
    End Sub

End Class

Public Class criarGerencia
    Public Sub carregarFuncionarios()
        abreConexao()
        Try
            sql = "SELECT * FROM tb_funcionarios"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                Dim pnl_funcionario As New Guna2ShadowPanel With {
                    .Name = "pnl_prato",
                    .FillColor = Color.FromArgb(239, 239, 239),
                    .Size = New Size(280, 300),
                    .Margin = New Padding(6, 3, 6, 3),
                    .Radius = 10,
                    .ShadowShift = 4,
                    .Padding = New Padding(12),
                    .ShadowColor = Color.FromArgb(200, 200, 200),
                    .Tag = rs.Fields(0).Value
                }
                Dim pbx_fotoFuncionario As New Guna2PictureBox() With {
                    .Name = "pbx_fotoFuncionario",
                    .BorderRadius = 12,
                    .Size = New Size(163, 130),
                    .Parent = pnl_funcionario,
                    .SizeMode = PictureBoxSizeMode.StretchImage,
                .Dock = DockStyle.Top
                }
                '.Image = Image.FromFile(Path.Combine(Application.StartupPath, "imgFuncionarios", rs.Fields(5).Value)),
                Dim lbl_divisor As New Label With {
                    .Size = New Size(251, 1),
                    .Location = New Point(16, 157),
                    .BackColor = Color.FromArgb(146, 146, 146),
                    .Parent = pnl_funcionario
                }
                Dim pnl_info As New Guna2Panel With {
                    .Name = "pnl_info",
                    .Dock = DockStyle.Bottom,
                    .Size = New Size(256, 117),
                    .Parent = pnl_funcionario
                }
                Dim lbl_nomeFuncionario As New Guna2HtmlLabel() With {
                    .Name = "lbl_nomeFuncionario",
                    .Text = rs.Fields(3).Value,
                    .Font = New Font("Libre Caslon Display", 18),
                    .Location = New Point(26, 3),
                    .ForeColor = Color.Black,
                    .Parent = pnl_info,
                    .Dock = DockStyle.Top,
                    .AutoSize = False,
                    .Size = New Size(256, 31),
                    .TextAlignment = ContentAlignment.MiddleCenter
                }
                Dim lbl_statusFuncionario As New Guna2HtmlLabel() With {
                    .Name = "lbl_nomeFuncionario",
                    .Font = New Font("Libre Caslon Display", 16),
                    .Location = New Point(75, 40),
                    .Parent = pnl_info
                }

                Dim btn_maisInfo As New Guna2Button() With {
                    .Name = "btn_maisInfo",
                    .Text = "Mais Informações",
                    .Font = New Font("Libre Caslon Display", 16),
                    .BorderRadius = 16,
                    .Location = New Point(19, 76),
                    .ForeColor = Color.White,
                    .Size = New Size(216, 35),
                    .FillColor = Color.FromArgb(46, 31, 39),
                    .Cursor = Cursors.Hand,
                    .Parent = pnl_info,
                    .Tag = rs.Fields(0).Value
                }
                AddHandler btn_maisInfo.Click, AddressOf carregarMaisInfoFuncionario
                gerencia.flp_itemsCard.Controls.Add(pnl_funcionario)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar funcionários!")
            telaErro.Show()
            MessageBox.Show(String.Format($"{ex.Message}"))

        End Try
    End Sub
    Public Sub gerenciaCadastrarFuncionario()
        abreConexao()
        Try
            Dim itensList As New List(Of String)
            Dim nome As String = cadastrarFuncionario.txt_nome.Text
            Dim cpf As String = cadastrarFuncionario.txt_cpf.Text
            Dim senha As String = cadastrarFuncionario.txt_senha.Text
            Dim funcao As String = cadastrarFuncionario.txt_funcao.Text
            Dim adm As Boolean = cadastrarFuncionario.cbx_administrador.Checked
            itensList.Add(nome)
            itensList.Add(cpf)
            itensList.Add(senha)
            itensList.Add(funcao)
            itensList.Add(adm)

            If verificarVazio(itensList) = False Then
                sql = "SELECT * FROM tb_funcionarios WHERE cpf = '" & cpf & "'"
                rs = db.Execute(sql)
                If rs.EOF = True Then
                    sql = "INSERT INTO tb_funcionarios (CPF, SENHA, NOME, FUNCAO, FOTO, ADMIN) VALUES('" & cpf & "', '" & senha & "', '" & nome & "', '" & funcao & "', '" & caminhoImagem & "', '" & adm & "')"
                    rs = db.Execute(sql)
                    telaErro.setTexto($"{nome} foi cadastrado com sucesso!")
                    telaErro.Show()
                Else
                    telaErro.setTexto($"O CPF {cpf} já está cadastrado!")
                    telaErro.Show()
                End If
            End If
        Catch ex As Exception
            telaErro.setTexto("Erro ao cadastrar funcionário!")
            telaErro.Show()
        End Try
    End Sub

    Public Sub carregarMaisInfoFuncionario(sender As Object, e As EventArgs)
        Dim codFuncionario As Integer = DirectCast(sender, Control).Tag
        abreConexao()
        Try
            sql = "SELECT * FROM tb_funcionarios WHERE cod_funcionario = " & codFuncionario & ""
            rs = db.Execute(sql)
            With maisInformacoesFuncionario
                If rs.EOF = False Then
                    .txt_cpf.Text = rs.Fields(1).Value
                    .txt_senha.Text = rs.Fields(2).Value
                    .txt_nome.Text = rs.Fields(3).Value
                    .txt_funcao.Text = rs.Fields(4).Value
                    .lbl_codFuncionario.Text = $"Funcionário #{Format(rs.Fields(0).Value, "00")}"
                    .lbl_codFuncionario.Tag = rs.Fields(0).Value
                    'MessageBox.Show(String.Format("Error editar item estoque: {0}", ex.Message))
                    If File.Exists(Path.Combine(Application.StartupPath, "imgProdutos", rs.Fields(1).Value)) Then
                        .pbx_imgFuncionario.Load(Path.Combine(Application.StartupPath, "imgFuncionarios", rs.Fields(5).Value))
                        caminhoImagem = rs.Fields(5).Value
                    End If
                    .Show()
                End If
            End With
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar dados!")
            telaErro.Show()
            'MessageBox.Show(String.Format("Error editar item estoque: {0}", ex.Message))
        End Try
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
    End Sub

    Public Sub excluirFuncionario(codFuncionario As String)
        abreConexao()
        Try
            sql = "SELECT * FROM tb_funcionarios WHERE cod_funcionario =" & codFuncionario & ""
            rs = db.Execute(sql)
            If rs.EOF = False Then
                If funcionario.codFuncionario <> rs.Fields(0).Value Then
                    sql = "DELETE * FROM tb_funcionarios WHERE cod_funcionario = " & codFuncionario & ""
                    rs = db.Execute(sql)
                    telaConfirmacao.setTexto($"Deseja realmente excluir o funcionario {rs.Fields(3).Value}")
                    telaConfirmacao.setSub(Sub()
                                               sql = "DELETE * FROM tb_funcionarios WHERE cod_funcionario = " & codFuncionario & ""
                                               rs = db.Execute(sql)
                                               telaConfirmacao.Close()
                                           End Sub)
                Else
                    telaErro.setTexto("Não é possível excluir o próprio usuário!")
                    telaErro.Show()
                End If
            Else
                telaErro.setTexto("Funcionario inválido")
                telaErro.Show()
            End If
        Catch ex As Exception
            telaErro.setTexto("Erro ao excluir funcionário!")
            telaErro.Show()
            MessageBox.Show(String.Format("Error: {0}", ex.Message))

        End Try
    End Sub
End Class
