Partial Class StaffDataSet
    Partial Public Class StaffDataTable
        Private Sub StaffDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.NameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
