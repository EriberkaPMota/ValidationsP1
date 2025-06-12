namespace ValidationsP1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label categoriaIDLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label fechaCreacionLabel;
            System.Windows.Forms.Label fechaModificacionLabel;
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label fotoIDLabel;
            System.Windows.Forms.Label categoriaIDLabel1;
            System.Windows.Forms.Label rutaFotoLabel;
            System.Windows.Forms.Label fechaCreacionLabel2;
            System.Windows.Forms.Label activoLabel2;
            System.Windows.Forms.Label suplidorIDLabel;
            System.Windows.Forms.Label nombreEmpresaLabel;
            System.Windows.Forms.Label nombreContactoLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label sitioWebLabel;
            System.Windows.Forms.Label fechaCreacionLabel1;
            System.Windows.Forms.Label fechaModificacionLabel1;
            System.Windows.Forms.Label activoLabel1;
            System.Windows.Forms.Label productoIDLabel;
            System.Windows.Forms.Label nombreProductoLabel;
            System.Windows.Forms.Label precioUnitarioLabel;
            System.Windows.Forms.Label categoriaIDLabel2;
            System.Windows.Forms.Label suplidorIDLabel1;
            System.Windows.Forms.Label fechaCreacionLabel3;
            System.Windows.Forms.Label fechaModificacionLabel2;
            System.Windows.Forms.Label activoLabel3;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CategoryGroup = new System.Windows.Forms.GroupBox();
            this.categoriaIDTextBox = new System.Windows.Forms.TextBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionProductosDBDataSet = new ValidationsP1.GestionProductosDBDataSet();
            this.nombreCategoriaTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.fechaCreacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaModificacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.añadirCate = new System.Windows.Forms.Button();
            this.categoriasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.guardarcate = new System.Windows.Forms.Button();
            this.EliminarCate = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnFoto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fotoIDTextBox = new System.Windows.Forms.TextBox();
            this.fotosCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaIDTextBox1 = new System.Windows.Forms.TextBox();
            this.rutaFotoTextBox = new System.Windows.Forms.TextBox();
            this.fechaCreacionDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.activoCheckBox2 = new System.Windows.Forms.CheckBox();
            this.añadirCata = new System.Windows.Forms.Button();
            this.guardarCata = new System.Windows.Forms.Button();
            this.eliminarCata = new System.Windows.Forms.Button();
            this.fotosCategoriaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.telefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.suplidoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suplidorIDTextBox = new System.Windows.Forms.TextBox();
            this.nombreEmpresaTextBox = new System.Windows.Forms.TextBox();
            this.nombreContactoTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.sitioWebTextBox = new System.Windows.Forms.TextBox();
            this.fechaCreacionDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.fechaModificacionDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.activoCheckBox1 = new System.Windows.Forms.CheckBox();
            this.añadirsuplidor = new System.Windows.Forms.Button();
            this.guardarSupli = new System.Windows.Forms.Button();
            this.eliminarSupli = new System.Windows.Forms.Button();
            this.suplidoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.productoIDTextBox = new System.Windows.Forms.TextBox();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreProductoTextBox = new System.Windows.Forms.TextBox();
            this.precioUnitarioTextBox = new System.Windows.Forms.TextBox();
            this.categoriaIDTextBox2 = new System.Windows.Forms.TextBox();
            this.suplidorIDTextBox1 = new System.Windows.Forms.TextBox();
            this.fechaCreacionDateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.fechaModificacionDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.activoCheckBox3 = new System.Windows.Forms.CheckBox();
            this.button11 = new System.Windows.Forms.Button();
            this.SaveProdu = new System.Windows.Forms.Button();
            this.eliminarProdu = new System.Windows.Forms.Button();
            this.productosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.categoriasTableAdapter = new ValidationsP1.GestionProductosDBDataSetTableAdapters.CategoriasTableAdapter();
            this.tableAdapterManager = new ValidationsP1.GestionProductosDBDataSetTableAdapters.TableAdapterManager();
            this.fotosCategoriaTableAdapter = new ValidationsP1.GestionProductosDBDataSetTableAdapters.FotosCategoriaTableAdapter();
            this.productosTableAdapter = new ValidationsP1.GestionProductosDBDataSetTableAdapters.ProductosTableAdapter();
            this.suplidoresTableAdapter = new ValidationsP1.GestionProductosDBDataSetTableAdapters.SuplidoresTableAdapter();
            categoriaIDLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            fechaCreacionLabel = new System.Windows.Forms.Label();
            fechaModificacionLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            fotoIDLabel = new System.Windows.Forms.Label();
            categoriaIDLabel1 = new System.Windows.Forms.Label();
            rutaFotoLabel = new System.Windows.Forms.Label();
            fechaCreacionLabel2 = new System.Windows.Forms.Label();
            activoLabel2 = new System.Windows.Forms.Label();
            suplidorIDLabel = new System.Windows.Forms.Label();
            nombreEmpresaLabel = new System.Windows.Forms.Label();
            nombreContactoLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            sitioWebLabel = new System.Windows.Forms.Label();
            fechaCreacionLabel1 = new System.Windows.Forms.Label();
            fechaModificacionLabel1 = new System.Windows.Forms.Label();
            activoLabel1 = new System.Windows.Forms.Label();
            productoIDLabel = new System.Windows.Forms.Label();
            nombreProductoLabel = new System.Windows.Forms.Label();
            precioUnitarioLabel = new System.Windows.Forms.Label();
            categoriaIDLabel2 = new System.Windows.Forms.Label();
            suplidorIDLabel1 = new System.Windows.Forms.Label();
            fechaCreacionLabel3 = new System.Windows.Forms.Label();
            fechaModificacionLabel2 = new System.Windows.Forms.Label();
            activoLabel3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.CategoryGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotosCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotosCategoriaDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suplidoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplidoresDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriaIDLabel
            // 
            categoriaIDLabel.AutoSize = true;
            categoriaIDLabel.Location = new System.Drawing.Point(6, 56);
            categoriaIDLabel.Name = "categoriaIDLabel";
            categoriaIDLabel.Size = new System.Drawing.Size(108, 19);
            categoriaIDLabel.TabIndex = 0;
            categoriaIDLabel.Text = "Categoria ID:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(6, 88);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(73, 19);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(6, 114);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(101, 19);
            descripcionLabel.TabIndex = 4;
            descripcionLabel.Text = "Descripcion:";
            // 
            // fechaCreacionLabel
            // 
            fechaCreacionLabel.AutoSize = true;
            fechaCreacionLabel.Location = new System.Drawing.Point(6, 150);
            fechaCreacionLabel.Name = "fechaCreacionLabel";
            fechaCreacionLabel.Size = new System.Drawing.Size(127, 19);
            fechaCreacionLabel.TabIndex = 6;
            fechaCreacionLabel.Text = "Fecha Creacion:";
            // 
            // fechaModificacionLabel
            // 
            fechaModificacionLabel.AutoSize = true;
            fechaModificacionLabel.Location = new System.Drawing.Point(6, 182);
            fechaModificacionLabel.Name = "fechaModificacionLabel";
            fechaModificacionLabel.Size = new System.Drawing.Size(159, 19);
            fechaModificacionLabel.TabIndex = 8;
            fechaModificacionLabel.Text = "Fecha Modificacion:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(6, 209);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(63, 19);
            activoLabel.TabIndex = 10;
            activoLabel.Text = "Activo:";
            // 
            // fotoIDLabel
            // 
            fotoIDLabel.AutoSize = true;
            fotoIDLabel.Location = new System.Drawing.Point(7, 50);
            fotoIDLabel.Name = "fotoIDLabel";
            fotoIDLabel.Size = new System.Drawing.Size(71, 19);
            fotoIDLabel.TabIndex = 0;
            fotoIDLabel.Text = "Foto ID:";
            // 
            // categoriaIDLabel1
            // 
            categoriaIDLabel1.AutoSize = true;
            categoriaIDLabel1.Location = new System.Drawing.Point(7, 82);
            categoriaIDLabel1.Name = "categoriaIDLabel1";
            categoriaIDLabel1.Size = new System.Drawing.Size(108, 19);
            categoriaIDLabel1.TabIndex = 2;
            categoriaIDLabel1.Text = "Categoria ID:";
            // 
            // rutaFotoLabel
            // 
            rutaFotoLabel.AutoSize = true;
            rutaFotoLabel.Location = new System.Drawing.Point(7, 114);
            rutaFotoLabel.Name = "rutaFotoLabel";
            rutaFotoLabel.Size = new System.Drawing.Size(86, 19);
            rutaFotoLabel.TabIndex = 4;
            rutaFotoLabel.Text = "Ruta Foto:";
            // 
            // fechaCreacionLabel2
            // 
            fechaCreacionLabel2.AutoSize = true;
            fechaCreacionLabel2.Location = new System.Drawing.Point(7, 147);
            fechaCreacionLabel2.Name = "fechaCreacionLabel2";
            fechaCreacionLabel2.Size = new System.Drawing.Size(127, 19);
            fechaCreacionLabel2.TabIndex = 6;
            fechaCreacionLabel2.Text = "Fecha Creacion:";
            // 
            // activoLabel2
            // 
            activoLabel2.AutoSize = true;
            activoLabel2.Location = new System.Drawing.Point(7, 180);
            activoLabel2.Name = "activoLabel2";
            activoLabel2.Size = new System.Drawing.Size(63, 19);
            activoLabel2.TabIndex = 8;
            activoLabel2.Text = "Activo:";
            // 
            // suplidorIDLabel
            // 
            suplidorIDLabel.AutoSize = true;
            suplidorIDLabel.Location = new System.Drawing.Point(7, 30);
            suplidorIDLabel.Name = "suplidorIDLabel";
            suplidorIDLabel.Size = new System.Drawing.Size(100, 19);
            suplidorIDLabel.TabIndex = 0;
            suplidorIDLabel.Text = "Suplidor ID:";
            // 
            // nombreEmpresaLabel
            // 
            nombreEmpresaLabel.AutoSize = true;
            nombreEmpresaLabel.Location = new System.Drawing.Point(7, 62);
            nombreEmpresaLabel.Name = "nombreEmpresaLabel";
            nombreEmpresaLabel.Size = new System.Drawing.Size(141, 19);
            nombreEmpresaLabel.TabIndex = 2;
            nombreEmpresaLabel.Text = "Nombre Empresa:";
            // 
            // nombreContactoLabel
            // 
            nombreContactoLabel.AutoSize = true;
            nombreContactoLabel.Location = new System.Drawing.Point(7, 94);
            nombreContactoLabel.Name = "nombreContactoLabel";
            nombreContactoLabel.Size = new System.Drawing.Size(143, 19);
            nombreContactoLabel.TabIndex = 4;
            nombreContactoLabel.Text = "Nombre Contacto:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(7, 126);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(79, 19);
            telefonoLabel.TabIndex = 6;
            telefonoLabel.Text = "Telefono:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(7, 158);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(64, 19);
            correoLabel.TabIndex = 8;
            correoLabel.Text = "Correo:";
            // 
            // sitioWebLabel
            // 
            sitioWebLabel.AutoSize = true;
            sitioWebLabel.Location = new System.Drawing.Point(7, 190);
            sitioWebLabel.Name = "sitioWebLabel";
            sitioWebLabel.Size = new System.Drawing.Size(87, 19);
            sitioWebLabel.TabIndex = 10;
            sitioWebLabel.Text = "Sitio Web:";
            // 
            // fechaCreacionLabel1
            // 
            fechaCreacionLabel1.AutoSize = true;
            fechaCreacionLabel1.Location = new System.Drawing.Point(7, 223);
            fechaCreacionLabel1.Name = "fechaCreacionLabel1";
            fechaCreacionLabel1.Size = new System.Drawing.Size(127, 19);
            fechaCreacionLabel1.TabIndex = 12;
            fechaCreacionLabel1.Text = "Fecha Creacion:";
            // 
            // fechaModificacionLabel1
            // 
            fechaModificacionLabel1.AutoSize = true;
            fechaModificacionLabel1.Location = new System.Drawing.Point(7, 255);
            fechaModificacionLabel1.Name = "fechaModificacionLabel1";
            fechaModificacionLabel1.Size = new System.Drawing.Size(159, 19);
            fechaModificacionLabel1.TabIndex = 14;
            fechaModificacionLabel1.Text = "Fecha Modificacion:";
            // 
            // activoLabel1
            // 
            activoLabel1.AutoSize = true;
            activoLabel1.Location = new System.Drawing.Point(7, 288);
            activoLabel1.Name = "activoLabel1";
            activoLabel1.Size = new System.Drawing.Size(63, 19);
            activoLabel1.TabIndex = 16;
            activoLabel1.Text = "Activo:";
            // 
            // productoIDLabel
            // 
            productoIDLabel.AutoSize = true;
            productoIDLabel.Location = new System.Drawing.Point(9, 31);
            productoIDLabel.Name = "productoIDLabel";
            productoIDLabel.Size = new System.Drawing.Size(103, 19);
            productoIDLabel.TabIndex = 0;
            productoIDLabel.Text = "Producto ID:";
            // 
            // nombreProductoLabel
            // 
            nombreProductoLabel.AutoSize = true;
            nombreProductoLabel.Location = new System.Drawing.Point(9, 63);
            nombreProductoLabel.Name = "nombreProductoLabel";
            nombreProductoLabel.Size = new System.Drawing.Size(143, 19);
            nombreProductoLabel.TabIndex = 2;
            nombreProductoLabel.Text = "Nombre Producto:";
            // 
            // precioUnitarioLabel
            // 
            precioUnitarioLabel.AutoSize = true;
            precioUnitarioLabel.Location = new System.Drawing.Point(9, 95);
            precioUnitarioLabel.Name = "precioUnitarioLabel";
            precioUnitarioLabel.Size = new System.Drawing.Size(125, 19);
            precioUnitarioLabel.TabIndex = 4;
            precioUnitarioLabel.Text = "Precio Unitario:";
            // 
            // categoriaIDLabel2
            // 
            categoriaIDLabel2.AutoSize = true;
            categoriaIDLabel2.Location = new System.Drawing.Point(9, 127);
            categoriaIDLabel2.Name = "categoriaIDLabel2";
            categoriaIDLabel2.Size = new System.Drawing.Size(108, 19);
            categoriaIDLabel2.TabIndex = 6;
            categoriaIDLabel2.Text = "Categoria ID:";
            // 
            // suplidorIDLabel1
            // 
            suplidorIDLabel1.AutoSize = true;
            suplidorIDLabel1.Location = new System.Drawing.Point(9, 159);
            suplidorIDLabel1.Name = "suplidorIDLabel1";
            suplidorIDLabel1.Size = new System.Drawing.Size(100, 19);
            suplidorIDLabel1.TabIndex = 8;
            suplidorIDLabel1.Text = "Suplidor ID:";
            // 
            // fechaCreacionLabel3
            // 
            fechaCreacionLabel3.AutoSize = true;
            fechaCreacionLabel3.Location = new System.Drawing.Point(9, 192);
            fechaCreacionLabel3.Name = "fechaCreacionLabel3";
            fechaCreacionLabel3.Size = new System.Drawing.Size(127, 19);
            fechaCreacionLabel3.TabIndex = 10;
            fechaCreacionLabel3.Text = "Fecha Creacion:";
            // 
            // fechaModificacionLabel2
            // 
            fechaModificacionLabel2.AutoSize = true;
            fechaModificacionLabel2.Location = new System.Drawing.Point(9, 224);
            fechaModificacionLabel2.Name = "fechaModificacionLabel2";
            fechaModificacionLabel2.Size = new System.Drawing.Size(159, 19);
            fechaModificacionLabel2.TabIndex = 12;
            fechaModificacionLabel2.Text = "Fecha Modificacion:";
            // 
            // activoLabel3
            // 
            activoLabel3.AutoSize = true;
            activoLabel3.Location = new System.Drawing.Point(9, 257);
            activoLabel3.Name = "activoLabel3";
            activoLabel3.Size = new System.Drawing.Size(63, 19);
            activoLabel3.TabIndex = 14;
            activoLabel3.Text = "Activo:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(995, 537);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.Azure;
            this.tabPage1.BackgroundImage = global::ValidationsP1.Properties.Resources.PAP_1;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.CategoryGroup);
            this.tabPage1.Controls.Add(this.añadirCate);
            this.tabPage1.Controls.Add(this.categoriasDataGridView);
            this.tabPage1.Controls.Add(this.guardarcate);
            this.tabPage1.Controls.Add(this.EliminarCate);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(987, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Categorías";
            // 
            // CategoryGroup
            // 
            this.CategoryGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CategoryGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(146)))), ((int)(((byte)(213)))));
            this.CategoryGroup.Controls.Add(categoriaIDLabel);
            this.CategoryGroup.Controls.Add(this.categoriaIDTextBox);
            this.CategoryGroup.Controls.Add(nombreLabel);
            this.CategoryGroup.Controls.Add(this.nombreCategoriaTextBox);
            this.CategoryGroup.Controls.Add(descripcionLabel);
            this.CategoryGroup.Controls.Add(this.descripcionTextBox);
            this.CategoryGroup.Controls.Add(fechaCreacionLabel);
            this.CategoryGroup.Controls.Add(this.fechaCreacionDateTimePicker);
            this.CategoryGroup.Controls.Add(fechaModificacionLabel);
            this.CategoryGroup.Controls.Add(this.fechaModificacionDateTimePicker);
            this.CategoryGroup.Controls.Add(activoLabel);
            this.CategoryGroup.Controls.Add(this.activoCheckBox);
            this.CategoryGroup.Location = new System.Drawing.Point(58, 76);
            this.CategoryGroup.Name = "CategoryGroup";
            this.CategoryGroup.Size = new System.Drawing.Size(379, 259);
            this.CategoryGroup.TabIndex = 17;
            this.CategoryGroup.TabStop = false;
            this.CategoryGroup.Text = "Categorías";
            // 
            // categoriaIDTextBox
            // 
            this.categoriaIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriasBindingSource, "CategoriaID", true));
            this.categoriaIDTextBox.Location = new System.Drawing.Point(173, 47);
            this.categoriaIDTextBox.Name = "categoriaIDTextBox";
            this.categoriaIDTextBox.Size = new System.Drawing.Size(200, 28);
            this.categoriaIDTextBox.TabIndex = 1;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.gestionProductosDBDataSet;
            // 
            // gestionProductosDBDataSet
            // 
            this.gestionProductosDBDataSet.DataSetName = "GestionProductosDBDataSet";
            this.gestionProductosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombreCategoriaTextBox
            // 
            this.nombreCategoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriasBindingSource, "Nombre", true));
            this.nombreCategoriaTextBox.Location = new System.Drawing.Point(173, 79);
            this.nombreCategoriaTextBox.Name = "nombreCategoriaTextBox";
            this.nombreCategoriaTextBox.Size = new System.Drawing.Size(200, 28);
            this.nombreCategoriaTextBox.TabIndex = 3;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriasBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(173, 111);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(200, 28);
            this.descripcionTextBox.TabIndex = 5;
            // 
            // fechaCreacionDateTimePicker
            // 
            this.fechaCreacionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.categoriasBindingSource, "FechaCreacion", true));
            this.fechaCreacionDateTimePicker.Location = new System.Drawing.Point(173, 143);
            this.fechaCreacionDateTimePicker.Name = "fechaCreacionDateTimePicker";
            this.fechaCreacionDateTimePicker.Size = new System.Drawing.Size(200, 28);
            this.fechaCreacionDateTimePicker.TabIndex = 7;
            // 
            // fechaModificacionDateTimePicker
            // 
            this.fechaModificacionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.categoriasBindingSource, "FechaModificacion", true));
            this.fechaModificacionDateTimePicker.Location = new System.Drawing.Point(173, 175);
            this.fechaModificacionDateTimePicker.Name = "fechaModificacionDateTimePicker";
            this.fechaModificacionDateTimePicker.Size = new System.Drawing.Size(200, 28);
            this.fechaModificacionDateTimePicker.TabIndex = 9;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.categoriasBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(173, 207);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.activoCheckBox.TabIndex = 11;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // añadirCate
            // 
            this.añadirCate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.añadirCate.Location = new System.Drawing.Point(312, 342);
            this.añadirCate.Name = "añadirCate";
            this.añadirCate.Size = new System.Drawing.Size(121, 42);
            this.añadirCate.TabIndex = 16;
            this.añadirCate.Text = "Añadir";
            this.añadirCate.UseVisualStyleBackColor = false;
            this.añadirCate.Click += new System.EventHandler(this.AddCategoria);
            // 
            // categoriasDataGridView
            // 
            this.categoriasDataGridView.AllowUserToAddRows = false;
            this.categoriasDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoriasDataGridView.AutoGenerateColumns = false;
            this.categoriasDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.categoriasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.categoriasDataGridView.DataSource = this.categoriasBindingSource;
            this.categoriasDataGridView.Location = new System.Drawing.Point(443, 76);
            this.categoriasDataGridView.Name = "categoriasDataGridView";
            this.categoriasDataGridView.RowHeadersWidth = 62;
            this.categoriasDataGridView.RowTemplate.Height = 28;
            this.categoriasDataGridView.Size = new System.Drawing.Size(488, 303);
            this.categoriasDataGridView.TabIndex = 14;
            this.categoriasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriasDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CategoriaID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CategoriaID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FechaCreacion";
            this.dataGridViewTextBoxColumn4.HeaderText = "FechaCreacion";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FechaModificacion";
            this.dataGridViewTextBoxColumn5.HeaderText = "FechaModificacion";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Activo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Activo";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // guardarcate
            // 
            this.guardarcate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(146)))), ((int)(((byte)(213)))));
            this.guardarcate.Location = new System.Drawing.Point(185, 342);
            this.guardarcate.Name = "guardarcate";
            this.guardarcate.Size = new System.Drawing.Size(121, 42);
            this.guardarcate.TabIndex = 12;
            this.guardarcate.Text = "Guardar";
            this.guardarcate.UseVisualStyleBackColor = false;
            this.guardarcate.Click += new System.EventHandler(this.saveCate);
            // 
            // EliminarCate
            // 
            this.EliminarCate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.EliminarCate.Location = new System.Drawing.Point(58, 342);
            this.EliminarCate.Name = "EliminarCate";
            this.EliminarCate.Size = new System.Drawing.Size(121, 42);
            this.EliminarCate.TabIndex = 12;
            this.EliminarCate.Text = "Eliminar";
            this.EliminarCate.UseVisualStyleBackColor = false;
            this.EliminarCate.Click += new System.EventHandler(this.BorrarCategoria);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.BackgroundImage = global::ValidationsP1.Properties.Resources.PAP_1;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.btnFoto);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.añadirCata);
            this.tabPage2.Controls.Add(this.guardarCata);
            this.tabPage2.Controls.Add(this.eliminarCata);
            this.tabPage2.Controls.Add(this.fotosCategoriaDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(987, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Catálogo";
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(146)))), ((int)(((byte)(213)))));
            this.btnFoto.Location = new System.Drawing.Point(791, 416);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(129, 40);
            this.btnFoto.TabIndex = 19;
            this.btnFoto.Text = "Elegir imagen";
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.groupBox1.Controls.Add(fotoIDLabel);
            this.groupBox1.Controls.Add(this.fotoIDTextBox);
            this.groupBox1.Controls.Add(categoriaIDLabel1);
            this.groupBox1.Controls.Add(this.categoriaIDTextBox1);
            this.groupBox1.Controls.Add(rutaFotoLabel);
            this.groupBox1.Controls.Add(this.rutaFotoTextBox);
            this.groupBox1.Controls.Add(fechaCreacionLabel2);
            this.groupBox1.Controls.Add(this.fechaCreacionDateTimePicker2);
            this.groupBox1.Controls.Add(activoLabel2);
            this.groupBox1.Controls.Add(this.activoCheckBox2);
            this.groupBox1.Location = new System.Drawing.Point(59, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 243);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Catálogo de Fotos";
            // 
            // fotoIDTextBox
            // 
            this.fotoIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fotosCategoriaBindingSource, "FotoID", true));
            this.fotoIDTextBox.Location = new System.Drawing.Point(138, 47);
            this.fotoIDTextBox.Name = "fotoIDTextBox";
            this.fotoIDTextBox.Size = new System.Drawing.Size(200, 28);
            this.fotoIDTextBox.TabIndex = 1;
            // 
            // fotosCategoriaBindingSource
            // 
            this.fotosCategoriaBindingSource.DataMember = "FotosCategoria";
            this.fotosCategoriaBindingSource.DataSource = this.gestionProductosDBDataSet;
            // 
            // categoriaIDTextBox1
            // 
            this.categoriaIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fotosCategoriaBindingSource, "CategoriaID", true));
            this.categoriaIDTextBox1.Location = new System.Drawing.Point(138, 79);
            this.categoriaIDTextBox1.Name = "categoriaIDTextBox1";
            this.categoriaIDTextBox1.Size = new System.Drawing.Size(200, 28);
            this.categoriaIDTextBox1.TabIndex = 3;
            // 
            // rutaFotoTextBox
            // 
            this.rutaFotoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fotosCategoriaBindingSource, "RutaFoto", true));
            this.rutaFotoTextBox.Location = new System.Drawing.Point(138, 111);
            this.rutaFotoTextBox.Name = "rutaFotoTextBox";
            this.rutaFotoTextBox.Size = new System.Drawing.Size(200, 28);
            this.rutaFotoTextBox.TabIndex = 5;
            // 
            // fechaCreacionDateTimePicker2
            // 
            this.fechaCreacionDateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fotosCategoriaBindingSource, "FechaCreacion", true));
            this.fechaCreacionDateTimePicker2.Location = new System.Drawing.Point(138, 143);
            this.fechaCreacionDateTimePicker2.Name = "fechaCreacionDateTimePicker2";
            this.fechaCreacionDateTimePicker2.Size = new System.Drawing.Size(200, 28);
            this.fechaCreacionDateTimePicker2.TabIndex = 7;
            // 
            // activoCheckBox2
            // 
            this.activoCheckBox2.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.fotosCategoriaBindingSource, "Activo", true));
            this.activoCheckBox2.Location = new System.Drawing.Point(138, 175);
            this.activoCheckBox2.Name = "activoCheckBox2";
            this.activoCheckBox2.Size = new System.Drawing.Size(200, 24);
            this.activoCheckBox2.TabIndex = 9;
            this.activoCheckBox2.UseVisualStyleBackColor = true;
            // 
            // añadirCata
            // 
            this.añadirCata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.añadirCata.Location = new System.Drawing.Point(293, 357);
            this.añadirCata.Name = "añadirCata";
            this.añadirCata.Size = new System.Drawing.Size(98, 40);
            this.añadirCata.TabIndex = 17;
            this.añadirCata.Text = "Añadir";
            this.añadirCata.UseVisualStyleBackColor = false;
            this.añadirCata.Click += new System.EventHandler(this.añadirCata_Click);
            // 
            // guardarCata
            // 
            this.guardarCata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(146)))), ((int)(((byte)(213)))));
            this.guardarCata.Location = new System.Drawing.Point(176, 357);
            this.guardarCata.Name = "guardarCata";
            this.guardarCata.Size = new System.Drawing.Size(98, 40);
            this.guardarCata.TabIndex = 13;
            this.guardarCata.Text = "Guardar";
            this.guardarCata.UseVisualStyleBackColor = false;
            this.guardarCata.Click += new System.EventHandler(this.saveCata);
            // 
            // eliminarCata
            // 
            this.eliminarCata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.eliminarCata.Location = new System.Drawing.Point(59, 357);
            this.eliminarCata.Name = "eliminarCata";
            this.eliminarCata.Size = new System.Drawing.Size(98, 40);
            this.eliminarCata.TabIndex = 14;
            this.eliminarCata.Text = "Eliminar";
            this.eliminarCata.UseVisualStyleBackColor = false;
            this.eliminarCata.Click += new System.EventHandler(this.eliminarCata_Click);
            // 
            // fotosCategoriaDataGridView
            // 
            this.fotosCategoriaDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fotosCategoriaDataGridView.AutoGenerateColumns = false;
            this.fotosCategoriaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.fotosCategoriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fotosCategoriaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewCheckBoxColumn3});
            this.fotosCategoriaDataGridView.DataSource = this.fotosCategoriaBindingSource;
            this.fotosCategoriaDataGridView.Location = new System.Drawing.Point(421, 79);
            this.fotosCategoriaDataGridView.Name = "fotosCategoriaDataGridView";
            this.fotosCategoriaDataGridView.RowHeadersWidth = 62;
            this.fotosCategoriaDataGridView.RowTemplate.Height = 28;
            this.fotosCategoriaDataGridView.Size = new System.Drawing.Size(499, 318);
            this.fotosCategoriaDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "FotoID";
            this.dataGridViewTextBoxColumn14.HeaderText = "FotoID";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 87;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "CategoriaID";
            this.dataGridViewTextBoxColumn15.HeaderText = "CategoriaID";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 87;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "RutaFoto";
            this.dataGridViewTextBoxColumn16.HeaderText = "RutaFoto";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 87;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "FechaCreacion";
            this.dataGridViewTextBoxColumn17.HeaderText = "FechaCreacion";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 87;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Activo";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Activo";
            this.dataGridViewCheckBoxColumn3.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Width = 87;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackgroundImage = global::ValidationsP1.Properties.Resources.PAP_1;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.añadirsuplidor);
            this.tabPage3.Controls.Add(this.guardarSupli);
            this.tabPage3.Controls.Add(this.eliminarSupli);
            this.tabPage3.Controls.Add(this.suplidoresDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(987, 505);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Suplidores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.groupBox2.Controls.Add(this.telefonoMaskedTextBox);
            this.groupBox2.Controls.Add(suplidorIDLabel);
            this.groupBox2.Controls.Add(this.suplidorIDTextBox);
            this.groupBox2.Controls.Add(nombreEmpresaLabel);
            this.groupBox2.Controls.Add(this.nombreEmpresaTextBox);
            this.groupBox2.Controls.Add(nombreContactoLabel);
            this.groupBox2.Controls.Add(this.nombreContactoTextBox);
            this.groupBox2.Controls.Add(telefonoLabel);
            this.groupBox2.Controls.Add(correoLabel);
            this.groupBox2.Controls.Add(this.correoTextBox);
            this.groupBox2.Controls.Add(sitioWebLabel);
            this.groupBox2.Controls.Add(this.sitioWebTextBox);
            this.groupBox2.Controls.Add(fechaCreacionLabel1);
            this.groupBox2.Controls.Add(this.fechaCreacionDateTimePicker1);
            this.groupBox2.Controls.Add(fechaModificacionLabel1);
            this.groupBox2.Controls.Add(this.fechaModificacionDateTimePicker1);
            this.groupBox2.Controls.Add(activoLabel1);
            this.groupBox2.Controls.Add(this.activoCheckBox1);
            this.groupBox2.Location = new System.Drawing.Point(55, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 324);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Suplidores ";
            // 
            // telefonoMaskedTextBox
            // 
            this.telefonoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suplidoresBindingSource, "Telefono", true));
            this.telefonoMaskedTextBox.Location = new System.Drawing.Point(170, 126);
            this.telefonoMaskedTextBox.Mask = "000-000-0000";
            this.telefonoMaskedTextBox.Name = "telefonoMaskedTextBox";
            this.telefonoMaskedTextBox.Size = new System.Drawing.Size(200, 28);
            this.telefonoMaskedTextBox.TabIndex = 21;
            // 
            // suplidoresBindingSource
            // 
            this.suplidoresBindingSource.DataMember = "Suplidores";
            this.suplidoresBindingSource.DataSource = this.gestionProductosDBDataSet;
            // 
            // suplidorIDTextBox
            // 
            this.suplidorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suplidoresBindingSource, "SuplidorID", true));
            this.suplidorIDTextBox.Location = new System.Drawing.Point(170, 27);
            this.suplidorIDTextBox.Name = "suplidorIDTextBox";
            this.suplidorIDTextBox.Size = new System.Drawing.Size(200, 28);
            this.suplidorIDTextBox.TabIndex = 1;
            // 
            // nombreEmpresaTextBox
            // 
            this.nombreEmpresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suplidoresBindingSource, "NombreEmpresa", true));
            this.nombreEmpresaTextBox.Location = new System.Drawing.Point(170, 59);
            this.nombreEmpresaTextBox.Name = "nombreEmpresaTextBox";
            this.nombreEmpresaTextBox.Size = new System.Drawing.Size(200, 28);
            this.nombreEmpresaTextBox.TabIndex = 3;
            // 
            // nombreContactoTextBox
            // 
            this.nombreContactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suplidoresBindingSource, "NombreContacto", true));
            this.nombreContactoTextBox.Location = new System.Drawing.Point(170, 91);
            this.nombreContactoTextBox.Name = "nombreContactoTextBox";
            this.nombreContactoTextBox.Size = new System.Drawing.Size(200, 28);
            this.nombreContactoTextBox.TabIndex = 5;
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suplidoresBindingSource, "Correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(170, 155);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(200, 28);
            this.correoTextBox.TabIndex = 9;
            // 
            // sitioWebTextBox
            // 
            this.sitioWebTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suplidoresBindingSource, "SitioWeb", true));
            this.sitioWebTextBox.Location = new System.Drawing.Point(170, 187);
            this.sitioWebTextBox.Name = "sitioWebTextBox";
            this.sitioWebTextBox.Size = new System.Drawing.Size(200, 28);
            this.sitioWebTextBox.TabIndex = 11;
            // 
            // fechaCreacionDateTimePicker1
            // 
            this.fechaCreacionDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.suplidoresBindingSource, "FechaCreacion", true));
            this.fechaCreacionDateTimePicker1.Location = new System.Drawing.Point(170, 219);
            this.fechaCreacionDateTimePicker1.Name = "fechaCreacionDateTimePicker1";
            this.fechaCreacionDateTimePicker1.Size = new System.Drawing.Size(200, 28);
            this.fechaCreacionDateTimePicker1.TabIndex = 13;
            // 
            // fechaModificacionDateTimePicker1
            // 
            this.fechaModificacionDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.suplidoresBindingSource, "FechaModificacion", true));
            this.fechaModificacionDateTimePicker1.Location = new System.Drawing.Point(170, 251);
            this.fechaModificacionDateTimePicker1.Name = "fechaModificacionDateTimePicker1";
            this.fechaModificacionDateTimePicker1.Size = new System.Drawing.Size(200, 28);
            this.fechaModificacionDateTimePicker1.TabIndex = 15;
            // 
            // activoCheckBox1
            // 
            this.activoCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.suplidoresBindingSource, "Activo", true));
            this.activoCheckBox1.Location = new System.Drawing.Point(170, 283);
            this.activoCheckBox1.Name = "activoCheckBox1";
            this.activoCheckBox1.Size = new System.Drawing.Size(200, 24);
            this.activoCheckBox1.TabIndex = 17;
            this.activoCheckBox1.UseVisualStyleBackColor = true;
            // 
            // añadirsuplidor
            // 
            this.añadirsuplidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.añadirsuplidor.Location = new System.Drawing.Point(320, 427);
            this.añadirsuplidor.Name = "añadirsuplidor";
            this.añadirsuplidor.Size = new System.Drawing.Size(121, 42);
            this.añadirsuplidor.TabIndex = 22;
            this.añadirsuplidor.Text = "Añadir";
            this.añadirsuplidor.UseVisualStyleBackColor = false;
            this.añadirsuplidor.Click += new System.EventHandler(this.añadirSupli);
            // 
            // guardarSupli
            // 
            this.guardarSupli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(146)))), ((int)(((byte)(213)))));
            this.guardarSupli.Location = new System.Drawing.Point(193, 427);
            this.guardarSupli.Name = "guardarSupli";
            this.guardarSupli.Size = new System.Drawing.Size(121, 42);
            this.guardarSupli.TabIndex = 13;
            this.guardarSupli.Text = "Guardar";
            this.guardarSupli.UseVisualStyleBackColor = false;
            this.guardarSupli.Click += new System.EventHandler(this.saveSupli);
            // 
            // eliminarSupli
            // 
            this.eliminarSupli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.eliminarSupli.Location = new System.Drawing.Point(66, 427);
            this.eliminarSupli.Name = "eliminarSupli";
            this.eliminarSupli.Size = new System.Drawing.Size(121, 42);
            this.eliminarSupli.TabIndex = 14;
            this.eliminarSupli.Text = "Eliminar";
            this.eliminarSupli.UseVisualStyleBackColor = false;
            this.eliminarSupli.Click += new System.EventHandler(this.eliminarSupli_Click);
            // 
            // suplidoresDataGridView
            // 
            this.suplidoresDataGridView.AutoGenerateColumns = false;
            this.suplidoresDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(146)))), ((int)(((byte)(213)))));
            this.suplidoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suplidoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewCheckBoxColumn2});
            this.suplidoresDataGridView.DataSource = this.suplidoresBindingSource;
            this.suplidoresDataGridView.Location = new System.Drawing.Point(461, 56);
            this.suplidoresDataGridView.Name = "suplidoresDataGridView";
            this.suplidoresDataGridView.RowHeadersWidth = 62;
            this.suplidoresDataGridView.RowTemplate.Height = 28;
            this.suplidoresDataGridView.Size = new System.Drawing.Size(463, 324);
            this.suplidoresDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SuplidorID";
            this.dataGridViewTextBoxColumn6.HeaderText = "SuplidorID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NombreEmpresa";
            this.dataGridViewTextBoxColumn7.HeaderText = "NombreEmpresa";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NombreContacto";
            this.dataGridViewTextBoxColumn8.HeaderText = "NombreContacto";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn9.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Correo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "SitioWeb";
            this.dataGridViewTextBoxColumn11.HeaderText = "SitioWeb";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "FechaCreacion";
            this.dataGridViewTextBoxColumn12.HeaderText = "FechaCreacion";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "FechaModificacion";
            this.dataGridViewTextBoxColumn13.HeaderText = "FechaModificacion";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Activo";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Activo";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 150;
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.BackgroundImage = global::ValidationsP1.Properties.Resources.PAP_1;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.button11);
            this.tabPage4.Controls.Add(this.SaveProdu);
            this.tabPage4.Controls.Add(this.eliminarProdu);
            this.tabPage4.Controls.Add(this.productosDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(987, 505);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Productos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.groupBox3.Controls.Add(productoIDLabel);
            this.groupBox3.Controls.Add(this.productoIDTextBox);
            this.groupBox3.Controls.Add(nombreProductoLabel);
            this.groupBox3.Controls.Add(this.nombreProductoTextBox);
            this.groupBox3.Controls.Add(precioUnitarioLabel);
            this.groupBox3.Controls.Add(this.precioUnitarioTextBox);
            this.groupBox3.Controls.Add(categoriaIDLabel2);
            this.groupBox3.Controls.Add(this.categoriaIDTextBox2);
            this.groupBox3.Controls.Add(suplidorIDLabel1);
            this.groupBox3.Controls.Add(this.suplidorIDTextBox1);
            this.groupBox3.Controls.Add(fechaCreacionLabel3);
            this.groupBox3.Controls.Add(this.fechaCreacionDateTimePicker3);
            this.groupBox3.Controls.Add(fechaModificacionLabel2);
            this.groupBox3.Controls.Add(this.fechaModificacionDateTimePicker2);
            this.groupBox3.Controls.Add(activoLabel3);
            this.groupBox3.Controls.Add(this.activoCheckBox3);
            this.groupBox3.Location = new System.Drawing.Point(51, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 302);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos";
            // 
            // productoIDTextBox
            // 
            this.productoIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "ProductoID", true));
            this.productoIDTextBox.Location = new System.Drawing.Point(172, 28);
            this.productoIDTextBox.Name = "productoIDTextBox";
            this.productoIDTextBox.Size = new System.Drawing.Size(200, 28);
            this.productoIDTextBox.TabIndex = 1;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.gestionProductosDBDataSet;
            // 
            // nombreProductoTextBox
            // 
            this.nombreProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "NombreProducto", true));
            this.nombreProductoTextBox.Location = new System.Drawing.Point(172, 60);
            this.nombreProductoTextBox.Name = "nombreProductoTextBox";
            this.nombreProductoTextBox.Size = new System.Drawing.Size(200, 28);
            this.nombreProductoTextBox.TabIndex = 3;
            // 
            // precioUnitarioTextBox
            // 
            this.precioUnitarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "PrecioUnitario", true));
            this.precioUnitarioTextBox.Location = new System.Drawing.Point(172, 92);
            this.precioUnitarioTextBox.Name = "precioUnitarioTextBox";
            this.precioUnitarioTextBox.Size = new System.Drawing.Size(200, 28);
            this.precioUnitarioTextBox.TabIndex = 5;
            // 
            // categoriaIDTextBox2
            // 
            this.categoriaIDTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "CategoriaID", true));
            this.categoriaIDTextBox2.Location = new System.Drawing.Point(172, 124);
            this.categoriaIDTextBox2.Name = "categoriaIDTextBox2";
            this.categoriaIDTextBox2.Size = new System.Drawing.Size(200, 28);
            this.categoriaIDTextBox2.TabIndex = 7;
            // 
            // suplidorIDTextBox1
            // 
            this.suplidorIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "SuplidorID", true));
            this.suplidorIDTextBox1.Location = new System.Drawing.Point(172, 156);
            this.suplidorIDTextBox1.Name = "suplidorIDTextBox1";
            this.suplidorIDTextBox1.Size = new System.Drawing.Size(200, 28);
            this.suplidorIDTextBox1.TabIndex = 9;
            // 
            // fechaCreacionDateTimePicker3
            // 
            this.fechaCreacionDateTimePicker3.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productosBindingSource, "FechaCreacion", true));
            this.fechaCreacionDateTimePicker3.Location = new System.Drawing.Point(172, 188);
            this.fechaCreacionDateTimePicker3.Name = "fechaCreacionDateTimePicker3";
            this.fechaCreacionDateTimePicker3.Size = new System.Drawing.Size(200, 28);
            this.fechaCreacionDateTimePicker3.TabIndex = 11;
            // 
            // fechaModificacionDateTimePicker2
            // 
            this.fechaModificacionDateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productosBindingSource, "FechaModificacion", true));
            this.fechaModificacionDateTimePicker2.Location = new System.Drawing.Point(172, 220);
            this.fechaModificacionDateTimePicker2.Name = "fechaModificacionDateTimePicker2";
            this.fechaModificacionDateTimePicker2.Size = new System.Drawing.Size(200, 28);
            this.fechaModificacionDateTimePicker2.TabIndex = 13;
            // 
            // activoCheckBox3
            // 
            this.activoCheckBox3.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productosBindingSource, "Activo", true));
            this.activoCheckBox3.Location = new System.Drawing.Point(172, 252);
            this.activoCheckBox3.Name = "activoCheckBox3";
            this.activoCheckBox3.Size = new System.Drawing.Size(200, 24);
            this.activoCheckBox3.TabIndex = 15;
            this.activoCheckBox3.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(146)))), ((int)(((byte)(213)))));
            this.button11.Location = new System.Drawing.Point(315, 418);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(121, 42);
            this.button11.TabIndex = 17;
            this.button11.Text = "Añadir";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.añadirProdu);
            // 
            // SaveProdu
            // 
            this.SaveProdu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.SaveProdu.Location = new System.Drawing.Point(188, 418);
            this.SaveProdu.Name = "SaveProdu";
            this.SaveProdu.Size = new System.Drawing.Size(121, 42);
            this.SaveProdu.TabIndex = 13;
            this.SaveProdu.Text = "Guardar";
            this.SaveProdu.UseVisualStyleBackColor = false;
            this.SaveProdu.Click += new System.EventHandler(this.Save_Click);
            // 
            // eliminarProdu
            // 
            this.eliminarProdu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(146)))), ((int)(((byte)(213)))));
            this.eliminarProdu.Location = new System.Drawing.Point(61, 418);
            this.eliminarProdu.Name = "eliminarProdu";
            this.eliminarProdu.Size = new System.Drawing.Size(121, 42);
            this.eliminarProdu.TabIndex = 14;
            this.eliminarProdu.Text = "Eliminar";
            this.eliminarProdu.UseVisualStyleBackColor = false;
            this.eliminarProdu.Click += new System.EventHandler(this.eliminarProdu_Click);
            // 
            // productosDataGridView
            // 
            this.productosDataGridView.AutoGenerateColumns = false;
            this.productosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.productosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewCheckBoxColumn4});
            this.productosDataGridView.DataSource = this.productosBindingSource;
            this.productosDataGridView.Location = new System.Drawing.Point(448, 78);
            this.productosDataGridView.Name = "productosDataGridView";
            this.productosDataGridView.RowHeadersWidth = 62;
            this.productosDataGridView.RowTemplate.Height = 28;
            this.productosDataGridView.Size = new System.Drawing.Size(481, 302);
            this.productosDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "ProductoID";
            this.dataGridViewTextBoxColumn18.HeaderText = "ProductoID";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 150;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "NombreProducto";
            this.dataGridViewTextBoxColumn19.HeaderText = "NombreProducto";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 150;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "PrecioUnitario";
            this.dataGridViewTextBoxColumn20.HeaderText = "PrecioUnitario";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 150;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "CategoriaID";
            this.dataGridViewTextBoxColumn21.HeaderText = "CategoriaID";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 150;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "SuplidorID";
            this.dataGridViewTextBoxColumn22.HeaderText = "SuplidorID";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 150;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "FechaCreacion";
            this.dataGridViewTextBoxColumn23.HeaderText = "FechaCreacion";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 150;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "FechaModificacion";
            this.dataGridViewTextBoxColumn24.HeaderText = "FechaModificacion";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 150;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "Activo";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Activo";
            this.dataGridViewCheckBoxColumn4.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.Width = 150;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = this.categoriasTableAdapter;
            this.tableAdapterManager.FotosCategoriaTableAdapter = this.fotosCategoriaTableAdapter;
            this.tableAdapterManager.ProductosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.SuplidoresTableAdapter = this.suplidoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = ValidationsP1.GestionProductosDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fotosCategoriaTableAdapter
            // 
            this.fotosCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // suplidoresTableAdapter
            // 
            this.suplidoresTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(995, 535);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.CategoryGroup.ResumeLayout(false);
            this.CategoryGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotosCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotosCategoriaDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suplidoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplidoresDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private GestionProductosDBDataSet gestionProductosDBDataSet;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private GestionProductosDBDataSetTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private GestionProductosDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button guardarcate;
        private System.Windows.Forms.Button EliminarCate;
        private System.Windows.Forms.TextBox nombreCategoriaTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.DateTimePicker fechaCreacionDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaModificacionDateTimePicker;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.DataGridView categoriasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TabPage tabPage3;
        private GestionProductosDBDataSetTableAdapters.SuplidoresTableAdapter suplidoresTableAdapter;
        private System.Windows.Forms.BindingSource suplidoresBindingSource;
        private System.Windows.Forms.Button guardarSupli;
        private System.Windows.Forms.Button eliminarSupli;
        private System.Windows.Forms.DataGridView suplidoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.TextBox suplidorIDTextBox;
        private System.Windows.Forms.TextBox nombreEmpresaTextBox;
        private System.Windows.Forms.TextBox nombreContactoTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox sitioWebTextBox;
        private System.Windows.Forms.DateTimePicker fechaCreacionDateTimePicker1;
        private System.Windows.Forms.DateTimePicker fechaModificacionDateTimePicker1;
        private System.Windows.Forms.CheckBox activoCheckBox1;
        private GestionProductosDBDataSetTableAdapters.FotosCategoriaTableAdapter fotosCategoriaTableAdapter;
        private System.Windows.Forms.BindingSource fotosCategoriaBindingSource;
        private System.Windows.Forms.Button guardarCata;
        private System.Windows.Forms.Button eliminarCata;
        private System.Windows.Forms.DataGridView fotosCategoriaDataGridView;
        private System.Windows.Forms.TextBox fotoIDTextBox;
        private System.Windows.Forms.TextBox categoriaIDTextBox1;
        private System.Windows.Forms.DateTimePicker fechaCreacionDateTimePicker2;
        private System.Windows.Forms.CheckBox activoCheckBox2;
        private System.Windows.Forms.TabPage tabPage4;
        private GestionProductosDBDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private System.Windows.Forms.Button SaveProdu;
        private System.Windows.Forms.Button eliminarProdu;
        private System.Windows.Forms.DataGridView productosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.TextBox productoIDTextBox;
        private System.Windows.Forms.TextBox nombreProductoTextBox;
        private System.Windows.Forms.TextBox precioUnitarioTextBox;
        private System.Windows.Forms.TextBox categoriaIDTextBox2;
        private System.Windows.Forms.TextBox suplidorIDTextBox1;
        private System.Windows.Forms.DateTimePicker fechaCreacionDateTimePicker3;
        private System.Windows.Forms.DateTimePicker fechaModificacionDateTimePicker2;
        private System.Windows.Forms.CheckBox activoCheckBox3;
        private System.Windows.Forms.MaskedTextBox telefonoMaskedTextBox;
        private System.Windows.Forms.Button añadirsuplidor;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button añadirCate;
        private System.Windows.Forms.TextBox categoriaIDTextBox;
        private System.Windows.Forms.Button añadirCata;
        private System.Windows.Forms.GroupBox CategoryGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.Button btnFoto;
        public System.Windows.Forms.TextBox rutaFotoTextBox;
    }
}

