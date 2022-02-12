Module CalculoCambio
    Const C_dolar = 7.69
    Const C_pesos = 0.38
    Const C_euros = 8.79
    Const C_colones = 0.012

    Public Function CalculoCompra(cantidad As Double, moneda As Integer) As Double
        Dim cambio As Double
        Dim total As Double

        If Form1.Cb_compra.Checked = True Then
            If moneda = "0" Then
                cambio = cantidad / C_dolar
            ElseIf moneda = "1" Then
                cambio = cantidad / C_pesos
            ElseIf moneda = "2" Then
                cambio = cantidad / C_euros
            ElseIf moneda = "3" Then
                cambio = cantidad / C_colones
            End If
        Else
            cambio = 0
        End If

        Return cambio
    End Function

    Public Function CalculoVenta(cantidad As Double, moneda As Integer) As Double
        Dim cambio As Double
        Dim total As Double

        If Form1.Cb_venta.Checked = True Then
            If moneda = "0" Then
                cambio = cantidad * C_dolar
            ElseIf moneda = "1" Then
                cambio = cantidad * C_pesos
            ElseIf moneda = "2" Then
                cambio = cantidad * C_euros
            ElseIf moneda = "3" Then
                cambio = cantidad * C_colones
            End If
        Else
            cambio = 0
        End If



        Return cambio
    End Function

    Public Sub Limpiar()
        Form1.CbMoneda.SelectedIndex = -1
        Form1.Cb_compra.Checked = False
        Form1.Cb_venta.Checked = False
        Form1.Txt_compra.Text = 0
        Form1.Txt_venta.Text = 0

    End Sub
End Module
