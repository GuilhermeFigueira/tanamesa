Imports System.Globalization
Imports System.Data.SqlClient
Imports Guna.UI2.WinForms
Imports System.IO
Module Module1
    Public db As ADODB.Connection
    Public rs, rs2 As New ADODB.Recordset
    Public sql, sql2 As String ' Queries CRUD in SQL language
    Public dir_banco = Application.StartupPath & "\banco\db.mdb"
    Public count, count2 As Integer
    Public caminhoImagem As String
    Public gerenciadorEstoque As New criarEstoque
    Public gerenciadorCardapio As New criarCardapio
    Public gerenciadorMesa As New criarMesas
    Public gerenciadorPedidos As New criarPedidos
    Public gerenciadorLogin As New criarLogin
    Public gerenciadorGerencia As New criarGerencia
    Public funcionario As New Usuario()
    Sub abreConexao()
        Try
            If db Is Nothing Then
                db = CreateObject("ADODB.Connection")
            End If
            If db.State <> 1 Then
                db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dir_banco)
                'MessageBox.Show(String.Format($"Connection opened successfully {db.State}"))
            End If
        Catch ex As Exception
            telaErro.setTexto("Erro ao conectar ao banco de dados!")
            telaErro.Show()
            ' MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Sub fechaConexao()
        'telaErro.setTexto("Fechando banco")
        'telaErro.Show()
        If db.State = 1 And db IsNot Nothing Then
            db.Close()
        End If
    End Sub

    Sub sair()
        telaConfirmacao.setSub(Sub()
                                   abreConexao()
                                   sql = "UPDATE tb_funcionarios SET trabalhando = false WHERE cpf = '" & funcionario.cpf & "'"
                                   rs = db.Execute(sql)
                                   funcionario.logout()
                                   fechaConexao()
                                   Application.Exit()
                               End Sub)
        telaConfirmacao.setTexto("Deseja realmente sair?")
        telaConfirmacao.Show()
    End Sub

    Public Function formatDate(data As Object) As String
        Dim dateTime As DateTime = DirectCast(data, DateTime)
        Dim dateOnly As String = dateTime.ToShortDateString()
        Return dateOnly
    End Function

    Public Sub carregarUnidades(cmb As Guna.UI2.WinForms.Guna2ComboBox)
        abreConexao()
        Try
            sql = "SELECT * FROM tb_unidade"
            rs = db.Execute(sql)
            With cmb
                If .Items.Count = 0 Then
                    Do While rs.EOF = False
                        .Items.Add(rs.Fields(1).Value)
                        rs.MoveNext()
                    Loop
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar unidades de medida!")
            telaErro.Show()
        End Try
        'fechaConexao()
    End Sub

    Public Sub carregarFuncionario(btn As Guna2Button, pbx As Guna2CirclePictureBox)
        btn.Text = funcionario.nome
        pbx.Load(Path.Combine(Application.StartupPath, "imgFuncionarios", funcionario.foto))
    End Sub
    Public Sub carregarCategorias(tabela As String, cmb As Guna2ComboBox)
        abreConexao()
        Try
            sql = "SELECT * FROM tb_categorias WHERE pertence = '" & tabela & "'"
            rs = db.Execute(sql)
            With cmb
                If .Items.Count = 0 Then
                    Do While rs.EOF = False
                        .Items.Add(rs.Fields(1).Value)
                        rs.MoveNext()
                    Loop
                End If
            End With
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar categorias!")
            telaErro.Show()
        End Try
    End Sub
    Public Sub carregarMesas(cmb As Guna.UI2.WinForms.Guna2ComboBox, status1 As String, status2 As String)
        abreConexao()
        Try
            sql = "SELECT * FROM tb_mesas WHERE status = '" & status1 & "' OR status = '" & status2 & "'"
            rs = db.Execute(sql)
            With cmb
                .Items.Clear()
                If .Items.Count = 0 Then
                    Do While rs.EOF = False
                        .Items.Add(rs.Fields(0).Value)
                        rs.MoveNext()
                    Loop
                End If
            End With
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar mesas!")
            telaErro.Show()
        End Try
    End Sub
    Public Function verificarVazio(itensArray As List(Of String))
        For Each item As String In itensArray
            If item = "" Then
                Return True
            End If
        Next
        Return False
    End Function
    Public Sub limparForm(parent As Control)
        For Each child As Control In parent.Controls
            limparForm(child)
        Next
        If TryCast(parent, Guna.UI2.WinForms.Guna2TextBox) IsNot Nothing Then
            TryCast(parent, Guna.UI2.WinForms.Guna2TextBox).Text = [String].Empty
        End If

    End Sub

    Public Class Usuario
        Public Property codFuncionario As String
        Public Property cpf As String
        Public Property nome As String
        Public Property funcao As String
        Public Property foto As String
        Public Property admin As Boolean

        Public Sub Initialize(codFuncionario As String, nome As String, cpf As String, funcao As String, foto As String, admin As Boolean)
            Me.codFuncionario = codFuncionario
            Me.nome = nome
            Me.cpf = cpf
            Me.funcao = funcao
            Me.foto = foto
            Me.admin = admin
        End Sub

        Public Sub logout()
            Me.codFuncionario = Nothing
            Me.nome = Nothing
            Me.cpf = Nothing
            Me.funcao = Nothing
            Me.foto = Nothing
            Me.admin = Nothing
        End Sub
    End Class
End Module
