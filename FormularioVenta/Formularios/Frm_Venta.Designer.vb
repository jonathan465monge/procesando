﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Venta
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtestado = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CodigoDetalleVenta = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.agregarListado_btn = New System.Windows.Forms.Button()
        Me.pb_ProdImg = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ventaNew_btn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_preciototal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.buscarProd_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nombreProd = New System.Windows.Forms.TextBox()
        Me.txt_precioUnidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_prodId = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dataFact = New System.Windows.Forms.DataGridView()
        Me.ProductoID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.labelVenta = New System.Windows.Forms.Label()
        Me.ventadetalle_btn = New System.Windows.Forms.Button()
        Me.panelCobrar = New System.Windows.Forms.Panel()
        Me.btnConfirmarVenta = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCambio = New System.Windows.Forms.TextBox()
        Me.txtPagoCliente = New System.Windows.Forms.TextBox()
        Me.txtTotalVenta = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.eliminardeLista_btn = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pb_ProdImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dataFact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.panelCobrar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.txtestado)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtStock)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.CodigoDetalleVenta)
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.btnAplicar)
        Me.GroupBox2.Controls.Add(Me.txtCantidad)
        Me.GroupBox2.Controls.Add(Me.agregarListado_btn)
        Me.GroupBox2.Controls.Add(Me.pb_ProdImg)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.ventaNew_btn)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_preciototal)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.buscarProd_btn)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_nombreProd)
        Me.GroupBox2.Controls.Add(Me.txt_precioUnidad)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_prodId)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(287, 519)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'txtestado
        '
        Me.txtestado.Location = New System.Drawing.Point(59, 110)
        Me.txtestado.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.ReadOnly = True
        Me.txtestado.Size = New System.Drawing.Size(77, 20)
        Me.txtestado.TabIndex = 34
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(5, 109)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Estado:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(116, 274)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(162, 83)
        Me.txtDescripcion.TabIndex = 32
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(139, 257)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 13)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Descripción:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(139, 233)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Existencias:"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(205, 230)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(74, 20)
        Me.txtStock.TabIndex = 29
        Me.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(11, 467)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(267, 42)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Cancelar venta"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(139, 113)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Codigo Detalle:"
        Me.Label10.Visible = False
        '
        'CodigoDetalleVenta
        '
        Me.CodigoDetalleVenta.Location = New System.Drawing.Point(222, 110)
        Me.CodigoDetalleVenta.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CodigoDetalleVenta.Name = "CodigoDetalleVenta"
        Me.CodigoDetalleVenta.ReadOnly = True
        Me.CodigoDetalleVenta.Size = New System.Drawing.Size(57, 20)
        Me.CodigoDetalleVenta.TabIndex = 26
        Me.CodigoDetalleVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CodigoDetalleVenta.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Red
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelar.Location = New System.Drawing.Point(160, 376)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(118, 27)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        Me.btnCancelar.Visible = False
        '
        'btnAplicar
        '
        Me.btnAplicar.BackColor = System.Drawing.Color.DimGray
        Me.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAplicar.Location = New System.Drawing.Point(9, 376)
        Me.btnAplicar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(125, 27)
        Me.btnAplicar.TabIndex = 24
        Me.btnAplicar.Text = "Aplicar cambios"
        Me.btnAplicar.UseVisualStyleBackColor = False
        Me.btnAplicar.Visible = False
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(59, 196)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(77, 20)
        Me.txtCantidad.TabIndex = 23
        Me.txtCantidad.Text = "0"
        '
        'agregarListado_btn
        '
        Me.agregarListado_btn.BackColor = System.Drawing.Color.Blue
        Me.agregarListado_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.agregarListado_btn.ForeColor = System.Drawing.SystemColors.Control
        Me.agregarListado_btn.Location = New System.Drawing.Point(11, 415)
        Me.agregarListado_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.agregarListado_btn.Name = "agregarListado_btn"
        Me.agregarListado_btn.Size = New System.Drawing.Size(267, 42)
        Me.agregarListado_btn.TabIndex = 10
        Me.agregarListado_btn.Text = "Agregar al Listado"
        Me.agregarListado_btn.UseVisualStyleBackColor = False
        '
        'pb_ProdImg
        '
        Me.pb_ProdImg.ErrorImage = Nothing
        Me.pb_ProdImg.InitialImage = Nothing
        Me.pb_ProdImg.Location = New System.Drawing.Point(8, 263)
        Me.pb_ProdImg.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pb_ProdImg.Name = "pb_ProdImg"
        Me.pb_ProdImg.Size = New System.Drawing.Size(101, 98)
        Me.pb_ProdImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_ProdImg.TabIndex = 22
        Me.pb_ProdImg.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 233)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Imagen del Producto:"
        '
        'ventaNew_btn
        '
        Me.ventaNew_btn.BackColor = System.Drawing.Color.DimGray
        Me.ventaNew_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ventaNew_btn.ForeColor = System.Drawing.SystemColors.Control
        Me.ventaNew_btn.Location = New System.Drawing.Point(9, 49)
        Me.ventaNew_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ventaNew_btn.Name = "ventaNew_btn"
        Me.ventaNew_btn.Size = New System.Drawing.Size(269, 42)
        Me.ventaNew_btn.TabIndex = 10
        Me.ventaNew_btn.Text = "Nueva venta"
        Me.ventaNew_btn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(200, 16)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 198)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Precio Total:"
        '
        'txt_preciototal
        '
        Me.txt_preciototal.Location = New System.Drawing.Point(209, 196)
        Me.txt_preciototal.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_preciototal.Name = "txt_preciototal"
        Me.txt_preciototal.ReadOnly = True
        Me.txt_preciototal.Size = New System.Drawing.Size(69, 20)
        Me.txt_preciototal.TabIndex = 19
        Me.txt_preciototal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(157, 19)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Fecha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 136)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Producto:"
        '
        'buscarProd_btn
        '
        Me.buscarProd_btn.Location = New System.Drawing.Point(235, 133)
        Me.buscarProd_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.buscarProd_btn.Name = "buscarProd_btn"
        Me.buscarProd_btn.Size = New System.Drawing.Size(43, 23)
        Me.buscarProd_btn.TabIndex = 17
        Me.buscarProd_btn.Text = "..."
        Me.buscarProd_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.buscarProd_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 198)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad:"
        '
        'txt_nombreProd
        '
        Me.txt_nombreProd.Location = New System.Drawing.Point(59, 136)
        Me.txt_nombreProd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_nombreProd.Name = "txt_nombreProd"
        Me.txt_nombreProd.ReadOnly = True
        Me.txt_nombreProd.Size = New System.Drawing.Size(174, 20)
        Me.txt_nombreProd.TabIndex = 16
        '
        'txt_precioUnidad
        '
        Me.txt_precioUnidad.Location = New System.Drawing.Point(222, 164)
        Me.txt_precioUnidad.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_precioUnidad.Name = "txt_precioUnidad"
        Me.txt_precioUnidad.ReadOnly = True
        Me.txt_precioUnidad.Size = New System.Drawing.Size(57, 20)
        Me.txt_precioUnidad.TabIndex = 4
        Me.txt_precioUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 166)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Codigo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Precio Unitario:"
        '
        'txt_prodId
        '
        Me.txt_prodId.Location = New System.Drawing.Point(59, 164)
        Me.txt_prodId.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_prodId.Name = "txt_prodId"
        Me.txt_prodId.ReadOnly = True
        Me.txt_prodId.Size = New System.Drawing.Size(77, 20)
        Me.txt_prodId.TabIndex = 6
        Me.txt_prodId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dataFact)
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(287, 0)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(692, 519)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lista de Productos"
        '
        'dataFact
        '
        Me.dataFact.AllowUserToAddRows = False
        Me.dataFact.AllowUserToDeleteRows = False
        Me.dataFact.BackgroundColor = System.Drawing.SystemColors.Highlight
        Me.dataFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataFact.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductoID, Me.NombreProducto, Me.Stock, Me.PrecioUnidad, Me.Cantidad, Me.Total})
        Me.dataFact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataFact.Location = New System.Drawing.Point(2, 62)
        Me.dataFact.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dataFact.Name = "dataFact"
        Me.dataFact.ReadOnly = True
        Me.dataFact.RowHeadersWidth = 62
        Me.dataFact.RowTemplate.Height = 24
        Me.dataFact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataFact.Size = New System.Drawing.Size(688, 375)
        Me.dataFact.TabIndex = 28
        '
        'ProductoID
        '
        Me.ProductoID.HeaderText = "ProductoID"
        Me.ProductoID.MinimumWidth = 8
        Me.ProductoID.Name = "ProductoID"
        Me.ProductoID.ReadOnly = True
        Me.ProductoID.Width = 150
        '
        'NombreProducto
        '
        Me.NombreProducto.HeaderText = "NombreProducto"
        Me.NombreProducto.MinimumWidth = 8
        Me.NombreProducto.Name = "NombreProducto"
        Me.NombreProducto.ReadOnly = True
        Me.NombreProducto.Width = 150
        '
        'Stock
        '
        Me.Stock.HeaderText = "Stock"
        Me.Stock.MinimumWidth = 8
        Me.Stock.Name = "Stock"
        Me.Stock.ReadOnly = True
        Me.Stock.Width = 150
        '
        'PrecioUnidad
        '
        Me.PrecioUnidad.HeaderText = "PrecioUnidad"
        Me.PrecioUnidad.MinimumWidth = 8
        Me.PrecioUnidad.Name = "PrecioUnidad"
        Me.PrecioUnidad.ReadOnly = True
        Me.PrecioUnidad.Width = 150
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 8
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 150
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 8
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 150
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.panelCobrar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(2, 437)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(688, 79)
        Me.Panel2.TabIndex = 27
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Controls.Add(Me.labelVenta)
        Me.Panel5.Controls.Add(Me.ventadetalle_btn)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(284, 79)
        Me.Panel5.TabIndex = 29
        '
        'labelVenta
        '
        Me.labelVenta.AutoSize = True
        Me.labelVenta.Location = New System.Drawing.Point(185, 3)
        Me.labelVenta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelVenta.Name = "labelVenta"
        Me.labelVenta.Size = New System.Drawing.Size(13, 13)
        Me.labelVenta.TabIndex = 9
        Me.labelVenta.Text = "0"
        Me.labelVenta.Visible = False
        '
        'ventadetalle_btn
        '
        Me.ventadetalle_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ventadetalle_btn.BackColor = System.Drawing.Color.Blue
        Me.ventadetalle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ventadetalle_btn.ForeColor = System.Drawing.SystemColors.Control
        Me.ventadetalle_btn.Location = New System.Drawing.Point(65, 22)
        Me.ventadetalle_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ventadetalle_btn.Name = "ventadetalle_btn"
        Me.ventadetalle_btn.Size = New System.Drawing.Size(141, 38)
        Me.ventadetalle_btn.TabIndex = 8
        Me.ventadetalle_btn.Text = "Registrar venta"
        Me.ventadetalle_btn.UseVisualStyleBackColor = False
        '
        'panelCobrar
        '
        Me.panelCobrar.BackColor = System.Drawing.Color.SteelBlue
        Me.panelCobrar.Controls.Add(Me.btnConfirmarVenta)
        Me.panelCobrar.Controls.Add(Me.Label14)
        Me.panelCobrar.Controls.Add(Me.Label13)
        Me.panelCobrar.Controls.Add(Me.txtCambio)
        Me.panelCobrar.Controls.Add(Me.txtPagoCliente)
        Me.panelCobrar.Controls.Add(Me.txtTotalVenta)
        Me.panelCobrar.Controls.Add(Me.Label9)
        Me.panelCobrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelCobrar.Location = New System.Drawing.Point(284, 0)
        Me.panelCobrar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.panelCobrar.Name = "panelCobrar"
        Me.panelCobrar.Size = New System.Drawing.Size(404, 79)
        Me.panelCobrar.TabIndex = 28
        '
        'btnConfirmarVenta
        '
        Me.btnConfirmarVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnConfirmarVenta.BackColor = System.Drawing.Color.DimGray
        Me.btnConfirmarVenta.Enabled = False
        Me.btnConfirmarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConfirmarVenta.Location = New System.Drawing.Point(293, 22)
        Me.btnConfirmarVenta.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnConfirmarVenta.Name = "btnConfirmarVenta"
        Me.btnConfirmarVenta.Size = New System.Drawing.Size(105, 38)
        Me.btnConfirmarVenta.TabIndex = 9
        Me.btnConfirmarVenta.Text = "Confirmar venta"
        Me.btnConfirmarVenta.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 57)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "CAMBIO:"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 32)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "EFECTIVO:"
        '
        'txtCambio
        '
        Me.txtCambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtCambio.Enabled = False
        Me.txtCambio.Location = New System.Drawing.Point(79, 57)
        Me.txtCambio.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCambio.Name = "txtCambio"
        Me.txtCambio.ReadOnly = True
        Me.txtCambio.Size = New System.Drawing.Size(209, 20)
        Me.txtCambio.TabIndex = 29
        '
        'txtPagoCliente
        '
        Me.txtPagoCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtPagoCliente.Enabled = False
        Me.txtPagoCliente.Location = New System.Drawing.Point(79, 30)
        Me.txtPagoCliente.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPagoCliente.Name = "txtPagoCliente"
        Me.txtPagoCliente.Size = New System.Drawing.Size(209, 20)
        Me.txtPagoCliente.TabIndex = 28
        Me.txtPagoCliente.Text = "0"
        '
        'txtTotalVenta
        '
        Me.txtTotalVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtTotalVenta.Location = New System.Drawing.Point(79, 5)
        Me.txtTotalVenta.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtTotalVenta.Name = "txtTotalVenta"
        Me.txtTotalVenta.ReadOnly = True
        Me.txtTotalVenta.Size = New System.Drawing.Size(209, 20)
        Me.txtTotalVenta.TabIndex = 26
        Me.txtTotalVenta.TabStop = False
        Me.txtTotalVenta.Text = "0"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 7)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "TOTAL:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.eliminardeLista_btn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(2, 16)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 46)
        Me.Panel1.TabIndex = 26
        '
        'eliminardeLista_btn
        '
        Me.eliminardeLista_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.eliminardeLista_btn.BackColor = System.Drawing.Color.Red
        Me.eliminardeLista_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.eliminardeLista_btn.Location = New System.Drawing.Point(557, 9)
        Me.eliminardeLista_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.eliminardeLista_btn.Name = "eliminardeLista_btn"
        Me.eliminardeLista_btn.Size = New System.Drawing.Size(124, 32)
        Me.eliminardeLista_btn.TabIndex = 10
        Me.eliminardeLista_btn.Text = "Eliminar de la Lista"
        Me.eliminardeLista_btn.UseVisualStyleBackColor = False
        '
        'Frm_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 519)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Frm_Venta"
        Me.Text = "Frm_Venta"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pb_ProdImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dataFact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.panelCobrar.ResumeLayout(False)
        Me.panelCobrar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Public WithEvents CodigoDetalleVenta As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAplicar As Button
    Public WithEvents txtCantidad As TextBox
    Friend WithEvents agregarListado_btn As Button
    Friend WithEvents pb_ProdImg As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ventaNew_btn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_preciototal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents buscarProd_btn As Button
    Friend WithEvents Label2 As Label
    Public WithEvents txt_nombreProd As TextBox
    Public WithEvents txt_precioUnidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Public WithEvents txt_prodId As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dataFact As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ventadetalle_btn As Button
    Friend WithEvents panelCobrar As Panel
    Friend WithEvents txtTotalVenta As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents eliminardeLista_btn As Button
    Friend WithEvents btnConfirmarVenta As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Public WithEvents txtCambio As TextBox
    Public WithEvents txtPagoCliente As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtStock As TextBox
    Public WithEvents txtestado As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents labelVenta As Label
    Friend WithEvents ProductoID As DataGridViewTextBoxColumn
    Friend WithEvents NombreProducto As DataGridViewTextBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnidad As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
