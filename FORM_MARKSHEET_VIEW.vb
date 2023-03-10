'https://www.dotnetspider.com/resources/630-For-passing-parameter-from-TextBox-Crystal-repo.aspx
'https://www.sitepoint.com/community/t/how-can-i-pass-parameter-to-crystal-report-in-vb-net/4447
Imports System.Data.Odbc

Public Class FORM_MARKSHEET_VIEW

    Dim total As Integer = 0

    Private Sub FORM_MARKSHEET_VIEW_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim COMMAND As New OdbcCommand
            Dim connection As New OdbcConnection
            connection = New OdbcConnection("dsn=ems;user=root;pwd=root")
            connection.Open()

            If form_admin_panel.label_referrer.Text = "ADMIN" And form_student_panel.label_referrer.Text = "ADMIN" Then

                Dim resultstatus As String = "NULL"
                COMMAND = New OdbcCommand("select marks from result where examtype = '" & form_admin_panel.combobox_resultsearch.Text & "' and rollno = '" & form_admin_panel.textbox_search.Text & "' ", connection)
                Dim data_reader As OdbcDataReader = COMMAND.ExecuteReader
                While data_reader.Read
                    If Convert.ToInt64(data_reader(0)) < 25 Then
                        resultstatus = "    FAIL"
                        Exit While
                    Else
                        resultstatus = "    PASS"
                    End If
                End While

                COMMAND = New OdbcCommand("select marks from result where examtype = '" & form_admin_panel.combobox_resultsearch.Text & "' and rollno = '" & form_admin_panel.textbox_search.Text & "' ", connection)
                data_reader = COMMAND.ExecuteReader
                While data_reader.Read
                    total += Convert.ToInt64(data_reader(0))
                End While

                Dim PARAM1FILEDS As New CrystalDecisions.Shared.ParameterFields
                Dim PARAM1FIELD As New CrystalDecisions.Shared.ParameterField
                Dim PARAM1RANGE As New CrystalDecisions.Shared.ParameterDiscreteValue

                PARAM1FIELD.ParameterFieldName = "RESULT" ' PARAMETER NAME IN CRYSTAL REPORT
                PARAM1RANGE.Value = resultstatus          ' VALUE FOR PARAMETER FIELD 
                PARAM1FIELD.CurrentValues.Add(PARAM1RANGE)
                PARAM1FILEDS.Add(PARAM1FIELD)                   ' TO ADD PARAMETER IN PARAMETERSLIST
                CrystalReportViewer1.ParameterFieldInfo = PARAM1FILEDS 'TO PASS PARAMETER INF.TO CRV

                Dim DATA_ADAPTER As New OdbcDataAdapter("select * from result where examtype = '" & form_admin_panel.combobox_resultsearch.Text & "' and rollno = '" & form_admin_panel.textbox_search.Text & "' ", connection)
                Dim DATA_SET As New DataSet
                DATA_ADAPTER.Fill(DATA_SET)
                Dim rpath = "D:\Projects\Workspace\Exam Management System\marksheet.rpt"
                Dim doc As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                doc.Load(rpath)
                doc.SetDataSource(DATA_SET.Tables(0))
                CrystalReportViewer1.ReportSource = doc

            Else
                Dim resultstatus As String = "NULL"
                COMMAND = New OdbcCommand("select marks from result where examtype = '" & form_student_panel.combobox_marksheet.Text & "' and rollno = '" & form_login.textbox_username.Text & "' ", connection)
                Dim data_reader As OdbcDataReader = COMMAND.ExecuteReader
                While data_reader.Read
                    If Convert.ToInt64(data_reader(0)) < 25 Then
                        resultstatus = "    FAIL"
                        Exit While
                    Else
                        resultstatus = "    PASS"
                    End If
                End While

                Dim param1Fileds As New CrystalDecisions.Shared.ParameterFields
                Dim param1Field As New CrystalDecisions.Shared.ParameterField
                Dim param1Range As New CrystalDecisions.Shared.ParameterDiscreteValue

                param1Field.ParameterFieldName = "result" ' Parameter Name In Crystal Report
                param1Range.Value = resultstatus          ' value For Parameter Field 
                param1Field.CurrentValues.Add(param1Range)
                param1Fileds.Add(param1Field)                   ' To add parameter in parameterslist
                CrystalReportViewer1.ParameterFieldInfo = param1Fileds 'to pass parameter inf.to CRV

                Dim DATA_ADAPTER As New OdbcDataAdapter("select * from result where examtype = '" & form_student_panel.combobox_marksheet.Text & "' and rollno = '" & form_login.textbox_username.Text & "' ", connection)
                Dim DATA_SET As New DataSet
                DATA_ADAPTER.Fill(DATA_SET)
                Dim rpath = "D:\Projects\Workspace\Exam Management System\marksheet.rpt"
                Dim doc As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                doc.Load(rpath)
                doc.SetDataSource(DATA_SET.Tables(0))
                CrystalReportViewer1.ReportSource = doc
            End If

            connection.Close()
        Catch error_ As Exception
            MsgBox(Convert.ToString(error_))
        End Try
    End Sub
End Class