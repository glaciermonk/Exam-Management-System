Imports System.Data.Odbc
Public Class form_login
    Private Sub button_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_login.Click
        Try
            If textbox_username.Text = "" And textbox_password.Text = "" Then
                label_message.Text = "Please enter a username and password!"
                textbox_username.Focus()
            ElseIf textbox_username.Text = "" Then
                label_message.Text = "Please enter a username!"
                textbox_username.Focus()
            ElseIf textbox_password.Text = "" Then
                label_message.Text = "Please enter a password!"
                textbox_password.Focus()
            Else
                Dim COMMAND As New OdbcCommand
                Dim connection As New OdbcConnection
                Dim DATA_READER_STUDENT, DATA_READER_ADMIN As OdbcDataReader
                connection = New OdbcConnection("dsn=ems;user=root;password=root")
                connection.Open()

                Try
                    COMMAND = New OdbcCommand("SELECT password FROM admin WHERE username = '" & textbox_username.Text & "'", connection)
                    DATA_READER_ADMIN = COMMAND.ExecuteReader
                    DATA_READER_ADMIN.Read()

                    If textbox_password.Text = DATA_READER_ADMIN(0) Then
                        Me.Hide()
                        form_admin_panel.Show()
                    Else
                        label_message.Text = "Wrong Password!"
                        textbox_password.Clear()
                        textbox_password.Focus()
                    End If
                Catch ex As Exception
                    COMMAND = New OdbcCommand("SELECT password FROM student WHERE rollno = '" & textbox_username.Text & "'", connection)
                    DATA_READER_STUDENT = COMMAND.ExecuteReader
                    DATA_READER_STUDENT.Read()

                    If textbox_password.Text = DATA_READER_STUDENT(0) Then
                        Me.Hide()
                        form_student_panel.Show()
                    Else
                        label_message.Text = "Wrong Password!"
                        textbox_password.Clear()
                        textbox_password.Focus()
                    End If
                End Try

                connection.Close()
            End If
        Catch ex As Exception
            label_message.Text = "User not found!"
            textbox_username.Clear()
            textbox_password.Clear()
            textbox_username.Focus()
        End Try
    End Sub

    Private Sub form_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        textbox_username.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_exit.Click
        Me.Close()
    End Sub

End Class
