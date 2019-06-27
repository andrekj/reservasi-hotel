Public Class Room1
    Dim modeproses As Integer
    Dim baris As Integer

    Private Sub RefreshGrid()
        Dim dgvcCheckBox As New DataGridViewCheckBoxColumn()
        dgvcCheckBox.HeaderText = "Select"


        DTGrid = KontrolKamar.tampilRooms.ToTable
        DataGridView1.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DataGridView1.Rows(DTGrid.Rows.Count - 1).Selected = True
            DataGridView1.CurrentCell = DataGridView1.Item(1, baris)
            DataGridView1.Columns.Add(dgvcCheckBox)
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.AllowUserToAddRows = False
        End If
    End Sub

    Private Sub Room1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        RefreshGrid()


        'columns for dataGridView2
        Dim dgvcId2 As New DataGridViewTextBoxColumn()
        dgvcId2.HeaderText = "Id"
        Dim dgvcFn2 As New DataGridViewTextBoxColumn()
        dgvcFn2.HeaderText = "First Name"
        Dim dgvcLn2 As New DataGridViewTextBoxColumn()
        dgvcLn2.HeaderText = "Last Name"
        Dim dgvcCheckBox2 As New DataGridViewCheckBoxColumn()
        dgvcCheckBox2.HeaderText = "Select"
        DataGridView2.Columns.Add(dgvcId2)
        DataGridView2.Columns.Add(dgvcFn2)
        DataGridView2.Columns.Add(dgvcLn2)
        DataGridView2.Columns.Add(dgvcCheckBox2)
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.AllowUserToAddRows = False
    End Sub

    Private Sub BtbDisplay_Click(sender As Object, e As EventArgs) Handles BtbDisplay.Click

        ' loop to check if the checkbox cell is checked
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1

            ' rowAlreadyExist => if the row already exist on dataGridView2
            Dim rowAlreadyExist As Boolean = False
            Dim check As Boolean = DataGridView1.Rows(i).Cells(3).Value
            Dim row As DataGridViewRow = DataGridView1.Rows(i)
            If check = True Then

                ' the dataGridView2 have one row or more
                If DataGridView2.Rows.Count() > 0 Then

                    ' loop to see if the row already exist on dataGridView2
                    For j As Integer = 0 To DataGridView2.Rows.Count() - 1 Step +1
                        If row.Cells(0).Value.ToString() = DataGridView2.Rows(j).Cells(0).Value.ToString() Then
                            rowAlreadyExist = True
                            Exit For

                        End If
                    Next

                    If rowAlreadyExist = False Then
                        DataGridView2.Rows.Add(row.Cells(0).Value.ToString(),
                                               row.Cells(1).Value.ToString(),
                                               row.Cells(2).Value.ToString(),
                                               row.Cells(3).Value)
                    End If

                Else
                    DataGridView2.Rows.Add(row.Cells(0).Value.ToString(),
                                                   row.Cells(1).Value.ToString(),
                                                   row.Cells(2).Value.ToString(),
                                                   row.Cells(3).Value)

                End If
            End If


        Next

    End Sub
End Class

