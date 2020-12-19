Public Class frmMain
    Private Sub btnEnterRainfall_Click(sender As Object, e As EventArgs) Handles btnEnterRainfall.Click
        ' Clear any inputs that may exist
        lstRainfallAmounts.Items.Clear()
        lblAvgRainfall.Text = "Average Rainfall per Month is: "

        Dim intMonth As Integer
        Dim strRainfall As String
        Dim decRainfallAvg As Decimal

        ' Walk through each month and get the rainfall amount from the user
        For intMonth = 1 To 12
            strRainfall = InputBox("Enter rainfall for month " & intMonth, "Rainfall")

            ' If the input contains something, validate it and add to the collection
            If strRainfall <> "" Then

                ' Handle non numeric entry
                While Not IsNumeric(strRainfall)
                    MsgBox("Your input was non-numeric. Please use positive numbers.")
                    strRainfall = InputBox("Enter rainfall for month " & intMonth, "Rainfall")
                End While

                ' Handle negative entry
                While strRainfall < 0
                    MsgBox("Your input was negative. Please use positive numbers.")
                    strRainfall = InputBox("Enter rainfall for month " & intMonth, "Rainfall")

                    ' Handle non numeric entry
                    While Not IsNumeric(strRainfall)
                        MsgBox("Your input was non-numeric. Please use positive numbers.")
                        strRainfall = InputBox("Enter rainfall for month " & intMonth, "Rainfall")
                    End While
                End While

                ' Valid entry, add to collection
                lstRainfallAmounts.Items.Add(strRainfall)
            Else

                ' If no entries were made, warn the user and exit sub.
                If lstRainfallAmounts.Items.Count < 1 Then
                    MsgBox("No Values Entered.")
                    Exit Sub
                End If

                ' Blank input or cancel pressed, Exit for loop
                Exit For
            End If
        Next

        ' Calculate the average rainfall
        Dim decTotalRainfall As Decimal
        Dim i As Integer

        ' Loop through the collection, adding to the total
        For i = 0 To (lstRainfallAmounts.Items.Count - 1)
            decTotalRainfall += lstRainfallAmounts.Items(i)
        Next
        decRainfallAvg = decTotalRainfall / lstRainfallAmounts.Items.Count

        ' Update the label with the average
        lblAvgRainfall.Text = "Average Rainfall per Month is: " & decRainfallAvg.ToString("F1")
    End Sub

    Private Sub tlsClear_Click(sender As Object, e As EventArgs) Handles tlsClear.Click
        lstRainfallAmounts.Items.Clear()
        lblAvgRainfall.Text = "Average Rainfall per Month is: "
    End Sub

    Private Sub tlsExit_Click(sender As Object, e As EventArgs) Handles tlsExit.Click
        Close()
    End Sub
End Class
