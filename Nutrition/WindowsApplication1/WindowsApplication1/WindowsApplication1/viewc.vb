Public Class viewc
    Dim Con As New OleDb.OleDbConnection 'Set up a new connection for the database
    Dim MaxRows, NumClients, inc As Integer
    Dim DBProvider As String 'Declare the variable for the technology to use
    Dim DBSource As String 'Declare the variable for the data source to use (i.e. path and file)
    Dim DSQuery, DSClient As New DataSet 'Declare the variable for the dataset to use
    Dim DAQuery, DAClient As OleDb.OleDbDataAdapter 'Declare the variable for the data adapter to use
    Dim SQLQuery, SQLClient As String 'Declare the variable to hold the SQL statement

    Private Sub viewc_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DBProvider = "PROVIDER = MICROSOFT.ACE.OLEDB.12.0;" 'Set technology to use

        DBSource = "Data Source = C:\WindowsApplication1\WindowsApplication1\WindowsApplication1\Resources\Vasilis.accdb" 'Set file including path to use

        Con.ConnectionString = DBProvider & DBSource 'Define the connection string including technology, path & file to use

        SQLquery = "SELECT * FROM QryDietsSubscribed" 'Declare the SQL statement (Choose all fields from table )
        DAQuery = New OleDb.OleDbDataAdapter(SQLQuery, Con) 'Create the new data adapter
        DAQuery.Fill(DSQuery, "QryDietsSubscribed") 'Fill the data set with records from a table. QryDietsSubscribed will hold this 
        MaxRows = DSQuery.Tables("QryDietsSubscribed").Rows.Count - 1
        'DataGridView.DataSource = DSQuery.Tables("QryDietsSubscribed")

        SQLClient = "SELECT * FROM tblClient" 'Declare the SQL statement (Choose all fields from table )
        DAClient = New OleDb.OleDbDataAdapter(SQLClient, Con) 'Create the new data adapter
        DAClient.Fill(DSClient, "tblClient") 'Fill the data set with records from a table. QryDietsSubscribed will hold this 

        NumClients = DSClient.Tables("tblClient").Rows.Count - 1
        inc = 0 'sets the inc value to zero 
        NavigateRecords()

        DSQuery.Clear() 'clears the dataset
        dgrDietsWritten.Refresh() 'refreshes the datagrid view

        DAQuery.Fill(DSQuery, "QryDietsSubscribed")         'Fill the data set with records from the query. QryDietsSubscribed will hold this data

        Me.dgrDietsWritten.DataSource = DSQuery.Tables("QryDietsSubscribed")
        dgrDietsWritten.Columns(0).Visible = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide() 'hide view menu
        mainmenu.Show()  'goes back to the mainmenu 

    End Sub

    Private Sub NavigateRecords()
        dgrDietsWritten.DataSource = DSQuery.Tables("QryDietsSubscribed")
        dgrDietsWritten.Refresh() 'refreshes the datagrid
        DSQuery.Clear() 'clear the data source
        dgrDietsWritten.DataSource = Nothing
        dgrDietsWritten.Refresh() 'refreshes the data grid view

        End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim Criteria As String = "*" 'declares Criteria As String'declares criteria as string
        Dim Counter As Integer = 0 'declares counter As integer sets its value to 0 'declares counter as integer and sets its value to zero 
        Dim MatchingRecords(MaxRows) As String 'declares MatchingRecords as String

        Criteria = InputBox("Please enter customer name to search for...", "George Davis Nutrition", vbOKCancel)
        Criteria = Criteria & "*"

        DSQuery.Clear() 'clears the dataset

        SQLQuery = "SELECT * FROM QryDietsSubscribed" 'Declare the SQL statement (Choose all fields from table )
        DAQuery = New OleDb.OleDbDataAdapter(SQLQuery, Con) 'Create the new data adapter
        DAQuery.Fill(DSQuery, "QryDietsSubscribed") 'Fill the data set with records from a table. QryDietsSubscribed will hold this 
        MaxRows = DSQuery.Tables("QryDietsSubscribed").Rows.Count - 1

        For Counter = 0 To MaxRows 'creates a loop 
            MatchingRecords(Counter) = "None" 'sets counter to null 
            If UCase(DSQuery.Tables("QryDietsSubscribed").Rows(Counter).Item(1)) Like UCase(Criteria) Then
                MatchingRecords(Counter) = DSQuery.Tables("QryDietsSubscribed").Rows(Counter).Item(0)
            End If
        Next

        DSQuery.Clear() 'clears the dataset
        dgrDietsWritten.Refresh() 'refreshes datagrid

        For Counter = 0 To MaxRows 'creates a loop 
            If MatchingRecords(Counter) <> "None" Then
                SQLQuery = "SELECT * FROM QryDietsSubscribed WHERE (MyKey = '" & MatchingRecords(Counter) & "')"
                'Declare the SQL statement (Choose all fields from table )
                DAQuery = New OleDb.OleDbDataAdapter(SQLQuery, Con) 'Create the new data adapter
                DAQuery.Fill(DSQuery, "QryDietsSubscribed") 'Fill the data set with records from a table. QryDietsSubscribed will hold this 
                'MaxRows = DSQuery.Tables("QryDietsSubscribed").Rows.Count - 1
                dgrDietsWritten.DataSource = DSQuery.Tables("QryDietsSubscribed")
                dgrDietsWritten.Columns(0).Visible = False
            End If
        Next
    End Sub
End Class

