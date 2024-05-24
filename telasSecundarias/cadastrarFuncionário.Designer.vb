<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cadastrarFuncionário
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastrarFuncionário))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.btn_minimizar = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btn_fechar = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2ContainerControl1 = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.lbl_titulo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_nome = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_nome = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_cpf = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_senha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnl_titulo = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_cadastrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pbx_imagem = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnl_info = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_codFunc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_funcao = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ofd_imagem = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2ContainerControl1.SuspendLayout()
        Me.pnl_nome.SuspendLayout()
        Me.pnl_titulo.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.pbx_imagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_info.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 12
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragStartTransparencyValue = 1.0R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
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
        Me.Guna2ContainerControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Guna2ContainerControl1.Controls.Add(Me.btn_fechar)
        Me.Guna2ContainerControl1.Controls.Add(Me.btn_minimizar)
        Me.Guna2ContainerControl1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ContainerControl1.Location = New System.Drawing.Point(827, 3)
        Me.Guna2ContainerControl1.Name = "Guna2ContainerControl1"
        Me.Guna2ContainerControl1.Size = New System.Drawing.Size(60, 30)
        Me.Guna2ContainerControl1.TabIndex = 2
        Me.Guna2ContainerControl1.Text = "Guna2ContainerControl1"
        '
        'lbl_titulo
        '
        Me.lbl_titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl_titulo.Font = New System.Drawing.Font("Libre Caslon Display", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(12, 8)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(227, 35)
        Me.lbl_titulo.TabIndex = 5
        Me.lbl_titulo.Text = "Cadastrar Funcionário"
        '
        'txt_nome
        '
        Me.txt_nome.AutoRoundedCorners = True
        Me.txt_nome.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_nome.BorderRadius = 17
        Me.txt_nome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_nome.DefaultText = ""
        Me.txt_nome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_nome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_nome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nome.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_nome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txt_nome.Font = New System.Drawing.Font("Libre Caslon Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.ForeColor = System.Drawing.Color.Black
        Me.txt_nome.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txt_nome.Location = New System.Drawing.Point(14, 44)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nome.PlaceholderText = ""
        Me.txt_nome.SelectedText = ""
        Me.txt_nome.Size = New System.Drawing.Size(570, 36)
        Me.txt_nome.TabIndex = 1
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Libre Caslon Display", 15.75!)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(14, 10)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(51, 27)
        Me.Guna2HtmlLabel1.TabIndex = 7
        Me.Guna2HtmlLabel1.Text = "Nome"
        '
        'pnl_nome
        '
        Me.pnl_nome.BackColor = System.Drawing.Color.Transparent
        Me.pnl_nome.Controls.Add(Me.Guna2HtmlLabel4)
        Me.pnl_nome.Controls.Add(Me.Guna2HtmlLabel3)
        Me.pnl_nome.Controls.Add(Me.txt_nome)
        Me.pnl_nome.Controls.Add(Me.Guna2HtmlLabel1)
        Me.pnl_nome.Controls.Add(Me.txt_cpf)
        Me.pnl_nome.Controls.Add(Me.txt_senha)
        Me.pnl_nome.FillColor = System.Drawing.Color.White
        Me.pnl_nome.Location = New System.Drawing.Point(16, 16)
        Me.pnl_nome.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_nome.Name = "pnl_nome"
        Me.pnl_nome.Radius = 6
        Me.pnl_nome.ShadowColor = System.Drawing.Color.Black
        Me.pnl_nome.ShadowShift = 2
        Me.pnl_nome.Size = New System.Drawing.Size(597, 187)
        Me.pnl_nome.TabIndex = 11
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Libre Caslon Display", 15.75!)
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(304, 91)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(52, 27)
        Me.Guna2HtmlLabel4.TabIndex = 14
        Me.Guna2HtmlLabel4.Text = "Senha"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Libre Caslon Display", 15.75!)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(14, 91)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(41, 27)
        Me.Guna2HtmlLabel3.TabIndex = 9
        Me.Guna2HtmlLabel3.Text = "CPF"
        '
        'txt_cpf
        '
        Me.txt_cpf.AutoRoundedCorners = True
        Me.txt_cpf.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_cpf.BorderRadius = 17
        Me.txt_cpf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_cpf.DefaultText = ""
        Me.txt_cpf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_cpf.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_cpf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cpf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cpf.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_cpf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txt_cpf.Font = New System.Drawing.Font("Libre Caslon Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.ForeColor = System.Drawing.Color.Black
        Me.txt_cpf.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txt_cpf.Location = New System.Drawing.Point(14, 125)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cpf.PlaceholderText = ""
        Me.txt_cpf.SelectedText = ""
        Me.txt_cpf.Size = New System.Drawing.Size(280, 36)
        Me.txt_cpf.TabIndex = 2
        '
        'txt_senha
        '
        Me.txt_senha.AutoRoundedCorners = True
        Me.txt_senha.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_senha.BorderRadius = 17
        Me.txt_senha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_senha.DefaultText = ""
        Me.txt_senha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_senha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_senha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_senha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_senha.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_senha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txt_senha.Font = New System.Drawing.Font("Libre Caslon Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.ForeColor = System.Drawing.Color.Black
        Me.txt_senha.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txt_senha.Location = New System.Drawing.Point(304, 125)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.PlaceholderText = ""
        Me.txt_senha.SelectedText = ""
        Me.txt_senha.Size = New System.Drawing.Size(280, 36)
        Me.txt_senha.TabIndex = 3
        '
        'pnl_titulo
        '
        Me.pnl_titulo.Controls.Add(Me.Guna2ContainerControl1)
        Me.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_titulo.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.pnl_titulo.Location = New System.Drawing.Point(0, 0)
        Me.pnl_titulo.Name = "pnl_titulo"
        Me.pnl_titulo.Size = New System.Drawing.Size(899, 50)
        Me.pnl_titulo.TabIndex = 12
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 1.0R
        Me.Guna2DragControl1.TargetControl = Me.pnl_titulo
        Me.Guna2DragControl1.TransparentWhileDrag = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.btn_cadastrar)
        Me.Guna2Panel2.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Guna2Panel2.Controls.Add(Me.pnl_info)
        Me.Guna2Panel2.Controls.Add(Me.pnl_nome)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Padding = New System.Windows.Forms.Padding(16)
        Me.Guna2Panel2.Size = New System.Drawing.Size(899, 361)
        Me.Guna2Panel2.TabIndex = 13
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.AutoRoundedCorners = True
        Me.btn_cadastrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_cadastrar.BorderRadius = 22
        Me.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cadastrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_cadastrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_cadastrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_cadastrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_cadastrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_cadastrar.Font = New System.Drawing.Font("Libre Caslon Display", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar.Image = CType(resources.GetObject("btn_cadastrar.Image"), System.Drawing.Image)
        Me.btn_cadastrar.ImageSize = New System.Drawing.Size(28, 28)
        Me.btn_cadastrar.Location = New System.Drawing.Point(634, 289)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(242, 47)
        Me.btn_cadastrar.TabIndex = 6
        Me.btn_cadastrar.Text = "Cadastrar Funcionário"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Guna2ShadowPanel1.Controls.Add(Me.pbx_imagem)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(634, 16)
        Me.Guna2ShadowPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 6
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowShift = 2
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(242, 253)
        Me.Guna2ShadowPanel1.TabIndex = 13
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Libre Caslon Display", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(25, 6)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(72, 31)
        Me.Guna2HtmlLabel10.TabIndex = 17
        Me.Guna2HtmlLabel10.Text = "Imagem"
        '
        'pbx_imagem
        '
        Me.pbx_imagem.BorderRadius = 17
        Me.pbx_imagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbx_imagem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbx_imagem.ImageRotate = 0!
        Me.pbx_imagem.Location = New System.Drawing.Point(30, 44)
        Me.pbx_imagem.Name = "pbx_imagem"
        Me.pbx_imagem.Size = New System.Drawing.Size(183, 183)
        Me.pbx_imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_imagem.TabIndex = 18
        Me.pbx_imagem.TabStop = False
        '
        'pnl_info
        '
        Me.pnl_info.BackColor = System.Drawing.Color.Transparent
        Me.pnl_info.Controls.Add(Me.Guna2HtmlLabel2)
        Me.pnl_info.Controls.Add(Me.Guna2HtmlLabel5)
        Me.pnl_info.Controls.Add(Me.txt_codFunc)
        Me.pnl_info.Controls.Add(Me.txt_funcao)
        Me.pnl_info.FillColor = System.Drawing.Color.White
        Me.pnl_info.Location = New System.Drawing.Point(16, 224)
        Me.pnl_info.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_info.Name = "pnl_info"
        Me.pnl_info.Radius = 6
        Me.pnl_info.ShadowColor = System.Drawing.Color.Black
        Me.pnl_info.ShadowShift = 2
        Me.pnl_info.Size = New System.Drawing.Size(597, 112)
        Me.pnl_info.TabIndex = 12
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Libre Caslon Display", 15.75!)
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(218, 18)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(61, 27)
        Me.Guna2HtmlLabel2.TabIndex = 21
        Me.Guna2HtmlLabel2.Text = "Função"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Libre Caslon Display", 15.75!)
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(14, 18)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(185, 27)
        Me.Guna2HtmlLabel5.TabIndex = 20
        Me.Guna2HtmlLabel5.Text = "Código do Funcionário"
        '
        'txt_codFunc
        '
        Me.txt_codFunc.AutoRoundedCorners = True
        Me.txt_codFunc.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_codFunc.BorderRadius = 17
        Me.txt_codFunc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_codFunc.DefaultText = ""
        Me.txt_codFunc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_codFunc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_codFunc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_codFunc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_codFunc.Enabled = False
        Me.txt_codFunc.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_codFunc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txt_codFunc.Font = New System.Drawing.Font("Libre Caslon Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codFunc.ForeColor = System.Drawing.Color.Black
        Me.txt_codFunc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txt_codFunc.Location = New System.Drawing.Point(14, 52)
        Me.txt_codFunc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_codFunc.Name = "txt_codFunc"
        Me.txt_codFunc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_codFunc.PlaceholderText = ""
        Me.txt_codFunc.SelectedText = ""
        Me.txt_codFunc.Size = New System.Drawing.Size(185, 36)
        Me.txt_codFunc.TabIndex = 4
        '
        'txt_funcao
        '
        Me.txt_funcao.AutoRoundedCorners = True
        Me.txt_funcao.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_funcao.BorderRadius = 17
        Me.txt_funcao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_funcao.DefaultText = ""
        Me.txt_funcao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_funcao.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_funcao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_funcao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_funcao.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_funcao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txt_funcao.Font = New System.Drawing.Font("Libre Caslon Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_funcao.ForeColor = System.Drawing.Color.Black
        Me.txt_funcao.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txt_funcao.Location = New System.Drawing.Point(218, 52)
        Me.txt_funcao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_funcao.Name = "txt_funcao"
        Me.txt_funcao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_funcao.PlaceholderText = ""
        Me.txt_funcao.SelectedText = ""
        Me.txt_funcao.Size = New System.Drawing.Size(366, 36)
        Me.txt_funcao.TabIndex = 5
        '
        'ofd_imagem
        '
        Me.ofd_imagem.FileName = "OpenFileDialog1"
        '
        'cadastrarFuncionário
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(899, 411)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.pnl_titulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cadastrarFuncionário"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Funcionário"
        Me.Guna2ContainerControl1.ResumeLayout(False)
        Me.pnl_nome.ResumeLayout(False)
        Me.pnl_nome.PerformLayout()
        Me.pnl_titulo.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.pbx_imagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_info.ResumeLayout(False)
        Me.pnl_info.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2ContainerControl1 As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents btn_fechar As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btn_minimizar As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents lbl_titulo As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_nome As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnl_nome As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents pnl_titulo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnl_info As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_cadastrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ofd_imagem As OpenFileDialog
    Friend WithEvents pbx_imagem As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_codFunc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_funcao As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_cpf As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_senha As Guna.UI2.WinForms.Guna2TextBox
End Class
