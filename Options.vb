Public Class Options
    Private tempSetting As formPropHolder = New formPropHolder()
    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frHlavni.cbHolder.CopyTo(tempSetting)
        chbOpenFolder.Image = frHlavni.ilMain.Images.Item(1)
        chbOpenFolder.Checked = tempSetting.cbOpen
        chbPlayControls.Image = frHlavni.ilMain.Images.Item(3)
        chbPlayControls.Checked = tempSetting.cbSlideshowCtrls
        chbInterval.Image = frHlavni.ilMain.Images.Item(9)
        chbInterval.Checked = tempSetting.cbInterval
        chbCrop.Image = frHlavni.ilMain.Images.Item(11)
        chbCrop.Checked = tempSetting.cbCrop
        chbExit.Image = frHlavni.ilMain.Images.Item(0)
        chbExit.Checked = tempSetting.cbExit
    End Sub

    Private Sub buCancel_Click(sender As Object, e As EventArgs) Handles buCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub buOK_Click(sender As Object, e As EventArgs) Handles buOK.Click
        DialogResult = Windows.Forms.DialogResult.OK
        tempSetting.CopyTo(frHlavni.cbHolder)
        Me.Close()
    End Sub

    Private Sub chbOpenFolder_CheckedChanged(sender As Object, e As EventArgs) Handles chbOpenFolder.CheckedChanged
        tempSetting.cbOpen = chbOpenFolder.Checked
    End Sub

    Private Sub chbPlayControls_CheckedChanged(sender As Object, e As EventArgs) Handles chbPlayControls.CheckedChanged
        tempSetting.cbSlideshowCtrls = chbPlayControls.Checked
    End Sub

    Private Sub chbInterval_CheckedChanged(sender As Object, e As EventArgs) Handles chbInterval.CheckedChanged
        tempSetting.cbInterval = chbInterval.Checked
    End Sub

    Private Sub chbCrop_CheckedChanged(sender As Object, e As EventArgs) Handles chbCrop.CheckedChanged
        tempSetting.cbCrop = chbCrop.Checked
    End Sub

    Private Sub chbExit_CheckedChanged(sender As Object, e As EventArgs) Handles chbExit.CheckedChanged
        tempSetting.cbExit = chbExit.Checked
    End Sub
End Class