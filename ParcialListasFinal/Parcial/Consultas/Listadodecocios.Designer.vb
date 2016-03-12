<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listadodecocios
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
        Me.Grillasociosmes = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtfecha = New System.Windows.Forms.ComboBox()
        CType(Me.Grillasociosmes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione mes :"
        '
        'Grillasociosmes
        '
        Me.Grillasociosmes.AllowUserToAddRows = False
        Me.Grillasociosmes.AllowUserToDeleteRows = False
        Me.Grillasociosmes.AllowUserToOrderColumns = True
        Me.Grillasociosmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grillasociosmes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Grillasociosmes.Location = New System.Drawing.Point(1, 56)
        Me.Grillasociosmes.Name = "Grillasociosmes"
        Me.Grillasociosmes.ReadOnly = True
        Me.Grillasociosmes.Size = New System.Drawing.Size(337, 366)
        Me.Grillasociosmes.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Cedula"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Fecha Nacimiento"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'txtfecha
        '
        Me.txtfecha.FormattingEnabled = True
        Me.txtfecha.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.txtfecha.Location = New System.Drawing.Point(116, 15)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(121, 21)
        Me.txtfecha.TabIndex = 3
        '
        'Listadodecocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 421)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.Grillasociosmes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Listadodecocios"
        Me.Text = "Listadodecocios"
        CType(Me.Grillasociosmes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grillasociosmes As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtfecha As System.Windows.Forms.ComboBox
End Class
