using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace App_Pokemon
{
    public partial class frmPokemon : Form
    {
        private List<Pokemon> listaPokemon;
        public frmPokemon()
        {
            InitializeComponent();
        }

        private void frmPokemon_Load(object sender, EventArgs e)
        {
            Cargar();
            cb_Campo.Items.Add("Numero");
            cb_Campo.Items.Add("Nombre");
            cb_Campo.Items.Add("Descripcion");
            
        }

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvPokemon.CurrentRow != null)
            {
                pbPokemon.Visible = true;
                Pokemon seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.UrlImagen);
            }
            else
            {
                pbPokemon.Visible = false;
            }
        }

        private void CargarImagen(string imagen) 
        {
            try
            {
                pbPokemon.Load(imagen);
            }
            catch (Exception ex)
            {
               pbPokemon.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWz9tftw9qculFH1gxieWkxL6rbRk_hrXTSg&s");
            }
            

        }

        private void Cargar()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            
            try
            {
                listaPokemon = negocio.Listar();
                dgvPokemon.DataSource = listaPokemon;
                ocultarColumnas();
                //CargarImagen(listaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            frmAltaPokemon alta = new frmAltaPokemon();
            alta.ShowDialog();
            //actualizar la carga de la base de datos
            Cargar();

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado;
            seleccionado = (Pokemon) dgvPokemon.CurrentRow.DataBoundItem;


            frmAltaPokemon modificar = new frmAltaPokemon(seleccionado);
            modificar.ShowDialog();
            Cargar();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            
        }

        private void btn_EliminarLogico_Click(object sender, EventArgs e)
        {
            Eliminar(true);
        }

        private void Eliminar(bool logico = false)
        {
            PokemonNegocio pkmNegocio = new PokemonNegocio();
            Pokemon seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar el registro?", "Eliminar Pokemon", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;

                    if (!logico)
                    {
                        pkmNegocio.Eliminar(seleccionado.Id);
                    }
                    else 
                    {
                        pkmNegocio.EliminarLogico(seleccionado.Id);
                    }
                    Cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private bool ValidarFiltro()
        {
            if(cb_Campo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione el Campo para Buscar");
                return true; //no tiene campo
            }
            if (cb_Criterio.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione el Criterio para Buscar");
                return true; //no tiene criterio    
            }
            if(cb_Campo.SelectedItem.ToString() == "Numero")
            {
                if (string.IsNullOrEmpty(txt_FiltroAv.Text))
                {
                    MessageBox.Show("Se debe ingresar un valor a buscar");
                    return true; //no tiene criterio
                }
                if (!(SoloNumeros(txt_FiltroAv.Text)))
                {
                    MessageBox.Show("Solo se aceptan valores numericos");
                    return true; //no tiene criterio
                }

            }

            return false; //tiene algo seleccionado
        }

        private bool SoloNumeros(string valor)
        {
            foreach(char caracter in valor)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }

            return true;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            PokemonNegocio pokemonNegocio = new PokemonNegocio();
            try
            {
                if(ValidarFiltro()) {
                    return;
                }
                string campo = cb_Campo.SelectedItem.ToString();
                string criterio = cb_Criterio.SelectedItem.ToString();
                string filtro = txt_FiltroAv.Text;
                dgvPokemon.DataSource = pokemonNegocio.Filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void ocultarColumnas()
        {
            dgvPokemon.Columns["UrlImagen"].Visible = false;
            dgvPokemon.Columns["Id"].Visible = false;
        }

        private void lbl_Restaurar_Click(object sender, EventArgs e)
        {
            frmPokemonEliminados eliminados = new frmPokemonEliminados();
            eliminados.ShowDialog();
            Cargar();

        }

        private void txt_Buscador_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;
            string filtro = txt_Buscador.Text;

            if (filtro.Length >= 2)
            {
                listaFiltrada = listaPokemon.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.Tipo.Descripcion.ToLower().Contains(filtro.ToLower()));
            }
            else
            {
                listaFiltrada = listaPokemon;
            }

            dgvPokemon.DataSource = null;
            dgvPokemon.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cb_Campo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cb_Campo.SelectedItem.ToString();
            if(opcion == "Numero")
            {
                cb_Criterio.Items.Clear();
                cb_Criterio.Items.Add("Mayor a");
                cb_Criterio.Items.Add("Menor a");
                cb_Criterio.Items.Add("Igual a");
            }
            else
            {
                cb_Criterio.Items.Clear();
                cb_Criterio.Items.Add("Comienza con");
                cb_Criterio.Items.Add("Termina con");
                cb_Criterio.Items.Add("Contiene");
            }
        }
    }
}
