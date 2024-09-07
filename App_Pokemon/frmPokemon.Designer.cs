namespace App_Pokemon
{
    partial class frmPokemon
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
            this.dgvPokemon = new System.Windows.Forms.DataGridView();
            this.pbPokemon = new System.Windows.Forms.PictureBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_EliminarLogico = new System.Windows.Forms.Button();
            this.lbl_Restaurar = new System.Windows.Forms.Button();
            this.lbl_Filtro = new System.Windows.Forms.Label();
            this.txt_Buscador = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_FiltroAv = new System.Windows.Forms.TextBox();
            this.lbl_FiltroAv = new System.Windows.Forms.Label();
            this.lbl_CampoFiltro = new System.Windows.Forms.Label();
            this.lbl_Criterio = new System.Windows.Forms.Label();
            this.cb_Campo = new System.Windows.Forms.ComboBox();
            this.cb_Criterio = new System.Windows.Forms.ComboBox();
            this.gp_GrupoFiltro = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).BeginInit();
            this.gp_GrupoFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPokemon
            // 
            this.dgvPokemon.AllowUserToAddRows = false;
            this.dgvPokemon.AllowUserToDeleteRows = false;
            this.dgvPokemon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPokemon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPokemon.Location = new System.Drawing.Point(415, 149);
            this.dgvPokemon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPokemon.MultiSelect = false;
            this.dgvPokemon.Name = "dgvPokemon";
            this.dgvPokemon.ReadOnly = true;
            this.dgvPokemon.RowHeadersWidth = 51;
            this.dgvPokemon.RowTemplate.Height = 24;
            this.dgvPokemon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokemon.Size = new System.Drawing.Size(631, 233);
            this.dgvPokemon.TabIndex = 0;
            this.dgvPokemon.SelectionChanged += new System.EventHandler(this.dgvPokemon_SelectionChanged);
            // 
            // pbPokemon
            // 
            this.pbPokemon.Location = new System.Drawing.Point(23, 117);
            this.pbPokemon.Name = "pbPokemon";
            this.pbPokemon.Size = new System.Drawing.Size(354, 337);
            this.pbPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPokemon.TabIndex = 1;
            this.pbPokemon.TabStop = false;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(76, 25);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(188, 41);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "Mi PokeDex";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Agregar.Location = new System.Drawing.Point(547, 451);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(156, 33);
            this.btn_Agregar.TabIndex = 3;
            this.btn_Agregar.Text = "Agregar Pokemon";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_Modificar.Location = new System.Drawing.Point(547, 490);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(156, 33);
            this.btn_Modificar.TabIndex = 4;
            this.btn_Modificar.Text = "Modificar Pokemon";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Eliminar.Location = new System.Drawing.Point(871, 451);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(156, 33);
            this.btn_Eliminar.TabIndex = 5;
            this.btn_Eliminar.Text = "Eliminar F Pokemon";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_EliminarLogico
            // 
            this.btn_EliminarLogico.BackColor = System.Drawing.Color.LightCoral;
            this.btn_EliminarLogico.Location = new System.Drawing.Point(709, 451);
            this.btn_EliminarLogico.Name = "btn_EliminarLogico";
            this.btn_EliminarLogico.Size = new System.Drawing.Size(156, 33);
            this.btn_EliminarLogico.TabIndex = 6;
            this.btn_EliminarLogico.Text = "Eliminar L Pokemon";
            this.btn_EliminarLogico.UseVisualStyleBackColor = false;
            this.btn_EliminarLogico.Click += new System.EventHandler(this.btn_EliminarLogico_Click);
            // 
            // lbl_Restaurar
            // 
            this.lbl_Restaurar.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_Restaurar.Location = new System.Drawing.Point(709, 490);
            this.lbl_Restaurar.Name = "lbl_Restaurar";
            this.lbl_Restaurar.Size = new System.Drawing.Size(156, 33);
            this.lbl_Restaurar.TabIndex = 7;
            this.lbl_Restaurar.Text = "Restaurar Pokemon";
            this.lbl_Restaurar.UseVisualStyleBackColor = false;
            this.lbl_Restaurar.Click += new System.EventHandler(this.lbl_Restaurar_Click);
            // 
            // lbl_Filtro
            // 
            this.lbl_Filtro.AutoSize = true;
            this.lbl_Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Filtro.Location = new System.Drawing.Point(429, 400);
            this.lbl_Filtro.Name = "lbl_Filtro";
            this.lbl_Filtro.Size = new System.Drawing.Size(98, 20);
            this.lbl_Filtro.TabIndex = 8;
            this.lbl_Filtro.Text = "Filtro rapido";
            // 
            // txt_Buscador
            // 
            this.txt_Buscador.Location = new System.Drawing.Point(533, 398);
            this.txt_Buscador.Name = "txt_Buscador";
            this.txt_Buscador.Size = new System.Drawing.Size(230, 24);
            this.txt_Buscador.TabIndex = 9;
            this.txt_Buscador.TextChanged += new System.EventHandler(this.txt_Buscador_TextChanged);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(856, 89);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(156, 31);
            this.btn_Buscar.TabIndex = 10;
            this.btn_Buscar.Text = "Busqueda";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_FiltroAv
            // 
            this.txt_FiltroAv.Location = new System.Drawing.Point(450, 16);
            this.txt_FiltroAv.Name = "txt_FiltroAv";
            this.txt_FiltroAv.Size = new System.Drawing.Size(116, 24);
            this.txt_FiltroAv.TabIndex = 12;
            // 
            // lbl_FiltroAv
            // 
            this.lbl_FiltroAv.AutoSize = true;
            this.lbl_FiltroAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FiltroAv.Location = new System.Drawing.Point(398, 17);
            this.lbl_FiltroAv.Name = "lbl_FiltroAv";
            this.lbl_FiltroAv.Size = new System.Drawing.Size(47, 20);
            this.lbl_FiltroAv.TabIndex = 11;
            this.lbl_FiltroAv.Text = "Filtro";
            // 
            // lbl_CampoFiltro
            // 
            this.lbl_CampoFiltro.AutoSize = true;
            this.lbl_CampoFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CampoFiltro.Location = new System.Drawing.Point(10, 19);
            this.lbl_CampoFiltro.Name = "lbl_CampoFiltro";
            this.lbl_CampoFiltro.Size = new System.Drawing.Size(62, 20);
            this.lbl_CampoFiltro.TabIndex = 13;
            this.lbl_CampoFiltro.Text = "Campo";
            // 
            // lbl_Criterio
            // 
            this.lbl_Criterio.AutoSize = true;
            this.lbl_Criterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Criterio.Location = new System.Drawing.Point(206, 17);
            this.lbl_Criterio.Name = "lbl_Criterio";
            this.lbl_Criterio.Size = new System.Drawing.Size(64, 20);
            this.lbl_Criterio.TabIndex = 14;
            this.lbl_Criterio.Text = "Criterio";
            // 
            // cb_Campo
            // 
            this.cb_Campo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Campo.FormattingEnabled = true;
            this.cb_Campo.Location = new System.Drawing.Point(78, 15);
            this.cb_Campo.Name = "cb_Campo";
            this.cb_Campo.Size = new System.Drawing.Size(115, 26);
            this.cb_Campo.TabIndex = 15;
            this.cb_Campo.SelectedIndexChanged += new System.EventHandler(this.cb_Campo_SelectedIndexChanged);
            // 
            // cb_Criterio
            // 
            this.cb_Criterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Criterio.FormattingEnabled = true;
            this.cb_Criterio.Location = new System.Drawing.Point(269, 15);
            this.cb_Criterio.Name = "cb_Criterio";
            this.cb_Criterio.Size = new System.Drawing.Size(123, 26);
            this.cb_Criterio.TabIndex = 16;
            // 
            // gp_GrupoFiltro
            // 
            this.gp_GrupoFiltro.Controls.Add(this.cb_Criterio);
            this.gp_GrupoFiltro.Controls.Add(this.cb_Campo);
            this.gp_GrupoFiltro.Controls.Add(this.lbl_Criterio);
            this.gp_GrupoFiltro.Controls.Add(this.lbl_CampoFiltro);
            this.gp_GrupoFiltro.Controls.Add(this.txt_FiltroAv);
            this.gp_GrupoFiltro.Controls.Add(this.lbl_FiltroAv);
            this.gp_GrupoFiltro.Location = new System.Drawing.Point(433, 25);
            this.gp_GrupoFiltro.Name = "gp_GrupoFiltro";
            this.gp_GrupoFiltro.Size = new System.Drawing.Size(579, 58);
            this.gp_GrupoFiltro.TabIndex = 17;
            this.gp_GrupoFiltro.TabStop = false;
            this.gp_GrupoFiltro.Text = "Filtros";
            // 
            // frmPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1058, 548);
            this.Controls.Add(this.gp_GrupoFiltro);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_Buscador);
            this.Controls.Add(this.lbl_Filtro);
            this.Controls.Add(this.lbl_Restaurar);
            this.Controls.Add(this.btn_EliminarLogico);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pbPokemon);
            this.Controls.Add(this.dgvPokemon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokeDex";
            this.Load += new System.EventHandler(this.frmPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).EndInit();
            this.gp_GrupoFiltro.ResumeLayout(false);
            this.gp_GrupoFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokemon;
        private System.Windows.Forms.PictureBox pbPokemon;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_EliminarLogico;
        private System.Windows.Forms.Button lbl_Restaurar;
        private System.Windows.Forms.Label lbl_Filtro;
        private System.Windows.Forms.TextBox txt_Buscador;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_FiltroAv;
        private System.Windows.Forms.Label lbl_FiltroAv;
        private System.Windows.Forms.Label lbl_CampoFiltro;
        private System.Windows.Forms.Label lbl_Criterio;
        private System.Windows.Forms.ComboBox cb_Campo;
        private System.Windows.Forms.ComboBox cb_Criterio;
        private System.Windows.Forms.GroupBox gp_GrupoFiltro;
    }
}

