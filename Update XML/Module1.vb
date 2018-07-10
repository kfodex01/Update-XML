Module Module1
    Public Function CreateXml(wkBookPath As String, xmlDirectoryPath As String) As Boolean
        Dim oExcel As New Microsoft.Office.Interop.Excel.Application
        Dim wkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim today As Date = Date.Today
        Dim xmlStartString As String = today.ToString("yyyy-MM-dd") & "_XML_UPLOAD_"
        wkBook = oExcel.Workbooks.Open(wkBookPath)
        wkSheet = wkBook.Worksheets(1)

        Dim platform As New PLATFORM_Type

        Dim thisUpdate As Upload_Type
        Dim updateList As New List(Of Upload_Type)
        Dim mainCategoryColumn As Long = -1
        Dim subCategoryColumn As Long = -1
        Dim column As Long = 1
        Dim row As Long = 2
        Dim thisHeading As String = wkSheet.Cells(1, column).value
        Dim thisRow As String

        While Not (thisHeading = "")
            If thisHeading = "Main Category" Or thisHeading = "Main_Category" Then
                mainCategoryColumn = column
            End If
            If thisHeading = "Sub-Category" Then
                subCategoryColumn = column
            End If
            column += 1
            thisHeading = wkSheet.Cells(1, column).value
        End While

        If mainCategoryColumn = -1 Then
            MsgBox("Main Category column not found.", MsgBoxStyle.OkCancel)
            wkBook.Close()
            oExcel.Quit()
            Return False
            Exit Function
        End If
        If subCategoryColumn = -1 Then
            If MsgBox("Sub-Category column not found. Do all these data points belong to the main category only?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                wkBook.Close()
                oExcel.Quit()
                Return False
                Exit Function
            End If
        End If

        column = 1
        thisHeading = wkSheet.Cells(1, column).value
        While Not (thisHeading = "")
            If mainCategoryColumn = column Or subCategoryColumn = column Then
                column += 1
                thisHeading = wkSheet.Cells(1, column).value
                Continue While
            End If
            row = 2
            thisRow = wkSheet.Cells(row, 1).value
            While Not (thisRow = "")
                Dim thisCell As String = wkSheet.Cells(row, column).value
                If thisCell <> "" Then
                    thisUpdate = New Upload_Type With {
                    .MainCategory = wkSheet.Cells(row, mainCategoryColumn).value,
                    .DataPoint = wkSheet.Cells(1, column).value,
                    .NewValue = wkSheet.Cells(row, column).value
                }
                    If subCategoryColumn <> -1 Then
                        thisUpdate.SubCategory = wkSheet.Cells(row, subCategoryColumn).value
                    End If
                    updateList.Add(thisUpdate)
                End If
                row += 1
                thisRow = wkSheet.Cells(row, 1).value
            End While
            Dim uploads() As Upload_Type = updateList.ToArray()
            platform.Uploads = uploads
            Dim serializer As New System.Xml.Serialization.XmlSerializer(GetType(PLATFORM_Type))
            Dim writer As New System.IO.StreamWriter(xmlDirectoryPath & "\" & xmlStartString & thisHeading & ".xml")
            serializer.Serialize(writer, platform)
            writer.Close()
            updateList.Clear()
            platform = New PLATFORM_Type
            column += 1
            thisHeading = wkSheet.Cells(1, column).value
        End While
        wkBook.Close()
        oExcel.Quit()
        Return True
    End Function
End Module

