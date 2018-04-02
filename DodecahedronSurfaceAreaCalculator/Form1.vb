Public Class Form1
    '' Initialize Each Data Types
    Dim area As Double
    Dim areaInput As Double


    Private Sub lengthSelection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '' If there is no default selected Item select the first one
        If lengthSelection.Items.Count > 0 Then
            lengthSelection.SelectedIndex = 0    ' The first item has index 0 '
        End If
    End Sub

    '' Event Listener When the Button Calculate is clicked
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ''This is to avoid an annoying freaking error
        If edgeBox.Text = "" Then
            areaInput = 0.0
        Else
            areaInput = edgeBox.Text
        End If

        '' Selected Length is CM
        If lengthSelection.SelectedIndex = 0 Then
            areaInput = areaInput / 100
        End If
        '' Selected Length is Ft
        If lengthSelection.SelectedIndex = 1 Then
            areaInput = areaInput / 3.28083989501
        End If
        '' Selected Length is Yard
        If lengthSelection.SelectedIndex = 2 Then
            areaInput = areaInput / 1.09361329834
        End If
        '' Selected Length is Inches
        If lengthSelection.SelectedIndex = 3 Then
            areaInput = areaInput / 39.3700787402
        End If
        '' Selected Length is KM
        If lengthSelection.SelectedIndex = 4 Then
            areaInput = areaInput / 0.001
        End If
        '' Selected Length is Miles
        If lengthSelection.SelectedIndex = 6 Then
            areaInput = areaInput / 0.00062137273
        End If
        '' Selected Length is MM
        If lengthSelection.SelectedIndex = 7 Then
            areaInput = areaInput / 1000
        End If


        '' Calculate the area
        area = 3 * Math.Sqrt(25 + 10 * Math.Sqrt(5)) * areaInput ^ 2

        '' Put the result in the label Text
        areaResult.Text = area

    End Sub
End Class
