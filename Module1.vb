Imports System.Globalization
Imports System.Data.SqlClient
Module Module1
    Public db As ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As String ' Queries CRUD in SQL language
    Public dir_banco = Application.StartupPath & "\banco\db.mdb"
    Public count As Integer
    Public caminhoImagem As String
    Public gerenciadorEstoque As New criarEstoque
    Public gerenciadorCardapio As New criarCardapio


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
        telaConfirmacao.setSub(Sub() Application.Exit())
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
    Public Sub carregarCategorias(tabela As String, cmb As Guna.UI2.WinForms.Guna2ComboBox)
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
    Public Sub carregarMesas(cmb As Guna.UI2.WinForms.Guna2ComboBox)
        abreConexao()
        Try
            sql = "SELECT * FROM tb_mesas WHERE status = 'fechada'"
            rs = db.Execute(sql)
            With cmb
                If .Items.Count = 0 Then
                    Do While rs.EOF = False
                        .Items.Add(rs.Fields(0).Value)
                        MessageBox.Show(String.Format($"{rs.Fields(0).Value}"))

                        rs.MoveNext()
                    Loop
                End If
            End With
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar mesas!")
            telaErro.Show()
        End Try
    End Sub
End Module
