<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainmenu))
        Me.btncreatenew = New System.Windows.Forms.Button()
        Me.btnVdiets = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnviewc = New System.Windows.Forms.Button()
        Me.BtnNewClient = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btncreatenew
        '
        Me.btncreatenew.Location = New System.Drawing.Point(196, 99)
        Me.btncreatenew.Name = "btncreatenew"
        Me.btncreatenew.Size = New System.Drawing.Size(250, 105)
        Me.btncreatenew.TabIndex = 0
        Me.btncreatenew.Text = "Create New Diet"
        Me.btncreatenew.UseVisualStyleBackColor = True
        '
        'btnVdiets
        '
        Me.btnVdiets.Location = New System.Drawing.Point(482, 99)
        Me.btnVdiets.Name = "btnVdiets"
        Me.btnVdiets.Size = New System.Drawing.Size(260, 104)
        Me.btnVdiets.TabIndex = 1
        Me.btnVdiets.Text = "View Diets Written"
        Me.btnVdiets.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(321, 396)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(256, 95)
        Me.btnexit.TabIndex = 2
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(331, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(275, 9)
        Me.Label2.MaximumSize = New System.Drawing.Size(500, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(419, 76)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Healthy LIFE"
        '
        'btnviewc
        '
        Me.btnviewc.Location = New System.Drawing.Point(482, 223)
        Me.btnviewc.Name = "btnviewc"
        Me.btnviewc.Size = New System.Drawing.Size(260, 95)
        Me.btnviewc.TabIndex = 5
        Me.btnviewc.Text = "View Clients"
        Me.btnviewc.UseVisualStyleBackColor = True
        '
        'BtnNewClient
        '
        Me.BtnNewClient.Location = New System.Drawing.Point(196, 223)
        Me.BtnNewClient.Name = "BtnNewClient"
        Me.BtnNewClient.Size = New System.Drawing.Size(250, 94)
        Me.BtnNewClient.TabIndex = 6
        Me.BtnNewClient.Text = "New Client"
        Me.BtnNewClient.UseVisualStyleBackColor = True
        '
        'mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(941, 541)
        Me.Controls.Add(Me.BtnNewClient)
        Me.Controls.Add(Me.btnviewc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnVdiets)
        Me.Controls.Add(Me.btncreatenew)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mainmenu"
        Me.Text = "Healthy Life"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncreatenew As System.Windows.Forms.Button
    Friend WithEvents btnVdiets As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnviewc As System.Windows.Forms.Button
    Friend WithEvents BtnNewClient As System.Windows.Forms.Button

End Class
