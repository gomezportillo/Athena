<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About_form))
        Me.lbl_about = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_info2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_link = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_about
        '
        resources.ApplyResources(Me.lbl_about, "lbl_about")
        Me.lbl_about.Name = "lbl_about"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_info2
        '
        resources.ApplyResources(Me.lbl_info2, "lbl_info2")
        Me.lbl_info2.Name = "lbl_info2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Athena.My.Resources.Resources.logo_small1
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'lbl_link
        '
        resources.ApplyResources(Me.lbl_link, "lbl_link")
        Me.lbl_link.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_link.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_link.Name = "lbl_link"
        '
        'About_form
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbl_link)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_info2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_about)
        Me.Name = "About_form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_about As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_info2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_link As Label
End Class
