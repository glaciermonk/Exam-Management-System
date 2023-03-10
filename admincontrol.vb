Imports System.Data.Odbc
Public Class admincontrol

    Private Sub button_adminsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_adminsave.Click
        Try
            Dim COMMAND As New OdbcCommand
            Dim connection As New OdbcConnection
            Dim ADAPTER As New OdbcDataAdapter
            Dim DATA_TABLE As New DataTable

            connection = New OdbcConnection("dsn=ems;user=root;password=root")
            connection.Open()

            COMMAND = New OdbcCommand("insert into admin VALUES ('" & textbox_createadminusername.Text & "','" & textbox_createadminpassword.Text & "')", connection)
            COMMAND.ExecuteNonQuery()
            MsgBox("Admin Created Succesfully")

            connection.Close()

            admincontrol_Load(sender, e)

        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
    End Sub

    Private Sub button_deleteadmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_deleteadmin.Click
        Try
            Dim COMMAND As New OdbcCommand
            Dim connection As New OdbcConnection
            Dim ADAPTER As New OdbcDataAdapter
            Dim DATA_TABLE As New DataTable

            connection = New OdbcConnection("dsn=ems;user=root;password=root")
            connection.Open()

            COMMAND = New OdbcCommand("delete from admin where username = '" & datagridview_adminlist.CurrentCell.Value.ToString & "' ", connection)
            COMMAND.ExecuteNonQuery()

            COMMAND = New OdbcCommand("delete from admin where password = '" & datagridview_adminlist.CurrentCell.Value.ToString & "' ", connection)
            COMMAND.ExecuteNonQuery()
            MsgBox("Admin Deleted Succesfully")

            connection.Close()

            admincontrol_Load(sender, e)

        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
    End Sub

    Private Sub admincontrol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim connection As New OdbcConnection
        Dim ADAPTER As New OdbcDataAdapter
        Dim DATA_TABLE As New DataTable
        Dim command As New OdbcCommand

        connection = New OdbcConnection("dsn=ems;user=root;password=root")
        connection.Open()

        ADAPTER = New OdbcDataAdapter("select username as Username, password as Password from admin", connection)
        ADAPTER.Fill(DATA_TABLE)
        datagridview_adminlist.DataSource = DATA_TABLE

        connection.Close()
    End Sub
End Class