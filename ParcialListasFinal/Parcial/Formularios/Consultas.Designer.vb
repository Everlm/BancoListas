<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultas
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(12, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(283, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Listado de socios  que cumplen año en mes especifico"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 38)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Listado de Ingresos y Egresos"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.Location = New System.Drawing.Point(12, 56)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 40)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Fecha rango"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.Location = New System.Drawing.Point(12, 102)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 40)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Lista general de socios"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button5.Location = New System.Drawing.Point(12, 191)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(230, 37)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Lista de movimientos por registro de fecha"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button6.Location = New System.Drawing.Point(12, 234)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(140, 37)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Movimientos por valor"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button7.Location = New System.Drawing.Point(12, 283)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(140, 37)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Movimientos por cedula"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button8.Location = New System.Drawing.Point(12, 326)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(140, 37)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Movimientos por socio"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button9.Location = New System.Drawing.Point(241, 481)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(54, 30)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Salir"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button10.Location = New System.Drawing.Point(12, 369)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(165, 31)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "Movimientos Por concepto"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(301, 523)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Consultas"
        Me.Text = "Consultas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
End Class
