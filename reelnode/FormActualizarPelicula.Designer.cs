namespace ProjectoNuevo
{
    partial class FormActualizarPelicula
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
            this.components = new System.ComponentModel.Container();
            this.CtxMenuModificar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxMenuSubModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.PanelDescripcion = new System.Windows.Forms.Panel();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.PanelImagen = new System.Windows.Forms.Panel();
            this.PicPelicula = new System.Windows.Forms.PictureBox();
            this.PanelDuracion = new System.Windows.Forms.Panel();
            this.TxtDuracion = new System.Windows.Forms.TextBox();
            this.PanelDirector = new System.Windows.Forms.Panel();
            this.TxtDirector = new System.Windows.Forms.TextBox();
            this.PanelFecha = new System.Windows.Forms.Panel();
            this.DtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
            this.PanelUsuario = new System.Windows.Forms.Panel();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.DataGridPeliculas = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnBuscarPelicula = new System.Windows.Forms.Button();
            this.PanelBuscarPeliculaNombre = new System.Windows.Forms.Panel();
            this.TxtBuscarNombrePelicula = new System.Windows.Forms.TextBox();
            this.CtxMenuModificar.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.PanelDescripcion.SuspendLayout();
            this.PanelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPelicula)).BeginInit();
            this.PanelDuracion.SuspendLayout();
            this.PanelDirector.SuspendLayout();
            this.PanelFecha.SuspendLayout();
            this.PanelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPeliculas)).BeginInit();
            this.PanelBuscarPeliculaNombre.SuspendLayout();
            this.SuspendLayout();
            // 
            // CtxMenuModificar
            // 
            this.CtxMenuModificar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtxMenuSubModificar});
            this.CtxMenuModificar.Name = "CtxMenuModificar";
            this.CtxMenuModificar.Size = new System.Drawing.Size(181, 48);
            // 
            // CtxMenuSubModificar
            // 
            this.CtxMenuSubModificar.Name = "CtxMenuSubModificar";
            this.CtxMenuSubModificar.Size = new System.Drawing.Size(180, 22);
            this.CtxMenuSubModificar.Text = "Modificar";
            this.CtxMenuSubModificar.Click += new System.EventHandler(this.CtxMenuSubModificar_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.PanelDescripcion);
            this.PanelMain.Controls.Add(this.PanelImagen);
            this.PanelMain.Controls.Add(this.PanelDuracion);
            this.PanelMain.Controls.Add(this.PanelDirector);
            this.PanelMain.Controls.Add(this.PanelFecha);
            this.PanelMain.Controls.Add(this.PanelUsuario);
            this.PanelMain.Controls.Add(this.DataGridPeliculas);
            this.PanelMain.Controls.Add(this.label7);
            this.PanelMain.Controls.Add(this.BtnBuscarPelicula);
            this.PanelMain.Controls.Add(this.PanelBuscarPeliculaNombre);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(933, 615);
            this.PanelMain.TabIndex = 1;
            // 
            // PanelDescripcion
            // 
            this.PanelDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.PanelDescripcion.Controls.Add(this.TxtDescripcion);
            this.PanelDescripcion.Location = new System.Drawing.Point(628, 293);
            this.PanelDescripcion.Name = "PanelDescripcion";
            this.PanelDescripcion.Padding = new System.Windows.Forms.Padding(5);
            this.PanelDescripcion.Size = new System.Drawing.Size(205, 115);
            this.PanelDescripcion.TabIndex = 49;
            this.PanelDescripcion.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDescripcion_Paint);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDescripcion.Enabled = false;
            this.TxtDescripcion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.ForeColor = System.Drawing.Color.White;
            this.TxtDescripcion.Location = new System.Drawing.Point(5, 5);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(195, 105);
            this.TxtDescripcion.TabIndex = 12;
            // 
            // PanelImagen
            // 
            this.PanelImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.PanelImagen.Controls.Add(this.PicPelicula);
            this.PanelImagen.Location = new System.Drawing.Point(334, 293);
            this.PanelImagen.Name = "PanelImagen";
            this.PanelImagen.Padding = new System.Windows.Forms.Padding(5);
            this.PanelImagen.Size = new System.Drawing.Size(205, 202);
            this.PanelImagen.TabIndex = 53;
            // 
            // PicPelicula
            // 
            this.PicPelicula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicPelicula.Location = new System.Drawing.Point(5, 5);
            this.PicPelicula.Name = "PicPelicula";
            this.PicPelicula.Size = new System.Drawing.Size(195, 192);
            this.PicPelicula.TabIndex = 0;
            this.PicPelicula.TabStop = false;
            // 
            // PanelDuracion
            // 
            this.PanelDuracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.PanelDuracion.Controls.Add(this.TxtDuracion);
            this.PanelDuracion.Location = new System.Drawing.Point(33, 522);
            this.PanelDuracion.Name = "PanelDuracion";
            this.PanelDuracion.Padding = new System.Windows.Forms.Padding(5);
            this.PanelDuracion.Size = new System.Drawing.Size(205, 35);
            this.PanelDuracion.TabIndex = 52;
            // 
            // TxtDuracion
            // 
            this.TxtDuracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.TxtDuracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDuracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDuracion.Enabled = false;
            this.TxtDuracion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDuracion.ForeColor = System.Drawing.Color.White;
            this.TxtDuracion.Location = new System.Drawing.Point(5, 5);
            this.TxtDuracion.Name = "TxtDuracion";
            this.TxtDuracion.Size = new System.Drawing.Size(195, 22);
            this.TxtDuracion.TabIndex = 12;
            // 
            // PanelDirector
            // 
            this.PanelDirector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.PanelDirector.Controls.Add(this.TxtDirector);
            this.PanelDirector.Location = new System.Drawing.Point(33, 443);
            this.PanelDirector.Name = "PanelDirector";
            this.PanelDirector.Padding = new System.Windows.Forms.Padding(5);
            this.PanelDirector.Size = new System.Drawing.Size(205, 35);
            this.PanelDirector.TabIndex = 50;
            // 
            // TxtDirector
            // 
            this.TxtDirector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.TxtDirector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDirector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDirector.Enabled = false;
            this.TxtDirector.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDirector.ForeColor = System.Drawing.Color.White;
            this.TxtDirector.Location = new System.Drawing.Point(5, 5);
            this.TxtDirector.Name = "TxtDirector";
            this.TxtDirector.Size = new System.Drawing.Size(195, 22);
            this.TxtDirector.TabIndex = 12;
            // 
            // PanelFecha
            // 
            this.PanelFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.PanelFecha.Controls.Add(this.DtpFechaEstreno);
            this.PanelFecha.Location = new System.Drawing.Point(33, 365);
            this.PanelFecha.Name = "PanelFecha";
            this.PanelFecha.Padding = new System.Windows.Forms.Padding(5);
            this.PanelFecha.Size = new System.Drawing.Size(205, 35);
            this.PanelFecha.TabIndex = 51;
            // 
            // DtpFechaEstreno
            // 
            this.DtpFechaEstreno.Enabled = false;
            this.DtpFechaEstreno.Font = new System.Drawing.Font("Palatino Linotype", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaEstreno.Location = new System.Drawing.Point(8, 8);
            this.DtpFechaEstreno.Name = "DtpFechaEstreno";
            this.DtpFechaEstreno.Size = new System.Drawing.Size(192, 20);
            this.DtpFechaEstreno.TabIndex = 0;
            // 
            // PanelUsuario
            // 
            this.PanelUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.PanelUsuario.Controls.Add(this.TxtNombre);
            this.PanelUsuario.Location = new System.Drawing.Point(33, 293);
            this.PanelUsuario.Name = "PanelUsuario";
            this.PanelUsuario.Padding = new System.Windows.Forms.Padding(5);
            this.PanelUsuario.Size = new System.Drawing.Size(205, 35);
            this.PanelUsuario.TabIndex = 48;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.Color.White;
            this.TxtNombre.Location = new System.Drawing.Point(5, 5);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(195, 22);
            this.TxtNombre.TabIndex = 12;
            // 
            // DataGridPeliculas
            // 
            this.DataGridPeliculas.AllowUserToAddRows = false;
            this.DataGridPeliculas.AllowUserToDeleteRows = false;
            this.DataGridPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPeliculas.ContextMenuStrip = this.CtxMenuModificar;
            this.DataGridPeliculas.Location = new System.Drawing.Point(34, 110);
            this.DataGridPeliculas.Name = "DataGridPeliculas";
            this.DataGridPeliculas.ReadOnly = true;
            this.DataGridPeliculas.Size = new System.Drawing.Size(878, 165);
            this.DataGridPeliculas.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(34, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Ingrese el nombre de la película";
            // 
            // BtnBuscarPelicula
            // 
            this.BtnBuscarPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.BtnBuscarPelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarPelicula.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarPelicula.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarPelicula.Location = new System.Drawing.Point(273, 58);
            this.BtnBuscarPelicula.Name = "BtnBuscarPelicula";
            this.BtnBuscarPelicula.Size = new System.Drawing.Size(205, 35);
            this.BtnBuscarPelicula.TabIndex = 45;
            this.BtnBuscarPelicula.Text = "Buscar";
            this.BtnBuscarPelicula.UseVisualStyleBackColor = false;
            this.BtnBuscarPelicula.Click += new System.EventHandler(this.BtnBuscarPelicula_Click_1);
            // 
            // PanelBuscarPeliculaNombre
            // 
            this.PanelBuscarPeliculaNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.PanelBuscarPeliculaNombre.Controls.Add(this.TxtBuscarNombrePelicula);
            this.PanelBuscarPeliculaNombre.Location = new System.Drawing.Point(34, 58);
            this.PanelBuscarPeliculaNombre.Name = "PanelBuscarPeliculaNombre";
            this.PanelBuscarPeliculaNombre.Padding = new System.Windows.Forms.Padding(5);
            this.PanelBuscarPeliculaNombre.Size = new System.Drawing.Size(205, 35);
            this.PanelBuscarPeliculaNombre.TabIndex = 44;
            this.PanelBuscarPeliculaNombre.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBuscarPeliculaNombre_Paint);
            // 
            // TxtBuscarNombrePelicula
            // 
            this.TxtBuscarNombrePelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.TxtBuscarNombrePelicula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscarNombrePelicula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBuscarNombrePelicula.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarNombrePelicula.ForeColor = System.Drawing.Color.White;
            this.TxtBuscarNombrePelicula.Location = new System.Drawing.Point(5, 5);
            this.TxtBuscarNombrePelicula.Name = "TxtBuscarNombrePelicula";
            this.TxtBuscarNombrePelicula.Size = new System.Drawing.Size(195, 22);
            this.TxtBuscarNombrePelicula.TabIndex = 12;
            // 
            // FormActualizarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(933, 615);
            this.Controls.Add(this.PanelMain);
            this.Name = "FormActualizarPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormActualizarPelicula";
            this.CtxMenuModificar.ResumeLayout(false);
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.PanelDescripcion.ResumeLayout(false);
            this.PanelDescripcion.PerformLayout();
            this.PanelImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicPelicula)).EndInit();
            this.PanelDuracion.ResumeLayout(false);
            this.PanelDuracion.PerformLayout();
            this.PanelDirector.ResumeLayout(false);
            this.PanelDirector.PerformLayout();
            this.PanelFecha.ResumeLayout(false);
            this.PanelUsuario.ResumeLayout(false);
            this.PanelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPeliculas)).EndInit();
            this.PanelBuscarPeliculaNombre.ResumeLayout(false);
            this.PanelBuscarPeliculaNombre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip CtxMenuModificar;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuSubModificar;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel PanelDescripcion;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Panel PanelImagen;
        private System.Windows.Forms.PictureBox PicPelicula;
        private System.Windows.Forms.Panel PanelDuracion;
        private System.Windows.Forms.TextBox TxtDuracion;
        private System.Windows.Forms.Panel PanelDirector;
        private System.Windows.Forms.TextBox TxtDirector;
        private System.Windows.Forms.Panel PanelFecha;
        private System.Windows.Forms.DateTimePicker DtpFechaEstreno;
        private System.Windows.Forms.Panel PanelUsuario;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.DataGridView DataGridPeliculas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnBuscarPelicula;
        private System.Windows.Forms.Panel PanelBuscarPeliculaNombre;
        private System.Windows.Forms.TextBox TxtBuscarNombrePelicula;
    }
}