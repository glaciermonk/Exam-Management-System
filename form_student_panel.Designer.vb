<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_student_panel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_student_panel))
        Me.datagridview_schedule = New System.Windows.Forms.DataGridView
        Me.button_apply = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.combobox_schedulelist = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.button_generate = New System.Windows.Forms.Button
        Me.datagridview_admitlist = New System.Windows.Forms.DataGridView
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.textbox_resultstatus = New System.Windows.Forms.TextBox
        Me.textbox_resulttext = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.button_marksheet_generate = New System.Windows.Forms.Button
        Me.combobox_marksheet = New System.Windows.Forms.ComboBox
        Me.datagridview_marksheet = New System.Windows.Forms.DataGridView
        Me.label_referrer = New System.Windows.Forms.Label
        Me.textbox_grandtotal = New System.Windows.Forms.TextBox
        Me.textbox_grandtext = New System.Windows.Forms.TextBox
        CType(Me.datagridview_schedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.datagridview_admitlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.datagridview_marksheet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datagridview_schedule
        '
        Me.datagridview_schedule.AllowUserToAddRows = False
        Me.datagridview_schedule.AllowUserToDeleteRows = False
        Me.datagridview_schedule.AllowUserToResizeColumns = False
        Me.datagridview_schedule.AllowUserToResizeRows = False
        Me.datagridview_schedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridview_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridview_schedule.Location = New System.Drawing.Point(13, 71)
        Me.datagridview_schedule.MultiSelect = False
        Me.datagridview_schedule.Name = "datagridview_schedule"
        Me.datagridview_schedule.ReadOnly = True
        Me.datagridview_schedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.datagridview_schedule.Size = New System.Drawing.Size(240, 254)
        Me.datagridview_schedule.TabIndex = 153
        '
        'button_apply
        '
        Me.button_apply.Location = New System.Drawing.Point(101, 331)
        Me.button_apply.Name = "button_apply"
        Me.button_apply.Size = New System.Drawing.Size(75, 23)
        Me.button_apply.TabIndex = 155
        Me.button_apply.Text = "Apply"
        Me.button_apply.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.Controls.Add(Me.combobox_schedulelist)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.button_apply)
        Me.Panel1.Controls.Add(Me.datagridview_schedule)
        Me.Panel1.Font = New System.Drawing.Font("Perpetua Titling MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(14, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 363)
        Me.Panel1.TabIndex = 156
        '
        'combobox_schedulelist
        '
        Me.combobox_schedulelist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_schedulelist.FormattingEnabled = True
        Me.combobox_schedulelist.Location = New System.Drawing.Point(13, 45)
        Me.combobox_schedulelist.Name = "combobox_schedulelist"
        Me.combobox_schedulelist.Size = New System.Drawing.Size(240, 21)
        Me.combobox_schedulelist.TabIndex = 157
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(61, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 23)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "Exam Schedules"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.button_generate)
        Me.Panel2.Controls.Add(Me.datagridview_admitlist)
        Me.Panel2.Font = New System.Drawing.Font("Perpetua Titling MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(310, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(266, 363)
        Me.Panel2.TabIndex = 158
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(33, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 23)
        Me.Label2.TabIndex = 158
        Me.Label2.Text = "Admit Card Generation"
        '
        'button_generate
        '
        Me.button_generate.Location = New System.Drawing.Point(79, 331)
        Me.button_generate.Name = "button_generate"
        Me.button_generate.Size = New System.Drawing.Size(109, 23)
        Me.button_generate.TabIndex = 155
        Me.button_generate.Text = "Generate"
        Me.button_generate.UseVisualStyleBackColor = True
        '
        'datagridview_admitlist
        '
        Me.datagridview_admitlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridview_admitlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridview_admitlist.Location = New System.Drawing.Point(13, 45)
        Me.datagridview_admitlist.MultiSelect = False
        Me.datagridview_admitlist.Name = "datagridview_admitlist"
        Me.datagridview_admitlist.ReadOnly = True
        Me.datagridview_admitlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.datagridview_admitlist.Size = New System.Drawing.Size(240, 280)
        Me.datagridview_admitlist.TabIndex = 153
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGreen
        Me.Panel3.Controls.Add(Me.textbox_grandtext)
        Me.Panel3.Controls.Add(Me.textbox_grandtotal)
        Me.Panel3.Controls.Add(Me.textbox_resultstatus)
        Me.Panel3.Controls.Add(Me.textbox_resulttext)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.button_marksheet_generate)
        Me.Panel3.Controls.Add(Me.combobox_marksheet)
        Me.Panel3.Controls.Add(Me.datagridview_marksheet)
        Me.Panel3.Font = New System.Drawing.Font("Perpetua Titling MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(605, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(266, 363)
        Me.Panel3.TabIndex = 160
        '
        'textbox_resultstatus
        '
        Me.textbox_resultstatus.Location = New System.Drawing.Point(137, 304)
        Me.textbox_resultstatus.Name = "textbox_resultstatus"
        Me.textbox_resultstatus.ReadOnly = True
        Me.textbox_resultstatus.Size = New System.Drawing.Size(115, 21)
        Me.textbox_resultstatus.TabIndex = 162
        Me.textbox_resultstatus.Visible = False
        '
        'textbox_resulttext
        '
        Me.textbox_resulttext.Location = New System.Drawing.Point(12, 304)
        Me.textbox_resulttext.Name = "textbox_resulttext"
        Me.textbox_resulttext.ReadOnly = True
        Me.textbox_resulttext.Size = New System.Drawing.Size(126, 21)
        Me.textbox_resulttext.TabIndex = 161
        Me.textbox_resulttext.Text = "RESULT"
        Me.textbox_resulttext.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(77, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 23)
        Me.Label3.TabIndex = 160
        Me.Label3.Text = "Exam Marks"
        '
        'button_marksheet_generate
        '
        Me.button_marksheet_generate.Location = New System.Drawing.Point(48, 331)
        Me.button_marksheet_generate.Name = "button_marksheet_generate"
        Me.button_marksheet_generate.Size = New System.Drawing.Size(169, 23)
        Me.button_marksheet_generate.TabIndex = 155
        Me.button_marksheet_generate.Text = "Generate Marksheet"
        Me.button_marksheet_generate.UseVisualStyleBackColor = True
        '
        'combobox_marksheet
        '
        Me.combobox_marksheet.FormattingEnabled = True
        Me.combobox_marksheet.Location = New System.Drawing.Point(12, 45)
        Me.combobox_marksheet.Name = "combobox_marksheet"
        Me.combobox_marksheet.Size = New System.Drawing.Size(240, 21)
        Me.combobox_marksheet.TabIndex = 154
        '
        'datagridview_marksheet
        '
        Me.datagridview_marksheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridview_marksheet.Location = New System.Drawing.Point(12, 71)
        Me.datagridview_marksheet.MultiSelect = False
        Me.datagridview_marksheet.Name = "datagridview_marksheet"
        Me.datagridview_marksheet.ReadOnly = True
        Me.datagridview_marksheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.datagridview_marksheet.Size = New System.Drawing.Size(240, 254)
        Me.datagridview_marksheet.TabIndex = 153
        '
        'label_referrer
        '
        Me.label_referrer.AutoSize = True
        Me.label_referrer.Location = New System.Drawing.Point(295, 16)
        Me.label_referrer.Name = "label_referrer"
        Me.label_referrer.Size = New System.Drawing.Size(0, 13)
        Me.label_referrer.TabIndex = 161
        Me.label_referrer.Visible = False
        '
        'textbox_grandtotal
        '
        Me.textbox_grandtotal.Location = New System.Drawing.Point(137, 284)
        Me.textbox_grandtotal.Name = "textbox_grandtotal"
        Me.textbox_grandtotal.ReadOnly = True
        Me.textbox_grandtotal.Size = New System.Drawing.Size(115, 21)
        Me.textbox_grandtotal.TabIndex = 163
        Me.textbox_grandtotal.Visible = False
        '
        'textbox_grandtext
        '
        Me.textbox_grandtext.Location = New System.Drawing.Point(12, 284)
        Me.textbox_grandtext.Name = "textbox_grandtext"
        Me.textbox_grandtext.ReadOnly = True
        Me.textbox_grandtext.Size = New System.Drawing.Size(126, 21)
        Me.textbox_grandtext.TabIndex = 162
        Me.textbox_grandtext.Text = "Grand Total:"
        Me.textbox_grandtext.Visible = False
        '
        'form_student_panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(888, 394)
        Me.Controls.Add(Me.label_referrer)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "form_student_panel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Panel"
        CType(Me.datagridview_schedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.datagridview_admitlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.datagridview_marksheet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents datagridview_schedule As System.Windows.Forms.DataGridView
    Friend WithEvents button_apply As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents button_generate As System.Windows.Forms.Button
    Friend WithEvents datagridview_admitlist As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents button_marksheet_generate As System.Windows.Forms.Button
    Friend WithEvents combobox_marksheet As System.Windows.Forms.ComboBox
    Friend WithEvents datagridview_marksheet As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents combobox_schedulelist As System.Windows.Forms.ComboBox
    Friend WithEvents label_referrer As System.Windows.Forms.Label
    Friend WithEvents textbox_resultstatus As System.Windows.Forms.TextBox
    Friend WithEvents textbox_resulttext As System.Windows.Forms.TextBox
    Friend WithEvents textbox_grandtext As System.Windows.Forms.TextBox
    Friend WithEvents textbox_grandtotal As System.Windows.Forms.TextBox
End Class
