<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class create
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(create))
        Me.txtCurrentDate = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnMonday = New System.Windows.Forms.Button()
        Me.btnTuesday = New System.Windows.Forms.Button()
        Me.btnWednesday = New System.Windows.Forms.Button()
        Me.btnThursday = New System.Windows.Forms.Button()
        Me.btnFriday = New System.Windows.Forms.Button()
        Me.btnSaturday = New System.Windows.Forms.Button()
        Me.btnSunday = New System.Windows.Forms.Button()
        Me.cmbClient = New System.Windows.Forms.ComboBox()
        Me.dtpDietDate = New System.Windows.Forms.DateTimePicker()
        Me.txtClientID = New System.Windows.Forms.TextBox()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.txtDietID = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.lblFollowUp = New System.Windows.Forms.Label()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.txtFollowUp = New System.Windows.Forms.TextBox()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.lblDietID = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCurrentDate
        '
        Me.txtCurrentDate.Location = New System.Drawing.Point(82, 200)
        Me.txtCurrentDate.Name = "txtCurrentDate"
        Me.txtCurrentDate.Size = New System.Drawing.Size(136, 20)
        Me.txtCurrentDate.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(945, 171)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox3.Size = New System.Drawing.Size(110, 20)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "George Davis"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox4.Location = New System.Drawing.Point(945, 197)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox4.Size = New System.Drawing.Size(110, 20)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = "22100189"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox5.Location = New System.Drawing.Point(867, 223)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(188, 20)
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.Text = "Dr.George.Davis@nutrition.com"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(284, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(467, 62)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Create New Diet Routine"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Client Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(852, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nutritionist Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(877, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tel.Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(822, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Email"
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(676, 501)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMainMenu.TabIndex = 81
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(505, 501)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 83
        Me.btnView.Text = "View records"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(321, 501)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 84
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnMonday
        '
        Me.btnMonday.Location = New System.Drawing.Point(257, 422)
        Me.btnMonday.Name = "btnMonday"
        Me.btnMonday.Size = New System.Drawing.Size(75, 50)
        Me.btnMonday.TabIndex = 85
        Me.btnMonday.Text = "Monday"
        Me.btnMonday.UseVisualStyleBackColor = True
        '
        'btnTuesday
        '
        Me.btnTuesday.Location = New System.Drawing.Point(343, 422)
        Me.btnTuesday.Name = "btnTuesday"
        Me.btnTuesday.Size = New System.Drawing.Size(75, 50)
        Me.btnTuesday.TabIndex = 86
        Me.btnTuesday.Text = "Tuesday"
        Me.btnTuesday.UseVisualStyleBackColor = True
        '
        'btnWednesday
        '
        Me.btnWednesday.Location = New System.Drawing.Point(424, 422)
        Me.btnWednesday.Name = "btnWednesday"
        Me.btnWednesday.Size = New System.Drawing.Size(75, 50)
        Me.btnWednesday.TabIndex = 87
        Me.btnWednesday.Text = "Wednesday"
        Me.btnWednesday.UseVisualStyleBackColor = True
        '
        'btnThursday
        '
        Me.btnThursday.Location = New System.Drawing.Point(505, 422)
        Me.btnThursday.Name = "btnThursday"
        Me.btnThursday.Size = New System.Drawing.Size(75, 50)
        Me.btnThursday.TabIndex = 88
        Me.btnThursday.Text = "Thursday"
        Me.btnThursday.UseVisualStyleBackColor = True
        '
        'btnFriday
        '
        Me.btnFriday.Location = New System.Drawing.Point(588, 422)
        Me.btnFriday.Name = "btnFriday"
        Me.btnFriday.Size = New System.Drawing.Size(75, 50)
        Me.btnFriday.TabIndex = 89
        Me.btnFriday.Text = "Friday"
        Me.btnFriday.UseVisualStyleBackColor = True
        '
        'btnSaturday
        '
        Me.btnSaturday.Location = New System.Drawing.Point(669, 422)
        Me.btnSaturday.Name = "btnSaturday"
        Me.btnSaturday.Size = New System.Drawing.Size(75, 50)
        Me.btnSaturday.TabIndex = 90
        Me.btnSaturday.Text = "Saturday"
        Me.btnSaturday.UseVisualStyleBackColor = True
        '
        'btnSunday
        '
        Me.btnSunday.Location = New System.Drawing.Point(750, 422)
        Me.btnSunday.Name = "btnSunday"
        Me.btnSunday.Size = New System.Drawing.Size(75, 50)
        Me.btnSunday.TabIndex = 92
        Me.btnSunday.Text = "Sunday"
        Me.btnSunday.UseVisualStyleBackColor = True
        '
        'cmbClient
        '
        Me.cmbClient.DisplayMember = "ClientID"
        Me.cmbClient.FormattingEnabled = True
        Me.cmbClient.Location = New System.Drawing.Point(82, 166)
        Me.cmbClient.Name = "cmbClient"
        Me.cmbClient.Size = New System.Drawing.Size(187, 21)
        Me.cmbClient.TabIndex = 93
        Me.cmbClient.ValueMember = "ClientID"
        '
        'dtpDietDate
        '
        Me.dtpDietDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDietDate.Location = New System.Drawing.Point(82, 200)
        Me.dtpDietDate.Name = "dtpDietDate"
        Me.dtpDietDate.Size = New System.Drawing.Size(136, 20)
        Me.dtpDietDate.TabIndex = 94
        '
        'txtClientID
        '
        Me.txtClientID.Location = New System.Drawing.Point(86, 129)
        Me.txtClientID.Name = "txtClientID"
        Me.txtClientID.Size = New System.Drawing.Size(68, 20)
        Me.txtClientID.TabIndex = 95
        '
        'txtClientName
        '
        Me.txtClientName.Location = New System.Drawing.Point(86, 129)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(68, 20)
        Me.txtClientName.TabIndex = 96
        '
        'txtDietID
        '
        Me.txtDietID.Location = New System.Drawing.Point(82, 129)
        Me.txtDietID.Name = "txtDietID"
        Me.txtDietID.Size = New System.Drawing.Size(89, 20)
        Me.txtDietID.TabIndex = 97
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(867, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 125)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.Location = New System.Drawing.Point(23, 256)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(56, 13)
        Me.lblComments.TabIndex = 98
        Me.lblComments.Text = "Comments"
        '
        'lblFollowUp
        '
        Me.lblFollowUp.AutoSize = True
        Me.lblFollowUp.Location = New System.Drawing.Point(27, 318)
        Me.lblFollowUp.Name = "lblFollowUp"
        Me.lblFollowUp.Size = New System.Drawing.Size(54, 13)
        Me.lblFollowUp.TabIndex = 99
        Me.lblFollowUp.Text = "Follow Up"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(85, 254)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(235, 20)
        Me.txtComments.TabIndex = 100
        '
        'txtFollowUp
        '
        Me.txtFollowUp.Location = New System.Drawing.Point(86, 314)
        Me.txtFollowUp.Name = "txtFollowUp"
        Me.txtFollowUp.Size = New System.Drawing.Size(235, 20)
        Me.txtFollowUp.TabIndex = 101
        '
        'txtDay
        '
        Me.txtDay.Location = New System.Drawing.Point(98, 129)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(47, 20)
        Me.txtDay.TabIndex = 102
        '
        'lblDietID
        '
        Me.lblDietID.AutoSize = True
        Me.lblDietID.Location = New System.Drawing.Point(40, 132)
        Me.lblDietID.Name = "lblDietID"
        Me.lblDietID.Size = New System.Drawing.Size(40, 13)
        Me.lblDietID.TabIndex = 103
        Me.lblDietID.Text = "Diet ID"
        '
        'create
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 539)
        Me.Controls.Add(Me.txtDietID)
        Me.Controls.Add(Me.lblDietID)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.txtFollowUp)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.lblFollowUp)
        Me.Controls.Add(Me.lblComments)
        Me.Controls.Add(Me.txtClientName)
        Me.Controls.Add(Me.txtClientID)
        Me.Controls.Add(Me.dtpDietDate)
        Me.Controls.Add(Me.cmbClient)
        Me.Controls.Add(Me.btnSunday)
        Me.Controls.Add(Me.btnSaturday)
        Me.Controls.Add(Me.btnFriday)
        Me.Controls.Add(Me.btnThursday)
        Me.Controls.Add(Me.btnWednesday)
        Me.Controls.Add(Me.btnTuesday)
        Me.Controls.Add(Me.btnMonday)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtCurrentDate)
        Me.HelpButton = True
        Me.MinimizeBox = False
        Me.Name = "create"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Create New Diet Routine"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCurrentDate As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnMonday As System.Windows.Forms.Button
    Friend WithEvents btnTuesday As System.Windows.Forms.Button
    Friend WithEvents btnWednesday As System.Windows.Forms.Button
    Friend WithEvents btnThursday As System.Windows.Forms.Button
    Friend WithEvents btnFriday As System.Windows.Forms.Button
    Friend WithEvents btnSaturday As System.Windows.Forms.Button
    Friend WithEvents btnSunday As System.Windows.Forms.Button
    Friend WithEvents cmbClient As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDietDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtClientID As System.Windows.Forms.TextBox
    Friend WithEvents txtClientName As System.Windows.Forms.TextBox
    Friend WithEvents txtDietID As System.Windows.Forms.TextBox
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents lblFollowUp As System.Windows.Forms.Label
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents txtFollowUp As System.Windows.Forms.TextBox
    Friend WithEvents txtDay As System.Windows.Forms.TextBox
    Friend WithEvents lblDietID As System.Windows.Forms.Label
End Class
