<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebBrownser
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.txtnav = New System.Windows.Forms.TextBox()
        Me.btgo = New System.Windows.Forms.Button()
        Me.btrefresh = New System.Windows.Forms.Button()
        Me.btforward = New System.Windows.Forms.Button()
        Me.btback = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Chartreuse
        Me.Panel1.Controls.Add(Me.btgo)
        Me.Panel1.Controls.Add(Me.txtnav)
        Me.Panel1.Controls.Add(Me.btrefresh)
        Me.Panel1.Controls.Add(Me.btforward)
        Me.Panel1.Controls.Add(Me.btback)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 65)
        Me.Panel1.TabIndex = 0
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 65)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(636, 324)
        Me.WebBrowser1.TabIndex = 1
        '
        'txtnav
        '
        Me.txtnav.Location = New System.Drawing.Point(183, 21)
        Me.txtnav.Name = "txtnav"
        Me.txtnav.Size = New System.Drawing.Size(381, 20)
        Me.txtnav.TabIndex = 3
        '
        'btgo
        '
        Me.btgo.Image = Global.VBGit.My.Resources.Resources.go
        Me.btgo.Location = New System.Drawing.Point(570, 12)
        Me.btgo.Name = "btgo"
        Me.btgo.Size = New System.Drawing.Size(54, 37)
        Me.btgo.TabIndex = 4
        Me.btgo.UseVisualStyleBackColor = True
        '
        'btrefresh
        '
        Me.btrefresh.Image = Global.VBGit.My.Resources.Resources.refresh
        Me.btrefresh.Location = New System.Drawing.Point(123, 12)
        Me.btrefresh.Name = "btrefresh"
        Me.btrefresh.Size = New System.Drawing.Size(54, 37)
        Me.btrefresh.TabIndex = 2
        Me.btrefresh.UseVisualStyleBackColor = True
        '
        'btforward
        '
        Me.btforward.BackColor = System.Drawing.SystemColors.Desktop
        Me.btforward.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btforward.Image = Global.VBGit.My.Resources.Resources.forward
        Me.btforward.Location = New System.Drawing.Point(63, 12)
        Me.btforward.Name = "btforward"
        Me.btforward.Size = New System.Drawing.Size(54, 37)
        Me.btforward.TabIndex = 1
        Me.btforward.UseVisualStyleBackColor = False
        '
        'btback
        '
        Me.btback.BackColor = System.Drawing.SystemColors.Desktop
        Me.btback.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btback.Image = Global.VBGit.My.Resources.Resources.back
        Me.btback.Location = New System.Drawing.Point(3, 12)
        Me.btback.Name = "btback"
        Me.btback.Size = New System.Drawing.Size(54, 37)
        Me.btback.TabIndex = 0
        Me.btback.UseVisualStyleBackColor = False
        '
        'WebBrownser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 389)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "WebBrownser"
        Me.Text = "WebBrownser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents btgo As Button
    Friend WithEvents txtnav As TextBox
    Friend WithEvents btrefresh As Button
    Friend WithEvents btforward As Button
    Friend WithEvents btback As Button
End Class
