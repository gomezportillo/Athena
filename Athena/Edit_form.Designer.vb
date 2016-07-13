<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_form))
        Me.tb_section = New System.Windows.Forms.TextBox()
        Me.tb_author = New System.Windows.Forms.TextBox()
        Me.tb_title = New System.Windows.Forms.TextBox()
        Me.lbl_section = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_author = New System.Windows.Forms.Label()
        Me.tb_units = New System.Windows.Forms.TextBox()
        Me.lbl_units = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_section
        '
        Me.tb_section.Location = New System.Drawing.Point(107, 127)
        Me.tb_section.Name = "tb_section"
        Me.tb_section.Size = New System.Drawing.Size(516, 20)
        Me.tb_section.TabIndex = 11
        '
        'tb_author
        '
        Me.tb_author.Location = New System.Drawing.Point(107, 87)
        Me.tb_author.Name = "tb_author"
        Me.tb_author.Size = New System.Drawing.Size(516, 20)
        Me.tb_author.TabIndex = 10
        '
        'tb_title
        '
        Me.tb_title.Location = New System.Drawing.Point(107, 44)
        Me.tb_title.Name = "tb_title"
        Me.tb_title.Size = New System.Drawing.Size(516, 20)
        Me.tb_title.TabIndex = 9
        '
        'lbl_section
        '
        Me.lbl_section.AutoSize = True
        Me.lbl_section.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_section.Location = New System.Drawing.Point(58, 130)
        Me.lbl_section.Name = "lbl_section"
        Me.lbl_section.Size = New System.Drawing.Size(43, 13)
        Me.lbl_section.TabIndex = 8
        Me.lbl_section.Text = "Section"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_title.Location = New System.Drawing.Point(74, 47)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(27, 13)
        Me.lbl_title.TabIndex = 7
        Me.lbl_title.Text = "Title"
        '
        'lbl_author
        '
        Me.lbl_author.AutoSize = True
        Me.lbl_author.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_author.Location = New System.Drawing.Point(63, 90)
        Me.lbl_author.Name = "lbl_author"
        Me.lbl_author.Size = New System.Drawing.Size(38, 13)
        Me.lbl_author.TabIndex = 6
        Me.lbl_author.Text = "Author"
        '
        'tb_units
        '
        Me.tb_units.Location = New System.Drawing.Point(107, 166)
        Me.tb_units.Name = "tb_units"
        Me.tb_units.Size = New System.Drawing.Size(516, 20)
        Me.tb_units.TabIndex = 13
        '
        'lbl_units
        '
        Me.lbl_units.AutoSize = True
        Me.lbl_units.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_units.Location = New System.Drawing.Point(58, 169)
        Me.lbl_units.Name = "lbl_units"
        Me.lbl_units.Size = New System.Drawing.Size(31, 13)
        Me.lbl_units.TabIndex = 12
        Me.lbl_units.Text = "Units"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(126, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 38)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Edit_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 291)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tb_units)
        Me.Controls.Add(Me.lbl_units)
        Me.Controls.Add(Me.tb_section)
        Me.Controls.Add(Me.tb_author)
        Me.Controls.Add(Me.tb_title)
        Me.Controls.Add(Me.lbl_section)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lbl_author)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Edit_form"
        Me.Text = "Edit book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_section As TextBox
    Friend WithEvents tb_author As TextBox
    Friend WithEvents tb_title As TextBox
    Friend WithEvents lbl_section As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_author As Label
    Friend WithEvents tb_units As TextBox
    Friend WithEvents lbl_units As Label
    Friend WithEvents Button1 As Button
End Class
