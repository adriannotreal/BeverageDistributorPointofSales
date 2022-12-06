Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class frmDataAnalysis
    Private Sub frmDataAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCategoryPieChart()
        loadMonthlySalesLineGraph()
        loadPopularProductsBarGraph()
        loadCustomerSalesDistributionBarGraph()
        loadDailySalesLineGraph()

    End Sub

    Private Sub loadCategoryPieChart()
        Try
            With Chart1
                .Series.Clear()
                .Series.Add("Series1")
            End With
            Dim datatable As New DataTable
            openConn()

            com = New MySqlCommand
            com.Connection = conn
            com.CommandText = "SELECT tblproducts.category as CATEGORY, SUM(tblproducts.price*tblorders.quantity) AS TOTAL_SALES FROM tblproducts INNER JOIN tblorders ON tblproducts.product_id = tblorders.product_id GROUP BY tblproducts.category"
            adapter.SelectCommand = com
            Dim ds As New DataSet

            adapter.Fill(ds, "Sales by Category")
            Chart1.DataSource = ds.Tables("Sales by Category")
            Dim series1 As Series = Chart1.Series("Series1")
            series1.ChartType = SeriesChartType.Pie
            series1.Name = "Sales by Category"

            With Chart1
                .Series(series1.Name).XValueMember = "CATEGORY"
                .Series(series1.Name).YValueMembers = "TOTAL_SALES"
                .Series(0).LabelFormat = "{#,##0}"
                .Series(0).IsValueShownAsLabel = True
                .Series(0).Label = "#PERCENT{P2}"
                .Series(0).LegendText = "#VALX Beverage"

                .ChartAreas(0).Area3DStyle.Enable3D = True

                .Legends(0).LegendStyle = LegendStyle.Column
                .Legends(0).Docking = Docking.Right
                .Legends(0).Alignment = System.Drawing.StringAlignment.Center
                .Legends(0).Font = New Font(Font.FontFamily, 12)
            End With

            Dim t As Title = Chart1.Titles.Add("Percentage of Sales by Category")
            t.Alignment = ContentAlignment.MiddleLeft
            t.Font = New Font("Segoe UI", 15, FontStyle.Bold)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub loadMonthlySalesLineGraph()
        Try
            With Chart2
                .Series.Clear()
                .Series.Add("Series2")
            End With
            Dim datatable As New DataTable
            openConn()

            com = New MySqlCommand
            com.Connection = conn
            com.CommandText = "SELECT MONTHNAME(tbltransaction.date_time) as MONTH, SUM(tblproducts.price*tblorders.quantity) AS TOTAL_SALES FROM (tblproducts INNER JOIN tblorders ON tblproducts.product_id = tblorders.product_id) INNER JOIN tbltransaction ON tblorders.transaction_id = tbltransaction.transaction_id GROUP BY MONTH(tbltransaction.date_time)"
            adapter.SelectCommand = com
            Dim ds As New DataSet

            adapter.Fill(ds, "Monthly Sales")
            Chart2.DataSource = ds.Tables("Monthly Sales")
            Dim series2 As Series = Chart2.Series("Series2")
            series2.ChartType = SeriesChartType.Line
            series2.Name = "Monthly Sales"

            With Chart2
                .Series(series2.Name).XValueMember = "MONTH"
                .Series(series2.Name).YValueMembers = "TOTAL_SALES"
                .Series(0).LabelFormat = "{#,##0}"
                .Series(0).BorderWidth = 3
                .Series(0).BorderColor = System.Drawing.Color.FromArgb(12, 12, 12)
                .Series(0).IsValueShownAsLabel = True

                .Legends(0).LegendStyle = LegendStyle.Column
                .Legends(0).Docking = Docking.Right
                .Legends(0).Alignment = System.Drawing.StringAlignment.Center
                .Legends(0).Font = New Font(Font.FontFamily, 12)
            End With

            Dim t As Title = Chart2.Titles.Add("Monthly Sales Performance")
            t.Alignment = ContentAlignment.MiddleLeft
            t.Font = New Font("Segoe UI", 15, FontStyle.Bold)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub loadDailySalesLineGraph()
        Try
            With Chart5
                .Series.Clear()
                .Series.Add("Series5")
            End With
            Dim datatable As New DataTable
            openConn()

            com = New MySqlCommand
            com.Connection = conn
            com.CommandText = "SELECT DATE(date_time) as DAY, SUM(totaldue) AS TOTAL_SALES FROM tbltransaction GROUP BY DATE(date_time)"
            adapter.SelectCommand = com
            Dim ds As New DataSet

            adapter.Fill(ds, "Daily Sales")
            Chart5.DataSource = ds.Tables("Daily Sales")
            Dim series5 As Series = Chart5.Series("Series5")
            series5.ChartType = SeriesChartType.Line
            series5.Name = "Daily Sales"

            With Chart5
                .Series(series5.Name).XValueMember = "DAY"
                .Series(series5.Name).YValueMembers = "TOTAL_SALES"
                .Series(0).LabelFormat = "{#,##0}"
                .Series(0).BorderWidth = 3
                .Series(0).BorderColor = System.Drawing.Color.FromArgb(12, 12, 12)
                .Series(0).IsValueShownAsLabel = True
                .Legends(0).LegendStyle = LegendStyle.Column
                .Legends(0).Docking = Docking.Right
                .Legends(0).Alignment = System.Drawing.StringAlignment.Center
                .Legends(0).Font = New Font(Font.FontFamily, 12)
            End With

            Dim t As Title = Chart5.Titles.Add("Daily Sales Performance")
            t.Alignment = ContentAlignment.MiddleLeft
            t.Font = New Font("Segoe UI", 15, FontStyle.Bold)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub loadPopularProductsBarGraph()
        Try
            With Chart3
                .Series.Clear()
                .Series.Add("Series3")
            End With
            Dim datatable As New DataTable
            openConn()

            com = New MySqlCommand
            com.Connection = conn
            com.CommandText = "SELECT CONCAT(tblproducts.product_name,' ', tblproducts.size, 'ml ') AS PRODUCT_NAME, SUM(tblorders.quantity) AS QUANTITY FROM tblproducts INNER JOIN tblorders ON tblproducts.product_id = tblorders.product_id GROUP BY tblorders.product_id ORDER BY SUM(tblorders.quantity)"
            adapter.SelectCommand = com
            Dim ds As New DataSet

            adapter.Fill(ds, "Product Popularity")
            Chart3.DataSource = ds.Tables("Product Popularity")
            Dim series3 As Series = Chart3.Series("Series3")
            series3.ChartType = SeriesChartType.Bar
            series3.Name = "Product Popularity"

            With Chart3
                .Series(series3.Name).XValueMember = "PRODUCT_NAME"
                .Series(series3.Name).YValueMembers = "QUANTITY"
                .Series(0).LabelFormat = "{#,##0}"

                .Legends(0).LegendStyle = LegendStyle.Column
                .Legends(0).Docking = Docking.Right
                .Legends(0).Alignment = System.Drawing.StringAlignment.Center
                .Legends(0).Font = New Font(Font.FontFamily, 12)
            End With

            Dim t As Title = Chart3.Titles.Add("Product Popularity")
            t.Alignment = ContentAlignment.MiddleLeft
            t.Font = New Font("Segoe UI", 15, FontStyle.Bold)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    Private Sub loadCustomerSalesDistributionBarGraph()
        Try
            With Chart4
                .Series.Clear()
                .Series.Add("Series4")
            End With
            Dim datatable As New DataTable
            openConn()

            com = New MySqlCommand
            com.Connection = conn
            com.CommandText = "SELECT CONCAT(tblcustomer.first_name,' ', tblcustomer.last_name) AS CUSTOMER_NAME, SUM(tblproducts.price*tblorders.quantity) AS SALES FROM (tblproducts INNER JOIN tblorders ON tblproducts.product_id = tblorders.product_id) INNER JOIN (tbltransaction INNER JOIN tblcustomer ON tbltransaction.customer_id = tblcustomer.customer_id) ON tblorders.transaction_id = tbltransaction.transaction_id GROUP BY tbltransaction.customer_id ORDER BY SUM(tblproducts.price*tblorders.quantity) DESC"
            adapter.SelectCommand = com
            Dim ds As New DataSet

            adapter.Fill(ds, "Sales per Customer")
            Chart4.DataSource = ds.Tables("Sales per Customer")
            Dim series4 As Series = Chart4.Series("Series4")
            series4.ChartType = SeriesChartType.Column
            series4.Name = "Sales per Customer"

            With Chart4
                .Series(series4.Name).XValueMember = "CUSTOMER_NAME"
                .Series(series4.Name).YValueMembers = "SALES"
                .Series(0).LabelFormat = "{#,##0}"
                .Series(0).IsValueShownAsLabel = True

                .Series(0).Label = "#PERCENT{P2}"

                .Legends(0).LegendStyle = LegendStyle.Column
                .Legends(0).Docking = Docking.Right
                .Legends(0).Alignment = System.Drawing.StringAlignment.Center
                .Legends(0).Font = New Font(Font.FontFamily, 12)
            End With

            Dim t As Title = Chart4.Titles.Add("Sales per Customer")
            t.Alignment = ContentAlignment.MiddleLeft
            t.Font = New Font("Segoe UI", 15, FontStyle.Bold)
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    'Private Sub loadCustomerSalesStackedColumn()
    '    Dim dt As New DataTable
    '    openConn()
    '    com = New MySqlCommand
    '    com.Connection = conn
    '    com.CommandText = "SELECT CONCAT(tblcustomer.first_name,' ', tblcustomer.last_name) AS CUSTOMER_NAME, SUM(tblproducts.price*tblorders.quantity) AS SALES, tblproducts.category as CATEGORY FROM (tblproducts INNER JOIN tblorders ON tblproducts.product_id = tblorders.product_id) INNER JOIN (tbltransaction INNER JOIN tblcustomer ON tbltransaction.customer_id = tblcustomer.customer_id) ON tblorders.transaction_id = tbltransaction.transaction_id GROUP BY tblproducts.category, tbltransaction.customer_id"
    '    adapter.SelectCommand = com
    '    adapter.Fill(dt)

    '    Dim categories As List(Of String) = (From p In dt.AsEnumerable()
    '                                         Select p.Field(Of String)("CATEGORY")).Distinct().ToList()

    '    'Remove the Default Series.
    '    If Chart4.Series.Count() = 1 Then
    '        Chart4.Series.Remove(Chart4.Series(0))
    '    End If

    '    'Loop through the Countries.
    '    For Each category As String In categories

    '        'Get the Year for each Country.
    '        Dim x As String() = (From p In dt.AsEnumerable()
    '                             Where p.Field(Of String)("CATEGORY") = category
    '                             Order By p.Field(Of String)("CUSTOMER_NAME")
    '                             Select p.Field(Of String)("CUSTOMER_NAME")).ToArray()

    '        'Get the Total of Orders for each Country.
    '        Dim y As Decimal() = (From p In dt.AsEnumerable()
    '                              Where p.Field(Of String)("CATEGORY") = category
    '                              Order By p.Field(Of String)("CUSTOMER_NAME")
    '                              Select p.Field(Of Decimal)("SALES")).ToArray()

    '        'Add Series to the Chart.
    '        Chart4.Series.Add(New Series(category))
    '        Chart4.Series(category).IsValueShownAsLabel = True
    '        Chart4.Series(category).ChartType = SeriesChartType.StackedColumn
    '        Chart4.Series(category).Points.DataBindXY(x, y)
    '    Next

    '    Chart4.Legends(0).Enabled = True

    '    conn.Close()
    'End Sub

    Private Sub pbxExitDA_Click(sender As Object, e As EventArgs) Handles pbxExitDA.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Chart5.Printing.PrintPreview()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Chart2.Printing.PrintPreview()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Chart3.Printing.PrintPreview()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Chart1.Printing.PrintPreview()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Chart4.Printing.PrintPreview()
    End Sub
End Class