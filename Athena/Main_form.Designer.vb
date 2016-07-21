<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_form))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneratetxtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tb_collection = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_add = New System.Windows.Forms.Button()
        Me.tb_section = New System.Windows.Forms.TextBox()
        Me.tb_author = New System.Windows.Forms.TextBox()
        Me.tb_title = New System.Windows.Forms.TextBox()
        Me.lbl_section = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_author = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_collection = New System.Windows.Forms.RadioButton()
        Me.rb_section = New System.Windows.Forms.RadioButton()
        Me.rb_author = New System.Windows.Forms.RadioButton()
        Me.rb_title = New System.Windows.Forms.RadioButton()
        Me.tb_search = New System.Windows.Forms.TextBox()
        Me.listView_books = New System.Windows.Forms.ListView()
        Me.lv_title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lv_author = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lv_section = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lv_collection = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lv_units = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_info = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneratetxtToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        resources.ApplyResources(Me.FileToolStripMenuItem, "FileToolStripMenuItem")
        '
        'GeneratetxtToolStripMenuItem
        '
        Me.GeneratetxtToolStripMenuItem.Name = "GeneratetxtToolStripMenuItem"
        resources.ApplyResources(Me.GeneratetxtToolStripMenuItem, "GeneratetxtToolStripMenuItem")
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        resources.ApplyResources(Me.ExitToolStripMenuItem, "ExitToolStripMenuItem")
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        resources.ApplyResources(Me.HelpToolStripMenuItem, "HelpToolStripMenuItem")
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        resources.ApplyResources(Me.AboutToolStripMenuItem, "AboutToolStripMenuItem")
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tb_collection)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Btn_add)
        Me.TabPage1.Controls.Add(Me.tb_section)
        Me.TabPage1.Controls.Add(Me.tb_author)
        Me.TabPage1.Controls.Add(Me.tb_title)
        Me.TabPage1.Controls.Add(Me.lbl_section)
        Me.TabPage1.Controls.Add(Me.lbl_title)
        Me.TabPage1.Controls.Add(Me.lbl_author)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tb_collection
        '
        Me.tb_collection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tb_collection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        resources.ApplyResources(Me.tb_collection, "tb_collection")
        Me.tb_collection.Name = "tb_collection"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Btn_add
        '
        resources.ApplyResources(Me.Btn_add, "Btn_add")
        Me.Btn_add.Name = "Btn_add"
        Me.Btn_add.UseVisualStyleBackColor = True
        '
        'tb_section
        '
        Me.tb_section.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tb_section.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        resources.ApplyResources(Me.tb_section, "tb_section")
        Me.tb_section.Name = "tb_section"
        '
        'tb_author
        '
        Me.tb_author.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tb_author.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        resources.ApplyResources(Me.tb_author, "tb_author")
        Me.tb_author.Name = "tb_author"
        '
        'tb_title
        '
        Me.tb_title.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tb_title.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
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
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.listView_books)
        resources.ApplyResources(Me.TabPage3, "TabPage3")
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_collection)
        Me.GroupBox1.Controls.Add(Me.rb_section)
        Me.GroupBox1.Controls.Add(Me.rb_author)
        Me.GroupBox1.Controls.Add(Me.rb_title)
        Me.GroupBox1.Controls.Add(Me.tb_search)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'rb_collection
        '
        resources.ApplyResources(Me.rb_collection, "rb_collection")
        Me.rb_collection.Name = "rb_collection"
        Me.rb_collection.UseVisualStyleBackColor = True
        '
        'rb_section
        '
        resources.ApplyResources(Me.rb_section, "rb_section")
        Me.rb_section.Name = "rb_section"
        Me.rb_section.UseVisualStyleBackColor = True
        '
        'rb_author
        '
        resources.ApplyResources(Me.rb_author, "rb_author")
        Me.rb_author.Name = "rb_author"
        Me.rb_author.UseVisualStyleBackColor = True
        '
        'rb_title
        '
        resources.ApplyResources(Me.rb_title, "rb_title")
        Me.rb_title.Checked = True
        Me.rb_title.Name = "rb_title"
        Me.rb_title.TabStop = True
        Me.rb_title.UseVisualStyleBackColor = True
        '
        'tb_search
        '
        Me.tb_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tb_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        resources.ApplyResources(Me.tb_search, "tb_search")
        Me.tb_search.Name = "tb_search"
        '
        'listView_books
        '
        Me.listView_books.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lv_title, Me.lv_author, Me.lv_section, Me.lv_collection, Me.lv_units})
        Me.listView_books.FullRowSelect = True
        Me.listView_books.GridLines = True
        resources.ApplyResources(Me.listView_books, "listView_books")
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
        'lv_collection
        '
        resources.ApplyResources(Me.lv_collection, "lv_collection")
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
        'Main_form
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbl_info)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main_form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_author As Label
    Friend WithEvents lbl_section As Label
    Friend WithEvents lbl_info As Label
    Friend WithEvents Btn_add As Button
    Friend WithEvents tb_section As TextBox
    Friend WithEvents tb_author As TextBox
    Friend WithEvents tb_title As TextBox
    Friend WithEvents listView_books As ListView
    Friend WithEvents lv_title As ColumnHeader
    Friend WithEvents lv_author As ColumnHeader
    Friend WithEvents lv_section As ColumnHeader
    Friend WithEvents lv_units As ColumnHeader
    Friend WithEvents tb_search As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_section As RadioButton
    Friend WithEvents rb_author As RadioButton
    Friend WithEvents rb_title As RadioButton
    Friend WithEvents GeneratetxtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tb_collection As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rb_collection As RadioButton
    Friend WithEvents lv_collection As ColumnHeader
End Class
