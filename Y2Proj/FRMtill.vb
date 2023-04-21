Imports Y2Proj.DBDataSetTableAdapters

Public Class FRMtill

    ' The structures needed for lists

    Structure DisplayItem
        Dim Container As Panel
        Dim Index As Label
        Dim Name As Label
        Dim Quantity As Label
        Dim Cost As Label
        Dim Total As Label
    End Structure

    Structure ItemInformation
        Dim Index As Point
        Dim Name As String
        Dim Quantity As Integer
        Dim Cost As Decimal
        Dim Total As Decimal
    End Structure

    Structure TotalBar
        Dim Container As Panel
        Dim LeftButton As PictureBox
        Dim RightButton As PictureBox
        Dim Total As Label
    End Structure

    ' The read only / contants

    ReadOnly UserName As String = FRMlogin.user
    ReadOnly ID As Integer = FRMlogin.ID

    ' The general variables

    Dim TillTotal As TotalBar
    Dim LeftContainer As Panel
    Dim PotContainer As Panel
    Dim ControlsContainer As Panel
    Dim DisplaySize As New Size(3, 2)
    Dim InfoNextFree As New Point(0, 0)
    Dim pageNumber As Integer = 1
    Dim Total As Decimal
    ' The lists

    Dim ControlButtons(3) As Button
    Dim PotButtons(11) As Button
    Dim DisplayInfo(3, 2) As ItemInformation
    Dim DisplayItems(3) As DisplayItem

    ' Variables for Till up form

    Dim StartOfWeek As Date

    Private Sub FRMtill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet.TillRollLog' table. You can move, or remove it, as needed.
        Me.TillRollLogTableAdapter.Fill(Me.DBDataSet.TillRollLog)
        'TODO: This line of code loads data into the 'DBDataSet.ItemTIllLookup' table. You can move, or remove it, as needed.
        Me.ItemTIllLookupTableAdapter.Fill(Me.DBDataSet.ItemTIllLookup)
        'TODO: This line of code loads data into the 'DBDataSet.Settings' table. You can move, or remove it, as needed.
        Me.SettingsTableAdapter.Fill(Me.DBDataSet.Settings)

        GetFormTopBar(Me)

        '
        TBCtill.Location = New Point(5, 5)
        TBCtill.Size = New Size(1900, 1000)
        TBCtill.Font = fType()

        '
        Me.LeftContainer = New Panel
        Me.TillTotal = New TotalBar

        '
        For y = 0 To 2
            For x = 0 To 3

                DisplayInfo(x, y) = CreateDisplayInfo()

            Next
        Next

        '
        LoadDisplay()

        '
        LoadPots()

        '
        LoadControls()

        '

        StartOfWeek = BeginningOfWeek(Today)

        LoadStats()

        DGVPotTillUp.Size = New Size(800, 900)
        DGVPotTillUp.Location = New Point(10, 10)
        DGVTransactionTillUp.Size = New Size(800, 900)
        DGVTransactionTillUp.Location = New Point(820, 10)

        CHRTStats.Size = New Size(700, 700)
    End Sub

    Sub UpdateTables()

        TillRollLogTableAdapter.Update(DBDataSet.TillRollLog)
        TillRollLogTableAdapter.Fill(DBDataSet.TillRollLog)

        ItemTIllLookupTableAdapter.Update(DBDataSet.ItemTIllLookup)
        ItemTIllLookupTableAdapter.Fill(DBDataSet.ItemTIllLookup)

    End Sub

    Function CreateDisplayInfo(Optional name As String = "", Optional cost As Decimal = 0.00F, Optional quantity As Integer = 0, Optional total As Decimal = 0.00F)
        'Returns iteminformation the user entered
        Return New ItemInformation With {
            .Name = name,
            .Cost = cost,
            .Quantity = quantity,
            .Total = total
        }

    End Function

    Function CreateDisplayItem(
        Optional row As String = "",
        Optional ItemName As String = "",
        Optional ItemQuantity As String = "0",
        Optional ItemCost As String = "0",
        Optional ItemTotal As String = "0"
        )
        'Creates a row of display information
        Return New DisplayItem With {
        .Container = New Panel With {
            .Name = "Container",
            .Size = New Size(1100, 160),
            .Location = New Point(20, 20 + (165 * row)),
            .BackColor = Color.LimeGreen
            },
        .Index = New Label With {
            .Name = "Index",
            .Text = $"Row: {row + 1}, Page: {pageNumber} of 3",
            .Font = fType(FontSize:=30),
            .ForeColor = Color.Black,
            .AutoSize = True,
            .Location = New Point(30, 30 + (165 * row)),
            .BackColor = Color.MediumAquamarine
            },
        .Name = New Label With {
            .Name = "Name",
            .Text = $"Name: {ItemName}",
            .Font = fType(FontSize:=30),
            .ForeColor = Color.White,
            .AutoSize = True,
            .Location = New Point(30, 80 + (165 * row)),
            .BackColor = Color.Green
            },
        .Quantity = New Label With {
            .Name = "Quantity",
            .Text = $"Quantity: {ItemQuantity}",
            .Font = fType(FontSize:=30),
            .ForeColor = Color.White,
            .AutoSize = True,
            .Location = New Point(30, 130 + (165 * row)),
            .BackColor = Color.Green
            },
        .Cost = New Label With {
            .Name = "Cost",
            .Text = $"Cost Per Item: £{ItemCost}",
            .Font = fType(FontSize:=30),
            .ForeColor = Color.White,
            .AutoSize = True,
            .Location = New Point(600, 80 + (165 * row)),
            .BackColor = Color.SeaGreen
            },
        .Total = New Label With {
            .Name = "Total",
            .Text = $"Total: £{ItemTotal}",
            .Font = fType(FontSize:=30),
            .ForeColor = Color.White,
            .AutoSize = True,
            .Location = New Point(600, 130 + (165 * row)),
            .BackColor = Color.SeaGreen
            }
        }


    End Function

    ' Loading the Sections of the screen

    Sub LoadDisplay()
        'Creates the till's display container
        With Me.LeftContainer
            .Name = "Contanier"
            .Size = New Size(1130, 790)
            .Location = New Point(5, 5)
            .BackColor = Color.DarkGreen
        End With
        ' Creates the bottom of the till where the total and the left and right button go
        With Me.TillTotal
            .Container = New Panel With {
                .Size = New Size(1100, 80),
                .Location = New Point(20, 700),
                .BackColor = Color.MediumSpringGreen
            }
            .LeftButton = New PictureBox With {
                .Size = New Size(60, 60),
                .Location = New Point(30, 710),
                .BackgroundImageLayout = ImageLayout.Zoom,
                .ImageLocation = $"{AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 21)}Images\LeftArrow.png"
            }
            .RightButton = New PictureBox With {
                .Size = New Size(60, 60),
                .Location = New Point(1050, 710),
                .BackgroundImageLayout = ImageLayout.Zoom,
                .ImageLocation = $"{AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 21)}Images\RightArrow.png"
            }
            .Total = New Label With {
                .Text = $"Total: £0",
                .Font = fType(FontSize:=30),
                .AutoSize = False,
                .Size = New Size(1100, 80),
                .Location = New Point(20, 700),
                .BackColor = Color.MediumSpringGreen,
                .TextAlign = ContentAlignment.MiddleCenter
            }
        End With

        AddHandler Me.TillTotal.RightButton.Click, AddressOf Me.RightArrowClick

        AddHandler Me.TillTotal.LeftButton.Click, AddressOf Me.LeftArrowClick

        TBPTill.Controls.Add(Me.TillTotal.RightButton)

        TBPTill.Controls.Add(Me.TillTotal.LeftButton)

        TBPTill.Controls.Add(Me.TillTotal.Total)

        TBPTill.Controls.Add(Me.TillTotal.Container)
        'Creates the boxes where the item information will be displayed
        For x = 0 To DisplaySize.Width()

            DisplayItems(x) = CreateDisplayItem(row:=x)

            AddDisplayItem(DisplayItems(x))

        Next

        TBPTill.Controls.Add(LeftContainer)

    End Sub

    Sub LoadPots()

        Dim multiplier As Decimal = 0.6

        Me.PotContainer = New Panel With {
            .Size = New Size(480, 435),
            .Location = New Point(1220, 5),
            .BackColor = Color.Green
        }

        Dim SettingsLocation As Integer

        For Each row In DBDataSet.Settings
            If row.UserID = ID Then
                SettingsLocation = row.ID
            End If
        Next
        'Creates the pots with the potname in the designated settings column
        For x = 0 To 11

            Dim Item As New Button With {
                .Text = $"{DBDataSet.Settings.Rows(SettingsLocation)(x + 10)}",
                .Font = fType(),
                .Size = New Size(150, 100),
                .Location = New Point(1230 + 155 * (x Mod 3), 15 + 105 * (x \ 3)),
                .BackColor = Color.LimeGreen,
                .TextAlign = ContentAlignment.MiddleCenter
            }

            PotButtons(x) = Item

            AddHandler PotButtons(x).Click, AddressOf Me.PotClick

            TBPTill.Controls.Add(PotButtons(x))

        Next

        TBPTill.Controls.Add(Me.PotContainer)

    End Sub

    Sub LoadControls()

        Me.ControlsContainer = New Panel With {
            .Size = New Size(170, 445),
            .Location = New Point(1375, 490),
            .BackColor = Color.Green
        }
        'Creates the 4 controls available (Confirm, remove one, remove item, clear)
        For i = 0 To 3

            Dim Item As New Button With {
                .Size = New Size(150, 100),
                .Location = New Point(1385, 500 + (105 * i)),
                .BackColor = Color.LimeGreen,
                .Font = fType()
            }

            ControlButtons(i) = Item

            Dim name As String = ""

            Select Case i
                Case 0
                    name = "Remove One"
                    AddHandler ControlButtons(i).Click, AddressOf Me.ControlRemoveOne
                Case 1
                    name = "Remove Item"
                    AddHandler ControlButtons(i).Click, AddressOf Me.ControlRemoveItem
                Case 2
                    name = "Clear"
                    AddHandler ControlButtons(i).Click, AddressOf Me.ControlClear
                Case 3
                    name = "Confirm"
                    ControlButtons(i).Location = New Point(1385, 510 + (105 * i))
                    AddHandler ControlButtons(i).Click, AddressOf Me.ControlConfirm
            End Select

            ControlButtons(i).Text = $"{name}"

            TBPTill.Controls.Add(ControlButtons(i))

        Next

        TBPTill.Controls.Add(Me.ControlsContainer)

    End Sub

    ' The controls associated with all the objects

    Sub RemoveItem(index As Point)
        'Sees if the item is not empty already
        If DisplayInfo(index.X, index.Y).Name = "" Then
            Exit Sub
        End If
        'Removes the item
        DisplayInfo(index.X, index.Y) = CreateDisplayInfo()

        UpdateDisplay()

    End Sub

    Function GetIndex()

        Dim index As New Point(0, 0)
        Dim flag As Boolean = False

        'Asks the user for an index until number is entered, then it returns a point data type
        Do
            Try
                index.X = CInt(InputBox("Please enter the row of the item to be removed.")) - 1

                flag = True

                If index.X < 0 Then
                    Return New Point(-1, -1)
                End If

            Catch ex As Exception

            End Try

        Loop Until flag

        flag = False

        Do

            Try

                index.Y = CInt(InputBox("Please enter the page number of the item to be removed."))

                flag = True

                index.Y -= 1

                If index.Y < 0 Then
                    Return New Point(-1, -1)
                End If

            Catch ex As Exception

            End Try

        Loop Until flag

        Return index

    End Function

    Sub ControlRemoveOne(sender As Object, e As EventArgs)

        Dim index As Point = GetIndex()

        If (index.X = -1) Then
            Exit Sub
        End If
        ' If the quantity would fall to zero then it will remove the item instead
        If DisplayInfo(index.X, index.Y).Quantity = 1 Then
            RemoveItem(index)
            Exit Sub
        End If
        ' Removes one from the wuantity
        DisplayInfo(index.X, index.Y).Quantity -= 1
        DisplayInfo(index.X, index.Y).Total = DisplayInfo(index.X, index.Y).Cost * DisplayInfo(index.X, index.Y).Quantity

        UpdateDisplay()

    End Sub

    Sub ControlRemoveItem(sender As Object, e As EventArgs)

        Dim index As Point

        index = GetIndex()

        If (index.X = -1) Then
            Exit Sub
        End If

        RemoveItem(index)

    End Sub

    Sub ControlClear()
        ' Goes through each display information and removes them then updates the display
        For y = 0 To 2
            For x = 0 To 3

                DisplayInfo(x, y) = CreateDisplayInfo()

            Next
        Next

        UpdateDisplay()

    End Sub

    Sub ControlConfirm(sender As Object, e As EventArgs)

        If Total = 0 Then
            MsgBox("There is nothing to pay for.")
            Exit Sub
        End If

        Dim TimeCompelete As DateTime = Date.Now
        Dim PaymentType As String = InputBox("Please enter payment type:")

        Me.DBDataSet.TillRollLog.Rows.Add()

        If MsgBox("Confirm purchase.", MessageBoxButtons.YesNo) = 7 Then
            Exit Sub
        End If
        ' Creates a new Till roll log row and saves the details of the transaction
        Dim TillLogID As Integer = Me.DBDataSet.TillRollLog.Rows.Count - 1

        If TillLogID = -1 Then
            TillLogID = 0
        End If

        With Me.DBDataSet.TillRollLog
            .Item(TillLogID).Total = Me.Total
            .Item(TillLogID).PaymentType = PaymentType
            .Item(TillLogID).SellerID = Me.ID
            .Item(TillLogID).TimeCompleted = TimeCompelete.ToString("d")
        End With
        ' Saves each item and links them to the till roll log ID
        ' Only saves the item if an item exists
        For y = 0 To 2
            For x = 0 To 3

                If DisplayInfo(x, y).Name <> "" Then

                    Me.DBDataSet.ItemTIllLookup.Rows.Add()

                    Dim LastRow As Integer = Me.DBDataSet.ItemTIllLookup.Rows.Count - 1

                    If LastRow = -1 Then
                        LastRow = 0
                    End If

                    With Me.DBDataSet.ItemTIllLookup
                        .Item(LastRow).TillLogID = TillLogID + 1
                        .Item(LastRow).ItemName = DisplayInfo(x, y).Name
                        .Item(LastRow).ItemQuantity = DisplayInfo(x, y).Quantity
                        .Item(LastRow).ItemPrice = DisplayInfo(x, y).Cost
                        .Item(LastRow).Total = DisplayInfo(x, y).Total
                    End With

                End If

            Next
        Next

        FRMlogin.LogAction($"Completed transaction with ID: {TillLogID}", Me.Name)

        MsgBox("Transaction complete.")

        ControlClear()

        UpdateTables()

    End Sub

    Sub LeftArrowClick(sender As Object, e As EventArgs)
        ' Moves to the previous page
        If pageNumber <> 1 Then

            pageNumber -= 1

            UpdateDisplay()
        End If

    End Sub

    Sub RightArrowClick(sender As Object, e As EventArgs)
        ' Moves to the next page
        If pageNumber <> 3 Then

            pageNumber += 1

            UpdateDisplay()

        End If

    End Sub

    Sub PotClick(sender As Object, e As EventArgs)
        ' Gets the pots details and saves them to the next available display slot if possible
        Dim Name As String
        Dim Price As Decimal
        Dim Quantity As Decimal

        Name = sender.text

        If Name = "" Then
            Exit Sub
        End If

        Dim flag As Boolean = False
        'Gets thte price of a single one of the item
        Do
            Try
                Price = CDec(InputBox("Enter price per one. (Use -1 to exit)"))

                flag = True

                If Price = -1 Then

                    Exit Sub

                End If

            Catch ex As Exception

            End Try

        Loop Until flag

        flag = False
        ' Gets the amount of the item
        Do
            Try
                Quantity = CDec(InputBox("How many. (Pitch fee, rent etc are 1)"))

                flag = True

                If Quantity = -1 Then

                    Exit Sub

                End If

            Catch ex As Exception

            End Try

        Loop Until flag
        ' Determines price and puts the item in the next free display slot
        Dim NextFree As Point = FindNextFree()

        Dim Total As Decimal = Price * Quantity

        DisplayInfo(NextFree.X, NextFree.Y) = CreateDisplayInfo(Name, Price, Quantity, Total)

        UpdateDisplay()

    End Sub

    ' Extra display functions

    Sub AddDisplayItem(item As DisplayItem)
        ' Adds the Displlay item to the control so you can see it
        TBPTill.Controls.Add(item.Container)
        item.Container.BringToFront()

        TBPTill.Controls.Add(item.Index)
        item.Index.BringToFront()

        TBPTill.Controls.Add(item.Name)
        item.Name.BringToFront()

        TBPTill.Controls.Add(item.Quantity)
        item.Quantity.BringToFront()

        TBPTill.Controls.Add(item.Cost)
        item.Cost.BringToFront()

        TBPTill.Controls.Add(item.Total)
        item.Total.BringToFront()

        Application.DoEvents()

    End Sub

    Sub UpdateDisplay()
        'Moves between the pages of the items
        For i = 0 To 3

            With DisplayItems(i)
                .Index.Text = $"Row: {i + 1}, Page: {pageNumber} of 3"
                .Name.Text = $"Name: {DisplayInfo(i, pageNumber - 1).Name}"
                .Cost.Text = $"Cost Per Item: £{DisplayInfo(i, pageNumber - 1).Cost}"
                .Quantity.Text = $"Quantity: {DisplayInfo(i, pageNumber - 1).Quantity}"
                .Total.Text = $"Total: £{DisplayInfo(i, pageNumber - 1).Total}"
            End With

            Application.DoEvents()

            AddDisplayItem(DisplayItems(i))

        Next

        UpdateTotal()

    End Sub

    Sub UpdateTotal()

        Dim total As Decimal
        ' Takes the sum of all the items totals and displays that in the Total label at the bottom
        For y = 0 To 2
            For x = 0 To 3

                If DisplayInfo(x, y).Name = "Paid Out" Then
                    total -= DisplayInfo(x, y).Total
                Else
                    total += DisplayInfo(x, y).Total
                End If

            Next
        Next

        Me.TillTotal.Total.Text = $"Total: £{total}"
        Me.Total = total

        Application.DoEvents()

    End Sub

    ' Extra functions

    Function FindNextFree()
        'Goes through the display information to see if there is a space for another item and returns the index
        For y = 0 To 2
            For x = 0 To 3

                If DisplayInfo(x, y).Name = "" Then

                    Return New Point(x, y)

                End If

            Next
        Next

        MsgBox("The list is full please remove an item before adding another")

        Return New Point(-1, -1)

    End Function

    Private Sub FRMtill_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Me.Dispose()

    End Sub

    ' Main  section of the till up tabpage

    Sub LoadStats()

        Dim TransactionTotal As Double
        Dim PotTotal As Double

        Dim LastDate As Date = New Date
        Dim DayTotal As Double

        For Each row In DBDataSet.TillRollLog
            'Displays all transactions that have happened that week
            If InWeek(row.TimeCompleted) Then

                DGVTransactionTillUp.Rows.Add(New String() {"", "", "", ""})

                DGVTransactionTillUp.Item(0, DGVTransactionTillUp.Rows.Count - 1).Value = $"{row.ID}"
                DGVTransactionTillUp.Item(1, DGVTransactionTillUp.Rows.Count - 1).Value = $"{row.TimeCompleted.ToString("d")}"
                DGVTransactionTillUp.Item(2, DGVTransactionTillUp.Rows.Count - 1).Value = $"{row.PaymentType}"
                DGVTransactionTillUp.Item(3, DGVTransactionTillUp.Rows.Count - 1).Value = $"£{row.Total}"

                DGVTransactionTillUp.Item(3, DGVTransactionTillUp.Rows.Count - 1).Style.BackColor = Color.LimeGreen

                TransactionTotal += CInt(row.Total)
                'Adds the date to the graph
                If LastDate <> New Date Then
                    If LastDate.ToString("d") <> row.TimeCompleted.ToString("d") Then
                        ' Record day total in the chart

                        CHRTStats.Series(0).Points.Add(DayTotal)

                        ' Reset day total

                        DayTotal = 0
                    End If
                Else

                End If

                DayTotal += row.Total
                LastDate = row.TimeCompleted.ToString("d")

                Application.DoEvents()
                'Creates a sum of the pots totals
                For Each item In DBDataSet.ItemTIllLookup
                    If item.TillLogID = row.ID Then

                        DGVPotTillUp.Rows.Add(New String() {"", "", "", ""})

                        DGVPotTillUp.Item(0, DGVPotTillUp.Rows.Count - 1).Value = $"{item.ItemName}"
                        DGVPotTillUp.Item(1, DGVPotTillUp.Rows.Count - 1).Value = $"{item.ItemQuantity}"
                        DGVPotTillUp.Item(2, DGVPotTillUp.Rows.Count - 1).Value = $"£{item.ItemPrice}"
                        DGVPotTillUp.Item(3, DGVPotTillUp.Rows.Count - 1).Value = $"£{item.Total}"

                        DGVPotTillUp.Item(3, DGVPotTillUp.Rows.Count - 1).Style.BackColor = Color.LimeGreen

                        If item.ItemName = "Paid Out" Then
                            PotTotal -= CInt(item.Total)
                        Else
                            PotTotal += CInt(item.Total)
                        End If

                    End If
                Next

            End If
        Next

        CHRTStats.Series(0).Points.Add(DayTotal)
        ' Makes the chart bigger if there is little to see
        If CHRTStats.Series(0).Points.Count = 1 Then
            CHRTStats.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.FastPoint
            CHRTStats.Series(0).MarkerSize = 15
        End If

        ' Add the final totaling row for each DGV

        DGVTransactionTillUp.Rows.Add(New String() {"Total", "", "", $"£{TransactionTotal}"})
        DGVTransactionTillUp.Item(3, DGVTransactionTillUp.Rows.Count - 1).Style.BackColor = Color.Green
        DGVTransactionTillUp.Item(3, DGVTransactionTillUp.Rows.Count - 1).Style.ForeColor = Color.White
        DGVPotTillUp.Rows.Add(New String() {"Total", "", "", $"£{PotTotal}"})
        DGVPotTillUp.Item(3, DGVPotTillUp.Rows.Count - 1).Style.BackColor = Color.Green
        DGVPotTillUp.Item(3, DGVPotTillUp.Rows.Count - 1).Style.ForeColor = Color.White
    End Sub

    Function InWeek(day As Date)
        ' Sees if the months match
        If day.Month = StartOfWeek.Month Then
            ' Sees if the day of the week is less than the beggining of the week
            If CInt(day.Day) >= CInt(StartOfWeek.Day) Then
                ' Sees if the day of the week is greater than the beggining of the week
                If CInt(day.Day) < CInt(StartOfWeek.Day) + 7 Then

                    Return True

                End If
            End If
        End If

        Return False

    End Function

End Class