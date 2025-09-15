namespace ProjectoNuevo
{
    partial class FormAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStpMenuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStpMenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStpMenuPeliculas = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStpMenuSeries = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelPeliculaCreacion = new System.Windows.Forms.Panel();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.PanelDescripcion = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PanelImagen = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelDuracion = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.PanelDirector = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PanelFecha = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PanelUsuario = new System.Windows.Forms.Panel();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblPanelPelicula = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelPeliculaCreacion.SuspendLayout();
            this.PanelDescripcion.SuspendLayout();
            this.PanelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelDuracion.SuspendLayout();
            this.PanelDirector.SuspendLayout();
            this.PanelFecha.SuspendLayout();
            this.PanelUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStpMenuArchivo,
            this.ToolStpMenuUsuarios,
            this.ToolStpMenuPeliculas,
            this.ToolStpMenuSeries,
            this.cerrarProgramaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStpMenuArchivo
            // 
            this.ToolStpMenuArchivo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStpMenuArchivo.Name = "ToolStpMenuArchivo";
            this.ToolStpMenuArchivo.Size = new System.Drawing.Size(69, 22);
            this.ToolStpMenuArchivo.Text = "Archivo";
            // 
            // ToolStpMenuUsuarios
            // 
            this.ToolStpMenuUsuarios.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStpMenuUsuarios.Name = "ToolStpMenuUsuarios";
            this.ToolStpMenuUsuarios.Size = new System.Drawing.Size(136, 22);
            this.ToolStpMenuUsuarios.Text = "Gestionar Usuarios";
            this.ToolStpMenuUsuarios.Click += new System.EventHandler(this.ToolStpMenuUsuarios_Click);
            // 
            // ToolStpMenuPeliculas
            // 
            this.ToolStpMenuPeliculas.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStpMenuPeliculas.Name = "ToolStpMenuPeliculas";
            this.ToolStpMenuPeliculas.Size = new System.Drawing.Size(135, 22);
            this.ToolStpMenuPeliculas.Text = "Gestionar Peliculas";
            this.ToolStpMenuPeliculas.Click += new System.EventHandler(this.ToolStpMenuPeliculas_Click);
            // 
            // ToolStpMenuSeries
            // 
            this.ToolStpMenuSeries.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStpMenuSeries.Name = "ToolStpMenuSeries";
            this.ToolStpMenuSeries.Size = new System.Drawing.Size(117, 22);
            this.ToolStpMenuSeries.Text = "Gestionar Series";
            // 
            // cerrarProgramaToolStripMenuItem
            // 
            this.cerrarProgramaToolStripMenuItem.Name = "cerrarProgramaToolStripMenuItem";
            this.cerrarProgramaToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.cerrarProgramaToolStripMenuItem.Text = "Cerrar Programa";
            this.cerrarProgramaToolStripMenuItem.Click += new System.EventHandler(this.cerrarProgramaToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.PanelPeliculaCreacion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 504);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // PanelPeliculaCreacion
            // 
            this.PanelPeliculaCreacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PanelPeliculaCreacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.PanelPeliculaCreacion.Controls.Add(this.BtnIngresar);
            this.PanelPeliculaCreacion.Controls.Add(this.PanelDescripcion);
            this.PanelPeliculaCreacion.Controls.Add(this.label6);
            this.PanelPeliculaCreacion.Controls.Add(this.PanelImagen);
            this.PanelPeliculaCreacion.Controls.Add(this.PanelDuracion);
            this.PanelPeliculaCreacion.Controls.Add(this.PanelDirector);
            this.PanelPeliculaCreacion.Controls.Add(this.PanelFecha);
            this.PanelPeliculaCreacion.Controls.Add(this.PanelUsuario);
            this.PanelPeliculaCreacion.Controls.Add(this.label5);
            this.PanelPeliculaCreacion.Controls.Add(this.label4);
            this.PanelPeliculaCreacion.Controls.Add(this.label3);
            this.PanelPeliculaCreacion.Controls.Add(this.label2);
            this.PanelPeliculaCreacion.Controls.Add(this.label1);
            this.PanelPeliculaCreacion.Controls.Add(this.LblPanelPelicula);
            this.PanelPeliculaCreacion.Location = new System.Drawing.Point(27, 27);
            this.PanelPeliculaCreacion.Name = "PanelPeliculaCreacion";
            this.PanelPeliculaCreacion.Size = new System.Drawing.Size(882, 450);
            this.PanelPeliculaCreacion.TabIndex = 0;
            this.PanelPeliculaCreacion.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.Location = new System.Drawing.Point(539, 224);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(200, 35);
            this.BtnIngresar.TabIndex = 33;
            this.BtnIngresar.Text = "Cargar película";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            // 
            // PanelDescripcion
            // 
            this.PanelDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.PanelDescripcion.Controls.Add(this.textBox4);
            this.PanelDescripcion.Location = new System.Drawing.Point(534, 94);
            this.PanelDescripcion.Name = "PanelDescripcion";
            this.PanelDescripcion.Padding = new System.Windows.Forms.Padding(5);
            this.PanelDescripcion.Size = new System.Drawing.Size(205, 115);
            this.PanelDescripcion.TabIndex = 29;
            this.PanelDescripcion.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDescripcion_Paint);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(5, 5);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(195, 105);
            this.textBox4.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(531, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Descripcion";
            // 
            // PanelImagen
            // 
            this.PanelImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.PanelImagen.Controls.Add(this.pictureBox1);
            this.PanelImagen.Location = new System.Drawing.Point(309, 94);
            this.PanelImagen.Name = "PanelImagen";
            this.PanelImagen.Padding = new System.Windows.Forms.Padding(5);
            this.PanelImagen.Size = new System.Drawing.Size(205, 202);
            this.PanelImagen.TabIndex = 31;
            this.PanelImagen.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelImagen_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 192);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelDuracion
            // 
            this.PanelDuracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.PanelDuracion.Controls.Add(this.textBox3);
            this.PanelDuracion.Location = new System.Drawing.Point(30, 323);
            this.PanelDuracion.Name = "PanelDuracion";
            this.PanelDuracion.Padding = new System.Windows.Forms.Padding(5);
            this.PanelDuracion.Size = new System.Drawing.Size(205, 35);
            this.PanelDuracion.TabIndex = 30;
            this.PanelDuracion.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDuracion_Paint);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(5, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 22);
            this.textBox3.TabIndex = 12;
            // 
            // PanelDirector
            // 
            this.PanelDirector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.PanelDirector.Controls.Add(this.textBox2);
            this.PanelDirector.Location = new System.Drawing.Point(30, 244);
            this.PanelDirector.Name = "PanelDirector";
            this.PanelDirector.Padding = new System.Windows.Forms.Padding(5);
            this.PanelDirector.Size = new System.Drawing.Size(205, 35);
            this.PanelDirector.TabIndex = 29;
            this.PanelDirector.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDirector_Paint);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(5, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 22);
            this.textBox2.TabIndex = 12;
            // 
            // PanelFecha
            // 
            this.PanelFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.PanelFecha.Controls.Add(this.textBox1);
            this.PanelFecha.Location = new System.Drawing.Point(30, 166);
            this.PanelFecha.Name = "PanelFecha";
            this.PanelFecha.Padding = new System.Windows.Forms.Padding(5);
            this.PanelFecha.Size = new System.Drawing.Size(205, 35);
            this.PanelFecha.TabIndex = 29;
            this.PanelFecha.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelFecha_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(5, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 22);
            this.textBox1.TabIndex = 12;
            // 
            // PanelUsuario
            // 
            this.PanelUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.PanelUsuario.Controls.Add(this.TxtUsuario);
            this.PanelUsuario.Location = new System.Drawing.Point(30, 94);
            this.PanelUsuario.Name = "PanelUsuario";
            this.PanelUsuario.Padding = new System.Windows.Forms.Padding(5);
            this.PanelUsuario.Size = new System.Drawing.Size(205, 35);
            this.PanelUsuario.TabIndex = 28;
            this.PanelUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelUsuario_Paint);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtUsuario.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.White;
            this.TxtUsuario.Location = new System.Drawing.Point(5, 5);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(195, 22);
            this.TxtUsuario.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(306, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Imagen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Duracion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Director";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Fecha de estreno";
            // 
            // LblPanelPelicula
            // 
            this.LblPanelPelicula.AutoSize = true;
            this.LblPanelPelicula.BackColor = System.Drawing.Color.Transparent;
            this.LblPanelPelicula.Enabled = false;
            this.LblPanelPelicula.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPanelPelicula.ForeColor = System.Drawing.Color.White;
            this.LblPanelPelicula.Location = new System.Drawing.Point(27, 74);
            this.LblPanelPelicula.Name = "LblPanelPelicula";
            this.LblPanelPelicula.Size = new System.Drawing.Size(125, 17);
            this.LblPanelPelicula.TabIndex = 22;
            this.LblPanelPelicula.Text = "Nombre de la pelicula";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.PanelPeliculaCreacion.ResumeLayout(false);
            this.PanelPeliculaCreacion.PerformLayout();
            this.PanelDescripcion.ResumeLayout(false);
            this.PanelDescripcion.PerformLayout();
            this.PanelImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelDuracion.ResumeLayout(false);
            this.PanelDuracion.PerformLayout();
            this.PanelDirector.ResumeLayout(false);
            this.PanelDirector.PerformLayout();
            this.PanelFecha.ResumeLayout(false);
            this.PanelFecha.PerformLayout();
            this.PanelUsuario.ResumeLayout(false);
            this.PanelUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStpMenuArchivo;
        private System.Windows.Forms.ToolStripMenuItem ToolStpMenuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem ToolStpMenuPeliculas;
        private System.Windows.Forms.ToolStripMenuItem ToolStpMenuSeries;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelPeliculaCreacion;
        private System.Windows.Forms.ToolStripMenuItem cerrarProgramaToolStripMenuItem;
        private System.Windows.Forms.Label LblPanelPelicula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PanelUsuario;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Panel PanelDuracion;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel PanelDirector;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel PanelFecha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel PanelImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelDescripcion;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnIngresar;
    }
}