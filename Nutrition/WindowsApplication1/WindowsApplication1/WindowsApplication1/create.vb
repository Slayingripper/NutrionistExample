Public Class create
    Dim inc As Integer 'declares inc as integer
    Dim MaxClients, MaxDietsGiven As Integer 'declares MaxClients and MaxDietGiven As integer
    Dim con As New OleDb.OleDbConnection 'declares con as a new olebdbconnection
    Dim dbProvider As String 'declares dbprovider as string
    Dim dbSource As String 'declares dbsource as string
    Dim DSClients, DSDietsGiven As New DataSet 'declares DSClients and DSDietsGiven As A new Data set
    Dim DAClients, DADietsGiven As OleDb.OleDbDataAdapter 'declares DAClients as DADietsGiven as an oleDbDataptor
    Dim SQLClients, SQLDietsGiven As String ' declares SQLClients and SQLDietsGiven as string

    Private Sub create_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim I As Integer 'Declares I as integer

        dbProvider = "PROVIDER=Microsoft.Ace.OLEDB.12.0;" 'sets the provider to use
        dbSource = "Data Source =C:\WindowsApplication1\WindowsApplication1\WindowsApplication1\Resources\Vasilis.accdb" 'sets the database source
        con.ConnectionString = dbProvider & dbSource 'creates a connection string

        SQLClients = "SELECT * FROM TblClient" 'Selects the table from the data base
        DAClients = New OleDb.OleDbDataAdapter(SQLClients, con) 'sets the connection 
        DAClients.Fill(DSClients, "Clients") 'fills the dataset

        MaxClients = DSClients.Tables("Clients").Rows.Count - 1 'sets a counter 

        For I = 0 To MaxClients 'creates a loop 
            cmbClient.Items.Add(DSClients.Tables("Clients").Rows(I).Item(1))
        Next

        SQLDietsGiven = "SELECT * FROM TblDietGiven" 'Selects the table from the database
        DADietsGiven = New OleDb.OleDbDataAdapter(SQLDietsGiven, con) 'sets teh connection
        DADietsGiven.Fill(DSDietsGiven, "DietsGiven") 'fills the dataset

        MaxDietsGiven = DSDietsGiven.Tables("DietsGiven").Rows.Count - 1 ' sets a counter

        txtDietID.Text = Val(DSDietsGiven.Tables("DietsGiven").Rows(MaxDietsGiven).Item(0)) + 1
        'incriments the counter
        txtComments.Text = ""
        txtFollowUp.Text = ""

        txtClientID.Visible = False 'sets the txtbox as invisible
        txtClientName.Visible = False 'sets the txtbox as invisible
        dtpDietDate.Visible = False 'sets the txtbox as invisible
        dtpDietDate.Text = Date.Now
        txtCurrentDate.Text = dtpDietDate.Text 'shows current date
        txtDay.Visible = False 'sets the txtbox as visible

    End Sub

    Private Sub cmbClient_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbClient.SelectedIndexChanged
        Dim I As Integer 'declares I as Integer
        For I = 0 To MaxClients 'creates a loop
            If cmbClient.SelectedItem = DSClients.Tables("Clients").Rows(I).Item(1) Then
                txtClientID.Text = DSClients.Tables("Clients").Rows(I).Item(0)
                txtClientName.Text = cmbClient.SelectedItem
            End If
        Next

    End Sub

    Private Sub btnMonday_Click(sender As System.Object, e As System.EventArgs) Handles btnMonday.Click
        txtDay.Text = "Monday"
        Day.Show() 'shows the corresponding day
    End Sub

    Private Sub BtnTuesday_Click(sender As System.Object, e As System.EventArgs) Handles btnTuesday.Click
        txtDay.Text = "Tuesday"
        Day.Show() 'shows the corresponding day
    End Sub

    Private Sub btnWednesday_Click(sender As System.Object, e As System.EventArgs) Handles btnWednesday.Click
        txtDay.Text = "Wednesday"
        Day.Show() 'shows the corresponding day
    End Sub

    Private Sub btnThursday_Click(sender As System.Object, e As System.EventArgs) Handles btnThursday.Click
        txtDay.Text = "Thursday"
        Day.Show() 'shows the corresponding day
    End Sub

    Private Sub btnFriday_Click(sender As System.Object, e As System.EventArgs) Handles btnFriday.Click
        txtDay.Text = "Friday"
        Day.Show() 'shows the corresponding day
    End Sub

    Private Sub btnSaturday_Click(sender As System.Object, e As System.EventArgs) Handles btnSaturday.Click
        txtDay.Text = "Saturday"
        Day.Show() 'shows the corresponding day
    End Sub

    Private Sub btnSunday_Click(sender As System.Object, e As System.EventArgs) Handles btnSunday.Click
        txtDay.Text = "Sunday"
        Day.Show() 'shows the corresponding day
    End Sub

    Private Sub btnView_Click(sender As System.Object, e As System.EventArgs) Handles btnView.Click
        Me.Close() 'hides view menu
        viewc.Show() 'opens the view current tables window
    End Sub

    Private Sub btnMainMenu_Click(sender As System.Object, e As System.EventArgs) Handles btnMainMenu.Click
        Me.Close() 'hides mainmenu
        mainmenu.Show() 'opens the mainmenu
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim cb As New OleDb.OleDbCommandBuilder(DADietsGiven) 'declares cb as new command builder
        Dim dsNewRow As DataRow 'declares dsNewRow as DataRow
        Dim RC As Integer 'Declares RC as Integer

        RC = DSDietsGiven.Tables("DietsGiven").Rows.Count - 1

        dsNewRow = DSDietsGiven.Tables("DietsGiven").NewRow()
        dsNewRow.Item("DietID") = Val(DSDietsGiven.Tables("DietsGiven").Rows(RC).Item(0)) + 1
        dsNewRow.Item("ClientID") = txtClientID.Text
        dsNewRow.Item("DietDate") = dtpDietDate.Text
        dsNewRow.Item("Comments") = txtComments.Text
        dsNewRow.Item("FollowUp") = txtFollowUp.Text

        DSDietsGiven.Tables("DietsGiven").Rows.Add(dsNewRow)  'Update the datasource
        DADietsGiven.Update(DSDietsGiven, "DietsGiven")        'Update the database table

        'Inform user of successful database update
        MsgBox("New record added succesfully ...", vbOK, "Dr George Davis Nutrition")

    End Sub


End Class