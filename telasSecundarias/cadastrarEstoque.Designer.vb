<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cadastrarEstoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastrarEstoque))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.btn_minimizar = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btn_fechar = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2ContainerControl1 = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.lbl_titulo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_nome = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_nome = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.cmb_unidade = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmb_categoria = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.pnl_titulo = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_cadastrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pbx_imagem = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnl_info = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.dtp_dataValidade = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txt_vlrUnidade = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_qtd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtp_dataCompra = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.ofd_imagem = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2ContainerControl1.SuspendLayout()
        Me.pnl_nome.SuspendLayout()
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
        Me.Guna2ContainerControl1.Location = New System.Drawing.Point(906, 0)
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
        Me.lbl_titulo.Size = New System.Drawing.Size(274, 35)
        Me.lbl_titulo.TabIndex = 5
        Me.lbl_titulo.Text = "Salvar Produto no Estoque"
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
        Me.txt_nome.TabIndex = 8
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
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Libre Caslon Display", 15.75!)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(14, 91)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(78, 27)
        Me.Guna2HtmlLabel3.TabIndex = 9
        Me.Guna2HtmlLabel3.Text = "Categoria"
        '
        'pnl_nome
        '
        Me.pnl_nome.BackColor = System.Drawing.Color.Transparent
        Me.pnl_nome.Controls.Add(Me.cmb_unidade)
        Me.pnl_nome.Controls.Add(Me.Guna2HtmlLabel4)
        Me.pnl_nome.Controls.Add(Me.cmb_categoria)
        Me.pnl_nome.Controls.Add(Me.Guna2HtmlLabel3)
        Me.pnl_nome.Controls.Add(Me.txt_nome)
        Me.pnl_nome.Controls.Add(Me.Guna2HtmlLabel1)
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
        'cmb_unidade
        '
        Me.cmb_unidade.AutoRoundedCorners = True
        Me.cmb_unidade.BackColor = System.Drawing.Color.Transparent
        Me.cmb_unidade.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmb_unidade.BorderRadius = 17
        Me.cmb_unidade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_unidade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_unidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_unidade.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmb_unidade.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmb_unidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmb_unidade.Font = New System.Drawing.Font("Libre Caslon Display", 12.0!)
        Me.cmb_unidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_unidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmb_unidade.ItemHeight = 30
        Me.cmb_unidade.Location = New System.Drawing.Point(304, 124)
        Me.cmb_unidade.Name = "cmb_unidade"
        Me.cmb_unidade.Size = New System.Drawing.Size(280, 36)
        Me.cmb_unidade.TabIndex = 15
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Libre Caslon Display", 15.75!)
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(304, 91)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(69, 27)
        Me.Guna2HtmlLabel4.TabIndex = 14
        Me.Guna2HtmlLabel4.Text = "Unidade"
        '
        'cmb_categoria
        '
        Me.cmb_categoria.AutoRoundedCorners = True
        Me.cmb_categoria.BackColor = System.Drawing.Color.Transparent
        Me.cmb_categoria.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmb_categoria.BorderRadius = 17
        Me.cmb_categoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_categoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_categoria.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmb_categoria.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmb_categoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmb_categoria.Font = New System.Drawing.Font("Libre Caslon Display", 12.0!)
        Me.cmb_categoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_categoria.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmb_categoria.ItemHeight = 30
        Me.cmb_categoria.Location = New System.Drawing.Point(14, 124)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(280, 36)
        Me.cmb_categoria.TabIndex = 13
        '
        'pnl_titulo
        '
        Me.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_titulo.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.pnl_titulo.Location = New System.Drawing.Point(0, 0)
        Me.pnl_titulo.Name = "pnl_titulo"
        Me.pnl_titulo.Size = New System.Drawing.Size(978, 50)
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
        Me.Guna2Panel2.Size = New System.Drawing.Size(978, 477)
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
        Me.btn_cadastrar.Location = New System.Drawing.Point(634, 403)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(328, 47)
        Me.btn_cadastrar.TabIndex = 36
        Me.btn_cadastrar.Text = "Adicionar Produto"
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
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(328, 370)
        Me.Guna2ShadowPanel1.TabIndex = 13
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Libre Caslon Display", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(25, 14)
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
        Me.pbx_imagem.Image = CType(resources.GetObject("pbx_imagem.Image"), System.Drawing.Image)
        Me.pbx_imagem.ImageRotate = 0!
        Me.pbx_imagem.Location = New System.Drawing.Point(26, 53)
        Me.pbx_imagem.Name = "pbx_imagem"
        Me.pbx_imagem.Size = New System.Drawing.Size(280, 290)
        Me.pbx_imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbx_imagem.TabIndex = 18
        Me.pbx_imagem.TabStop = False
        '
        'pnl_info
        '
        Me.pnl_info.BackColor = System.Drawing.Color.Transparent
        Me.pnl_info.Controls.Add(Me.dtp_dataValidade)
        Me.pnl_info.Controls.Add(Me.txt_vlrUnidade)
        Me.pnl_info.Controls.Add(Me.Guna2HtmlLabel9)
        Me.pnl_info.Controls.Add(Me.Guna2HtmlLabel8)
        Me.pnl_info.Controls.Add(Me.Guna2HtmlLabel5)
        Me.pnl_info.Controls.Add(Me.Guna2HtmlLabel6)
        Me.pnl_info.Controls.Add(Me.txt_qtd)
        Me.pnl_info.Controls.Add(Me.Guna2HtmlLabel7)
        Me.pnl_info.Controls.Add(Me.dtp_dataCompra)
        Me.pnl_info.FillColor = System.Drawing.Color.White
        Me.pnl_info.Location = New System.Drawing.Point(16, 224)
        Me.pnl_info.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_info.Name = "pnl_info"
        Me.pnl_info.Radius = 6
        Me.pnl_info.ShadowColor = System.Drawing.Color.Black
        Me.pnl_info.ShadowShift = 2
        Me.pnl_info.Size = New System.Drawing.Size(597, 226)
        Me.pnl_info.TabIndex = 12
        '
        'dtp_dataValidade
        '
        Me.dtp_dataValidade.BorderRadius = 17
        Me.dtp_dataValidade.Checked = True
        Me.dtp_dataValidade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtp_dataValidade.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dtp_dataValidade.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtp_dataValidade.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtp_dataValidade.Location = New System.Drawing.Point(304, 168)
        Me.dtp_dataValidade.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp_dataValidade.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp_dataValidade.Name = "dtp_dataValidade"
        Me.dtp_dataValidade.Size = New System.Drawing.Size(280, 36)
        Me.dtp_dataValidade.TabIndex = 20
        Me.dtp_dataValidade.Value = New Date(2024, 5, 20, 7, 38, 54, 607)
        '
        'txt_vlrUnidade
        '
        Me.txt_vlrUnidade.AutoRoundedCorners = True
        Me.txt_vlrUnidade.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_vlrUnidade.BorderRadius = 17
        Me.txt_vlrUnidade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_vlrUnidade.DefaultText = ""
        Me.txt_vlrUnidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_vlrUnidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_vlrUnidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_vlrUnidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_vlrUnidade.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_vlrUnidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txt_vlrUnidade.Font = New System.Drawing.Font("Libre Caslon Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vlrUnidade.ForeColor = System.Drawing.Color.Black
        Me.txt_vlrUnidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txt_vlrUnidade.Location = New System.Drawing.Point(304, 88)
        Me.txt_vlrUnidade.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_vlrUnidade.Name = "txt_vlrUnidade"
        Me.txt_vlrUnidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_vlrUnidade.PlaceholderText = ""
        Me.txt_vlrUnidade.SelectedText = ""
        Me.txt_vlrUnidade.Size = New System.Drawing.Size(280, 36)
        Me.txt_vlrUnidade.TabIndex = 18
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Libre Caslon Display", 15.75!)
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(304, 54)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(186, 27)
        Me.Guna2HtmlLabel9.TabIndex = 17
        Me.Guna2HtmlLabel9.Text = "Valor pago por unidade"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Libre Caslon Display", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(14, 16)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(249, 31)
        Me.Guna2HtmlLabel8.TabIndex = 16
        Me.Guna2HtmlLabel8.Text = "Informações para o Estoque"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Libre Caslon Display", 15.75!)
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(304, 135)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(133, 27)
        Me.Guna2HtmlLabel5.TabIndex = 14
        Me.Guna2HtmlLabel5.Text = "Data de validade"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Libre Caslon Display", 15.75!)
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(14, 135)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(126, 27)
        Me.Guna2HtmlLabel6.TabIndex = 9
        Me.Guna2HtmlLabel6.Text = "Data da compra"
        '
        'txt_qtd
        '
        Me.txt_qtd.AutoRoundedCorners = True
        Me.txt_qtd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_qtd.BorderRadius = 17
        Me.txt_qtd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_qtd.DefaultText = ""
        Me.txt_qtd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_qtd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_qtd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_qtd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_qtd.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_qtd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txt_qtd.Font = New System.Drawing.Font("Libre Caslon Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtd.ForeColor = System.Drawing.Color.Black
        Me.txt_qtd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txt_qtd.Location = New System.Drawing.Point(14, 88)
        Me.txt_qtd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_qtd.Name = "txt_qtd"
        Me.txt_qtd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_qtd.PlaceholderText = ""
        Me.txt_qtd.SelectedText = ""
        Me.txt_qtd.Size = New System.Drawing.Size(280, 36)
        Me.txt_qtd.TabIndex = 8
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Libre Caslon Display", 15.75!)
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(14, 54)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(174, 27)
        Me.Guna2HtmlLabel7.TabIndex = 7
        Me.Guna2HtmlLabel7.Text = "Quantidade comprada"
        '
        'dtp_dataCompra
        '
        Me.dtp_dataCompra.BorderRadius = 17
        Me.dtp_dataCompra.Checked = True
        Me.dtp_dataCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtp_dataCompra.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dtp_dataCompra.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtp_dataCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtp_dataCompra.Location = New System.Drawing.Point(14, 168)
        Me.dtp_dataCompra.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp_dataCompra.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp_dataCompra.Name = "dtp_dataCompra"
        Me.dtp_dataCompra.Size = New System.Drawing.Size(280, 36)
        Me.dtp_dataCompra.TabIndex = 19
        Me.dtp_dataCompra.Value = New Date(2024, 5, 20, 7, 38, 54, 607)
        '
        'ofd_imagem
        '
        Me.ofd_imagem.FileName = "OpenFileDialog1"
        '
        'cadastrarEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(978, 527)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.Guna2ContainerControl1)
        Me.Controls.Add(Me.pnl_titulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cadastrarEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sair1"
        Me.Guna2ContainerControl1.ResumeLayout(False)
        Me.pnl_nome.ResumeLayout(False)
        Me.pnl_nome.PerformLayout()
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
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnl_nome As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents pnl_titulo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cmb_categoria As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmb_unidade As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnl_info As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents dtp_dataCompra As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txt_vlrUnidade As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_qtd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtp_dataValidade As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_cadastrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ofd_imagem As OpenFileDialog
    Friend WithEvents pbx_imagem As Guna.UI2.WinForms.Guna2PictureBox
End Class
