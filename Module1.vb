﻿Module Module1
    Public diretorio As String
    Public db As ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, aux_cpf, resp As String ' Querys CRUD linguagem SQL
    Public dir_banco = Application.StartupPath & "\banco\db.mdb"
    Public count As Integer

    Sub conecta_banco_access()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dir_banco)
            telaErro.setTexto("Conexão com o banco de dados OK")
            telaErro.Show()
        Catch ex As Exception
            telaErro.setTexto("Erro de conexão com o banco de dados")
            telaErro.Show()
            'MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
End Module