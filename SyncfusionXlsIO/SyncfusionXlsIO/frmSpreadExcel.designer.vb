<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpreadExcel
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
        Me.components = New System.ComponentModel.Container()
        Dim MessageBoxSettings3 As Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings = New Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings()
        Dim PdfViewerPrinterSettings3 As Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings = New Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSpreadExcel))
        Dim TextSearchSettings3 As Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings = New Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings()
        Dim SpreadsheetCopyPaste1 As Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste = New Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste()
        Dim FormulaRangeSelectionController1 As Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController = New Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController()
        Me.btnLoadXLS = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.btnExit = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.btnSaveXLS = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.btnSavePDF = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.TabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.PdfViewerControl1 = New Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl()
        Me.TabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Spreadsheet1 = New Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet()
        Me.TabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.onePageRadioBtn = New System.Windows.Forms.RadioButton()
        Me.allColumnRadioBtn = New System.Windows.Forms.RadioButton()
        Me.allRowsRadioBtn = New System.Windows.Forms.RadioButton()
        Me.noScaleRadioBtn = New System.Windows.Forms.RadioButton()
        Me.TabPageAdv2.SuspendLayout()
        Me.TabPageAdv1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlAdv1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLoadXLS
        '
        Me.btnLoadXLS.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnLoadXLS.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnLoadXLS.BeforeTouchSize = New System.Drawing.Size(100, 41)
        Me.btnLoadXLS.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
        Me.btnLoadXLS.ComboEditBackColor = System.Drawing.Color.Silver
        Me.btnLoadXLS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadXLS.ForeColor = System.Drawing.Color.White
        Me.btnLoadXLS.KeepFocusRectangle = False
        Me.btnLoadXLS.Location = New System.Drawing.Point(4, 26)
        Me.btnLoadXLS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLoadXLS.Name = "btnLoadXLS"
        Me.btnLoadXLS.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
        Me.btnLoadXLS.Size = New System.Drawing.Size(100, 41)
        Me.btnLoadXLS.TabIndex = 1
        Me.btnLoadXLS.Text = "Load Excel"
        Me.btnLoadXLS.ThemeName = "Metro"
        Me.btnLoadXLS.UseVisualStyle = True
        '
        'btnExit
        '
        Me.btnExit.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnExit.BeforeTouchSize = New System.Drawing.Size(100, 41)
        Me.btnExit.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
        Me.btnExit.ComboEditBackColor = System.Drawing.Color.Silver
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.KeepFocusRectangle = False
        Me.btnExit.Location = New System.Drawing.Point(326, 26)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
        Me.btnExit.Size = New System.Drawing.Size(100, 41)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit Program"
        Me.btnExit.ThemeName = "Metro"
        Me.btnExit.UseVisualStyle = True
        '
        'btnSaveXLS
        '
        Me.btnSaveXLS.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnSaveXLS.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnSaveXLS.BeforeTouchSize = New System.Drawing.Size(100, 41)
        Me.btnSaveXLS.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
        Me.btnSaveXLS.ComboEditBackColor = System.Drawing.Color.Silver
        Me.btnSaveXLS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveXLS.ForeColor = System.Drawing.Color.White
        Me.btnSaveXLS.KeepFocusRectangle = False
        Me.btnSaveXLS.Location = New System.Drawing.Point(111, 26)
        Me.btnSaveXLS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSaveXLS.Name = "btnSaveXLS"
        Me.btnSaveXLS.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
        Me.btnSaveXLS.Size = New System.Drawing.Size(100, 41)
        Me.btnSaveXLS.TabIndex = 2
        Me.btnSaveXLS.Text = "Save Excel"
        Me.btnSaveXLS.ThemeName = "Metro"
        Me.btnSaveXLS.UseVisualStyle = True
        '
        'btnSavePDF
        '
        Me.btnSavePDF.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnSavePDF.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnSavePDF.BeforeTouchSize = New System.Drawing.Size(100, 41)
        Me.btnSavePDF.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
        Me.btnSavePDF.ComboEditBackColor = System.Drawing.Color.Silver
        Me.btnSavePDF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSavePDF.ForeColor = System.Drawing.Color.White
        Me.btnSavePDF.KeepFocusRectangle = False
        Me.btnSavePDF.Location = New System.Drawing.Point(219, 26)
        Me.btnSavePDF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSavePDF.Name = "btnSavePDF"
        Me.btnSavePDF.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
        Me.btnSavePDF.Size = New System.Drawing.Size(100, 41)
        Me.btnSavePDF.TabIndex = 3
        Me.btnSavePDF.Text = "Save PDF"
        Me.btnSavePDF.ThemeName = "Metro"
        Me.btnSavePDF.UseVisualStyle = True
        '
        'TabPageAdv2
        '
        Me.TabPageAdv2.Controls.Add(Me.PdfViewerControl1)
        Me.TabPageAdv2.Image = Nothing
        Me.TabPageAdv2.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabPageAdv2.Location = New System.Drawing.Point(1, 28)
        Me.TabPageAdv2.Name = "TabPageAdv2"
        Me.TabPageAdv2.ShowCloseButton = True
        Me.TabPageAdv2.Size = New System.Drawing.Size(1024, 523)
        Me.TabPageAdv2.TabIndex = 4
        Me.TabPageAdv2.Text = "View PDF"
        Me.TabPageAdv2.ThemesEnabled = False
        '
        'PdfViewerControl1
        '
        Me.PdfViewerControl1.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool
        Me.PdfViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PdfViewerControl1.EnableContextMenu = True
        Me.PdfViewerControl1.EnableNotificationBar = True
        Me.PdfViewerControl1.HorizontalScrollOffset = 0
        Me.PdfViewerControl1.IsBookmarkEnabled = True
        Me.PdfViewerControl1.IsTextSearchEnabled = True
        Me.PdfViewerControl1.IsTextSelectionEnabled = True
        Me.PdfViewerControl1.Location = New System.Drawing.Point(0, 0)
        MessageBoxSettings3.EnableNotification = True
        Me.PdfViewerControl1.MessageBoxSettings = MessageBoxSettings3
        Me.PdfViewerControl1.MinimumZoomPercentage = 50
        Me.PdfViewerControl1.Name = "PdfViewerControl1"
        Me.PdfViewerControl1.PageBorderThickness = 1
        PdfViewerPrinterSettings3.Copies = 1
        PdfViewerPrinterSettings3.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.[Auto]
        PdfViewerPrinterSettings3.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize
        PdfViewerPrinterSettings3.PrintLocation = CType(resources.GetObject("PdfViewerPrinterSettings3.PrintLocation"), System.Drawing.PointF)
        PdfViewerPrinterSettings3.ShowPrintStatusDialog = True
        Me.PdfViewerControl1.PrinterSettings = PdfViewerPrinterSettings3
        Me.PdfViewerControl1.ReferencePath = Nothing
        Me.PdfViewerControl1.ScrollDisplacementValue = 0
        Me.PdfViewerControl1.ShowHorizontalScrollBar = True
        Me.PdfViewerControl1.ShowToolBar = True
        Me.PdfViewerControl1.ShowVerticalScrollBar = True
        Me.PdfViewerControl1.Size = New System.Drawing.Size(1024, 523)
        Me.PdfViewerControl1.SpaceBetweenPages = 8
        Me.PdfViewerControl1.TabIndex = 0
        Me.PdfViewerControl1.Text = "PdfViewerControl1"
        TextSearchSettings3.CurrentInstanceColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        TextSearchSettings3.HighlightAllInstance = True
        TextSearchSettings3.OtherInstanceColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PdfViewerControl1.TextSearchSettings = TextSearchSettings3
        Me.PdfViewerControl1.ThemeName = "Default"
        Me.PdfViewerControl1.VerticalScrollOffset = 0
        Me.PdfViewerControl1.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.[Default]
        Me.PdfViewerControl1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.[Default]
        '
        'TabPageAdv1
        '
        Me.TabPageAdv1.Controls.Add(Me.Panel1)
        Me.TabPageAdv1.Image = Nothing
        Me.TabPageAdv1.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabPageAdv1.Location = New System.Drawing.Point(1, 28)
        Me.TabPageAdv1.Name = "TabPageAdv1"
        Me.TabPageAdv1.ShowCloseButton = True
        Me.TabPageAdv1.Size = New System.Drawing.Size(1024, 523)
        Me.TabPageAdv1.TabIndex = 1
        Me.TabPageAdv1.Text = "View Excel"
        Me.TabPageAdv1.ThemesEnabled = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Spreadsheet1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 523)
        Me.Panel1.TabIndex = 7
        '
        'Spreadsheet1
        '
        Me.Spreadsheet1.AllowCellContextMenu = True
        Me.Spreadsheet1.AllowExtendRowColumnCount = True
        Me.Spreadsheet1.AllowFiltering = False
        Me.Spreadsheet1.AllowFormulaRangeSelection = True
        Me.Spreadsheet1.AllowTabItemContextMenu = True
        Me.Spreadsheet1.AllowZooming = True
        Me.Spreadsheet1.BaseThemeName = ""
        SpreadsheetCopyPaste1.AllowPasteOptionPopup = True
        SpreadsheetCopyPaste1.DefaultPasteOption = Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste
        Me.Spreadsheet1.CopyPaste = SpreadsheetCopyPaste1
        Me.Spreadsheet1.DefaultColumnCount = 101
        Me.Spreadsheet1.DefaultRowCount = 101
        Me.Spreadsheet1.DisplayAlerts = True
        Me.Spreadsheet1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Spreadsheet1.FileName = "Book1"
        Me.Spreadsheet1.FormulaBarVisibility = True
        FormulaRangeSelectionController1.AllowMouseSelection = True
        FormulaRangeSelectionController1.AllowSelectionOnEditing = True
        Me.Spreadsheet1.FormulaRangeSelectionController = FormulaRangeSelectionController1
        Me.Spreadsheet1.IsCustomTabItemContextMenuEnabled = False
        Me.Spreadsheet1.Location = New System.Drawing.Point(0, 0)
        Me.Spreadsheet1.Name = "Spreadsheet1"
        Me.Spreadsheet1.SelectedTabIndex = 0
        Me.Spreadsheet1.SelectedTabItem = Nothing
        Me.Spreadsheet1.ShowBusyIndicator = True
        Me.Spreadsheet1.Size = New System.Drawing.Size(1024, 523)
        Me.Spreadsheet1.TabIndex = 0
        Me.Spreadsheet1.TabItemContextMenu = Nothing
        Me.Spreadsheet1.Text = "Spreadsheet1"
        Me.Spreadsheet1.ThemeName = "Default"
        '
        'TabControlAdv1
        '
        Me.TabControlAdv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlAdv1.BeforeTouchSize = New System.Drawing.Size(1027, 553)
        Me.TabControlAdv1.Controls.Add(Me.TabPageAdv1)
        Me.TabControlAdv1.Controls.Add(Me.TabPageAdv2)
        Me.TabControlAdv1.FocusOnTabClick = False
        Me.TabControlAdv1.Location = New System.Drawing.Point(2, 89)
        Me.TabControlAdv1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControlAdv1.Name = "TabControlAdv1"
        Me.TabControlAdv1.Size = New System.Drawing.Size(1027, 553)
        Me.TabControlAdv1.TabIndex = 6
        Me.TabControlAdv1.ThemeName = "TabRenderer3D"
        Me.TabControlAdv1.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = CType(resources.GetObject("resource.DisabledNextPageImage"), System.Drawing.Image)
        Me.TabControlAdv1.ThemeStyle.PrimitiveButtonStyle.NextPageImage = CType(resources.GetObject("resource.NextPageImage"), System.Drawing.Image)
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.onePageRadioBtn)
        Me.groupBox1.Controls.Add(Me.allColumnRadioBtn)
        Me.groupBox1.Controls.Add(Me.allRowsRadioBtn)
        Me.groupBox1.Controls.Add(Me.noScaleRadioBtn)
        Me.groupBox1.Location = New System.Drawing.Point(443, 1)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(396, 81)
        Me.groupBox1.TabIndex = 99
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "PDF Page Setup Options"
        '
        'onePageRadioBtn
        '
        Me.onePageRadioBtn.AutoSize = True
        Me.onePageRadioBtn.Location = New System.Drawing.Point(211, 50)
        Me.onePageRadioBtn.Name = "onePageRadioBtn"
        Me.onePageRadioBtn.Size = New System.Drawing.Size(156, 20)
        Me.onePageRadioBtn.TabIndex = 3
        Me.onePageRadioBtn.Text = "Fit Sheet On One Page"
        Me.onePageRadioBtn.UseVisualStyleBackColor = True
        '
        'allColumnRadioBtn
        '
        Me.allColumnRadioBtn.AutoSize = True
        Me.allColumnRadioBtn.Checked = True
        Me.allColumnRadioBtn.Location = New System.Drawing.Point(15, 50)
        Me.allColumnRadioBtn.Name = "allColumnRadioBtn"
        Me.allColumnRadioBtn.Size = New System.Drawing.Size(190, 20)
        Me.allColumnRadioBtn.TabIndex = 2
        Me.allColumnRadioBtn.TabStop = True
        Me.allColumnRadioBtn.Text = "Fit All Columns On One Page"
        Me.allColumnRadioBtn.UseVisualStyleBackColor = True
        '
        'allRowsRadioBtn
        '
        Me.allRowsRadioBtn.AutoSize = True
        Me.allRowsRadioBtn.Location = New System.Drawing.Point(211, 25)
        Me.allRowsRadioBtn.Name = "allRowsRadioBtn"
        Me.allRowsRadioBtn.Size = New System.Drawing.Size(172, 20)
        Me.allRowsRadioBtn.TabIndex = 1
        Me.allRowsRadioBtn.Text = "Fit All Rows On One Page"
        Me.allRowsRadioBtn.UseVisualStyleBackColor = True
        '
        'noScaleRadioBtn
        '
        Me.noScaleRadioBtn.AutoSize = True
        Me.noScaleRadioBtn.Location = New System.Drawing.Point(15, 25)
        Me.noScaleRadioBtn.Name = "noScaleRadioBtn"
        Me.noScaleRadioBtn.Size = New System.Drawing.Size(86, 20)
        Me.noScaleRadioBtn.TabIndex = 0
        Me.noScaleRadioBtn.Text = "No Scaling"
        Me.noScaleRadioBtn.UseVisualStyleBackColor = True
        '
        'frmSpreadExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 643)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.TabControlAdv1)
        Me.Controls.Add(Me.btnSavePDF)
        Me.Controls.Add(Me.btnSaveXLS)
        Me.Controls.Add(Me.btnLoadXLS)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmSpreadExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SpreadSheet on Syncfusion - coDe bY Thongkorn Tubtimkrob"
        Me.TabPageAdv2.ResumeLayout(False)
        Me.TabPageAdv1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.TabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlAdv1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnLoadXLS As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents btnExit As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents btnSaveXLS As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents btnSavePDF As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents TabPageAdv2 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents PdfViewerControl1 As Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl
    Friend WithEvents TabPageAdv1 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents TabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Spreadsheet1 As Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents onePageRadioBtn As System.Windows.Forms.RadioButton
    Private WithEvents allColumnRadioBtn As System.Windows.Forms.RadioButton
    Private WithEvents allRowsRadioBtn As System.Windows.Forms.RadioButton
    Private WithEvents noScaleRadioBtn As System.Windows.Forms.RadioButton
End Class
