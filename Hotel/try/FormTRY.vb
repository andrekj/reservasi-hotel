Public Class FormTRY
    Private Sub FormTRY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'create a text columns
        Dim dgvcId As New DataGridViewTextBoxColumn()
        dgvcId.HeaderText = "Id"
        Dim dgvcFn As New DataGridViewTextBoxColumn()
        dgvcFn.HeaderText = "First Name"
        Dim dgvcLn As New DataGridViewTextBoxColumn()
        dgvcLn.HeaderText = "Last Name"

        'create checkbox column
        Dim dgvcCheckBox As New DataGridViewCheckBoxColumn()
        dgvcCheckBox.HeaderText = "Select"

        'add columns to datagridview
        DataGridView1.Columns.Add(dgvcId)
        DataGridView1.Columns.Add(dgvcFn)
        DataGridView1.Columns.Add(dgvcLn)
        DataGridView1.Columns.Add(dgvcCheckBox)

        ' add some row to datagridview
        ' true the checkBox Is checked
        ' false the checkBox Is Not checked
        DataGridView1.Rows.Add("1", "DTYUI", "RTYUI", False)
        DataGridView1.Rows.Add("2", "KJHGF", "OIUY", False)
        DataGridView1.Rows.Add("3", "SDFGH", "LTDFGH", False)
        DataGridView1.Rows.Add("4", "ERJHGV", "CVHEYH", False)
        DataGridView1.Rows.Add("5", "AQSFGHKK", "TRDFHJH", False)
        DataGridView1.Rows.Add("6", "NQAAZTYI", "KITGHKG", False)
        DataGridView1.Rows.Add("7", "XBVSARY", "OTYHNC", False)
        DataGridView1.Rows.Add("8", "ACJKT", "PMLGESB", False)
        DataGridView1.Rows.Add("9", "FGHKL", "IUYTEYK", False)
        DataGridView1.Rows.Add("10", "WQAZR", "ERTYUVBD", False)
        DataGridView1.Rows.Add("11", "CKKTS", "EGCQA", False)

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AllowUserToAddRows = False


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