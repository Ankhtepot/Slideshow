<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chbCrop = New System.Windows.Forms.CheckBox()
        Me.chbExit = New System.Windows.Forms.CheckBox()
        Me.chbInterval = New System.Windows.Forms.CheckBox()
        Me.chbPlayControls = New System.Windows.Forms.CheckBox()
        Me.chbOpenFolder = New System.Windows.Forms.CheckBox()
        Me.buCancel = New System.Windows.Forms.PictureBox()
        Me.buOK = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.buCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buOK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.chbCrop)
        Me.GroupBox1.Controls.Add(Me.chbExit)
        Me.GroupBox1.Controls.Add(Me.chbInterval)
        Me.GroupBox1.Controls.Add(Me.chbPlayControls)
        Me.GroupBox1.Controls.Add(Me.chbOpenFolder)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose buttons to show"
        '
        'chbCrop
        '
        Me.chbCrop.AutoSize = True
        Me.chbCrop.Location = New System.Drawing.Point(7, 92)
        Me.chbCrop.Name = "chbCrop"
        Me.chbCrop.Size = New System.Drawing.Size(196, 20)
        Me.chbCrop.TabIndex = 4
        Me.chbCrop.Text = "Crop Enlarg Ratio button"
        Me.chbCrop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.chbCrop.UseVisualStyleBackColor = True
        '
        'chbExit
        '
        Me.chbExit.AutoSize = True
        Me.chbExit.Location = New System.Drawing.Point(6, 116)
        Me.chbExit.Name = "chbExit"
        Me.chbExit.Size = New System.Drawing.Size(99, 20)
        Me.chbExit.TabIndex = 3
        Me.chbExit.Text = "Exit Button"
        Me.chbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.chbExit.UseVisualStyleBackColor = True
        '
        'chbInterval
        '
        Me.chbInterval.AutoSize = True
        Me.chbInterval.Location = New System.Drawing.Point(7, 68)
        Me.chbInterval.Name = "chbInterval"
        Me.chbInterval.Size = New System.Drawing.Size(124, 20)
        Me.chbInterval.TabIndex = 2
        Me.chbInterval.Text = "Interval button"
        Me.chbInterval.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.chbInterval.UseVisualStyleBackColor = True
        '
        'chbPlayControls
        '
        Me.chbPlayControls.AutoSize = True
        Me.chbPlayControls.Location = New System.Drawing.Point(7, 44)
        Me.chbPlayControls.Name = "chbPlayControls"
        Me.chbPlayControls.Size = New System.Drawing.Size(163, 20)
        Me.chbPlayControls.TabIndex = 1
        Me.chbPlayControls.Text = "Play control buttons"
        Me.chbPlayControls.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.chbPlayControls.UseVisualStyleBackColor = True
        '
        'chbOpenFolder
        '
        Me.chbOpenFolder.AutoSize = True
        Me.chbOpenFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chbOpenFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chbOpenFolder.Location = New System.Drawing.Point(7, 20)
        Me.chbOpenFolder.Name = "chbOpenFolder"
        Me.chbOpenFolder.Size = New System.Drawing.Size(160, 20)
        Me.chbOpenFolder.TabIndex = 0
        Me.chbOpenFolder.Text = "Open Folder Button"
        Me.chbOpenFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.chbOpenFolder.UseVisualStyleBackColor = True
        '
        'buCancel
        '
        Me.buCancel.BackColor = System.Drawing.Color.Transparent
        Me.buCancel.Image = Global.obrázkyZAdresare.My.Resources.Resources.cancel
        Me.buCancel.Location = New System.Drawing.Point(12, 162)
        Me.buCancel.Name = "buCancel"
        Me.buCancel.Size = New System.Drawing.Size(92, 84)
        Me.buCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.buCancel.TabIndex = 1
        Me.buCancel.TabStop = False
        '
        'buOK
        '
        Me.buOK.BackColor = System.Drawing.Color.Transparent
        Me.buOK.Image = Global.obrázkyZAdresare.My.Resources.Resources.accept1
        Me.buOK.Location = New System.Drawing.Point(144, 162)
        Me.buOK.Name = "buOK"
        Me.buOK.Size = New System.Drawing.Size(95, 84)
        Me.buOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.buOK.TabIndex = 2
        Me.buOK.TabStop = False
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.obrázkyZAdresare.My.Resources.Resources.bacgrndTiled2
        Me.ClientSize = New System.Drawing.Size(249, 258)
        Me.Controls.Add(Me.buOK)
        Me.Controls.Add(Me.buCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.buCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buOK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents chbExit As Windows.Forms.CheckBox
    Friend WithEvents chbInterval As Windows.Forms.CheckBox
    Friend WithEvents chbPlayControls As Windows.Forms.CheckBox
    Friend WithEvents chbOpenFolder As Windows.Forms.CheckBox
    Friend WithEvents buCancel As Windows.Forms.PictureBox
    Friend WithEvents buOK As Windows.Forms.PictureBox
    Friend WithEvents chbCrop As Windows.Forms.CheckBox
End Class
