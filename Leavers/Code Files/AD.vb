Imports System.DirectoryServices
Imports System.Security.Principal
Imports System.Threading
Imports System.Globalization
Imports System.DirectoryServices.AccountManagement

Public Class AD

    Private Const UF_ACCOUNTDISABLE = &H2 'Constant value for the enable account function

    Public Shared Sub SetCultureAndIdentity() 'Sets the current program to use the details of the loggged in user for AD connections
        AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal)
        Dim principal As WindowsPrincipal = CType(Thread.CurrentPrincipal, WindowsPrincipal)
        Dim identity As WindowsIdentity = CType(principal.Identity, WindowsIdentity)
        System.Threading.Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
    End Sub

    Public Sub SetPassword(ByVal path As String, ByVal pass As String) 'Sets account password to pre-defined varible
        Try
            Dim usr As New DirectoryEntry
            usr.Path = path
            usr.AuthenticationType = AuthenticationTypes.Secure
            Dim password As Object() = New Object() {pass}
            Dim ret As Object = usr.Invoke("SetPassword", password)
            usr.CommitChanges()
            usr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Active Directory Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function VerifyUser(ByVal userName As String) As Boolean 'checks that the account exists
        Try
            Dim de As New DirectoryEntry
            Dim deSearch As DirectorySearcher = New DirectorySearcher()
            de.Path = "LDAP://" + My.Settings.LDAP_IP + "/" + My.Settings.LDAP_Path
            deSearch.SearchRoot = de
            deSearch.Filter = "(&(objectClass=user) (cn=" & userName & "))"
            Dim results As SearchResultCollection = deSearch.FindAll()
            If results.Count = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Active Directory Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Sub GetLoginName() 'Gets username name from account details
        Dim de As New DirectoryEntry
        Dim deSearch As New DirectorySearcher(de)
        de.Path = Main.path
        Main.loginName = de.InvokeGet("sAMAccountName").ToString
    End Sub

    Public Sub DeleteUser(ByVal loginname As String) 'Deletes account from AD
        Try
            Dim de As New DirectoryEntry
            Dim User As DirectoryEntry
            de.Path = "LDAP://" + My.Settings.LDAP_IP + "/" + My.Settings.LDAP_Path
            User = de.Children.Find("CN=" + loginname)
            de.Children.Remove(User)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Active Directory Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub EnableAccount(ByVal loginname As String) 'Enables account
        Try
            Dim de As New DirectoryEntry
            Dim User As DirectoryEntry
            de.Path = "LDAP://" + My.Settings.LDAP_IP + "/" + My.Settings.LDAP_Path
            User = de.Children.Find("CN=" + loginname)
            User.Properties("userAccountControl").Value = (CType(User.Properties("userAccountControl").Value, Integer) And Not UF_ACCOUNTDISABLE)
            User.CommitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Active Directory Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function ListADUsers() 'Function to return a list of all AD users

        Dim dirEntry As New DirectoryEntry
        dirEntry.Path = "LDAP://" + My.Settings.LDAP_IP + "/" + My.Settings.LDAP_Path
        Dim userList As New Collection()
        '   1. Search the Active Directory for all objects with type of computer
        Try
            Dim dirSearcher As DirectorySearcher = New DirectorySearcher(dirEntry)
            dirSearcher.Filter = "(objectClass=user)"
            '   2. Check the search results
            Dim dirSearchResults As SearchResult
            '   3. Loop through all the computer names returned
            For Each dirSearchResults In dirSearcher.FindAll()
                '   4. Check to ensure the computer name isnt already listed in the collection
                'If Not pcList.Contains(dirSearchResults.GetDirectoryEntry().Name.ToString()) Then
                '   5. Add the computer name to the collection (since it dont already exist)
                userList.Add(dirSearchResults.GetDirectoryEntry().Properties.Item("cn").Value)
                'For Each item In userList
                'Dim result = item
                'Next
                'End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Active Directory Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        '   6. Return the results
        Return userList

    End Function
End Class
