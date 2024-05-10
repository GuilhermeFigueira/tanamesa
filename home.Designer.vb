<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.btn_minimizar = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btn_fechar = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btn_sair = New Guna.UI2.WinForms.Guna2Button()
        Me.pnl_controls = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnl_logo = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_estoque = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_gerencia = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_mesas = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_pedidos = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_cardapio = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ContainerControl1 = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.pnl_title = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_controls.SuspendLayout()
        Me.pnl_logo.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2ContainerControl1.SuspendLayout()
        Me.pnl_title.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 12
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragStartTransparencyValue = 1.0R
        Me.Guna2BorderlessForm1.HasFormShadow = False
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'btn_minimizar
        '
        Me.btn_minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimizar.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimizar.HoverState.ImageSize = New System.Drawing.Size(18, 18)
        Me.btn_minimizar.Image = CType(resources.GetObject("btn_minimizar.Image"), System.Drawing.Image)
        Me.btn_minimizar.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btn_minimizar.ImageRotate = 0!
        Me.btn_minimizar.ImageSize = New System.Drawing.Size(16, 16)
        Me.btn_minimizar.Location = New System.Drawing.Point(6, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.PressedState.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_minimizar.Size = New System.Drawing.Size(30, 30)
        Me.btn_minimizar.TabIndex = 1
        '
        'btn_fechar
        '
        Me.btn_fechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_fechar.BackColor = System.Drawing.Color.Transparent
        Me.btn_fechar.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_fechar.HoverState.ImageSize = New System.Drawing.Size(18, 18)
        Me.btn_fechar.Image = CType(resources.GetObject("btn_fechar.Image"), System.Drawing.Image)
        Me.btn_fechar.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btn_fechar.ImageRotate = 0!
        Me.btn_fechar.ImageSize = New System.Drawing.Size(16, 16)
        Me.btn_fechar.Location = New System.Drawing.Point(30, 0)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.PressedState.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_fechar.Size = New System.Drawing.Size(30, 30)
        Me.btn_fechar.TabIndex = 0
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.Transparent
        Me.btn_sair.BorderRadius = 12
        Me.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sair.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_sair.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_sair.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_sair.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_sair.FillColor = System.Drawing.Color.White
        Me.btn_sair.Font = New System.Drawing.Font("Libre Caslon Display", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.ForeColor = System.Drawing.Color.Black
        Me.btn_sair.Location = New System.Drawing.Point(63, 89)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(86, 42)
        Me.btn_sair.TabIndex = 30
        Me.btn_sair.Text = "Sair"
        '
        'pnl_controls
        '
        Me.pnl_controls.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.pnl_controls.Controls.Add(Me.pnl_logo)
        Me.pnl_controls.Controls.Add(Me.Guna2Panel3)
        Me.pnl_controls.Controls.Add(Me.Guna2Panel2)
        Me.pnl_controls.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_controls.Location = New System.Drawing.Point(980, 0)
        Me.pnl_controls.Name = "pnl_controls"
        Me.pnl_controls.Padding = New System.Windows.Forms.Padding(0, 31, 0, 31)
        Me.pnl_controls.Size = New System.Drawing.Size(220, 800)
        Me.pnl_controls.TabIndex = 31
        '
        'pnl_logo
        '
        Me.pnl_logo.Controls.Add(Me.Guna2HtmlLabel5)
        Me.pnl_logo.Controls.Add(Me.Guna2HtmlLabel3)
        Me.pnl_logo.Controls.Add(Me.Guna2HtmlLabel4)
        Me.pnl_logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_logo.Location = New System.Drawing.Point(0, 31)
        Me.pnl_logo.Name = "pnl_logo"
        Me.pnl_logo.Size = New System.Drawing.Size(220, 179)
        Me.pnl_logo.TabIndex = 35
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Julius Sans One", 28.0!)
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(57, 106)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(103, 42)
        Me.Guna2HtmlLabel5.TabIndex = 6
        Me.Guna2HtmlLabel5.Text = "MESA"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Julius Sans One", 28.0!)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(85, 10)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(49, 42)
        Me.Guna2HtmlLabel3.TabIndex = 4
        Me.Guna2HtmlLabel3.Text = "TÁ"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Julius Sans One", 28.0!)
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(80, 58)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(60, 42)
        Me.Guna2HtmlLabel4.TabIndex = 5
        Me.Guna2HtmlLabel4.Text = "NA"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Panel3.Controls.Add(Me.btn_sair)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 630)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(220, 139)
        Me.Guna2Panel3.TabIndex = 34
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(45, 3)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.Guna2CirclePictureBox1.TabIndex = 32
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Julius Sans One", 16.0!)
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(101, 14)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(65, 25)
        Me.Guna2HtmlLabel6.TabIndex = 31
        Me.Guna2HtmlLabel6.Text = "nome"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.btn_estoque)
        Me.Guna2Panel2.Controls.Add(Me.btn_gerencia)
        Me.Guna2Panel2.Controls.Add(Me.btn_mesas)
        Me.Guna2Panel2.Controls.Add(Me.btn_pedidos)
        Me.Guna2Panel2.Controls.Add(Me.btn_cardapio)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 31)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(220, 738)
        Me.Guna2Panel2.TabIndex = 33
        '
        'btn_estoque
        '
        Me.btn_estoque.BackColor = System.Drawing.Color.Transparent
        Me.btn_estoque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_estoque.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_estoque.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_estoque.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_estoque.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_estoque.FillColor = System.Drawing.Color.Transparent
        Me.btn_estoque.Font = New System.Drawing.Font("Libre Caslon Display", 24.25!)
        Me.btn_estoque.ForeColor = System.Drawing.Color.Black
        Me.btn_estoque.Image = CType(resources.GetObject("btn_estoque.Image"), System.Drawing.Image)
        Me.btn_estoque.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_estoque.ImageSize = New System.Drawing.Size(25, 25)
        Me.btn_estoque.Location = New System.Drawing.Point(3, 416)
        Me.btn_estoque.Name = "btn_estoque"
        Me.btn_estoque.Size = New System.Drawing.Size(217, 54)
        Me.btn_estoque.TabIndex = 32
        Me.btn_estoque.Text = "Estoque"
        '
        'btn_gerencia
        '
        Me.btn_gerencia.BackColor = System.Drawing.Color.Transparent
        Me.btn_gerencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_gerencia.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_gerencia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_gerencia.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_gerencia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_gerencia.FillColor = System.Drawing.Color.Transparent
        Me.btn_gerencia.Font = New System.Drawing.Font("Libre Caslon Display", 24.25!)
        Me.btn_gerencia.ForeColor = System.Drawing.Color.Black
        Me.btn_gerencia.Image = CType(resources.GetObject("btn_gerencia.Image"), System.Drawing.Image)
        Me.btn_gerencia.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_gerencia.ImageSize = New System.Drawing.Size(25, 25)
        Me.btn_gerencia.Location = New System.Drawing.Point(3, 482)
        Me.btn_gerencia.Name = "btn_gerencia"
        Me.btn_gerencia.Size = New System.Drawing.Size(217, 54)
        Me.btn_gerencia.TabIndex = 32
        Me.btn_gerencia.Text = "Gerência"
        '
        'btn_mesas
        '
        Me.btn_mesas.BackColor = System.Drawing.Color.Transparent
        Me.btn_mesas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mesas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_mesas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_mesas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_mesas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_mesas.FillColor = System.Drawing.Color.Transparent
        Me.btn_mesas.Font = New System.Drawing.Font("Libre Caslon Display", 24.25!)
        Me.btn_mesas.ForeColor = System.Drawing.Color.Black
        Me.btn_mesas.Image = CType(resources.GetObject("btn_mesas.Image"), System.Drawing.Image)
        Me.btn_mesas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_mesas.ImageSize = New System.Drawing.Size(25, 25)
        Me.btn_mesas.Location = New System.Drawing.Point(3, 350)
        Me.btn_mesas.Name = "btn_mesas"
        Me.btn_mesas.Size = New System.Drawing.Size(217, 54)
        Me.btn_mesas.TabIndex = 32
        Me.btn_mesas.Text = "Mesas"
        '
        'btn_pedidos
        '
        Me.btn_pedidos.BackColor = System.Drawing.Color.Transparent
        Me.btn_pedidos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_pedidos.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_pedidos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_pedidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_pedidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_pedidos.FillColor = System.Drawing.Color.Transparent
        Me.btn_pedidos.Font = New System.Drawing.Font("Libre Caslon Display", 24.25!)
        Me.btn_pedidos.ForeColor = System.Drawing.Color.Black
        Me.btn_pedidos.Image = CType(resources.GetObject("btn_pedidos.Image"), System.Drawing.Image)
        Me.btn_pedidos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_pedidos.ImageSize = New System.Drawing.Size(25, 25)
        Me.btn_pedidos.Location = New System.Drawing.Point(3, 284)
        Me.btn_pedidos.Name = "btn_pedidos"
        Me.btn_pedidos.Size = New System.Drawing.Size(217, 54)
        Me.btn_pedidos.TabIndex = 32
        Me.btn_pedidos.Text = "Pedidos"
        '
        'btn_cardapio
        '
        Me.btn_cardapio.BackColor = System.Drawing.Color.White
        Me.btn_cardapio.BorderThickness = 1
        Me.btn_cardapio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cardapio.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_cardapio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_cardapio.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_cardapio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_cardapio.FillColor = System.Drawing.Color.Transparent
        Me.btn_cardapio.Font = New System.Drawing.Font("Libre Caslon Display", 24.25!)
        Me.btn_cardapio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_cardapio.Image = CType(resources.GetObject("btn_cardapio.Image"), System.Drawing.Image)
        Me.btn_cardapio.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_cardapio.ImageSize = New System.Drawing.Size(25, 25)
        Me.btn_cardapio.Location = New System.Drawing.Point(1, 218)
        Me.btn_cardapio.Name = "btn_cardapio"
        Me.btn_cardapio.Size = New System.Drawing.Size(219, 54)
        Me.btn_cardapio.TabIndex = 32
        Me.btn_cardapio.Text = "Cardápio"
        '
        'Guna2ContainerControl1
        '
        Me.Guna2ContainerControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Guna2ContainerControl1.Controls.Add(Me.btn_fechar)
        Me.Guna2ContainerControl1.Controls.Add(Me.btn_minimizar)
        Me.Guna2ContainerControl1.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Guna2ContainerControl1.Location = New System.Drawing.Point(1128, 0)
        Me.Guna2ContainerControl1.Name = "Guna2ContainerControl1"
        Me.Guna2ContainerControl1.Size = New System.Drawing.Size(60, 30)
        Me.Guna2ContainerControl1.TabIndex = 2
        Me.Guna2ContainerControl1.Text = "Guna2ContainerControl1"
        '
        'pnl_title
        '
        Me.pnl_title.Controls.Add(Me.Guna2TextBox2)
        Me.pnl_title.Controls.Add(Me.Guna2HtmlLabel7)
        Me.pnl_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_title.FillColor = System.Drawing.Color.White
        Me.pnl_title.Location = New System.Drawing.Point(0, 0)
        Me.pnl_title.Name = "pnl_title"
        Me.pnl_title.Padding = New System.Windows.Forms.Padding(46, 0, 46, 0)
        Me.pnl_title.Size = New System.Drawing.Size(980, 80)
        Me.pnl_title.TabIndex = 32
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.AutoRoundedCorners = True
        Me.Guna2TextBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Guna2TextBox2.BorderRadius = 17
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Libre Caslon Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox2.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Guna2TextBox2.IconLeft = CType(resources.GetObject("Guna2TextBox2.IconLeft"), System.Drawing.Image)
        Me.Guna2TextBox2.Location = New System.Drawing.Point(518, 24)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.Padding = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderText = "Pesquise itens do cardápio"
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(413, 36)
        Me.Guna2TextBox2.TabIndex = 33
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Libre Caslon Display", 30.0!)
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(49, 15)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(141, 51)
        Me.Guna2HtmlLabel7.TabIndex = 33
        Me.Guna2HtmlLabel7.Text = "Cardápio"
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.pnl_title)
        Me.Controls.Add(Me.Guna2ContainerControl1)
        Me.Controls.Add(Me.pnl_controls)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formDefault1"
        Me.pnl_controls.ResumeLayout(False)
        Me.pnl_logo.ResumeLayout(False)
        Me.pnl_logo.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2ContainerControl1.ResumeLayout(False)
        Me.pnl_title.ResumeLayout(False)
        Me.pnl_title.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents btn_fechar As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btn_minimizar As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btn_sair As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnl_controls As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ContainerControl1 As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents btn_cardapio As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_pedidos As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnl_logo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_gerencia As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btn_mesas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_estoque As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents pnl_title As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
