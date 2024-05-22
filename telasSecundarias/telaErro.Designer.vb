<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class telaErro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(telaErro))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.btn_minimizar = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btn_fechar = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2ContainerControl1 = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.lbl_mensagem = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_ok = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2ContainerControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 12
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragStartTransparencyValue = 1.0R
        Me.Guna2BorderlessForm1.ResizeForm = False
        '
        'btn_minimizar
        '
        Me.btn_minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimizar.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimizar.HoverState.ImageSize = New System.Drawing.Size(18, 18)
        Me.btn_minimizar.Image = CType(resources.GetObject("btn_minimizar.Image"), System.Drawing.Image)
        Me.btn_minimizar.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btn_minimizar.ImageRotate = 0!
        Me.btn_minimizar.ImageSize = New System.Drawing.Size(16, 16)
        Me.btn_minimizar.Location = New System.Drawing.Point(5, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.PressedState.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_minimizar.Size = New System.Drawing.Size(30, 30)
        Me.btn_minimizar.TabIndex = 1
        '
        'btn_fechar
        '
        Me.btn_fechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_fechar.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_fechar.HoverState.ImageSize = New System.Drawing.Size(18, 18)
        Me.btn_fechar.Image = CType(resources.GetObject("btn_fechar.Image"), System.Drawing.Image)
        Me.btn_fechar.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btn_fechar.ImageRotate = 0!
        Me.btn_fechar.ImageSize = New System.Drawing.Size(16, 16)
        Me.btn_fechar.Location = New System.Drawing.Point(29, 0)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.PressedState.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_fechar.Size = New System.Drawing.Size(30, 30)
        Me.btn_fechar.TabIndex = 0
        '
        'Guna2ContainerControl1
        '
        Me.Guna2ContainerControl1.Controls.Add(Me.btn_fechar)
        Me.Guna2ContainerControl1.Controls.Add(Me.btn_minimizar)
        Me.Guna2ContainerControl1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ContainerControl1.Location = New System.Drawing.Point(414, 0)
        Me.Guna2ContainerControl1.Name = "Guna2ContainerControl1"
        Me.Guna2ContainerControl1.Size = New System.Drawing.Size(60, 30)
        Me.Guna2ContainerControl1.TabIndex = 2
        Me.Guna2ContainerControl1.Text = "Guna2ContainerControl1"
        '
        'lbl_mensagem
        '
        Me.lbl_mensagem.AutoSize = False
        Me.lbl_mensagem.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mensagem.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_mensagem.Font = New System.Drawing.Font("Libre Caslon Display", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mensagem.Location = New System.Drawing.Point(0, 0)
        Me.lbl_mensagem.Name = "lbl_mensagem"
        Me.lbl_mensagem.Size = New System.Drawing.Size(486, 126)
        Me.lbl_mensagem.TabIndex = 4
        Me.lbl_mensagem.Text = Nothing
        Me.lbl_mensagem.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_ok
        '
        Me.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ok.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_ok.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_ok.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_ok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_ok.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_ok.Font = New System.Drawing.Font("Libre Caslon Display", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(16, 101)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(453, 47)
        Me.btn_ok.TabIndex = 7
        Me.btn_ok.Text = "Ok"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.lbl_mensagem
        Me.Guna2DragControl1.TransparentWhileDrag = False
        '
        'telaErro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(486, 168)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.Guna2ContainerControl1)
        Me.Controls.Add(Me.lbl_mensagem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "telaErro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sair1"
        Me.Guna2ContainerControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2ContainerControl1 As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents btn_fechar As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btn_minimizar As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents lbl_mensagem As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_ok As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
