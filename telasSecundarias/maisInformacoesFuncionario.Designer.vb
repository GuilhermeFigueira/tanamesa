﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class maisInformacoesFuncionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(maisInformacoesFuncionario))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.btn_minimizar = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btn_fechar = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2ContainerControl1 = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.pbx_imgFuncionario = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_nome = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_cpf = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_info = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.txt_senha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_funcao = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_titulo = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_codFuncionario = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_salvar = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_excluirFuncionario = New Guna.UI2.WinForms.Guna2Button()
        Me.ofd_imagem = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2ContainerControl1.SuspendLayout()
        CType(Me.pbx_imgFuncionario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_info.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
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
        Me.Guna2ContainerControl1.Location = New System.Drawing.Point(716, 0)
        Me.Guna2ContainerControl1.Name = "Guna2ContainerControl1"
        Me.Guna2ContainerControl1.Size = New System.Drawing.Size(60, 30)
        Me.Guna2ContainerControl1.TabIndex = 2
        Me.Guna2ContainerControl1.Text = "Guna2ContainerControl1"
        '
        'pbx_imgFuncionario
        '
        Me.pbx_imgFuncionario.BackColor = System.Drawing.Color.Transparent
        Me.pbx_imgFuncionario.BorderRadius = 16
        Me.pbx_imgFuncionario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbx_imgFuncionario.ImageRotate = 0!
        Me.pbx_imgFuncionario.Location = New System.Drawing.Point(581, 24)
        Me.pbx_imgFuncionario.Name = "pbx_imgFuncionario"
        Me.pbx_imgFuncionario.ShadowDecoration.BorderRadius = 2
        Me.pbx_imgFuncionario.ShadowDecoration.Depth = 2
        Me.pbx_imgFuncionario.ShadowDecoration.Enabled = True
        Me.pbx_imgFuncionario.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
        Me.pbx_imgFuncionario.Size = New System.Drawing.Size(183, 192)
        Me.pbx_imgFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx_imgFuncionario.TabIndex = 3
        Me.pbx_imgFuncionario.TabStop = False
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Libre Caslon Display", 15.75!)
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(12, 12)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(225, 27)
        Me.Guna2HtmlLabel2.TabIndex = 5
        Me.Guna2HtmlLabel2.Text = "Informações do Funcionário"
        '
        'txt_nome
        '
        Me.txt_nome.AutoRoundedCorners = True
        Me.txt_nome.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_nome.BorderRadius = 17
        Me.txt_nome.Cursor = System.Windows.Forms.Cursors.IBeam
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
        Me.txt_nome.Location = New System.Drawing.Point(14, 51)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nome.PlaceholderText = ""
        Me.txt_nome.SelectedText = ""
        Me.txt_nome.Size = New System.Drawing.Size(324, 36)
        Me.txt_nome.TabIndex = 8
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Libre Caslon Display", 15.75!)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(14, 17)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(51, 27)
        Me.Guna2HtmlLabel1.TabIndex = 7
        Me.Guna2HtmlLabel1.Text = "Nome"
        '
        'txt_cpf
        '
        Me.txt_cpf.AutoRoundedCorners = True
        Me.txt_cpf.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_cpf.BorderRadius = 17
        Me.txt_cpf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpf.DefaultText = ""
        Me.txt_cpf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_cpf.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_cpf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cpf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cpf.Enabled = False
        Me.txt_cpf.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_cpf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txt_cpf.Font = New System.Drawing.Font("Libre Caslon Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.ForeColor = System.Drawing.Color.Black
        Me.txt_cpf.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txt_cpf.Location = New System.Drawing.Point(344, 51)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cpf.PlaceholderText = ""
        Me.txt_cpf.SelectedText = ""
        Me.txt_cpf.Size = New System.Drawing.Size(171, 36)
        Me.txt_cpf.TabIndex = 10
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Libre Caslon Display", 15.75!)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(344, 17)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(41, 27)
        Me.Guna2HtmlLabel3.TabIndex = 9
        Me.Guna2HtmlLabel3.Text = "CPF"
        '
        'pnl_info
        '
        Me.pnl_info.BackColor = System.Drawing.Color.Transparent
        Me.pnl_info.Controls.Add(Me.txt_senha)
        Me.pnl_info.Controls.Add(Me.Guna2HtmlLabel5)
        Me.pnl_info.Controls.Add(Me.txt_funcao)
        Me.pnl_info.Controls.Add(Me.Guna2HtmlLabel4)
        Me.pnl_info.Controls.Add(Me.txt_cpf)
        Me.pnl_info.Controls.Add(Me.Guna2HtmlLabel3)
        Me.pnl_info.Controls.Add(Me.txt_nome)
        Me.pnl_info.Controls.Add(Me.Guna2HtmlLabel1)
        Me.pnl_info.FillColor = System.Drawing.Color.White
        Me.pnl_info.Location = New System.Drawing.Point(24, 24)
        Me.pnl_info.Margin = New System.Windows.Forms.Padding(12)
        Me.pnl_info.Name = "pnl_info"
        Me.pnl_info.Radius = 6
        Me.pnl_info.ShadowColor = System.Drawing.Color.Black
        Me.pnl_info.ShadowShift = 2
        Me.pnl_info.Size = New System.Drawing.Size(527, 192)
        Me.pnl_info.TabIndex = 11
        '
        'txt_senha
        '
        Me.txt_senha.AutoRoundedCorners = True
        Me.txt_senha.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_senha.BorderRadius = 17
        Me.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam
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
        Me.txt_senha.Location = New System.Drawing.Point(14, 132)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_senha.PlaceholderText = ""
        Me.txt_senha.SelectedText = ""
        Me.txt_senha.Size = New System.Drawing.Size(280, 36)
        Me.txt_senha.TabIndex = 14
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Libre Caslon Display", 15.75!)
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(14, 98)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(52, 27)
        Me.Guna2HtmlLabel5.TabIndex = 13
        Me.Guna2HtmlLabel5.Text = "Senha"
        '
        'txt_funcao
        '
        Me.txt_funcao.AutoRoundedCorners = True
        Me.txt_funcao.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_funcao.BorderRadius = 17
        Me.txt_funcao.Cursor = System.Windows.Forms.Cursors.IBeam
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
        Me.txt_funcao.Location = New System.Drawing.Point(302, 132)
        Me.txt_funcao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_funcao.Name = "txt_funcao"
        Me.txt_funcao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_funcao.PlaceholderText = ""
        Me.txt_funcao.SelectedText = ""
        Me.txt_funcao.Size = New System.Drawing.Size(213, 36)
        Me.txt_funcao.TabIndex = 12
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Libre Caslon Display", 15.75!)
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(302, 98)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(61, 27)
        Me.Guna2HtmlLabel4.TabIndex = 11
        Me.Guna2HtmlLabel4.Text = "Função"
        '
        'pnl_titulo
        '
        Me.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_titulo.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.pnl_titulo.Location = New System.Drawing.Point(0, 0)
        Me.pnl_titulo.Name = "pnl_titulo"
        Me.pnl_titulo.Size = New System.Drawing.Size(788, 50)
        Me.pnl_titulo.TabIndex = 12
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 1.0R
        Me.Guna2DragControl1.TargetControl = Me.pnl_titulo
        Me.Guna2DragControl1.TransparentWhileDrag = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.lbl_codFuncionario)
        Me.Guna2Panel1.Controls.Add(Me.btn_salvar)
        Me.Guna2Panel1.Controls.Add(Me.btn_excluirFuncionario)
        Me.Guna2Panel1.Controls.Add(Me.pnl_info)
        Me.Guna2Panel1.Controls.Add(Me.pbx_imgFuncionario)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Padding = New System.Windows.Forms.Padding(24)
        Me.Guna2Panel1.Size = New System.Drawing.Size(788, 285)
        Me.Guna2Panel1.TabIndex = 13
        '
        'lbl_codFuncionario
        '
        Me.lbl_codFuncionario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_codFuncionario.Font = New System.Drawing.Font("Libre Caslon Display", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codFuncionario.Location = New System.Drawing.Point(24, 231)
        Me.lbl_codFuncionario.Name = "lbl_codFuncionario"
        Me.lbl_codFuncionario.Size = New System.Drawing.Size(153, 31)
        Me.lbl_codFuncionario.TabIndex = 38
        Me.lbl_codFuncionario.Text = "Funcionário #01"
        '
        'btn_salvar
        '
        Me.btn_salvar.AutoRoundedCorners = True
        Me.btn_salvar.BackColor = System.Drawing.Color.Transparent
        Me.btn_salvar.BorderRadius = 20
        Me.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salvar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_salvar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_salvar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_salvar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_salvar.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_salvar.Font = New System.Drawing.Font("Libre Caslon Display", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_salvar.ImageSize = New System.Drawing.Size(28, 28)
        Me.btn_salvar.Location = New System.Drawing.Point(545, 231)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(219, 42)
        Me.btn_salvar.TabIndex = 37
        Me.btn_salvar.Text = "Salvar Alterações"
        '
        'btn_excluirFuncionario
        '
        Me.btn_excluirFuncionario.AutoRoundedCorners = True
        Me.btn_excluirFuncionario.BackColor = System.Drawing.Color.Transparent
        Me.btn_excluirFuncionario.BorderRadius = 20
        Me.btn_excluirFuncionario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_excluirFuncionario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_excluirFuncionario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_excluirFuncionario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_excluirFuncionario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_excluirFuncionario.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_excluirFuncionario.Font = New System.Drawing.Font("Libre Caslon Display", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_excluirFuncionario.ForeColor = System.Drawing.Color.White
        Me.btn_excluirFuncionario.ImageSize = New System.Drawing.Size(28, 28)
        Me.btn_excluirFuncionario.Location = New System.Drawing.Point(315, 231)
        Me.btn_excluirFuncionario.Name = "btn_excluirFuncionario"
        Me.btn_excluirFuncionario.Size = New System.Drawing.Size(219, 42)
        Me.btn_excluirFuncionario.TabIndex = 36
        Me.btn_excluirFuncionario.Text = "Excluir Funcionário"
        '
        'ofd_imagem
        '
        Me.ofd_imagem.FileName = "OpenFileDialog1"
        '
        'maisInformacoesFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(788, 335)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2ContainerControl1)
        Me.Controls.Add(Me.pnl_titulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "maisInformacoesFuncionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informações do Funcionario"
        Me.Guna2ContainerControl1.ResumeLayout(False)
        CType(Me.pbx_imgFuncionario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_info.ResumeLayout(False)
        Me.pnl_info.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2ContainerControl1 As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents btn_fechar As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btn_minimizar As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents pbx_imgFuncionario As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_nome As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_cpf As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnl_info As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents txt_funcao As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnl_titulo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txt_senha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_salvar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_excluirFuncionario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ofd_imagem As OpenFileDialog
    Friend WithEvents lbl_codFuncionario As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
