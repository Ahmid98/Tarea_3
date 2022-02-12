Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CbMoneda.Items.Add("Dolar")
        CbMoneda.Items.Add("Pesos")
        CbMoneda.Items.Add("Euros")
        CbMoneda.Items.Add("Colones")
        Txt_compra.Text = 0
        Txt_venta.Text = 0

    End Sub

    Private Sub Cb_compra_CheckedChanged(sender As Object, e As EventArgs) Handles Cb_compra.CheckedChanged
        If Cb_compra.Checked = True Then
            Txt_compra.Enabled = True
        Else
            Txt_compra.Enabled = False
        End If
    End Sub

    Private Sub Cb_venta_CheckedChanged(sender As Object, e As EventArgs) Handles Cb_venta.CheckedChanged
        If Cb_venta.Checked = True Then
            Txt_venta.Enabled = True
        Else
            Txt_venta.Enabled = False
        End If
    End Sub

    Private Sub Btn_calcular_Click(sender As Object, e As EventArgs) Handles Btn_calcular.Click
        Dim t_compra As Double
        Dim t_venta As Double

        If Cb_venta.Checked = False And Cb_compra.Checked = False Then
            MsgBox("Debe seleccionar Venta o Compra para poder continuar..")
        End If

        If CbMoneda.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar moneda para poder continuar..")
        End If

        If Cb_venta.Checked = True Then
            If Txt_venta.Text = "" Then
                MsgBox("Debes ingresar la cantidad a vender..")
            End If
        Else
            Form2.Gb_venta.Visible = False
        End If

        If Cb_compra.Checked = True Then
            If Txt_compra.Text = "" Then
                MsgBox("Debes ingresar la cantidad a comprar..")
            End If
        Else
            Form2.Gb_compra.Visible = False
        End If

        t_compra = CalculoCompra(Txt_compra.Text, CbMoneda.SelectedIndex)
        t_venta = CalculoVenta(Txt_venta.Text, CbMoneda.SelectedIndex)

        Form2.sb_compra.Text = System.Math.Round(t_compra, 2).ToString
        Form2.com_compra.Text = System.Math.Round(t_compra * 0.025, 2).ToString
        Form2.t_compra.Text = System.Math.Round(t_compra + t_compra * 0.025, 2).ToString

        Form2.sb_venta.Text = System.Math.Round(t_venta, 2).ToString
        Form2.com_venta.Text = System.Math.Round(t_venta * 0.025, 2).ToString
        Form2.t_venta.Text = System.Math.Round(t_venta + t_venta * 0.025, 2).ToString

        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Txt_compra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_compra.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Txt_venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_venta.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Btn_limpiar_Click(sender As Object, e As EventArgs) Handles Btn_limpiar.Click
        CalculoCambio.Limpiar()
    End Sub

    Private Sub Btn_salir_Click(sender As Object, e As EventArgs) Handles Btn_salir.Click
        MsgBox("Desea salir del sistema...")
    End Sub
End Class
