Imports System.Runtime.CompilerServices

Module StringExtensions

    <Extension()>
    Public Function TrimPath(ByRef path As String, ByVal places As Integer,
                             Optional ByVal trimExtension As Boolean = True, Optional ByVal info As String = "*>") As String
        Dim resultPath As String = "" 'záložní result, aby se vrátilo vždy aspoň něco
        If path.Contains("\") Then 'pokud je ve stringu "\"...
            Dim lastSlashIndex As Integer = path.LastIndexOf("\") '...tak najdi poslední výskyt...
            resultPath = path.Substring(lastSlashIndex + 1) '...a všechno před ním odstřihni...
            '...a pokud je volitelně žádáno neponechat i příponu souboru, tak ji ustřihni taky.
            If trimExtension Then resultPath = resultPath.Substring(0, resultPath.Length -
                                                                    (resultPath.Length - resultPath.LastIndexOf(".")))
            If resultPath.Length > places Then 'a pokud je string i tak delší než 'places',
                'tak výsledek ještě víc uprav a na začátek přidej info o zkrácení názvu, pokud chceš (volitelně 'info').
                resultPath = resultPath.Substring(resultPath.Length - places)
                resultPath = info + resultPath
            End If
        End If
        'MsgBox(resultPath) ...pro testování
        Return resultPath '...a vrácení výsledku
    End Function
End Module
