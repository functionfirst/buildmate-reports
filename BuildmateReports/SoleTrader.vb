Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class SoleTrader
    Inherits Telerik.Reporting.Report

    Private filepath As String

    Public Sub New()
        'filepath = "C:\HostingSpaces\getbuild\buildmateapp.com\wwwroot\report_assets\"
        filepath = "C:\HostingSpaces\getbuild\dev.buildmateapp.com\wwwroot\report_assets\"
        InitializeComponent()
    End Sub

    Public Shared Function formatCurrency(ByVal value As Decimal) As String
        Return String.Format("{0:C2}", value)
    End Function

    Private Sub SoleTrader_ItemDataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ItemDataBinding
        Dim TermsOfUse As Integer = Convert.ToInt16(Me.ReportParameters("TermsOfUse").Value)
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
            TextBox19.Value = "Total"
        End If
    End Sub
End Class