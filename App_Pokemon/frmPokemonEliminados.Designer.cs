namespace App_Pokemon
{
    partial class frmPokemonEliminados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPokemonEliminados));
            this.dgv_Eliminados = new System.Windows.Forms.DataGridView();
            this.pb_Img = new System.Windows.Forms.PictureBox();
            this.btn_Restaurar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Eliminados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Eliminados
            // 
            this.dgv_Eliminados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Eliminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Eliminados.Location = new System.Drawing.Point(27, 90);
            this.dgv_Eliminados.Name = "dgv_Eliminados";
            this.dgv_Eliminados.RowHeadersWidth = 51;
            this.dgv_Eliminados.RowTemplate.Height = 24;
            this.dgv_Eliminados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Eliminados.Size = new System.Drawing.Size(499, 241);
            this.dgv_Eliminados.TabIndex = 0;
            this.dgv_Eliminados.SelectionChanged += new System.EventHandler(this.dgv_Eliminados_SelectionChanged);
            // 
            // pb_Img
            // 
            this.pb_Img.Location = new System.Drawing.Point(532, 69);
            this.pb_Img.Name = "pb_Img";
            this.pb_Img.Size = new System.Drawing.Size(338, 296);
            this.pb_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Img.TabIndex = 1;
            this.pb_Img.TabStop = false;
            // 
            // btn_Restaurar
            // 
            this.btn_Restaurar.Location = new System.Drawing.Point(263, 355);
            this.btn_Restaurar.Name = "btn_Restaurar";
            this.btn_Restaurar.Size = new System.Drawing.Size(120, 34);
            this.btn_Restaurar.TabIndex = 2;
            this.btn_Restaurar.Text = "Restaurar";
            this.btn_Restaurar.UseVisualStyleBackColor = true;
            this.btn_Restaurar.Click += new System.EventHandler(this.btn_Restaurar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(406, 355);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(120, 34);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // frmPokemonEliminados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(892, 466);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Restaurar);
            this.Controls.Add(this.pb_Img);
            this.Controls.Add(this.dgv_Eliminados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPokemonEliminados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemon Eliminados";
            this.Load += new System.EventHandler(this.frmPokemonEliminados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Eliminados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Eliminados;
        private System.Windows.Forms.PictureBox pb_Img;
        private System.Windows.Forms.Button btn_Restaurar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}