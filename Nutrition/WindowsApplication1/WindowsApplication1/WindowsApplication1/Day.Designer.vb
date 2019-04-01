<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Day
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
        Me.lblDay = New System.Windows.Forms.Label()
        Me.cmbBreakfast = New System.Windows.Forms.ComboBox()
        Me.cmbLunch = New System.Windows.Forms.ComboBox()
        Me.cmbDinner = New System.Windows.Forms.ComboBox()
        Me.cmbDrink = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cmbSnack = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(123, 31)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(91, 46)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "Day"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbBreakfast
        '
        Me.cmbBreakfast.DisplayMember = "BreakfastID"
        Me.cmbBreakfast.FormattingEnabled = True
        Me.cmbBreakfast.Location = New System.Drawing.Point(93, 90)
        Me.cmbBreakfast.Name = "cmbBreakfast"
        Me.cmbBreakfast.Size = New System.Drawing.Size(201, 21)
        Me.cmbBreakfast.TabIndex = 1
        Me.cmbBreakfast.ValueMember = "BreakfastID"
        '
        'cmbLunch
        '
        Me.cmbLunch.DisplayMember = "LunchID"
        Me.cmbLunch.FormattingEnabled = True
        Me.cmbLunch.Location = New System.Drawing.Point(93, 120)
        Me.cmbLunch.Name = "cmbLunch"
        Me.cmbLunch.Size = New System.Drawing.Size(201, 21)
        Me.cmbLunch.TabIndex = 3
        Me.cmbLunch.ValueMember = "LunchID"
        '
        'cmbDinner
        '
        Me.cmbDinner.DisplayMember = "DinnerID"
        Me.cmbDinner.FormattingEnabled = True
        Me.cmbDinner.Location = New System.Drawing.Point(93, 150)
        Me.cmbDinner.Name = "cmbDinner"
        Me.cmbDinner.Size = New System.Drawing.Size(201, 21)
        Me.cmbDinner.TabIndex = 5
        Me.cmbDinner.ValueMember = "DinnerID"
        '
        'cmbDrink
        '
        Me.cmbDrink.DisplayMember = "DrinkID"
        Me.cmbDrink.FormattingEnabled = True
        Me.cmbDrink.Location = New System.Drawing.Point(92, 209)
        Me.cmbDrink.Name = "cmbDrink"
        Me.cmbDrink.Size = New System.Drawing.Size(201, 21)
        Me.cmbDrink.TabIndex = 6
        Me.cmbDrink.ValueMember = "DrinkID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Breakfast"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Lunch"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Dinner"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Drink"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(218, 405)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 15
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(56, 405)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cmbSnack
        '
        Me.cmbSnack.DisplayMember = "SnackID"
        Me.cmbSnack.FormattingEnabled = True
        Me.cmbSnack.Location = New System.Drawing.Point(93, 182)
        Me.cmbSnack.Name = "cmbSnack"
        Me.cmbSnack.Size = New System.Drawing.Size(201, 21)
        Me.cmbSnack.TabIndex = 18
        Me.cmbSnack.ValueMember = "SnackID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Snack"
        '
        'Day
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 484)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbSnack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbDrink)
        Me.Controls.Add(Me.cmbDinner)
        Me.Controls.Add(Me.cmbLunch)
        Me.Controls.Add(Me.cmbBreakfast)
        Me.Controls.Add(Me.lblDay)
        Me.Name = "Day"
        Me.Text = "Day"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents cmbBreakfast As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLunch As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDinner As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDrink As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cmbSnack As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
