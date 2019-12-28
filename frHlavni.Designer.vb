<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frHlavni
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frHlavni))
        Me.ssMain = New System.Windows.Forms.StatusStrip()
        Me.tssbuSaveFile = New System.Windows.Forms.ToolStripSplitButton()
        Me.tsslbOF = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssddbOptions = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SetButtonsInStatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeIntervalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssbuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFolderToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssbuForward = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssbuBackward = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssbuCropEnlarge = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssddbOpenFolder = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tssbuBackwards = New System.Windows.Forms.ToolStripSplitButton()
        Me.tssbuPause = New System.Windows.Forms.ToolStripSplitButton()
        Me.tssbuForwards = New System.Windows.Forms.ToolStripSplitButton()
        Me.tssbuInterval = New System.Windows.Forms.ToolStripSplitButton()
        Me.tssbuExit = New System.Windows.Forms.ToolStripDropDownButton()
        Me.fbDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.tiMain = New System.Windows.Forms.Timer(Me.components)
        Me.pbNext = New System.Windows.Forms.PictureBox()
        Me.pbPrevious = New System.Windows.Forms.PictureBox()
        Me.pbMain = New System.Windows.Forms.PictureBox()
        Me.ilMain = New System.Windows.Forms.ImageList(Me.components)
        Me.sfDialog = New System.Windows.Forms.SaveFileDialog()
        Me.il256 = New System.Windows.Forms.ImageList(Me.components)
        Me.tssbuCrop = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ssMain.SuspendLayout()
        CType(Me.pbNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPrevious, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ssMain
        '
        Me.ssMain.AllowMerge = False
        Me.ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssbuSaveFile, Me.tsslbOF, Me.tssddbOptions, Me.tssddbOpenFolder, Me.tssbuBackwards, Me.tssbuPause, Me.tssbuForwards, Me.tssbuInterval, Me.tssbuCrop, Me.tssbuExit})
        Me.ssMain.Location = New System.Drawing.Point(0, 428)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Size = New System.Drawing.Size(945, 22)
        Me.ssMain.TabIndex = 0
        Me.ssMain.Text = "StatusStrip1"
        '
        'tssbuSaveFile
        '
        Me.tssbuSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tssbuSaveFile.Image = Global.obrázkyZAdresare.My.Resources.Resources.saveIcon
        Me.tssbuSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssbuSaveFile.Name = "tssbuSaveFile"
        Me.tssbuSaveFile.Size = New System.Drawing.Size(32, 20)
        Me.tssbuSaveFile.Text = "ToolStripSplitButton1"
        '
        'tsslbOF
        '
        Me.tsslbOF.Name = "tsslbOF"
        Me.tsslbOF.Size = New System.Drawing.Size(623, 17)
        Me.tsslbOF.Spring = True
        Me.tsslbOF.Text = "Opened FIle:"
        Me.tsslbOF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tssddbOptions
        '
        Me.tssddbOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tssddbOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetButtonsInStatusBarToolStripMenuItem, Me.ChangeIntervalToolStripMenuItem, Me.tssbuSaveAs, Me.OpenFolderToolStripMenuItem1, Me.PauseToolStripMenuItem, Me.tssbuCropEnlarge, Me.OpenFolderToolStripMenuItem})
        Me.tssddbOptions.Image = Global.obrázkyZAdresare.My.Resources.Resources.options
        Me.tssddbOptions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssddbOptions.Name = "tssddbOptions"
        Me.tssddbOptions.Size = New System.Drawing.Size(29, 20)
        Me.tssddbOptions.Text = "Options"
        '
        'SetButtonsInStatusBarToolStripMenuItem
        '
        Me.SetButtonsInStatusBarToolStripMenuItem.Image = Global.obrázkyZAdresare.My.Resources.Resources.options
        Me.SetButtonsInStatusBarToolStripMenuItem.Name = "SetButtonsInStatusBarToolStripMenuItem"
        Me.SetButtonsInStatusBarToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.SetButtonsInStatusBarToolStripMenuItem.Text = "Set buttons in status bar"
        '
        'ChangeIntervalToolStripMenuItem
        '
        Me.ChangeIntervalToolStripMenuItem.Image = CType(resources.GetObject("ChangeIntervalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangeIntervalToolStripMenuItem.Name = "ChangeIntervalToolStripMenuItem"
        Me.ChangeIntervalToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ChangeIntervalToolStripMenuItem.Text = "Change interval"
        '
        'tssbuSaveAs
        '
        Me.tssbuSaveAs.Image = Global.obrázkyZAdresare.My.Resources.Resources.saveIcon
        Me.tssbuSaveAs.Name = "tssbuSaveAs"
        Me.tssbuSaveAs.Size = New System.Drawing.Size(201, 22)
        Me.tssbuSaveAs.Text = "Save as..."
        '
        'OpenFolderToolStripMenuItem1
        '
        Me.OpenFolderToolStripMenuItem1.Image = Global.obrázkyZAdresare.My.Resources.Resources.Open_file
        Me.OpenFolderToolStripMenuItem1.Name = "OpenFolderToolStripMenuItem1"
        Me.OpenFolderToolStripMenuItem1.Size = New System.Drawing.Size(201, 22)
        Me.OpenFolderToolStripMenuItem1.Text = "Open Folder"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssbuForward, Me.tssbuBackward})
        Me.PauseToolStripMenuItem.Image = Global.obrázkyZAdresare.My.Resources.Resources.pause
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.PauseToolStripMenuItem.Text = "Pause"
        '
        'tssbuForward
        '
        Me.tssbuForward.Image = Global.obrázkyZAdresare.My.Resources.Resources.nextSign
        Me.tssbuForward.Name = "tssbuForward"
        Me.tssbuForward.Size = New System.Drawing.Size(244, 22)
        Me.tssbuForward.Text = "Slideshow in forward direction"
        '
        'tssbuBackward
        '
        Me.tssbuBackward.Image = Global.obrázkyZAdresare.My.Resources.Resources.previous
        Me.tssbuBackward.Name = "tssbuBackward"
        Me.tssbuBackward.Size = New System.Drawing.Size(244, 22)
        Me.tssbuBackward.Text = "Slideshow in backward direction"
        '
        'tssbuCropEnlarge
        '
        Me.tssbuCropEnlarge.Image = Global.obrázkyZAdresare.My.Resources.Resources.crop_512
        Me.tssbuCropEnlarge.Name = "tssbuCropEnlarge"
        Me.tssbuCropEnlarge.Size = New System.Drawing.Size(201, 22)
        Me.tssbuCropEnlarge.Text = "Crop Enlarge mulltiplier"
        '
        'OpenFolderToolStripMenuItem
        '
        Me.OpenFolderToolStripMenuItem.Image = Global.obrázkyZAdresare.My.Resources.Resources.exitSign
        Me.OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem"
        Me.OpenFolderToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.OpenFolderToolStripMenuItem.Text = "Exit"
        '
        'tssddbOpenFolder
        '
        Me.tssddbOpenFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tssddbOpenFolder.Image = Global.obrázkyZAdresare.My.Resources.Resources.Open_file
        Me.tssddbOpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssddbOpenFolder.Name = "tssddbOpenFolder"
        Me.tssddbOpenFolder.Size = New System.Drawing.Size(29, 20)
        Me.tssddbOpenFolder.Text = "Open Folder"
        '
        'tssbuBackwards
        '
        Me.tssbuBackwards.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tssbuBackwards.Image = Global.obrázkyZAdresare.My.Resources.Resources.previous
        Me.tssbuBackwards.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssbuBackwards.Name = "tssbuBackwards"
        Me.tssbuBackwards.Size = New System.Drawing.Size(32, 20)
        Me.tssbuBackwards.Text = "ToolStripSplitButton1"
        '
        'tssbuPause
        '
        Me.tssbuPause.BackgroundImage = Global.obrázkyZAdresare.My.Resources.Resources.play
        Me.tssbuPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tssbuPause.Image = CType(resources.GetObject("tssbuPause.Image"), System.Drawing.Image)
        Me.tssbuPause.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssbuPause.Name = "tssbuPause"
        Me.tssbuPause.Size = New System.Drawing.Size(32, 20)
        Me.tssbuPause.Text = "ToolStripSplitButton1"
        '
        'tssbuForwards
        '
        Me.tssbuForwards.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tssbuForwards.Image = CType(resources.GetObject("tssbuForwards.Image"), System.Drawing.Image)
        Me.tssbuForwards.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssbuForwards.Name = "tssbuForwards"
        Me.tssbuForwards.Size = New System.Drawing.Size(32, 20)
        Me.tssbuForwards.Text = "ToolStripSplitButton1"
        '
        'tssbuInterval
        '
        Me.tssbuInterval.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tssbuInterval.Image = CType(resources.GetObject("tssbuInterval.Image"), System.Drawing.Image)
        Me.tssbuInterval.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssbuInterval.Name = "tssbuInterval"
        Me.tssbuInterval.Size = New System.Drawing.Size(32, 20)
        Me.tssbuInterval.Text = "ToolStripSplitButton1"
        '
        'tssbuExit
        '
        Me.tssbuExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tssbuExit.Image = Global.obrázkyZAdresare.My.Resources.Resources.exitSign
        Me.tssbuExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssbuExit.Name = "tssbuExit"
        Me.tssbuExit.Size = New System.Drawing.Size(29, 20)
        Me.tssbuExit.Text = "Exit"
        Me.tssbuExit.ToolTipText = "Exit"
        '
        'tiMain
        '
        Me.tiMain.Interval = 1000
        '
        'pbNext
        '
        Me.pbNext.BackColor = System.Drawing.Color.Transparent
        Me.pbNext.ErrorImage = Global.obrázkyZAdresare.My.Resources.Resources.panicButton
        Me.pbNext.Image = Global.obrázkyZAdresare.My.Resources.Resources.nextSign
        Me.pbNext.InitialImage = CType(resources.GetObject("pbNext.InitialImage"), System.Drawing.Image)
        Me.pbNext.Location = New System.Drawing.Point(836, 316)
        Me.pbNext.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.pbNext.Name = "pbNext"
        Me.pbNext.Size = New System.Drawing.Size(100, 100)
        Me.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbNext.TabIndex = 3
        Me.pbNext.TabStop = False
        '
        'pbPrevious
        '
        Me.pbPrevious.BackColor = System.Drawing.Color.Transparent
        Me.pbPrevious.ErrorImage = Global.obrázkyZAdresare.My.Resources.Resources.OMG
        Me.pbPrevious.Image = Global.obrázkyZAdresare.My.Resources.Resources.previous
        Me.pbPrevious.InitialImage = CType(resources.GetObject("pbPrevious.InitialImage"), System.Drawing.Image)
        Me.pbPrevious.Location = New System.Drawing.Point(12, 316)
        Me.pbPrevious.Margin = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.pbPrevious.Name = "pbPrevious"
        Me.pbPrevious.Size = New System.Drawing.Size(100, 100)
        Me.pbPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPrevious.TabIndex = 2
        Me.pbPrevious.TabStop = False
        '
        'pbMain
        '
        Me.pbMain.BackColor = System.Drawing.Color.Transparent
        Me.pbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbMain.ErrorImage = CType(resources.GetObject("pbMain.ErrorImage"), System.Drawing.Image)
        Me.pbMain.Image = Global.obrázkyZAdresare.My.Resources.Resources.clickHere1
        Me.pbMain.InitialImage = CType(resources.GetObject("pbMain.InitialImage"), System.Drawing.Image)
        Me.pbMain.Location = New System.Drawing.Point(331, 93)
        Me.pbMain.Margin = New System.Windows.Forms.Padding(0)
        Me.pbMain.Name = "pbMain"
        Me.pbMain.Size = New System.Drawing.Size(299, 206)
        Me.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMain.TabIndex = 1
        Me.pbMain.TabStop = False
        '
        'ilMain
        '
        Me.ilMain.ImageStream = CType(resources.GetObject("ilMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilMain.TransparentColor = System.Drawing.Color.Transparent
        Me.ilMain.Images.SetKeyName(0, "exit sign.png")
        Me.ilMain.Images.SetKeyName(1, "Open_file.png")
        Me.ilMain.Images.SetKeyName(2, "options.png")
        Me.ilMain.Images.SetKeyName(3, "play.jpg")
        Me.ilMain.Images.SetKeyName(4, "accept.jpg")
        Me.ilMain.Images.SetKeyName(5, "cancel-icon.png")
        Me.ilMain.Images.SetKeyName(6, "Next-icon.png")
        Me.ilMain.Images.SetKeyName(7, "Previous-icon.png")
        Me.ilMain.Images.SetKeyName(8, "stažený soubor.jpg")
        Me.ilMain.Images.SetKeyName(9, "stažený soubor.png")
        Me.ilMain.Images.SetKeyName(10, "clickHere.gif")
        Me.ilMain.Images.SetKeyName(11, "crop-512.png")
        '
        'sfDialog
        '
        Me.sfDialog.Filter = "png file (*.png)|*.png|jpg (Jpeg) file|*.jpeg| Bitmap file (*.BMP)|*.bmp|GIF file" &
    " (*.gif)|*.gif"
        '
        'il256
        '
        Me.il256.ImageStream = CType(resources.GetObject("il256.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il256.TransparentColor = System.Drawing.Color.Transparent
        Me.il256.Images.SetKeyName(0, "clickHere.gif")
        '
        'tssbuCrop
        '
        Me.tssbuCrop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tssbuCrop.Image = Global.obrázkyZAdresare.My.Resources.Resources.crop_512
        Me.tssbuCrop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssbuCrop.Name = "tssbuCrop"
        Me.tssbuCrop.Size = New System.Drawing.Size(29, 20)
        Me.tssbuCrop.Text = "ToolStripDropDownButton1"
        '
        'frHlavni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.obrázkyZAdresare.My.Resources.Resources.bacgrndTiled2
        Me.ClientSize = New System.Drawing.Size(945, 450)
        Me.Controls.Add(Me.pbNext)
        Me.Controls.Add(Me.pbPrevious)
        Me.Controls.Add(Me.pbMain)
        Me.Controls.Add(Me.ssMain)
        Me.Name = "frHlavni"
        Me.Text = "Slideshow"
        Me.TransparencyKey = System.Drawing.Color.DimGray
        Me.ssMain.ResumeLayout(False)
        Me.ssMain.PerformLayout()
        CType(Me.pbNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPrevious, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ssMain As Windows.Forms.StatusStrip
    Friend WithEvents tsslbOF As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssddbOptions As Windows.Forms.ToolStripDropDownButton
    Friend WithEvents OpenFolderToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFolderToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbMain As Windows.Forms.PictureBox
    Friend WithEvents tssbuExit As Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tssddbOpenFolder As Windows.Forms.ToolStripDropDownButton
    Friend WithEvents fbDialog As Windows.Forms.FolderBrowserDialog
    Friend WithEvents tiMain As Windows.Forms.Timer
    Friend WithEvents ChangeIntervalToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssbuPause As Windows.Forms.ToolStripSplitButton
    Friend WithEvents pbPrevious As Windows.Forms.PictureBox
    Friend WithEvents pbNext As Windows.Forms.PictureBox
    Friend WithEvents PauseToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssbuInterval As Windows.Forms.ToolStripSplitButton
    Friend WithEvents SetButtonsInStatusBarToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ilMain As Windows.Forms.ImageList
    Friend WithEvents tssbuBackwards As Windows.Forms.ToolStripSplitButton
    Friend WithEvents tssbuForwards As Windows.Forms.ToolStripSplitButton
    Friend WithEvents tssbuForward As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssbuBackward As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssbuCropEnlarge As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssbuSaveFile As Windows.Forms.ToolStripSplitButton
    Friend WithEvents sfDialog As Windows.Forms.SaveFileDialog
    Friend WithEvents tssbuSaveAs As Windows.Forms.ToolStripMenuItem
    Friend WithEvents il256 As Windows.Forms.ImageList
    Friend WithEvents tssbuCrop As Windows.Forms.ToolStripDropDownButton
End Class
