Public Class ViewClient
    Dim Con As New OleDb.OleDbConnection 'Set up a new connection for the database
    Dim DBProvider As String 'Declare the variable for the technology to use
    Dim DBSource As String 'Declare the variable for the data source to use (i.e. path and file)
    Dim DSClient As New DataSet() 'Declare the variable for the dataset to use
    Dim DAClient As OleDb.OleDbDataAdapter 'Declare the variable for the data adapter to use
    Dim SQLClient As String 'Declare the variable to hold the SQL statement
    Dim NumClients As Integer 'Declares NumClients As Integer

    Private Sub ViewClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DBProvider = "PROVIDER = MICROSOFT.ACE.OLEDB.12.0;" 'Set technology to use
        DBSource = "Data Source = C:\WindowsApplication1\WindowsApplication1\WindowsApplication1\Resources\Vasilis.accdb" 'Set file including path to use
        Con.ConnectionString = DBProvider & DBSource 'Define the connection string including technology, path & file to use

        DSClient.Clear() 'clears the dataset
        dgrClients.Refresh() 'refreshes the datagrid

        SQLClient = "SELECT * FROM TblClient" 'Declare the SQL statement (Choose all fields from table )
        DAClient = New OleDb.OleDbDataAdapter(SQLClient, Con) 'Create the new data adapter
        DAClient.Fill(DSClient, "TblClient") 'Fill the data set with records from a table. tblclient will hold this 
        NumClients = DSClient.Tables("TblClient").Rows.Count - 1

        dgrClients.DataSource = DSClient.Tables("TblClient")

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim Criteria As String = "*" 'declares Criteria As String'declares Criteria As String
        Dim Counter As Integer = 0 'declares counter As integer sets its value to 0 'declares counter As integer sets its value to 0
        Dim MatchingRecords(NumClients) As Integer 'declares MatchingRecords(NumClients) as integer

        Criteria = InputBox("Please enter customer name to search for...", "George Davis Nutrition", vbOKCancel)
        'opens a text box asking for the user to enter the name of the customer to search for
        Criteria = Criteria & "*"

        DSClient.Clear()                        'Clear the dataset

        'Set the SQL to be free of any filtering and set the data adapter and dataset again to start a new search
        SQLClient = "SELECT * FROM TblClient" 'Declare the SQL statement (Choose all fields from table )
        DAClient = New OleDb.OleDbDataAdapter(SQLClient, Con) 'Create the new data adapter
        DAClient.Fill(DSClient, "TblClient") 'Fill the data set with records from a table. TblClient will hold this 
        NumClients = DSClient.Tables("TblClient").Rows.Count - 1

        For Counter = 0 To NumClients 'creates a loop
            MatchingRecords(Counter) = -1 'sets counter to -1
            If UCase(DSClient.Tables("tblClient").Rows(Counter).Item(1)) Like UCase(Criteria) Then
                MatchingRecords(Counter) = DSClient.Tables("tblClient").Rows(Counter).Item(0)
            End If
        Next

        DSClient.Clear() 'clears dataset
        dgrClients.Refresh() 'refreshes datagrid 

        For Counter = 0 To NumClients 'creates a loop
            If MatchingRecords(Counter) >= 0 Then
                SQLClient = "SELECT * FROM TblClient WHERE (ClientID =" & MatchingRecords(Counter) & ")" 'Declare the SQL statement (Choose all fields from table )
                DAClient = New OleDb.OleDbDataAdapter(SQLClient, Con) 'Create the new data adapter
                DAClient.Fill(DSClient, "TblClient") 'Fill the data set with records from a table. TblClient will hold this 
                'NumClients = DSClient.Tables("TblClient").Rows.Count - 1
                dgrClients.DataSource = DSClient.Tables("TblClient")
            End If
        Next
       
    End Sub

    Private Sub btnViewDiets_Click(sender As System.Object, e As System.EventArgs) Handles btnViewDiets.Click
        Me.Hide() 'hides current window
        viewc.Show()  'opens the view tables window
    End Sub

    Private Sub btnMainMenu_Click(sender As System.Object, e As System.EventArgs) Handles btnMainMenu.Click
        Me.Hide() 'hides current window
        mainmenu.Show()  'opens the mainmenu window
    End Sub

    Private Sub btnCreateDiet_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateDiet.Click
        Me.Hide() 'hides current window
        create.Show()  'opens the create window
    End Sub

    Private Sub btnNewClient_Click(sender As System.Object, e As System.EventArgs) Handles btnNewClient.Click
        Me.Close() 'closes window
        'Me.Hide()
        NewClient.Visible = True 'makes new client visible
    End Sub
End Class