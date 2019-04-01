Public Class Day
    Dim inc As Integer 'declares inc
    Dim MaxRows As Integer 'declares MaxRows as integer
    Dim con As New OleDb.OleDbConnection 'declares con as new oledbConnection
    Dim dbProvider As String 'declares dbProvider as string
    Dim dbSource As String 'declares dbSource as string
    Dim DSDay, DSFood, DSBreakfast, DSLunch, DSDinner, DSSnack, DSDrink As New DataSet
    'declares DSDay, DSFood, DSBreakfast, DSLunch, DSDinner, DSSnack, DSDrink as new dataset
    Dim DADay, DAFood, DABreakfast, DALunch, DADinner, DASnack, DADrink As OleDb.OleDbDataAdapter
    'declares DADay, DAFood, DABreakfast, DALunch, DADinner, DASnack, DADrink as dataAdaptor
    Dim SQLDay, SQLFood, SQLBreakfast, SQLLunch, SQLDinner, SQLSnack, SQLDrink As String
    'declares SQLDay, SQLFood, SQLBreakfast, SQLLunch, SQLDinner, SQLSnack, SQLDrink as string
    Dim FoodDays(4) As String
    'creates an array Foodays(4) and declares it as an array 
    Dim MaxFoodDays(4) As Integer
    'creates an array Foodays(4) and declares it as an array 
    Private Sub Day_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim I, D As Integer

        dbProvider = "PROVIDER=Microsoft.Ace.OLEDB.12.0;" 'Set technology to use
        dbSource = "Data Source =C:\WindowsApplication1\WindowsApplication1\WindowsApplication1\Resources\Vasilis.accdb"
        'Set file including path to use

        con.ConnectionString = dbProvider & dbSource  'Define the connection string including technology, path & file to use

        Me.Text = create.txtDay.Text
        lblDay.Text = Me.Text

        FoodDays(0) = "TblForBreakfast"
        FoodDays(1) = "TblForLunch"
        FoodDays(2) = "TblForDinner"
        FoodDays(3) = "TblForSnack"
        FoodDays(4) = "TblForDrink"

        DSDay.Clear() 'clear data set

        SQLDay = "SELECT * FROM TblDietDetails" 'selects data from the database table diet details
        DADay = New OleDb.OleDbDataAdapter(SQLDay, con) 'Create the new data adapter
        DADay.Fill(DSDay, "DietDetails") ''Fill the data set with records from a table. DietDetails will hold this

        MaxRows = DSDay.Tables("DietDetails").Rows.Count - 1
        'sets up a loop filling up the array FoodDay(I)
        For I = 0 To 4
            DSFood.Clear()
            SQLFood = "SELECT * FROM " & FoodDays(I)
            DAFood = New OleDb.OleDbDataAdapter(SQLFood, con)
            DAFood.Fill(DSFood, "Food")
            MaxFoodDays(I) = DSFood.Tables("Food").Rows.Count - 1
            If I = 0 Then
                For D = 0 To MaxFoodDays(I)
                    cmbBreakfast.Items.Add(DSFood.Tables("Food").Rows(D).Item(1))
                Next
            ElseIf I = 1 Then
                For D = 0 To MaxFoodDays(I)
                    cmbLunch.Items.Add(DSFood.Tables("Food").Rows(D).Item(1))
                Next
            ElseIf I = 2 Then
                For D = 0 To MaxFoodDays(I)
                    cmbDinner.Items.Add(DSFood.Tables("Food").Rows(D).Item(1))
                Next
            ElseIf I = 3 Then
                For D = 0 To MaxFoodDays(I)
                    cmbSnack.Items.Add(DSFood.Tables("Food").Rows(D).Item(1))
                Next
            Else
                For D = 0 To MaxFoodDays(I)
                    cmbDrink.Items.Add(DSFood.Tables("Food").Rows(D).Item(1))
                Next
            End If
        Next


    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Close()  'hides current window
        create.Visible = True  'goes back to create screen
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        Dim cb As New OleDb.OleDbCommandBuilder(DADay)
        Dim dsNewRow As DataRow
        Dim D, Max As Integer
        inc = inc + 1
        'Create a new row for the database
        'Set the contents of each textbox to the corresponding field 
        dsNewRow = DSDay.Tables("DietDetails").NewRow()
        dsNewRow.Item("DietID") = create.txtDietID.Text
        dsNewRow.Item("DietDay") = lblDay.Text

        'creates a loop and saves the data stored in the text boxes to the 
        'coresponding table. 
        DSBreakfast.Clear() 'clears the data set
        SQLBreakfast = "SELECT * FROM TblForBreakfast"
        DABreakfast = New OleDb.OleDbDataAdapter(SQLBreakfast, con)
        DABreakfast.Fill(DSBreakfast, "Breakfast")
        Max = DSBreakfast.Tables("Breakfast").Rows.Count - 1
        For D = 0 To Max
            If cmbBreakfast.Text = DSBreakfast.Tables("Breakfast").Rows(D).Item(1) Then
                dsNewRow.Item("Breakfast") = DSBreakfast.Tables("Breakfast").Rows(D).Item(0)
                D = Max
            End If
        Next
        'creates a loop and saves the data stored in the text boxes to the 
        'coresponding table. 
        DSLunch.Clear() 'clears the data set
        SQLLunch = "SELECT * FROM TblForLunch"
        DALunch = New OleDb.OleDbDataAdapter(SQLLunch, con)
        DALunch.Fill(DSLunch, "Lunch")
        Max = DSLunch.Tables("Lunch").Rows.Count - 1
        For D = 0 To Max
            If cmbLunch.Text = DSLunch.Tables("Lunch").Rows(D).Item(1) Then
                dsNewRow.Item("Lunch") = DSLunch.Tables("Lunch").Rows(D).Item(0)
                D = Max
            End If
        Next
        'creates a loop and saves the data stored in the text boxes to the 
        'coresponding table. 
        DSDinner.Clear() 'clears the data set
        SQLDinner = "SELECT * FROM TblForDinner"
        DADinner = New OleDb.OleDbDataAdapter(SQLDinner, con)
        DADinner.Fill(DSDinner, "Dinner")
        Max = DSDinner.Tables("Dinner").Rows.Count - 1
        For D = 0 To Max
            If cmbDinner.Text = DSDinner.Tables("Dinner").Rows(D).Item(1) Then
                dsNewRow.Item("Dinner") = DSDinner.Tables("Dinner").Rows(D).Item(0)
                D = Max
            End If
        Next
        'creates a loop and saves the data stored in the text boxes to the 
        'coresponding table. 
        DSSnack.Clear() 'clears the data set
        SQLSnack = "SELECT * FROM TblForSnack"
        DASnack = New OleDb.OleDbDataAdapter(SQLSnack, con)
        DASnack.Fill(DSSnack, "Snack")
        Max = DSSnack.Tables("Snack").Rows.Count - 1
        For D = 0 To Max
            If cmbSnack.Text = DSSnack.Tables("Snack").Rows(D).Item(1) Then
                dsNewRow.Item("Snack") = DSSnack.Tables("Snack").Rows(D).Item(0)
                D = Max
            End If
        Next
        'creates a loop and saves the data stored in the text boxes to the 
        'coresponding table. 
        DSDrink.Clear() 'clears the data set
        SQLDrink = "SELECT * FROM TblForDrink"
        DADrink = New OleDb.OleDbDataAdapter(SQLDrink, con)
        DADrink.Fill(DSDrink, "Drink")
        Max = DSDrink.Tables("Drink").Rows.Count - 1
        For D = 0 To Max
            If cmbDrink.Text = DSDrink.Tables("Drink").Rows(D).Item(1) Then
                dsNewRow.Item("Drink") = DSDrink.Tables("Drink").Rows(D).Item(0)
                D = Max
            End If
        Next

        DSDay.Tables("DietDetails").Rows.Add(dsNewRow)  'Update the datasource
        DADay.Update(DSDay, "TblDietDetails")        'Update the database table

        MsgBox("New record added succesfully ...", vbOK, "Dr George Davis Nutrition")
        'displays a messagebox that the new record has been saved

    End Sub
End Class