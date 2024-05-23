<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class estoque
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(estoque))
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
        Me.btn_info = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_estoque = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_gerencia = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_mesas = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_pedidos = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_cardapio = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ContainerControl1 = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.pnl_title = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnl_info = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.dgv_estoque = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.fotoProduto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtdEmEstoque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vlrPagoUnidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataValidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_addProd = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_pesquisa = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2DragControl2 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2HtmlLabel29 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel28 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel27 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel26 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_controls.SuspendLayout()
        Me.pnl_logo.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2ContainerControl1.SuspendLayout()
        Me.pnl_title.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.pnl_info.SuspendLayout()
        CType(Me.dgv_estoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
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
        Me.Guna2Panel3.Controls.Add(Me.btn_info)
        Me.Guna2Panel3.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2Panel3.Controls.Add(Me.btn_sair)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 630)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(220, 139)
        Me.Guna2Panel3.TabIndex = 34
        '
        'btn_info
        '
        Me.btn_info.AutoRoundedCorners = True
        Me.btn_info.BorderRadius = 11
        Me.btn_info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_info.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_info.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_info.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_info.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_info.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btn_info.Font = New System.Drawing.Font("Julius Sans One", 16.0!)
        Me.btn_info.ForeColor = System.Drawing.Color.Black
        Me.btn_info.Location = New System.Drawing.Point(90, 14)
        Me.btn_info.Name = "btn_info"
        Me.btn_info.Size = New System.Drawing.Size(105, 25)
        Me.btn_info.TabIndex = 33
        Me.btn_info.Text = "NOME"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(34, 3)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.Guna2CirclePictureBox1.TabIndex = 32
        Me.Guna2CirclePictureBox1.TabStop = False
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
        Me.btn_estoque.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_estoque.BorderThickness = 1
        Me.btn_estoque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_estoque.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_estoque.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_estoque.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_estoque.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_estoque.FillColor = System.Drawing.Color.Transparent
        Me.btn_estoque.Font = New System.Drawing.Font("Libre Caslon Display", 24.25!)
        Me.btn_estoque.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_estoque.Image = CType(resources.GetObject("btn_estoque.Image"), System.Drawing.Image)
        Me.btn_estoque.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_estoque.ImageSize = New System.Drawing.Size(25, 25)
        Me.btn_estoque.Location = New System.Drawing.Point(0, 416)
        Me.btn_estoque.Name = "btn_estoque"
        Me.btn_estoque.Size = New System.Drawing.Size(220, 54)
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
        Me.btn_gerencia.Location = New System.Drawing.Point(3, 476)
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
        Me.btn_mesas.Location = New System.Drawing.Point(3, 236)
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
        Me.btn_pedidos.Location = New System.Drawing.Point(3, 356)
        Me.btn_pedidos.Name = "btn_pedidos"
        Me.btn_pedidos.Size = New System.Drawing.Size(217, 54)
        Me.btn_pedidos.TabIndex = 32
        Me.btn_pedidos.Text = "Pedidos"
        '
        'btn_cardapio
        '
        Me.btn_cardapio.BackColor = System.Drawing.Color.Transparent
        Me.btn_cardapio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cardapio.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_cardapio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_cardapio.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_cardapio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_cardapio.FillColor = System.Drawing.Color.Transparent
        Me.btn_cardapio.Font = New System.Drawing.Font("Libre Caslon Display", 24.25!)
        Me.btn_cardapio.ForeColor = System.Drawing.Color.Black
        Me.btn_cardapio.Image = CType(resources.GetObject("btn_cardapio.Image"), System.Drawing.Image)
        Me.btn_cardapio.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_cardapio.ImageSize = New System.Drawing.Size(25, 25)
        Me.btn_cardapio.Location = New System.Drawing.Point(1, 296)
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
        Me.pnl_title.BackColor = System.Drawing.Color.Transparent
        Me.pnl_title.Controls.Add(Me.Guna2HtmlLabel7)
        Me.pnl_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_title.FillColor = System.Drawing.Color.White
        Me.pnl_title.Location = New System.Drawing.Point(0, 0)
        Me.pnl_title.Name = "pnl_title"
        Me.pnl_title.Padding = New System.Windows.Forms.Padding(46, 0, 46, 0)
        Me.pnl_title.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.pnl_title.ShadowShift = 0
        Me.pnl_title.Size = New System.Drawing.Size(980, 80)
        Me.pnl_title.TabIndex = 32
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Libre Caslon Display", 30.0!)
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(49, 15)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(126, 51)
        Me.Guna2HtmlLabel7.TabIndex = 33
        Me.Guna2HtmlLabel7.Text = "Estoque"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Controls.Add(Me.pnl_info)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 80)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Padding = New System.Windows.Forms.Padding(16)
        Me.Guna2Panel4.Size = New System.Drawing.Size(980, 720)
        Me.Guna2Panel4.TabIndex = 33
        '
        'pnl_info
        '
        Me.pnl_info.BackColor = System.Drawing.Color.Transparent
        Me.pnl_info.Controls.Add(Me.dgv_estoque)
        Me.pnl_info.Controls.Add(Me.Guna2Panel1)
        Me.pnl_info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_info.FillColor = System.Drawing.Color.White
        Me.pnl_info.Location = New System.Drawing.Point(16, 16)
        Me.pnl_info.Name = "pnl_info"
        Me.pnl_info.Padding = New System.Windows.Forms.Padding(16)
        Me.pnl_info.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.pnl_info.Size = New System.Drawing.Size(948, 688)
        Me.pnl_info.TabIndex = 0
        '
        'dgv_estoque
        '
        Me.dgv_estoque.AllowUserToAddRows = False
        Me.dgv_estoque.AllowUserToDeleteRows = False
        Me.dgv_estoque.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Libre Caslon Display", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv_estoque.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Julius Sans One", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_estoque.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_estoque.ColumnHeadersHeight = 70
        Me.dgv_estoque.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fotoProduto, Me.produto, Me.categoria, Me.qtdEmEstoque, Me.unidade, Me.vlrPagoUnidade, Me.dataCompra, Me.dataValidade, Me.editar, Me.excluir})
        Me.dgv_estoque.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Libre Caslon Display", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_estoque.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_estoque.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_estoque.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_estoque.Location = New System.Drawing.Point(16, 109)
        Me.dgv_estoque.Name = "dgv_estoque"
        Me.dgv_estoque.ReadOnly = True
        Me.dgv_estoque.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgv_estoque.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_estoque.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_estoque.RowHeadersVisible = False
        Me.dgv_estoque.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_estoque.RowTemplate.Height = 50
        Me.dgv_estoque.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv_estoque.ShowCellErrors = False
        Me.dgv_estoque.ShowCellToolTips = False
        Me.dgv_estoque.ShowEditingIcon = False
        Me.dgv_estoque.ShowRowErrors = False
        Me.dgv_estoque.Size = New System.Drawing.Size(916, 560)
        Me.dgv_estoque.TabIndex = 36
        Me.dgv_estoque.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_estoque.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Libre Caslon Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_estoque.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgv_estoque.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_estoque.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv_estoque.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv_estoque.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_estoque.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.dgv_estoque.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_estoque.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Julius Sans One", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_estoque.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.dgv_estoque.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_estoque.ThemeStyle.HeaderStyle.Height = 70
        Me.dgv_estoque.ThemeStyle.ReadOnly = True
        Me.dgv_estoque.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_estoque.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_estoque.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Libre Caslon Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_estoque.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv_estoque.ThemeStyle.RowsStyle.Height = 50
        Me.dgv_estoque.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_estoque.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'fotoProduto
        '
        Me.fotoProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.fotoProduto.FillWeight = 60.0!
        Me.fotoProduto.HeaderText = ""
        Me.fotoProduto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.fotoProduto.Name = "fotoProduto"
        Me.fotoProduto.ReadOnly = True
        Me.fotoProduto.Width = 94
        '
        'produto
        '
        Me.produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.produto.FillWeight = 77.10199!
        Me.produto.HeaderText = "Produto"
        Me.produto.Name = "produto"
        Me.produto.ReadOnly = True
        '
        'categoria
        '
        Me.categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.categoria.FillWeight = 77.10199!
        Me.categoria.HeaderText = "Categoria"
        Me.categoria.Name = "categoria"
        Me.categoria.ReadOnly = True
        '
        'qtdEmEstoque
        '
        Me.qtdEmEstoque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.qtdEmEstoque.FillWeight = 77.10199!
        Me.qtdEmEstoque.HeaderText = "Em Estoque"
        Me.qtdEmEstoque.Name = "qtdEmEstoque"
        Me.qtdEmEstoque.ReadOnly = True
        '
        'unidade
        '
        Me.unidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.unidade.FillWeight = 30.0!
        Me.unidade.HeaderText = "UN"
        Me.unidade.Name = "unidade"
        Me.unidade.ReadOnly = True
        Me.unidade.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'vlrPagoUnidade
        '
        Me.vlrPagoUnidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.vlrPagoUnidade.FillWeight = 77.10199!
        Me.vlrPagoUnidade.HeaderText = "Valor Pago por Unidade"
        Me.vlrPagoUnidade.Name = "vlrPagoUnidade"
        Me.vlrPagoUnidade.ReadOnly = True
        '
        'dataCompra
        '
        Me.dataCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dataCompra.FillWeight = 77.10199!
        Me.dataCompra.HeaderText = "Data da compra"
        Me.dataCompra.Name = "dataCompra"
        Me.dataCompra.ReadOnly = True
        '
        'dataValidade
        '
        Me.dataValidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dataValidade.FillWeight = 77.10199!
        Me.dataValidade.HeaderText = "Data de Validade"
        Me.dataValidade.Name = "dataValidade"
        Me.dataValidade.ReadOnly = True
        '
        'editar
        '
        Me.editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.editar.FillWeight = 30.0!
        Me.editar.HeaderText = ""
        Me.editar.Image = CType(resources.GetObject("editar.Image"), System.Drawing.Image)
        Me.editar.Name = "editar"
        Me.editar.ReadOnly = True
        Me.editar.Width = 47
        '
        'excluir
        '
        Me.excluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.excluir.FillWeight = 30.0!
        Me.excluir.HeaderText = ""
        Me.excluir.Image = CType(resources.GetObject("excluir.Image"), System.Drawing.Image)
        Me.excluir.Name = "excluir"
        Me.excluir.ReadOnly = True
        Me.excluir.Width = 47
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btn_addProd)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel1.Controls.Add(Me.txt_pesquisa)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(16, 16)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(916, 88)
        Me.Guna2Panel1.TabIndex = 35
        '
        'btn_addProd
        '
        Me.btn_addProd.AutoRoundedCorners = True
        Me.btn_addProd.BackColor = System.Drawing.Color.Transparent
        Me.btn_addProd.BorderRadius = 17
        Me.btn_addProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_addProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_addProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_addProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_addProd.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_addProd.Font = New System.Drawing.Font("Libre Caslon Display", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addProd.ForeColor = System.Drawing.Color.White
        Me.btn_addProd.Image = CType(resources.GetObject("btn_addProd.Image"), System.Drawing.Image)
        Me.btn_addProd.ImageSize = New System.Drawing.Size(28, 28)
        Me.btn_addProd.Location = New System.Drawing.Point(680, 25)
        Me.btn_addProd.Name = "btn_addProd"
        Me.btn_addProd.Size = New System.Drawing.Size(219, 36)
        Me.btn_addProd.TabIndex = 35
        Me.btn_addProd.Text = "Adicionar Produto"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Libre Caslon Display", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(17, 20)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(192, 35)
        Me.Guna2HtmlLabel8.TabIndex = 9
        Me.Guna2HtmlLabel8.Text = "Todos os produtos"
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.AutoRoundedCorners = True
        Me.txt_pesquisa.BackColor = System.Drawing.Color.Transparent
        Me.txt_pesquisa.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_pesquisa.BorderRadius = 17
        Me.txt_pesquisa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_pesquisa.DefaultText = ""
        Me.txt_pesquisa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_pesquisa.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_pesquisa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_pesquisa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_pesquisa.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_pesquisa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txt_pesquisa.Font = New System.Drawing.Font("Libre Caslon Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pesquisa.ForeColor = System.Drawing.Color.Black
        Me.txt_pesquisa.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txt_pesquisa.IconLeft = CType(resources.GetObject("txt_pesquisa.IconLeft"), System.Drawing.Image)
        Me.txt_pesquisa.Location = New System.Drawing.Point(238, 25)
        Me.txt_pesquisa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Padding = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.txt_pesquisa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_pesquisa.PlaceholderText = "Pesquise itens do cardápio"
        Me.txt_pesquisa.SelectedText = ""
        Me.txt_pesquisa.Size = New System.Drawing.Size(413, 36)
        Me.txt_pesquisa.TabIndex = 34
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.pnl_title
        Me.Guna2DragControl1.TransparentWhileDrag = False
        '
        'Guna2DragControl2
        '
        Me.Guna2DragControl2.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl2.TargetControl = Me.pnl_controls
        Me.Guna2DragControl2.TransparentWhileDrag = False
        '
        'Guna2HtmlLabel29
        '
        Me.Guna2HtmlLabel29.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel29.Font = New System.Drawing.Font("Libre Caslon Display", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel29.Location = New System.Drawing.Point(19, 136)
        Me.Guna2HtmlLabel29.Name = "Guna2HtmlLabel29"
        Me.Guna2HtmlLabel29.Size = New System.Drawing.Size(140, 31)
        Me.Guna2HtmlLabel29.TabIndex = 11
        Me.Guna2HtmlLabel29.Text = "Nome do Prato"
        '
        'Guna2HtmlLabel28
        '
        Me.Guna2HtmlLabel28.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel28.Font = New System.Drawing.Font("Libre Caslon Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Guna2HtmlLabel28.Location = New System.Drawing.Point(19, 170)
        Me.Guna2HtmlLabel28.Name = "Guna2HtmlLabel28"
        Me.Guna2HtmlLabel28.Size = New System.Drawing.Size(160, 20)
        Me.Guna2HtmlLabel28.TabIndex = 12
        Me.Guna2HtmlLabel28.Text = "Vezes pedido na semana: 10"
        '
        'Guna2HtmlLabel27
        '
        Me.Guna2HtmlLabel27.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel27.Font = New System.Drawing.Font("Libre Caslon Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Guna2HtmlLabel27.Location = New System.Drawing.Point(19, 197)
        Me.Guna2HtmlLabel27.Name = "Guna2HtmlLabel27"
        Me.Guna2HtmlLabel27.Size = New System.Drawing.Size(154, 20)
        Me.Guna2HtmlLabel27.TabIndex = 13
        Me.Guna2HtmlLabel27.Text = "Porcentagem do total: 48%"
        '
        'Guna2HtmlLabel26
        '
        Me.Guna2HtmlLabel26.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel26.Font = New System.Drawing.Font("Libre Caslon Display", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel26.Location = New System.Drawing.Point(19, 235)
        Me.Guna2HtmlLabel26.Name = "Guna2HtmlLabel26"
        Me.Guna2HtmlLabel26.Size = New System.Drawing.Size(57, 31)
        Me.Guna2HtmlLabel26.TabIndex = 14
        Me.Guna2HtmlLabel26.Text = "24,35"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Libre Caslon Display", 24.75!)
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(31, 15)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(328, 42)
        Me.Guna2HtmlLabel2.TabIndex = 5
        Me.Guna2HtmlLabel2.Text = "Explorar itens do cardápio"
        '
        'estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.pnl_title)
        Me.Controls.Add(Me.Guna2ContainerControl1)
        Me.Controls.Add(Me.pnl_controls)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "estoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tá na Mesa - Estoque"
        Me.pnl_controls.ResumeLayout(False)
        Me.pnl_logo.ResumeLayout(False)
        Me.pnl_logo.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2ContainerControl1.ResumeLayout(False)
        Me.pnl_title.ResumeLayout(False)
        Me.pnl_title.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.pnl_info.ResumeLayout(False)
        CType(Me.dgv_estoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
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
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents pnl_title As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnl_info As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2DragControl2 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_info As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel29 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel28 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel27 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel26 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_pesquisa As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_addProd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DataGridViewStyler1 As Guna.UI2.WinForms.Guna2DataGridViewStyler
    Friend WithEvents Guna2DataGridViewStyler2 As Guna.UI2.WinForms.Guna2DataGridViewStyler
    Friend WithEvents dgv_estoque As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents fotoProduto As DataGridViewImageColumn
    Friend WithEvents produto As DataGridViewTextBoxColumn
    Friend WithEvents categoria As DataGridViewTextBoxColumn
    Friend WithEvents qtdEmEstoque As DataGridViewTextBoxColumn
    Friend WithEvents unidade As DataGridViewTextBoxColumn
    Friend WithEvents vlrPagoUnidade As DataGridViewTextBoxColumn
    Friend WithEvents dataCompra As DataGridViewTextBoxColumn
    Friend WithEvents dataValidade As DataGridViewTextBoxColumn
    Friend WithEvents editar As DataGridViewImageColumn
    Friend WithEvents excluir As DataGridViewImageColumn
End Class
