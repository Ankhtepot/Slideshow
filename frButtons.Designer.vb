<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frButtons
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
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

    'Vyžadováno Návrhářem Windows Form
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující procedura je vyžadována Návrhářem Windows Form
    'Může být upraveno pomocí Návrháře Windows Form.  
    'Neupravovat pomocí editoru kódu
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbExit = New System.Windows.Forms.CheckBox()
        Me.cbOpen = New System.Windows.Forms.CheckBox()
        Me.cbInterval = New System.Windows.Forms.CheckBox()
        Me.cbPause = New System.Windows.Forms.CheckBox()
        Me.buOK = New System.Windows.Forms.Button()
        Me.buCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbExit)
        Me.GroupBox1.Controls.Add(Me.cbOpen)
        Me.GroupBox1.Controls.Add(Me.cbInterval)
        Me.GroupBox1.Controls.Add(Me.cbPause)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 117)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "checked is shown"
        '
        'cbExit
        '
        Me.cbExit.AutoSize = True
        Me.cbExit.Location = New System.Drawing.Point(12, 92)
        Me.cbExit.Name = "cbExit"
        Me.cbExit.Size = New System.Drawing.Size(98, 17)
        Me.cbExit.TabIndex = 3
        Me.cbExit.Text = "Exit App button"
        Me.cbExit.UseVisualStyleBackColor = True
        '
        'cbOpen
        '
        Me.cbOpen.AutoSize = True
        Me.cbOpen.Location = New System.Drawing.Point(12, 68)
        Me.cbOpen.Name = "cbOpen"
        Me.cbOpen.Size = New System.Drawing.Size(117, 17)
        Me.cbOpen.TabIndex = 2
        Me.cbOpen.Text = "Open Folder button"
        Me.cbOpen.UseVisualStyleBackColor = True
        '
        'cbInterval
        '
        Me.cbInterval.AutoSize = True
        Me.cbInterval.Location = New System.Drawing.Point(12, 44)
        Me.cbInterval.Name = "cbInterval"
        Me.cbInterval.Size = New System.Drawing.Size(113, 17)
        Me.cbInterval.TabIndex = 1
        Me.cbInterval.Text = "Set Interval button"
        Me.cbInterval.UseVisualStyleBackColor = True
        '
        'cbPause
        '
        Me.cbPause.AutoSize = True
        Me.cbPause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cbPause.Location = New System.Drawing.Point(12, 20)
        Me.cbPause.Name = "cbPause"
        Me.cbPause.Size = New System.Drawing.Size(114, 17)
        Me.cbPause.TabIndex = 0
        Me.cbPause.Text = "Slideshow controls"
        Me.cbPause.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cbPause.UseVisualStyleBackColor = True
        '
        'buOK
        '
        Me.buOK.BackgroundImage = Global.obrázkyZAdresare.My.Resources.Resources.accept
        Me.buOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buOK.Location = New System.Drawing.Point(98, 126)
        Me.buOK.Name = "buOK"
        Me.buOK.Size = New System.Drawing.Size(35, 35)
        Me.buOK.TabIndex = 2
        Me.buOK.UseVisualStyleBackColor = True
        '
        'buCancel
        '
        Me.buCancel.BackgroundImage = Global.obrázkyZAdresare.My.Resources.Resources.cancel
        Me.buCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buCancel.Location = New System.Drawing.Point(12, 126)
        Me.buCancel.Name = "buCancel"
        Me.buCancel.Size = New System.Drawing.Size(35, 35)
        Me.buCancel.TabIndex = 1
        Me.buCancel.UseVisualStyleBackColor = True
        '
        'frButtons
        '
        Me.AcceptButton = Me.buOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.buCancel
        Me.ClientSize = New System.Drawing.Size(145, 166)
        Me.ControlBox = False
        Me.Controls.Add(Me.buOK)
        Me.Controls.Add(Me.buCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frButtons"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Button selection"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents buCancel As Windows.Forms.Button
    Friend WithEvents buOK As Windows.Forms.Button
    Friend WithEvents cbOpen As Windows.Forms.CheckBox
    Friend WithEvents cbInterval As Windows.Forms.CheckBox
    Friend WithEvents cbPause As Windows.Forms.CheckBox
    Friend WithEvents cbExit As Windows.Forms.CheckBox
End Class
