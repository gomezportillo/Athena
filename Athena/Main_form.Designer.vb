<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_frame
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_frame))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tb_section = New System.Windows.Forms.TextBox()
        Me.tb_author = New System.Windows.Forms.TextBox()
        Me.tb_title = New System.Windows.Forms.TextBox()
        Me.lbl_section = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_author = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.listView_books = New System.Windows.Forms.ListView()
        Me.lv_title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lv_author = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lv_section = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lv_units = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_info = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1274, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectDatabaseToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SelectDatabaseToolStripMenuItem
        '
        Me.SelectDatabaseToolStripMenuItem.Name = "SelectDatabaseToolStripMenuItem"
        Me.SelectDatabaseToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SelectDatabaseToolStripMenuItem.Text = "Select database"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1250, 486)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.tb_section)
        Me.TabPage1.Controls.Add(Me.tb_author)
        Me.TabPage1.Controls.Add(Me.tb_title)
        Me.TabPage1.Controls.Add(Me.lbl_section)
        Me.TabPage1.Controls.Add(Me.lbl_title)
        Me.TabPage1.Controls.Add(Me.lbl_author)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1242, 460)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add book"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(480, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(287, 70)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Add book"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tb_section
        '
        Me.tb_section.Location = New System.Drawing.Point(108, 177)
        Me.tb_section.Name = "tb_section"
        Me.tb_section.Size = New System.Drawing.Size(1021, 20)
        Me.tb_section.TabIndex = 5
        '
        'tb_author
        '
        Me.tb_author.Location = New System.Drawing.Point(108, 137)
        Me.tb_author.Name = "tb_author"
        Me.tb_author.Size = New System.Drawing.Size(1021, 20)
        Me.tb_author.TabIndex = 4
        '
        'tb_title
        '
        Me.tb_title.Location = New System.Drawing.Point(108, 94)
        Me.tb_title.Name = "tb_title"
        Me.tb_title.Size = New System.Drawing.Size(1021, 20)
        Me.tb_title.TabIndex = 3
        '
        'lbl_section
        '
        Me.lbl_section.AutoSize = True
        Me.lbl_section.Location = New System.Drawing.Point(59, 180)
        Me.lbl_section.Name = "lbl_section"
        Me.lbl_section.Size = New System.Drawing.Size(43, 13)
        Me.lbl_section.TabIndex = 2
        Me.lbl_section.Text = "Section"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(75, 97)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(27, 13)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Title"
        '
        'lbl_author
        '
        Me.lbl_author.AutoSize = True
        Me.lbl_author.Location = New System.Drawing.Point(64, 140)
        Me.lbl_author.Name = "lbl_author"
        Me.lbl_author.Size = New System.Drawing.Size(38, 13)
        Me.lbl_author.TabIndex = 0
        Me.lbl_author.Text = "Author"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1242, 473)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Search book"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.listView_books)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1242, 460)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Manage books"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'listView_books
        '
        Me.listView_books.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lv_title, Me.lv_author, Me.lv_section, Me.lv_units})
        Me.listView_books.FullRowSelect = True
        Me.listView_books.GridLines = True
        Me.listView_books.Location = New System.Drawing.Point(0, 0)
        Me.listView_books.Name = "listView_books"
        Me.listView_books.Size = New System.Drawing.Size(1242, 473)
        Me.listView_books.TabIndex = 0
        Me.listView_books.UseCompatibleStateImageBehavior = False
        Me.listView_books.View = System.Windows.Forms.View.Details
        '
        'lv_title
        '
        Me.lv_title.Text = "Title"
        Me.lv_title.Width = 360
        '
        'lv_author
        '
        Me.lv_author.Text = "Author"
        Me.lv_author.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lv_author.Width = 423
        '
        'lv_section
        '
        Me.lv_section.Text = "Section"
        Me.lv_section.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lv_section.Width = 323
        '
        'lv_units
        '
        Me.lv_units.Text = "Units"
        Me.lv_units.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lv_units.Width = 132
        '
        'lbl_info
        '
        Me.lbl_info.AutoSize = True
        Me.lbl_info.Location = New System.Drawing.Point(13, 516)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(0, 13)
        Me.lbl_info.TabIndex = 2
        '
        'Main_frame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 538)
        Me.Controls.Add(Me.lbl_info)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main_frame"
        Me.Text = "Athena"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_author As Label
    Friend WithEvents lbl_section As Label
    Friend WithEvents lbl_info As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents tb_section As TextBox
    Friend WithEvents tb_author As TextBox
    Friend WithEvents tb_title As TextBox
    Friend WithEvents listView_books As ListView
    Friend WithEvents lv_title As ColumnHeader
    Friend WithEvents lv_author As ColumnHeader
    Friend WithEvents lv_section As ColumnHeader
    Friend WithEvents lv_units As ColumnHeader
End Class
