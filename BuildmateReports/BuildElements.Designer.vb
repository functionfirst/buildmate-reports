Partial Class BuildElements

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.resourceNameDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.labelsGroup = New Telerik.Reporting.Group()
        Me.labelsGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.resourceNameCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.resourceTypeGroup = New Telerik.Reporting.Group()
        Me.supplierNameGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.priceSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.supplierNameGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "server=mssql2008R2.aspnethosting.co.uk, 14330;uid=getbuild_user;pwd=#Sharpe30pyr!" &
    ";database=getbuild_mate"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@projectId", System.Data.DbType.Int32, "=Parameters.pid.Value")})
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = "dbo.report_BUILD_ELEMENTS"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.reportNameTextBox})
        Me.pageHeader.Name = "pageHeader"
        Me.pageHeader.Style.Visible = True
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(22.347084045410156R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.reportNameTextBox.Style.Font.Bold = True
        Me.reportNameTextBox.Style.Font.Name = "Open Sans"
        Me.reportNameTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16.0R)
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "Project (Break-down)"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.currentTimeTextBox, Me.pageInfoTextBox})
        Me.pageFooter.Name = "pageFooter"
        '
        'currentTimeTextBox
        '
        Me.currentTimeTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.currentTimeTextBox.Name = "currentTimeTextBox"
        Me.currentTimeTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.5894265174865723R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.currentTimeTextBox.Style.Color = System.Drawing.Color.Gainsboro
        Me.currentTimeTextBox.Style.Font.Name = "Open Sans"
        Me.currentTimeTextBox.StyleName = "PageInfo"
        Me.currentTimeTextBox.Value = "=""Created on ""+ NOW()"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(19.899999618530273R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.5999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.pageInfoTextBox.Style.Color = System.Drawing.Color.Gainsboro
        Me.pageInfoTextBox.Style.Font.Name = "Open Sans"
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=""Page "" + PageNumber"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.72833341360092163R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.resourceNameDataTextBox, Me.TextBox2, Me.TextBox5, Me.TextBox9})
        Me.detail.Name = "detail"
        Me.detail.Style.BorderColor.Default = System.Drawing.Color.Gainsboro
        Me.detail.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.detail.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.detail.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Cm(0R)
        Me.detail.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Cm(0R)
        Me.detail.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Cm(0R)
        '
        'resourceNameDataTextBox
        '
        Me.resourceNameDataTextBox.CanGrow = True
        Me.resourceNameDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.resourceNameDataTextBox.Name = "resourceNameDataTextBox"
        Me.resourceNameDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.8470840454101562R), Telerik.Reporting.Drawing.Unit.Cm(0.70999997854232788R))
        Me.resourceNameDataTextBox.Style.Font.Name = "Open Sans"
        Me.resourceNameDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.resourceNameDataTextBox.StyleName = "Data"
        Me.resourceNameDataTextBox.Value = "=Fields.spaceName"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Format = "{0:C2}"
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(22.0R), Telerik.Reporting.Drawing.Unit.Cm(0.018333425745368004R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4000003337860107R), Telerik.Reporting.Drawing.Unit.Cm(0.70999997854232788R))
        Me.TextBox2.Style.Font.Name = "Open Sans"
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox2.StyleName = "Data"
        Me.TextBox2.Value = "=Fields.buildCost"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.100000381469727R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8997979164123535R), Telerik.Reporting.Drawing.Unit.Cm(0.70999997854232788R))
        Me.TextBox5.Style.Font.Name = "Open Sans"
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox5.StyleName = "Data"
        Me.TextBox5.Value = "=Fields.spaceType"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.5R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8491225242614746R), Telerik.Reporting.Drawing.Unit.Cm(0.70999997854232788R))
        Me.TextBox9.Style.Font.Name = "Open Sans"
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox9.StyleName = "Data"
        Me.TextBox9.Value = "=Fields.subcontractType"
        '
        'labelsGroup
        '
        Me.labelsGroup.GroupFooter = Me.labelsGroupFooter
        Me.labelsGroup.GroupHeader = Me.labelsGroupHeader
        Me.labelsGroup.Name = "labelsGroup"
        '
        'labelsGroupFooter
        '
        Me.labelsGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.labelsGroupFooter.Name = "labelsGroupFooter"
        Me.labelsGroupFooter.PageBreak = Telerik.Reporting.PageBreak.None
        Me.labelsGroupFooter.Style.Visible = False
        '
        'labelsGroupHeader
        '
        Me.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.70999991893768311R)
        Me.labelsGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.resourceNameCaptionTextBox, Me.TextBox1, Me.TextBox4, Me.TextBox8})
        Me.labelsGroupHeader.Name = "labelsGroupHeader"
        Me.labelsGroupHeader.PrintOnEveryPage = True
        Me.labelsGroupHeader.Style.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.labelsGroupHeader.Style.BorderColor.Default = System.Drawing.Color.DimGray
        Me.labelsGroupHeader.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.labelsGroupHeader.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Cm(0R)
        Me.labelsGroupHeader.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Cm(0R)
        Me.labelsGroupHeader.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Cm(0R)
        '
        'resourceNameCaptionTextBox
        '
        Me.resourceNameCaptionTextBox.CanGrow = True
        Me.resourceNameCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(-0.000000050465263967680585R))
        Me.resourceNameCaptionTextBox.Name = "resourceNameCaptionTextBox"
        Me.resourceNameCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.8470840454101562R), Telerik.Reporting.Drawing.Unit.Cm(0.70999997854232788R))
        Me.resourceNameCaptionTextBox.Style.Font.Bold = True
        Me.resourceNameCaptionTextBox.Style.Font.Name = "Open Sans"
        Me.resourceNameCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.resourceNameCaptionTextBox.StyleName = "Caption"
        Me.resourceNameCaptionTextBox.Value = "Name"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(22.0R), Telerik.Reporting.Drawing.Unit.Cm(-0.000000050465263967680585R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4000003337860107R), Telerik.Reporting.Drawing.Unit.Cm(0.70999997854232788R))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "Open Sans"
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "Build Cost (£)"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.100000381469727R), Telerik.Reporting.Drawing.Unit.Cm(-0.000000050465263967680585R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8997979164123535R), Telerik.Reporting.Drawing.Unit.Cm(0.70999997854232788R))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Name = "Open Sans"
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox4.StyleName = "Caption"
        Me.TextBox4.Value = "Type"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.5R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8491225242614746R), Telerik.Reporting.Drawing.Unit.Cm(0.70999997854232788R))
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.Style.Font.Name = "Open Sans"
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox8.StyleName = "Caption"
        Me.TextBox8.Value = "Sundry Items"
        '
        'resourceTypeGroup
        '
        Me.resourceTypeGroup.GroupFooter = Me.supplierNameGroupFooter
        Me.resourceTypeGroup.GroupHeader = Me.supplierNameGroupHeader
        Me.resourceTypeGroup.Name = "resourceTypeGroup"
        '
        'supplierNameGroupFooter
        '
        Me.supplierNameGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.728125274181366R)
        Me.supplierNameGroupFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.priceSumFunctionTextBox, Me.TextBox3})
        Me.supplierNameGroupFooter.Name = "supplierNameGroupFooter"
        Me.supplierNameGroupFooter.PageBreak = Telerik.Reporting.PageBreak.After
        Me.supplierNameGroupFooter.Style.BackgroundColor = System.Drawing.Color.WhiteSmoke
        '
        'priceSumFunctionTextBox
        '
        Me.priceSumFunctionTextBox.CanGrow = True
        Me.priceSumFunctionTextBox.Format = "{0:C2}"
        Me.priceSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(21.456510543823242R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.priceSumFunctionTextBox.Name = "priceSumFunctionTextBox"
        Me.priceSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0047397613525391R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.priceSumFunctionTextBox.Style.Font.Name = "Open Sans"
        Me.priceSumFunctionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.priceSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.priceSumFunctionTextBox.StyleName = "Data"
        Me.priceSumFunctionTextBox.Value = "=Sum(Fields.buildCost)"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(18.398853302001953R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0047390460968018R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Name = "Open Sans"
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox3.StyleName = "Data"
        Me.TextBox3.Value = "Subtotal"
        '
        'supplierNameGroupHeader
        '
        Me.supplierNameGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.800000011920929R)
        Me.supplierNameGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox6})
        Me.supplierNameGroupHeader.Name = "supplierNameGroupHeader"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.30000114440918R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox6.Style.Font.Bold = True
        Me.TextBox6.Style.Font.Name = "Open Sans"
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox6.StyleName = "Data"
        Me.TextBox6.Value = "Build Element (net of O&P, VAT and bulk resource saving)"
        '
        'BuildElements
        '
        Me.DataSource = Me.SqlDataSource1
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.resourceTypeGroup, Me.labelsGroup})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.supplierNameGroupHeader, Me.supplierNameGroupFooter, Me.labelsGroupHeader, Me.labelsGroupFooter, Me.pageHeader, Me.pageFooter, Me.detail})
        Me.Name = "BuildElements"
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R)
        Me.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R)
        Me.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R)
        Me.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "pid"
        ReportParameter1.Text = "pid"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter1.Value = "277"
        Me.ReportParameters.Add(ReportParameter1)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Title")})
        StyleRule1.Style.Color = System.Drawing.Color.Black
        StyleRule1.Style.Font.Bold = True
        StyleRule1.Style.Font.Italic = False
        StyleRule1.Style.Font.Name = "Tahoma"
        StyleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18.0R)
        StyleRule1.Style.Font.Strikeout = False
        StyleRule1.Style.Font.Underline = False
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Caption")})
        StyleRule2.Style.Color = System.Drawing.Color.Black
        StyleRule2.Style.Font.Name = "Tahoma"
        StyleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Data")})
        StyleRule3.Style.Font.Name = "Tahoma"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        StyleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("PageInfo")})
        StyleRule4.Style.Font.Name = "Tahoma"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        StyleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(24.514167785644531R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents resourceNameDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroup As Telerik.Reporting.Group
    Friend WithEvents labelsGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents labelsGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents resourceNameCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents resourceTypeGroup As Telerik.Reporting.Group
    Friend WithEvents supplierNameGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents priceSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents supplierNameGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
End Class