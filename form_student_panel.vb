Imports System.Data.Odbc
Public Class form_student_panel
    Dim username As String = form_login.textbox_username.Text
    Private Sub form_student_panel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim COMMAND As New OdbcCommand
            Dim connection As New OdbcConnection
            Dim DATA_TABLE As New DataTable
            connection = New OdbcConnection("dsn=ems;user=root;password=root")
            connection.Open()

            'list of upcoming schedules
            COMMAND = New OdbcCommand("select distinct(examtype) from schedule", connection)
            Dim data_reader As OdbcDataReader = COMMAND.ExecuteReader
            combobox_schedulelist.Items.Clear()
            While data_reader.Read
                combobox_schedulelist.Items.Add(data_reader(0))
            End While

            'list of applied exams to further generate admit cards
            ADAPTER = New OdbcDataAdapter("select distinct(examtype) from exam where rollno = '" & Convert.ToString(username) & "' ", connection)
            ADAPTER.Fill(DATA_TABLE)
            datagridview_admitlist.DataSource = DATA_TABLE

            'list of appeared exams to generate marksheets from
            COMMAND = New OdbcCommand("select distinct(examtype) from result where rollno = '" & Convert.ToString(username) & "' ", connection)
            data_reader = COMMAND.ExecuteReader
            combobox_marksheet.Items.Clear()
            While data_reader.Read
                combobox_marksheet.Items.Add(data_reader(0))
            End While
            connection.Close()
        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
    End Sub

    Private Sub button_apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_apply.Click
        Try
            Dim COMMAND As New OdbcCommand
            Dim connection As New OdbcConnection

            connection = New OdbcConnection("dsn=ems;user=root;password=root")
            connection.Open()

            'create table exam(examid int(10), examtype varchar(20), rollno int(3), PRIMARY KEY(examid));
            'Try
            'COMMAND = New OdbcCommand("SELECT max(examid) from exam", connection)
            'DATA_READER = COMMAND.ExecuteReader
            'DATA_READER.Read()
            'examid = Convert.ToInt64(DATA_READER(0))
            'examid = examid + 1
            'MsgBox(Convert.ToString(examid))
            'Catch ex As Exception
            'examid = 1
            'MsgBox(Convert.ToString(examid))
            'End Try

            'Try
            'COMMAND = New OdbcCommand("insert into exam VALUES ('" & Convert.ToString(examid) & "','" & combobox_schedulelist.Text & "','" & Convert.ToString(username) & "')", connection)
            'COMMAND.ExecuteNonQuery()
            'MsgBox("You have succesfully applied for this exam!")
            'Catch ex As Exception
            'MsgBox("You have already applied for this exam!")
            'End Try
            'connection.Close()

            Try
                COMMAND = New OdbcCommand("select * from exam where examtype = '" & combobox_schedulelist.Text & "' and rollno = '" & Convert.ToString(username) & "' ", connection)
                DATA_READER = COMMAND.ExecuteReader
                DATA_READER.Read()
                MsgBox("You have already applied for this exam!")
            Catch ex As Exception
                'create table exam(examid int AUTO_INCREMENT primary key NOT NULL, examtype varchar(20), rollno int(3));
                COMMAND = New OdbcCommand("insert into exam (examtype, rollno) VALUES ('" & combobox_schedulelist.Text & "','" & Convert.ToString(username) & "')", connection)
                COMMAND.ExecuteNonQuery()
                MsgBox("You have succesfully applied for this exam!")
            End Try


            connection.Close()
            form_student_panel_Load(sender, e)
            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try
    End Sub

    Private Sub combobox_schedulelist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combobox_schedulelist.SelectedIndexChanged
        Try
            Dim COMMAND As New OdbcCommand
            Dim connection As New OdbcConnection
            Dim ADAPTER As New OdbcDataAdapter
            Dim DATA_TABLE As New DataTable

            connection = New OdbcConnection("dsn=ems;user=root;password=root")
            connection.Open()

            ADAPTER = New OdbcDataAdapter("select subject as Subjects, date as Dates from schedule where examtype = '" & combobox_schedulelist.Text & "'", connection)
            ADAPTER.Fill(DATA_TABLE)
            datagridview_schedule.DataSource = DATA_TABLE

            connection.Close()

        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
    End Sub

    Private Sub button_generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_generate.Click
        FORM_ADMIT_VIEW.Show()
    End Sub

    Private Sub combobox_marksheet_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combobox_marksheet.SelectedIndexChanged
        Try
            Dim COMMAND As New OdbcCommand
            Dim connection As New OdbcConnection
            Dim ADAPTER As New OdbcDataAdapter
            Dim DATA_TABLE As New DataTable

            connection = New OdbcConnection("dsn=ems;user=root;password=root")
            connection.Open()

            ADAPTER = New OdbcDataAdapter("select subject as Subjects, marks as Marks from result where examtype = '" & combobox_marksheet.Text & "' and rollno = '" & Convert.ToString(username) & "'", connection)
            ADAPTER.Fill(DATA_TABLE)
            datagridview_marksheet.DataSource = DATA_TABLE

            COMMAND = New OdbcCommand("select marks from result where examtype = '" & combobox_marksheet.Text & "' and rollno = '" & form_login.textbox_username.Text & "' ", connection)
            Dim data_reader As OdbcDataReader = COMMAND.ExecuteReader
            textbox_resulttext.Visible = True
            textbox_resultstatus.Visible = True
            While data_reader.Read
                If Convert.ToInt64(data_reader(0)) < 25 Then
                    textbox_resultstatus.Text = "    FAIL"
                    Exit While
                Else
                    textbox_resultstatus.Text = "    PASS"
                End If
            End While

            Dim total As Integer = 0
            COMMAND = New OdbcCommand("select marks from result where examtype = '" & combobox_marksheet.Text & "' and rollno = '" & form_login.textbox_username.Text & "' ", connection)
            data_reader = COMMAND.ExecuteReader
            While data_reader.Read
                total += Convert.ToInt64(data_reader(0))
            End While

            textbox_grandtext.Visible = True
            textbox_grandtotal.Visible = True
            textbox_grandtotal.Text = "     " + Convert.ToString(total)

            connection.Close()

        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
    End Sub

    Private Sub button_marksheet_generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_marksheet_generate.Click
        label_referrer.Text = "STUDENT"
        form_admin_panel.label_referrer.Text = "STUDENT"
        FORM_MARKSHEET_VIEW.Show()
    End Sub
End Class