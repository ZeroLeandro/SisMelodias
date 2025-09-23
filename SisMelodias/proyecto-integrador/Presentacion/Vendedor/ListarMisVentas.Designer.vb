<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListarMisVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListarMisVentas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LVendeN = New System.Windows.Forms.Label()
        Me.LVendeA = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LFechaH = New System.Windows.Forms.Label()
        Me.LFechaD = New System.Windows.Forms.Label()
        Me.DTPHasta = New System.Windows.Forms.DateTimePicker()
        Me.DTPDesde = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DVGDetalleFac = New System.Windows.Forms.DataGridView()
        Me.DVentas = New System.Windows.Forms.DataGridView()
        Me.BDetalle = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.BTodos = New System.Windows.Forms.Button()
        CType(Me.DVGDetalleFac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(765, 157)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MIS VENTAS "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1294, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Vendedor/a"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.BackColor = System.Drawing.Color.Transparent
        Me.LDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDni.ForeColor = System.Drawing.Color.White
        Me.LDni.Location = New System.Drawing.Point(1202, 163)
        Me.LDni.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(81, 20)
        Me.LDni.TabIndex = 92
        Me.LDni.Text = "________"
        '
        'LVendeN
        '
        Me.LVendeN.AutoSize = True
        Me.LVendeN.BackColor = System.Drawing.Color.Transparent
        Me.LVendeN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVendeN.ForeColor = System.Drawing.Color.White
        Me.LVendeN.Location = New System.Drawing.Point(1404, 120)
        Me.LVendeN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LVendeN.Name = "LVendeN"
        Me.LVendeN.Size = New System.Drawing.Size(81, 20)
        Me.LVendeN.TabIndex = 93
        Me.LVendeN.Text = "________"
        '
        'LVendeA
        '
        Me.LVendeA.AutoSize = True
        Me.LVendeA.BackColor = System.Drawing.Color.Transparent
        Me.LVendeA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVendeA.ForeColor = System.Drawing.Color.White
        Me.LVendeA.Location = New System.Drawing.Point(1404, 188)
        Me.LVendeA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LVendeA.Name = "LVendeA"
        Me.LVendeA.Size = New System.Drawing.Size(81, 20)
        Me.LVendeA.TabIndex = 91
        Me.LVendeA.Text = "________"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(526, 249)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 88)
        Me.Button1.TabIndex = 95
        Me.Button1.Text = "Buscar Fecha "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LFechaH
        '
        Me.LFechaH.AutoSize = True
        Me.LFechaH.BackColor = System.Drawing.Color.Transparent
        Me.LFechaH.ForeColor = System.Drawing.Color.White
        Me.LFechaH.Location = New System.Drawing.Point(62, 326)
        Me.LFechaH.Name = "LFechaH"
        Me.LFechaH.Size = New System.Drawing.Size(101, 20)
        Me.LFechaH.TabIndex = 99
        Me.LFechaH.Text = "Fecha Hasta"
        '
        'LFechaD
        '
        Me.LFechaD.AutoSize = True
        Me.LFechaD.BackColor = System.Drawing.Color.Transparent
        Me.LFechaD.ForeColor = System.Drawing.Color.White
        Me.LFechaD.Location = New System.Drawing.Point(58, 260)
        Me.LFechaD.Name = "LFechaD"
        Me.LFechaD.Size = New System.Drawing.Size(105, 20)
        Me.LFechaD.TabIndex = 98
        Me.LFechaD.Text = "Fecha Desde"
        '
        'DTPHasta
        '
        Me.DTPHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPHasta.Location = New System.Drawing.Point(190, 317)
        Me.DTPHasta.Name = "DTPHasta"
        Me.DTPHasta.Size = New System.Drawing.Size(122, 26)
        Me.DTPHasta.TabIndex = 97
        '
        'DTPDesde
        '
        Me.DTPDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDesde.Location = New System.Drawing.Point(190, 260)
        Me.DTPDesde.Name = "DTPDesde"
        Me.DTPDesde.Size = New System.Drawing.Size(122, 26)
        Me.DTPDesde.TabIndex = 96
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1260, 805)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 49)
        Me.Button2.TabIndex = 103
        Me.Button2.Text = "Imprimir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DVGDetalleFac
        '
        Me.DVGDetalleFac.AllowUserToAddRows = False
        Me.DVGDetalleFac.AllowUserToDeleteRows = False
        Me.DVGDetalleFac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DVGDetalleFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVGDetalleFac.Location = New System.Drawing.Point(786, 403)
        Me.DVGDetalleFac.Name = "DVGDetalleFac"
        Me.DVGDetalleFac.ReadOnly = True
        Me.DVGDetalleFac.RowHeadersWidth = 51
        Me.DVGDetalleFac.RowTemplate.Height = 24
        Me.DVGDetalleFac.Size = New System.Drawing.Size(794, 383)
        Me.DVGDetalleFac.TabIndex = 102
        '
        'DVentas
        '
        Me.DVentas.AllowUserToOrderColumns = True
        Me.DVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVentas.Location = New System.Drawing.Point(-15, 403)
        Me.DVentas.Name = "DVentas"
        Me.DVentas.RowHeadersWidth = 51
        Me.DVentas.RowTemplate.Height = 24
        Me.DVentas.Size = New System.Drawing.Size(768, 383)
        Me.DVentas.TabIndex = 100
        '
        'BDetalle
        '
        Me.BDetalle.Location = New System.Drawing.Point(306, 805)
        Me.BDetalle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BDetalle.Name = "BDetalle"
        Me.BDetalle.Size = New System.Drawing.Size(138, 60)
        Me.BDetalle.TabIndex = 105
        Me.BDetalle.Text = "Ver detalle"
        Me.BDetalle.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'BTodos
        '
        Me.BTodos.Location = New System.Drawing.Point(884, 263)
        Me.BTodos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTodos.Name = "BTodos"
        Me.BTodos.Size = New System.Drawing.Size(138, 60)
        Me.BTodos.TabIndex = 106
        Me.BTodos.Text = "Todos"
        Me.BTodos.UseVisualStyleBackColor = True
        '
        'ListarMisVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1650, 1000)
        Me.Controls.Add(Me.BTodos)
        Me.Controls.Add(Me.BDetalle)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DVGDetalleFac)
        Me.Controls.Add(Me.DVentas)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LFechaH)
        Me.Controls.Add(Me.LFechaD)
        Me.Controls.Add(Me.DTPHasta)
        Me.Controls.Add(Me.DTPDesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LDni)
        Me.Controls.Add(Me.LVendeN)
        Me.Controls.Add(Me.LVendeA)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ListarMisVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListarVentas"
        CType(Me.DVGDetalleFac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LVendeN As Label
    Friend WithEvents LVendeA As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LFechaH As Label
    Friend WithEvents LFechaD As Label
    Friend WithEvents DTPHasta As DateTimePicker
    Friend WithEvents DTPDesde As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents DVGDetalleFac As DataGridView
    Friend WithEvents DVentas As DataGridView
    Friend WithEvents BDetalle As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents BTodos As Button
End Class
