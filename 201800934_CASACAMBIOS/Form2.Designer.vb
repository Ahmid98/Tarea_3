<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Gb_compra = New System.Windows.Forms.GroupBox()
        Me.Gb_venta = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sb_compra = New System.Windows.Forms.Label()
        Me.t_compra = New System.Windows.Forms.Label()
        Me.com_compra = New System.Windows.Forms.Label()
        Me.com_venta = New System.Windows.Forms.Label()
        Me.t_venta = New System.Windows.Forms.Label()
        Me.sb_venta = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Gb_compra.SuspendLayout()
        Me.Gb_venta.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gb_compra
        '
        Me.Gb_compra.Controls.Add(Me.com_compra)
        Me.Gb_compra.Controls.Add(Me.t_compra)
        Me.Gb_compra.Controls.Add(Me.sb_compra)
        Me.Gb_compra.Controls.Add(Me.Label3)
        Me.Gb_compra.Controls.Add(Me.Label2)
        Me.Gb_compra.Controls.Add(Me.Label1)
        Me.Gb_compra.Location = New System.Drawing.Point(13, 15)
        Me.Gb_compra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Gb_compra.Name = "Gb_compra"
        Me.Gb_compra.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Gb_compra.Size = New System.Drawing.Size(320, 314)
        Me.Gb_compra.TabIndex = 0
        Me.Gb_compra.TabStop = False
        Me.Gb_compra.Text = "Total compra:"
        '
        'Gb_venta
        '
        Me.Gb_venta.Controls.Add(Me.com_venta)
        Me.Gb_venta.Controls.Add(Me.t_venta)
        Me.Gb_venta.Controls.Add(Me.sb_venta)
        Me.Gb_venta.Controls.Add(Me.Label7)
        Me.Gb_venta.Controls.Add(Me.Label8)
        Me.Gb_venta.Controls.Add(Me.Label9)
        Me.Gb_venta.Location = New System.Drawing.Point(362, 15)
        Me.Gb_venta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Gb_venta.Name = "Gb_venta"
        Me.Gb_venta.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Gb_venta.Size = New System.Drawing.Size(320, 314)
        Me.Gb_venta.TabIndex = 1
        Me.Gb_venta.TabStop = False
        Me.Gb_venta.Text = "Total venta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sub total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Comision:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TOTAL:"
        '
        'sb_compra
        '
        Me.sb_compra.AutoSize = True
        Me.sb_compra.Location = New System.Drawing.Point(130, 66)
        Me.sb_compra.Name = "sb_compra"
        Me.sb_compra.Size = New System.Drawing.Size(21, 25)
        Me.sb_compra.TabIndex = 3
        Me.sb_compra.Text = "0"
        '
        't_compra
        '
        Me.t_compra.AutoSize = True
        Me.t_compra.Location = New System.Drawing.Point(130, 231)
        Me.t_compra.Name = "t_compra"
        Me.t_compra.Size = New System.Drawing.Size(21, 25)
        Me.t_compra.TabIndex = 4
        Me.t_compra.Text = "0"
        '
        'com_compra
        '
        Me.com_compra.AutoSize = True
        Me.com_compra.Location = New System.Drawing.Point(130, 138)
        Me.com_compra.Name = "com_compra"
        Me.com_compra.Size = New System.Drawing.Size(21, 25)
        Me.com_compra.TabIndex = 5
        Me.com_compra.Text = "0"
        '
        'com_venta
        '
        Me.com_venta.AutoSize = True
        Me.com_venta.Location = New System.Drawing.Point(142, 138)
        Me.com_venta.Name = "com_venta"
        Me.com_venta.Size = New System.Drawing.Size(21, 25)
        Me.com_venta.TabIndex = 11
        Me.com_venta.Text = "0"
        '
        't_venta
        '
        Me.t_venta.AutoSize = True
        Me.t_venta.Location = New System.Drawing.Point(142, 231)
        Me.t_venta.Name = "t_venta"
        Me.t_venta.Size = New System.Drawing.Size(21, 25)
        Me.t_venta.TabIndex = 10
        Me.t_venta.Text = "0"
        '
        'sb_venta
        '
        Me.sb_venta.AutoSize = True
        Me.sb_venta.Location = New System.Drawing.Point(142, 66)
        Me.sb_venta.Name = "sb_venta"
        Me.sb_venta.Size = New System.Drawing.Size(21, 25)
        Me.sb_venta.TabIndex = 9
        Me.sb_venta.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 25)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "TOTAL:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Comision:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 25)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Sub total:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.Font = New System.Drawing.Font("Pepper Sauce", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(283, 358)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 61)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "ACEPTAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(708, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Gb_venta)
        Me.Controls.Add(Me.Gb_compra)
        Me.Font = New System.Drawing.Font("Pepper Sauce", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form2"
        Me.Text = "SISTEMA CASA CAMBIO"
        Me.Gb_compra.ResumeLayout(False)
        Me.Gb_compra.PerformLayout()
        Me.Gb_venta.ResumeLayout(False)
        Me.Gb_venta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Gb_compra As GroupBox
    Friend WithEvents Gb_venta As GroupBox
    Friend WithEvents com_compra As Label
    Friend WithEvents t_compra As Label
    Friend WithEvents sb_compra As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents com_venta As Label
    Friend WithEvents t_venta As Label
    Friend WithEvents sb_venta As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
End Class
