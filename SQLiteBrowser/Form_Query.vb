Public Class Form_Query

    Private Sub TextBoxQuery_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBoxQuery.KeyDown
        If e.KeyValue = 116 Then

            AdaHasil = True
            ''MsgBox(TextBoxQuery.SelectedText)

            sSQL = "" & TextBoxQuery.SelectedText & ""

            OpenRecordsetLite(sSQL)

            If AdaHasil Then
                If readerLite.HasRows Then
                    Call Listview_TambahListSqlLite(Lvw_Result, readerLite)
                End If

                Call CloseSQLite()
            End If
            Call CloseSQLite2()
        End If

    End Sub

    Private Sub TextBoxQuery_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxQuery.TextChanged

    End Sub
End Class