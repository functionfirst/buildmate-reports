Partial Class PricedMaterials

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.supplierNameGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.supplierNameDataTextBox = New Telerik.Reporting.TextBox()
        Me.supplierNameGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.priceSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.supplierNameGroup = New Telerik.Reporting.Group()
        Me.labelsGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.resourceNameCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.manufacturerCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.partIdCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.suffixCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.qtyCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.priceCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.labelsGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroup = New Telerik.Reporting.Group()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.resourceNameDataTextBox = New Telerik.Reporting.TextBox()
        Me.manufacturerDataTextBox = New Telerik.Reporting.TextBox()
        Me.partIdDataTextBox = New Telerik.Reporting.TextBox()
        Me.suffixDataTextBox = New Telerik.Reporting.TextBox()
        Me.qtyDataTextBox = New Telerik.Reporting.TextBox()
        Me.priceDataTextBox = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "LocalSqlServer"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@pid", System.Data.DbType.Int32, "=Parameters.pid.Value"), New Telerik.Reporting.SqlDataSourceParameter("@resourceTypeId", System.Data.DbType.Int32, "=Parameters.resourceTypeId.Value")})
        Me.SqlDataSource1.SelectCommand = "dbo.report_RESOURCES"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'supplierNameGroupHeader
        '
        Me.supplierNameGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.supplierNameGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.supplierNameDataTextBox})
        Me.supplierNameGroupHeader.Name = "supplierNameGroupHeader"
        '
        'supplierNameDataTextBox
        '
        Me.supplierNameDataTextBox.CanGrow = True
        Me.supplierNameDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916865795850754R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.supplierNameDataTextBox.Name = "supplierNameDataTextBox"
        Me.supplierNameDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(24.355419158935547R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.supplierNameDataTextBox.Style.Font.Bold = True
        Me.supplierNameDataTextBox.Style.Font.Name = "Open Sans"
        Me.supplierNameDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.supplierNameDataTextBox.StyleName = "Data"
        Me.supplierNameDataTextBox.Value = "=Fields.supplierName"
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
        Me.priceSumFunctionTextBox.Value = "=Sum(Fields.price)"
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
        'supplierNameGroup
        '
        Me.supplierNameGroup.GroupFooter = Me.supplierNameGroupFooter
        Me.supplierNameGroup.GroupHeader = Me.supplierNameGroupHeader
        Me.supplierNameGroup.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.supplierName")})
        Me.supplierNameGroup.Name = "supplierNameGroup"
        '
        'labelsGroupHeader
        '
        Me.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(1.0R)
        Me.labelsGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.resourceNameCaptionTextBox, Me.manufacturerCaptionTextBox, Me.partIdCaptionTextBox, Me.suffixCaptionTextBox, Me.qtyCaptionTextBox, Me.priceCaptionTextBox})
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
        Me.resourceNameCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.resourceNameCaptionTextBox.Name = "resourceNameCaptionTextBox"
        Me.resourceNameCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.1470832824707031R), Telerik.Reporting.Drawing.Unit.Cm(0.91823315620422363R))
        Me.resourceNameCaptionTextBox.Style.Font.Bold = True
        Me.resourceNameCaptionTextBox.Style.Font.Name = "Open Sans"
        Me.resourceNameCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.resourceNameCaptionTextBox.StyleName = "Caption"
        Me.resourceNameCaptionTextBox.Value = "Product Description"
        '
        'manufacturerCaptionTextBox
        '
        Me.manufacturerCaptionTextBox.CanGrow = True
        Me.manufacturerCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.3000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.manufacturerCaptionTextBox.Name = "manufacturerCaptionTextBox"
        Me.manufacturerCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.09999942779541R), Telerik.Reporting.Drawing.Unit.Cm(0.91823315620422363R))
        Me.manufacturerCaptionTextBox.Style.Font.Bold = True
        Me.manufacturerCaptionTextBox.Style.Font.Name = "Open Sans"
        Me.manufacturerCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.manufacturerCaptionTextBox.StyleName = "Caption"
        Me.manufacturerCaptionTextBox.Value = "Build Stage Reference"
        '
        'partIdCaptionTextBox
        '
        Me.partIdCaptionTextBox.CanGrow = True
        Me.partIdCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.5R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.partIdCaptionTextBox.Name = "partIdCaptionTextBox"
        Me.partIdCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.331770658493042R), Telerik.Reporting.Drawing.Unit.Cm(0.91823315620422363R))
        Me.partIdCaptionTextBox.Style.Font.Bold = True
        Me.partIdCaptionTextBox.Style.Font.Name = "Open Sans"
        Me.partIdCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.partIdCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.partIdCaptionTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.partIdCaptionTextBox.StyleName = "Caption"
        Me.partIdCaptionTextBox.Value = "Unit"
        '
        'suffixCaptionTextBox
        '
        Me.suffixCaptionTextBox.CanGrow = True
        Me.suffixCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(19.200000762939453R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.suffixCaptionTextBox.Name = "suffixCaptionTextBox"
        Me.suffixCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1000008583068848R), Telerik.Reporting.Drawing.Unit.Cm(0.91823315620422363R))
        Me.suffixCaptionTextBox.Style.Font.Bold = True
        Me.suffixCaptionTextBox.Style.Font.Name = "Open Sans"
        Me.suffixCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.suffixCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.suffixCaptionTextBox.StyleName = "Caption"
        Me.suffixCaptionTextBox.Value = "Rate"
        '
        'qtyCaptionTextBox
        '
        Me.qtyCaptionTextBox.CanGrow = True
        Me.qtyCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(17.0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.qtyCaptionTextBox.Name = "qtyCaptionTextBox"
        Me.qtyCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9999957084655762R), Telerik.Reporting.Drawing.Unit.Cm(0.91833329200744629R))
        Me.qtyCaptionTextBox.Style.Font.Bold = True
        Me.qtyCaptionTextBox.Style.Font.Name = "Open Sans"
        Me.qtyCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.qtyCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.qtyCaptionTextBox.StyleName = "Caption"
        Me.qtyCaptionTextBox.Value = "Material Quantity"
        '
        'priceCaptionTextBox
        '
        Me.priceCaptionTextBox.CanGrow = True
        Me.priceCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(21.456510543823242R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.priceCaptionTextBox.Name = "priceCaptionTextBox"
        Me.priceCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.9434912204742432R), Telerik.Reporting.Drawing.Unit.Cm(0.91823315620422363R))
        Me.priceCaptionTextBox.Style.Font.Bold = True
        Me.priceCaptionTextBox.Style.Font.Name = "Open Sans"
        Me.priceCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.priceCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.priceCaptionTextBox.StyleName = "Caption"
        Me.priceCaptionTextBox.Value = "Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ex VAT"
        '
        'labelsGroupFooter
        '
        Me.labelsGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.labelsGroupFooter.Name = "labelsGroupFooter"
        Me.labelsGroupFooter.Style.Visible = False
        '
        'labelsGroup
        '
        Me.labelsGroup.GroupFooter = Me.labelsGroupFooter
        Me.labelsGroup.GroupHeader = Me.labelsGroupHeader
        Me.labelsGroup.Name = "labelsGroup"
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.reportNameTextBox})
        Me.pageHeader.Name = "pageHeader"
        Me.pageHeader.Style.Visible = False
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(24.408334732055664R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.reportNameTextBox.Style.Font.Name = "Open Sans"
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "Resource Break-down"
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
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.resourceNameDataTextBox, Me.manufacturerDataTextBox, Me.partIdDataTextBox, Me.suffixDataTextBox, Me.qtyDataTextBox, Me.priceDataTextBox})
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
        Me.resourceNameDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.resourceNameDataTextBox.Name = "resourceNameDataTextBox"
        Me.resourceNameDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.1470832824707031R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.resourceNameDataTextBox.Style.Font.Name = "Open Sans"
        Me.resourceNameDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.resourceNameDataTextBox.StyleName = "Data"
        Me.resourceNameDataTextBox.Value = "=Fields.resourceName"
        '
        'manufacturerDataTextBox
        '
        Me.manufacturerDataTextBox.CanGrow = True
        Me.manufacturerDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.3000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.manufacturerDataTextBox.Name = "manufacturerDataTextBox"
        Me.manufacturerDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.09999942779541R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.manufacturerDataTextBox.Style.Font.Name = "Open Sans"
        Me.manufacturerDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.manufacturerDataTextBox.StyleName = "Data"
        Me.manufacturerDataTextBox.Value = ""
        '
        'partIdDataTextBox
        '
        Me.partIdDataTextBox.CanGrow = True
        Me.partIdDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.5R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.partIdDataTextBox.Name = "partIdDataTextBox"
        Me.partIdDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.331770658493042R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.partIdDataTextBox.Style.Font.Name = "Open Sans"
        Me.partIdDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.partIdDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.partIdDataTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.partIdDataTextBox.StyleName = "Data"
        Me.partIdDataTextBox.Value = "=Fields.suffix"
        '
        'suffixDataTextBox
        '
        Me.suffixDataTextBox.CanGrow = True
        Me.suffixDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(19.200000762939453R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.suffixDataTextBox.Name = "suffixDataTextBox"
        Me.suffixDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1000008583068848R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.suffixDataTextBox.Style.Font.Name = "Open Sans"
        Me.suffixDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.suffixDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.suffixDataTextBox.StyleName = "Data"
        Me.suffixDataTextBox.Value = ""
        '
        'qtyDataTextBox
        '
        Me.qtyDataTextBox.CanGrow = True
        Me.qtyDataTextBox.Format = "{0:N2}"
        Me.qtyDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(17.0R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.qtyDataTextBox.Name = "qtyDataTextBox"
        Me.qtyDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9999957084655762R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.qtyDataTextBox.Style.Font.Name = "Open Sans"
        Me.qtyDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.qtyDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.qtyDataTextBox.StyleName = "Data"
        Me.qtyDataTextBox.Value = "=Fields.qty"
        '
        'priceDataTextBox
        '
        Me.priceDataTextBox.CanGrow = True
        Me.priceDataTextBox.Format = "{0:C2}"
        Me.priceDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(21.456510543823242R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.priceDataTextBox.Name = "priceDataTextBox"
        Me.priceDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.9434912204742432R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.priceDataTextBox.Style.Font.Name = "Open Sans"
        Me.priceDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.priceDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.priceDataTextBox.StyleName = "Data"
        Me.priceDataTextBox.Value = "=Fields.price"
        '
        'PricedMaterials
        '
        Me.DataSource = Me.SqlDataSource1
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.supplierNameGroup, Me.labelsGroup})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.supplierNameGroupHeader, Me.supplierNameGroupFooter, Me.labelsGroupHeader, Me.labelsGroupFooter, Me.pageHeader, Me.pageFooter, Me.detail})
        Me.Name = "SupplierResources"
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R)
        Me.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R)
        Me.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R)
        Me.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "pid"
        ReportParameter1.Text = "pid"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter1.Value = "229"
        ReportParameter2.Name = "resourceTypeId"
        ReportParameter2.Text = "resourceTypeId"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter2.Value = "1"
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
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
    Friend WithEvents supplierNameGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents supplierNameDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents supplierNameGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents supplierNameGroup As Telerik.Reporting.Group
    Friend WithEvents labelsGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents resourceNameCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents manufacturerCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents partIdCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents suffixCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents qtyCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents priceCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents labelsGroup As Telerik.Reporting.Group
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents resourceNameDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents manufacturerDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents partIdDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents suffixDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents qtyDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents priceDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents priceSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
End Class