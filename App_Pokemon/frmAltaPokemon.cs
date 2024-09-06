using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Pokemon
{
    public partial class frmAltaPokemon : Form
    {
        public frmAltaPokemon()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Pokemon aux = new Pokemon();
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                aux.Numero = int.Parse(txt_Numero.Text);
                aux.Nombre = txt_Nombre.Text;
                aux.Descripcion = txt_Descripcion.Text;
                aux.UrlImagen = txt_Url.Text; 
                aux.Tipo = (Elemento)cb_Tipo.SelectedItem;
                aux.Debilidad = (Elemento)cb_Debilidad.SelectedItem;

                negocio.Agregar(aux);
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                cb_Tipo.DataSource = elementoNegocio.listar();
                cb_Debilidad.DataSource = elementoNegocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pb_CargaImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pb_CargaImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWz9tftw9qculFH1gxieWkxL6rbRk_hrXTSg&s");
            }

        }

        private void txt_Url_Leave(object sender, EventArgs e)
        {
            try
            {
                CargarImagen(txt_Url.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
