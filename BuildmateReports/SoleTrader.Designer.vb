Partial Class SoleTrader

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SoleTrader))
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.HtmlTextBox7 = New Telerik.Reporting.HtmlTextBox()
        Me.HtmlTextBox6 = New Telerik.Reporting.HtmlTextBox()
        Me.HtmlTextBox2 = New Telerik.Reporting.HtmlTextBox()
        Me.HtmlTextBox4 = New Telerik.Reporting.HtmlTextBox()
        Me.HtmlTextBox1 = New Telerik.Reporting.HtmlTextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.HtmlTextBox3 = New Telerik.Reporting.HtmlTextBox()
        Me.PictureBox1 = New Telerik.Reporting.PictureBox()
        Me.currentDateDataTextBox = New Telerik.Reporting.TextBox()
        Me.HtmlTextBox5 = New Telerik.Reporting.HtmlTextBox()
        Me.HtmlTextBox8 = New Telerik.Reporting.HtmlTextBox()
        Me.HtmlTextBox9 = New Telerik.Reporting.HtmlTextBox()
        Me.ReportFooterSection1 = New Telerik.Reporting.ReportFooterSection()
        Me.HtmlTextBox10 = New Telerik.Reporting.HtmlTextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "LocalSqlServer"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@pid", System.Data.DbType.Int32, "=Parameters.pid.Value"), New Telerik.Reporting.SqlDataSourceParameter("@incVAT", System.Data.DbType.[Byte], "=Parameters.incVAT.Value")})
        Me.SqlDataSource1.SelectCommand = "dbo.report_COMPANY_NO_VAT"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(20.899999618530273R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.HtmlTextBox7, Me.HtmlTextBox6, Me.HtmlTextBox2, Me.HtmlTextBox4, Me.HtmlTextBox1, Me.TextBox12, Me.TextBox19, Me.TextBox18, Me.TextBox7, Me.TextBox6, Me.TextBox5, Me.TextBox4, Me.HtmlTextBox3, Me.PictureBox1, Me.currentDateDataTextBox, Me.HtmlTextBox5, Me.HtmlTextBox8, Me.HtmlTextBox9})
        Me.detail.Name = "detail"
        '
        'HtmlTextBox7
        '
        Me.HtmlTextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(20.0R))
        Me.HtmlTextBox7.Name = "HtmlTextBox7"
        Me.HtmlTextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.895545959472656R), Telerik.Reporting.Drawing.Unit.Cm(0.50020074844360352R))
        Me.HtmlTextBox7.Style.Font.Name = "Open Sans"
        Me.HtmlTextBox7.Value = "{Fields.busName},&nbsp;{Fields.busJobtitle}&nbsp;"
        '
        'HtmlTextBox6
        '
        Me.HtmlTextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.63936710357666R), Telerik.Reporting.Drawing.Unit.Cm(4.7129006385803223R))
        Me.HtmlTextBox6.Name = "HtmlTextBox6"
        Me.HtmlTextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0606327056884766R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.HtmlTextBox6.Style.Font.Name = "Open Sans"
        Me.HtmlTextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.HtmlTextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox6.Value = "<strong>Payment Terms:</strong>"
        '
        'HtmlTextBox2
        '
        Me.HtmlTextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.040409352630376816R), Telerik.Reporting.Drawing.Unit.Cm(16.972507476806641R))
        Me.HtmlTextBox2.Name = "HtmlTextBox2"
        Me.HtmlTextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.895545959472656R), Telerik.Reporting.Drawing.Unit.Cm(2.5274925231933594R))
        Me.HtmlTextBox2.Style.Font.Name = "Open Sans"
        Me.HtmlTextBox2.Value = resources.GetString("HtmlTextBox2.Value")
        '
        'HtmlTextBox4
        '
        Me.HtmlTextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.040409352630376816R), Telerik.Reporting.Drawing.Unit.Cm(2.6033334732055664R))
        Me.HtmlTextBox4.Name = "HtmlTextBox4"
        Me.HtmlTextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.4842782020568848R), Telerik.Reporting.Drawing.Unit.Cm(3.2998003959655762R))
        Me.HtmlTextBox4.Style.Font.Name = "Open Sans"
        Me.HtmlTextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.HtmlTextBox4.Value = "F.a.o:<br />{Fields.customerDetails}"
        '
        'HtmlTextBox1
        '
        Me.HtmlTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.63936710357666R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.HtmlTextBox1.Name = "HtmlTextBox1"
        Me.HtmlTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.29554557800293R), Telerik.Reporting.Drawing.Unit.Cm(3.2998003959655762R))
        Me.HtmlTextBox1.Style.Font.Name = "Open Sans"
        Me.HtmlTextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.HtmlTextBox1.Value = "{Fields.businessDetails}"
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = True
        Me.TextBox12.CanShrink = True
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.699999809265137R), Telerik.Reporting.Drawing.Unit.Cm(3.5124998092651367R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.1806325912475586R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox12.Style.Font.Name = "Open Sans"
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox12.StyleName = "Data"
        Me.TextBox12.Value = "=Fields.tenderType"
        '
        'TextBox19
        '
        Me.TextBox19.CanGrow = True
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(16.0R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(11.899999618530273R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox19.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox19.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox19.Style.Font.Name = "Open Sans"
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox19.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox19.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox19.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox19.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox19.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox19.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox19.StyleName = "Caption"
        Me.TextBox19.Value = "Total (excluding VAT)"
        '
        'TextBox18
        '
        Me.TextBox18.CanGrow = True
        Me.TextBox18.Format = "{0:C2}"
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.920200347900391R), Telerik.Reporting.Drawing.Unit.Cm(16.0R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9953458309173584R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox18.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox18.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox18.Style.Font.Name = "Open Sans"
        Me.TextBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox18.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox18.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox18.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox18.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox18.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox18.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox18.StyleName = "Caption"
        Me.TextBox18.Value = "=Fields.totalValue"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.040409352630376816R), Telerik.Reporting.Drawing.Unit.Cm(12.500000953674316R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(11.859590530395508R), Telerik.Reporting.Drawing.Unit.Cm(3.4999978542327881R))
        Me.TextBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox7.Style.Font.Name = "Open Sans"
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox7.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox7.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox7.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox7.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox7.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox7.StyleName = "Caption"
        Me.TextBox7.Value = "{Fields.ProjectName}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{Fields.description}"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Format = "{0:C2}"
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.920200347900391R), Telerik.Reporting.Drawing.Unit.Cm(12.474591255187988R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9997997283935547R), Telerik.Reporting.Drawing.Unit.Cm(3.5254096984863281R))
        Me.TextBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox6.Style.Font.Name = "Open Sans"
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox6.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox6.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox6.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox6.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox6.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox6.StyleName = "Caption"
        Me.TextBox6.Value = "=Fields.totalValue"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.920200347900391R), Telerik.Reporting.Drawing.Unit.Cm(11.874591827392578R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9997997283935547R), Telerik.Reporting.Drawing.Unit.Cm(0.59999954700469971R))
        Me.TextBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.Style.Font.Name = "Open Sans"
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox5.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox5.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox5.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox5.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox5.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox5.StyleName = "Caption"
        Me.TextBox5.Value = "Amount"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.040409352630376816R), Telerik.Reporting.Drawing.Unit.Cm(11.874591827392578R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(11.859590530395508R), Telerik.Reporting.Drawing.Unit.Cm(0.59999954700469971R))
        Me.TextBox4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Name = "Open Sans"
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox4.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox4.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox4.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox4.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox4.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox4.StyleName = "Caption"
        Me.TextBox4.Value = "Description"
        '
        'HtmlTextBox3
        '
        Me.HtmlTextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.039999999105930328R), Telerik.Reporting.Drawing.Unit.Cm(6.4000000953674316R))
        Me.HtmlTextBox3.Name = "HtmlTextBox3"
        Me.HtmlTextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.895545959472656R), Telerik.Reporting.Drawing.Unit.Cm(4.3920016288757324R))
        Me.HtmlTextBox3.Style.Font.Name = "Open Sans"
        Me.HtmlTextBox3.Value = resources.GetString("HtmlTextBox3.Value")
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.PictureBox1.MimeType = ""
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.4842782020568848R), Telerik.Reporting.Drawing.Unit.Cm(2.1999001502990723R))
        Me.PictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.PictureBox1.Value = "= Fields.busLogo"
        '
        'currentDateDataTextBox
        '
        Me.currentDateDataTextBox.CanGrow = True
        Me.currentDateDataTextBox.Format = "{0:D}"
        Me.currentDateDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.699999809265137R), Telerik.Reporting.Drawing.Unit.Cm(4.1127004623413086R))
        Me.currentDateDataTextBox.Name = "currentDateDataTextBox"
        Me.currentDateDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.1906328201293945R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.currentDateDataTextBox.Style.Font.Name = "Open Sans"
        Me.currentDateDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.currentDateDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.currentDateDataTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.currentDateDataTextBox.StyleName = "Data"
        Me.currentDateDataTextBox.Value = "= Now()"
        '
        'HtmlTextBox5
        '
        Me.HtmlTextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.699999809265137R), Telerik.Reporting.Drawing.Unit.Cm(4.7129006385803223R))
        Me.HtmlTextBox5.Name = "HtmlTextBox5"
        Me.HtmlTextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.1806330680847168R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.HtmlTextBox5.Style.Font.Name = "Open Sans"
        Me.HtmlTextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.HtmlTextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox5.Value = "{Fields.paymentTerm}"
        '
        'HtmlTextBox8
        '
        Me.HtmlTextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.63936710357666R), Telerik.Reporting.Drawing.Unit.Cm(4.1127004623413086R))
        Me.HtmlTextBox8.Name = "HtmlTextBox8"
        Me.HtmlTextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0606327056884766R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.HtmlTextBox8.Style.Font.Name = "Open Sans"
        Me.HtmlTextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.HtmlTextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox8.Value = "<strong>Date:</strong>"
        '
        'HtmlTextBox9
        '
        Me.HtmlTextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.63936710357666R), Telerik.Reporting.Drawing.Unit.Cm(3.5124998092651367R))
        Me.HtmlTextBox9.Name = "HtmlTextBox9"
        Me.HtmlTextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0606327056884766R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.HtmlTextBox9.Style.Font.Bold = True
        Me.HtmlTextBox9.Style.Font.Name = "Open Sans"
        Me.HtmlTextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.HtmlTextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox9.Value = "Tender Type:"
        '
        'ReportFooterSection1
        '
        Me.ReportFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(3.0R)
        Me.ReportFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.HtmlTextBox10})
        Me.ReportFooterSection1.Name = "ReportFooterSection1"
        Me.ReportFooterSection1.PageBreak = Telerik.Reporting.PageBreak.Before
        '
        'HtmlTextBox10
        '
        Me.HtmlTextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.026458332315087318R), Telerik.Reporting.Drawing.Unit.Cm(0.5027083158493042R))
        Me.HtmlTextBox10.Name = "HtmlTextBox10"
        Me.HtmlTextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.895545959472656R), Telerik.Reporting.Drawing.Unit.Cm(1.9618978500366211R))
        Me.HtmlTextBox10.Style.Font.Name = "Open Sans"
        Me.HtmlTextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.HtmlTextBox10.Value = ""
        '
        'SoleTrader
        '
        Me.DataSource = Me.SqlDataSource1
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detail, Me.ReportFooterSection1})
        Me.Name = "NewCompanyExcVAT"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R)
        Me.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R)
        Me.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R)
        Me.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "pid"
        ReportParameter1.Text = "pid"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter1.Value = "0"
        ReportParameter2.AllowBlank = False
        ReportParameter2.Name = "TermsOfUse"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter2.Value = "0"
        ReportParameter3.Name = "incVAT"
        ReportParameter3.Text = "incVAT"
        ReportParameter3.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter3.Value = "0"
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(15.980632781982422R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents HtmlTextBox6 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents HtmlTextBox2 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents HtmlTextBox4 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents HtmlTextBox1 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents HtmlTextBox3 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents PictureBox1 As Telerik.Reporting.PictureBox
    Friend WithEvents currentDateDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents HtmlTextBox5 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents HtmlTextBox8 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents HtmlTextBox9 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents ReportFooterSection1 As Telerik.Reporting.ReportFooterSection
    Friend WithEvents HtmlTextBox10 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents HtmlTextBox7 As Telerik.Reporting.HtmlTextBox
End Class