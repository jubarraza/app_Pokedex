namespace App_Pokemon
{
    partial class frmAltaPokemon
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
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.cb_Tipo = new System.Windows.Forms.ComboBox();
            this.cb_Debilidad = new System.Windows.Forms.ComboBox();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.lbl_Debilidad = new System.Windows.Forms.Label();
            this.txt_Url = new System.Windows.Forms.TextBox();
            this.lbl_UrlImagen = new System.Windows.Forms.Label();
            this.pb_CargaImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CargaImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero.Location = new System.Drawing.Point(103, 40);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(92, 25);
            this.lbl_Numero.TabIndex = 0;
            this.lbl_Numero.Text = "Numero: ";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(103, 79);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(92, 25);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "Nombre: ";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.Location = new System.Drawing.Point(70, 132);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(125, 25);
            this.lbl_Descripcion.TabIndex = 2;
            this.lbl_Descripcion.Text = "Descripcion: ";
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(219, 40);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(135, 22);
            this.txt_Numero.TabIndex = 0;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(219, 82);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(260, 22);
            this.txt_Nombre.TabIndex = 1;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(219, 132);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(260, 118);
            this.txt_Descripcion.TabIndex = 2;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(148, 447);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(164, 37);
            this.btn_Aceptar.TabIndex = 6;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(356, 447);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(164, 37);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // cb_Tipo
            // 
            this.cb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Tipo.FormattingEnabled = true;
            this.cb_Tipo.Location = new System.Drawing.Point(218, 324);
            this.cb_Tipo.Name = "cb_Tipo";
            this.cb_Tipo.Size = new System.Drawing.Size(261, 24);
            this.cb_Tipo.TabIndex = 4;
            // 
            // cb_Debilidad
            // 
            this.cb_Debilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Debilidad.FormattingEnabled = true;
            this.cb_Debilidad.Location = new System.Drawing.Point(218, 371);
            this.cb_Debilidad.Name = "cb_Debilidad";
            this.cb_Debilidad.Size = new System.Drawing.Size(261, 24);
            this.cb_Debilidad.TabIndex = 5;
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tipo.Location = new System.Drawing.Point(128, 325);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(62, 25);
            this.lbl_Tipo.TabIndex = 10;
            this.lbl_Tipo.Text = "Tipo: ";
            // 
            // lbl_Debilidad
            // 
            this.lbl_Debilidad.AutoSize = true;
            this.lbl_Debilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Debilidad.Location = new System.Drawing.Point(91, 370);
            this.lbl_Debilidad.Name = "lbl_Debilidad";
            this.lbl_Debilidad.Size = new System.Drawing.Size(99, 25);
            this.lbl_Debilidad.TabIndex = 11;
            this.lbl_Debilidad.Text = "Debilidad:";
            // 
            // txt_Url
            // 
            this.txt_Url.Location = new System.Drawing.Point(219, 280);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(260, 22);
            this.txt_Url.TabIndex = 3;
            this.txt_Url.Leave += new System.EventHandler(this.txt_Url_Leave);
            // 
            // lbl_UrlImagen
            // 
            this.lbl_UrlImagen.AutoSize = true;
            this.lbl_UrlImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UrlImagen.Location = new System.Drawing.Point(64, 277);
            this.lbl_UrlImagen.Name = "lbl_UrlImagen";
            this.lbl_UrlImagen.Size = new System.Drawing.Size(126, 25);
            this.lbl_UrlImagen.TabIndex = 12;
            this.lbl_UrlImagen.Text = "URL Imagen:";
            // 
            // pb_CargaImagen
            // 
            this.pb_CargaImagen.Location = new System.Drawing.Point(522, 82);
            this.pb_CargaImagen.Name = "pb_CargaImagen";
            this.pb_CargaImagen.Size = new System.Drawing.Size(366, 313);
            this.pb_CargaImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_CargaImagen.TabIndex = 14;
            this.pb_CargaImagen.TabStop = false;
            // 
            // frmAltaPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 529);
            this.Controls.Add(this.pb_CargaImagen);
            this.Controls.Add(this.txt_Url);
            this.Controls.Add(this.lbl_UrlImagen);
            this.Controls.Add(this.lbl_Debilidad);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.cb_Debilidad);
            this.Controls.Add(this.cb_Tipo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Numero);
            this.Name = "frmAltaPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Pokemon";
            this.Load += new System.EventHandler(this.frmAltaPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_CargaImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ComboBox cb_Tipo;
        private System.Windows.Forms.ComboBox cb_Debilidad;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.Label lbl_Debilidad;
        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.Label lbl_UrlImagen;
        private System.Windows.Forms.PictureBox pb_CargaImagen;
    }
}