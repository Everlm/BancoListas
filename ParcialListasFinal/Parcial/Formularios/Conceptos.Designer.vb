<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conceptos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtconsecutivo = New System.Windows.Forms.TextBox()
        Me.txtconcep = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Grillaconceptos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Grillaconceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Consecutivo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion"
        '
        'txtconsecutivo
        '
        Me.txtconsecutivo.Location = New System.Drawing.Point(168, 51)
        Me.txtconsecutivo.Name = "txtconsecutivo"
        Me.txtconsecutivo.ReadOnly = True
        Me.txtconsecutivo.Size = New System.Drawing.Size(32, 20)
        Me.txtconsecutivo.TabIndex = 2
        '
        'txtconcep
        '
        Me.txtconcep.Location = New System.Drawing.Point(168, 88)
        Me.txtconcep.Name = "txtconcep"
        Me.txtconcep.Size = New System.Drawing.Size(112, 20)
        Me.txtconcep.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(429, 286)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabPage1.Controls.Add(Me.btnsalir)
        Me.TabPage1.Controls.Add(Me.btnmodificar)
        Me.TabPage1.Controls.Add(Me.btnbuscar)
        Me.TabPage1.Controls.Add(Me.btneliminar)
        Me.TabPage1.Controls.Add(Me.btnguardar)
        Me.TabPage1.Controls.Add(Me.txtconsecutivo)
        Me.TabPage1.Controls.Add(Me.txtconcep)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(421, 260)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar"
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnsalir.Location = New System.Drawing.Point(343, 219)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(72, 27)
        Me.btnsalir.TabIndex = 8
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnmodificar.Location = New System.Drawing.Point(260, 219)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(77, 27)
        Me.btnmodificar.TabIndex = 7
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnbuscar.Location = New System.Drawing.Point(179, 219)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(71, 28)
        Me.btnbuscar.TabIndex = 6
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btneliminar.Location = New System.Drawing.Point(98, 219)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 28)
        Me.btneliminar.TabIndex = 5
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnguardar.Location = New System.Drawing.Point(17, 219)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 28)
        Me.btnguardar.TabIndex = 4
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Grillaconceptos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(421, 260)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Registrados"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Grillaconceptos
        '
        Me.Grillaconceptos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grillaconceptos.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.Grillaconceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grillaconceptos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.Grillaconceptos.Location = New System.Drawing.Point(0, 0)
        Me.Grillaconceptos.Name = "Grillaconceptos"
        Me.Grillaconceptos.Size = New System.Drawing.Size(421, 260)
        Me.Grillaconceptos.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo consecutivo"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Descripcion"
        Me.Column2.Name = "Column2"
        '
        'Conceptos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 288)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Conceptos"
        Me.Text = "Conceptos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Grillaconceptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtconsecutivo As System.Windows.Forms.TextBox
    Friend WithEvents txtconcep As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Grillaconceptos As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnsalir As System.Windows.Forms.Button
End Class
