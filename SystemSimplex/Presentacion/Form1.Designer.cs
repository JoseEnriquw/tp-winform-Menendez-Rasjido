﻿
namespace Presentacion
{
    partial class Window
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabpageMenu = new System.Windows.Forms.TabPage();
            this.tabpageListar = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelListar = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridViewListar = new System.Windows.Forms.DataGridView();
            this.tabpageME = new System.Windows.Forms.TabPage();
            this.tabpageAgregar = new System.Windows.Forms.TabPage();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelPictureBox = new System.Windows.Forms.Label();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.listarArticuloPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDeArticulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descripcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl.SuspendLayout();
            this.tabpageListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListar)).BeginInit();
            this.tabpageAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabpageMenu);
            this.tabControl.Controls.Add(this.tabpageListar);
            this.tabControl.Controls.Add(this.tabpageME);
            this.tabControl.Controls.Add(this.tabpageAgregar);
            this.tabControl.Location = new System.Drawing.Point(4, 18);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(793, 445);
            this.tabControl.TabIndex = 0;
            // 
            // tabpageMenu
            // 
            this.tabpageMenu.Location = new System.Drawing.Point(4, 22);
            this.tabpageMenu.Name = "tabpageMenu";
            this.tabpageMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageMenu.Size = new System.Drawing.Size(785, 419);
            this.tabpageMenu.TabIndex = 0;
            this.tabpageMenu.Text = "Interfaz ";
            this.tabpageMenu.UseVisualStyleBackColor = true;
            // 
            // tabpageListar
            // 
            this.tabpageListar.Controls.Add(this.label2);
            this.tabpageListar.Controls.Add(this.textBox7);
            this.tabpageListar.Controls.Add(this.textBox6);
            this.tabpageListar.Controls.Add(this.textBox5);
            this.tabpageListar.Controls.Add(this.labelListar);
            this.tabpageListar.Controls.Add(this.buttonBuscar);
            this.tabpageListar.Controls.Add(this.dataGridViewListar);
            this.tabpageListar.Location = new System.Drawing.Point(4, 22);
            this.tabpageListar.Name = "tabpageListar";
            this.tabpageListar.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageListar.Size = new System.Drawing.Size(785, 419);
            this.tabpageListar.TabIndex = 1;
            this.tabpageListar.Text = "Listar";
            this.tabpageListar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(536, 38);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(56, 20);
            this.textBox7.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(453, 38);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(56, 20);
            this.textBox6.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(35, 35);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(264, 20);
            this.textBox5.TabIndex = 3;
            // 
            // labelListar
            // 
            this.labelListar.AutoSize = true;
            this.labelListar.Location = new System.Drawing.Point(103, 17);
            this.labelListar.Name = "labelListar";
            this.labelListar.Size = new System.Drawing.Size(0, 13);
            this.labelListar.TabIndex = 2;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(341, 35);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dataGridViewListar
            // 
            this.dataGridViewListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListar.Location = new System.Drawing.Point(22, 83);
            this.dataGridViewListar.Name = "dataGridViewListar";
            this.dataGridViewListar.Size = new System.Drawing.Size(728, 290);
            this.dataGridViewListar.TabIndex = 0;
            // 
            // tabpageME
            // 
            this.tabpageME.Location = new System.Drawing.Point(4, 22);
            this.tabpageME.Name = "tabpageME";
            this.tabpageME.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageME.Size = new System.Drawing.Size(785, 419);
            this.tabpageME.TabIndex = 2;
            this.tabpageME.Text = "Modificar o Eliminar";
            this.tabpageME.UseVisualStyleBackColor = true;
            // 
            // tabpageAgregar
            // 
            this.tabpageAgregar.Controls.Add(this.labelPrecio);
            this.tabpageAgregar.Controls.Add(this.labelNombre);
            this.tabpageAgregar.Controls.Add(this.labelCodigo);
            this.tabpageAgregar.Controls.Add(this.labelID);
            this.tabpageAgregar.Controls.Add(this.textBox4);
            this.tabpageAgregar.Controls.Add(this.textBox3);
            this.tabpageAgregar.Controls.Add(this.textBox2);
            this.tabpageAgregar.Controls.Add(this.textBox1);
            this.tabpageAgregar.Controls.Add(this.labelCategoria);
            this.tabpageAgregar.Controls.Add(this.labelMarca);
            this.tabpageAgregar.Controls.Add(this.comboBox2);
            this.tabpageAgregar.Controls.Add(this.comboBox1);
            this.tabpageAgregar.Controls.Add(this.buttonAdd);
            this.tabpageAgregar.Controls.Add(this.labelPictureBox);
            this.tabpageAgregar.Controls.Add(this.pictureBoxAdd);
            this.tabpageAgregar.Location = new System.Drawing.Point(4, 22);
            this.tabpageAgregar.Name = "tabpageAgregar";
            this.tabpageAgregar.Size = new System.Drawing.Size(785, 419);
            this.tabpageAgregar.TabIndex = 3;
            this.tabpageAgregar.Text = "Agregar";
            this.tabpageAgregar.UseVisualStyleBackColor = true;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(356, 61);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 14;
            this.labelPrecio.Text = "Precio";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(235, 61);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 13;
            this.labelNombre.Text = "Nombre";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(113, 61);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 12;
            this.labelCodigo.Text = "Codigo";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(10, 61);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(90, 13);
            this.labelID.TabIndex = 11;
            this.labelID.Text = "Id (Autonumerico)";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(359, 77);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(102, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(238, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(115, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 20);
            this.textBox1.TabIndex = 7;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(220, 117);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(52, 13);
            this.labelCategoria.TabIndex = 6;
            this.labelCategoria.Text = "Categoria";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(10, 117);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 5;
            this.labelMarca.Text = "Marca";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(223, 133);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(192, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(467, 340);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(299, 25);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "AGREGAR";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // labelPictureBox
            // 
            this.labelPictureBox.AutoSize = true;
            this.labelPictureBox.Location = new System.Drawing.Point(509, 52);
            this.labelPictureBox.Name = "labelPictureBox";
            this.labelPictureBox.Size = new System.Drawing.Size(104, 13);
            this.labelPictureBox.TabIndex = 1;
            this.labelPictureBox.Text = "Imagen del producto";
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.Location = new System.Drawing.Point(467, 77);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(299, 257);
            this.pictureBoxAdd.TabIndex = 0;
            this.pictureBoxAdd.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarArticuloPorToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.configuracionToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // listarArticuloPorToolStripMenuItem
            // 
            this.listarArticuloPorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todoToolStripMenuItem,
            this.iDToolStripMenuItem,
            this.codigoToolStripMenuItem,
            this.nombreDeArticulToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.descripcionToolStripMenuItem});
            this.listarArticuloPorToolStripMenuItem.Name = "listarArticuloPorToolStripMenuItem";
            this.listarArticuloPorToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.listarArticuloPorToolStripMenuItem.Text = "Listar Articulo Por";
            // 
            // todoToolStripMenuItem
            // 
            this.todoToolStripMenuItem.Name = "todoToolStripMenuItem";
            this.todoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.todoToolStripMenuItem.Text = "Todo";
            this.todoToolStripMenuItem.Click += new System.EventHandler(this.todoToolStripMenuItem_Click);
            // 
            // iDToolStripMenuItem
            // 
            this.iDToolStripMenuItem.Name = "iDToolStripMenuItem";
            this.iDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iDToolStripMenuItem.Text = "ID";
            // 
            // codigoToolStripMenuItem
            // 
            this.codigoToolStripMenuItem.Name = "codigoToolStripMenuItem";
            this.codigoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.codigoToolStripMenuItem.Text = "Codigo";
            this.codigoToolStripMenuItem.Click += new System.EventHandler(this.codigoDeArticuloToolStripMenuItem_Click);
            // 
            // nombreDeArticulToolStripMenuItem
            // 
            this.nombreDeArticulToolStripMenuItem.Name = "nombreDeArticulToolStripMenuItem";
            this.nombreDeArticulToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nombreDeArticulToolStripMenuItem.Text = "Nombre";
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // descripcionToolStripMenuItem
            // 
            this.descripcionToolStripMenuItem.Name = "descripcionToolStripMenuItem";
            this.descripcionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.descripcionToolStripMenuItem.Text = "Descripcion";
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarArticuloToolStripMenuItem});
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.agregarToolStripMenuItem.Text = "Agregar Articulo";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.modificarToolStripMenuItem.Text = "Modificar Articulo";
            // 
            // eliminarArticuloToolStripMenuItem
            // 
            this.eliminarArticuloToolStripMenuItem.Name = "eliminarArticuloToolStripMenuItem";
            this.eliminarArticuloToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.eliminarArticuloToolStripMenuItem.Text = "Eliminar Articulo";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.tabControl);
            this.Name = "Window";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabpageListar.ResumeLayout(false);
            this.tabpageListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListar)).EndInit();
            this.tabpageAgregar.ResumeLayout(false);
            this.tabpageAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabpageMenu;
        private System.Windows.Forms.TabPage tabpageListar;
        private System.Windows.Forms.TabPage tabpageME;
        private System.Windows.Forms.TabPage tabpageAgregar;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem listarArticuloPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDeArticulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelPictureBox;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label labelListar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridViewListar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem todoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descripcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDToolStripMenuItem;
    }
}

