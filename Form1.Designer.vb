<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    'Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        TabPage1 = New TabPage()
        lbGender = New Label()
        lbLN = New Label()
        lbFN = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        txtSearch = New MaterialSkin.Controls.MaterialTextBox2()
        btnSearch = New MaterialSkin.Controls.MaterialButton()
        Panel2 = New Panel()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        DataGridView1 = New DataGridView()
        txtGender = New MaterialSkin.Controls.MaterialComboBox()
        btnDelete = New MaterialSkin.Controls.MaterialButton()
        txtLastName = New MaterialSkin.Controls.MaterialTextBox2()
        btnUpdate = New MaterialSkin.Controls.MaterialButton()
        txtFirstName = New MaterialSkin.Controls.MaterialTextBox2()
        btnInsert = New MaterialSkin.Controls.MaterialButton()
        TabPage2 = New TabPage()
        MaterialTabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        StatusStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MaterialTabControl1
        ' 
        MaterialTabControl1.Controls.Add(TabPage1)
        MaterialTabControl1.Controls.Add(TabPage2)
        MaterialTabControl1.Depth = 0
        MaterialTabControl1.Dock = DockStyle.Fill
        MaterialTabControl1.Location = New Point(3, 64)
        MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialTabControl1.Multiline = True
        MaterialTabControl1.Name = "MaterialTabControl1"
        MaterialTabControl1.SelectedIndex = 0
        MaterialTabControl1.Size = New Size(757, 500)
        MaterialTabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(lbGender)
        TabPage1.Controls.Add(lbLN)
        TabPage1.Controls.Add(lbFN)
        TabPage1.Controls.Add(Panel1)
        TabPage1.Controls.Add(Panel2)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(749, 472)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' lbGender
        ' 
        lbGender.AutoSize = True
        lbGender.Font = New Font("Roboto", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lbGender.Location = New Point(32, 239)
        lbGender.Name = "lbGender"
        lbGender.Size = New Size(79, 25)
        lbGender.TabIndex = 1
        lbGender.Text = "Gender"
        ' 
        ' lbLN
        ' 
        lbLN.AutoSize = True
        lbLN.Font = New Font("Roboto", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lbLN.Location = New Point(32, 173)
        lbLN.Name = "lbLN"
        lbLN.Size = New Size(112, 25)
        lbLN.TabIndex = 1
        lbLN.Text = "Last Name"
        ' 
        ' lbFN
        ' 
        lbFN.AutoSize = True
        lbFN.Font = New Font("Roboto", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lbFN.Location = New Point(32, 109)
        lbFN.Name = "lbFN"
        lbFN.Size = New Size(114, 25)
        lbFN.TabIndex = 1
        lbFN.Text = "First Name"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSkyBlue
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtSearch)
        Panel1.Controls.Add(btnSearch)
        Panel1.ForeColor = SystemColors.ControlText
        Panel1.Location = New Point(6, 6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(737, 85)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(26, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(301, 29)
        Label1.TabIndex = 3
        Label1.Text = "VB.NET PostgreSQL CRUD"
        ' 
        ' txtSearch
        ' 
        txtSearch.AnimateReadOnly = False
        txtSearch.BackgroundImageLayout = ImageLayout.None
        txtSearch.CharacterCasing = CharacterCasing.Normal
        txtSearch.Depth = 0
        txtSearch.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtSearch.HideSelection = True
        txtSearch.LeadingIcon = Nothing
        txtSearch.Location = New Point(333, 21)
        txtSearch.MaxLength = 32767
        txtSearch.MouseState = MaterialSkin.MouseState.OUT
        txtSearch.Name = "txtSearch"
        txtSearch.PasswordChar = ChrW(0)
        txtSearch.PrefixSuffixText = Nothing
        txtSearch.ReadOnly = False
        txtSearch.RightToLeft = RightToLeft.No
        txtSearch.SelectedText = ""
        txtSearch.SelectionLength = 0
        txtSearch.SelectionStart = 0
        txtSearch.ShortcutsEnabled = True
        txtSearch.Size = New Size(280, 48)
        txtSearch.TabIndex = 2
        txtSearch.TabStop = False
        txtSearch.Text = "Search Here"
        txtSearch.TextAlign = HorizontalAlignment.Left
        txtSearch.TrailingIcon = Nothing
        txtSearch.UseSystemPasswordChar = False
        ' 
        ' btnSearch
        ' 
        btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnSearch.Depth = 0
        btnSearch.HighEmphasis = True
        btnSearch.Icon = Nothing
        btnSearch.Location = New Point(630, 33)
        btnSearch.Margin = New Padding(4, 6, 4, 6)
        btnSearch.MouseState = MaterialSkin.MouseState.HOVER
        btnSearch.Name = "btnSearch"
        btnSearch.NoAccentTextColor = Color.Empty
        btnSearch.Size = New Size(78, 36)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search"
        btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnSearch.UseAccentColor = False
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(StatusStrip1)
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(txtGender)
        Panel2.Controls.Add(btnDelete)
        Panel2.Controls.Add(txtLastName)
        Panel2.Controls.Add(btnUpdate)
        Panel2.Controls.Add(txtFirstName)
        Panel2.Controls.Add(btnInsert)
        Panel2.Location = New Point(6, 97)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(737, 372)
        Panel2.TabIndex = 5
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
        StatusStrip1.Location = New Point(0, 350)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(737, 22)
        StatusStrip1.TabIndex = 7
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(107, 17)
        ToolStripStatusLabel1.Text = "Number of row(s): "
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(15, 208)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(709, 126)
        DataGridView1.TabIndex = 6
        ' 
        ' txtGender
        ' 
        txtGender.AutoResize = False
        txtGender.BackColor = Color.White
        txtGender.Depth = 0
        txtGender.DrawMode = DrawMode.OwnerDrawVariable
        txtGender.DropDownHeight = 174
        txtGender.DropDownStyle = ComboBoxStyle.DropDownList
        txtGender.DropDownWidth = 121
        txtGender.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        txtGender.ForeColor = Color.Black
        txtGender.FormattingEnabled = True
        txtGender.Hint = "Gender"
        txtGender.IntegralHeight = False
        txtGender.ItemHeight = 43
        txtGender.Items.AddRange(New Object() {"Male", "Female"})
        txtGender.Location = New Point(148, 142)
        txtGender.MaxDropDownItems = 4
        txtGender.MouseState = MaterialSkin.MouseState.OUT
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(250, 49)
        txtGender.StartIndex = 0
        txtGender.TabIndex = 4
        ' 
        ' btnDelete
        ' 
        btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnDelete.Depth = 0
        btnDelete.HighEmphasis = True
        btnDelete.Icon = Nothing
        btnDelete.Location = New Point(540, 155)
        btnDelete.Margin = New Padding(4, 6, 4, 6)
        btnDelete.MouseState = MaterialSkin.MouseState.HOVER
        btnDelete.Name = "btnDelete"
        btnDelete.NoAccentTextColor = Color.Empty
        btnDelete.Size = New Size(73, 36)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnDelete.UseAccentColor = False
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' txtLastName
        ' 
        txtLastName.AnimateReadOnly = False
        txtLastName.BackgroundImageLayout = ImageLayout.None
        txtLastName.CharacterCasing = CharacterCasing.Normal
        txtLastName.Depth = 0
        txtLastName.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtLastName.HideSelection = True
        txtLastName.Hint = "Last Name"
        txtLastName.LeadingIcon = Nothing
        txtLastName.Location = New Point(148, 76)
        txtLastName.MaxLength = 32767
        txtLastName.MouseState = MaterialSkin.MouseState.OUT
        txtLastName.Name = "txtLastName"
        txtLastName.PasswordChar = ChrW(0)
        txtLastName.PrefixSuffixText = Nothing
        txtLastName.ReadOnly = False
        txtLastName.RightToLeft = RightToLeft.No
        txtLastName.SelectedText = ""
        txtLastName.SelectionLength = 0
        txtLastName.SelectionStart = 0
        txtLastName.ShortcutsEnabled = True
        txtLastName.Size = New Size(250, 48)
        txtLastName.TabIndex = 2
        txtLastName.TabStop = False
        txtLastName.TextAlign = HorizontalAlignment.Left
        txtLastName.TrailingIcon = Nothing
        txtLastName.UseSystemPasswordChar = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnUpdate.Depth = 0
        btnUpdate.HighEmphasis = True
        btnUpdate.Icon = Nothing
        btnUpdate.Location = New Point(540, 88)
        btnUpdate.Margin = New Padding(4, 6, 4, 6)
        btnUpdate.MouseState = MaterialSkin.MouseState.HOVER
        btnUpdate.Name = "btnUpdate"
        btnUpdate.NoAccentTextColor = Color.Empty
        btnUpdate.Size = New Size(77, 36)
        btnUpdate.TabIndex = 3
        btnUpdate.Text = "Update"
        btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnUpdate.UseAccentColor = False
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' txtFirstName
        ' 
        txtFirstName.AnimateReadOnly = False
        txtFirstName.BackgroundImageLayout = ImageLayout.None
        txtFirstName.CharacterCasing = CharacterCasing.Normal
        txtFirstName.Depth = 0
        txtFirstName.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtFirstName.HideSelection = True
        txtFirstName.Hint = "First Name"
        txtFirstName.LeadingIcon = Nothing
        txtFirstName.Location = New Point(148, 12)
        txtFirstName.MaxLength = 32767
        txtFirstName.MouseState = MaterialSkin.MouseState.OUT
        txtFirstName.Name = "txtFirstName"
        txtFirstName.PasswordChar = ChrW(0)
        txtFirstName.PrefixSuffixText = Nothing
        txtFirstName.ReadOnly = False
        txtFirstName.RightToLeft = RightToLeft.No
        txtFirstName.SelectedText = ""
        txtFirstName.SelectionLength = 0
        txtFirstName.SelectionStart = 0
        txtFirstName.ShortcutsEnabled = True
        txtFirstName.Size = New Size(250, 48)
        txtFirstName.TabIndex = 2
        txtFirstName.TabStop = False
        txtFirstName.TextAlign = HorizontalAlignment.Left
        txtFirstName.TrailingIcon = Nothing
        txtFirstName.UseSystemPasswordChar = False
        ' 
        ' btnInsert
        ' 
        btnInsert.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnInsert.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnInsert.Depth = 0
        btnInsert.HighEmphasis = True
        btnInsert.Icon = Nothing
        btnInsert.Location = New Point(540, 24)
        btnInsert.Margin = New Padding(4, 6, 4, 6)
        btnInsert.MouseState = MaterialSkin.MouseState.HOVER
        btnInsert.Name = "btnInsert"
        btnInsert.NoAccentTextColor = Color.Empty
        btnInsert.Size = New Size(71, 36)
        btnInsert.TabIndex = 3
        btnInsert.Text = "Insert"
        btnInsert.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnInsert.UseAccentColor = False
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(749, 472)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(763, 567)
        Controls.Add(MaterialTabControl1)
        DrawerTabControl = MaterialTabControl1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MaterialTabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearch As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btnSearch As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLastName As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtFirstName As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents lbGender As Label
    Friend WithEvents lbLN As Label
    Friend WithEvents lbFN As Label
    Friend WithEvents txtGender As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents btnDelete As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnUpdate As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnInsert As MaterialSkin.Controls.MaterialButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
