Public Class login
    Dim con As New OleDb.OleDbConnection 'declares variable con as a database connection
    Dim dbProvider As String    'declares dbProvider As String
    Dim dbSource As String  'declares dbSource As Strings
    Dim ds As New DataSet   'declares ds as Dataset
    Dim da As OleDb.OleDbDataAdapter 'declares da as Oledb.OledbdataAdapter
    Dim sql As String 'declares sql as  string
    Dim inc As Integer 'declares inc as integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If txtusername.Text = "george" And txtpassword.Text = "nutrition" Then mainmenu.Show() _
            Else MsgBox("Sorry, The Username or Password was wrong.", MsgBoxStyle.Critical, "Information")
        Me.Hide() 'hideslogin screen
        'checks if user name"george" and password "nutritionist" are correct.
        'If credentials are correct then it sends the user to the main menu 
        'if credentials are wrong then it displays a message box alerting the user it is wrong
    End Sub

    Private Sub login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dbProvider = "PROVIDER = MICROSOFT.ACE.OLEDB.12.0;"
        'specifies which provider technology we want to use to do the connecting 
        dbSource = "Data Source = C:\WindowsApplication1\WindowsApplication1\WindowsApplication1\Resources\Vasilis.accdb" 'source of file

        con.ConnectionString = dbProvider And dbSource 'initiates a connection to the database. 
        con.Open() 'opens connection to database
        sql = "select FROM tblClient" 'selects data from client table
        da = New OleDb.OleDbDataAdapter(sql, con) 'declares an new data adaptor

        da.Fill(ds, "tblclients") 'fill table with clients


        MsgBox("Database is now open") 'shows a message box when connected
        con.Close() 'Closes database
        MsgBox("Database is now closed") 'shows a message box when closed

    End Sub
End Class
