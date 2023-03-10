<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admincontrol
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admincontrol))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.textbox_createadminpassword = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.textbox_createadminusername = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.button_adminsave = New System.Windows.Forms.Button
        Me.datagridview_adminlist = New System.Windows.Forms.DataGridView
        Me.button_deleteadmin = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.datagridview_adminlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.button_adminsave)
        Me.GroupBox1.Controls.Add(Me.textbox_createadminpassword)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.textbox_createadminusername)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 209)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Create Admin"
        '
        'textbox_createadminpassword
        '
        Me.textbox_createadminpassword.Location = New System.Drawing.Point(62, 129)
        Me.textbox_createadminpassword.Name = "textbox_createadminpassword"
        Me.textbox_createadminpassword.Size = New System.Drawing.Size(219, 22)
        Me.textbox_createadminpassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Perpetua Titling MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label2.Location = New System.Drawing.Point(59, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'textbox_createadminusername
        '
        Me.textbox_createadminusername.Location = New System.Drawing.Point(62, 67)
        Me.textbox_createadminusername.Name = "textbox_createadminusername"
        Me.textbox_createadminusername.Size = New System.Drawing.Size(219, 22)
        Me.textbox_createadminusername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(59, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'button_adminsave
        '
        Me.button_adminsave.BackColor = System.Drawing.Color.Transparent
        Me.button_adminsave.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_adminsave.ForeColor = System.Drawing.Color.Black
        Me.button_adminsave.Location = New System.Drawing.Point(133, 166)
        Me.button_adminsave.Name = "button_adminsave"
        Me.button_adminsave.Size = New System.Drawing.Size(75, 23)
        Me.button_adminsave.TabIndex = 4
        Me.button_adminsave.Text = "SAVE"
        Me.button_adminsave.UseVisualStyleBackColor = False
        '
        'datagridview_adminlist
        '
        Me.datagridview_adminlist.AllowUserToAddRows = False
        Me.datagridview_adminlist.AllowUserToDeleteRows = False
        Me.datagridview_adminlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridview_adminlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridview_adminlist.Location = New System.Drawing.Point(368, 18)
        Me.datagridview_adminlist.Name = "datagridview_adminlist"
        Me.datagridview_adminlist.Size = New System.Drawing.Size(341, 203)
        Me.datagridview_adminlist.TabIndex = 1
        '
        'button_deleteadmin
        '
        Me.button_deleteadmin.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_deleteadmin.Location = New System.Drawing.Point(501, 227)
        Me.button_deleteadmin.Name = "button_deleteadmin"
        Me.button_deleteadmin.Size = New System.Drawing.Size(75, 23)
        Me.button_deleteadmin.TabIndex = 2
        Me.button_deleteadmin.Text = "DELETE"
        Me.button_deleteadmin.UseVisualStyleBackColor = True
        '
        'admincontrol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(721, 267)
        Me.Controls.Add(Me.button_deleteadmin)
        Me.Controls.Add(Me.datagridview_adminlist)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "admincontrol"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Control"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.datagridview_adminlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents textbox_createadminpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents textbox_createadminusername As System.Windows.Forms.TextBox
    Friend WithEvents button_adminsave As System.Windows.Forms.Button
    Friend WithEvents datagridview_adminlist As System.Windows.Forms.DataGridView
    Friend WithEvents button_deleteadmin As System.Windows.Forms.Button
End Class
