Imports System.Data.OleDb
Imports Microsoft.Win32
Module ModMain
    'Company Variable
    Public XTension As String = ".MDB"
    Public imUser As UserLogin
    Public CompName As String = "Siddhi Softwares"
    Public CompAdd As String = ""
    Public CompPath As String
    Public FromDate As Date = #4/1/2006#
    Public ToDate As Date = #3/31/2007#
    Public DBName As String
    'Connection String
    Public StrSearchResult As String
    Public ConStr As String = ""
    Public FindQuery As String
    Public DBPath As String
    Public StrNavigation As Navigation
    Public strTabName As String
    Public Enum CallFrom
        AccountMaster
        ReceiptVoucher
        PaymentVoucher
        JournalVoucher
    End Enum
    Public Function FnAmount(ByRef e As KeyPressEventArgs, ByVal StrText As String)
        If Char.IsDigit(e.KeyChar) = False Then
            If e.KeyChar = Chr(8) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
            If e.KeyChar = "." Then
                If InStr(StrText, ".") > 0 Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If
            End If
        End If
    End Function
    Public Function FnNumber(ByRef e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) = False Then
            If e.KeyChar = Chr(8) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Function
    Public Function FnChar(ByRef e As KeyPressEventArgs, Optional ByVal WithSpace As Boolean = False)
        If Char.IsLetter(e.KeyChar) = False Then
            If WithSpace Then
                If e.KeyChar = " " Then
                    e.Handled = False
                    Exit Function
                End If
            End If
            If e.KeyChar = Chr(8) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Function
    Public Enum Operation
        None = 0
        Add = 1
        Edit = 2
        Search = 3
    End Enum
    Public Enum Navigation
        MoveFirst = 1
        MovePrevious = 2
        MoveNext = 3
        MoveLast = 4
    End Enum
    Public Enum Reports
        CashBook = 101
        DailyCashBook = 102
        JournalBook = 103

        TrialBalance = 201
        TrialBalance_Detail = 202
        TrialBalance_Namewise = 203

        TradingAc = 301
        ProfitNLoss = 302
        BalanceSheet = 303
        LedgerBook = 304

        GeneralLedgerMaster = 401
        GeneralLedgerMaster_Details = 402
        BalanceSheetHead_Master = 403

        LabelPrinting = 501

        AccountStatement = 601
        AccountStatementDetail = 602
    End Enum
    Public Function Vno(ByVal StrVtype As String) As String
        Dim con As New OleDbConnection(ConStr)
        Dim Cmd As New OleDbCommand
        Dim intX As Object
        Try
            Cmd.CommandText = "Vno"
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = con
            Dim P As New OleDbParameter
            P.ParameterName = "@BOOK"
            P.Direction = ParameterDirection.Input
            P.DbType = DbType.String
            P.Value = StrVtype
            Cmd.Parameters.Add(P)
            con.Open()
            intX = Cmd.ExecuteScalar
            Dim IntCount As Integer = CType(intX, Integer)
            con.Close()
            Vno = StrVtype & Format(IntCount, "0000")
        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            con.Close()
        End Try
    End Function
    Public Sub CreateDSN()
        Dim Reg As RegistryKey
        Reg = Registry.LocalMachine.OpenSubKey("SOFTWARE\\ODBC\\ODBC.INI\\PERACC", True)
        If Reg Is Nothing Then
            Reg = Registry.LocalMachine.OpenSubKey("SOFTWARE\\ODBC\\ODBC.INI\\ODBC Data Sources", True)
            If Not Reg Is Nothing Then
                Reg.SetValue("PERACC", "Microsoft Access Driver (*.mdb)")
            Else
                Reg = Registry.LocalMachine.CreateSubKey("SOFTWARE\\ODBC\\ODBC.INI\\ODBC Data Sources")
                Reg.SetValue("PERACC", "Microsoft Access Driver (*.mdb)")
            End If
            Reg = Registry.LocalMachine.CreateSubKey("SOFTWARE\\ODBC\\ODBC.INI\\PERACC")
            Reg.SetValue("DBQ", DBPath)
            Reg.SetValue("Driver", "C:\WINDOWS\system32\odbcjt32.dll")
            Reg.SetValue("DriverId", 25)
            Reg.SetValue("FIL", "MS Access;")
            Reg.SetValue("SafeTransactions", 0)
            Reg.SetValue("UID", "")
            Reg = Registry.LocalMachine.CreateSubKey("SOFTWARE\\ODBC\\ODBC.INI\\PERACC\\Engines")
            Reg = Registry.LocalMachine.CreateSubKey("SOFTWARE\\ODBC\\ODBC.INI\\PERACC\\Engines\\Jet")
            Reg.SetValue("ImplicitCommitSync", "")
            Reg.SetValue("MaxBufferSize", 2048)
            Reg.SetValue("PageTimeout", 5)
            Reg.SetValue("Threads", 3)
            Reg.SetValue("UserCommitSync", "Yes")
        Else
            Reg.SetValue("DBQ", DBPath)
        End If
    End Sub
End Module
