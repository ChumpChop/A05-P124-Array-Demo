Public Class Form1
    'Declare a form level array
    Private strFriends(4) As String

    Private Sub Button1btnArrayElement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1btnArrayElement.Click

        'Clear the list
        ClearList()

        'Declare an array
        Dim strFriends(4) As String

        'Populate the array
        strFriends(0) = "Wendy"
        strFriends(1) = "Harriet"
        strFriends(2) = "Jay"
        strFriends(3) = "Michelle"
        strFriends(4) = "Richard"

        'Add the first array item to the list
        lstFriends.Items.Add(strFriends(0))

    End Sub

    Private Sub ClearList()

        'Clear the list
        lstFriends.Items.Clear()

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles Me.Load

        'Populate the array
        strFriends(0) = "Wendy"
        strFriends(1) = "Harriet"
        strFriends(2) = "Jay"
        strFriends(3) = "Michelle"
        strFriends(4) = "Richard"

    End Sub

    Private Sub btnEnumerateArray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnumerateArray.Click

        'Clear the list
        ClearList()

        'Enumerate the array
        For Each strName As String In strFriends
            'Add the array item to the list
            lstFriends.Items.Add(strName)
        Next

    End Sub

    Private Sub btnArraysAsParameters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArraysAsParameters.Click

        'Clear the list
        ClearList()

        'List your friends
        AddItemsToList(strFriends)

    End Sub

    Private Sub AddItemsToList(ByVal arrayList() As String)
        'Enumerate the array
        For Each strName As String In arrayList
            'Add the array item to the list
            lstFriends.Items.Add("[" & strName & "]")
        Next
    End Sub


    Private Sub btnMoreArrayParameters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoreArrayParameters.Click

        'Clear the list
        ClearList()

        'Declare an array
        Dim strMoreFriends(1) As String

        'Populate the array
        strMoreFriends(0) = "Elaine"
        strMoreFriends(1) = "Debra"

        'List your friends
        AddItemsToList(strFriends)
        AddItemsToList(strMoreFriends)

    End Sub

    Private Sub btnSortingArrays_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSortingArrays.Click

        'Clear the list
        ClearList()

        'Sort the array
        Array.Sort(strFriends)

        'List your friends
        AddItemsToList(strFriends)

    End Sub

    Private Sub btnReversingAnArray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReversingAnArray.Click

        'Clear the list
        ClearList()

        'Reverse the order—elements will be in descending order
        Array.Reverse(strFriends)

        'List your friends
        AddItemsToList(strFriends)

    End Sub

    Private Sub btnInitializingArraysWithValues_Click( _
        ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnInitializingArraysWithValues.Click

        'Clear the list
        ClearList()

        'Declare and populate an array
        Dim strMyFriends() As String = {"Elaine", "Richard", "Debra", _
            "Wendy", "Harriet"}

        'Make the strMyFriends array larger
        ReDim Preserve strMyFriends(6)
        strMyFriends(5) = "Lane"
        strMyFriends(6) = "Joel"

        'List your friends
        AddItemsToList(strMyFriends)
    End Sub

End Class
