Imports System.Globalization

Module Module1
    Public db As ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As String ' Querys CRUD linguagem SQL
    Public dir_banco = Application.StartupPath & "\banco\db.mdb"
    Public count As Integer
    Public caminhoImagem As String
    Public gerenciadorEstoque As New criarEstoque

    Sub abreConexao()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dir_banco)
            'telaErro.setTexto("Conexão com o banco de dados OK")
            'telaErro.Show()
        Catch ex As Exception
            telaErro.setTexto("Erro de conexão com o banco de dados")
            telaErro.Show()
            'MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Sub fechaConexao()
        'telaErro.setTexto("Fechando banco")
        'telaErro.Show()
        db.Close()
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
                .Items.Clear()
                Do While rs.EOF = False
                    .Items.Add(rs.Fields(1).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            telaErro.setTexto("Erro ao carregar unidades de medida!")
            telaErro.Show()
        End Try
        fechaConexao()
    End Sub
End Module
