namespace compilador
{
    partial class Form1
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
            this.btnCompilarCod = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.IngreseTexto = new System.Windows.Forms.Label();
            this.textCargar = new System.Windows.Forms.Label();
            this.textArchivo = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ValorRecibido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDeLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosicionInicialError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosicionFinalError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosicionInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosicionFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewLiterales = new System.Windows.Forms.DataGridView();
            this.Literal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosicionIncial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosicionFnal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLiterales)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompilarCod
            // 
            this.btnCompilarCod.Location = new System.Drawing.Point(15, 207);
            this.btnCompilarCod.Name = "btnCompilarCod";
            this.btnCompilarCod.Size = new System.Drawing.Size(104, 25);
            this.btnCompilarCod.TabIndex = 0;
            this.btnCompilarCod.Text = "Leer";
            this.btnCompilarCod.UseVisualStyleBackColor = true;
            this.btnCompilarCod.Click += new System.EventHandler(this.btnCompilarCod_Click);
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(12, 46);
            this.codigo.Multiline = true;
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(334, 146);
            this.codigo.TabIndex = 1;
            this.codigo.TextChanged += new System.EventHandler(this.codigo_TextChanged);
            // 
            // resultado
            // 
            this.resultado.Enabled = false;
            this.resultado.Location = new System.Drawing.Point(12, 319);
            this.resultado.Multiline = true;
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(334, 302);
            this.resultado.TabIndex = 2;
            this.resultado.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.resultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // IngreseTexto
            // 
            this.IngreseTexto.AutoSize = true;
            this.IngreseTexto.Location = new System.Drawing.Point(12, 18);
            this.IngreseTexto.Name = "IngreseTexto";
            this.IngreseTexto.Size = new System.Drawing.Size(89, 13);
            this.IngreseTexto.TabIndex = 3;
            this.IngreseTexto.Text = "Ingrese el Texto: ";
            // 
            // textCargar
            // 
            this.textCargar.AutoSize = true;
            this.textCargar.Location = new System.Drawing.Point(12, 245);
            this.textCargar.Name = "textCargar";
            this.textCargar.Size = new System.Drawing.Size(77, 13);
            this.textCargar.TabIndex = 4;
            this.textCargar.Text = "Cargar Archivo";
            // 
            // textArchivo
            // 
            this.textArchivo.Location = new System.Drawing.Point(15, 277);
            this.textArchivo.Name = "textArchivo";
            this.textArchivo.Size = new System.Drawing.Size(214, 20);
            this.textArchivo.TabIndex = 5;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(235, 274);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(104, 23);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Analizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ValorRecibido,
            this.Descripcion,
            this.NumeroDeLinea,
            this.PosicionInicialError,
            this.PosicionFinalError,
            this.TipoError});
            this.dataGridView1.Location = new System.Drawing.Point(-4, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(893, 569);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ValorRecibido
            // 
            this.ValorRecibido.HeaderText = "ValorRecibido";
            this.ValorRecibido.Name = "ValorRecibido";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // NumeroDeLinea
            // 
            this.NumeroDeLinea.HeaderText = "NumeroDeLinea";
            this.NumeroDeLinea.Name = "NumeroDeLinea";
            // 
            // PosicionInicialError
            // 
            this.PosicionInicialError.HeaderText = "PosicionInicialError";
            this.PosicionInicialError.Name = "PosicionInicialError";
            // 
            // PosicionFinalError
            // 
            this.PosicionFinalError.HeaderText = "PosicionFinalError";
            this.PosicionFinalError.Name = "PosicionFinalError";
            // 
            // TipoError
            // 
            this.TipoError.HeaderText = "TipoError";
            this.TipoError.Name = "TipoError";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lexema,
            this.NumeroLinea,
            this.Categoria,
            this.PosicionInicial,
            this.PosicionFinal});
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.Location = new System.Drawing.Point(-4, 6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(890, 569);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Lexema
            // 
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.Name = "Lexema";
            this.Lexema.ReadOnly = true;
            // 
            // NumeroLinea
            // 
            this.NumeroLinea.HeaderText = "NumeroLinea";
            this.NumeroLinea.Name = "NumeroLinea";
            this.NumeroLinea.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // PosicionInicial
            // 
            this.PosicionInicial.HeaderText = "PosicionInicial";
            this.PosicionInicial.Name = "PosicionInicial";
            this.PosicionInicial.ReadOnly = true;
            // 
            // PosicionFinal
            // 
            this.PosicionFinal.HeaderText = "PosicionFinal";
            this.PosicionFinal.Name = "PosicionFinal";
            this.PosicionFinal.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewLiterales
            // 
            this.dataGridViewLiterales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLiterales.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewLiterales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLiterales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Literal,
            this.NumeroDLinea,
            this.Categorias,
            this.PosicionIncial,
            this.PosicionFnal});
            this.dataGridViewLiterales.Location = new System.Drawing.Point(-4, 6);
            this.dataGridViewLiterales.Name = "dataGridViewLiterales";
            this.dataGridViewLiterales.Size = new System.Drawing.Size(893, 569);
            this.dataGridViewLiterales.TabIndex = 12;
            this.dataGridViewLiterales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // Literal
            // 
            this.Literal.HeaderText = "Literal";
            this.Literal.Name = "Literal";
            // 
            // NumeroDLinea
            // 
            this.NumeroDLinea.HeaderText = "NumeroDLinea ";
            this.NumeroDLinea.Name = "NumeroDLinea";
            // 
            // Categorias
            // 
            this.Categorias.HeaderText = "Categorias";
            this.Categorias.Name = "Categorias";
            // 
            // PosicionIncial
            // 
            this.PosicionIncial.HeaderText = "PosicionInicial ";
            this.PosicionIncial.Name = "PosicionIncial";
            // 
            // PosicionFnal
            // 
            this.PosicionFnal.HeaderText = "PosicionFnal";
            this.PosicionFnal.Name = "PosicionFnal";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(388, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 570);
            this.tabControl1.TabIndex = 15;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewLiterales);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 544);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LITERALES";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 544);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SIMBOLOS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(892, 544);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ERRORES";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 567);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.textArchivo);
            this.Controls.Add(this.textCargar);
            this.Controls.Add(this.IngreseTexto);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.btnCompilarCod);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tarea";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLiterales)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompilarCod;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Label IngreseTexto;
        private System.Windows.Forms.Label textCargar;
        private System.Windows.Forms.TextBox textArchivo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosicionInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosicionFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorRecibido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDeLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosicionInicialError;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosicionFinalError;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoError;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewLiterales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Literal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosicionIncial;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosicionFnal;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

