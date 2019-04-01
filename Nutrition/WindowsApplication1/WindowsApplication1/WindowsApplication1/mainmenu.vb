Public Class mainmenu

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        End 'closes the application 
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreatenew.Click
        Me.Hide() 'hides create window
        create.Show()  'opens the create window
    End Sub

    Private Sub viewcurrentB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVdiets.Click
        Me.Hide() 'hides view window
        viewc.Show()  'opens the view current tables window
    End Sub

    Private Sub buttonC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewc.Click
        Me.Hide() 'hides the mainmenu
        ViewClient.ShowDialog() 'opens the view client form
    End Sub

    Private Sub BtnNewClient_Click(sender As System.Object, e As System.EventArgs) Handles BtnNewClient.Click
        Me.Hide() 'hides mainmenu
        NewClient.ShowDialog() 'opens the Newclient form
    End Sub
End Class



