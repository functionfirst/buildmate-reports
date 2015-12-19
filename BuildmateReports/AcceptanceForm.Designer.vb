Partial Class AcceptanceForm
    
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
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.busAddressDataTextBox = New Telerik.Reporting.TextBox()
        Me.busCompanyDataTextBox = New Telerik.Reporting.TextBox()
        Me.busEmailDataTextBox = New Telerik.Reporting.TextBox()
        Me.busNameDataTextBox = New Telerik.Reporting.TextBox()
        Me.busPostcodeDataTextBox = New Telerik.Reporting.TextBox()
        Me.busTelDataTextBox = New Telerik.Reporting.TextBox()
        Me.currentDateDataTextBox = New Telerik.Reporting.TextBox()
        Me.customerAddressDataTextBox = New Telerik.Reporting.TextBox()
        Me.customerNameDataTextBox = New Telerik.Reporting.TextBox()
        Me.customerpostcodeDataTextBox = New Telerik.Reporting.TextBox()
        Me.customerTelDataTextBox = New Telerik.Reporting.TextBox()
        Me.paymentTermDataTextBox = New Telerik.Reporting.TextBox()
        Me.vatnumberDataTextBox = New Telerik.Reporting.TextBox()
        Me.PictureBox1 = New Telerik.Reporting.PictureBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.HtmlTextBox1 = New Telerik.Reporting.HtmlTextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "LocalSqlServer"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@pid", System.Data.DbType.Int32, "=Parameters.pid.Value")})
        Me.SqlDataSource1.SelectCommand = "dbo.report_ACCEPTANCE_FORM"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(22.112499237060547R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.busAddressDataTextBox, Me.busCompanyDataTextBox, Me.busEmailDataTextBox, Me.busNameDataTextBox, Me.busPostcodeDataTextBox, Me.busTelDataTextBox, Me.currentDateDataTextBox, Me.customerAddressDataTextBox, Me.customerNameDataTextBox, Me.customerpostcodeDataTextBox, Me.customerTelDataTextBox, Me.paymentTermDataTextBox, Me.vatnumberDataTextBox, Me.PictureBox1, Me.TextBox3, Me.TextBox14, Me.TextBox13, Me.TextBox7, Me.TextBox6, Me.HtmlTextBox1, Me.TextBox8, Me.TextBox4, Me.TextBox1, Me.TextBox2, Me.TextBox5, Me.TextBox9})
        Me.detail.Name = "detail"
        '
        'busAddressDataTextBox
        '
        Me.busAddressDataTextBox.CanGrow = True
        Me.busAddressDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.19999989867210388R), Telerik.Reporting.Drawing.Unit.Cm(4.0004010200500488R))
        Me.busAddressDataTextBox.Name = "busAddressDataTextBox"
        Me.busAddressDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.3599996566772461R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.busAddressDataTextBox.Style.Font.Name = "Open Sans"
        Me.busAddressDataTextBox.Value = "=Fields.busAddress"
        '
        'busCompanyDataTextBox
        '
        Me.busCompanyDataTextBox.CanGrow = True
        Me.busCompanyDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224R), Telerik.Reporting.Drawing.Unit.Cm(2.7999999523162842R))
        Me.busCompanyDataTextBox.Name = "busCompanyDataTextBox"
        Me.busCompanyDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.3599996566772461R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.busCompanyDataTextBox.Style.Font.Bold = True
        Me.busCompanyDataTextBox.Style.Font.Name = "Open Sans"
        Me.busCompanyDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.busCompanyDataTextBox.Value = "=Fields.busCompany"
        '
        'busEmailDataTextBox
        '
        Me.busEmailDataTextBox.CanGrow = True
        Me.busEmailDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.19999989867210388R), Telerik.Reporting.Drawing.Unit.Cm(6.2504000663757324R))
        Me.busEmailDataTextBox.Name = "busEmailDataTextBox"
        Me.busEmailDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.3599996566772461R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.busEmailDataTextBox.Style.Font.Name = "Open Sans"
        Me.busEmailDataTextBox.Value = "=Fields.busEmail"
        '
        'busNameDataTextBox
        '
        Me.busNameDataTextBox.CanGrow = True
        Me.busNameDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224R), Telerik.Reporting.Drawing.Unit.Cm(5.0500001907348633R))
        Me.busNameDataTextBox.Name = "busNameDataTextBox"
        Me.busNameDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.3599996566772461R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.busNameDataTextBox.Style.Font.Name = "Open Sans"
        Me.busNameDataTextBox.Value = "=Fields.busPostcode"
        '
        'busPostcodeDataTextBox
        '
        Me.busPostcodeDataTextBox.CanGrow = True
        Me.busPostcodeDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224R), Telerik.Reporting.Drawing.Unit.Cm(3.4002006053924561R))
        Me.busPostcodeDataTextBox.Name = "busPostcodeDataTextBox"
        Me.busPostcodeDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.3599996566772461R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.busPostcodeDataTextBox.Style.Font.Bold = False
        Me.busPostcodeDataTextBox.Style.Font.Name = "Open Sans"
        Me.busPostcodeDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.busPostcodeDataTextBox.Value = "=Fields.busName"
        '
        'busTelDataTextBox
        '
        Me.busTelDataTextBox.CanGrow = True
        Me.busTelDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000070333480835R), Telerik.Reporting.Drawing.Unit.Cm(5.6501998901367188R))
        Me.busTelDataTextBox.Name = "busTelDataTextBox"
        Me.busTelDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.3599996566772461R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.busTelDataTextBox.Style.Font.Name = "Open Sans"
        Me.busTelDataTextBox.Value = "=Fields.busTel"
        '
        'currentDateDataTextBox
        '
        Me.currentDateDataTextBox.CanGrow = True
        Me.currentDateDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000070333480835R), Telerik.Reporting.Drawing.Unit.Cm(7.6694526672363281R))
        Me.currentDateDataTextBox.Name = "currentDateDataTextBox"
        Me.currentDateDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.6999993324279785R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.currentDateDataTextBox.Style.Font.Name = "Open Sans"
        Me.currentDateDataTextBox.Value = "Date:"
        '
        'customerAddressDataTextBox
        '
        Me.customerAddressDataTextBox.CanGrow = True
        Me.customerAddressDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.399998664855957R), Telerik.Reporting.Drawing.Unit.Cm(3.4002006053924561R))
        Me.customerAddressDataTextBox.Name = "customerAddressDataTextBox"
        Me.customerAddressDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.customerAddressDataTextBox.Style.Font.Name = "Open Sans"
        Me.customerAddressDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.customerAddressDataTextBox.Value = "=Fields.customerAddress"
        '
        'customerNameDataTextBox
        '
        Me.customerNameDataTextBox.CanGrow = True
        Me.customerNameDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.399999618530273R), Telerik.Reporting.Drawing.Unit.Cm(2.7999999523162842R))
        Me.customerNameDataTextBox.Name = "customerNameDataTextBox"
        Me.customerNameDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.customerNameDataTextBox.Style.Font.Name = "Open Sans"
        Me.customerNameDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.customerNameDataTextBox.Value = "=Fields.customerName"
        '
        'customerpostcodeDataTextBox
        '
        Me.customerpostcodeDataTextBox.CanGrow = True
        Me.customerpostcodeDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.399999618530273R), Telerik.Reporting.Drawing.Unit.Cm(4.4499998092651367R))
        Me.customerpostcodeDataTextBox.Name = "customerpostcodeDataTextBox"
        Me.customerpostcodeDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.customerpostcodeDataTextBox.Style.Font.Name = "Open Sans"
        Me.customerpostcodeDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.customerpostcodeDataTextBox.Value = "=Fields.customerpostcode"
        '
        'customerTelDataTextBox
        '
        Me.customerTelDataTextBox.CanGrow = True
        Me.customerTelDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.399998664855957R), Telerik.Reporting.Drawing.Unit.Cm(5.0502004623413086R))
        Me.customerTelDataTextBox.Name = "customerTelDataTextBox"
        Me.customerTelDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.customerTelDataTextBox.Style.Font.Name = "Open Sans"
        Me.customerTelDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.customerTelDataTextBox.Value = "=Fields.customerTel"
        '
        'paymentTermDataTextBox
        '
        Me.paymentTermDataTextBox.CanGrow = True
        Me.paymentTermDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000070333480835R), Telerik.Reporting.Drawing.Unit.Cm(8.3000001907348633R))
        Me.paymentTermDataTextBox.Name = "paymentTermDataTextBox"
        Me.paymentTermDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.6999993324279785R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.paymentTermDataTextBox.Style.Font.Name = "Open Sans"
        Me.paymentTermDataTextBox.Value = "Payment Terms:"
        '
        'vatnumberDataTextBox
        '
        Me.vatnumberDataTextBox.CanGrow = True
        Me.vatnumberDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000070333480835R), Telerik.Reporting.Drawing.Unit.Cm(6.8505997657775879R))
        Me.vatnumberDataTextBox.Name = "vatnumberDataTextBox"
        Me.vatnumberDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.3599996566772461R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.vatnumberDataTextBox.Style.Color = System.Drawing.Color.DimGray
        Me.vatnumberDataTextBox.Style.Font.Name = "Open Sans"
        Me.vatnumberDataTextBox.Value = "=""VAT Registration: "" + Fields.vatnumber"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224R), Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224R))
        Me.PictureBox1.MimeType = ""
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.3599996566772461R), Telerik.Reporting.Drawing.Unit.Cm(2.0999999046325684R))
        Me.PictureBox1.Value = "=Fields.busLogo"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224R), Telerik.Reporting.Drawing.Unit.Cm(9.1099996566772461R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.550000190734863R), Telerik.Reporting.Drawing.Unit.Cm(0.49999982118606567R))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Name = "Open Sans"
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "Acceptance and confirmation order to proceed with the work "
        '
        'TextBox14
        '
        Me.TextBox14.CanGrow = True
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.699999988079071R), Telerik.Reporting.Drawing.Unit.Cm(15.899999618530273R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.6000001430511475R), Telerik.Reporting.Drawing.Unit.Cm(0.45200598239898682R))
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox14.StyleName = "Caption"
        Me.TextBox14.Value = "Date:"
        '
        'TextBox13
        '
        Me.TextBox13.CanGrow = True
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.699999988079071R), Telerik.Reporting.Drawing.Unit.Cm(14.109999656677246R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.6000001430511475R), Telerik.Reporting.Drawing.Unit.Cm(0.49999982118606567R))
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox13.StyleName = "Caption"
        Me.TextBox13.Value = "Signed:"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224R), Telerik.Reporting.Drawing.Unit.Cm(13.100000381469727R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.550000190734863R), Telerik.Reporting.Drawing.Unit.Cm(0.50333350896835327R))
        Me.TextBox7.Style.Font.Name = "Arial"
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox7.StyleName = "Caption"
        Me.TextBox7.Value = "I acknowledge where VAT is applicable it will be applied at the prevailing rate a" &
    "t the date of invoice. In order that you can proceed, please contact me to arran" &
    "ge a convenient start date. "
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224R), Telerik.Reporting.Drawing.Unit.Cm(12.409999847412109R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.550000190734863R), Telerik.Reporting.Drawing.Unit.Cm(0.50333350896835327R))
        Me.TextBox6.Style.Font.Name = "Arial"
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox6.StyleName = "Caption"
        Me.TextBox6.Value = "=""I acknowledge receipt of your "" + tenderType + "" for the above project and acce" &
    "pt your terms and conditions please carry out the specified work on my behalf fo" &
    "r the sum specified."""
        '
        'HtmlTextBox1
        '
        Me.HtmlTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224R), Telerik.Reporting.Drawing.Unit.Cm(10.710000038146973R))
        Me.HtmlTextBox1.Name = "HtmlTextBox1"
        Me.HtmlTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.549998283386231R), Telerik.Reporting.Drawing.Unit.Cm(0.49999982118606567R))
        Me.HtmlTextBox1.Value = "Re: <strong>{Fields.projectName}</strong>"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Format = "{0:C2}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224R), Telerik.Reporting.Drawing.Unit.Cm(11.420000076293945R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.6000001430511475R), Telerik.Reporting.Drawing.Unit.Cm(0.49999982118606567R))
        Me.TextBox8.Style.Font.Name = "Arial"
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox8.StyleName = "Caption"
        Me.TextBox8.Value = "Total Cost (Exc. VAT):"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224R), Telerik.Reporting.Drawing.Unit.Cm(9.90999984741211R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.549998283386231R), Telerik.Reporting.Drawing.Unit.Cm(0.49999982118606567R))
        Me.TextBox4.Style.Font.Name = "Arial"
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox4.StyleName = "Caption"
        Me.TextBox4.Value = "Dear Sir/Madam,"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.900200366973877R), Telerik.Reporting.Drawing.Unit.Cm(8.3044528961181641R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.3599996566772461R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox1.Style.Font.Name = "Open Sans"
        Me.TextBox1.Value = "=Fields.paymentTerm"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Format = "{0:D}"
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.900200366973877R), Telerik.Reporting.Drawing.Unit.Cm(7.6694526672363281R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.3599996566772461R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox2.Style.Font.Name = "Open Sans"
        Me.TextBox2.Value = "= Now()"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Format = "{0:C2}"
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(11.420000076293945R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.7600002288818359R), Telerik.Reporting.Drawing.Unit.Cm(0.49999982118606567R))
        Me.TextBox5.Style.Font.Name = "Arial"
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox5.StyleName = "Caption"
        Me.TextBox5.Value = "=Fields.totalValue"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.0R), Telerik.Reporting.Drawing.Unit.Cm(1.2999999523162842R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox9.Style.Font.Name = "Open Sans"
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox9.Value = "=Fields.customerName"
        '
        'AcceptanceForm
        '
        Me.DataSource = Me.SqlDataSource1
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detail})
        Me.Name = "AcceptanceForm"
        Me.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R)
        Me.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R)
        Me.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R)
        Me.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "pid"
        ReportParameter1.Text = "pid"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter1.Value = "0"
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(15.99990177154541R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents busAddressDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents busCompanyDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents busEmailDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents busNameDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents busPostcodeDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents busTelDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents currentDateDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents customerAddressDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents customerNameDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents customerpostcodeDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents customerTelDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents paymentTermDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents vatnumberDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents PictureBox1 As Telerik.Reporting.PictureBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents HtmlTextBox1 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
End Class