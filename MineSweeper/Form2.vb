Imports vb = Microsoft.VisualBasic
Public Class Form2
    Dim pics() As Image = {My.Resources._0, My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6, My.Resources._7, My.Resources._8, My.Resources.empty, My.Resources.flag, My.Resources.mine}
    Dim b() As PictureBox
    Dim rowLength As Integer = 10
    Dim mines As Integer = 10
    Dim started As Boolean
    Dim cMines As Integer = mines

    Dim currentTime As Integer = 0, bestTime As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Me.FormBorderStyle = FormBorderStyle.Fixed3D
        b = New PictureBox() {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10, PictureBox11, PictureBox12, PictureBox13, PictureBox14, PictureBox15, PictureBox16, PictureBox17, PictureBox18, PictureBox19, PictureBox20, PictureBox21, PictureBox22, PictureBox23, PictureBox24, PictureBox25, PictureBox26, PictureBox27, PictureBox28, PictureBox29, PictureBox30, PictureBox31, PictureBox32, PictureBox33, PictureBox34, PictureBox35, PictureBox36, PictureBox37, PictureBox38, PictureBox39, PictureBox40, PictureBox41, PictureBox42, PictureBox43, PictureBox44, PictureBox45, PictureBox46, PictureBox47, PictureBox48, PictureBox49, PictureBox50, PictureBox51, PictureBox52, PictureBox53, PictureBox54, PictureBox55, PictureBox56, PictureBox57, PictureBox58, PictureBox59, PictureBox60, PictureBox61, PictureBox62, PictureBox63, PictureBox64, PictureBox65, PictureBox66, PictureBox67, PictureBox68, PictureBox69, PictureBox70, PictureBox71, PictureBox72, PictureBox73, PictureBox74, PictureBox75, PictureBox76, PictureBox77, PictureBox78, PictureBox79, PictureBox80}
    End Sub

    Public Sub Wait(ByVal s As Single)
        Dim j As Single = vb.Timer()

        Do While vb.Timer() < j + s
            My.Application.DoEvents()
        Loop
    End Sub

    Public Sub Setup(a As Integer)
        Dim first As Integer = (a / 10), Second As Integer = (a Mod 10) / 10
        Dim sets() As Integer = {0, 0, 0, 0, 0, 0, 0, 0}
        Dim totalSurr As Integer = 0

        If (a - rowLength) > 0 Then
            sets(1) = (a - rowLength)
        End If

        If (a + rowLength) <= 80 Then
            sets(6) = (a + rowLength)
        End If

        If (a - 1) > 0 And (a - 1) Mod rowLength <> 0 Then
            sets(3) = (a - 1)
        End If

        If (a + 1) <= 80 And (a + 1) Mod rowLength <> 1 Then
            sets(4) = (a + 1)
        End If

        If (sets(1) - 1) > 0 And (sets(1) - 1) Mod rowLength <> 0 Then
            sets(0) = (sets(1) - 1)
        End If

        If (sets(1) + 1) <= 80 And (sets(1) + 1) Mod rowLength <> 1 Then
            sets(2) = (sets(1) + 1)
        End If

        If (sets(6) - 1) Mod rowLength <> 0 Then
            sets(5) = (sets(6) - 1)
        End If

        If (sets(6) + 1) <= 80 And (sets(6) + 1) Mod rowLength <> 1 Then
            sets(7) = (sets(6) + 1)
        End If

        For i As Integer = 0 To (sets.Length - 1)
            If sets(i) > 0 Then
                If CStr(b(sets(i) - 1).Tag) = "MINE" Then
                    totalSurr += 1
                End If
            End If
        Next

        If CStr(b(a - 1).Tag) <> "MINE" Then
            b(a - 1).Tag = totalSurr
        End If
    End Sub


    Private Sub Check(a As Integer)
        Dim first As Integer = (a / 10), Second As Integer = (a Mod 10) / 10
        Dim sets() As Integer = {0, 0, 0, 0, 0, 0, 0, 0}

        If (a - rowLength) > 0 Then
            sets(1) = (a - rowLength)
        End If

        If (a + rowLength) <= 80 Then
            sets(6) = (a + rowLength)
        End If

        If (a - 1) > 0 And (a - 1) Mod rowLength <> 0 Then
            sets(3) = (a - 1)
        End If

        If (a + 1) <= 80 And (a + 1) Mod rowLength <> 1 Then
            sets(4) = (a + 1)
        End If

        If (sets(1) - 1) > 0 And (sets(1) - 1) Mod rowLength <> 0 Then
            sets(0) = (sets(1) - 1)
        End If

        If (sets(1) + 1) <= 80 And (sets(1) + 1) Mod rowLength <> 1 Then
            sets(2) = (sets(1) + 1)
        End If

        If (sets(6) - 1) Mod rowLength <> 0 Then
            sets(5) = (sets(6) - 1)
        End If

        If (sets(6) + 1) <= 80 And (sets(6) + 1) Mod rowLength <> 1 Then
            sets(7) = (sets(6) + 1)
        End If

        For i As Integer = 0 To (sets.Length - 1)
            If sets(i) > 0 Then
                If CStr(b(sets(i) - 1).Tag) <> "MINE" Then
                    If Int(b(sets(i) - 1).Tag) = 0 And b(sets(i) - 1).Enabled Then
                        b(sets(i) - 1).Enabled = False
                        b(sets(i) - 1).BackgroundImage = pics(0)
                        Check(sets(i))
                    ElseIf Int(b(sets(i) - 1).Tag) > 0 And b(sets(i) - 1).Enabled Then
                        b(sets(i) - 1).Enabled = False
                        b(sets(i) - 1).BackgroundImage = pics(Int(b(sets(i) - 1).Tag))
                    End If
                End If
            End If
        Next
    End Sub

    Public Sub reset(didWin As Integer)
        Timer.Enabled = False

        Wait(0.15)
        For i As Integer = 0 To (b.Length - 1)
            Dim c As PictureBox = b(i)

            c.Enabled = True
            c.Tag = 0
            c.Visible = True
            c.BackgroundImage = pics(9)
            c.AccessibleDescription = ""
        Next

        If didWin Then
            If currentTime < bestTime Or bestTime = 0 Then
                bestTime = currentTime
                Label2.Text = "Best: " & (bestTime / 1000)
            End If
        End If

        cMines = 10
        currentTime = 0
        Label1.Text = "Score: 0"
        Label3.Text = "Mines: 0"
        started = False
    End Sub

    Private Sub PictureBox_Click(sender As Object, e As MouseEventArgs) Handles PictureBox1.Click, PictureBox2.Click, PictureBox3.Click, PictureBox4.Click, PictureBox5.Click, PictureBox6.Click, PictureBox7.Click, PictureBox8.Click, PictureBox9.Click, PictureBox10.Click, PictureBox11.Click, PictureBox12.Click, PictureBox13.Click, PictureBox14.Click, PictureBox15.Click, PictureBox16.Click, PictureBox17.Click, PictureBox18.Click, PictureBox19.Click, PictureBox20.Click, PictureBox21.Click, PictureBox22.Click, PictureBox23.Click, PictureBox24.Click, PictureBox25.Click, PictureBox26.Click, PictureBox27.Click, PictureBox28.Click, PictureBox29.Click, PictureBox30.Click, PictureBox31.Click, PictureBox32.Click, PictureBox33.Click, PictureBox34.Click, PictureBox35.Click, PictureBox36.Click, PictureBox37.Click, PictureBox38.Click, PictureBox39.Click, PictureBox40.Click, PictureBox41.Click, PictureBox42.Click, PictureBox43.Click, PictureBox44.Click, PictureBox45.Click, PictureBox46.Click, PictureBox47.Click, PictureBox48.Click, PictureBox49.Click, PictureBox50.Click, PictureBox51.Click, PictureBox52.Click, PictureBox53.Click, PictureBox54.Click, PictureBox55.Click, PictureBox56.Click, PictureBox57.Click, PictureBox58.Click, PictureBox59.Click, PictureBox60.Click, PictureBox61.Click, PictureBox62.Click, PictureBox63.Click, PictureBox64.Click, PictureBox65.Click, PictureBox66.Click, PictureBox67.Click, PictureBox68.Click, PictureBox69.Click, PictureBox70.Click, PictureBox71.Click, PictureBox72.Click, PictureBox73.Click, PictureBox74.Click, PictureBox75.Click, PictureBox76.Click, PictureBox77.Click, PictureBox78.Click, PictureBox79.Click, PictureBox80.Click
        If e.Button = MouseButtons.Left Then
            If Not started Then
                Dim startedMines As Integer
                started = Not started

                Do
                    startedMines = mines
                    For i As Integer = 0 To (b.Length - 1)
                        b(i).Tag = 0
                    Next

                    While startedMines > 0
                        Dim rand As Integer = ((b.Length - 1) * Rnd())

                        If CStr(b(rand).Tag) <> "MINE" Then
                            b(rand).Tag = "MINE"
                            startedMines -= 1
                        End If
                    End While

                    For i As Integer = 0 To (b.Length - 1)
                        Setup(i + 1)
                    Next
                Loop While CStr(sender.Tag) <> "0"

                Label3.Text = "Mines: " & cMines
                Check(Val((sender.Name).substring(10)))
                Timer.Enabled = True
            Else
                If sender.AccessibleDescription <> "FLAGGED" Then
                    If CStr(sender.Tag) = "MINE" Then
                        sender.BackgroundImage = pics(11)

                        MsgBox("You hit a mine! You've lost. Click to reset.", MsgBoxStyle.DefaultButton1, "Fail.")
                        reset(False)
                    ElseIf Int(sender.Tag) > 0 Then
                        sender.BackgroundImage = pics(Int(sender.Tag))
                    Else
                        Check(Val((sender.Name).substring(10)))
                    End If

                    sender.Enabled = False
                End If

                Dim first As Integer = 0, second As Integer = 0, third As Integer = 0

                For i As Integer = 0 To (b.Length - 1)
                    Dim c As PictureBox = b(i)

                    If CStr(c.Tag) = "MINE" And c.AccessibleDescription = "FLAGGED" Then
                        second += 1
                    ElseIf Not c.Enabled Then
                        first += 1
                    Else
                        third += 1
                    End If

                    If (second = mines And (first + second) = 80) Or ((second + third) = mines And 80 - first = mines) Then
                        Timer.Enabled = False
                        MsgBox("You won!", MsgBoxStyle.DefaultButton1, "Win!")
                        reset(True)
                    End If
                Next
            End If

            If Timer.Enabled Then
                For i As Integer = 0 To (b.Length - 1)
                    Dim obj As PictureBox = b(i)

                    If Not obj.Enabled And CStr(obj.Tag) <> "MINE" Then
                        obj.BackgroundImage = pics(Int(obj.Tag))
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub PictureBox_Down(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown, PictureBox2.MouseDown, PictureBox3.MouseDown, PictureBox4.MouseDown, PictureBox5.MouseDown, PictureBox6.MouseDown, PictureBox7.MouseDown, PictureBox8.MouseDown, PictureBox9.MouseDown, PictureBox10.MouseDown, PictureBox11.MouseDown, PictureBox12.MouseDown, PictureBox13.MouseDown, PictureBox14.MouseDown, PictureBox15.MouseDown, PictureBox16.MouseDown, PictureBox17.MouseDown, PictureBox18.MouseDown, PictureBox19.MouseDown, PictureBox20.MouseDown, PictureBox21.MouseDown, PictureBox22.MouseDown, PictureBox23.MouseDown, PictureBox24.MouseDown, PictureBox25.MouseDown, PictureBox26.MouseDown, PictureBox27.MouseDown, PictureBox28.MouseDown, PictureBox29.MouseDown, PictureBox30.MouseDown, PictureBox31.MouseDown, PictureBox32.MouseDown, PictureBox33.MouseDown, PictureBox34.MouseDown, PictureBox35.MouseDown, PictureBox36.MouseDown, PictureBox37.MouseDown, PictureBox38.MouseDown, PictureBox39.MouseDown, PictureBox40.MouseDown, PictureBox41.MouseDown, PictureBox42.MouseDown, PictureBox43.MouseDown, PictureBox44.MouseDown, PictureBox45.MouseDown, PictureBox46.MouseDown, PictureBox47.MouseDown, PictureBox48.MouseDown, PictureBox49.MouseDown, PictureBox50.MouseDown, PictureBox51.MouseDown, PictureBox52.MouseDown, PictureBox53.MouseDown, PictureBox54.MouseDown, PictureBox55.MouseDown, PictureBox56.MouseDown, PictureBox57.MouseDown, PictureBox58.MouseDown, PictureBox59.MouseDown, PictureBox60.MouseDown, PictureBox61.MouseDown, PictureBox62.MouseDown, PictureBox63.MouseDown, PictureBox64.MouseDown, PictureBox65.MouseDown, PictureBox66.MouseDown, PictureBox67.MouseDown, PictureBox68.MouseDown, PictureBox69.MouseDown, PictureBox70.MouseDown, PictureBox71.MouseDown, PictureBox72.MouseDown, PictureBox73.MouseDown, PictureBox74.MouseDown, PictureBox75.MouseDown, PictureBox76.MouseDown, PictureBox77.MouseDown, PictureBox78.MouseDown, PictureBox79.MouseDown, PictureBox80.MouseDown
        If e.Button = MouseButtons.Right Then
            If sender.AccessibleDescription = "FLAGGED" Then
                sender.AccessibleDescription = ""
                sender.BackgroundImage = pics(9)

                cMines += 1
            Else
                sender.AccessibleDescription = "FLAGGED"
                sender.BackgroundImage = pics(10)

                cMines -= 1
            End If

            Label3.Text = "Mines: " & cMines

            Dim first As Integer = 0, second As Integer = 0, third As Integer = 0

            For i As Integer = 0 To (b.Length - 1)
                Dim c As PictureBox = b(i)

                If CStr(c.Tag) = "MINE" And c.AccessibleDescription = "FLAGGED" Then
                    second += 1
                ElseIf Not c.Enabled Then
                    first += 1
                Else
                    third += 1
                End If ' 

                If (second = mines And (first + second) = 80) Or ((second + third) = mines And 80 - first = mines) Then
                    Timer.Enabled = False
                    MsgBox("You won!", MsgBoxStyle.DefaultButton1, "Win!")
                    reset(True)
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox81_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reset(False)
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        currentTime += sender.Interval
        Label1.Text = "Score: " & (currentTime / 1000)
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If keyData = Keys.Enter Then
            For i As Integer = 0 To (b.Length - 1)
                Dim c As PictureBox = b(i)

                If CStr(c.Tag) = "MINE" Then
                    c.Visible = False
                End If
            Next
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub ExitToSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToSelectionToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub DarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem.Click
        DarkToolStripMenuItem.Checked = True
        LightToolStripMenuItem.Checked = False

        Me.BackColor = Color.DimGray
        MenuStrip1.BackColor = Color.DimGray
        MenuStrip1.ForeColor = Color.White
        Button1.BackColor = Color.DimGray
        Button1.ForeColor = Color.White
        Label1.ForeColor = Color.White
        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.White
    End Sub

    Private Sub LightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightToolStripMenuItem.Click
        LightToolStripMenuItem.Checked = True
        DarkToolStripMenuItem.Checked = False

        Me.BackColor = Color.Gainsboro
        MenuStrip1.BackColor = Color.Gainsboro
        MenuStrip1.ForeColor = Color.Black
        Button1.ForeColor = Color.Black
        Button1.BackColor = Color.Gainsboro
        Label1.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
    End Sub

    Private Sub AlwaysOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click
        If Not AlwaysOnTopToolStripMenuItem.Checked Then ' True
            Me.TopMost = True
        Else ' False
            Me.TopMost = False
        End If

        AlwaysOnTopToolStripMenuItem.Checked = Not AlwaysOnTopToolStripMenuItem.Checked
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class