namespace ProyectoBiblioteca
{
    partial class FrmBiblioteca
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
            this.grpBoxLibros = new System.Windows.Forms.GroupBox();
            this.DgvLibros = new System.Windows.Forms.DataGridView();
            this.grpBoxDatos = new System.Windows.Forms.GroupBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtAnio = new System.Windows.Forms.TextBox();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpBoxLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibros)).BeginInit();
            this.grpBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxLibros
            // 
            this.grpBoxLibros.Controls.Add(this.DgvLibros);
            this.grpBoxLibros.Location = new System.Drawing.Point(12, 12);
            this.grpBoxLibros.Name = "grpBoxLibros";
            this.grpBoxLibros.Size = new System.Drawing.Size(510, 260);
            this.grpBoxLibros.TabIndex = 2;
            this.grpBoxLibros.TabStop = false;
            this.grpBoxLibros.Text = "Libros";
            // 
            // DgvLibros
            // 
            this.DgvLibros.AllowUserToAddRows = false;
            this.DgvLibros.AllowUserToDeleteRows = false;
            this.DgvLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvLibros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvLibros.Location = new System.Drawing.Point(6, 19);
            this.DgvLibros.MultiSelect = false;
            this.DgvLibros.Name = "DgvLibros";
            this.DgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLibros.Size = new System.Drawing.Size(498, 235);
            this.DgvLibros.TabIndex = 0;
            this.DgvLibros.SelectionChanged += new System.EventHandler(this.DgvLibros_SelectionChanged);
            // 
            // grpBoxDatos
            // 
            this.grpBoxDatos.Controls.Add(this.BtnEliminar);
            this.grpBoxDatos.Controls.Add(this.BtnCerrar);
            this.grpBoxDatos.Controls.Add(this.BtnLimpiar);
            this.grpBoxDatos.Controls.Add(this.BtnGuardar);
            this.grpBoxDatos.Controls.Add(this.TxtAnio);
            this.grpBoxDatos.Controls.Add(this.TxtAutor);
            this.grpBoxDatos.Controls.Add(this.TxtTitulo);
            this.grpBoxDatos.Controls.Add(this.lblAnio);
            this.grpBoxDatos.Controls.Add(this.lblAutor);
            this.grpBoxDatos.Controls.Add(this.lblTitulo);
            this.grpBoxDatos.Location = new System.Drawing.Point(12, 291);
            this.grpBoxDatos.Name = "grpBoxDatos";
            this.grpBoxDatos.Size = new System.Drawing.Size(510, 183);
            this.grpBoxDatos.TabIndex = 3;
            this.grpBoxDatos.TabStop = false;
            this.grpBoxDatos.Text = "Entrada de datos";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(257, 150);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(419, 151);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(338, 151);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 7;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(176, 150);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtAnio
            // 
            this.TxtAnio.Location = new System.Drawing.Point(6, 153);
            this.TxtAnio.Name = "TxtAnio";
            this.TxtAnio.Size = new System.Drawing.Size(100, 20);
            this.TxtAnio.TabIndex = 5;
            // 
            // TxtAutor
            // 
            this.TxtAutor.Location = new System.Drawing.Point(6, 97);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(488, 20);
            this.TxtAutor.TabIndex = 4;
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(6, 41);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(488, 20);
            this.TxtTitulo.TabIndex = 3;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(3, 137);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(98, 13);
            this.lblAnio.TabIndex = 2;
            this.lblAnio.Text = "Año de publicación";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(6, 81);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(6, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            // 
            // FrmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 481);
            this.Controls.Add(this.grpBoxLibros);
            this.Controls.Add(this.grpBoxDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBiblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.FrmBiblioteca_Load);
            this.grpBoxLibros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibros)).EndInit();
            this.grpBoxDatos.ResumeLayout(false);
            this.grpBoxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxLibros;
        private System.Windows.Forms.DataGridView DgvLibros;
        private System.Windows.Forms.GroupBox grpBoxDatos;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtAnio;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
    }
}

