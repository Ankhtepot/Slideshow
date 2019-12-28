Imports System.Runtime.CompilerServices
'class to manage feeding files one by one while allowing forward and backward feed, also includes
'previous and next file (if any)
Public Class FileHandler
    Public directoryPath As String 'stores directory path from where files are loaded
    Public currentFile As String 'stores last file fetched into app
    Public previousFile As String 'stores previous file in list
    Public nextFile As String 'stores next file in list

    Private fileList As String() 'array of files for managing
    Private nrOfFiles As Integer
    Private showingIndex As Integer 'service variable for testing purpuses

    Sub New()
        Me.New("C:\", {""})
    End Sub

    Sub New(ByVal dp As String, ByVal fl As String())
        Me.directoryPath = dp : Me.fileList = fl : Me.showingIndex = 0 : Me.currentFile = ""
        Me.previousFile = "" : Me.nextFile = "" : Me.nrOfFiles = 1
    End Sub

    'fetches next file in a list aslo stored in me.nextFile
    Public Function fetchNextFile() As String
        Me.previousFile = Me.currentFile

        If Me.fileList.Length = 1 Then '1 file in a list
            Me.showingIndex = 0
            Me.currentFile = Me.fileList(0)
            Me.nextFile = Me.fileList(0)
            Me.previousFile = Me.fileList(0)
        End If

        If Me.fileList.Length = 2 Then '2 files in list
            If Me.showingIndex = 0 Then
                Me.showingIndex = 1
                Me.currentFile = Me.fileList(1)
                Me.nextFile = Me.fileList(0)
            Else
                Me.showingIndex = 0
                Me.currentFile = Me.fileList(0)
                Me.nextFile = Me.fileList(1)
            End If
        End If

        If Me.fileList.Length > 2 Then
            If showingIndex = Me.fileList.GetUpperBound(0) Then 'last file in list
                showingIndex = 0
                Me.currentFile = Me.fileList(0)
                Me.nextFile = Me.fileList(1)
            ElseIf showingIndex = Me.fileList.GetUpperBound(0) - 1 Then 'before last file
                showingIndex += 1
                Me.currentFile = Me.fileList(showingIndex)
                Me.nextFile = Me.fileList(0)
            Else
                showingIndex += 1
                Me.currentFile = Me.fileList(showingIndex)
                Me.nextFile = Me.fileList(showingIndex + 1)
            End If
        End If

        Return Me.currentFile
    End Function

    'fetches previous file in a list aslo stored in me.previousFile
    Public Function fetchPreviousFile() As String
        Me.nextFile = Me.currentFile

        If Me.fileList.Length = 1 Then '1 file in a list
            Me.showingIndex = 0
            Me.currentFile = Me.fileList(0)
            Me.previousFile = Me.fileList(0)
        End If

        If Me.fileList.Length = 2 Then '2 files in list
            If Me.showingIndex = 0 Then
                Me.showingIndex = 1
                Me.currentFile = Me.fileList(1)
                Me.previousFile = Me.fileList(0)
            Else
                Me.showingIndex = 0
                Me.currentFile = Me.fileList(0)
                Me.previousFile = Me.fileList(1)
            End If
        End If

        If Me.fileList.Length > 2 Then
            If showingIndex = 0 Then 'first file in list
                showingIndex = Me.fileList.GetUpperBound(0)
                Me.currentFile = Me.fileList(showingIndex)
                Me.previousFile = Me.fileList(showingIndex - 1)
            ElseIf showingIndex = 1 Then 'second file in list
                showingIndex = 0
                Me.currentFile = Me.fileList(showingIndex)
                Me.previousFile = Me.fileList(Me.fileList.GetUpperBound(0))
            Else
                showingIndex -= 1
                Me.currentFile = Me.fileList(showingIndex)
                Me.previousFile = Me.fileList(showingIndex - 1)
            End If
        End If

        Return Me.currentFile
    End Function

    'public function to feed class with list to wirk with
    Public Sub feederIni(ByVal fList As String())
        If fList IsNot Nothing Then
            Try
                Me.nrOfFiles = fList.Length
                If nrOfFiles = 0 Then MsgBox("Feeding failed, empty list.")
                If fList.Length = 1 And (fList(0) <> "" Or fList(0) <> Nothing) Then
                    Me.currentFile = fList(0)
                    Me.showingIndex = 0
                    Me.fileList = fList
                End If
                If nrOfFiles > 1 And (fList(0) <> "" Or fList(0) <> Nothing) Then
                    Me.currentFile = fList(0)
                    Me.showingIndex = 0
                    Me.fileList = fList
                Else
                    Me.currentFile = ""
                End If
                If fList.Length > 1 Then
                    If nrOfFiles > 1 And fList(1) <> "" Then
                        Me.nextFile = fList(1)
                    Else
                        Me.nextFile = ""
                    End If
                End If
                Me.previousFile = ""
            Catch ex As Exception
                Debug.WriteLine("FeederIni ERR: " + ex.Message)
            End Try
        Else
            Me.currentFile = "" : Me.previousFile = "" : Me.nextFile = ""
        End If

    End Sub

    Public Function getCurrentFile() As String
        Return Me.currentFile
    End Function

    Public Sub setCurrentFile(ByVal f As String)
        Me.currentFile = f
    End Sub

End Class
