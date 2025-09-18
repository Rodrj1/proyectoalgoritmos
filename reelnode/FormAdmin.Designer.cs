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
            this.ToolStpSubMenuCargarPeliculas = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStpSubMenuListarPeliculas = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStpMenuActualizarPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStpMenuSeries = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataGridPeliculas = new System.Windows.Forms.DataGridView();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPeliculas)).BeginInit();
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
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.ToolStpMenuPeliculas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStpSubMenuCargarPeliculas,
            this.ToolStpSubMenuListarPeliculas,
            this.ToolStpMenuActualizarPelicula});
            this.ToolStpMenuPeliculas.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStpMenuPeliculas.Name = "ToolStpMenuPeliculas";
            this.ToolStpMenuPeliculas.Size = new System.Drawing.Size(135, 22);
            this.ToolStpMenuPeliculas.Text = "Gestionar Peliculas";
            // 
            // ToolStpSubMenuCargarPeliculas
            // 
            this.ToolStpSubMenuCargarPeliculas.Name = "ToolStpSubMenuCargarPeliculas";
            this.ToolStpSubMenuCargarPeliculas.Size = new System.Drawing.Size(190, 22);
            this.ToolStpSubMenuCargarPeliculas.Text = "Cargar Pelicula";
            this.ToolStpSubMenuCargarPeliculas.Click += new System.EventHandler(this.ToolStpSubMenuCargarPeliculas_Click);
            // 
            // ToolStpSubMenuListarPeliculas
            // 
            this.ToolStpSubMenuListarPeliculas.Name = "ToolStpSubMenuListarPeliculas";
            this.ToolStpSubMenuListarPeliculas.Size = new System.Drawing.Size(190, 22);
            this.ToolStpSubMenuListarPeliculas.Text = "Listar Peliculas";
            this.ToolStpSubMenuListarPeliculas.Click += new System.EventHandler(this.ToolStpSubMenuListarPeliculas_Click);
            // 
            // ToolStpMenuActualizarPelicula
            // 
            this.ToolStpMenuActualizarPelicula.Name = "ToolStpMenuActualizarPelicula";
            this.ToolStpMenuActualizarPelicula.Size = new System.Drawing.Size(190, 22);
            this.ToolStpMenuActualizarPelicula.Text = "Actualizar Pelicula";
            this.ToolStpMenuActualizarPelicula.Click += new System.EventHandler(this.ToolStpMenuActualizarPelicula_Click);
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
            this.cerrarProgramaToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarProgramaToolStripMenuItem.Name = "cerrarProgramaToolStripMenuItem";
            this.cerrarProgramaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.cerrarProgramaToolStripMenuItem.Text = "Cerrar Programa";
            this.cerrarProgramaToolStripMenuItem.Click += new System.EventHandler(this.cerrarProgramaToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.DataGridPeliculas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 436);
            this.panel2.TabIndex = 2;
            // 
            // DataGridPeliculas
            // 
            this.DataGridPeliculas.AllowUserToAddRows = false;
            this.DataGridPeliculas.AllowUserToDeleteRows = false;
            this.DataGridPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPeliculas.Location = new System.Drawing.Point(33, 31);
            this.DataGridPeliculas.Name = "DataGridPeliculas";
            this.DataGridPeliculas.ReadOnly = true;
            this.DataGridPeliculas.Size = new System.Drawing.Size(846, 353);
            this.DataGridPeliculas.TabIndex = 0;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 462);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPeliculas)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem cerrarProgramaToolStripMenuItem;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.ToolStripMenuItem ToolStpSubMenuCargarPeliculas;
        private System.Windows.Forms.ToolStripMenuItem ToolStpSubMenuListarPeliculas;
        private System.Windows.Forms.DataGridView DataGridPeliculas;
        private System.Windows.Forms.ToolStripMenuItem ToolStpMenuActualizarPelicula;
    }
}