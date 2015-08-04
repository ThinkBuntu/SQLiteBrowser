Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Management
Imports System.Net

Public Class Home
    Dim sCopy As Boolean
    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
    End Sub

    Private Sub ToolStripButton_Database_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton_Database.Click
        Dim Form_Koneksi As New Form_Koneksi
        Form_Koneksi.MdiParent = Me
        Form_Koneksi.Show()
    End Sub

    Private Sub ToolStripButton_Query_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripButton_Query.Click
        Dim Form_Query As New Form_Query
        Form_Query.MdiParent = Me
        Form_Query.Show()
    End Sub
End Class