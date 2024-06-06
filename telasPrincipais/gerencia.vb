Imports System.IO
Imports System.Text.RegularExpressions
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
        If funcionario.admin = True Then
            btn_gerencia.Visible = True
        Else
            btn_addProd.Visible = False
        End If
    End Sub

    Private Sub btn_addProd_Click(sender As Object, e As EventArgs) Handles btn_addProd.Click
        cadastrarFuncionario.Show()
    End Sub

    Private Sub gerencia_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If funcionario.admin = True Then
            btn_gerencia.Visible = True
        Else
            btn_addProd.Visible = False
        End If
    End Sub
    Public Sub verificarFuncionario()
        If funcionario.admin = True Then
            btn_gerencia.Visible = True
        Else
            btn_addProd.Visible = False
        End If
    End Sub
End Class

Public Class criarGerencia

    Public Sub carregarFuncionarios()
        abreConexao()
        Try
            sql = "SELECT * FROM tb_funcionarios"
            rs = db.Execute(sql)
            gerencia.flp_itemsCard.Controls.Clear()
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
                    .Image = Image.FromFile(Path.Combine(Application.StartupPath, "imgFuncionarios", rs.Fields(5).Value)),
                    .Parent = pnl_funcionario,
                    .Location = New Point(58, 15),
                    .SizeMode = PictureBoxSizeMode.StretchImage
                }
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
                    .Location = New Point(3, 40),
                    .Parent = pnl_info,
                    .AutoSize = False,
                    .Size = New Size(253, 27),
                    .TextAlignment = ContentAlignment.BottomCenter
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
                If rs.Fields(7).Value = True Then
                    lbl_statusFuncionario.Text = "Trabalhando"
                    lbl_statusFuncionario.ForeColor = Color.FromArgb(48, 107, 52)
                Else
                    lbl_statusFuncionario.Text = "Ausente"
                    lbl_statusFuncionario.ForeColor = Color.FromArgb(255, 67, 101)
                End If
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
            'If ValidarCPF(cpf) = True Then
            If verificarVazio(itensList) = False Then
                    sql = "SELECT * FROM tb_funcionarios WHERE cpf = '" & cpf & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = True Then
                        sql = "INSERT INTO tb_funcionarios (CPF, SENHA, NOME, FUNCAO, FOTO, ADMIN) VALUES('" & cpf & "', '" & senha & "', '" & nome & "', '" & funcao & "', '" & caminhoImagem & "', " & adm & ")"
                        rs = db.Execute(sql)
                        telaErro.setTexto($"{nome} foi cadastrado com sucesso!")
                        telaErro.Show()
                        carregarFuncionarios()
                    Else
                        telaErro.setTexto($"O CPF {cpf} já está cadastrado!")
                        telaErro.Show()
                    End If
                Else
                    telaErro.setTexto("Existem campos vazios!")
                    telaErro.Show()
                End If
            ' Else
            'telaErro.setTexto("CPF inválido!")
            'telaErro.Show()
            'End If

        Catch ex As Exception
            MessageBox.Show(String.Format("Efetuar pedido: {0}", ex.Message))
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
                    If File.Exists(Path.Combine(Application.StartupPath, "imgFuncionarios", rs.Fields(5).Value)) Then
                        .pbx_imgFuncionario.Load(Path.Combine(Application.StartupPath, "imgFuncionarios", rs.Fields(5).Value))
                        caminhoImagem = rs.Fields(5).Value
                    End If
                    .Show()
                End If
            End With
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar dados!")
            telaErro.Show()
        End Try
    End Sub

    Public Sub editarFuncionario(codFuncionario As String)
        abreConexao()
        Dim itensList As New List(Of String)
        Dim nome As String = maisInformacoesFuncionario.txt_nome.Text
        Dim cpf As String = maisInformacoesFuncionario.txt_cpf.Text
        Dim senha As String = maisInformacoesFuncionario.txt_senha.Text
        Dim funcao As String = maisInformacoesFuncionario.txt_funcao.Text
        itensList.Add(nome)
        itensList.Add(cpf)
        itensList.Add(senha)
        itensList.Add(funcao)
        Try
            If verificarVazio(itensList) = False Then
                sql = "UPDATE tb_funcionarios SET foto='" & caminhoImagem & "', nome ='" & nome & "', senha ='" & senha & "', funcao='" & funcao & "' WHERE cod_funcionario=" & codFuncionario & " and cpf = '" & cpf & "'"
                rs = db.Execute(sql)
                telaErro.setTexto($"{nome} foi editado com sucesso!")
                telaErro.Show()
                carregarFuncionarios()
            Else
                telaErro.setTexto("Existem campos vazios!")
                telaErro.Show()
            End If
        Catch ex As Exception
            telaErro.setTexto("Erro ao editar informações do funcionário!")
            telaErro.Show()
        End Try
    End Sub

    Public Sub excluirFuncionario(codFuncionario)
        abreConexao()
        Try
            sql = "SELECT * FROM tb_funcionarios WHERE cod_funcionario =" & codFuncionario & ""
            rs = db.Execute(sql)
            If rs.EOF = False Then
                If funcionario.codFuncionario <> rs.Fields(0).Value Then
                    telaConfirmacao.setTexto($"Deseja realmente excluir o funcionario {rs.Fields(3).Value}?")
                    telaConfirmacao.setSub(Sub()
                                               sql = "DELETE * FROM tb_funcionarios WHERE cod_funcionario = " & codFuncionario & ""
                                               rs = db.Execute(sql)
                                               gerenciadorGerencia.carregarFuncionarios()
                                               maisInformacoesFuncionario.Close()
                                               telaConfirmacao.Close()
                                           End Sub)
                    telaConfirmacao.Show()
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
        End Try
    End Sub

    Public Sub carregarCadastroFuncionario()
        abreConexao()
        Try
            Dim codFuncionario As Integer
            sql = "SELECT TOP 1 * FROM tb_funcionarios ORDER BY cod_funcionario DESC"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                codFuncionario = rs.Fields(0).Value + 1
            Else
                codFuncionario = 1
            End If
            cadastrarFuncionario.txt_codFunc.Text = codFuncionario
        Catch ex As Exception
            telaErro.setTexto("Erro ao definir o código do funcionario!")
            telaErro.Show()
        End Try
    End Sub

    ' Public Function ValidarCPF(cpf As String) As Boolean
    '     Dim regex As New Regex("^\d{11}$")
    '     If Not regex.IsMatch(cpf) Then Return False
    '
    '     Dim numeros() As Char = cpf.ToCharArray()
    '     Dim somaTotal As Integer = 0
    '
    '     ' Primeiro dígito verificador
    '     For i As Integer = 0 To 8 Step 2
    '         somaTotal += CInt(numeros(i).ToString())
    '     Next
    '
    '     somaTotal *= 10
    '     somaTotal = somaTotal Mod 11 ' Correção aqui
    '     If somaTotal < 2 Then somaTotal = 0 Else somaTotal -= 1
    '
    '     If CInt(numeros(9).ToString()) <> somaTotal Then Return False
    '
    '     ' Segundo dígito verificador
    '     For i As Integer = 0 To 9 Step 2
    '         somaTotal = 0
    '         For j As Integer = 0 To 8 Step 2
    '             somaTotal += CInt(numeros(j).ToString())
    '         Next
    '         somaTotal += CInt(numeros(i).ToString())
    '         somaTotal *= 10
    '         somaTotal = somaTotal Mod 11 ' E também aqui
    '         If somaTotal < 2 Then somaTotal = 0 Else somaTotal -= 1
    '         If CInt(numeros(10).ToString()) <> somaTotal Then Return False
    '     Next
    '
    '     Return True
    ' End Function

End Class
