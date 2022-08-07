Public Class Form1
    Dim second As Integer
    Dim minute As Integer
    Dim hour As Integer
    Private Sub btexit_Click(sender As Object, e As EventArgs) Handles btexit.Click
        Dim bt_exit As MsgBoxResult
        bt_exit = MsgBox("จบการทำข้อสอบ ใช่ หรือ ไม่ ?", MsgBoxStyle.YesNo, "จบการสอบ")
        If bt_exit = MsgBoxResult.Yes Then
            MsgBox("เลิกการทำงาน", MsgBoxStyle.Exclamation, "จบการทำงาน")
            Application.Exit()
        Else
            bt_exit = MsgBoxResult.No
        End If
    End Sub

    Private Sub btok_Click(sender As Object, e As EventArgs) Handles btok.Click
        Dim correct As Integer
        Dim inconnect As Integer
        Dim percent As Integer
        If tbname.Text = "" Then
            MsgBox("กรุณากรอกชื่อ-นามสกุลก่อน!", MsgBoxStyle.Exclamation, "ข้อมูลผิดพลาด")
            tbname.Focus()
        Else
            If Rb11.Checked = False And Rb12.Checked = False And Rb13.Checked = False And Rb14.Checked = False Then
                MsgBox("กรุณาทำโจทย์ข้อ 1 ก่อน", MsgBoxStyle.Exclamation, "ข้อมูลผิดพลาด")
            Else
                If Rb21.Checked = False And Rb22.Checked = False And Rb23.Checked = False And Rb24.Checked = False Then
                    MsgBox("กรุณาทำโจทย์ข้อ 2 ก่อน", MsgBoxStyle.Exclamation, "ข้อมูลผิดพลาด")
                Else
                    If Rb31.Checked = False And Rb32.Checked = False And Rb33.Checked = False And Rb34.Checked = False Then
                        MsgBox("กรุณาทำโจทย์ข้อ 3 ก่อน", MsgBoxStyle.Exclamation, "ข้อมูลผิดพลาด")
                    Else
                        If Rb41.Checked = False And Rb42.Checked = False And Rb43.Checked = False And Rb44.Checked = False Then
                            MsgBox("กรุณาทำโจทย์ข้อ 4 ก่อน", MsgBoxStyle.Exclamation, "ข้อมูลผิดพลาด")
                        Else
                            Timer1.Stop()
                            If Rb14.Checked Then
                                correct = correct + 1
                            End If
                            If Rb22.Checked Then
                                correct = correct + 1
                            End If
                            If Rb33.Checked Then
                                correct = correct + 1
                            End If
                            If Rb41.Checked Then
                                correct = correct + 1
                            End If

                            inconnect = 4 - correct
                            percent = (correct * 100) / 4
                            MsgBox("ชื่อ " & tbname.Text & vbCrLf & "ถูกต้อง " & correct & " ข้อ" & vbCrLf & "ผิด " & inconnect & " ข้อ" & vbCrLf & "คิดเป็น %   = " & percent & " %")
                            End If
                        End If
                    End If
                End If
            End If
    End Sub

    Private Sub btclear_Click(sender As Object, e As EventArgs) Handles btclear.Click
        Rb11.Checked = False
        Rb12.Checked = False
        Rb13.Checked = False
        Rb14.Checked = False
        Rb21.Checked = False
        Rb22.Checked = False
        Rb23.Checked = False
        Rb24.Checked = False
        Rb31.Checked = False
        Rb32.Checked = False
        Rb33.Checked = False
        Rb34.Checked = False
        Rb41.Checked = False
        Rb42.Checked = False
        Rb43.Checked = False
        Rb44.Checked = False
        tbname.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        second = 0
        minute = 3
        hour = 0
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        GroupBox4.Enabled = False
        btclear.Enabled = False
        btok.Enabled = False
        btexit.Enabled = True

        Rb11.Checked = False
        Rb12.Checked = False
        Rb13.Checked = False
        Rb14.Checked = False
        Rb21.Checked = False
        Rb22.Checked = False
        Rb23.Checked = False
        Rb24.Checked = False
        Rb31.Checked = False
        Rb32.Checked = False
        Rb33.Checked = False
        Rb34.Checked = False
        Rb41.Checked = False
        Rb42.Checked = False
        Rb43.Checked = False
        Rb44.Checked = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ans As String
        Dim anm As String
        Dim anh As String

        second = second - 1
        If second < 0 Then
            second = 59
            minute = minute - 1
        End If

        If minute < 0 Then
            minute = 59
            hour = hour - 1
        End If

        If second < 10 Then
            ans = ":" & 0 & second.ToString
        Else
            ans = ":" & second.ToString
        End If

        If minute < 10 Then
            anm = ":" & 0 & minute.ToString
        Else
            anm = ":" & minute.ToString
        End If

        If hour < 10 Then
            anh = "" & 0 & hour.ToString
        Else
            anh = "" & hour.ToString
        End If

        If hour <= 0 And minute <= 0 And second <= 0 Then
            Timer1.Stop()
            MsgBox("หมดเวลาทำข้อสอบแล้ว!", MsgBoxStyle.Information, "ข้อมูลผิดพลาด")
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            GroupBox4.Enabled = False
            btclear.Enabled = False
            btok.Enabled = False
            tbname.Enabled = False
        End If
        lboutput.Text = anh & anm & ans
    End Sub

    Private Sub bttimer_Click(sender As Object, e As EventArgs) Handles bttimer.Click
        

        If tbname.Text = "" Then
            MsgBox("กรุณากรอกชื่อ-นามสกุลก่อน!", MsgBoxStyle.Exclamation, "ข้อมูลผิดพลาด")
            tbname.Focus()
        Else
            Timer1.Start()
            Timer1.Interval = 800
            bttimer.Enabled = False
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            GroupBox3.Enabled = True
            GroupBox4.Enabled = True
            btok.Enabled = True
            btclear.Enabled = True
            btexit.Enabled = True
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lboutput.Click

    End Sub

    Private Sub tbname_TextChanged(sender As Object, e As EventArgs) Handles tbname.TextChanged

    End Sub

    Private Sub Rb44_CheckedChanged(sender As Object, e As EventArgs) Handles Rb44.CheckedChanged

    End Sub
End Class
