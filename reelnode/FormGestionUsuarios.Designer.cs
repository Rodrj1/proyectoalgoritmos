namespace ProjectoNuevo
{
    partial class FormGestionUsuarios
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
            this.DataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.CtxMenuModificarRol = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.RbtAdmin = new System.Windows.Forms.RadioButton();
            this.RbtUsuario = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUsuarios)).BeginInit();
            this.CtxMenuModificarRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridUsuarios
            // 
            this.DataGridUsuarios.AllowUserToAddRows = false;
            this.DataGridUsuarios.AllowUserToDeleteRows = false;
            this.DataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridUsuarios.ContextMenuStrip = this.CtxMenuModificarRol;
            this.DataGridUsuarios.Location = new System.Drawing.Point(45, 55);
            this.DataGridUsuarios.Name = "DataGridUsuarios";
            this.DataGridUsuarios.ReadOnly = true;
            this.DataGridUsuarios.Size = new System.Drawing.Size(707, 259);
            this.DataGridUsuarios.TabIndex = 1;
            // 
            // CtxMenuModificarRol
            // 
            this.CtxMenuModificarRol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem});
            this.CtxMenuModificarRol.Name = "CtxMenuModificarRol";
            this.CtxMenuModificarRol.Size = new System.Drawing.Size(126, 26);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Location = new System.Drawing.Point(45, 341);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(102, 38);
            this.BtnConfirmar.TabIndex = 2;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // RbtAdmin
            // 
            this.RbtAdmin.AutoSize = true;
            this.RbtAdmin.Location = new System.Drawing.Point(251, 341);
            this.RbtAdmin.Name = "RbtAdmin";
            this.RbtAdmin.Size = new System.Drawing.Size(54, 17);
            this.RbtAdmin.TabIndex = 3;
            this.RbtAdmin.TabStop = true;
            this.RbtAdmin.Text = "Admin";
            this.RbtAdmin.UseVisualStyleBackColor = true;
            // 
            // RbtUsuario
            // 
            this.RbtUsuario.AutoSize = true;
            this.RbtUsuario.Location = new System.Drawing.Point(342, 341);
            this.RbtUsuario.Name = "RbtUsuario";
            this.RbtUsuario.Size = new System.Drawing.Size(61, 17);
            this.RbtUsuario.TabIndex = 4;
            this.RbtUsuario.TabStop = true;
            this.RbtUsuario.Text = "Usuario";
            this.RbtUsuario.UseVisualStyleBackColor = true;
            // 
            // FormGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RbtUsuario);
            this.Controls.Add(this.RbtAdmin);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.DataGridUsuarios);
            this.Name = "FormGestionUsuarios";
            this.Text = "FormGestionUsuarios";
            this.Load += new System.EventHandler(this.FormGestionUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUsuarios)).EndInit();
            this.CtxMenuModificarRol.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridUsuarios;
        private System.Windows.Forms.ContextMenuStrip CtxMenuModificarRol;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.RadioButton RbtAdmin;
        private System.Windows.Forms.RadioButton RbtUsuario;
    }
}