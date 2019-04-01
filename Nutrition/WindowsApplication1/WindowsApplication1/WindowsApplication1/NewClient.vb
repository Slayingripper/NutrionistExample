Public Class NewClient
    Dim inc As Integer 'declares inc as integer
    Dim MaxRows As Integer 'declares MaxRows as integer
    Dim con As New OleDb.OleDbConnection 'declares con As a new olebdbconnection
    Dim dbProvider As String 'declares dbprovider As string
    Dim dbSource As String 'declares dbsource as string
    Dim DSClients As New DataSet 'declares DSClients As a new dataset
    Dim DAClients As OleDb.OleDbDataAdapter 'declares DAClients as oleDbDataadapter
    Dim SQLClients As String 'declare SQLClients as string
    Private Sub NewClient_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dbProvider = "PROVIDER=Microsoft.Ace.OLEDB.12.0;" 'Set technology to use
        dbSource = "Data Source =C:\WindowsApplication1\WindowsApplication1\WindowsApplication1\Resources\Vasilis.accdb"
        'Set file including path to use

        con.ConnectionString = dbProvider & dbSource  'Define the connection string including technology, path & file to use

        DSClients.Clear() 'clears the data set
        txtClientID.Clear() 'clears the text box
        txtClientName.Clear() 'clears the textbox
        dtpDoB.Value = #1/1/1980#
        radMale.Checked = False
        radFemale.Checked = False
        txtAddress.Clear() 'clears text box
        txtPostalCode.Clear() 'clears text box
        txtCity.Clear() 'clears text box
        txtTelNum.Clear() 'clears text box
        txtMobile.Clear() 'clears text box

        SQLClients = "SELECT * FROM TblClient" 'Declare the SQL statement (Choose all fields from table 
        DAClients = New OleDb.OleDbDataAdapter(SQLClients, con) 'Create the new data adapter
        DAClients.Fill(DSClients, "Clients") 'Fill the data set with records from a table. tblclient will hold this 

        MaxRows = DSClients.Tables("Clients").Rows.Count - 1



        txtClientID.Enabled = False 'disables use of clientiD text box

        txtClientName.Focus() 'focuses the window to the text box

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        Dim cb As New OleDb.OleDbCommandBuilder(DAClients) 'declares cb As new OlDbcommandbuilder
        Dim dsNewRow As DataRow 'Declares dsnewrow as DataRow
        Dim RC As Integer 'Declares RC As Integer

        RC = Val(DSClients.Tables("Clients").Rows(MaxRows).Item(0)) '

        dsNewRow = DSClients.Tables("Clients").NewRow()
        dsNewRow.Item("ClientID") = RC + 1
        dsNewRow.Item("Name") = txtClientName.Text 'adds data to the access from the textbox
        dsNewRow.Item("Birthdate") = dtpDoB.Text 'adds data to the access from the textbox
        If radMale.Checked Then 'checks if the client is male of female
            dsNewRow.Item("Gender") = "Male"
        Else
            dsNewRow.Item("Gender") = "Female"
        End If
        dsNewRow.Item("Address") = txtAddress.Text 'adds data to the access from the textbox
        dsNewRow.Item("Postalcode") = Val(txtPostalCode.Text) 'adds data to the access from the textbox
        dsNewRow.Item("City") = txtCity.Text 'adds data to the access from the textbox
        dsNewRow.Item("TelNum") = Val(txtTelNum.Text) 'adds data to the access from the textbox
        dsNewRow.Item("Mobile") = Val(txtMobile.Text) 'adds data to the access from the textbox

        DSClients.Tables("Clients").Rows.Add(dsNewRow)  'Update the datasource
        DAClients.Update(DSClients, "Clients")        'Update the database table

        'Inform user of successful database update
        MsgBox("New record added succesfully ...", vbOK, "Dr George Davis Nutrition")
        'displays a message box that record where added succesfully 

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Hide() 'hides window
        ViewClient.Visible = True 'displayes viewclient
    End Sub

    Private Sub txtClientName_LostFocus(sender As Object, e As System.EventArgs) Handles txtClientName.LostFocus
        'creates an if statment for input and sets up validation 
        'so that the name of the client must be entered in order for 
        'the program to add the client
        If txtClientName.Text = "" Then
            MsgBox("Client name is required", vbOK, "Dr George Davis Nutrition")
            txtClientName.Focus()
        End If
    End Sub

    Private Sub txtPostalCode_LostFocus(sender As Object, e As System.EventArgs) Handles txtPostalCode.LostFocus
        'creates an if statment for input and sets up validation so that the postal is stored as text and must be 4 digits long
        If txtPostalCode.Text <> "" And (Val(txtPostalCode.Text) < 1000 Or Val(txtPostalCode.Text) > 9999) Then
            MsgBox("Postcode must be 4 digits long", vbOK, "Dr George Davis Nutrition")
            txtPostalCode.Text = ""
            txtPostalCode.Focus()
        End If
    End Sub

    Private Sub txtTelNum_LostFocus(sender As Object, e As System.EventArgs) Handles txtTelNum.LostFocus
        'creates an if statment for input and sets up validation so that the telephone number is stored as text and must be 8 digits long
        If txtTelNum.Text <> "" And (Val(txtTelNum.Text) < 10000000 Or Val(txtTelNum.Text) > 99999999) Then
            MsgBox("Telephone number must be 8 digits long", vbOK, "Dr George Davis Nutrition")
            txtTelNum.Text = ""
            txtTelNum.Focus()
        End If
    End Sub

    Private Sub txtMobile_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMobile.LostFocus
        'creates an if statment for input and sets up validation so that the mobile number is stored as text and must be 8 digits long
        If txtMobile.Text <> "" And (Val(txtMobile.Text) < 10000000 Or Val(txtMobile.Text) > 99999999) Then
            MsgBox("Mobile Tel. number must be 8 digits long", vbOK, "Dr George Davis Nutrition")
            txtMobile.Text = ""
            txtMobile.Focus()
        End If
    End Sub
End Class