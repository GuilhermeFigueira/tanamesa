<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_cpf = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_senha = New Guna.UI.WinForms.GunaTextBox()
        Me.btn_entrar = New Guna.UI.WinForms.GunaButton()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Julius Sans One", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(70, 26)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(396, 70)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "TÁNAMESA!"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Libre Caslon Display", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(32, 234)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(182, 58)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "SENHA"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Libre Caslon Display", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(32, 138)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(111, 58)
        Me.GunaLabel3.TabIndex = 2
        Me.GunaLabel3.Text = "CPF"
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.Transparent
        Me.txt_cpf.BaseColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.txt_cpf.BorderColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txt_cpf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpf.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.txt_cpf.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txt_cpf.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_cpf.Font = New System.Drawing.Font("Libre Caslon Display", 30.0!)
        Me.txt_cpf.Location = New System.Drawing.Point(217, 138)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cpf.Radius = 12
        Me.txt_cpf.SelectedText = ""
        Me.txt_cpf.Size = New System.Drawing.Size(700, 60)
        Me.txt_cpf.TabIndex = 3
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.Transparent
        Me.txt_senha.BaseColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.txt_senha.BorderColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senha.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.txt_senha.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txt_senha.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_senha.Font = New System.Drawing.Font("Libre Caslon Display", 30.0!)
        Me.txt_senha.Location = New System.Drawing.Point(383, 234)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_senha.Radius = 12
        Me.txt_senha.SelectedText = ""
        Me.txt_senha.Size = New System.Drawing.Size(534, 60)
        Me.txt_senha.TabIndex = 4
        '
        'btn_entrar
        '
        Me.btn_entrar.AnimationHoverSpeed = 0.07!
        Me.btn_entrar.AnimationSpeed = 0.03!
        Me.btn_entrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_entrar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_entrar.BorderColor = System.Drawing.Color.Black
        Me.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_entrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_entrar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_entrar.Font = New System.Drawing.Font("Libre Caslon Display", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.ForeColor = System.Drawing.Color.White
        Me.btn_entrar.Image = Nothing
        Me.btn_entrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_entrar.Location = New System.Drawing.Point(553, 330)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_entrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_entrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_entrar.OnHoverImage = Nothing
        Me.btn_entrar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_entrar.Radius = 8
        Me.btn_entrar.Size = New System.Drawing.Size(364, 88)
        Me.btn_entrar.TabIndex = 5
        Me.btn_entrar.TabStop = False
        Me.btn_entrar.Text = "ENTRAR"
        Me.btn_entrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.BorderRadius = 12
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragStartTransparencyValue = 1.0R
        Me.Guna2BorderlessForm1.HasFormShadow = False
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(963, 454)
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_cpf As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_senha As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btn_entrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
