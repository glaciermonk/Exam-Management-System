<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_login))
        Me.button_login = New System.Windows.Forms.Button
        Me.textbox_username = New System.Windows.Forms.TextBox
        Me.textbox_password = New System.Windows.Forms.TextBox
        Me.picturebox_school_logo = New System.Windows.Forms.PictureBox
        Me.button_exit = New System.Windows.Forms.Button
        Me.label_login = New System.Windows.Forms.Label
        Me.label_message = New System.Windows.Forms.Label
        Me.label_username = New System.Windows.Forms.Label
        Me.label_password = New System.Windows.Forms.Label
        Me.panel_login = New System.Windows.Forms.Panel
        CType(Me.picturebox_school_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_login.SuspendLayout()
        Me.SuspendLayout()
        '
        'button_login
        '
        Me.button_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.button_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_login.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_login.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_login.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.button_login.Location = New System.Drawing.Point(34, 155)
        Me.button_login.Margin = New System.Windows.Forms.Padding(0)
        Me.button_login.Name = "button_login"
        Me.button_login.Padding = New System.Windows.Forms.Padding(3)
        Me.button_login.Size = New System.Drawing.Size(226, 36)
        Me.button_login.TabIndex = 0
        Me.button_login.Text = "LOGIN"
        Me.button_login.UseVisualStyleBackColor = False
        '
        'textbox_username
        '
        Me.textbox_username.BackColor = System.Drawing.Color.White
        Me.textbox_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_username.Location = New System.Drawing.Point(34, 77)
        Me.textbox_username.Name = "textbox_username"
        Me.textbox_username.Size = New System.Drawing.Size(226, 26)
        Me.textbox_username.TabIndex = 2
        Me.textbox_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textbox_password
        '
        Me.textbox_password.BackColor = System.Drawing.Color.White
        Me.textbox_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_password.Location = New System.Drawing.Point(34, 122)
        Me.textbox_password.Name = "textbox_password"
        Me.textbox_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textbox_password.Size = New System.Drawing.Size(226, 26)
        Me.textbox_password.TabIndex = 4
        Me.textbox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.textbox_password.UseSystemPasswordChar = True
        '
        'picturebox_school_logo
        '
        Me.picturebox_school_logo.Image = CType(resources.GetObject("picturebox_school_logo.Image"), System.Drawing.Image)
        Me.picturebox_school_logo.Location = New System.Drawing.Point(3, 3)
        Me.picturebox_school_logo.Name = "picturebox_school_logo"
        Me.picturebox_school_logo.Size = New System.Drawing.Size(582, 139)
        Me.picturebox_school_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picturebox_school_logo.TabIndex = 5
        Me.picturebox_school_logo.TabStop = False
        '
        'button_exit
        '
        Me.button_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_exit.Location = New System.Drawing.Point(29, 157)
        Me.button_exit.Name = "button_exit"
        Me.button_exit.Size = New System.Drawing.Size(1, 1)
        Me.button_exit.TabIndex = 6
        Me.button_exit.Text = "Button1"
        Me.button_exit.UseVisualStyleBackColor = True
        '
        'label_login
        '
        Me.label_login.AutoSize = True
        Me.label_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_login.Location = New System.Drawing.Point(114, 6)
        Me.label_login.Name = "label_login"
        Me.label_login.Size = New System.Drawing.Size(62, 24)
        Me.label_login.TabIndex = 7
        Me.label_login.Text = "Login"
        '
        'label_message
        '
        Me.label_message.AutoSize = True
        Me.label_message.ForeColor = System.Drawing.Color.Red
        Me.label_message.Location = New System.Drawing.Point(32, 44)
        Me.label_message.Name = "label_message"
        Me.label_message.Size = New System.Drawing.Size(0, 13)
        Me.label_message.TabIndex = 8
        Me.label_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label_username
        '
        Me.label_username.AutoSize = True
        Me.label_username.Location = New System.Drawing.Point(32, 61)
        Me.label_username.Name = "label_username"
        Me.label_username.Size = New System.Drawing.Size(55, 13)
        Me.label_username.TabIndex = 9
        Me.label_username.Text = "Username"
        '
        'label_password
        '
        Me.label_password.AutoSize = True
        Me.label_password.Location = New System.Drawing.Point(32, 106)
        Me.label_password.Name = "label_password"
        Me.label_password.Size = New System.Drawing.Size(53, 13)
        Me.label_password.TabIndex = 10
        Me.label_password.Text = "Password"
        '
        'panel_login
        '
        Me.panel_login.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel_login.Controls.Add(Me.label_password)
        Me.panel_login.Controls.Add(Me.label_username)
        Me.panel_login.Controls.Add(Me.label_message)
        Me.panel_login.Controls.Add(Me.label_login)
        Me.panel_login.Controls.Add(Me.textbox_password)
        Me.panel_login.Controls.Add(Me.textbox_username)
        Me.panel_login.Controls.Add(Me.button_login)
        Me.panel_login.Location = New System.Drawing.Point(146, 151)
        Me.panel_login.Name = "panel_login"
        Me.panel_login.Size = New System.Drawing.Size(295, 220)
        Me.panel_login.TabIndex = 11
        '
        'form_login
        '
        Me.AcceptButton = Me.button_login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.button_exit
        Me.ClientSize = New System.Drawing.Size(587, 394)
        Me.Controls.Add(Me.panel_login)
        Me.Controls.Add(Me.button_exit)
        Me.Controls.Add(Me.picturebox_school_logo)
        Me.Name = "form_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exam Management System Login"
        CType(Me.picturebox_school_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_login.ResumeLayout(False)
        Me.panel_login.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents button_login As System.Windows.Forms.Button
    Friend WithEvents textbox_username As System.Windows.Forms.TextBox
    Friend WithEvents textbox_password As System.Windows.Forms.TextBox
    Friend WithEvents picturebox_school_logo As System.Windows.Forms.PictureBox
    Friend WithEvents button_exit As System.Windows.Forms.Button
    Friend WithEvents label_login As System.Windows.Forms.Label
    Friend WithEvents label_message As System.Windows.Forms.Label
    Friend WithEvents label_username As System.Windows.Forms.Label
    Friend WithEvents label_password As System.Windows.Forms.Label
    Friend WithEvents panel_login As System.Windows.Forms.Panel

End Class
