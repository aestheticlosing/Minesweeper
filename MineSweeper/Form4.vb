Imports vb = Microsoft.VisualBasic
Public Class Form4
    Dim pics() As Image = {My.Resources._0, My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6, My.Resources._7, My.Resources._8, My.Resources.empty, My.Resources.flag, My.Resources.mine}
    Dim b() As PictureBox
    Dim rowLength As Integer = 24
    Dim mines As Integer = 99
    Dim started As Boolean
    Dim cMines As Integer = mines

    Dim currentTime As Integer = 0, bestTime As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Me.FormBorderStyle = FormBorderStyle.Fixed3D
        b = New PictureBox() {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10, PictureBox11, PictureBox12, PictureBox13, PictureBox14, PictureBox15, PictureBox16, PictureBox17, PictureBox18, PictureBox19, PictureBox20, PictureBox21, PictureBox22, PictureBox23, PictureBox24, PictureBox25, PictureBox26, PictureBox27, PictureBox28, PictureBox29, PictureBox30, PictureBox31, PictureBox32, PictureBox33, PictureBox34, PictureBox35, PictureBox36, PictureBox37, PictureBox38, PictureBox39, PictureBox40, PictureBox41, PictureBox42, PictureBox43, PictureBox44, PictureBox45, PictureBox46, PictureBox47, PictureBox48, PictureBox49, PictureBox50, PictureBox51, PictureBox52, PictureBox53, PictureBox54, PictureBox55, PictureBox56, PictureBox57, PictureBox58, PictureBox59, PictureBox60, PictureBox61, PictureBox62, PictureBox63, PictureBox64, PictureBox65, PictureBox66, PictureBox67, PictureBox68, PictureBox69, PictureBox70, PictureBox71, PictureBox72, PictureBox73, PictureBox74, PictureBox75, PictureBox76, PictureBox77, PictureBox78, PictureBox79, PictureBox80, PictureBox81, PictureBox82, PictureBox83, PictureBox84, PictureBox85, PictureBox86, PictureBox87, PictureBox88, PictureBox89, PictureBox90, PictureBox91, PictureBox92, PictureBox93, PictureBox94, PictureBox95, PictureBox96, PictureBox97, PictureBox98, PictureBox99, PictureBox100, PictureBox101, PictureBox102, PictureBox103, PictureBox104, PictureBox105, PictureBox106, PictureBox107, PictureBox108, PictureBox109, PictureBox110, PictureBox111, PictureBox112, PictureBox113, PictureBox114, PictureBox115, PictureBox116, PictureBox117, PictureBox118, PictureBox119, PictureBox120, PictureBox121, PictureBox122, PictureBox123, PictureBox124, PictureBox125, PictureBox126, PictureBox127, PictureBox128, PictureBox129, PictureBox130, PictureBox131, PictureBox132, PictureBox133, PictureBox134, PictureBox135, PictureBox136, PictureBox137, PictureBox138, PictureBox139, PictureBox140, PictureBox141, PictureBox142, PictureBox143, PictureBox144, PictureBox145, PictureBox146, PictureBox147, PictureBox148, PictureBox149, PictureBox150, PictureBox151, PictureBox152, PictureBox153, PictureBox154, PictureBox155, PictureBox156, PictureBox157, PictureBox158, PictureBox159, PictureBox160, PictureBox161, PictureBox162, PictureBox163, PictureBox164, PictureBox165, PictureBox166, PictureBox167, PictureBox168, PictureBox169, PictureBox170, PictureBox171, PictureBox172, PictureBox173, PictureBox174, PictureBox175, PictureBox176, PictureBox177, PictureBox178, PictureBox179, PictureBox180, PictureBox181, PictureBox182, PictureBox183, PictureBox184, PictureBox185, PictureBox186, PictureBox187, PictureBox188, PictureBox189, PictureBox190, PictureBox191, PictureBox192, PictureBox193, PictureBox194, PictureBox195, PictureBox196, PictureBox197, PictureBox198, PictureBox199, PictureBox200, PictureBox201, PictureBox202, PictureBox203, PictureBox204, PictureBox205, PictureBox206, PictureBox207, PictureBox208, PictureBox209, PictureBox210, PictureBox211, PictureBox212, PictureBox213, PictureBox214, PictureBox215, PictureBox216, PictureBox217, PictureBox218, PictureBox219, PictureBox220, PictureBox221, PictureBox222, PictureBox223, PictureBox224, PictureBox225, PictureBox226, PictureBox227, PictureBox228, PictureBox229, PictureBox230, PictureBox231, PictureBox232, PictureBox233, PictureBox234, PictureBox235, PictureBox236, PictureBox237, PictureBox238, PictureBox239, PictureBox240, PictureBox241, PictureBox242, PictureBox243, PictureBox244, PictureBox245, PictureBox246, PictureBox247, PictureBox248, PictureBox249, PictureBox250, PictureBox251, PictureBox252, PictureBox253, PictureBox254, PictureBox255, PictureBox256, PictureBox257, PictureBox258, PictureBox259, PictureBox260, PictureBox261, PictureBox262, PictureBox263, PictureBox264, PictureBox265, PictureBox266, PictureBox267, PictureBox268, PictureBox269, PictureBox270, PictureBox271, PictureBox272, PictureBox273, PictureBox274, PictureBox275, PictureBox276, PictureBox277, PictureBox278, PictureBox279, PictureBox280, PictureBox281, PictureBox282, PictureBox283, PictureBox284, PictureBox285, PictureBox286, PictureBox287, PictureBox288, PictureBox289, PictureBox290, PictureBox291, PictureBox292, PictureBox293, PictureBox294, PictureBox295, PictureBox296, PictureBox297, PictureBox298, PictureBox299, PictureBox300, PictureBox301, PictureBox302, PictureBox303, PictureBox304, PictureBox305, PictureBox306, PictureBox307, PictureBox308, PictureBox309, PictureBox310, PictureBox311, PictureBox312, PictureBox313, PictureBox314, PictureBox315, PictureBox316, PictureBox317, PictureBox318, PictureBox319, PictureBox320, PictureBox321, PictureBox322, PictureBox323, PictureBox324, PictureBox325, PictureBox326, PictureBox327, PictureBox328, PictureBox329, PictureBox330, PictureBox331, PictureBox332, PictureBox333, PictureBox334, PictureBox335, PictureBox336, PictureBox337, PictureBox338, PictureBox339, PictureBox340, PictureBox341, PictureBox342, PictureBox343, PictureBox344, PictureBox345, PictureBox346, PictureBox347, PictureBox348, PictureBox349, PictureBox350, PictureBox351, PictureBox352, PictureBox353, PictureBox354, PictureBox355, PictureBox356, PictureBox357, PictureBox358, PictureBox359, PictureBox360, PictureBox361, PictureBox362, PictureBox363, PictureBox364, PictureBox365, PictureBox366, PictureBox367, PictureBox368, PictureBox369, PictureBox370, PictureBox371, PictureBox372, PictureBox373, PictureBox374, PictureBox375, PictureBox376, PictureBox377, PictureBox378, PictureBox379, PictureBox380, PictureBox381, PictureBox382, PictureBox383, PictureBox384, PictureBox385, PictureBox386, PictureBox387, PictureBox388, PictureBox389, PictureBox390, PictureBox391, PictureBox392, PictureBox393, PictureBox394, PictureBox395, PictureBox396, PictureBox397, PictureBox398, PictureBox399, PictureBox400, PictureBox401, PictureBox402, PictureBox403, PictureBox404, PictureBox405, PictureBox406, PictureBox407, PictureBox408, PictureBox409, PictureBox410, PictureBox411, PictureBox412, PictureBox413, PictureBox414, PictureBox415, PictureBox416, PictureBox417, PictureBox418, PictureBox419, PictureBox420, PictureBox421, PictureBox422, PictureBox423, PictureBox424, PictureBox425, PictureBox426, PictureBox427, PictureBox428, PictureBox429, PictureBox430, PictureBox431, PictureBox432, PictureBox433, PictureBox434, PictureBox435, PictureBox436, PictureBox437, PictureBox438, PictureBox439, PictureBox440, PictureBox441, PictureBox442, PictureBox443, PictureBox444, PictureBox445, PictureBox446, PictureBox447, PictureBox448, PictureBox449, PictureBox450, PictureBox451, PictureBox452, PictureBox453, PictureBox454, PictureBox455, PictureBox456, PictureBox457, PictureBox458, PictureBox459, PictureBox460, PictureBox461, PictureBox462, PictureBox463, PictureBox464, PictureBox465, PictureBox466, PictureBox467, PictureBox468, PictureBox469, PictureBox470, PictureBox471, PictureBox472, PictureBox473, PictureBox474, PictureBox475, PictureBox476, PictureBox477, PictureBox478, PictureBox479, PictureBox480}
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

        If (a + rowLength) <= 480 Then
            sets(6) = (a + rowLength)
        End If

        If (a - 1) > 0 And (a - 1) Mod rowLength <> 0 Then
            sets(3) = (a - 1)
        End If

        If (a + 1) <= 480 And (a + 1) Mod rowLength <> 1 Then
            sets(4) = (a + 1)
        End If

        If (sets(1) - 1) > 0 And (sets(1) - 1) Mod rowLength <> 0 Then
            sets(0) = (sets(1) - 1)
        End If

        If (sets(1) + 1) <= 480 And (sets(1) + 1) Mod rowLength <> 1 Then
            sets(2) = (sets(1) + 1)
        End If

        If (sets(6) - 1) Mod rowLength <> 0 Then
            sets(5) = (sets(6) - 1)
        End If

        If (sets(6) + 1) <= 480 And (sets(6) + 1) Mod rowLength <> 1 Then
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

        If (a + rowLength) <= 480 Then
            sets(6) = (a + rowLength)
        End If

        If (a - 1) > 0 And (a - 1) Mod rowLength <> 0 Then
            sets(3) = (a - 1)
        End If

        If (a + 1) <= 480 And (a + 1) Mod rowLength <> 1 Then
            sets(4) = (a + 1)
        End If

        If (sets(1) - 1) > 0 And (sets(1) - 1) Mod rowLength <> 0 Then
            sets(0) = (sets(1) - 1)
        End If

        If (sets(1) + 1) <= 480 And (sets(1) + 1) Mod rowLength <> 1 Then
            sets(2) = (sets(1) + 1)
        End If

        If (sets(6) - 1) Mod rowLength <> 0 Then
            sets(5) = (sets(6) - 1)
        End If

        If (sets(6) + 1) <= 480 And (sets(6) + 1) Mod rowLength <> 1 Then
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

    Private Sub PictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.Click, PictureBox2.Click, PictureBox3.Click, PictureBox4.Click, PictureBox5.Click, PictureBox6.Click, PictureBox7.Click, PictureBox8.Click, PictureBox9.Click, PictureBox10.Click, PictureBox11.Click, PictureBox12.Click, PictureBox13.Click, PictureBox14.Click, PictureBox15.Click, PictureBox16.Click, PictureBox17.Click, PictureBox18.Click, PictureBox19.Click, PictureBox20.Click, PictureBox21.Click, PictureBox22.Click, PictureBox23.Click, PictureBox24.Click, PictureBox25.Click, PictureBox26.Click, PictureBox27.Click, PictureBox28.Click, PictureBox29.Click, PictureBox30.Click, PictureBox31.Click, PictureBox32.Click, PictureBox33.Click, PictureBox34.Click, PictureBox35.Click, PictureBox36.Click, PictureBox37.Click, PictureBox38.Click, PictureBox39.Click, PictureBox40.Click, PictureBox41.Click, PictureBox42.Click, PictureBox43.Click, PictureBox44.Click, PictureBox45.Click, PictureBox46.Click, PictureBox47.Click, PictureBox48.Click, PictureBox49.Click, PictureBox50.Click, PictureBox51.Click, PictureBox52.Click, PictureBox53.Click, PictureBox54.Click, PictureBox55.Click, PictureBox56.Click, PictureBox57.Click, PictureBox58.Click, PictureBox59.Click, PictureBox60.Click, PictureBox61.Click, PictureBox62.Click, PictureBox63.Click, PictureBox64.Click, PictureBox65.Click, PictureBox66.Click, PictureBox67.Click, PictureBox68.Click, PictureBox69.Click, PictureBox70.Click, PictureBox71.Click, PictureBox72.Click, PictureBox73.Click, PictureBox74.Click, PictureBox75.Click, PictureBox76.Click, PictureBox77.Click, PictureBox78.Click, PictureBox79.Click, PictureBox80.Click, PictureBox81.Click, PictureBox82.Click, PictureBox83.Click, PictureBox84.Click, PictureBox85.Click, PictureBox86.Click, PictureBox87.Click, PictureBox88.Click, PictureBox89.Click, PictureBox90.Click, PictureBox91.Click, PictureBox92.Click, PictureBox93.Click, PictureBox94.Click, PictureBox95.Click, PictureBox96.Click, PictureBox97.Click, PictureBox98.Click, PictureBox99.Click, PictureBox100.Click, PictureBox101.Click, PictureBox102.Click, PictureBox103.Click, PictureBox104.Click, PictureBox105.Click, PictureBox106.Click, PictureBox107.Click, PictureBox108.Click, PictureBox109.Click, PictureBox110.Click, PictureBox111.Click, PictureBox112.Click, PictureBox113.Click, PictureBox114.Click, PictureBox115.Click, PictureBox116.Click, PictureBox117.Click, PictureBox118.Click, PictureBox119.Click, PictureBox120.Click, PictureBox121.Click, PictureBox122.Click, PictureBox123.Click, PictureBox124.Click, PictureBox125.Click, PictureBox126.Click, PictureBox127.Click, PictureBox128.Click, PictureBox129.Click, PictureBox130.Click, PictureBox131.Click, PictureBox132.Click, PictureBox133.Click, PictureBox134.Click, PictureBox135.Click, PictureBox136.Click, PictureBox137.Click, PictureBox138.Click, PictureBox139.Click, PictureBox140.Click, PictureBox141.Click, PictureBox142.Click, PictureBox143.Click, PictureBox144.Click, PictureBox145.Click, PictureBox146.Click, PictureBox147.Click, PictureBox148.Click, PictureBox149.Click, PictureBox150.Click, PictureBox151.Click, PictureBox152.Click, PictureBox153.Click, PictureBox154.Click, PictureBox155.Click, PictureBox156.Click, PictureBox157.Click, PictureBox158.Click, PictureBox159.Click, PictureBox160.Click, PictureBox161.Click, PictureBox162.Click, PictureBox163.Click, PictureBox164.Click, PictureBox165.Click, PictureBox166.Click, PictureBox167.Click, PictureBox168.Click, PictureBox169.Click, PictureBox170.Click, PictureBox171.Click, PictureBox172.Click, PictureBox173.Click, PictureBox174.Click, PictureBox175.Click, PictureBox176.Click, PictureBox177.Click, PictureBox178.Click, PictureBox179.Click, PictureBox180.Click, PictureBox181.Click, PictureBox182.Click, PictureBox183.Click, PictureBox184.Click, PictureBox185.Click, PictureBox186.Click, PictureBox187.Click, PictureBox188.Click, PictureBox189.Click, PictureBox190.Click, PictureBox191.Click, PictureBox192.Click, PictureBox193.Click, PictureBox194.Click, PictureBox195.Click, PictureBox196.Click, PictureBox197.Click, PictureBox198.Click, PictureBox199.Click, PictureBox200.Click, PictureBox201.Click, PictureBox202.Click, PictureBox203.Click, PictureBox204.Click, PictureBox205.Click, PictureBox206.Click, PictureBox207.Click, PictureBox208.Click, PictureBox209.Click, PictureBox210.Click, PictureBox211.Click, PictureBox212.Click, PictureBox213.Click, PictureBox214.Click, PictureBox215.Click, PictureBox216.Click, PictureBox217.Click, PictureBox218.Click, PictureBox219.Click, PictureBox220.Click, PictureBox221.Click, PictureBox222.Click, PictureBox223.Click, PictureBox224.Click, PictureBox225.Click, PictureBox226.Click, PictureBox227.Click, PictureBox228.Click, PictureBox229.Click, PictureBox230.Click, PictureBox231.Click, PictureBox232.Click, PictureBox233.Click, PictureBox234.Click, PictureBox235.Click, PictureBox236.Click, PictureBox237.Click, PictureBox238.Click, PictureBox239.Click, PictureBox240.Click, PictureBox241.Click, PictureBox242.Click, PictureBox243.Click, PictureBox244.Click, PictureBox245.Click, PictureBox246.Click, PictureBox247.Click, PictureBox248.Click, PictureBox249.Click, PictureBox250.Click, PictureBox251.Click, PictureBox252.Click, PictureBox253.Click, PictureBox254.Click, PictureBox255.Click, PictureBox256.Click, PictureBox257.Click, PictureBox258.Click, PictureBox259.Click, PictureBox260.Click, PictureBox261.Click, PictureBox262.Click, PictureBox263.Click, PictureBox264.Click, PictureBox265.Click, PictureBox266.Click, PictureBox267.Click, PictureBox268.Click, PictureBox269.Click, PictureBox270.Click, PictureBox271.Click, PictureBox272.Click, PictureBox273.Click, PictureBox274.Click, PictureBox275.Click, PictureBox276.Click, PictureBox277.Click, PictureBox278.Click, PictureBox279.Click, PictureBox280.Click, PictureBox281.Click, PictureBox282.Click, PictureBox283.Click, PictureBox284.Click, PictureBox285.Click, PictureBox286.Click, PictureBox287.Click, PictureBox288.Click, PictureBox289.Click, PictureBox290.Click, PictureBox291.Click, PictureBox292.Click, PictureBox293.Click, PictureBox294.Click, PictureBox295.Click, PictureBox296.Click, PictureBox297.Click, PictureBox298.Click, PictureBox299.Click, PictureBox300.Click, PictureBox301.Click, PictureBox302.Click, PictureBox303.Click, PictureBox304.Click, PictureBox305.Click, PictureBox306.Click, PictureBox307.Click, PictureBox308.Click, PictureBox309.Click, PictureBox310.Click, PictureBox311.Click, PictureBox312.Click, PictureBox313.Click, PictureBox314.Click, PictureBox315.Click, PictureBox316.Click, PictureBox317.Click, PictureBox318.Click, PictureBox319.Click, PictureBox320.Click, PictureBox321.Click, PictureBox322.Click, PictureBox323.Click, PictureBox324.Click, PictureBox325.Click, PictureBox326.Click, PictureBox327.Click, PictureBox328.Click, PictureBox329.Click, PictureBox330.Click, PictureBox331.Click, PictureBox332.Click, PictureBox333.Click, PictureBox334.Click, PictureBox335.Click, PictureBox336.Click, PictureBox337.Click, PictureBox338.Click, PictureBox339.Click, PictureBox340.Click, PictureBox341.Click, PictureBox342.Click, PictureBox343.Click, PictureBox344.Click, PictureBox345.Click, PictureBox346.Click, PictureBox347.Click, PictureBox348.Click, PictureBox349.Click, PictureBox350.Click, PictureBox351.Click, PictureBox352.Click, PictureBox353.Click, PictureBox354.Click, PictureBox355.Click, PictureBox356.Click, PictureBox357.Click, PictureBox358.Click, PictureBox359.Click, PictureBox360.Click, PictureBox361.Click, PictureBox362.Click, PictureBox363.Click, PictureBox364.Click, PictureBox365.Click, PictureBox366.Click, PictureBox367.Click, PictureBox368.Click, PictureBox369.Click, PictureBox370.Click, PictureBox371.Click, PictureBox372.Click, PictureBox373.Click, PictureBox374.Click, PictureBox375.Click, PictureBox376.Click, PictureBox377.Click, PictureBox378.Click, PictureBox379.Click, PictureBox380.Click, PictureBox381.Click, PictureBox382.Click, PictureBox383.Click, PictureBox384.Click, PictureBox385.Click, PictureBox386.Click, PictureBox387.Click, PictureBox388.Click, PictureBox389.Click, PictureBox390.Click, PictureBox391.Click, PictureBox392.Click, PictureBox393.Click, PictureBox394.Click, PictureBox395.Click, PictureBox396.Click, PictureBox397.Click, PictureBox398.Click, PictureBox399.Click, PictureBox400.Click, PictureBox401.Click, PictureBox402.Click, PictureBox403.Click, PictureBox404.Click, PictureBox405.Click, PictureBox406.Click, PictureBox407.Click, PictureBox408.Click, PictureBox409.Click, PictureBox410.Click, PictureBox411.Click, PictureBox412.Click, PictureBox413.Click, PictureBox414.Click, PictureBox415.Click, PictureBox416.Click, PictureBox417.Click, PictureBox418.Click, PictureBox419.Click, PictureBox420.Click, PictureBox421.Click, PictureBox422.Click, PictureBox423.Click, PictureBox424.Click, PictureBox425.Click, PictureBox426.Click, PictureBox427.Click, PictureBox428.Click, PictureBox429.Click, PictureBox430.Click, PictureBox431.Click, PictureBox432.Click, PictureBox433.Click, PictureBox434.Click, PictureBox435.Click, PictureBox436.Click, PictureBox437.Click, PictureBox438.Click, PictureBox439.Click, PictureBox440.Click, PictureBox441.Click, PictureBox442.Click, PictureBox443.Click, PictureBox444.Click, PictureBox445.Click, PictureBox446.Click, PictureBox447.Click, PictureBox448.Click, PictureBox449.Click, PictureBox450.Click, PictureBox451.Click, PictureBox452.Click, PictureBox453.Click, PictureBox454.Click, PictureBox455.Click, PictureBox456.Click, PictureBox457.Click, PictureBox458.Click, PictureBox459.Click, PictureBox460.Click, PictureBox461.Click, PictureBox462.Click, PictureBox463.Click, PictureBox464.Click, PictureBox465.Click, PictureBox466.Click, PictureBox467.Click, PictureBox468.Click, PictureBox469.Click, PictureBox470.Click, PictureBox471.Click, PictureBox472.Click, PictureBox473.Click, PictureBox474.Click, PictureBox475.Click, PictureBox476.Click, PictureBox477.Click, PictureBox478.Click, PictureBox479.Click, PictureBox480.Click

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

                    If (second = mines And (first + second) = 480) Or ((second + third) = mines And 480 - first = mines) Then
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

    Private Sub PictureBox_Down(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown, PictureBox2.MouseDown, PictureBox3.MouseDown, PictureBox4.MouseDown, PictureBox5.MouseDown, PictureBox6.MouseDown, PictureBox7.MouseDown, PictureBox8.MouseDown, PictureBox9.MouseDown, PictureBox10.MouseDown, PictureBox11.MouseDown, PictureBox12.MouseDown, PictureBox13.MouseDown, PictureBox14.MouseDown, PictureBox15.MouseDown, PictureBox16.MouseDown, PictureBox17.MouseDown, PictureBox18.MouseDown, PictureBox19.MouseDown, PictureBox20.MouseDown, PictureBox21.MouseDown, PictureBox22.MouseDown, PictureBox23.MouseDown, PictureBox24.MouseDown, PictureBox25.MouseDown, PictureBox26.MouseDown, PictureBox27.MouseDown, PictureBox28.MouseDown, PictureBox29.MouseDown, PictureBox30.MouseDown, PictureBox31.MouseDown, PictureBox32.MouseDown, PictureBox33.MouseDown, PictureBox34.MouseDown, PictureBox35.MouseDown, PictureBox36.MouseDown, PictureBox37.MouseDown, PictureBox38.MouseDown, PictureBox39.MouseDown, PictureBox40.MouseDown, PictureBox41.MouseDown, PictureBox42.MouseDown, PictureBox43.MouseDown, PictureBox44.MouseDown, PictureBox45.MouseDown, PictureBox46.MouseDown, PictureBox47.MouseDown, PictureBox48.MouseDown, PictureBox49.MouseDown, PictureBox50.MouseDown, PictureBox51.MouseDown, PictureBox52.MouseDown, PictureBox53.MouseDown, PictureBox54.MouseDown, PictureBox55.MouseDown, PictureBox56.MouseDown, PictureBox57.MouseDown, PictureBox58.MouseDown, PictureBox59.MouseDown, PictureBox60.MouseDown, PictureBox61.MouseDown, PictureBox62.MouseDown, PictureBox63.MouseDown, PictureBox64.MouseDown, PictureBox65.MouseDown, PictureBox66.MouseDown, PictureBox67.MouseDown, PictureBox68.MouseDown, PictureBox69.MouseDown, PictureBox70.MouseDown, PictureBox71.MouseDown, PictureBox72.MouseDown, PictureBox73.MouseDown, PictureBox74.MouseDown, PictureBox75.MouseDown, PictureBox76.MouseDown, PictureBox77.MouseDown, PictureBox78.MouseDown, PictureBox79.MouseDown, PictureBox80.MouseDown, PictureBox81.MouseDown, PictureBox82.MouseDown, PictureBox83.MouseDown, PictureBox84.MouseDown, PictureBox85.MouseDown, PictureBox86.MouseDown, PictureBox87.MouseDown, PictureBox88.MouseDown, PictureBox89.MouseDown, PictureBox90.MouseDown, PictureBox91.MouseDown, PictureBox92.MouseDown, PictureBox93.MouseDown, PictureBox94.MouseDown, PictureBox95.MouseDown, PictureBox96.MouseDown, PictureBox97.MouseDown, PictureBox98.MouseDown, PictureBox99.MouseDown, PictureBox100.MouseDown, PictureBox101.MouseDown, PictureBox102.MouseDown, PictureBox103.MouseDown, PictureBox104.MouseDown, PictureBox105.MouseDown, PictureBox106.MouseDown, PictureBox107.MouseDown, PictureBox108.MouseDown, PictureBox109.MouseDown, PictureBox110.MouseDown, PictureBox111.MouseDown, PictureBox112.MouseDown, PictureBox113.MouseDown, PictureBox114.MouseDown, PictureBox115.MouseDown, PictureBox116.MouseDown, PictureBox117.MouseDown, PictureBox118.MouseDown, PictureBox119.MouseDown, PictureBox120.MouseDown, PictureBox121.MouseDown, PictureBox122.MouseDown, PictureBox123.MouseDown, PictureBox124.MouseDown, PictureBox125.MouseDown, PictureBox126.MouseDown, PictureBox127.MouseDown, PictureBox128.MouseDown, PictureBox129.MouseDown, PictureBox130.MouseDown, PictureBox131.MouseDown, PictureBox132.MouseDown, PictureBox133.MouseDown, PictureBox134.MouseDown, PictureBox135.MouseDown, PictureBox136.MouseDown, PictureBox137.MouseDown, PictureBox138.MouseDown, PictureBox139.MouseDown, PictureBox140.MouseDown, PictureBox141.MouseDown, PictureBox142.MouseDown, PictureBox143.MouseDown, PictureBox144.MouseDown, PictureBox145.MouseDown, PictureBox146.MouseDown, PictureBox147.MouseDown, PictureBox148.MouseDown, PictureBox149.MouseDown, PictureBox150.MouseDown, PictureBox151.MouseDown, PictureBox152.MouseDown, PictureBox153.MouseDown, PictureBox154.MouseDown, PictureBox155.MouseDown, PictureBox156.MouseDown, PictureBox157.MouseDown, PictureBox158.MouseDown, PictureBox159.MouseDown, PictureBox160.MouseDown, PictureBox161.MouseDown, PictureBox162.MouseDown, PictureBox163.MouseDown, PictureBox164.MouseDown, PictureBox165.MouseDown, PictureBox166.MouseDown, PictureBox167.MouseDown, PictureBox168.MouseDown, PictureBox169.MouseDown, PictureBox170.MouseDown, PictureBox171.MouseDown, PictureBox172.MouseDown, PictureBox173.MouseDown, PictureBox174.MouseDown, PictureBox175.MouseDown, PictureBox176.MouseDown, PictureBox177.MouseDown, PictureBox178.MouseDown, PictureBox179.MouseDown, PictureBox180.MouseDown, PictureBox181.MouseDown, PictureBox182.MouseDown, PictureBox183.MouseDown, PictureBox184.MouseDown, PictureBox185.MouseDown, PictureBox186.MouseDown, PictureBox187.MouseDown, PictureBox188.MouseDown, PictureBox189.MouseDown, PictureBox190.MouseDown, PictureBox191.MouseDown, PictureBox192.MouseDown, PictureBox193.MouseDown, PictureBox194.MouseDown, PictureBox195.MouseDown, PictureBox196.MouseDown, PictureBox197.MouseDown, PictureBox198.MouseDown, PictureBox199.MouseDown, PictureBox200.MouseDown, PictureBox201.MouseDown, PictureBox202.MouseDown, PictureBox203.MouseDown, PictureBox204.MouseDown, PictureBox205.MouseDown, PictureBox206.MouseDown, PictureBox207.MouseDown, PictureBox208.MouseDown, PictureBox209.MouseDown, PictureBox210.MouseDown, PictureBox211.MouseDown, PictureBox212.MouseDown, PictureBox213.MouseDown, PictureBox214.MouseDown, PictureBox215.MouseDown, PictureBox216.MouseDown, PictureBox217.MouseDown, PictureBox218.MouseDown, PictureBox219.MouseDown, PictureBox220.MouseDown, PictureBox221.MouseDown, PictureBox222.MouseDown, PictureBox223.MouseDown, PictureBox224.MouseDown, PictureBox225.MouseDown, PictureBox226.MouseDown, PictureBox227.MouseDown, PictureBox228.MouseDown, PictureBox229.MouseDown, PictureBox230.MouseDown, PictureBox231.MouseDown, PictureBox232.MouseDown, PictureBox233.MouseDown, PictureBox234.MouseDown, PictureBox235.MouseDown, PictureBox236.MouseDown, PictureBox237.MouseDown, PictureBox238.MouseDown, PictureBox239.MouseDown, PictureBox240.MouseDown, PictureBox241.MouseDown, PictureBox242.MouseDown, PictureBox243.MouseDown, PictureBox244.MouseDown, PictureBox245.MouseDown, PictureBox246.MouseDown, PictureBox247.MouseDown, PictureBox248.MouseDown, PictureBox249.MouseDown, PictureBox250.MouseDown, PictureBox251.MouseDown, PictureBox252.MouseDown, PictureBox253.MouseDown, PictureBox254.MouseDown, PictureBox255.MouseDown, PictureBox256.MouseDown, PictureBox257.MouseDown, PictureBox258.MouseDown, PictureBox259.MouseDown, PictureBox260.MouseDown, PictureBox261.MouseDown, PictureBox262.MouseDown, PictureBox263.MouseDown, PictureBox264.MouseDown, PictureBox265.MouseDown, PictureBox266.MouseDown, PictureBox267.MouseDown, PictureBox268.MouseDown, PictureBox269.MouseDown, PictureBox270.MouseDown, PictureBox271.MouseDown, PictureBox272.MouseDown, PictureBox273.MouseDown, PictureBox274.MouseDown, PictureBox275.MouseDown, PictureBox276.MouseDown, PictureBox277.MouseDown, PictureBox278.MouseDown, PictureBox279.MouseDown, PictureBox280.MouseDown, PictureBox281.MouseDown, PictureBox282.MouseDown, PictureBox283.MouseDown, PictureBox284.MouseDown, PictureBox285.MouseDown, PictureBox286.MouseDown, PictureBox287.MouseDown, PictureBox288.MouseDown, PictureBox289.MouseDown, PictureBox290.MouseDown, PictureBox291.MouseDown, PictureBox292.MouseDown, PictureBox293.MouseDown, PictureBox294.MouseDown, PictureBox295.MouseDown, PictureBox296.MouseDown, PictureBox297.MouseDown, PictureBox298.MouseDown, PictureBox299.MouseDown, PictureBox300.MouseDown, PictureBox301.MouseDown, PictureBox302.MouseDown, PictureBox303.MouseDown, PictureBox304.MouseDown, PictureBox305.MouseDown, PictureBox306.MouseDown, PictureBox307.MouseDown, PictureBox308.MouseDown, PictureBox309.MouseDown, PictureBox310.MouseDown, PictureBox311.MouseDown, PictureBox312.MouseDown, PictureBox313.MouseDown, PictureBox314.MouseDown, PictureBox315.MouseDown, PictureBox316.MouseDown, PictureBox317.MouseDown, PictureBox318.MouseDown, PictureBox319.MouseDown, PictureBox320.MouseDown, PictureBox321.MouseDown, PictureBox322.MouseDown, PictureBox323.MouseDown, PictureBox324.MouseDown, PictureBox325.MouseDown, PictureBox326.MouseDown, PictureBox327.MouseDown, PictureBox328.MouseDown, PictureBox329.MouseDown, PictureBox330.MouseDown, PictureBox331.MouseDown, PictureBox332.MouseDown, PictureBox333.MouseDown, PictureBox334.MouseDown, PictureBox335.MouseDown, PictureBox336.MouseDown, PictureBox337.MouseDown, PictureBox338.MouseDown, PictureBox339.MouseDown, PictureBox340.MouseDown, PictureBox341.MouseDown, PictureBox342.MouseDown, PictureBox343.MouseDown, PictureBox344.MouseDown, PictureBox345.MouseDown, PictureBox346.MouseDown, PictureBox347.MouseDown, PictureBox348.MouseDown, PictureBox349.MouseDown, PictureBox350.MouseDown, PictureBox351.MouseDown, PictureBox352.MouseDown, PictureBox353.MouseDown, PictureBox354.MouseDown, PictureBox355.MouseDown, PictureBox356.MouseDown, PictureBox357.MouseDown, PictureBox358.MouseDown, PictureBox359.MouseDown, PictureBox360.MouseDown, PictureBox361.MouseDown, PictureBox362.MouseDown, PictureBox363.MouseDown, PictureBox364.MouseDown, PictureBox365.MouseDown, PictureBox366.MouseDown, PictureBox367.MouseDown, PictureBox368.MouseDown, PictureBox369.MouseDown, PictureBox370.MouseDown, PictureBox371.MouseDown, PictureBox372.MouseDown, PictureBox373.MouseDown, PictureBox374.MouseDown, PictureBox375.MouseDown, PictureBox376.MouseDown, PictureBox377.MouseDown, PictureBox378.MouseDown, PictureBox379.MouseDown, PictureBox380.MouseDown, PictureBox381.MouseDown, PictureBox382.MouseDown, PictureBox383.MouseDown, PictureBox384.MouseDown, PictureBox385.MouseDown, PictureBox386.MouseDown, PictureBox387.MouseDown, PictureBox388.MouseDown, PictureBox389.MouseDown, PictureBox390.MouseDown, PictureBox391.MouseDown, PictureBox392.MouseDown, PictureBox393.MouseDown, PictureBox394.MouseDown, PictureBox395.MouseDown, PictureBox396.MouseDown, PictureBox397.MouseDown, PictureBox398.MouseDown, PictureBox399.MouseDown, PictureBox400.MouseDown, PictureBox401.MouseDown, PictureBox402.MouseDown, PictureBox403.MouseDown, PictureBox404.MouseDown, PictureBox405.MouseDown, PictureBox406.MouseDown, PictureBox407.MouseDown, PictureBox408.MouseDown, PictureBox409.MouseDown, PictureBox410.MouseDown, PictureBox411.MouseDown, PictureBox412.MouseDown, PictureBox413.MouseDown, PictureBox414.MouseDown, PictureBox415.MouseDown, PictureBox416.MouseDown, PictureBox417.MouseDown, PictureBox418.MouseDown, PictureBox419.MouseDown, PictureBox420.MouseDown, PictureBox421.MouseDown, PictureBox422.MouseDown, PictureBox423.MouseDown, PictureBox424.MouseDown, PictureBox425.MouseDown, PictureBox426.MouseDown, PictureBox427.MouseDown, PictureBox428.MouseDown, PictureBox429.MouseDown, PictureBox430.MouseDown, PictureBox431.MouseDown, PictureBox432.MouseDown, PictureBox433.MouseDown, PictureBox434.MouseDown, PictureBox435.MouseDown, PictureBox436.MouseDown, PictureBox437.MouseDown, PictureBox438.MouseDown, PictureBox439.MouseDown, PictureBox440.MouseDown, PictureBox441.MouseDown, PictureBox442.MouseDown, PictureBox443.MouseDown, PictureBox444.MouseDown, PictureBox445.MouseDown, PictureBox446.MouseDown, PictureBox447.MouseDown, PictureBox448.MouseDown, PictureBox449.MouseDown, PictureBox450.MouseDown, PictureBox451.MouseDown, PictureBox452.MouseDown, PictureBox453.MouseDown, PictureBox454.MouseDown, PictureBox455.MouseDown, PictureBox456.MouseDown, PictureBox457.MouseDown, PictureBox458.MouseDown, PictureBox459.MouseDown, PictureBox460.MouseDown, PictureBox461.MouseDown, PictureBox462.MouseDown, PictureBox463.MouseDown, PictureBox464.MouseDown, PictureBox465.MouseDown, PictureBox466.MouseDown, PictureBox467.MouseDown, PictureBox468.MouseDown, PictureBox469.MouseDown, PictureBox470.MouseDown, PictureBox471.MouseDown, PictureBox472.MouseDown, PictureBox473.MouseDown, PictureBox474.MouseDown, PictureBox475.MouseDown, PictureBox476.MouseDown, PictureBox477.MouseDown, PictureBox478.MouseDown, PictureBox479.MouseDown, PictureBox480.MouseDown
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

                If (second = mines And (first + second) = 480) Or ((second + third) = mines And 480 - first = mines) Then
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