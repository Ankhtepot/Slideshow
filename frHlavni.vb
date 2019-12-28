Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing
Imports System.Reflection

'TODO:
'DONE solve showing blue sqaure ehile chosing region to enlarge
'DONE add enlarge ration for croping
'DONE make saving croped image when those above are done

Public Class frHlavni
    Public pictureHandler As FileHandler 'object to feed files
    Public Shared cbHolder As formPropHolder = New formPropHolder() 'storage for button selection
    Private RectStartPoint As Point
    Private Rect As Rectangle = New Rectangle() 'rectangle buffer for selection area
    Private selectionBrush As Brush = New SolidBrush(Color.FromArgb(128, 72, 145, 220)) 'color of selection area
    Private tempImage As Image 'buffer image for general use
    Private selectionActive As Boolean 'for selection of area for cropping
    Public PlayDirection As Boolean 'True = forward going slideshow, False = backwards going slideshow
    Public enlargeRatio As Integer
    Public cropped As Boolean = False 'flag to check if cropping worked


    Private Sub tsddbExit_Click(sender As Object, e As EventArgs) Handles tssbuExit.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbMain.Click
        If selectionActive = False Then fbDialogOpen()
    End Sub

    Public Sub fbDialogOpen()
        Dim dialogResult As DialogResult = fbDialog.ShowDialog()
        If dialogResult = DialogResult.OK Then
            pictureHandler.directoryPath = fbDialog.SelectedPath
            Dim tempFList() As String = filterImages(Directory.GetFiles(fbDialog.SelectedPath))
            If tempFList IsNot Nothing Then
                If tempFList(0) IsNot "" Then
                    pictureHandler.feederIni(filterImages(tempFList))
                    'Debug.WriteLine(showStringArray(filterImages(tempFList)))
                    If PlayDirection Then directionsBuSetup(directionSetupState.forward) Else directionsBuSetup(directionSetupState.backward)
                End If
            Else
                directionsBuSetup(directionSetupState.noFiles)
                pictureHandler.feederIni(Nothing)
            End If

            tiMain.Enabled = True
            UpdateSS(pictureHandler)
        End If

    End Sub

    Private Sub tssddbOpenFolder_Click(sender As Object, e As EventArgs) Handles tssddbOpenFolder.Click
        fbDialogOpen()
    End Sub

    Private Sub frHlavni_Load(sender As Object, e As EventArgs) Handles Me.Load
        pictureHandler = New FileHandler()
        'fbDialog.SelectedPath = "D:\obrazky\Android resources"
        fbDialog.SelectedPath = "D:\obrazky\resources"
        tempImage = New Bitmap(1, 1)
        directionsBuSetup(directionSetupState.noFiles)
        PlayDirection = True
        resizePB(pbMain.Image)
        enlargeRatio = 2
        SetStripButtons()
    End Sub

    Private Sub tiMain_Tick(sender As Object, e As EventArgs) Handles tiMain.Tick
        If pictureHandler.nextFile = pictureHandler.currentFile Then tiMain.Enabled = False
        ManagePictureChange(PlayDirection)
    End Sub

    Public Function UpdateSS(ByVal fh As FileHandler) As String
        Dim result As String = ""
        result += "previous file: " + pictureHandler.previousFile.TrimPath(25) +
            " | current file: " + pictureHandler.currentFile.TrimPath(25) +
            " | next file: " + pictureHandler.nextFile.TrimPath(25) +
            " ."
        Return result
    End Function

    'function to check if filename is image-fitting file
    Function IsValidImage(filename As String) As Boolean
        Dim testResult As Boolean = False
        Try
            Dim img As System.Drawing.Image = System.Drawing.Image.FromFile(filename)
            testResult = True
        Catch generatedExceptionName As OutOfMemoryException
            testResult = False
        Catch ex As Exception

            testResult = False
        End Try
        Return testResult
    End Function

    'function to filter image files from all files in directory
    Function filterImages(ByVal list() As String) As String()
        Dim result() As String = {""}
        If list IsNot Nothing Then
            Dim listSize = list.GetUpperBound(0)

            Dim tempresult(listSize) As String
            For index = 0 To tempresult.GetUpperBound(0)
                tempresult(index) = ""
            Next
            Dim anyImages As Boolean = False
            Dim nrOfImages = 0
            For i As Integer = 0 To list.GetUpperBound(0)
                If IsValidImage(list(i)) Then
                    anyImages = True
                    tempresult(nrOfImages) = list(i)
                    nrOfImages += 1
                End If
            Next
            If tempresult.Length > 1 Then
                ReDim result(nrOfImages - 1)
                For i As Integer = 0 To nrOfImages - 1
                    result(i) = tempresult(i)
                Next
            End If
            If tempresult.Length = 1 Then
                result(0) = tempresult(0)
            End If

            If nrOfImages = 0 Then result = Nothing
        Else
            DialogResult = Nothing
        End If


        Return result
    End Function

    'general purpuse function to list content of String array
    Public Function showStringArray(ByVal arr() As String) As String
        Dim result As String = "Výpis pole:" + vbCrLf
        If arr IsNot Nothing Then
            For i As Integer = 0 To arr.GetUpperBound(0)
                result += arr(i) + vbCrLf
            Next
        End If
        Return result
    End Function

    Private Sub ChangeIntervalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeIntervalToolStripMenuItem.Click
        changeInterval()
    End Sub

    Private Sub OpenFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFolderToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub tssbuPause_ButtonClick(sender As Object, e As EventArgs) Handles tssbuPause.ButtonClick
        PauseClick()
    End Sub

    Private Sub pbNext_Click(sender As Object, e As EventArgs) Handles pbNext.Click
        cropped = False
        If pbNext.Image Is pbNext.ErrorImage Then
            pbMain.SizeMode = PictureBoxSizeMode.Zoom
            pbMain.Image = pbMain.InitialImage
            resizePB(pbMain.Image)
        End If
        If tiMain.Enabled = False And pbNext.Image IsNot pbNext.ErrorImage And (pictureHandler.nextFile IsNot "" Or pictureHandler.nextFile IsNot Nothing) Then
            ManagePictureChange(True)
        End If
    End Sub

    Private Sub SetButtonsInStatusBarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetButtonsInStatusBarToolStripMenuItem.Click
        Dim dialogResult As DialogResult = Options.ShowDialog()
        If dialogResult = DialogResult.OK Then
            Debug.Write("Dialog Result OK")
            SetStripButtons()
        End If
    End Sub

    Private Sub SetStripButtons()
        If tiMain.Enabled Then
            If PlayDirection Then directionsBuSetup(directionSetupState.forward) Else directionsBuSetup(directionSetupState.backward)
        ElseIf pictureHandler.currentFile <> "" And pictureHandler.currentFile <> Nothing Then
            directionsBuSetup(directionSetupState.pause)
        Else
            directionsBuSetup(directionSetupState.noFiles)
        End If
        tssbuInterval.Visible = cbHolder.cbInterval
        tssddbOpenFolder.Visible = cbHolder.cbOpen
        tssbuExit.Visible = cbHolder.cbExit
        tssbuCrop.Visible = cbHolder.cbCrop
    End Sub

    Private Sub OpenFolderToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenFolderToolStripMenuItem1.Click
        fbDialogOpen()
    End Sub

    Private Sub frHlavni_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width < 235 Or Me.Height < 170 Then
            pbPrevious.Visible = False : pbNext.Visible = False
        Else
            pbPrevious.Visible = True : pbNext.Visible = True
            pbNext.Left = Me.Width - 125 : pbNext.Top = Me.Height - 173
            pbPrevious.Top = pbNext.Top
        End If
        resizePB(pbMain.Image)
        'Debug.WriteLine("original W= " + pbMain.Image.Width.ToString + " original H= " + pbMain.Image.Height.ToString)
    End Sub

    Public Sub ManagePictureChange(ByVal direction As Boolean) 'true=forward, false = backward
        Dim tempPath As String
        If direction Then
            tempPath = pictureHandler.fetchNextFile()
        ElseIf direction = False Then
            tempPath = pictureHandler.fetchPreviousFile()
        End If
        If tempPath IsNot "" And (pictureHandler.previousFile <> "" Or pictureHandler.nextFile <> "") Then
            Try
                'Debug.WriteLine("CurrentFile: " + pictureHandler.currentFile + vbCrLf +
                '                "PreviousFile: " + pictureHandler.previousFile + vbCrLf +
                '                "NextFile: " + pictureHandler.nextFile)
                pbMain.Image = Image.FromFile(tempPath)
                resizePB(pbMain.Image)
                pbNext.Image = Image.FromFile(pictureHandler.nextFile)
                pbPrevious.Image = Image.FromFile(pictureHandler.previousFile)
            Catch ex As Exception
                'pbMain.SizeMode = PictureBoxSizeMode.CenterImage
                tsslbOF.Text = "No image files in selected directory."
                pbMain.Image = pbMain.ErrorImage
                resizePB(pbMain.Image)
                pbPrevious.Image = pbPrevious.ErrorImage
                pbNext.Image = pbNext.ErrorImage
                tiMain.Enabled = False
                directionsBuSetup(directionSetupState.noFiles)
                Debug.WriteLine("ManagePictureChange ERR :" + ex.Message + " " + pictureHandler.previousFile)
            End Try

            If (pbMain.Image.Size.Height > pbMain.Size.Height) Or (pbMain.Image.Size.Width > pbMain.Size.Width) Then
                pbMain.SizeMode = PictureBoxSizeMode.Zoom
            Else
                'pbMain.SizeMode = PictureBoxSizeMode.CenterImage
            End If
            tsslbOF.Text = UpdateSS(pictureHandler)
        Else
            'pbMain.SizeMode = PictureBoxSizeMode.CenterImage
            tsslbOF.Text = "No image files in selected directory."
            pbMain.Image = pbMain.ErrorImage
            resizePB(pbMain.Image)
            pbPrevious.Image = pbPrevious.ErrorImage
            pbNext.Image = pbNext.ErrorImage
            tiMain.Enabled = False
            directionsBuSetup(directionSetupState.noFiles)
        End If
    End Sub

    Private Sub pbPrevious_Click(sender As Object, e As EventArgs) Handles pbPrevious.Click
        If cropped Then
            ResetPBs()
        ElseIf tiMain.Enabled = False And (pictureHandler.previousFile IsNot "" Or pictureHandler.previousFile IsNot Nothing) Then
            ManagePictureChange(False)
        End If
    End Sub

    'set PictureBoxes after cropped image was shown
    Private Sub ResetPBs()
        Try
            pbMain.Image = Image.FromFile(pictureHandler.currentFile)
            pbPrevious.Image = Image.FromFile(pictureHandler.previousFile)
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            pbMain.Image = il256.Images(0)
        End Try

        cropped = False
        resizePB(pbMain.Image)
    End Sub

    Private Sub pbMain_Paint(sender As Object, e As PaintEventArgs) Handles pbMain.Paint
        If pbMain.Image IsNot Nothing And selectionActive = True Then
            If Rect <> Nothing And Rect.Width > 0 And Rect.Height > 0 Then
                'Debug.WriteLine("Fill rectangle")
                e.Graphics.FillRectangle(selectionBrush, Rect)
            End If
        End If
    End Sub

    Private Sub pbMain_MouseUp(sender As Object, e As MouseEventArgs) Handles pbMain.MouseUp
        Debug.WriteLine(selectionActive.ToString) 'TEST!
        If e.Button = MouseButtons.Right Then 'base for case I would like to use right click function in a future
            If Rect.Contains(e.Location) Then
                Debug.WriteLine("Right click")

            End If
        End If
        If selectionActive = True Then
            selectionActive = False

            pbPrevious.Image = pbMain.Image
            cropped = True
            tssbuSaveFile.Visible = True
            'testRect
            If Rect.Width + Rect.X > pbMain.Width Then Rect.Width = pbMain.Width - Rect.X

            If Rect.Height + Rect.Y > pbMain.Height Then Rect.Height = pbMain.Height - Rect.Y
            tempImage = cropCurrentImage(pbMain.Image, Rect, New Rectangle(0, 0, Rect.Width, Rect.Height))
            changeCurrentImage(tempImage)
        End If
        Invalidate()
        Debug.WriteLine("selectionActive = " + selectionActive.ToString)
    End Sub

    Private Sub pbMain_MouseMove(sender As Object, e As MouseEventArgs) Handles pbMain.MouseMove
        If e.Button <> MouseButtons.Left Then
            selectionActive = False
            Return

        ElseIf e.Button = MouseButtons.Left Then

            selectionActive = True
            Dim tempEndPoint As Point = e.Location
            If tempEndPoint.X < 0 Then tempEndPoint.X = 0
            If tempEndPoint.Y < 0 Then tempEndPoint.Y = 0

            Rect.Location = New Point(
         Math.Min(RectStartPoint.X, tempEndPoint.X),
         Math.Min(RectStartPoint.Y, tempEndPoint.Y))
            Rect.Size = New Size(
                Math.Abs(RectStartPoint.X - tempEndPoint.X),
                Math.Abs(RectStartPoint.Y - tempEndPoint.Y))

            Debug.WriteLine("MB pressed StartX = " + RectStartPoint.X.ToString + " StartY= " + RectStartPoint.Y.ToString + " EndX=" + tempEndPoint.X.ToString + " EndY=" + tempEndPoint.Y.ToString)
            Debug.WriteLine("RectW = " + Rect.Width.ToString + " RectH = " + Rect.Height.ToString)
            pbMain.Invalidate()
        End If
        Debug.WriteLine("selectionActive= " + selectionActive.ToString)
        Me.Text = ("pbMain.mousepos: X=" + e.X.ToString + " Y=" + e.Y.ToString)
    End Sub

    Private Sub pbMain_MouseDown(sender As Object, e As MouseEventArgs) Handles pbMain.MouseDown
        RectStartPoint = e.Location
        'Invalidate()
        'If e.Button = MouseButtons.Right Then selectionActive = False
    End Sub

    Public Function cropCurrentImage(ByVal srcBitmap As Image, ByVal srcRegion As Rectangle, ByVal destRegion As Rectangle) As Image
        Dim srcXp As Double = (srcRegion.Location.X / pbMain.Width)
        Dim srcYp As Double = (srcRegion.Y / pbMain.Height)
        Dim srcWidthp As Double = (srcRegion.Width / pbMain.Width)
        Dim srcHeightp As Double = (srcRegion.Height / pbMain.Height)
        Dim destX As Double = (srcBitmap.Width) * srcXp
        Dim destY As Double = (srcBitmap.Height) * srcYp
        Dim destWidth As Double = (srcBitmap.Width) * srcWidthp
        Dim destHeight As Double = (srcBitmap.Height) * srcHeightp
        Dim relativeSrcRect As Rectangle = New Rectangle(destX, destY, destWidth, destHeight)

        Dim enlargedDestRegion As Rectangle = New Rectangle(destRegion.X, destRegion.Y, destRegion.Width * enlargeRatio, destRegion.Height * enlargeRatio)

        Dim rImg As Image
        Try
            rImg = New Bitmap(destRegion.Width * enlargeRatio, destRegion.Height * enlargeRatio)
            Dim gr As Graphics  'Default(Graphics)
            gr = Graphics.FromImage(rImg)
            gr.DrawImage(srcBitmap, enlargedDestRegion, relativeSrcRect, GraphicsUnit.Pixel)
        Catch ex As Exception
            Debug.WriteLine("CropCurrentImage ERR : " + ex.Message)
        End Try

        Return rImg
    End Function

    'change pbMain image after image was cropped
    Public Sub changeCurrentImage(ByVal image As Image)
        pbMain.SizeMode = PictureBoxSizeMode.Zoom
        pbMain.Image = tempImage
        resizePB(pbMain.Image)
    End Sub

    'set stuff on pause
    Public Sub PauseClick()
        If tiMain.Enabled = True Then
            tiMain.Enabled = False
            directionsBuSetup(directionSetupState.pause)
        Else
            tiMain.Enabled = True
            If PlayDirection Then directionsBuSetup(directionSetupState.forward) Else directionsBuSetup(directionSetupState.backward)
        End If

    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        PauseClick()
    End Sub

    'enumeration to determinate shiledshow state to set slideshow button controls
    Enum directionSetupState
        pause = 0
        forward = 1
        backward = 2
        noFiles = 3
    End Enum

    'seting slideshow controls
    Private Sub directionsBuSetup(ByVal state As directionSetupState)
        Select Case state
            Case 0
                tssbuBackward.Visible = False
                tssbuBackwards.Visible = False
                tssbuForward.Visible = False
                tssbuForwards.Visible = False
                If cbHolder.cbSlideshowCtrls Then tssbuPause.Visible = True Else tssbuPause.Visible = False
                tssbuPause.Enabled = True
                tssbuPause.Image = ilMain.Images(3)
                PauseToolStripMenuItem.Image = ilMain.Images(3)
                PauseToolStripMenuItem.Text = "Play"
            Case 1
                tssbuForward.Visible = False
                tssbuForwards.Visible = False
                If cbHolder.cbSlideshowCtrls = True Then
                    tssbuBackwards.Visible = True
                Else
                    tssbuBackwards.Visible = False
                End If
                tssbuBackward.Visible = True
                If cbHolder.cbSlideshowCtrls Then tssbuPause.Visible = True Else tssbuPause.Visible = False
                tssbuPause.Enabled = True
                tssbuPause.Image = ilMain.Images(8)
                PauseToolStripMenuItem.Enabled = True
                PauseToolStripMenuItem.Image = ilMain.Images(8)
                PauseToolStripMenuItem.Text = "Pause"
            Case 2
                tssbuBackward.Visible = False
                tssbuBackwards.Visible = False
                If cbHolder.cbSlideshowCtrls = True Then
                    tssbuForwards.Visible = True
                Else
                    tssbuForwards.Visible = False
                End If
                tssbuForward.Visible = True
                If cbHolder.cbSlideshowCtrls Then tssbuPause.Visible = True Else tssbuPause.Visible = False
                tssbuPause.Enabled = True
                tssbuPause.Image = ilMain.Images(8)
                PauseToolStripMenuItem.Enabled = True
                PauseToolStripMenuItem.Image = ilMain.Images(8)
                PauseToolStripMenuItem.Text = "Pause"
            Case 3
                tssbuBackward.Visible = False
                tssbuBackwards.Visible = False
                tssbuForward.Visible = False
                tssbuForwards.Visible = False
                tssbuPause.Enabled = False
                tssbuPause.Image = ilMain.Images(3)
                PauseToolStripMenuItem.Image = ilMain.Images(3)
                PauseToolStripMenuItem.Text = "Play"
                PauseToolStripMenuItem.Enabled = False
        End Select
    End Sub

    Private Sub SlideshowInBackwardsDirectionToolStripMenuItem_Click(sender As Object, e As EventArgs)
        directionChange(False)
    End Sub

    'set stuff when direciton of slideshow changes
    Private Sub directionChange(ByVal dir As Boolean)
        If dir = True Then
            PlayDirection = True
            directionsBuSetup(directionSetupState.forward)
        Else
            PlayDirection = False
            directionsBuSetup(directionSetupState.backward)
        End If
    End Sub

    Private Sub tssbuInterval_ButtonClick(sender As Object, e As EventArgs) Handles tssbuInterval.ButtonClick
        changeInterval()
    End Sub

    'handles changing slideshow speed
    Private Sub changeInterval()
        Dim newInterval As Integer = 1000
        Try
            newInterval = Integer.Parse(InputBox("Enter new interval (in seconds):"))
            tiMain.Interval = newInterval * 1000
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tssbuBackwards_ButtonClick(sender As Object, e As EventArgs) Handles tssbuBackwards.ButtonClick
        directionChange(False)
    End Sub

    Private Sub tssbuForwards_ButtonClick(sender As Object, e As EventArgs) Handles tssbuForwards.ButtonClick
        directionChange(True)
    End Sub

    Private Sub tssbuForward_Click(sender As Object, e As EventArgs) Handles tssbuForward.Click
        directionChange(True)
    End Sub

    Private Sub tssbuBackward_Click(sender As Object, e As EventArgs) Handles tssbuBackward.Click
        directionChange(False)
    End Sub

    'handles resizing image accoriding to image
    Private Sub resizePB(ByVal img As Image)

        Dim offset As Integer = 40
        Dim imgWidth As Double = img.Width
        Dim imgHeight As Double = img.Height
        Dim formWidth As Double = Me.Width
        Dim formHeight As Double = Me.Height
        Dim tempImgH
        If imgWidth > formWidth Then
            'Debug.WriteLine("Před: Wtest test: imgW= " + imgWidth.ToString + " imgH= " + imgHeight.ToString)
            imgWidth = formWidth
            imgHeight = imgHeight * (imgWidth / img.Width)
            'Debug.WriteLine("Po: Wtest test: imgW= " + imgWidth.ToString + " imgH= " + imgHeight.ToString)
        End If
        tempImgH = imgHeight
        If imgHeight > formHeight - 2 * offset Then
            'Debug.WriteLine("Před: Htest test: imgW= " + imgWidth.ToString + " imgH= " + imgHeight.ToString)
            imgHeight = formHeight - 2 * offset
            imgWidth = imgWidth * (imgHeight / tempImgH)
            'Debug.WriteLine("Po: Htest test: imgW= " + imgWidth.ToString + " imgH= " + imgHeight.ToString)
        End If
        If imgWidth <= formWidth And imgHeight <= formHeight - offset Then 'img fits into main form canvas
            'Debug.WriteLine("img fits into main form canvas")
            pbMain.Width = imgWidth
            pbMain.Height = imgHeight
            pbMain.Left = ((formWidth) / 2 - pbMain.Width / 2)
            pbMain.Top = ((formHeight - offset - offset / 2) / 2 - pbMain.Height / 2)
            If pbMain.Top + pbMain.Height > formHeight - offset Then pbMain.Top = 0
            pbMain.Image = img
        Else
            'Debug.WriteLine("Didnt work")
        End If
        'pbMain.Image = img
    End Sub

    Private Sub tssbuCropEnlarge_Click(sender As Object, e As EventArgs) Handles tssbuCropEnlarge.Click
        ChangeCropEnlarge()
    End Sub

    'manages change of enlarge ration after cropping image
    Public Sub ChangeCropEnlarge()
        Dim ratio As Integer = enlargeRatio
        Try
            ratio = Integer.Parse(InputBox("How many times you want to enlarge cropped image? (only whole numbers)"))
            tsslbOF.Text = "Enlarge ration for croped image changed to multiplier x" + ratio.ToString + "."
        Catch ex As Exception
            MsgBox("Enter only whole numbers, please.")
        End Try
        enlargeRatio = ratio
    End Sub

    Private Sub tssbuSaveFile_ButtonClick(sender As Object, e As EventArgs) Handles tssbuSaveFile.ButtonClick
        sfDialogExe()
    End Sub

    'manages saving file
    Private Sub sfDialogExe()
        Dim dialogResult As DialogResult = sfDialog.ShowDialog()
        If dialogResult = DialogResult.OK Then
            If sfDialog.FileName <> "" Then
                ' Saves the Image in the appropriate ImageFormat based upon the
                ' file type selected in the dialog box.                
                Try
                    Select Case sfDialog.FilterIndex
                        Case 1
                            pbMain.Image.Save(sfDialog.FileName, System.Drawing.Imaging.ImageFormat.Png)
                        Case 2
                            pbMain.Image.Save(sfDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                        Case 3
                            pbMain.Image.Save(sfDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
                        Case 4
                            pbMain.Image.Save(sfDialog.FileName, System.Drawing.Imaging.ImageFormat.Gif)
                    End Select
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
        'TODO finish and debug saving
    End Sub

    Private Sub tssbuSaveAs_Click(sender As Object, e As EventArgs) Handles tssbuSaveAs.Click
        sfDialogExe()
    End Sub

    Private Sub tssbuCrop_Click(sender As Object, e As EventArgs) Handles tssbuCrop.Click
        ChangeCropEnlarge()
    End Sub
End Class