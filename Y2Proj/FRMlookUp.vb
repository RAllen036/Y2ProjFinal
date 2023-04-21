Public Class FRMlookUp

    Structure Filter
        Dim Container As Panel
        Dim FilterLabel As Label
        Dim IDFilter As Button
        Dim UsernameFilter As Button
        Dim AddressFilter As Button
    End Structure

    Dim FilterOptions As Filter

    Private Sub FRMlookUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.DBDataSet.Users)

        Me.WindowState = FormWindowState.Maximized

        Dim tempSize As Size = screenSize()

        With DGVlookupTable
            .Font = fType(FontSize:=35)
            .Size = New Size(tempSize.Width * 0.5, tempSize.Height * 0.9)
        End With

        DGVlookupTable.Sort(DGVlookupTable.Columns(0), 0) ' Sorts the data grid view based on the ID

        DGVlookupTable.AutoResizeColumns()
        DGVlookupTable.AutoResizeRows()

        InnitFilterOptions()

    End Sub

    Sub InnitFilterOptions()
        Dim FilterLocation As New Point(DGVlookupTable.Location.X + DGVlookupTable.Width, DGVlookupTable.Location.Y)

        FilterOptions = New Filter

        With FilterOptions
            .Container = New Panel With {
                .Size = New Size(170, 210),
                .Location = New Point(FilterLocation.X + 80, FilterLocation.Y),
                .BackColor = Color.Green
            }

            .FilterLabel = New Label With {
                .Text = "Filter by:",
                .AutoSize = False,
                .Size = New Size(150, 40),
                .Location = New Point(FilterLocation.X + 90, FilterLocation.Y + 10),
                .Font = fType(FontSize:=30),
                .TextAlign = ContentAlignment.MiddleCenter,
                .BackColor = Color.LimeGreen,
                .BorderStyle = BorderStyle.FixedSingle
            }

            .IDFilter = New Button With {
                .Text = "ID",
                .AutoSize = False,
                .Size = New Size(150, 40),
                .Location = New Point(FilterLocation.X + 90, FilterLocation.Y + 60),
                .Font = fType(),
                .TextAlign = ContentAlignment.MiddleCenter,
                .BackColor = Color.LimeGreen
            }

            .UsernameFilter = New Button With {
                .Text = "Username",
                .AutoSize = False,
                .Size = New Size(150, 40),
                .Location = New Point(FilterLocation.X + 90, FilterLocation.Y + 110),
                .Font = fType(),
                .TextAlign = ContentAlignment.MiddleCenter,
                .BackColor = Color.LimeGreen
            }

            .AddressFilter = New Button With {
                .Text = "Address",
                .AutoSize = False,
                .Size = New Size(150, 40),
                .Location = New Point(FilterLocation.X + 90, FilterLocation.Y + 160),
                .Font = fType(),
                .TextAlign = ContentAlignment.MiddleCenter,
                .BackColor = Color.LimeGreen
            }
        End With

        AddHandler FilterOptions.AddressFilter.Click, AddressOf FilterAddress

        AddHandler FilterOptions.UsernameFilter.Click, AddressOf FilterUsername

        AddHandler FilterOptions.IDFilter.Click, AddressOf FilterID

        Me.Controls.Add(FilterOptions.AddressFilter)

        Me.Controls.Add(FilterOptions.UsernameFilter)

        Me.Controls.Add(FilterOptions.IDFilter)

        Me.Controls.Add(FilterOptions.FilterLabel)

        Me.Controls.Add(FilterOptions.Container)
    End Sub

    Sub FilterDGV(Col As Integer, Order As Integer)

        DGVlookupTable.Sort(DGVlookupTable.Columns(Col), Order)

        DGVlookupTable.AutoResizeColumns()
        DGVlookupTable.AutoResizeRows()

    End Sub

    Sub FilterID()
        Static order As Integer = 1

        FilterDGV(0, order)

        order += 1

        If order > 1 Then
            order = 0
        End If
    End Sub

    Sub FilterUsername()
        Static order As Integer = 0

        FilterDGV(1, order)

        order += 1

        If order > 1 Then
            order = 0
        End If
    End Sub

    Sub FilterAddress()
        Static order As Integer = 0

        FilterDGV(2, order)

        order += 1

        If order > 1 Then
            order = 0
        End If
    End Sub

    Private Sub FRMlookUp_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class