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
        Me.components = New System.ComponentModel.Container()
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        resources.ApplyResources(Me.FileToolStripMenuItem, "FileToolStripMenuItem")
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectDatabaseToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        '
        'SelectDatabaseToolStripMenuItem
        '
        resources.ApplyResources(Me.SelectDatabaseToolStripMenuItem, "SelectDatabaseToolStripMenuItem")
        Me.SelectDatabaseToolStripMenuItem.Name = "SelectDatabaseToolStripMenuItem"
        '
        'ExitToolStripMenuItem
        '
        resources.ApplyResources(Me.ExitToolStripMenuItem, "ExitToolStripMenuItem")
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        '
        'HelpToolStripMenuItem
        '
        resources.ApplyResources(Me.HelpToolStripMenuItem, "HelpToolStripMenuItem")
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        '
        'AboutToolStripMenuItem
        '
        resources.ApplyResources(Me.AboutToolStripMenuItem, "AboutToolStripMenuItem")
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        '
        'TabControl1
        '
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'TabPage1
        '
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.tb_section)
        Me.TabPage1.Controls.Add(Me.tb_author)
        Me.TabPage1.Controls.Add(Me.tb_title)
        Me.TabPage1.Controls.Add(Me.lbl_section)
        Me.TabPage1.Controls.Add(Me.lbl_title)
        Me.TabPage1.Controls.Add(Me.lbl_author)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tb_section
        '
        resources.ApplyResources(Me.tb_section, "tb_section")
        Me.tb_section.Name = "tb_section"
        '
        'tb_author
        '
        resources.ApplyResources(Me.tb_author, "tb_author")
        Me.tb_author.Name = "tb_author"
        '
        'tb_title
        '
        resources.ApplyResources(Me.tb_title, "tb_title")
        Me.tb_title.Name = "tb_title"
        '
        'lbl_section
        '
        resources.ApplyResources(Me.lbl_section, "lbl_section")
        Me.lbl_section.Name = "lbl_section"
        '
        'lbl_title
        '
        resources.ApplyResources(Me.lbl_title, "lbl_title")
        Me.lbl_title.Name = "lbl_title"
        '
        'lbl_author
        '
        resources.ApplyResources(Me.lbl_author, "lbl_author")
        Me.lbl_author.Name = "lbl_author"
        '
        'TabPage2
        '
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        resources.ApplyResources(Me.TabPage3, "TabPage3")
        Me.TabPage3.Controls.Add(Me.listView_books)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'listView_books
        '
        resources.ApplyResources(Me.listView_books, "listView_books")
        Me.listView_books.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lv_title, Me.lv_author, Me.lv_section, Me.lv_units})
        Me.listView_books.FullRowSelect = True
        Me.listView_books.GridLines = True
        Me.listView_books.Name = "listView_books"
        Me.listView_books.UseCompatibleStateImageBehavior = False
        Me.listView_books.View = System.Windows.Forms.View.Details
        '
        'lv_title
        '
        resources.ApplyResources(Me.lv_title, "lv_title")
        '
        'lv_author
        '
        resources.ApplyResources(Me.lv_author, "lv_author")
        '
        'lv_section
        '
        resources.ApplyResources(Me.lv_section, "lv_section")
        '
        'lv_units
        '
        resources.ApplyResources(Me.lv_units, "lv_units")
        '
        'lbl_info
        '
        resources.ApplyResources(Me.lbl_info, "lbl_info")
        Me.lbl_info.Name = "lbl_info"
        '
        'ContextMenuStrip1
        '
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        '
        'Main_frame
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbl_info)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main_frame"
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
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
