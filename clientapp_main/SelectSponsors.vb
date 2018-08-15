Imports System.Windows.Forms

Public Class SelectSponsors
    Private _signatorie As Boolean

    Public Property IsSignatories As Boolean
        Get
            Return _signatorie
        End Get
        Set(value As Boolean)
            Label2.Enabled = value
            ListBox2.Enabled = value
            Button3.Enabled = value
            Button4.Enabled = value
            _signatorie = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Sub MoveItems(sourse As ListBox, target As ListBox)
        If Not sourse.SelectedItems.Equals(Nothing) Then
            For Each i As Object In sourse.SelectedItems
                target.Items.Add(i)
            Next
            Dim a As Integer = sourse.SelectedItems.Count
            For i = 1 To a
                sourse.Items.RemoveAt(sourse.SelectedIndices(0))
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button3.Click
        Dim listbox As New ListBox
        If sender.Equals(Button1) Then listbox = ListBox1
        If sender.Equals(Button3) Then listbox = ListBox2
        Call MoveItems(ListBox3, listbox)
    End Sub

    Private Sub button2_click(sender As Object, e As EventArgs) Handles Button2.Click, Button4.Click
        Dim listbox As New ListBox
        If sender.Equals(Button2) Then listbox = ListBox1
        If sender.Equals(Button4) Then listbox = ListBox2
        Call MoveItems(listbox, ListBox3)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        IsSignatories = CheckBox1.Checked
    End Sub
End Class
