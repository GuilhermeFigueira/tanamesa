Module Module1
    Public Class MoveForm
        Private mouseOffset As Point
        Private isMouseDown As Boolean = False
        Public Sub MouseDown(e As MouseEventArgs)
            If e.Button = Windows.Forms.MouseButtons.Left Then
                mouseOffset = New Point(-e.X, -e.Y)
                isMouseDown = True
            End If
        End Sub
        Public Sub MouseMove(form As Form)
            If isMouseDown Then
                System.Diagnostics.Debug.WriteLine(form)
                Dim mousePos As Point = Control.MousePosition
                ' Get the new form position
                mousePos.Offset(mouseOffset.X, mouseOffset.Y)
                form.Location = mousePos
            End If
        End Sub

        Public Sub MouseUp(e As MouseEventArgs)
            If e.Button = Windows.Forms.MouseButtons.Left Then
                isMouseDown = False
            End If
        End Sub
    End Class
    Sub Fechar()
        ' sair.show()
    End Sub
End Module
