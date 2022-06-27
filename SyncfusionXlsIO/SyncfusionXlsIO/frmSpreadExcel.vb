#Region "About"
' / --------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: https://www.facebook.com/g2gnet (For Thailand)
' / Facebook: https://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gsoft.com/webboard
' /
' / Purpose: Test SpreadSheet of Syncfusion Community. (XlsIO .Net)
' / Microsoft Visual Basic .NET (2010)
' /
' / This is open source code under @CopyLeft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / --------------------------------------------------------------------------------
#End Region

Imports Syncfusion.Windows.Forms.Spreadsheet
Imports Syncfusion.XlsIO
Imports Syncfusion.Pdf
Imports Syncfusion.ExcelToPdfConverter

Public Class frmSpreadExcel
    '// Data Path 
    Dim strPathData As String = MyPath(Application.StartupPath) & "Excel\"
    '// Filename
    Dim strFileName As String = String.Empty
    Dim XlsFileName As String()

    ' / --------------------------------------------------------------------------------
    ' / Get my project path
    ' / AppPath = C:\My Project\bin\debug
    ' / Replace "\bin\debug" with "\"
    ' / Return : C:\My Project\
    Function MyPath(ByVal AppPath As String) As String
        '/ Return Value
        MyPath = AppPath.ToLower.Replace("\bin\debug", "\").Replace("\bin\release", "\").Replace("\bin\x86\debug", "\")
        '// If not found folder then put the \ (BackSlash) at the end.
        If Microsoft.VisualBasic.Right(MyPath, 1) <> Chr(92) Then MyPath = MyPath & Chr(92)
    End Function

    ' / --------------------------------------------------------------------------------
    Private Sub btnLoadXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadXLS.Click
        Me.TabControlAdv1.SelectedIndex = 0
        ' ประกาศใช้งาน Open File Dialog ในแบบ Run Time   
        Dim dlgOpenFile As OpenFileDialog = New OpenFileDialog()
        Try
            ' / ตั้งค่าการใช้งาน Open File Dialog
            With dlgOpenFile
                .InitialDirectory = strPathData
                .Title = "เลือกไฟล์ MS Excel"
                .Filter = "MS Excel Files (*.xlsx;*.xls)|*.xlsx;*xls"
                .FilterIndex = 1
                .RestoreDirectory = True
            End With
            '/ If the OK button is selected.
            If dlgOpenFile.ShowDialog() = DialogResult.OK Then
                '// For save
                strFileName = dlgOpenFile.FileName
                Spreadsheet1.Open(strFileName)
                '// Xlsfilename(0) = "D:\SyncfusionFile\SyncfusionFile\GettingStarted"
                '// Xlsfilename(1) = "xlsx"
                XlsFileName = Split(strFileName, ".")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' / --------------------------------------------------------------------------------
    Private Sub btnSaveXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveXLS.Click
        '// Save the workbook to disk in xlsx format.
        If strFileName.Length = 0 Then
            MessageBox.Show("You did not load the Excel file.", "Report status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        Spreadsheet1.Save()
        MessageBox.Show("Save Excel file successfully.", "Report status", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Convert Excel To PDF.
    ' / --------------------------------------------------------------------------------
    Private Sub btnSavePDF_Click(sender As System.Object, e As System.EventArgs) Handles btnSavePDF.Click
        If strFileName.Length = 0 Then
            MessageBox.Show("You did not load the Excel file.", "Report status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        Spreadsheet1.Save()
        '//
        Me.TabControlAdv1.SelectedIndex = 1
        '//
        Try
            Using ExcelEngine As ExcelEngine = New ExcelEngine()
                Dim Application As IApplication = ExcelEngine.Excel
                Application.DefaultVersion = ExcelVersion.Excel2013
                '/ Load Excel to Workbook.
                Dim workbook As IWorkbook = Application.Workbooks.Open(strFileName, ExcelOpenType.Automatic)
                '/ Open the Excel document to convert
                Dim converter As ExcelToPdfConverter = New ExcelToPdfConverter(workbook)
                '/ Initialize the PDF document
                Dim pdfDocument As PdfDocument = New PdfDocument()

                '// Sample Setting Page.
                Dim Settings As ExcelToPdfConverterSettings = New ExcelToPdfConverterSettings()
                Settings.LayoutOptions = LayoutOptions.Automatic
                '// Set the Layout Options for the output Pdf page.
                If (noScaleRadioBtn.Checked) Then
                    Settings.LayoutOptions = LayoutOptions.NoScaling
                ElseIf (allRowsRadioBtn.Checked) Then
                    Settings.LayoutOptions = LayoutOptions.FitAllRowsOnOnePage
                ElseIf (allColumnRadioBtn.Checked) Then
                    Settings.LayoutOptions = LayoutOptions.FitAllColumnsOnOnePage
                Else
                    Settings.LayoutOptions = LayoutOptions.FitSheetOnOnePage
                End If
                '// Assign the PDFDocument to the TemplateDocument property of ExcelToPdfConverterSettings
                Settings.TemplateDocument = pdfDocument
                Settings.DisplayGridLines = GridLinesDisplayStyle.Auto
                Settings.EnableFormFields = True
                '// Convert Excel Document into PDF document
                pdfDocument = converter.Convert(Settings)
                '// Save the PDF file.
                '// "FOLDER\MonthlySalesSample" & "pdf"
                pdfDocument.Save(XlsFileName(0) & ".pdf")

            End Using
            '/ Show PDF.
            Me.PdfViewerControl1.Load(XlsFileName(0) + ".pdf", "")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmSpreadExcel_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        GC.SuppressFinalize(Me)
        Application.Exit()
    End Sub

    Private Sub frmSpreadExcel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class