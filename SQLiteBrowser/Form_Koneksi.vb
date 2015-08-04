Public Class Form_Koneksi

    Private Sub Button_Database_Click(sender As System.Object, e As System.EventArgs) Handles Button_Database.Click
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            Txt_Database.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Btn_Save_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Save.Click
        If Txt_Database.Text = "" Then
            MsgBox("Silahkan pilih Database !!")
            Exit Sub
        Else
            Home.Label_Database.Text = Txt_Database.Text
            sDBLite = Txt_Database.Text
        End If

        
    End Sub
End Class