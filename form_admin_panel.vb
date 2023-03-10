Imports System.Data.Odbc
Public Class form_admin_panel

    'form load
    Private Sub form_admin_panel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim COMMAND As New OdbcCommand
        Dim connection As New OdbcConnection
        connection = New OdbcConnection("dsn=ems;user=root;password=root")
        connection.Open()
        COMMAND = New OdbcCommand("SELECT distinct(examtype) FROM schedule", connection)
        Dim data_reader As OdbcDataReader = COMMAND.ExecuteReader
        combobox_marksentry_examtype.Items.Clear()
        While data_reader.Read
            combobox_marksentry_examtype.Items.Add(data_reader(0))
            combobox_resultsearch.Items.Add(data_reader(0))
        End While
        connection.Close()
    End Sub

    'create a new student
    Private Sub button_createstudent_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_createstudent.Click
        Try
            Dim COMMAND As New OdbcCommand
            Dim connection As New OdbcConnection
            Dim ADAPTER As New OdbcDataAdapter
            Dim DATA_TABLE As New DataTable

            connection = New OdbcConnection("dsn=ems;user=root;password=root")
            connection.Open()

            'old codes
            'Try
            'COMMAND = New OdbcCommand("SELECT rollno FROM student WHERE rollno = '" & textbox_createstdrollno.Text & "' ", connection)
            'Dim data_reader As OdbcDataReader = COMMAND.ExecuteReader
            'data_reader.Read()
            'roll = data_reader(0)
            'If (roll = textbox_createstdrollno.Text) Then
            'MsgBox("Roll no Already Exists!")
            'End If
            'Catch ex As Exception
            'COMMAND = New OdbcCommand("insert into student VALUES ('" & textbox_createstdrollno.Text & "','" & textbox_createstdpassword.Text & "','" & textbox_createstdname.Text & "','" & textbox_createstdgrade.Text & "','" & textbox_createstdaddress.Text & "','" & textbox_createstdphone.Text & "','" & textbox_createstdemail.Text & "','" & textbox_createstdfather.Text & "','" & textbox_createstdmother.Text & "','" & combobox_createstdgender.Text & "')", connection)
            'COMMAND.ExecuteNonQuery()
            'MsgBox("Student Information Saved Succesfully")
            'End Try


            'updated codes
            COMMAND = New OdbcCommand("delete from student where rollno = '" & textbox_createstdrollno.Text & "' ", connection)
            COMMAND.ExecuteNonQuery()
            COMMAND = New OdbcCommand("insert into student VALUES ('" & textbox_createstdrollno.Text & "','" & textbox_createstdpassword.Text & "','" & textbox_createstdname.Text & "','" & textbox_createstdgrade.Text & "','" & textbox_createstdaddress.Text & "','" & textbox_createstdphone.Text & "','" & textbox_createstdemail.Text & "','" & textbox_createstdfather.Text & "','" & textbox_createstdmother.Text & "','" & combobox_createstdgender.Text & "')", connection)
            COMMAND.ExecuteNonQuery()
            MsgBox("Student Information Saved Succesfully")

            connection.Close()

            textbox_createstdname.Clear()
            textbox_createstdrollno.Clear()
            textbox_createstdpassword.Clear()
            textbox_createstdgrade.Clear()
            textbox_createstdemail.Clear()
            textbox_createstdphone.Clear()
            textbox_createstdfather.Clear()
            textbox_createstdmother.Clear()
            combobox_createstdgender.Text = ""
            textbox_createstdaddress.Clear()


        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
    End Sub

    'search/view students' details
    Private Sub button_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_search.Click
        Try
            Dim COMMAND As New OdbcCommand
            Dim connection As New OdbcConnection
            Dim DATA_READER As OdbcDataReader
            Dim ADAPTER As New OdbcDataAdapter
            Dim DATA_TABLE As New DataTable

            connection = New OdbcConnection("dsn=ems;user=root;password=root")
            connection.Open()

            COMMAND = New OdbcCommand("SELECT name FROM student WHERE rollno = '" & textbox_search.Text & "'", connection)
            DATA_READER = COMMAND.ExecuteReader
            DATA_READER.Read()
            textbox_createstdname.Text = DATA_READER(0)

            COMMAND = New OdbcCommand("SELECT email FROM student WHERE rollno = '" & textbox_search.Text & "'", connection)
            DATA_READER = COMMAND.ExecuteReader
            DATA_READER.Read()
            textbox_createstdemail.Text = DATA_READER(0)

            COMMAND = New OdbcCommand("SELECT phone FROM student WHERE rollno = '" & textbox_search.Text & "'", connection)
            DATA_READER = COMMAND.ExecuteReader
            DATA_READER.Read()
            textbox_createstdphone.Text = DATA_READER(0)

            COMMAND = New OdbcCommand("SELECT fathers_name FROM student WHERE rollno = '" & textbox_search.Text & "'", connection)
            DATA_READER = COMMAND.ExecuteReader
            DATA_READER.Read()
            textbox_createstdfather.Text = DATA_READER(0)

            COMMAND = New OdbcCommand("SELECT mothers_name FROM student WHERE rollno = '" & textbox_search.Text & "'", connection)
            DATA_READER = COMMAND.ExecuteReader
            DATA_READER.Read()
            textbox_createstdmother.Text = DATA_READER(0)

            COMMAND = New OdbcCommand("SELECT address FROM student WHERE rollno = '" & textbox_search.Text & "'", connection)
            DATA_READER = COMMAND.ExecuteReader
            DATA_READER.Read()
            textbox_createstdaddress.Text = DATA_READER(0)

            COMMAND = New OdbcCommand("SELECT grade FROM student WHERE rollno = '" & textbox_search.Text & "'", connection)
            DATA_READER = COMMAND.ExecuteReader
            DATA_READER.Read()
            textbox_createstdgrade.Text = DATA_READER(0)

            COMMAND = New OdbcCommand("SELECT password FROM student WHERE rollno = '" & textbox_search.Text & "'", connection)
            DATA_READER = COMMAND.ExecuteReader
            DATA_READER.Read()
            textbox_createstdpassword.Text = DATA_READER(0)

            COMMAND = New OdbcCommand("SELECT gender FROM student WHERE rollno = '" & textbox_search.Text & "'", connection)
            DATA_READER = COMMAND.ExecuteReader
            DATA_READER.Read()
            If (DATA_READER(0) = "Male") Then
                combobox_createstdgender.Text = "Male"
            Else
                combobox_createstdgender.Text = "Female"
            End If

            textbox_createstdrollno.Text = textbox_search.Text

            COMMAND = New OdbcCommand("SELECT examtype FROM exam WHERE rollno = '" & textbox_search.Text & "' ", connection)
            Dim data_reader2 As OdbcDataReader = COMMAND.ExecuteReader
            combobox_resultsearch.Items.Clear()
            While data_reader2.Read
                combobox_resultsearch.Items.Add(data_reader2(0))
            End While

            connection.Close()
        Catch ex As Exception
            MsgBox("Student not found!")
        End Try
    End Sub

    'combobox to list a student's exam records list
    Private Sub combobox_resultsearch_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combobox_resultsearch.SelectedIndexChanged
        Try
            Dim connection As New OdbcConnection
            Dim ADAPTER As New OdbcDataAdapter
            Dim DATA_TABLE As New DataTable
            Dim command As New OdbcCommand

            connection = New OdbcConnection("dsn=ems;user=root;password=root")
            connection.Open()

            ADAPTER = New OdbcDataAdapter("select subject as Subject, marks as Marks from result where rollno = '" & textbox_search.Text & "' and examtype = '" & combobox_resultsearch.Text & "' ", connection)
            ADAPTER.Fill(DATA_TABLE)
            datagridview_result.DataSource = DATA_TABLE

            command = New OdbcCommand("select marks from result where rollno = '" & textbox_search.Text & "' and examtype = '" & combobox_resultsearch.Text & "' ", connection)
            Dim data_reader As OdbcDataReader = command.ExecuteReader
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
            command = New OdbcCommand("select marks from result where rollno = '" & textbox_search.Text & "' and examtype = '" & combobox_resultsearch.Text & "' ", connection)
            data_reader = command.ExecuteReader
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

    'save a new schedule
    Private Sub button_schedulesave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_schedulesave.Click
        Try
            Dim COMMAND As New OdbcCommand
            Dim connection As New OdbcConnection
            Dim ADAPTER As New OdbcDataAdapter
            Dim DATA_TABLE As New DataTable
            connection = New OdbcConnection("dsn=ems;user=root;password=root")
            connection.Open()
            examtype = textbox_examname.Text + " " + textbox_examyear.Text
            COMMAND = New OdbcCommand("delete from schedule where examtype = '" & examtype & "' ", connection)
            COMMAND.ExecuteNonQuery()
            COMMAND = New OdbcCommand("insert into schedule (date, examtype, subject) VALUES ('" & Format(datetimepicker_subject1.Value, "yyyy-MM-dd") & "','" & examtype & "','" & textbox_subject1.Text & "')", connection)
            COMMAND.ExecuteNonQuery()
            COMMAND = New OdbcCommand("insert into schedule (date, examtype, subject) VALUES ('" & Format(datetimepicker_subject2.Value, "yyyy-MM-dd") & "','" & examtype & "','" & textbox_subject2.Text & "')", connection)
            COMMAND.ExecuteNonQuery()
            COMMAND = New OdbcCommand("insert into schedule (date, examtype, subject) VALUES ('" & Format(datetimepicker_subject3.Value, "yyyy-MM-dd") & "','" & examtype & "','" & textbox_subject3.Text & "')", connection)
            COMMAND.ExecuteNonQuery()
            COMMAND = New OdbcCommand("insert into schedule (date, examtype, subject) VALUES ('" & Format(datetimepicker_subject4.Value, "yyyy-MM-dd") & "','" & examtype & "','" & textbox_subject4.Text & "')", connection)
            COMMAND.ExecuteNonQuery()
            COMMAND = New OdbcCommand("insert into schedule (date, examtype, subject) VALUES ('" & Format(datetimepicker_subject5.Value, "yyyy-MM-dd") & "','" & examtype & "','" & textbox_subject5.Text & "')", connection)
            COMMAND.ExecuteNonQuery()
            connection.Close()

            textbox_examname.Clear()
            textbox_examyear.Clear()
            textbox_subject1.Clear()
            textbox_subject2.Clear()
            textbox_subject3.Clear()
            textbox_subject4.Clear()
            textbox_subject5.Clear()

            MsgBox("Schedule Saved Succesfully")

            form_admin_panel_Load(sender, e)

        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
    End Sub

    'save marks of a student
    Private Sub button_savemarks_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_savemarks.Click
        Try
            Dim COMMAND As New OdbcCommand
            Dim connection As New OdbcConnection
            connection = New OdbcConnection("dsn=ems;user=root;password=root")
            connection.Open()

            COMMAND = New OdbcCommand("SELECT examid FROM exam WHERE rollno = '" & textbox_marksentry_rollno.Text & "' and examtype = '" & combobox_marksentry_examtype.Text & "' ", connection)
            Dim data_reader As OdbcDataReader = COMMAND.ExecuteReader
            data_reader.Read()
            examid = data_reader(0)

            COMMAND = New OdbcCommand("insert into result VALUES ('" & combobox_marksentry_examtype.Text & "','" & textbox_marksentry_rollno.Text & "','" & textbox_marksentry_subject1.Text & "','" & textbox_marksentry_marks1.Text & "','" & examid & "')", connection)
            COMMAND.ExecuteNonQuery()
            COMMAND = New OdbcCommand("insert into result VALUES ('" & combobox_marksentry_examtype.Text & "','" & textbox_marksentry_rollno.Text & "','" & textbox_marksentry_subject2.Text & "','" & textbox_marksentry_marks2.Text & "','" & examid & "')", connection)
            COMMAND.ExecuteNonQuery()
            COMMAND = New OdbcCommand("insert into result VALUES ('" & combobox_marksentry_examtype.Text & "','" & textbox_marksentry_rollno.Text & "','" & textbox_marksentry_subject3.Text & "','" & textbox_marksentry_marks3.Text & "','" & examid & "')", connection)
            COMMAND.ExecuteNonQuery()
            COMMAND = New OdbcCommand("insert into result VALUES ('" & combobox_marksentry_examtype.Text & "','" & textbox_marksentry_rollno.Text & "','" & textbox_marksentry_subject4.Text & "','" & textbox_marksentry_marks4.Text & "','" & examid & "')", connection)
            COMMAND.ExecuteNonQuery()
            COMMAND = New OdbcCommand("insert into result VALUES ('" & combobox_marksentry_examtype.Text & "','" & textbox_marksentry_rollno.Text & "','" & textbox_marksentry_subject5.Text & "','" & textbox_marksentry_marks5.Text & "','" & examid & "')", connection)
            COMMAND.ExecuteNonQuery()
            connection.Close()

            MsgBox("Marks Saved Succesfully")

        Catch ex As Exception
            MsgBox("Error: Exam ID not found. This student has not applied for this exam!")
        End Try
    End Sub

    'delete a student and all their information
    Private Sub button_deletestudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_deletestudent.Click
        Try
            If (textbox_search.Text = "") Then
                MsgBox("Please enter a roll no!")
            Else
                Dim COMMAND As New OdbcCommand
                Dim connection As New OdbcConnection

                Dim ask As MsgBoxResult
                ask = MsgBox("Are you sure you want to delete this student? All their exam records will be deleted too!", MsgBoxStyle.YesNoCancel, "")

                If ask = MsgBoxResult.Yes Then
                    connection = New OdbcConnection("dsn=ems;user=root;password=root")
                    connection.Open()

                    COMMAND = New OdbcCommand("delete from student where rollno = '" & textbox_search.Text & "' ", connection)
                    COMMAND.ExecuteNonQuery()

                    connection.Close()

                    textbox_createstdname.Clear()
                    textbox_createstdrollno.Clear()
                    textbox_createstdpassword.Clear()
                    textbox_createstdgrade.Clear()
                    textbox_createstdemail.Clear()
                    textbox_createstdphone.Clear()
                    textbox_createstdfather.Clear()
                    textbox_createstdmother.Clear()
                    combobox_createstdgender.Text = ""
                    textbox_createstdaddress.Clear()

                    MsgBox("Deleted Succesfully!")
                End If

            End If

        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
    End Sub

    'search for a schedule
    Private Sub button_schedulesearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_schedulesearch.Click
        Try
            Dim COMMAND As New OdbcCommand
            Dim connection As New OdbcConnection
            Dim ADAPTER As New OdbcDataAdapter
            Dim DATA_TABLE As New DataTable

            connection = New OdbcConnection("dsn=ems;user=root;password=root")
            connection.Open()

            examtype = textbox_examname.Text + " " + textbox_examyear.Text

            COMMAND = New OdbcCommand("SELECT subject FROM schedule WHERE examtype = '" & examtype & "' ", connection)
            Dim data_reader As OdbcDataReader = COMMAND.ExecuteReader
            i = 1
            While data_reader.Read()
                If i = 1 Then
                    textbox_subject1.Text = data_reader(0)
                    i += 1
                ElseIf i = 2 Then
                    textbox_subject2.Text = data_reader(0)
                    i += 1
                ElseIf i = 3 Then
                    textbox_subject3.Text = data_reader(0)
                    i += 1
                ElseIf i = 4 Then
                    textbox_subject4.Text = data_reader(0)
                    i += 1
                ElseIf i = 5 Then
                    textbox_subject5.Text = data_reader(0)
                    i += 1
                End If
            End While

            COMMAND = New OdbcCommand("SELECT date FROM schedule WHERE examtype = '" & examtype & "' ", connection)
            data_reader = COMMAND.ExecuteReader
            i = 1
            While data_reader.Read()
                If i = 1 Then
                    datetimepicker_subject1.Text = data_reader(0)
                    i += 1
                ElseIf i = 2 Then
                    datetimepicker_subject2.Text = data_reader(0)
                    i += 1
                ElseIf i = 3 Then
                    datetimepicker_subject3.Text = data_reader(0)
                    i += 1
                ElseIf i = 4 Then
                    datetimepicker_subject4.Text = data_reader(0)
                    i += 1
                ElseIf i = 5 Then
                    datetimepicker_subject5.Text = data_reader(0)
                    i += 1
                End If
            End While

            connection.Close()

        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
    End Sub

    'delete a schedule
    Private Sub button_deleteschedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_deleteschedule.Click
        Try
            If (textbox_examname.Text = "") Then
                MsgBox("Please enter an exam name!")
                textbox_examname.Focus()
            ElseIf (textbox_examyear.Text = "") Then
                MsgBox("Please enter an exam year")
                textbox_examyear.Focus()
            Else
                Dim COMMAND As New OdbcCommand
                Dim connection As New OdbcConnection

                Dim ask As MsgBoxResult
                ask = MsgBox("Are you sure you want to delete this schedule? All associated exam records will be deleted too!", MsgBoxStyle.YesNoCancel, "")

                If ask = MsgBoxResult.Yes Then
                    connection = New OdbcConnection("dsn=ems;user=root;password=root")
                    connection.Open()

                    schedulename = textbox_examname.Text + " " + textbox_examyear.Text

                    COMMAND = New OdbcCommand("delete from schedule where examtype = '" & schedulename & "' ", connection)
                    COMMAND.ExecuteNonQuery()

                    connection.Close()

                    textbox_examname.Clear()
                    textbox_examyear.Clear()
                    textbox_subject1.Clear()
                    textbox_subject2.Clear()
                    textbox_subject3.Clear()
                    textbox_subject4.Clear()
                    textbox_subject5.Clear()

                    MsgBox("Deleted Succesfully!")

                    form_admin_panel_Load(sender, e)
                End If

            End If

        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
    End Sub

    'combobox result save exam list
    Private Sub combobox_marksentry_examtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combobox_marksentry_examtype.SelectedIndexChanged
        Dim COMMAND As New OdbcCommand
        Dim connection As New OdbcConnection
        connection = New OdbcConnection("dsn=ems;user=root;password=root")
        connection.Open()
        COMMAND = New OdbcCommand("SELECT subject FROM schedule where examtype = '" & combobox_marksentry_examtype.Text & "' ", connection)
        Dim data_reader As OdbcDataReader = COMMAND.ExecuteReader
        i = 1
        While data_reader.Read
            If i = 1 Then
                textbox_marksentry_subject1.Text = data_reader(0)
                i += 1
            ElseIf i = 2 Then
                textbox_marksentry_subject2.Text = data_reader(0)
                i += 1
            ElseIf i = 3 Then
                textbox_marksentry_subject3.Text = data_reader(0)
                i += 1
            ElseIf i = 4 Then
                textbox_marksentry_subject4.Text = data_reader(0)
                i += 1
            ElseIf i = 5 Then
                textbox_marksentry_subject5.Text = data_reader(0)
                i += 1
            End If
        End While
        connection.Close()
    End Sub

    Private Sub button_printschedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_printschedule.Click
        FORM_SCHEDULE_VIEW.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        admincontrol.Show()
    End Sub

    Private Sub button_marksprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_marksprint.Click
        label_referrer.Text = "ADMIN"
        form_student_panel.label_referrer.Text = "ADMIN"
        FORM_MARKSHEET_VIEW.Show()
    End Sub
End Class