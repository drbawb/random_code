Imports Microsoft.Office.Interop

Public Class Form1
    Dim app As Excel.Application
    Dim book As Excel._Workbook
    Dim count As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        'declare local variables
        Dim books As Excel.Workbooks
        Dim sheets As Excel.Sheets
        Dim sheet As Excel._Worksheet
        Dim range As Excel.Range

        'start up excel, and create workspace
        app = New Excel.Application
        books = app.Workbooks
        book = books.Add
        sheets = book.Worksheets
        sheet = sheets(1)

        'work with the sheet  -- example 1
        range = sheet.Range("A1:A3", Reflection.Missing.Value)
        range.Interior.Color = RGB(40, 115, 40)
        range.ColumnWidth = 20
        sheet.Range("A1").Value = txtInstructorName.Text
        sheet.Range("A2").Value = txtCRN.Text



        'close excel when done

        'app.Quit()
        'Runtime.InteropServices.Marshal.ReleaseComObject(app)
        'Runtime.InteropServices.Marshal.ReleaseComObject(books)
        'app = Nothing
        CloseExcel(app, books)
    End Sub

    Sub CloseExcel(ByRef application As Excel.Application, ByRef workbooks As Excel.Workbooks)
        count += 1
        txtCRN.Text = CStr(count)
        application.Quit()
        Runtime.InteropServices.Marshal.ReleaseComObject(workbooks)
        Runtime.InteropServices.Marshal.ReleaseComObject(application)
        application = Nothing
    End Sub
End Class
