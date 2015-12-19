Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class NewCompany
    Inherits Telerik.Reporting.Report

    Private filepath As String

    Public Sub New()
        'filepath = "C:\HostingSpaces\getbuild\buildmateapp.com\wwwroot\report_assets\"
        filepath = "C:\HostingSpaces\getbuild\dev.buildmateapp.com\wwwroot\report_assets\"
        InitializeComponent()
    End Sub

    Private Sub NewCompany_ItemDataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ItemDataBinding
        Dim TermsOfUse As Integer = Convert.ToInt16(Me.ReportParameters("TermsOfUse").Value)
        'Conversions.ToInteger(Me.ReportParameters("TermsOfUse").Value)
        If (TermsOfUse = 1 Or TermsOfUse = 2) Then
            Dim termsfile As String = String.Concat(Me.filepath, "terms_small_print.txt")
            If (TermsOfUse = 2) Then
                termsfile = String.Concat(Me.filepath, "terms_large_print.txt")
            End If
            Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(termsfile)
            Dim filecontent As String = streamReader.ReadToEnd()
            streamReader.Close()
            Me.HtmlTextBox10.Value = String.Format(filecontent, New Object(0) {})
            Me.ReportFooterSection1.Visible = True
        End If

        Dim incVat As Integer = Convert.ToInt16(Me.ReportParameters("incVAT").Value)
        If incVat Then
            TextBox19.Value = "Subtotal"
            TextBox16.Visible = True
            TextBox17.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
        Else
            TextBox16.Visible = False
            TextBox17.Visible = False
            TextBox1.Visible = False
            TextBox2.Visible = False
        End If
    End Sub
End Class