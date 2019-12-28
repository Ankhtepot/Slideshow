Public Class formPropHolder
    Public cbExit As Boolean
    Public cbOpen As Boolean
    Public cbInterval As Boolean
    Public cbSlideshowCtrls As Boolean
    Public cbCrop As Boolean

    Sub New()
        With Me : cbExit = True : cbInterval = False
            cbOpen = True : cbSlideshowCtrls = True : cbCrop = False
        End With
    End Sub

    Sub CopyTo(ByVal destFPH As formPropHolder)
        destFPH.cbCrop = Me.cbCrop
        destFPH.cbExit = Me.cbExit
        destFPH.cbInterval = Me.cbInterval
        destFPH.cbOpen = Me.cbOpen
        destFPH.cbSlideshowCtrls = Me.cbSlideshowCtrls
    End Sub
End Class
