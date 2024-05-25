Public Class Form1


    Dim ProcID As Integer = 0
    Dim ProcessCNCT As Process
    Dim MyOrgin As Point

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Find CNC program and save proc-id for sending keystrokes

        For Each p As Process In Process.GetProcesses
            'ListBox1.Items.Add(p.ProcessName.ToString)
            If String.Compare(p.ProcessName, "cnct", True) = 0 Or String.Compare(p.ProcessName, "cncm", True) = 0 Then
                ProcID = p.Id
                ProcessCNCT = p
            End If
        Next

        If ProcID = 0 Then
            MsgBox("No CNC program is active, will close the programm.")
            Me.Dispose()
        End If

        Me.FormBorderStyle = FormBorderStyle.None

        MyOrgin = Me.Location

        Timer1.Enabled = True

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.FormBorderStyle = FormBorderStyle.None

        ' Activate the CNC application.
        AppActivate(ProcID)
        ' Send the keystrokes to the CNC application.
        My.Computer.Keyboard.SendKeys("1", True)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Activate the CNC application.
        AppActivate(ProcID)
        ' Send the keystrokes to the CNC application.
        My.Computer.Keyboard.SendKeys("2", True)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ' Activate the CNC application.
        AppActivate(ProcID)
        ' Send the keystrokes to the CNC application.
        My.Computer.Keyboard.SendKeys("3", True)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ' Activate the CNC application.
        AppActivate(ProcID)
        ' Send the keystrokes to the CNC application.
        My.Computer.Keyboard.SendKeys("4", True)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        ' Activate the CNC application.
        AppActivate(ProcID)
        ' Send the keystrokes to the CNC application.
        My.Computer.Keyboard.SendKeys("5", True)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        ' Activate the CNC application.
        AppActivate(ProcID)
        ' Send the keystrokes to the CNC application.
        My.Computer.Keyboard.SendKeys("6", True)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        ' Activate the CNC application.
        AppActivate(ProcID)
        ' Send the keystrokes to the CNC application.
        My.Computer.Keyboard.SendKeys("7", True)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        ' Activate the CNC application.
        AppActivate(ProcID)
        ' Send the keystrokes to the CNC application.
        My.Computer.Keyboard.SendKeys("8", True)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        ' Activate the CNC application.
        AppActivate(ProcID)
        ' Send the keystrokes to the CNC application.
        My.Computer.Keyboard.SendKeys("9", True)

    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click

        ' Activate the CNC application.
        AppActivate(ProcID)
        ' Send the keystrokes to the CNC application.
        My.Computer.Keyboard.SendKeys("0", True)

    End Sub

    Private Sub ButtonP_Click(sender As Object, e As EventArgs) Handles ButtonP.Click

        ' Activate the CNC application.
        AppActivate(ProcID)
        ' Send the keystrokes to the CNC application.
        My.Computer.Keyboard.SendKeys(".", True)

    End Sub

    Private Sub ButtonS_Click(sender As Object, e As EventArgs) Handles ButtonS.Click

        ' Activate the CNC application.
        AppActivate(ProcID)
        ' Send the keystrokes to the CNC application.
        My.Computer.Keyboard.SendKeys(" ", True)

    End Sub

    Private Sub ButtonM_Click(sender As Object, e As EventArgs) Handles ButtonM.Click

        ' Activate the CNC application.
        AppActivate(ProcID)
        ' Send the keystrokes to the CNC application.
        My.Computer.Keyboard.SendKeys("-", True)

    End Sub

    Private Sub ButtonL_Click(sender As Object, e As EventArgs) Handles ButtonL.Click

        ' Activate the CNC application.
        AppActivate(ProcID)
        ' Send the keystrokes to the CNC application.
        My.Computer.Keyboard.SendKeys("{LEFT}", True)

    End Sub


    Private Sub ButtonR_Click(sender As Object, e As EventArgs) Handles ButtonR.Click


        ' Activate the CNC application.
        AppActivate(ProcID)
        ' Send the keystrokes to the CNC application.
        My.Computer.Keyboard.SendKeys("{RIGHT}", True)


    End Sub

    Private Sub ButtonD_Click(sender As Object, e As EventArgs) Handles ButtonD.Click

        ' Activate the CNC application.
        AppActivate(ProcID)
        ' Send the keystrokes to the CNC application.
        My.Computer.Keyboard.SendKeys("{BACKSPACE}", True)

    End Sub

    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs) Handles ButtonEnter.Click

        ' Activate the CNC application.
        AppActivate(ProcID)
        ' Send the keystrokes to the CNC application.
        My.Computer.Keyboard.SendKeys("{ENTER}", True)

    End Sub

    Private Sub ButtonLCK_Click(sender As Object, e As EventArgs) Handles ButtonLCK.Click

        If ButtonLCK.Text = "Lock" Then
            'Me.FormBorderStyle = FormBorderStyle.None
            ButtonLCK.Text = "Move"
            Button0.Visible = True
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = True
            Button5.Visible = True
            Button6.Visible = True
            Button7.Visible = True
            Button8.Visible = True
            Button9.Visible = True
            Button0.Visible = True
            ButtonP.Visible = True
            ButtonS.Visible = True
            ButtonP.Visible = True
            ButtonM.Visible = True
            ButtonX.Visible = True
            ButtonY.Visible = True
            ButtonZ.Visible = True
            ButtonL.Visible = True
            ButtonR.Visible = True
            ButtonD.Visible = True
            ButtonEnter.Visible = True
            ButtonLM.Visible = False
            ButtonRM.Visible = False
            ButtonUM.Visible = False
            ButtonDM.Visible = False
            ButtonFree.Visible = False
        Else
            'Me.FormBorderStyle = FormBorderStyle.Fixed3D
            ButtonLCK.Text = "Lock"
            Button0.Visible = False
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            Button0.Visible = False
            ButtonP.Visible = False
            ButtonM.Visible = False
            ButtonS.Visible = False
            ButtonP.Visible = False
            ButtonX.Visible = False
            ButtonY.Visible = False
            ButtonZ.Visible = False
            ButtonL.Visible = False
            ButtonR.Visible = False
            ButtonD.Visible = False
            ButtonEnter.Visible = False
            ButtonLM.Visible = True
            ButtonRM.Visible = True
            ButtonUM.Visible = True
            ButtonDM.Visible = True
            ButtonFree.Visible = True
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ProcessCNCT.HasExited Then Me.Dispose()

    End Sub

    Private Sub ButtonX_Click(sender As Object, e As EventArgs) Handles ButtonX.Click


        ' Activate the CNC application.
        AppActivate(ProcID)
        ' Send the keystrokes to the CNC application.
        My.Computer.Keyboard.SendKeys("X", True)


    End Sub

    Private Sub ButtonY_Click(sender As Object, e As EventArgs) Handles ButtonY.Click


        ' Activate the CNC application.
        AppActivate(ProcID)
        ' Send the keystrokes to the CNC application.
        My.Computer.Keyboard.SendKeys("Y", True)


    End Sub

    Private Sub ButtonZ_Click(sender As Object, e As EventArgs) Handles ButtonZ.Click


        ' Activate the CNC application.
        AppActivate(ProcID)
        ' Send the keystrokes to the CNC application.
        My.Computer.Keyboard.SendKeys("Z", True)


    End Sub

    Private Sub ButtonLM_Click(sender As Object, e As EventArgs) Handles ButtonLM.Click

        If ButtonLCK.Text = "Lock" Then

            MyOrgin = Me.Location
            MyOrgin.X -= 1
            Me.Location = MyOrgin

        End If

    End Sub

    Private Sub ButtonRM_Click(sender As Object, e As EventArgs) Handles ButtonRM.Click

        If ButtonLCK.Text = "Lock" Then

            MyOrgin = Me.Location
            MyOrgin.X += 1
            Me.Location = MyOrgin

        End If

    End Sub

    Private Sub ButtonUM_Click(sender As Object, e As EventArgs) Handles ButtonUM.Click

        If ButtonLCK.Text = "Lock" Then

            MyOrgin = Me.Location
            MyOrgin.Y -= 1
            Me.Location = MyOrgin

        End If

    End Sub

    Private Sub ButtonDM_Click(sender As Object, e As EventArgs) Handles ButtonDM.Click

        If ButtonLCK.Text = "Lock" Then

            MyOrgin = Me.Location
            MyOrgin.Y += 1
            Me.Location = MyOrgin

        End If

    End Sub

    Private Sub ButtonFree_Click(sender As Object, e As EventArgs) Handles ButtonFree.Click

        If ButtonLCK.Text = "Lock" Then

            If ButtonFree.Text = "Free Move" Then
                ButtonFree.Text = "Fixed"
                Me.FormBorderStyle = FormBorderStyle.Fixed3D
            Else
                ButtonFree.Text = "Free Move"
                Me.FormBorderStyle = FormBorderStyle.None
            End If

        End If

    End Sub
End Class
