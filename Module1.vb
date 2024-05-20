Module Module1
    Public diretorio As String
    'Public db As ADODB.Connection
    'Public rs As New ADODB.Recordset
    Public sql, aux_cpf, resp As String ' Querys CRUD linguagem SQL
    Public dir_banco = Application.StartupPath & "\Banco\cadastro.mdb"
    Public cont As Integer

    Sub conecta_banco_access()
        Try
            'db = CreateObject("ADODB.Connection")
            'db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dir_banco)
            MsgBox("Conexao OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro de conexao", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            'MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
End Module
