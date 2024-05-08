Partial Class Component1
    Inherits System.ComponentModel.Component

    <System.Diagnostics.DebuggerNonUserCode()>
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Exigido para suporte ao Designer de Composição da Classe Windows.Forms
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()>
    Public Sub New()
        MyBase.New()

        'Esta chamada é exigida pelo Designer de Componentes.
        InitializeComponent()

    End Sub

    'O componente substitui o descarte para limpar a lista de componentes.
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

    'Exigido pelo Designer de Componentes
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Designer de Componentes
    'Pode ser modificado usando o Designer de Componentes.
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Component1))
        Me.btn_default = New Guna.UI2.WinForms.Guna2Button()
        '
        'btn_default
        '
        Me.btn_default.AutoRoundedCorners = True
        Me.btn_default.BackColor = System.Drawing.Color.Transparent
        Me.btn_default.BorderRadius = 22
        Me.btn_default.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_default.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_default.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_default.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_default.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_default.FillColor = System.Drawing.Color.Transparent
        Me.btn_default.Font = New System.Drawing.Font("Libre Caslon Display", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_default.ForeColor = System.Drawing.Color.Black
        Me.btn_default.Image = CType(resources.GetObject("btn_default.Image"), System.Drawing.Image)
        Me.btn_default.Location = New System.Drawing.Point(21, 252)
        Me.btn_default.Name = "btn_default"
        Me.btn_default.Size = New System.Drawing.Size(219, 47)
        Me.btn_default.TabIndex = 21
        Me.btn_default.Text = "Button"

    End Sub

    Friend WithEvents btn_default As Guna.UI2.WinForms.Guna2Button
End Class
