<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_venta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_compra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_salir = New System.Windows.Forms.Button()
        Me.Btn_limpiar = New System.Windows.Forms.Button()
        Me.Btn_calcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbMoneda = New System.Windows.Forms.ComboBox()
        Me.Cb_venta = New System.Windows.Forms.CheckBox()
        Me.Cb_compra = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Teal
        Me.GroupBox1.Controls.Add(Me.Txt_venta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_compra)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Btn_salir)
        Me.GroupBox1.Controls.Add(Me.Btn_limpiar)
        Me.GroupBox1.Controls.Add(Me.Btn_calcular)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CbMoneda)
        Me.GroupBox1.Controls.Add(Me.Cb_venta)
        Me.GroupBox1.Controls.Add(Me.Cb_compra)
        Me.GroupBox1.Font = New System.Drawing.Font("Pepper Sauce", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 418)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestion a realizar:"
        '
        'Txt_venta
        '
        Me.Txt_venta.Location = New System.Drawing.Point(346, 125)
        Me.Txt_venta.Name = "Txt_venta"
        Me.Txt_venta.Size = New System.Drawing.Size(168, 33)
        Me.Txt_venta.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(234, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cantidad:"
        '
        'Txt_compra
        '
        Me.Txt_compra.Location = New System.Drawing.Point(346, 38)
        Me.Txt_compra.Name = "Txt_compra"
        Me.Txt_compra.Size = New System.Drawing.Size(168, 33)
        Me.Txt_compra.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cantidad:"
        '
        'Btn_salir
        '
        Me.Btn_salir.BackColor = System.Drawing.Color.Gray
        Me.Btn_salir.Location = New System.Drawing.Point(399, 353)
        Me.Btn_salir.Name = "Btn_salir"
        Me.Btn_salir.Size = New System.Drawing.Size(138, 48)
        Me.Btn_salir.TabIndex = 6
        Me.Btn_salir.Text = "SALIR"
        Me.Btn_salir.UseVisualStyleBackColor = False
        '
        'Btn_limpiar
        '
        Me.Btn_limpiar.BackColor = System.Drawing.Color.Gray
        Me.Btn_limpiar.Location = New System.Drawing.Point(207, 353)
        Me.Btn_limpiar.Name = "Btn_limpiar"
        Me.Btn_limpiar.Size = New System.Drawing.Size(138, 48)
        Me.Btn_limpiar.TabIndex = 5
        Me.Btn_limpiar.Text = "LIMPIAR"
        Me.Btn_limpiar.UseVisualStyleBackColor = False
        '
        'Btn_calcular
        '
        Me.Btn_calcular.BackColor = System.Drawing.Color.Gray
        Me.Btn_calcular.Location = New System.Drawing.Point(20, 353)
        Me.Btn_calcular.Name = "Btn_calcular"
        Me.Btn_calcular.Size = New System.Drawing.Size(138, 48)
        Me.Btn_calcular.TabIndex = 4
        Me.Btn_calcular.Text = "CALCULAR "
        Me.Btn_calcular.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Moneda:"
        '
        'CbMoneda
        '
        Me.CbMoneda.BackColor = System.Drawing.Color.Gray
        Me.CbMoneda.FormattingEnabled = True
        Me.CbMoneda.Location = New System.Drawing.Point(216, 228)
        Me.CbMoneda.Name = "CbMoneda"
        Me.CbMoneda.Size = New System.Drawing.Size(148, 33)
        Me.CbMoneda.TabIndex = 2
        '
        'Cb_venta
        '
        Me.Cb_venta.AutoSize = True
        Me.Cb_venta.Location = New System.Drawing.Point(20, 129)
        Me.Cb_venta.Name = "Cb_venta"
        Me.Cb_venta.Size = New System.Drawing.Size(89, 29)
        Me.Cb_venta.TabIndex = 1
        Me.Cb_venta.Text = "Venta"
        Me.Cb_venta.UseVisualStyleBackColor = True
        '
        'Cb_compra
        '
        Me.Cb_compra.AutoSize = True
        Me.Cb_compra.Location = New System.Drawing.Point(20, 45)
        Me.Cb_compra.Name = "Cb_compra"
        Me.Cb_compra.Size = New System.Drawing.Size(103, 29)
        Me.Cb_compra.TabIndex = 0
        Me.Cb_compra.Text = "Compra"
        Me.Cb_compra.UseMnemonic = False
        Me.Cb_compra.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "SISTEMA CASA DE CAMBIOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CbMoneda As ComboBox
    Friend WithEvents Cb_venta As CheckBox
    Friend WithEvents Cb_compra As CheckBox
    Friend WithEvents Btn_salir As Button
    Friend WithEvents Btn_limpiar As Button
    Friend WithEvents Btn_calcular As Button
    Friend WithEvents Txt_venta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_compra As TextBox
    Friend WithEvents Label2 As Label
End Class
