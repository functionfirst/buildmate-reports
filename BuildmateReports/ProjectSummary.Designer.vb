Partial Class ProjectSummary

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
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        Me.TextBox34 = New Telerik.Reporting.TextBox()
        Me.TextBox35 = New Telerik.Reporting.TextBox()
        Me.TextBox36 = New Telerik.Reporting.TextBox()
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.TextBox40 = New Telerik.Reporting.TextBox()
        Me.TextBox41 = New Telerik.Reporting.TextBox()
        Me.TextBox42 = New Telerik.Reporting.TextBox()
        Me.TextBox43 = New Telerik.Reporting.TextBox()
        Me.TextBox44 = New Telerik.Reporting.TextBox()
        Me.TextBox45 = New Telerik.Reporting.TextBox()
        Me.TextBox46 = New Telerik.Reporting.TextBox()
        Me.TextBox48 = New Telerik.Reporting.TextBox()
        Me.TextBox49 = New Telerik.Reporting.TextBox()
        Me.TextBox50 = New Telerik.Reporting.TextBox()
        Me.TextBox51 = New Telerik.Reporting.TextBox()
        Me.TextBox52 = New Telerik.Reporting.TextBox()
        Me.TextBox47 = New Telerik.Reporting.TextBox()
        Me.TextBox53 = New Telerik.Reporting.TextBox()
        Me.TextBox54 = New Telerik.Reporting.TextBox()
        Me.TextBox55 = New Telerik.Reporting.TextBox()
        Me.TextBox56 = New Telerik.Reporting.TextBox()
        Me.TextBox57 = New Telerik.Reporting.TextBox()
        Me.TextBox58 = New Telerik.Reporting.TextBox()
        Me.TextBox59 = New Telerik.Reporting.TextBox()
        Me.TextBox60 = New Telerik.Reporting.TextBox()
        Me.TextBox61 = New Telerik.Reporting.TextBox()
        Me.TextBox62 = New Telerik.Reporting.TextBox()
        Me.TextBox63 = New Telerik.Reporting.TextBox()
        Me.TextBox64 = New Telerik.Reporting.TextBox()
        Me.TextBox65 = New Telerik.Reporting.TextBox()
        Me.TextBox66 = New Telerik.Reporting.TextBox()
        Me.TextBox67 = New Telerik.Reporting.TextBox()
        Me.TextBox68 = New Telerik.Reporting.TextBox()
        Me.TextBox69 = New Telerik.Reporting.TextBox()
        Me.TextBox70 = New Telerik.Reporting.TextBox()
        Me.TextBox71 = New Telerik.Reporting.TextBox()
        Me.TextBox72 = New Telerik.Reporting.TextBox()
        Me.TextBox73 = New Telerik.Reporting.TextBox()
        Me.TextBox74 = New Telerik.Reporting.TextBox()
        Me.TextBox75 = New Telerik.Reporting.TextBox()
        Me.TextBox76 = New Telerik.Reporting.TextBox()
        Me.TextBox77 = New Telerik.Reporting.TextBox()
        Me.TextBox78 = New Telerik.Reporting.TextBox()
        Me.TextBox79 = New Telerik.Reporting.TextBox()
        Me.TextBox80 = New Telerik.Reporting.TextBox()
        Me.TextBox81 = New Telerik.Reporting.TextBox()
        Me.TextBox82 = New Telerik.Reporting.TextBox()
        Me.TextBox83 = New Telerik.Reporting.TextBox()
        Me.TextBox84 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "server=mssql2008R2.aspnethosting.co.uk, 14330;uid=getbuild_user;pwd=#Sharpe30pyr!" &
    ";database=getbuild_mate"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@pid", System.Data.DbType.Int32, "=Parameters.pid.Value")})
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = "dbo.report_PROJECT_SUMMARY"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(35.696456909179688R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox9, Me.TextBox10, Me.TextBox3, Me.TextBox4, Me.TextBox1, Me.TextBox2, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox11, Me.TextBox12, Me.TextBox13, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.TextBox20, Me.TextBox21, Me.TextBox22, Me.TextBox23, Me.TextBox24, Me.TextBox25, Me.TextBox26, Me.TextBox27, Me.TextBox28, Me.TextBox29, Me.TextBox30, Me.TextBox31, Me.TextBox32, Me.TextBox33, Me.TextBox34, Me.TextBox35, Me.TextBox36, Me.TextBox37, Me.TextBox38, Me.TextBox39, Me.TextBox40, Me.TextBox41, Me.TextBox42, Me.TextBox43, Me.TextBox44, Me.TextBox45, Me.TextBox46, Me.TextBox48, Me.TextBox49, Me.TextBox50, Me.TextBox51, Me.TextBox52, Me.TextBox47, Me.TextBox53, Me.TextBox54, Me.TextBox55, Me.TextBox56, Me.TextBox57, Me.TextBox58, Me.TextBox59, Me.TextBox60, Me.TextBox61, Me.TextBox62, Me.TextBox63, Me.TextBox64, Me.TextBox65, Me.TextBox66, Me.TextBox67, Me.TextBox68, Me.TextBox69, Me.TextBox70, Me.TextBox71, Me.TextBox72, Me.TextBox73, Me.TextBox74, Me.TextBox75, Me.TextBox76, Me.TextBox77, Me.TextBox78, Me.TextBox79, Me.TextBox80, Me.TextBox81, Me.TextBox82, Me.TextBox83, Me.TextBox84})
        Me.detail.Name = "detail"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(2.5R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox9.Style.Font.Name = "Open Sans"
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox9.Value = "=Fields.projectName"
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39999979734420776R), Telerik.Reporting.Drawing.Unit.Cm(2.5R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox10.Style.Font.Name = "Open Sans"
        Me.TextBox10.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox10.Value = "Project Name:"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448R), Telerik.Reporting.Drawing.Unit.Cm(3.2000000476837158R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox3.Style.Font.Name = "Open Sans"
        Me.TextBox3.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox3.Value = "Description:"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.7943835258483887R), Telerik.Reporting.Drawing.Unit.Cm(3.2000000476837158R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox4.Style.Font.Name = "Open Sans"
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox4.Value = "=Fields.description"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(3.9000000953674316R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox1.Style.Font.Name = "Open Sans"
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox1.Value = "=Fields.projectType"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.4025004506111145R), Telerik.Reporting.Drawing.Unit.Cm(3.9000000953674316R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox2.Style.Font.Name = "Open Sans"
        Me.TextBox2.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox2.Value = "Project Type"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448R), Telerik.Reporting.Drawing.Unit.Cm(4.5999999046325684R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox5.Style.Font.Name = "Open Sans"
        Me.TextBox5.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox5.Value = "Customer Name:"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.7974996566772461R), Telerik.Reporting.Drawing.Unit.Cm(4.5999999046325684R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox6.Style.Font.Name = "Open Sans"
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox6.Value = "=Fields.customerName"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Format = "{0:f}"
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(5.3000001907348633R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox7.Style.Font.Name = "Open Sans"
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox7.Value = "=Fields.returnDate"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.4025004506111145R), Telerik.Reporting.Drawing.Unit.Cm(5.3000001907348633R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox8.Style.Font.Name = "Open Sans"
        Me.TextBox8.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox8.Value = "Return Date:"
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = True
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39999979734420776R), Telerik.Reporting.Drawing.Unit.Cm(5.900200366973877R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox11.Style.Font.Name = "Open Sans"
        Me.TextBox11.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox11.Value = "Start Date:"
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = True
        Me.TextBox12.Format = "{0:D}"
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.7974996566772461R), Telerik.Reporting.Drawing.Unit.Cm(5.900200366973877R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox12.Style.Font.Name = "Open Sans"
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox12.Value = "=Fields.startDate"
        '
        'TextBox13
        '
        Me.TextBox13.CanGrow = True
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.7974996566772461R), Telerik.Reporting.Drawing.Unit.Cm(7.5002007484436035R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox13.Style.Font.Name = "Open Sans"
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox13.Value = "=Fields.retentionPeriod + ' '+ Fields.retentionType + ' at ' + Fields.retentionPe" &
    "rcentage + '%'"
        '
        'TextBox14
        '
        Me.TextBox14.CanGrow = True
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39999979734420776R), Telerik.Reporting.Drawing.Unit.Cm(7.5002007484436035R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox14.Style.Font.Name = "Open Sans"
        Me.TextBox14.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox14.Value = "Retention:"
        '
        'TextBox15
        '
        Me.TextBox15.CanGrow = True
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448R), Telerik.Reporting.Drawing.Unit.Cm(6.5999999046325684R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox15.Style.Font.Name = "Open Sans"
        Me.TextBox15.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox15.Value = "Completion Date:"
        '
        'TextBox16
        '
        Me.TextBox16.CanGrow = True
        Me.TextBox16.Format = "{0:D}"
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(6.5999999046325684R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox16.Style.Font.Name = "Open Sans"
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox16.Value = "=Fields.completionDate"
        '
        'TextBox17
        '
        Me.TextBox17.CanGrow = True
        Me.TextBox17.Format = "{0:P2}"
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.0R), Telerik.Reporting.Drawing.Unit.Cm(9.09999942779541R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox17.Style.Font.Name = "Open Sans"
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox17.Value = "=Fields.profitPercent/100"
        '
        'TextBox18
        '
        Me.TextBox18.CanGrow = True
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448R), Telerik.Reporting.Drawing.Unit.Cm(8.1999998092651367R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox18.Style.Font.Name = "Open Sans"
        Me.TextBox18.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox18.Value = "Overhead:"
        '
        'TextBox19
        '
        Me.TextBox19.CanGrow = True
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39999979734420776R), Telerik.Reporting.Drawing.Unit.Cm(0.000099921220680698752R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.9000015258789062R), Telerik.Reporting.Drawing.Unit.Cm(0.89970028400421143R))
        Me.TextBox19.Style.Font.Bold = True
        Me.TextBox19.Style.Font.Name = "Open Sans"
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18.0R)
        Me.TextBox19.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox19.Value = "Project Summary"
        '
        'TextBox20
        '
        Me.TextBox20.CanGrow = True
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.40250125527381897R), Telerik.Reporting.Drawing.Unit.Cm(1.1000000238418579R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox20.Style.Font.Bold = True
        Me.TextBox20.Style.Font.Name = "Open Sans"
        Me.TextBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox20.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox20.Value = "Project Details"
        '
        'TextBox21
        '
        Me.TextBox21.CanGrow = True
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.47624999284744263R), Telerik.Reporting.Drawing.Unit.Cm(9.09999942779541R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox21.Style.Font.Name = "Open Sans"
        Me.TextBox21.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox21.Value = "Profit:"
        '
        'TextBox22
        '
        Me.TextBox22.CanGrow = True
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39999979734420776R), Telerik.Reporting.Drawing.Unit.Cm(10.100000381469727R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox22.Style.Font.Name = "Open Sans"
        Me.TextBox22.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox22.Value = "Tender Type:"
        '
        'TextBox23
        '
        Me.TextBox23.CanGrow = True
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.55562496185302734R), Telerik.Reporting.Drawing.Unit.Cm(15.0R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox23.Style.Font.Name = "Open Sans"
        Me.TextBox23.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox23.Value = "Labour"
        '
        'TextBox24
        '
        Me.TextBox24.CanGrow = True
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.47624999284744263R), Telerik.Reporting.Drawing.Unit.Cm(11.09999942779541R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox24.Style.Font.Name = "Open Sans"
        Me.TextBox24.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox24.Value = "VAT:"
        '
        'TextBox25
        '
        Me.TextBox25.CanGrow = True
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.55562496185302734R), Telerik.Reporting.Drawing.Unit.Cm(11.799999237060547R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox25.Style.Font.Name = "Open Sans"
        Me.TextBox25.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox25.Value = "Discount:"
        '
        'TextBox26
        '
        Me.TextBox26.CanGrow = True
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.47624999284744263R), Telerik.Reporting.Drawing.Unit.Cm(12.800000190734863R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(14.423749923706055R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox26.Style.Font.Bold = True
        Me.TextBox26.Style.Font.Name = "Open Sans"
        Me.TextBox26.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox26.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox26.Value = "Resource Break-down two versions required for VAT"
        '
        'TextBox27
        '
        Me.TextBox27.CanGrow = True
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.55562496185302734R), Telerik.Reporting.Drawing.Unit.Cm(13.90000057220459R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox27.Style.Font.Bold = True
        Me.TextBox27.Style.Font.Name = "Open Sans"
        Me.TextBox27.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox27.Value = "Resource"
        '
        'TextBox28
        '
        Me.TextBox28.CanGrow = True
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.55562496185302734R), Telerik.Reporting.Drawing.Unit.Cm(16.500200271606445R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.58979237079620361R))
        Me.TextBox28.Style.Font.Name = "Open Sans"
        Me.TextBox28.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox28.Value = "Materials"
        '
        'TextBox29
        '
        Me.TextBox29.CanGrow = True
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.63499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(17.19999885559082R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox29.Style.Font.Name = "Open Sans"
        Me.TextBox29.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox29.Value = "Plant & Equipment"
        '
        'TextBox30
        '
        Me.TextBox30.CanGrow = True
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.63499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(15.899999618530273R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox30.Style.Font.Name = "Open Sans"
        Me.TextBox30.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox30.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox30.Value = "+VAT"
        '
        'TextBox31
        '
        Me.TextBox31.CanGrow = True
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.2999999523162842R), Telerik.Reporting.Drawing.Unit.Cm(17.800199508666992R))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox31.Style.Font.Name = "Open Sans"
        Me.TextBox31.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox31.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox31.Value = "+VAT"
        '
        'TextBox32
        '
        Me.TextBox32.CanGrow = True
        Me.TextBox32.Format = "{0:P2}"
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.8737497329711914R), Telerik.Reporting.Drawing.Unit.Cm(8.2814579010009766R))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox32.Style.Font.Name = "Open Sans"
        Me.TextBox32.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox32.Value = "=Fields.overheadPercent/100"
        '
        'TextBox33
        '
        Me.TextBox33.CanGrow = True
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.085416316986084R), Telerik.Reporting.Drawing.Unit.Cm(10.0R))
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox33.Style.Font.Name = "Open Sans"
        Me.TextBox33.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox33.Value = "=Fields.tenderType"
        '
        'TextBox34
        '
        Me.TextBox34.CanGrow = True
        Me.TextBox34.Format = "{0:P2}"
        Me.TextBox34.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.2000002861022949R), Telerik.Reporting.Drawing.Unit.Cm(11.0R))
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox34.Style.Font.Name = "Open Sans"
        Me.TextBox34.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox34.Value = "=Fields.VATRate/100"
        '
        'TextBox35
        '
        Me.TextBox35.CanGrow = True
        Me.TextBox35.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.2970833778381348R), Telerik.Reporting.Drawing.Unit.Cm(11.699999809265137R))
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox35.Style.Font.Name = "Open Sans"
        Me.TextBox35.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox35.Value = "=IIF(Fields.incDiscount, '2.5%', 'None')"
        '
        'TextBox36
        '
        Me.TextBox36.CanGrow = True
        Me.TextBox36.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.085416316986084R), Telerik.Reporting.Drawing.Unit.Cm(15.0R))
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox36.Style.Font.Name = "Open Sans"
        Me.TextBox36.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox36.Value = "=Fields.labourCost"
        '
        'TextBox37
        '
        Me.TextBox37.CanGrow = True
        Me.TextBox37.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.2970833778381348R), Telerik.Reporting.Drawing.Unit.Cm(16.500200271606445R))
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox37.Style.Font.Name = "Open Sans"
        Me.TextBox37.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox37.Value = "=Fields.materialCost"
        '
        'TextBox38
        '
        Me.TextBox38.CanGrow = True
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.3764581680297852R), Telerik.Reporting.Drawing.Unit.Cm(17.19999885559082R))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox38.Style.Font.Name = "Open Sans"
        Me.TextBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox38.Value = "=Fields.plantCost"
        '
        'TextBox39
        '
        Me.TextBox39.CanGrow = True
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.7999997138977051R), Telerik.Reporting.Drawing.Unit.Cm(15.600200653076172R))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox39.Style.Font.Name = "Open Sans"
        Me.TextBox39.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox39.Value = "=Fields.labourCost * (Fields.VATRate/100)"
        '
        'TextBox40
        '
        Me.TextBox40.CanGrow = True
        Me.TextBox40.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.8791666030883789R), Telerik.Reporting.Drawing.Unit.Cm(17.899999618530273R))
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox40.Style.Font.Name = "Open Sans"
        Me.TextBox40.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox40.Value = "=Fields.plantCost * (Fields.VATRate/100)"
        '
        'TextBox41
        '
        Me.TextBox41.CanGrow = True
        Me.TextBox41.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.4558329582214355R), Telerik.Reporting.Drawing.Unit.Cm(18.80000114440918R))
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox41.Style.Font.Name = "Open Sans"
        Me.TextBox41.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox41.Value = "=Fields.plantCost"
        '
        'TextBox42
        '
        Me.TextBox42.CanGrow = True
        Me.TextBox42.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R), Telerik.Reporting.Drawing.Unit.Cm(18.80000114440918R))
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox42.Style.Font.Name = "Open Sans"
        Me.TextBox42.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox42.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox42.Value = "Sundry Items"
        '
        'TextBox43
        '
        Me.TextBox43.CanGrow = True
        Me.TextBox43.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.70000004768371582R), Telerik.Reporting.Drawing.Unit.Cm(19.5R))
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox43.Style.Font.Name = "Open Sans"
        Me.TextBox43.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox43.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox43.Value = "Ad-hoc Costs"
        '
        'TextBox44
        '
        Me.TextBox44.CanGrow = True
        Me.TextBox44.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.4414582252502441R), Telerik.Reporting.Drawing.Unit.Cm(19.5R))
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox44.Style.Font.Name = "Open Sans"
        Me.TextBox44.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox44.Value = "=Fields.plantCost"
        '
        'TextBox45
        '
        Me.TextBox45.CanGrow = True
        Me.TextBox45.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.5000004768371582R), Telerik.Reporting.Drawing.Unit.Cm(20.30000114440918R))
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox45.Style.Font.Name = "Open Sans"
        Me.TextBox45.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox45.Value = "=Fields.plantCost"
        '
        'TextBox46
        '
        Me.TextBox46.CanGrow = True
        Me.TextBox46.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.75854218006134033R), Telerik.Reporting.Drawing.Unit.Cm(20.30000114440918R))
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox46.Style.Font.Name = "Open Sans"
        Me.TextBox46.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox46.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox46.Value = "Subtotal"
        '
        'TextBox48
        '
        Me.TextBox48.CanGrow = True
        Me.TextBox48.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.63499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(21.299999237060547R))
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox48.Style.Font.Bold = True
        Me.TextBox48.Style.Font.Name = "Open Sans"
        Me.TextBox48.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox48.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox48.Value = "Profit & Overheads"
        '
        'TextBox49
        '
        Me.TextBox49.CanGrow = True
        Me.TextBox49.Format = "{0:C2}"
        Me.TextBox49.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.5352082252502441R), Telerik.Reporting.Drawing.Unit.Cm(22.19502067565918R))
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox49.Style.Font.Name = "Open Sans"
        Me.TextBox49.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox49.Value = "=Fields.overhead"
        '
        'TextBox50
        '
        Me.TextBox50.CanGrow = True
        Me.TextBox50.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.793749988079071R), Telerik.Reporting.Drawing.Unit.Cm(22.19502067565918R))
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox50.Style.Font.Name = "Open Sans"
        Me.TextBox50.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox50.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox50.Value = "='Overhead (' + Fields.overheadPercent + '%)'"
        '
        'TextBox51
        '
        Me.TextBox51.CanGrow = True
        Me.TextBox51.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.800000011920929R), Telerik.Reporting.Drawing.Unit.Cm(22.948970794677734R))
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox51.Style.Font.Name = "Open Sans"
        Me.TextBox51.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox51.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox51.Value = "='Profit (' + Fields.profitPercent + '%)'"
        '
        'TextBox52
        '
        Me.TextBox52.CanGrow = True
        Me.TextBox52.Format = "{0:C2}"
        Me.TextBox52.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.5414581298828125R), Telerik.Reporting.Drawing.Unit.Cm(22.948970794677734R))
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox52.Style.Font.Name = "Open Sans"
        Me.TextBox52.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox52.Value = "=Fields.profit"
        '
        'TextBox47
        '
        Me.TextBox47.CanGrow = True
        Me.TextBox47.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.793749988079071R), Telerik.Reporting.Drawing.Unit.Cm(23.799999237060547R))
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox47.Style.Font.Name = "Open Sans"
        Me.TextBox47.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox47.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox47.Value = "Subtotal"
        '
        'TextBox53
        '
        Me.TextBox53.CanGrow = True
        Me.TextBox53.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.5352082252502441R), Telerik.Reporting.Drawing.Unit.Cm(23.799999237060547R))
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox53.Style.Font.Name = "Open Sans"
        Me.TextBox53.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox53.Value = "=Fields.plantCost"
        '
        'TextBox54
        '
        Me.TextBox54.CanGrow = True
        Me.TextBox54.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.6145830154418945R), Telerik.Reporting.Drawing.Unit.Cm(27.468606948852539R))
        Me.TextBox54.Name = "TextBox54"
        Me.TextBox54.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox54.Style.Font.Name = "Open Sans"
        Me.TextBox54.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox54.Value = "=Fields.plantCost"
        '
        'TextBox55
        '
        Me.TextBox55.CanGrow = True
        Me.TextBox55.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.87312495708465576R), Telerik.Reporting.Drawing.Unit.Cm(27.468606948852539R))
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox55.Style.Font.Name = "Open Sans"
        Me.TextBox55.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox55.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox55.Value = "Subtotal"
        '
        'TextBox56
        '
        Me.TextBox56.CanGrow = True
        Me.TextBox56.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.6145830154418945R), Telerik.Reporting.Drawing.Unit.Cm(26.621921539306641R))
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox56.Style.Font.Name = "Open Sans"
        Me.TextBox56.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox56.Value = "=Fields.plantCost"
        '
        'TextBox57
        '
        Me.TextBox57.CanGrow = True
        Me.TextBox57.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.87312495708465576R), Telerik.Reporting.Drawing.Unit.Cm(26.621921539306641R))
        Me.TextBox57.Name = "TextBox57"
        Me.TextBox57.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox57.Style.Font.Name = "Open Sans"
        Me.TextBox57.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox57.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox57.Value = "Discount (2.5%)"
        '
        'TextBox58
        '
        Me.TextBox58.CanGrow = True
        Me.TextBox58.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.87312495708465576R), Telerik.Reporting.Drawing.Unit.Cm(25.854621887207031R))
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox58.Style.Font.Name = "Open Sans"
        Me.TextBox58.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox58.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox58.Value = "Contractor"
        '
        'TextBox59
        '
        Me.TextBox59.CanGrow = True
        Me.TextBox59.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.6145830154418945R), Telerik.Reporting.Drawing.Unit.Cm(25.854621887207031R))
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox59.Style.Font.Name = "Open Sans"
        Me.TextBox59.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox59.Value = "=Fields.plantCost"
        '
        'TextBox60
        '
        Me.TextBox60.CanGrow = True
        Me.TextBox60.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R), Telerik.Reporting.Drawing.Unit.Cm(24.955039978027344R))
        Me.TextBox60.Name = "TextBox60"
        Me.TextBox60.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox60.Style.Font.Bold = True
        Me.TextBox60.Style.Font.Name = "Open Sans"
        Me.TextBox60.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox60.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox60.Value = "Additions"
        '
        'TextBox61
        '
        Me.TextBox61.CanGrow = True
        Me.TextBox61.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.89999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(28.27311897277832R))
        Me.TextBox61.Name = "TextBox61"
        Me.TextBox61.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.7412581443786621R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox61.Style.Font.Bold = True
        Me.TextBox61.Style.Font.Name = "Open Sans"
        Me.TextBox61.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox61.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox61.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox61.Value = "Proposed Bid"
        '
        'TextBox62
        '
        Me.TextBox62.CanGrow = True
        Me.TextBox62.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.6414580345153809R), Telerik.Reporting.Drawing.Unit.Cm(28.27311897277832R))
        Me.TextBox62.Name = "TextBox62"
        Me.TextBox62.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox62.Style.Font.Name = "Open Sans"
        Me.TextBox62.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox62.Value = "=Fields.plantCost"
        '
        'TextBox63
        '
        Me.TextBox63.CanGrow = True
        Me.TextBox63.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.75854134559631348R), Telerik.Reporting.Drawing.Unit.Cm(30.638322830200195R))
        Me.TextBox63.Name = "TextBox63"
        Me.TextBox63.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.3499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.TextBox63.Style.Font.Bold = True
        Me.TextBox63.Style.Font.Name = "Open Sans"
        Me.TextBox63.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox63.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox63.Value = "Adjusting Profit"
        '
        'TextBox64
        '
        Me.TextBox64.CanGrow = True
        Me.TextBox64.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.79999959468841553R), Telerik.Reporting.Drawing.Unit.Cm(31.452484130859375R))
        Me.TextBox64.Name = "TextBox64"
        Me.TextBox64.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9000002145767212R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox64.Style.Font.Name = "Open Sans"
        Me.TextBox64.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox64.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox64.Value = "Profit %"
        '
        'TextBox65
        '
        Me.TextBox65.CanGrow = True
        Me.TextBox65.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.87312495708465576R), Telerik.Reporting.Drawing.Unit.Cm(29.855625152587891R))
        Me.TextBox65.Name = "TextBox65"
        Me.TextBox65.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.0268754959106445R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox65.Style.Font.Bold = True
        Me.TextBox65.Style.Font.Name = "Open Sans"
        Me.TextBox65.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox65.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox65.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox65.Value = "Applying Bid Adjustment %"
        '
        'TextBox66
        '
        Me.TextBox66.CanGrow = True
        Me.TextBox66.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.800000011920929R), Telerik.Reporting.Drawing.Unit.Cm(32.146659851074219R))
        Me.TextBox66.Name = "TextBox66"
        Me.TextBox66.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9000002145767212R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox66.Style.Font.Name = "Open Sans"
        Me.TextBox66.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox66.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox66.Value = "10%"
        '
        'TextBox67
        '
        Me.TextBox67.CanGrow = True
        Me.TextBox67.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.800000011920929R), Telerik.Reporting.Drawing.Unit.Cm(32.834579467773438R))
        Me.TextBox67.Name = "TextBox67"
        Me.TextBox67.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9000002145767212R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox67.Style.Font.Name = "Open Sans"
        Me.TextBox67.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox67.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox67.Value = "13%"
        '
        'TextBox68
        '
        Me.TextBox68.CanGrow = True
        Me.TextBox68.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.800000011920929R), Telerik.Reporting.Drawing.Unit.Cm(33.522495269775391R))
        Me.TextBox68.Name = "TextBox68"
        Me.TextBox68.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9000002145767212R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox68.Style.Font.Name = "Open Sans"
        Me.TextBox68.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox68.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox68.Value = "15%"
        '
        'TextBox69
        '
        Me.TextBox69.CanGrow = True
        Me.TextBox69.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.9000000953674316R), Telerik.Reporting.Drawing.Unit.Cm(31.452484130859375R))
        Me.TextBox69.Name = "TextBox69"
        Me.TextBox69.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox69.Style.Font.Name = "Open Sans"
        Me.TextBox69.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox69.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox69.Value = "+-%"
        '
        'TextBox70
        '
        Me.TextBox70.CanGrow = True
        Me.TextBox70.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.9000000953674316R), Telerik.Reporting.Drawing.Unit.Cm(33.5099983215332R))
        Me.TextBox70.Name = "TextBox70"
        Me.TextBox70.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox70.Style.Font.Name = "Open Sans"
        Me.TextBox70.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox70.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox70.Value = "15%"
        '
        'TextBox71
        '
        Me.TextBox71.CanGrow = True
        Me.TextBox71.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.9000000953674316R), Telerik.Reporting.Drawing.Unit.Cm(32.82208251953125R))
        Me.TextBox71.Name = "TextBox71"
        Me.TextBox71.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox71.Style.Font.Name = "Open Sans"
        Me.TextBox71.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox71.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox71.Value = "13%"
        '
        'TextBox72
        '
        Me.TextBox72.CanGrow = True
        Me.TextBox72.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.9000000953674316R), Telerik.Reporting.Drawing.Unit.Cm(32.1341667175293R))
        Me.TextBox72.Name = "TextBox72"
        Me.TextBox72.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox72.Style.Font.Name = "Open Sans"
        Me.TextBox72.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox72.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox72.Value = "10%"
        '
        'TextBox73
        '
        Me.TextBox73.CanGrow = True
        Me.TextBox73.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.2000002861022949R), Telerik.Reporting.Drawing.Unit.Cm(32.1341667175293R))
        Me.TextBox73.Name = "TextBox73"
        Me.TextBox73.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox73.Style.Font.Name = "Open Sans"
        Me.TextBox73.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox73.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox73.Value = "10%"
        '
        'TextBox74
        '
        Me.TextBox74.CanGrow = True
        Me.TextBox74.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.2000002861022949R), Telerik.Reporting.Drawing.Unit.Cm(32.82208251953125R))
        Me.TextBox74.Name = "TextBox74"
        Me.TextBox74.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox74.Style.Font.Name = "Open Sans"
        Me.TextBox74.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox74.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox74.Value = "13%"
        '
        'TextBox75
        '
        Me.TextBox75.CanGrow = True
        Me.TextBox75.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.2000002861022949R), Telerik.Reporting.Drawing.Unit.Cm(33.5099983215332R))
        Me.TextBox75.Name = "TextBox75"
        Me.TextBox75.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox75.Style.Font.Name = "Open Sans"
        Me.TextBox75.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox75.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox75.Value = "15%"
        '
        'TextBox76
        '
        Me.TextBox76.CanGrow = True
        Me.TextBox76.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.2000002861022949R), Telerik.Reporting.Drawing.Unit.Cm(31.446249008178711R))
        Me.TextBox76.Name = "TextBox76"
        Me.TextBox76.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox76.Style.Font.Name = "Open Sans"
        Me.TextBox76.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox76.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox76.Value = "Profit Adjustment"
        '
        'TextBox77
        '
        Me.TextBox77.CanGrow = True
        Me.TextBox77.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.40000057220459R), Telerik.Reporting.Drawing.Unit.Cm(31.397491455078125R))
        Me.TextBox77.Name = "TextBox77"
        Me.TextBox77.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox77.Style.Font.Name = "Open Sans"
        Me.TextBox77.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox77.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox77.Value = "Profit"
        '
        'TextBox78
        '
        Me.TextBox78.CanGrow = True
        Me.TextBox78.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.40000057220459R), Telerik.Reporting.Drawing.Unit.Cm(33.46124267578125R))
        Me.TextBox78.Name = "TextBox78"
        Me.TextBox78.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox78.Style.Font.Name = "Open Sans"
        Me.TextBox78.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox78.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox78.Value = "15%"
        '
        'TextBox79
        '
        Me.TextBox79.CanGrow = True
        Me.TextBox79.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.40000057220459R), Telerik.Reporting.Drawing.Unit.Cm(32.773323059082031R))
        Me.TextBox79.Name = "TextBox79"
        Me.TextBox79.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox79.Style.Font.Name = "Open Sans"
        Me.TextBox79.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox79.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox79.Value = "13%"
        '
        'TextBox80
        '
        Me.TextBox80.CanGrow = True
        Me.TextBox80.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.40000057220459R), Telerik.Reporting.Drawing.Unit.Cm(32.085407257080078R))
        Me.TextBox80.Name = "TextBox80"
        Me.TextBox80.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox80.Style.Font.Name = "Open Sans"
        Me.TextBox80.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox80.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox80.Value = "10%"
        '
        'TextBox81
        '
        Me.TextBox81.CanGrow = True
        Me.TextBox81.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.300000190734863R), Telerik.Reporting.Drawing.Unit.Cm(32.081249237060547R))
        Me.TextBox81.Name = "TextBox81"
        Me.TextBox81.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox81.Style.Font.Name = "Open Sans"
        Me.TextBox81.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox81.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox81.Value = "10%"
        '
        'TextBox82
        '
        Me.TextBox82.CanGrow = True
        Me.TextBox82.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.300000190734863R), Telerik.Reporting.Drawing.Unit.Cm(32.7691650390625R))
        Me.TextBox82.Name = "TextBox82"
        Me.TextBox82.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox82.Style.Font.Name = "Open Sans"
        Me.TextBox82.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox82.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox82.Value = "13%"
        '
        'TextBox83
        '
        Me.TextBox83.CanGrow = True
        Me.TextBox83.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.300000190734863R), Telerik.Reporting.Drawing.Unit.Cm(33.457080841064453R))
        Me.TextBox83.Name = "TextBox83"
        Me.TextBox83.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox83.Style.Font.Name = "Open Sans"
        Me.TextBox83.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox83.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox83.Value = "15%"
        '
        'TextBox84
        '
        Me.TextBox84.CanGrow = True
        Me.TextBox84.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.300000190734863R), Telerik.Reporting.Drawing.Unit.Cm(31.393331527709961R))
        Me.TextBox84.Name = "TextBox84"
        Me.TextBox84.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611R))
        Me.TextBox84.Style.Font.Name = "Open Sans"
        Me.TextBox84.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TextBox84.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox84.Value = "Revised Bid"
        '
        'ProjectSummary
        '
        Me.DataSource = Me.SqlDataSource1
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detail})
        Me.Name = "ProjectSummary"
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(15.99990177154541R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox31 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox33 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox34 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox35 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox36 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox37 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox40 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox41 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox42 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox43 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox44 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox45 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox46 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox48 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox49 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox50 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox51 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox52 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox47 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox53 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox54 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox55 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox56 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox57 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox58 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox59 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox60 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox61 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox62 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox63 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox64 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox65 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox66 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox67 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox68 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox69 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox70 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox71 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox72 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox73 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox74 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox75 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox76 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox77 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox78 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox79 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox80 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox81 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox82 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox83 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox84 As Telerik.Reporting.TextBox
End Class