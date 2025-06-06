﻿namespace Proyecto.Formularios.Ventas
{
    partial class frmNuevaVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevaVenta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            this.btnbuscarcliente = new FontAwesome.Sharp.IconButton();
            this.btnagregarproducto = new FontAwesome.Sharp.IconButton();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.txtcodproducto = new System.Windows.Forms.TextBox();
            this.txtdoccliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnumerodocumento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtfecharegistro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnCrearVenta = new FontAwesome.Sharp.IconButton();
            this.btnCancelarVenta = new FontAwesome.Sharp.IconButton();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.txtpagocon = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbuscarproducto);
            this.groupBox1.Controls.Add(this.btnbuscarcliente);
            this.groupBox1.Controls.Add(this.btnagregarproducto);
            this.groupBox1.Controls.Add(this.txtstock);
            this.groupBox1.Controls.Add(this.txtprecioventa);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.txtproducto);
            this.groupBox1.Controls.Add(this.txtnombrecliente);
            this.groupBox1.Controls.Add(this.txtcodproducto);
            this.groupBox1.Controls.Add(this.txtdoccliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarproducto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarproducto.IconSize = 20;
            this.btnbuscarproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarproducto.Location = new System.Drawing.Point(243, 49);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Size = new System.Drawing.Size(69, 23);
            this.btnbuscarproducto.TabIndex = 16;
            this.btnbuscarproducto.Text = "Buscar";
            this.btnbuscarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarproducto.UseVisualStyleBackColor = true;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarcliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarcliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.btnbuscarcliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarcliente.IconSize = 20;
            this.btnbuscarcliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarcliente.Location = new System.Drawing.Point(243, 20);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Size = new System.Drawing.Size(69, 23);
            this.btnbuscarcliente.TabIndex = 15;
            this.btnbuscarcliente.Text = "Buscar";
            this.btnbuscarcliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarcliente.UseVisualStyleBackColor = true;
            this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnagregarproducto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregarproducto.IconSize = 20;
            this.btnagregarproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnagregarproducto.Location = new System.Drawing.Point(410, 107);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.Size = new System.Drawing.Size(195, 23);
            this.btnagregarproducto.TabIndex = 14;
            this.btnagregarproducto.Text = "Agregar";
            this.btnagregarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnagregarproducto.UseVisualStyleBackColor = true;
            this.btnagregarproducto.Click += new System.EventHandler(this.btnagregarproducto_Click);
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(100, 109);
            this.txtstock.Name = "txtstock";
            this.txtstock.ReadOnly = true;
            this.txtstock.Size = new System.Drawing.Size(133, 20);
            this.txtstock.TabIndex = 13;
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Location = new System.Drawing.Point(410, 80);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(195, 20);
            this.txtprecioventa.TabIndex = 12;
            this.txtprecioventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecioventa_KeyPress);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(100, 81);
            this.txtcantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtcantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(133, 20);
            this.txtcantidad.TabIndex = 11;
            this.txtcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(410, 52);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.ReadOnly = true;
            this.txtproducto.Size = new System.Drawing.Size(195, 20);
            this.txtproducto.TabIndex = 10;
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(410, 22);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(195, 20);
            this.txtnombrecliente.TabIndex = 9;
            // 
            // txtcodproducto
            // 
            this.txtcodproducto.Location = new System.Drawing.Point(100, 51);
            this.txtcodproducto.Name = "txtcodproducto";
            this.txtcodproducto.Size = new System.Drawing.Size(133, 20);
            this.txtcodproducto.TabIndex = 8;
            this.txtcodproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodproducto_KeyDown);
            // 
            // txtdoccliente
            // 
            this.txtdoccliente.Location = new System.Drawing.Point(100, 22);
            this.txtdoccliente.Name = "txtdoccliente";
            this.txtdoccliente.Size = new System.Drawing.Size(133, 20);
            this.txtdoccliente.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio Venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cod. Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doc. Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvdata);
            this.groupBox2.Location = new System.Drawing.Point(8, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 210);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Codigo,
            this.Producto,
            this.Categoria,
            this.Medida,
            this.Cantidad,
            this.Precio,
            this.SubTotal,
            this.btneliminar});
            this.dgvdata.Location = new System.Drawing.Point(4, 10);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvdata.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowTemplate.Height = 24;
            this.dgvdata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.Size = new System.Drawing.Size(613, 194);
            this.dgvdata.TabIndex = 14;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Visible = false;
            // 
            // Medida
            // 
            this.Medida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Medida.HeaderText = "Medida";
            this.Medida.Name = "Medida";
            this.Medida.ReadOnly = true;
            this.Medida.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SubTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btneliminar
            // 
            this.btneliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btneliminar.HeaderText = "";
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(463, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total a Pagar:";
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.Location = new System.Drawing.Point(557, 475);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.ReadOnly = true;
            this.txttotalpagar.Size = new System.Drawing.Size(74, 20);
            this.txttotalpagar.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.label9.Location = new System.Drawing.Point(8, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(623, 94);
            this.label9.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(129, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Numero Documento:";
            // 
            // txtnumerodocumento
            // 
            this.txtnumerodocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumerodocumento.Location = new System.Drawing.Point(240, 69);
            this.txtnumerodocumento.Name = "txtnumerodocumento";
            this.txtnumerodocumento.ReadOnly = true;
            this.txtnumerodocumento.Size = new System.Drawing.Size(119, 20);
            this.txtnumerodocumento.TabIndex = 21;
            this.txtnumerodocumento.Text = "Autogenerado";
            this.txtnumerodocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(389, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Fecha Registro:";
            // 
            // txtfecharegistro
            // 
            this.txtfecharegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecharegistro.Location = new System.Drawing.Point(477, 69);
            this.txtfecharegistro.Name = "txtfecharegistro";
            this.txtfecharegistro.ReadOnly = true;
            this.txtfecharegistro.Size = new System.Drawing.Size(111, 20);
            this.txtfecharegistro.TabIndex = 23;
            this.txtfecharegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(133, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 31);
            this.label12.TabIndex = 24;
            this.label12.Text = "Nueva Venta";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 72;
            this.iconPictureBox1.Location = new System.Drawing.Point(16, 13);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Padding = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.iconPictureBox1.Size = new System.Drawing.Size(75, 72);
            this.iconPictureBox1.TabIndex = 19;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnCrearVenta
            // 
            this.btnCrearVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearVenta.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnCrearVenta.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnCrearVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearVenta.IconSize = 20;
            this.btnCrearVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearVenta.Location = new System.Drawing.Point(8, 473);
            this.btnCrearVenta.Name = "btnCrearVenta";
            this.btnCrearVenta.Size = new System.Drawing.Size(139, 23);
            this.btnCrearVenta.TabIndex = 17;
            this.btnCrearVenta.Text = "Crear Venta";
            this.btnCrearVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearVenta.UseVisualStyleBackColor = true;
            this.btnCrearVenta.Click += new System.EventHandler(this.btnCrearVenta_Click);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarVenta.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnCancelarVenta.IconColor = System.Drawing.Color.Red;
            this.btnCancelarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarVenta.IconSize = 20;
            this.btnCancelarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarVenta.Location = new System.Drawing.Point(8, 504);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(139, 23);
            this.btnCancelarVenta.TabIndex = 17;
            this.btnCancelarVenta.Text = "Cancelar Venta";
            this.btnCancelarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // txtcambio
            // 
            this.txtcambio.Location = new System.Drawing.Point(557, 503);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.ReadOnly = true;
            this.txtcambio.Size = new System.Drawing.Size(74, 20);
            this.txtcambio.TabIndex = 25;
            // 
            // txtpagocon
            // 
            this.txtpagocon.Location = new System.Drawing.Point(400, 503);
            this.txtpagocon.Name = "txtpagocon";
            this.txtpagocon.Size = new System.Drawing.Size(74, 20);
            this.txtpagocon.TabIndex = 26;
            this.txtpagocon.TextChanged += new System.EventHandler(this.txtpagocon_TextChanged);
            this.txtpagocon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpagocon_KeyDown);
            this.txtpagocon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpagocon_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(506, 506);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Cambio:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(338, 506);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Paga con:";
            // 
            // frmNuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 545);
            this.ControlBox = false;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtpagocon);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtfecharegistro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtnumerodocumento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txttotalpagar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCrearVenta);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Nueva Venta :.";
            this.Load += new System.EventHandler(this.frmNuevaVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.TextBox txtcodproducto;
        private System.Windows.Forms.TextBox txtdoccliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private FontAwesome.Sharp.IconButton btnbuscarcliente;
        private FontAwesome.Sharp.IconButton btnagregarproducto;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnCancelarVenta;
        private FontAwesome.Sharp.IconButton btnCrearVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttotalpagar;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtnumerodocumento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtfecharegistro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.TextBox txtpagocon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
    }
}