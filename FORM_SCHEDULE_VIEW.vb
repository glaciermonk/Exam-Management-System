Imports System.Data.Odbc
Public Class FORM_SCHEDULE_VIEW

    Private Sub FORM_SCHEDULE_VIEW_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim connection As New OdbcConnection
            connection = New OdbcConnection("dsn=ems;user=root;pwd=root")

            connection.Open()

            examtype = form_admin_panel.textbox_examname.Text + " " + form_admin_panel.textbox_examyear.Text
            Dim DATA_ADAPTER As New OdbcDataAdapter("select * from schedule where examtype = '" & examtype & "' ", connection)
            Dim DATA_SET As New DataSet
            DATA_ADAPTER.Fill(DATA_SET)

            Dim rpath = "D:\Projects\Workspace\Exam Management System\schedule.rpt"
            Dim doc As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            doc.Load(rpath)
            doc.SetDataSource(DATA_SET.Tables(0))
            CrystalReportViewer1.ReportSource = doc
            'CrystalReportViewer1.RefreshReport()


            connection.Close()
        Catch error_ As Exception
            MsgBox(Convert.ToString(error_))
        End Try
    End Sub
End Class