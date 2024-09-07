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
    public partial class frmPokemonEliminados : Form
    {
        private List<Pokemon> listaPokemon;
        public frmPokemonEliminados()
        {
            InitializeComponent();
        }

        private void frmPokemonEliminados_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void ocultarColumnas()
        {
            dgv_Eliminados.Columns["UrlImagen"].Visible = false;
            dgv_Eliminados.Columns["Id"].Visible = false;
        }
        private void CargarImagen(string imagen)
        {
            if (string.IsNullOrEmpty(imagen))
            {
                pb_Img.Image = null; // Limpia el PictureBox si la URL de la imagen es nula o vacía
                return;
            }
            try
            {
                pb_Img.Load(imagen);
            }
            catch (Exception ex)
            {
                pb_Img.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWz9tftw9qculFH1gxieWkxL6rbRk_hrXTSg&s");
            }


        }
        private void Cargar()
        {
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                listaPokemon = negocio.ListarEliminados();
                dgv_Eliminados.DataSource = listaPokemon;
                ocultarColumnas();
                if (listaPokemon.Count == 0)
                {
                    pb_Img.Image = null; // Limpia la imagen cuando no hay más Pokémon
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            PokemonNegocio pkmNegocio = new PokemonNegocio();

            try
            {

                Pokemon seleccionado = (Pokemon)dgv_Eliminados.CurrentRow.DataBoundItem;
                pkmNegocio.RestaurarEliminado(seleccionado);

                Cargar();
                
                if (listaPokemon.Count == 0)
                {
                    pb_Img.Image = null;
                }
                else
                {
                    CargarImagen(listaPokemon[0].UrlImagen);
                }

            }
            catch (NullReferenceException exc)
            {
                MessageBox.Show("No hay Pokemon para restaurar", "Atencion");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void dgv_Eliminados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Eliminados.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dgv_Eliminados.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.UrlImagen);
            }

        }
    }
}
