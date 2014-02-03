Imports System.Windows.Forms.Form

Public Class Results
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Displays results from run of deletions sub
        txtProfile.Text = Main.Results(1)
        txtHomedir.Text = Main.Results(2)
        lstAppdata.Items.Add(Main.Results(3))
        lstAppdata.Items.Add(Main.Results(4))
        lstAppdata.Items.Add(Main.Results(5))
    End Sub
End Class
