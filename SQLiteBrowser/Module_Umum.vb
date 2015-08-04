Option Explicit On

Imports System.Data.SqlClient
Imports System.IO

Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Net.Mime.MediaTypeNames
Imports System.Net


Imports System.Net.Mail
Imports System.Data.SQLite


Module Module_Umum

    Public Password_Login As String = ""
    Public NIP_Login As String = ""
    Public Nama_Login As String = ""

    Public Auth_Login As String = ""
    Public Cabang_Login As String = ""
    Public NamaCabang_Login As String = ""
    Public KodeCabang_Login As String = ""
    Public periode As String
    Public ManaYgDiklik As String
    Public sLocal_Folder As String = "\\192.168.0.7\Teguhsindo\MeBrow\Report\"
    Public sLocal_Folder2 As String = "D:\ReportDPLDPF\"
    Public sServer_Folder As String = "\\192.168.0.7\Teguhsindo\MeBrow\Report\"

    Public sPT2 As String
    Public sPT As String
    Public sNamaPT As String
    Public sKodePT As String = "01"
    Public database As String = sPT + "_MKT"
    Public Server As String = "192.168.0.7"
    Public UserId As String = "nunung"
    Public Password As String = "nunung123.mkt"

    Public con1 As New SqlClient.SqlConnection
    Public con2 As New SqlClient.SqlConnection
    Public con3 As New SqlClient.SqlConnection
    Public reader As SqlClient.SqlDataReader
    Public reader2 As SqlClient.SqlDataReader
    Public reader3 As SqlClient.SqlDataReader
    Public sSQL As String

    Public adapter As SqlClient.SqlDataAdapter
    Public cmd As SqlClient.SqlCommand
    Public cmd2 As SqlClient.SqlCommand
    Public cmd3 As SqlClient.SqlCommand
    Public cmd4 As SqlClient.SqlCommand


    Public HDD_Serial As String
    Public sKodeCust_HistDPL As String
    Public sKodeOut_HistDPL As String
    Public sNamaCust_HistDPL As String
    Public sKeteranganReject As String
    Public sKodeReq_Public As String

    Public connectionString As String
    Public SQLiteConnection As SqlConnection

    Public cmdLite As New SQLite.SQLiteCommand
    Public dssLite As New DataSet
    Public dssLite2 As New DataSet
    Public dasLite As New SQLite.SQLiteDataAdapter
    Public dasLite2 As New SQLite.SQLiteDataAdapter
    Public sDBLite As String
    Dim sPasLite As String = "sdgrt821a5e83u54zxc23bn"
    Dim sIDLite As String = "sdgrt8"
    Public consLite As New SQLite.SQLiteConnection
    Public readerLite As SQLiteDataReader
    Public AdaHasil As Boolean

    Public Sub CekDatabaseLite()
        If Not Directory.Exists(sDBLite) Then
            Directory.CreateDirectory(sDBLite)
        End If
        If Not File.Exists(sDBLite + "\Mebrow.db") Then
            Call CreateDBLite()
            Call CreateTableLite("(Elename varchar(50))", "UserMFTL")
            Call OpenExecuteLite("INSERT INTO UserMFTL VALUES('Testing')")
            Call OpenRecordsetLite("Select * From UserMFTL")
        End If

    End Sub

    Public Function koneksiLite() As SQLite.SQLiteConnection
        Dim konLite As SQLite.SQLiteConnection
        konLite = New SQLite.SQLiteConnection("Data Source=" + sDBLite + "\Mebrow.db;Version=3;User id=" & sIDLite & ";Password=" + sPasLite + "")
        consLite = konLite
    End Function

    Public Sub CreateTableLite(ByVal sKolomTable As String, ByVal sNamaTable As String)
        If consLite.State = ConnectionState.Open Then
            consLite.Close()
        End If

        Dim sSQLCreate As String = "create table " + sNamaTable + " " + sKolomTable
        consLite.ConnectionString = "Data Source=" + sDBLite + "\Mebrow.db;Version=3;User id=" & sIDLite & ";Password=" + sPasLite + ""
        consLite.Open()
        dasLite = New SQLite.SQLiteDataAdapter(sSQLCreate, consLite)
        dasLite.Fill(dssLite, sNamaTable.ToLower)
        consLite.Close()
    End Sub
    Private Sub CreateDBLite()
        SQLite.SQLiteConnection.CreateFile(sDBLite + "\Mebrow.db")
    End Sub

    Public Sub CloseSQLite()
        readerLite.Close()
        cmdLite.Dispose()
        consLite.Close()
    End Sub
    Public Sub CloseSQLite2()
        cmdLite.Dispose()
        consLite.Close()
    End Sub
    Public Function OpenExecuteLite(ByVal sSQL As String)
        If consLite.State = ConnectionState.Open Then
            consLite.Close()
        End If

        consLite.ConnectionString = "Data Source=" + sDBLite + "\Mebrow.db;Version=3;User id=" & sIDLite & ";Password=" + sPasLite + ""
        Dim Command As SQLiteCommand
        Command = New SQLiteCommand(sSQL, consLite)
        consLite.Open()
        Command.ExecuteNonQuery()
        Command.Dispose()
        consLite.Close()
    End Function

    Public Function OpenRecordsetLite(ByVal sSQL As String)

        Try
            If consLite.State = ConnectionState.Open Then
                consLite.Close()
            End If

            consLite.ConnectionString = "Data Source=" + sDBLite + ";Version=3;User id=" & sIDLite & ";Password=" + sPasLite + ""
            consLite.Open()
            cmdLite = consLite.CreateCommand()
            cmdLite.CommandText = sSQL
            cmdLite.CommandTimeout = 0
            cmdLite.CommandType = CommandType.Text
            readerLite = cmdLite.ExecuteReader()
        Catch ex As Exception
            AdaHasil = False
            MsgBox(" Error :  " + ex.ToString)

        End Try


    End Function


    Public Function OpenExecuteII(ByVal sSQL1 As String)
        If con2.State = ConnectionState.Open Then
            con2.Close()
        End If

        cmd = New SqlClient.SqlCommand(sSQL1)
        cmd.CommandTimeout = 0
        cmd.Connection = con2
        con2.Open()

        cmd.ExecuteNonQuery()

    End Function


    Public Function OpenExecute(ByVal sSQL1 As String)
        If con1.State = ConnectionState.Open Then
            con1.Close()
        End If

        cmd = New SqlClient.SqlCommand(sSQL1)
        cmd.CommandTimeout = 0
        cmd.Connection = con1
        con1.Open()

        cmd.ExecuteNonQuery()

    End Function
    Public Function OpenRecordSetIII(ByVal sSQL As String)
        If con3.State = ConnectionState.Open Then
            con3.Close()
        End If

        cmd3 = New SqlClient.SqlCommand(sSQL)
        cmd.CommandTimeout = 0
        cmd3.Connection = con3
        con3.Open()

        reader3 = cmd3.ExecuteReader
    End Function
    Public Function OpenRecordSetII(ByVal sSQL As String)
        If con2.State = ConnectionState.Open Then
            con2.Close()
        End If

        cmd2 = New SqlClient.SqlCommand(sSQL)
        cmd.CommandTimeout = 0
        cmd2.Connection = con2
        con2.Open()

        reader2 = cmd2.ExecuteReader
    End Function
    Public Function OpenRecordSet(ByVal sSQL As String)
        If con1.State = ConnectionState.Open Then
            con1.Close()
        End If

        cmd = New SqlClient.SqlCommand(sSQL)
        cmd.CommandTimeout = 0
        cmd.Connection = con1
        con1.Open()

        reader = cmd.ExecuteReader
    End Function

    Public Function koneksi() As SqlClient.SqlConnection
        Dim kon As SqlClient.SqlConnection
        'data SQL2008
        kon = New SqlClient.SqlConnection("Data Source=192.168.0.7;Initial Catalog=" & sPT & "_MKT;Connection Timeout=0;User id=" & UserId & ";password=" & Password & ";")
        Return kon
        kon = Nothing
    End Function
    Public Function koneksi2() As SqlClient.SqlConnection
        Dim kon As SqlClient.SqlConnection
        Try
            'data SQL2008
            kon = New SqlClient.SqlConnection("Data Source=192.168.0.7;Initial Catalog=" & sPT & "_MKT;Connection Timeout=0;User id=" & UserId & ";password=" & Password & ";")
            Return kon
            kon = Nothing
        Catch ex As Exception
            MsgBox("Koneksi dengan server gagal, mohon pastikan koneksi LAN atau Internet anda jalan !")
            End
        End Try
    End Function

    Public Sub FillListView(ByRef MyListView As ListView, ByRef myData As SqlDataReader)
        Dim lvwColumn As ColumnHeader
        Dim itmListItem As ListViewItem
        Dim strTest As String
        Dim shtCntr As Short

        MyListView.Clear()

        For shtCntr = 0 To myData.FieldCount() - 1
            lvwColumn = New ColumnHeader()
            lvwColumn.Text = myData.GetName(shtCntr)
            MyListView.Columns.Add(lvwColumn)
        Next

        Do While myData.Read
            itmListItem = New ListViewItem()
            strTest = IIf(myData.IsDBNull(0), "", myData.GetString(0))
            itmListItem.Text = strTest

            For shtCntr = 1 To myData.FieldCount() - 1
                If myData.IsDBNull(shtCntr) Then
                    itmListItem.SubItems.Add("")
                Else
                    itmListItem.SubItems.Add(myData.GetString(shtCntr))
                End If
            Next shtCntr

            MyListView.Items.Add(itmListItem)
        Loop

        For i As Integer = 0 To MyListView.Columns.Count - 1
            MyListView.Columns(i).Width = -5
        Next i

    End Sub

    Public Sub Listview_TambahListSqlLite(ByRef ListView1 As ListView, ByRef myData As SQLiteDataReader)
        Try

            Dim iKolom As Integer
            Dim iBaris As Integer

            ListView1.Clear()
            ListView1.View = View.Details

            iKolom = readerLite.FieldCount
            iBaris = 0

            For i As Integer = 0 To iKolom - 1
                ListView1.Columns.Add("", 60, HorizontalAlignment.Left)
                ListView1.Columns(i).Text = myData.GetName(i)
            Next
            Do While myData.Read
                ListView1.Items.Add(Trim(readerLite(0))) 'col no. 1
                For i As Integer = 1 To iKolom - 1
                    ListView1.Items(iBaris).SubItems.Add(Trim(readerLite(i))) 'col no. 2 - Dst
                Next
                iBaris = iBaris + 1
            Loop
            For i As Integer = 0 To iKolom - 1
                ListView1.Columns(i).Width = -2
            Next

        Catch ex As Exception

            MsgBox(" Error :  " + ex.ToString)

        End Try



    End Sub


    Public Sub Listview_TambahList(ByRef ListView1 As ListView, ByRef myData As SqlDataReader)
        'Dim iKolom As Integer
        'Dim iBaris As Integer

        'ListView1.Clear()
        'ListView1.View = View.Details

        'iKolom = reader.FieldCount
        'iBaris = 0

        'For i As Integer = 0 To iKolom - 1
        '    ListView1.Columns.Add("", 60, HorizontalAlignment.Left)
        '    ListView1.Columns(i).Text = myData.GetName(i)
        'Next
        'Do While myData.Read

        '    If IsNumeric(reader(0)) = True Then
        '        ListView1.Items.Add(Trim(FormatNumber(reader(0)))) 'col no. 1
        '    Else
        '        ListView1.Items.Add(Trim(reader(0))) 'col no. 1
        '    End If
        '    For i As Integer = 1 To iKolom - 1
        '        If IsNumeric(reader(i)) = True Then
        '            ListView1.Items(iBaris).SubItems.Add(Trim(FormatNumber(reader(i)))) 'col no. 2 - Dst
        '        Else
        '            ListView1.Items(iBaris).SubItems.Add(Trim(reader(i))) 'col no. 2 - Dst
        '        End If

        '    Next
        '    iBaris = iBaris + 1
        'Loop
        'For i As Integer = 0 To iKolom - 1
        '    ListView1.Columns(i).Width = -2
        'Next


        Dim iKolom As Integer
        Dim iBaris As Integer

        ListView1.Clear()
        ListView1.View = View.Details

        iKolom = reader.FieldCount
        iBaris = 0

        For i As Integer = 0 To iKolom - 1
            ListView1.Columns.Add("", 60, HorizontalAlignment.Left)
            ListView1.Columns(i).Text = myData.GetName(i)
        Next
        Do While myData.Read
            ListView1.Items.Add(Trim(reader(0))) 'col no. 1
            For i As Integer = 1 To iKolom - 1
                ListView1.Items(iBaris).SubItems.Add(Trim(reader(i))) 'col no. 2 - Dst
            Next
            iBaris = iBaris + 1
        Loop
        For i As Integer = 0 To iKolom - 1
            ListView1.Columns(i).Width = -2
        Next
    End Sub

    Public Sub Listview_TambahList_Value(ByRef ListView1 As ListView, ByRef myData As SqlDataReader)
        Dim iKolom As Integer
        Dim iBaris As Integer

        ListView1.Clear()
        ListView1.View = View.Details

        iKolom = reader.FieldCount
        iBaris = 0

        For i As Integer = 0 To iKolom - 1
            ListView1.Columns.Add("", 60, HorizontalAlignment.Left)
            ListView1.Columns(i).Text = myData.GetName(i)
        Next
        Do While myData.Read

            If IsNumeric(reader(0)) = True Then
                ListView1.Items.Add(Trim(FormatNumber(reader(0)))) 'col no. 1
            Else
                ListView1.Items.Add(Trim(Replace(reader(0), "`", ""))) 'col no. 1
            End If
            For i As Integer = 1 To iKolom - 1
                If IsNumeric(reader(i)) = True Then
                    ListView1.Items(iBaris).SubItems.Add(Trim(FormatNumber(reader(i)))) 'col no. 2 - Dst
                Else
                    ListView1.Items(iBaris).SubItems.Add(Trim(Replace(reader(i), "`", ""))) 'col no. 2 - Dst
                End If

            Next
            iBaris = iBaris + 1
        Loop
        For i As Integer = 0 To iKolom - 1
            ListView1.Columns(i).Width = -2
        Next
    End Sub
    Public Sub Validasi_Input(ByVal oTextBox As TextBox)
        oTextBox.Text = Replace(Replace(Replace(Trim(oTextBox.Text), "%", ""), "'", ""), """", "")
    End Sub

    Public Sub ListView_CekCentang(ByVal ListView1 As ListView, ByRef sData As String, ByVal sItem As Integer)
        Dim i As Integer
        i = 0
        sData = "('',"
        For Each item As ListViewItem In ListView1.Items
            If item.Checked Then
                sData = sData & "'" & ListView1.Items(i).SubItems(sItem).Text & "',"
            End If
            i = i + 1
        Next
        sData = sData & "'')"
    End Sub
    Public Sub ExportToCSV(ByRef myData As SqlClient.SqlDataReader, ByVal sJenisAnalisa As String)
        Dim iKolom As Integer
        Dim iBaris As Integer
        Dim strExport As String
        iKolom = reader.FieldCount
        iBaris = 0

        For i As Integer = 0 To iKolom - 1
            strExport += myData.GetName(i) & "|"
        Next

        strExport = strExport.Substring(0, strExport.Length - 3) + Environment.NewLine.ToString()
        Do While myData.Read
            For i As Integer = 0 To iKolom - 1
                If IsDBNull(reader(i)) Then
                    strExport += Trim(" ") & "|"
                Else
                    strExport += Trim(reader(i)) & "|"
                End If
            Next
            strExport += Environment.NewLine.ToString()
        Loop

        strExport = strExport.Substring(0, strExport.Length - 3) + Environment.NewLine.ToString()
        Dim tw As System.IO.TextWriter = New System.IO.StreamWriter("D:\Promosi\INPUT PELUNASAN\INPUT PELUNASAN.csv")
        tw.Write(strExport)
        tw.Close()

        If sJenisAnalisa = "1" Then
            MsgBox("Data Berhasil di simpan di D:\Promosi\INPUT PELUNASAN\INPUT PELUNASAN.csv")
        End If
    End Sub
    Public Sub ExportToCSVII(ByRef myData As SqlClient.SqlDataReader, ByVal sJenisAnalisa As String)
        Dim iKolom As Integer
        Dim iBaris As Integer
        Dim strExport As String
        iKolom = reader.FieldCount
        iBaris = 0

        Dim sFolder = "D:\SalesFF\"

        '' Jika Folder Belum ada, Buat dulu
        If Not Directory.Exists(sFolder) Then
            Directory.CreateDirectory(sFolder)
        End If

        For i As Integer = 0 To iKolom - 1
            strExport += myData.GetName(i) & "|"
        Next

        strExport = strExport.Substring(0, strExport.Length - 3) + Environment.NewLine.ToString()
        Do While myData.Read
            For i As Integer = 0 To iKolom - 1
                If IsDBNull(reader(i)) Then
                    strExport += Trim(" ") & "|"
                Else
                    strExport += Trim(reader(i)) & "|"
                End If
            Next
            strExport += Environment.NewLine.ToString()
        Loop

        strExport = strExport.Substring(0, strExport.Length - 3) + Environment.NewLine.ToString()
        Dim tw As System.IO.TextWriter = New System.IO.StreamWriter("" & sFolder & "Data Sales FF.csv")
        tw.Write(strExport)
        tw.Close()

        If sJenisAnalisa = "1" Then
            MsgBox("Data Berhasil di simpan di " & sFolder & "Data Sales FF.csv")
        End If
    End Sub
    Public Sub Update_CRLocal(ByVal FileReport As String)

        Dim client As New System.Net.WebClient()
        Dim client_VB As New System.Net.WebClient()

        client.Credentials = CredentialCache.DefaultCredentials
        client_VB.Credentials = CredentialCache.DefaultCredentials

        '' Jika Folder Belum ada, Buat dulu
        If Not Directory.Exists(sLocal_Folder) Then
            Directory.CreateDirectory(sLocal_Folder)
        End If
        If Not File.Exists(sLocal_Folder + FileReport + ".rpt") Then
            File.Delete(sLocal_Folder + FileReport + ".rpt")
        End If
        If Not File.Exists(sLocal_Folder + FileReport + ".vb") Then
            File.Delete(sLocal_Folder + FileReport + ".vb")
        End If

        '' Cek Setiap File, Berdasar Tgl
        client.DownloadFileAsync(New Uri(sServer_Folder + FileReport + ".rpt"), sLocal_Folder + FileReport + ".rpt")
        client_VB.DownloadFileAsync(New Uri(sServer_Folder + FileReport + ".vb"), sLocal_Folder + FileReport + ".vb")

    End Sub

    Public Sub CariID(ByVal sNamaParameter As String, ByRef sNomorBaru As String)
        Dim sUrut As String
        sSQL = "Select Isnull((Max(No)+1),99999) As Urut, Convert(Varchar(6), getdate(), 112) + '-' + Right('000' + Convert(Varchar(3),(Max(NO) + 1)),3) As NOBaru" & vbCrLf
        sSQL += "From Metiska_MKT.dbo.CounterTab " & vbCrLf
        sSQL += "Where Periode = Convert(Varchar(6), getdate(), 112)" & vbCrLf
        sSQL += "       And TIPE = '" & sNamaParameter & "'" & vbCrLf

        OpenRecordSetII(sSQL)

        If reader2.HasRows Then
            Do While reader2.Read
                If reader2("Urut") = "99999" Then
                    sNomorBaru = Now().Year.ToString + Now().Month.ToString + "-001"

                    sSQL = "Insert Into Metiska_MKT.dbo.CounterTab " & vbCrLf
                    sSQL += "(TIPE, PERIODE, NO)" & vbCrLf
                    sSQL += "Select TIPE = '" & sNamaParameter & "', Periode = Convert(Varchar(6), getdate(), 112), NO = 1" & vbCrLf

                    OpenExecute(sSQL)
                Else
                    sNomorBaru = reader2("NOBaru")
                    sUrut = reader2("Urut")
                End If
            Loop

            sSQL = "Update Metiska_MKT.dbo.CounterTab " & vbCrLf
            sSQL += "Set No=" & sUrut & "" & vbCrLf
            sSQL += "Where Periode = Convert(Varchar(6), getdate(), 112)" & vbCrLf
            sSQL += "       And TIPE = '" & sNamaParameter & "'" & vbCrLf
            OpenExecute(sSQL)
        Else
            sNomorBaru = Now().Year.ToString + Now().Month.ToString + "-001"

            sSQL = "Insert Into Metiska_MKT.dbo.CounterTab " & vbCrLf
            sSQL += "(TIPE, PERIODE, NO)" & vbCrLf
            sSQL += "Select TIPE = '" & sNamaParameter & "', Periode = Convert(Varchar(6), getdate(), 112), NO = 1" & vbCrLf

            OpenExecute(sSQL)
        End If
    End Sub
    Public Sub Send_Mail(ByVal sMail As String, ByVal sMail2 As String, ByVal sNoReq As String, ByVal sTipe As String, ByVal sNamaCabLogin As String)


        Dim sMsg As MailMessage = New MailMessage

        sMsg.From = New MailAddress("work.order@metiska.co.id")
        sMsg.To.Add(sMail)
        sMsg.To.Add(sMail2)
        sMsg.Body = "Dengan Hormat, " & vbCrLf & "" & vbCrLf & "Berikut Kami Infokan Bahwa Ada Pengajuan " & sTipe & " Dengan No Request : " & sNoReq & " Dari Area " & sNamaCabLogin & " . " & vbCrLf & "" & vbCrLf & "Mohon Agar di Proses Lebih Lanjut ." & vbCrLf & "" & vbCrLf & "Terima Kasih"
        '   sMsg.Attachments.Add(New Attachment(Save))
        'sMsg.IsBodyHtml = True
        sMsg.Subject = "Pengajuan " & sTipe & " Baru " + DateTime.Now.ToString() + " date"
        Dim sSMT As SmtpClient = New SmtpClient(" mail.metiska.co.id ")
        sSMT.Port = 25
        sSMT.Credentials = New NetworkCredential("work.order@metiska.co.id", "wo123456!")
        'sSMT.EnableSsl = True

        sSMT.Send(sMsg)

        sSMT.SendAsyncCancel()


    End Sub
    Public Sub Export_SQLtoExcel(ByVal sSQL As String)


        Dim cnt As New ADODB.Connection
        Dim rst As New ADODB.Recordset

        Dim xlApp As Object
        Dim xlWb As Object
        Dim xlWs As Object


        Dim recArray As Object

        Dim fldCount As Integer
        Dim recCount As Long
        Dim iCol As Integer
        Dim iRow As Integer


        ' Open connection to the database
        If sNamaPT = "PT. Metiska Farma" Then
            cnt.ConnectionString = "provider=sqloledb;server=" & Server & ";database=" & sPT & "_MKT;uid=" & UserId & ";password=" & Password & ""
            cnt.Open()
            'Else
            '    cnt.ConnectionString = "provider=sqloledb;server=" & Server & ";database=TeguhSindo_MKT;uid=" & UserId & ";password=" & Password & ""
            '    cnt.Open()
        End If



        ' Open recordset based on Orders table
        rst.Open(sSQL, cnt)

        ' Create an instance of Excel and add a workbook
        xlApp = CreateObject("Excel.Application")
        xlWb = xlApp.Workbooks.add
        xlWs = xlWb.Worksheets("Sheet1")

        ' Display Excel and give user control of Excel's lifetime
        xlApp.Visible = True
        xlApp.UserControl = True

        ' Copy field names to the first row of the worksheet
        fldCount = rst.Fields.Count
        For iCol = 1 To fldCount
            xlWs.Cells(1, iCol).Value = rst.Fields(iCol - 1).Name
        Next

        ' Check version of Excel
        If Val(Mid(xlApp.Version, 1, InStr(1, xlApp.Version, ".") - 1)) > 8 Then
            'EXCEL 2000,2002,2003, or 2007: Use CopyFromRecordset

            ' Copy the recordset to the worksheet, starting in cell A2
            xlWs.Cells(2, 1).CopyFromRecordset(rst)
            'Note: CopyFromRecordset will fail if the recordset
            'contains an OLE object field or array data such
            'as hierarchical recordsets

        Else
            'EXCEL 97 or earlier: Use GetRows then copy array to Excel

            ' Copy recordset to an array
            recArray = rst.GetRows
            'Note: GetRows returns a 0-based array where the first
            'dimension contains fields and the second dimension
            'contains records. We will transpose this array so that
            'the first dimension contains records, allowing the
            'data to appears properly when copied to Excel

            ' Determine number of records

            recCount = UBound(recArray, 2) + 1 '+ 1 since 0-based array


            ' Check the array for contents that are not valid when
            ' copying the array to an Excel worksheet
            For iCol = 0 To fldCount - 1
                For iRow = 0 To recCount - 1
                    ' Take care of Date fields
                    If IsDate(recArray(iCol, iRow)) Then
                        recArray(iCol, iRow) = Format(recArray(iCol, iRow))
                        ' Take care of OLE object fields or array fields
                    ElseIf IsArray(recArray(iCol, iRow)) Then
                        recArray(iCol, iRow) = "Array Field"
                    End If
                Next iRow 'next record
            Next iCol 'next field

            ' Transpose and Copy the array to the worksheet,
            ' starting in cell A2
            xlWs.Cells(2, 1).Resize(recCount, fldCount).Value = _
                TransposeDim(recArray)
        End If

        ' Auto-fit the column widths and row heights
        xlApp.Selection.CurrentRegion.Columns.AutoFit()
        xlApp.Selection.CurrentRegion.Rows.AutoFit()

        ' Close ADO objects
        rst.Close()
        cnt.Close()
        rst = Nothing
        cnt = Nothing

        ' Release Excel references
        xlWs = Nothing
        xlWb = Nothing
        xlApp = Nothing
    End Sub

    Function TransposeDim(ByVal v As Object) As Object
        ' Custom Function to Transpose a 0-based array (v)

        Dim X As Long, Y As Long, Xupper As Long, Yupper As Long
        Dim tempArray As Object

        Xupper = UBound(v, 2)
        Yupper = UBound(v, 1)

        ReDim tempArray(Xupper, Yupper)
        For X = 0 To Xupper
            For Y = 0 To Yupper
                tempArray(X, Y) = v(Y, X)
            Next Y
        Next X

        TransposeDim = tempArray
    End Function

End Module
