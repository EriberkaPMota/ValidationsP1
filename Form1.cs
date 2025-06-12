using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ValidationsP1.GestionProductosDBDataSet;

namespace ValidationsP1
{
    public partial class Form1 : Form
    {
        public readonly Funtionalities viewFuntionalities = new Funtionalities();
            
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {            

            viewFuntionalities.CargarYFiltrarActivos(gestionProductosDBDataSet.Categorias, categoriasBindingSource, categoriasTableAdapter);
            viewFuntionalities.CargarYFiltrarActivos(gestionProductosDBDataSet.Productos, productosBindingSource, productosTableAdapter);
            viewFuntionalities.CargarYFiltrarActivos(gestionProductosDBDataSet.FotosCategoria, fotosCategoriaBindingSource, fotosCategoriaTableAdapter);
            viewFuntionalities.CargarYFiltrarActivos(gestionProductosDBDataSet.Suplidores, suplidoresBindingSource, suplidoresTableAdapter);

            this.productosTableAdapter.Fill(this.gestionProductosDBDataSet.Productos);
            this.fotosCategoriaTableAdapter.Fill(this.gestionProductosDBDataSet.FotosCategoria);
            this.suplidoresTableAdapter.Fill(this.gestionProductosDBDataSet.Suplidores);
            this.suplidoresTableAdapter.Fill(this.gestionProductosDBDataSet.Suplidores);
            this.categoriasTableAdapter.Fill(this.gestionProductosDBDataSet.Categorias);
        }

               


        private void Save_Click(object sender, EventArgs e)
        {
            viewFuntionalities.GuardarProductos(gestionProductosDBDataSet, productosBindingSource, tableAdapterManager);
        }

        private void saveCate(object sender, EventArgs e)
        {
           viewFuntionalities.GuardarCategorias(gestionProductosDBDataSet, categoriasBindingSource, tableAdapterManager);
        }



        private void saveSupli(object sender, EventArgs e)
        {
            viewFuntionalities.GuardarSuplidores(gestionProductosDBDataSet, suplidoresBindingSource, tableAdapterManager);
            string correo = correoTextBox.Text;
           
            if (!viewFuntionalities.EsCorreoValido(correo))
            {
                MessageBox.Show("El correo electrónico no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                correoTextBox.Focus();
                return;
            }
        }

        private void saveCata(object sender, EventArgs e)
        {
            viewFuntionalities.GuardarFotosCategoria(gestionProductosDBDataSet, fotosCategoriaBindingSource, tableAdapterManager);
        }   
      

        private void añadirProdu(object sender, EventArgs e)
        {
            viewFuntionalities.AgregarFilaNueva(productosBindingSource, nombreProductoTextBox);
        }

        private void AddCategoria(object sender, EventArgs e)
        {
            viewFuntionalities.AgregarFilaNueva(categoriasBindingSource, nombreCategoriaTextBox);
        
        }

        private void categoriasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       
        private void BorrarCategoria(object sender, EventArgs e)
        {
            viewFuntionalities.BorradoLogico(
            categoriasDataGridView, categoriasBindingSource,
            tableAdapterManager, nombreCategoriaTextBox,  
            () => categoriasTableAdapter.Fill(gestionProductosDBDataSet.Categorias)
            );
                       
        }

        private void eliminarProdu_Click(object sender, EventArgs e)
        {
            viewFuntionalities.BorradoLogico(
            productosDataGridView, productosBindingSource,
            tableAdapterManager, nombreProductoTextBox,
            () => productosTableAdapter.Fill(gestionProductosDBDataSet.Productos)
            );
        }

        private void añadirSupli(object sender, EventArgs e)
        {
            viewFuntionalities.AgregarFilaNueva(suplidoresBindingSource, nombreEmpresaTextBox);
        }

        private void añadirCata_Click(object sender, EventArgs e)
        {
            viewFuntionalities.AgregarFilaNueva(fotosCategoriaBindingSource, categoriaIDTextBox);
        }

        private void eliminarCata_Click(object sender, EventArgs e)
        {
            viewFuntionalities.BorradoLogico(
            fotosCategoriaDataGridView, fotosCategoriaBindingSource,
            tableAdapterManager, categoriaIDTextBox,
            () => fotosCategoriaTableAdapter.Fill(gestionProductosDBDataSet.FotosCategoria)
            );
        }

        private void eliminarSupli_Click(object sender, EventArgs e)
        {
            viewFuntionalities.BorradoLogico(
            suplidoresDataGridView, suplidoresBindingSource,
            tableAdapterManager, nombreEmpresaTextBox,
            () => suplidoresTableAdapter.Fill(gestionProductosDBDataSet.Suplidores)
            );
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            viewFuntionalities.CargarFotos(this);
            
        }
    }
}
