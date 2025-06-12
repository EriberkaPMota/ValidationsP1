using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationsP1.GestionProductosDBDataSetTableAdapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;         
using System.Drawing;
using System.Text.RegularExpressions;

namespace ValidationsP1
{
   public  class Funtionalities
   {       
        public void CargarYFiltrarActivos(DataTable table, BindingSource bindingSource, object tableAdapter)
        {
            try
            {
                // Usar reflexión para llamar al método Fill del tableAdapter
                var fillMethod = tableAdapter.GetType().GetMethod("Fill");
                if (fillMethod != null)
                {
                    fillMethod.Invoke(tableAdapter, new object[] { table });
                }

                // Aplicar filtro si la tabla contiene columna "Activo"
                if (table.Columns.Contains("Activo"))
                {
                    bindingSource.Filter = "Activo = 1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al cargar los datos: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        public void GuardarCategorias(GestionProductosDBDataSet dataset, BindingSource bindingSource, TableAdapterManager tableAdapterManager)
        {
            // Finaliza edición de los datos vinculados
            bindingSource.EndEdit();

            foreach (DataRow row in dataset.Categorias.Rows)
            {
                if (row.RowState == DataRowState.Added)
                {
                    if (row["FechaCreacion"] == DBNull.Value)
                        row["FechaCreacion"] = DateTime.Now;

                    if (row["FechaModificacion"] == DBNull.Value)
                        row["FechaModificacion"] = DateTime.Now;

                    if (row["Activo"] == DBNull.Value)
                        row["Activo"] = true;
                }

                if (row.RowState == DataRowState.Modified)
                {
                    row["FechaModificacion"] = DateTime.Now;
                }
            }

            // Guarda todos los cambios
            tableAdapterManager.UpdateAll(dataset);
        }


        public void GuardarFotosCategoria(GestionProductosDBDataSet dataset, BindingSource bindingSource, TableAdapterManager tableAdapterManager)
        {
            try
            {
                // Finaliza edición de los datos vinculados
                bindingSource.EndEdit();


                foreach (DataRow row in dataset.FotosCategoria.Rows)
                {
                    if (row.RowState == DataRowState.Added)
                    {
                        if (row["FechaCreacion"] == DBNull.Value)
                            row["FechaCreacion"] = DateTime.Now;

                        if (row["Activo"] == DBNull.Value)
                            row["Activo"] = true;
                    }                    

                }

                // Guarda todos los cambios
                tableAdapterManager.UpdateAll(dataset);
            }
            catch (Exception)
            {
                MessageBox.Show
                (
                    "Ingrese un ID de categoría válido.", "Error de entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            
        }

        public void GuardarSuplidores(GestionProductosDBDataSet dataset, BindingSource bindingSource, TableAdapterManager tableAdapterManager)
        {
            try
            {
                // Finaliza edición de los datos vinculados
                bindingSource.EndEdit();

                foreach (DataRow row in dataset.Suplidores.Rows)
                {
                    if (row.RowState == DataRowState.Added)
                    {
                        if (row["FechaCreacion"] == DBNull.Value)
                            row["FechaCreacion"] = DateTime.Now;

                        if (row["FechaModificacion"] == DBNull.Value)
                            row["FechaModificacion"] = DateTime.Now;

                        if (row["Activo"] == DBNull.Value)
                            row["Activo"] = true;
                    }

                    if (row.RowState == DataRowState.Modified)
                    {
                        row["FechaModificacion"] = DateTime.Now;
                    }

                }

                // Guarda todos los cambios
                tableAdapterManager.UpdateAll(dataset);
            }
            catch (Exception)
            {
                MessageBox.Show
                (
                    "Ingrese los datos correctos.", "Error de entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

        }

        public void GuardarProductos(GestionProductosDBDataSet dataset, BindingSource bindingSource, TableAdapterManager tableAdapterManager)
        {
            try
            {
                // Finaliza edición de los datos vinculados
                bindingSource.EndEdit();



                foreach (DataRow row in dataset.Productos.Rows)
                {
                    if (row.RowState == DataRowState.Added)
                    {
                        if (row["FechaCreacion"] == DBNull.Value)
                            row["FechaCreacion"] = DateTime.Now;

                        if (row["FechaModificacion"] == DBNull.Value)
                            row["FechaModificacion"] = DateTime.Now;

                        if (row["Activo"] == DBNull.Value)
                            row["Activo"] = true;
                    }

                    if (row.RowState == DataRowState.Modified)
                    {
                        row["FechaModificacion"] = DateTime.Now;
                    }

                }

                // Guarda todos los cambios
                tableAdapterManager.UpdateAll(dataset);
            }
            catch (Exception)
            {
                MessageBox.Show
                (
                    "Ingrese los datos correctos.", "Error de entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

        }

        public void AgregarFilaNueva(BindingSource bindingSource, Control primerControl = null)
        {
            bindingSource.EndEdit();
            bindingSource.AddNew();
            primerControl?.Focus();
        }

        public void BorradoLogico(DataGridView dgv, BindingSource bindingSource, TableAdapterManager tableAdapterManager, Control anyControlInForm,Action reloadTable = null)
        {
            try
            {
                if (dgv.CurrentRow != null)
                {
                    var filaSeleccionada = (DataRowView)dgv.CurrentRow.DataBoundItem;

                    if (filaSeleccionada.Row.Table.Columns.Contains("Activo"))
                    {
                        // Validar el formulario
                        anyControlInForm?.FindForm()?.Validate();

                        // Poner Activo = 0
                        filaSeleccionada["Activo"] = 0;

                        // Guardar cambios
                        bindingSource.EndEdit();

                        var dataset = filaSeleccionada.Row.Table.DataSet;
                        tableAdapterManager.UpdateAll((GestionProductosDBDataSet)dataset);

                        // Recargar tabla si se indicó
                        reloadTable?.Invoke();
                    }
                    else
                    {
                        MessageBox.Show("Esta tabla no tiene una columna 'Activo'.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona un registro para borrar.");
                }
            }
            catch(Exception)
            {
                MessageBox.Show
               (
                   "Seleccione un registro valido para borrar.", "Error!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
        }


        public void CargarFotos(Form1 form1)
        {
            try
            {
                OpenFileDialog chooseImage = new OpenFileDialog();
                chooseImage.Title = "Choose Image";
                DialogResult chooseImageDialog = chooseImage.ShowDialog();

                if (chooseImageDialog == DialogResult.OK)
                {
                    form1.rutaFotoTextBox.Text = chooseImage.FileName;
                    //Displaying image from Pc On PictureBox, but borré el otro form
                    //fotos.imagen.Image = Image.FromFile(chooseImage.FileName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool EsCorreoValido(string correo)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }
   }
}
