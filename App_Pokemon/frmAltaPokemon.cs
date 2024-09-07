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
        private Pokemon pokemon = null;
        public frmAltaPokemon()
        {
            InitializeComponent();

        }

        public frmAltaPokemon(Pokemon poke)
        {
            InitializeComponent();
            this.pokemon = poke;
            Text = "Modificar Pokemon";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                if(pokemon == null) 
                    pokemon = new Pokemon();

                pokemon.Numero = int.Parse(txt_Numero.Text);
                pokemon.Nombre = txt_Nombre.Text;
                pokemon.Descripcion = txt_Descripcion.Text;
                pokemon.UrlImagen = txt_Url.Text; 
                pokemon.Tipo = (Elemento)cb_Tipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cb_Debilidad.SelectedItem;

                if(pokemon.Id == 0)
                {
                    negocio.Agregar(pokemon);
                    MessageBox.Show("Agregado exitosamente");
                }
                else
                {
                    negocio.Modificar(pokemon);
                    MessageBox.Show("Modificado exitosamente");
                }

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
                cb_Tipo.ValueMember = "Id";
                cb_Tipo.DisplayMember = "Descripcion";
                cb_Debilidad.DataSource = elementoNegocio.listar();
                cb_Debilidad.ValueMember = "Id";
                cb_Debilidad.DisplayMember = "Descripcion";

                if (pokemon != null)
                {
                    txt_Numero.Text = pokemon.Numero.ToString();
                    txt_Nombre.Text = pokemon.Nombre;
                    txt_Descripcion.Text = pokemon.Descripcion;
                    txt_Url.Text = pokemon.UrlImagen;
                    CargarImagen(pokemon.UrlImagen);
                    cb_Tipo.SelectedValue = pokemon.Tipo.ID;
                    cb_Debilidad.SelectedValue = pokemon.Debilidad.ID;


                }
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
