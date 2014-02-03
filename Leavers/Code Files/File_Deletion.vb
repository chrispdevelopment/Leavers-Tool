Imports System.IO

Public Class File_Deletion

    'Sets up varibles.
    Dim homedirs As String
    Dim profile As String
    Dim appdata_terminal As String
    Dim appdata_workstation As String
    Dim appdata_laptop As String
    Dim deletion_result As String

    'Sets up code file for use
    Dim AD As New AD

    Public Function FileDeletion(ByVal folderPath As String) As String 'Fucntion for deletion of folders
        Try
            If System.IO.Directory.Exists(folderPath) = False Then 'Checks for existence of folder
                Return "False"
            Else
                My.Computer.FileSystem.DeleteDirectory(folderPath, FileIO.UIOption.AllDialogs, _
                                   FileIO.RecycleOption.DeletePermanently, _
                                   FileIO.UICancelOption.DoNothing) 'If the folder is found delete it
                Return "True"
            End If
        Catch 'Error Handling
            Beep() 'PC beeps at user
            Return "Error" 'Function returns this if there is an error
            End
        End Try
    End Function

    Public Sub Deletions()

        'Pass full folder paths into varibles
        homedirs = My.Settings.Homdirs + Main.loginName
        profile = My.Settings.Profile + Main.loginName
        appdata_terminal = My.Settings.appdata_terminal + Main.loginName
        appdata_laptop = My.Settings.appdata_laptop + Main.loginName
        appdata_workstation = My.Settings.appdata_workstation + Main.loginName


        'Message box that only continues if the Ok button is pressed
        If MessageBox.Show("This process will permanently delete files do you wish to continue", _
                           "Folder Deletion", MessageBoxButtons.OKCancel) _
                           = Windows.Forms.DialogResult.OK Then

            'Profile Folder Deletion. Results passed into results array.
            deletion_result = FileDeletion(profile)
            If deletion_result = "False" Then
                Main.Results(1) = "Profile Folder Could Not Be Found"
            ElseIf deletion_result = "Error" Then
                AD.EnableAccount(Main.userName) 'Account is checked to see if it is enabled. If not it is enabled
                AD.SetPassword(Main.path, My.Settings.Password) 'Account password set to pre-defined varible
                MessageBox.Show("Unable to delete Profile folder please run first run on this account." + Chr(13) + "Password for account has been reset to Probation2011", _
                                "File Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error, _
                                MessageBoxDefaultButton.Button1)
                Exit Sub
                'Message displayed to get the user to login as the user to be deleted with specified password 
                'and run the first run script then try again.
            Else
                Main.Results(1) = "Profile Folder Has Been Deleted"
            End If

            'Homedirs Folder Deletion. Results passed into results array.
            deletion_result = FileDeletion(homedirs)
            If deletion_result = "False" Then
                Main.Results(2) = "HomeDir Folder Could Not Be Found"
            ElseIf deletion_result = "Error" Then
                Main.Results(2) = "Unable to Delete Homedir folder"
            Else
                Main.Results(2) = "Homedir Folder Has Been Deleted"
            End If

            'Appdata Terminal Folder Deletion. Results passed into results array.
            deletion_result = FileDeletion(appdata_terminal)
            If deletion_result = "False" Then
                Main.Results(3) = "Terminal Folder Could Not Be Found"
            ElseIf deletion_result = "Error" Then
                Main.Results(3) = "Unable to Delete Terminal folder"
            Else
                Main.Results(3) = "Terminal Folder Has Been Deleted"
            End If

            'Appdata Workstation Folder Deletion. Results passed into results array.
            deletion_result = FileDeletion(appdata_workstation)
            If deletion_result = "False" Then
                Main.Results(4) = "Workstation Folder Could Not Be Found"
            ElseIf deletion_result = "Error" Then
                Main.Results(4) = "Unable to Delete Workstation folder"
            Else
                Main.Results(4) = "Workstation Folder Has Been Deleted"
            End If

            'Appdata Laptop Folder Deletion. Results passed into results array.
            deletion_result = FileDeletion(appdata_laptop)
            If deletion_result = "False" Then
                Main.Results(5) = "Laptop Folder Could Not Be Found"
            ElseIf deletion_result = "Error" Then
                Main.Results(5) = "Unable to Delete Laptop folder"
            Else
                Main.Results(5) = "Laptop Folder Has Been Deleted"
            End If

            'Call Results form
            Dim results As New Results()
            results.Show()
        End If
    End Sub
End Class
