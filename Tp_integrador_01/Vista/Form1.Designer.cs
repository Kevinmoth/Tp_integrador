namespace Tp_integrador_01
{
    partial class BiblioMax
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
            System.Windows.Forms.TabControl tabControl01;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiblioMax));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mail_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.direccion_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.telefono_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dni_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nombre_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.apellido_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.registrar_boton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.localidad_txt = new System.Windows.Forms.ComboBox();
            this.dataGridAlumno = new System.Windows.Forms.DataGridView();
            this.Alumnos = new System.Windows.Forms.TabPage();
            this.comboBoxEjemplar = new System.Windows.Forms.ComboBox();
            this.Ejemplar = new System.Windows.Forms.Label();
            this.comboBoxBibliotecarios = new System.Windows.Forms.ComboBox();
            this.TablaPrestamos = new System.Windows.Forms.DataGridView();
            this.comboBoxLibro = new System.Windows.Forms.ComboBox();
            this.comboBoxAlumno = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tablaLibros = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.ejemplares_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.generoLibro_txt = new System.Windows.Forms.TextBox();
            this.editorial_txt = new System.Windows.Forms.TextBox();
            this.autor_txt = new System.Windows.Forms.TextBox();
            this.isnb_txt = new System.Windows.Forms.TextBox();
            this.libro_txt = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Eliminar_Alumno = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            tabControl01 = new System.Windows.Forms.TabControl();
            tabControl01.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumno)).BeginInit();
            this.Alumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPrestamos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl01
            // 
            tabControl01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tabControl01.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            tabControl01.Controls.Add(this.tabPage1);
            tabControl01.Controls.Add(this.Alumnos);
            tabControl01.Controls.Add(this.tabPage2);
            tabControl01.Cursor = System.Windows.Forms.Cursors.Hand;
            tabControl01.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tabControl01.HotTrack = true;
            tabControl01.ItemSize = new System.Drawing.Size(57, 27);
            tabControl01.Location = new System.Drawing.Point(1, 3);
            tabControl01.Name = "tabControl01";
            tabControl01.Padding = new System.Drawing.Point(40, 3);
            tabControl01.SelectedIndex = 0;
            tabControl01.ShowToolTips = true;
            tabControl01.Size = new System.Drawing.Size(902, 394);
            tabControl01.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.Eliminar_Alumno);
            this.tabPage1.Controls.Add(this.mail_txt);
            this.tabPage1.Controls.Add(this.direccion_txt);
            this.tabPage1.Controls.Add(this.telefono_txt);
            this.tabPage1.Controls.Add(this.dni_txt);
            this.tabPage1.Controls.Add(this.nombre_txt);
            this.tabPage1.Controls.Add(this.apellido_txt);
            this.tabPage1.Controls.Add(this.materialLabel7);
            this.tabPage1.Controls.Add(this.materialLabel6);
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.registrar_boton1);
            this.tabPage1.Controls.Add(this.localidad_txt);
            this.tabPage1.Controls.Add(this.dataGridAlumno);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(894, 359);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Alumnos";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // mail_txt
            // 
            this.mail_txt.Depth = 0;
            this.mail_txt.Hint = "";
            this.mail_txt.Location = new System.Drawing.Point(90, 230);
            this.mail_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.mail_txt.Name = "mail_txt";
            this.mail_txt.PasswordChar = '\0';
            this.mail_txt.SelectedText = "";
            this.mail_txt.SelectionLength = 0;
            this.mail_txt.SelectionStart = 0;
            this.mail_txt.Size = new System.Drawing.Size(110, 23);
            this.mail_txt.TabIndex = 5;
            this.mail_txt.UseSystemPasswordChar = false;
            // 
            // direccion_txt
            // 
            this.direccion_txt.Depth = 0;
            this.direccion_txt.Hint = "";
            this.direccion_txt.Location = new System.Drawing.Point(92, 187);
            this.direccion_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.direccion_txt.Name = "direccion_txt";
            this.direccion_txt.PasswordChar = '\0';
            this.direccion_txt.SelectedText = "";
            this.direccion_txt.SelectionLength = 0;
            this.direccion_txt.SelectionStart = 0;
            this.direccion_txt.Size = new System.Drawing.Size(110, 23);
            this.direccion_txt.TabIndex = 4;
            this.direccion_txt.UseSystemPasswordChar = false;
            this.direccion_txt.Click += new System.EventHandler(this.direccion_txt_Click);
            // 
            // telefono_txt
            // 
            this.telefono_txt.Depth = 0;
            this.telefono_txt.Hint = "";
            this.telefono_txt.Location = new System.Drawing.Point(90, 145);
            this.telefono_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.telefono_txt.Name = "telefono_txt";
            this.telefono_txt.PasswordChar = '\0';
            this.telefono_txt.SelectedText = "";
            this.telefono_txt.SelectionLength = 0;
            this.telefono_txt.SelectionStart = 0;
            this.telefono_txt.Size = new System.Drawing.Size(110, 23);
            this.telefono_txt.TabIndex = 3;
            this.telefono_txt.UseSystemPasswordChar = false;
            // 
            // dni_txt
            // 
            this.dni_txt.Depth = 0;
            this.dni_txt.Hint = "";
            this.dni_txt.Location = new System.Drawing.Point(90, 107);
            this.dni_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.dni_txt.Name = "dni_txt";
            this.dni_txt.PasswordChar = '\0';
            this.dni_txt.SelectedText = "";
            this.dni_txt.SelectionLength = 0;
            this.dni_txt.SelectionStart = 0;
            this.dni_txt.Size = new System.Drawing.Size(110, 23);
            this.dni_txt.TabIndex = 2;
            this.dni_txt.UseSystemPasswordChar = false;
            // 
            // nombre_txt
            // 
            this.nombre_txt.Depth = 0;
            this.nombre_txt.Hint = "";
            this.nombre_txt.Location = new System.Drawing.Point(90, 68);
            this.nombre_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.PasswordChar = '\0';
            this.nombre_txt.SelectedText = "";
            this.nombre_txt.SelectionLength = 0;
            this.nombre_txt.SelectionStart = 0;
            this.nombre_txt.Size = new System.Drawing.Size(110, 23);
            this.nombre_txt.TabIndex = 1;
            this.nombre_txt.UseSystemPasswordChar = false;
            // 
            // apellido_txt
            // 
            this.apellido_txt.Depth = 0;
            this.apellido_txt.Hint = "";
            this.apellido_txt.Location = new System.Drawing.Point(90, 31);
            this.apellido_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.apellido_txt.Name = "apellido_txt";
            this.apellido_txt.PasswordChar = '\0';
            this.apellido_txt.SelectedText = "";
            this.apellido_txt.SelectionLength = 0;
            this.apellido_txt.SelectionStart = 0;
            this.apellido_txt.Size = new System.Drawing.Size(110, 23);
            this.apellido_txt.TabIndex = 0;
            this.apellido_txt.UseSystemPasswordChar = false;
            this.apellido_txt.Click += new System.EventHandler(this.apellido_txt_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(17, 277);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(74, 19);
            this.materialLabel7.TabIndex = 27;
            this.materialLabel7.Text = "Localidad";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(17, 230);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(38, 19);
            this.materialLabel6.TabIndex = 26;
            this.materialLabel6.Text = "Mail";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(17, 191);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(73, 19);
            this.materialLabel5.TabIndex = 25;
            this.materialLabel5.Text = "Direccion";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(17, 149);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(69, 19);
            this.materialLabel4.TabIndex = 24;
            this.materialLabel4.Text = "Telefono";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(17, 111);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(34, 19);
            this.materialLabel3.TabIndex = 23;
            this.materialLabel3.Text = "DNI";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(17, 72);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(63, 19);
            this.materialLabel2.TabIndex = 22;
            this.materialLabel2.Text = "Nombre";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(17, 31);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 19);
            this.materialLabel1.TabIndex = 21;
            this.materialLabel1.Text = "Apellido";
            // 
            // registrar_boton1
            // 
            this.registrar_boton1.AutoSize = true;
            this.registrar_boton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registrar_boton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrar_boton1.Depth = 0;
            this.registrar_boton1.Location = new System.Drawing.Point(70, 313);
            this.registrar_boton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registrar_boton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.registrar_boton1.Name = "registrar_boton1";
            this.registrar_boton1.Primary = false;
            this.registrar_boton1.Size = new System.Drawing.Size(84, 36);
            this.registrar_boton1.TabIndex = 7;
            this.registrar_boton1.Text = "Registrar";
            this.registrar_boton1.UseVisualStyleBackColor = true;
            this.registrar_boton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // localidad_txt
            // 
            this.localidad_txt.FormattingEnabled = true;
            this.localidad_txt.Items.AddRange(new object[] {
            "Seleccione su localidad..",
            "Obera",
            "Alem",
            "Eldorado",
            "Posadas",
            "Cerro Azul",
            "albapose"});
            this.localidad_txt.Location = new System.Drawing.Point(95, 275);
            this.localidad_txt.Name = "localidad_txt";
            this.localidad_txt.Size = new System.Drawing.Size(110, 27);
            this.localidad_txt.TabIndex = 6;
            this.localidad_txt.Tag = "";
            this.localidad_txt.SelectedIndexChanged += new System.EventHandler(this.localidad_txt_SelectedIndexChanged);
            // 
            // dataGridAlumno
            // 
            this.dataGridAlumno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridAlumno.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridAlumno.BackgroundColor = System.Drawing.Color.White;
            this.dataGridAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlumno.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridAlumno.GridColor = System.Drawing.Color.White;
            this.dataGridAlumno.Location = new System.Drawing.Point(223, 20);
            this.dataGridAlumno.Name = "dataGridAlumno";
            this.dataGridAlumno.ReadOnly = true;
            this.dataGridAlumno.Size = new System.Drawing.Size(653, 289);
            this.dataGridAlumno.TabIndex = 99;
            // 
            // Alumnos
            // 
            this.Alumnos.Controls.Add(this.materialFlatButton2);
            this.Alumnos.Controls.Add(this.materialFlatButton1);
            this.Alumnos.Controls.Add(this.comboBoxEjemplar);
            this.Alumnos.Controls.Add(this.Ejemplar);
            this.Alumnos.Controls.Add(this.comboBoxBibliotecarios);
            this.Alumnos.Controls.Add(this.TablaPrestamos);
            this.Alumnos.Controls.Add(this.comboBoxLibro);
            this.Alumnos.Controls.Add(this.comboBoxAlumno);
            this.Alumnos.Controls.Add(this.label16);
            this.Alumnos.Controls.Add(this.label17);
            this.Alumnos.Controls.Add(this.label18);
            this.Alumnos.Location = new System.Drawing.Point(4, 31);
            this.Alumnos.Name = "Alumnos";
            this.Alumnos.Padding = new System.Windows.Forms.Padding(3);
            this.Alumnos.Size = new System.Drawing.Size(894, 359);
            this.Alumnos.TabIndex = 0;
            this.Alumnos.Text = "Prestamos";
            this.Alumnos.UseVisualStyleBackColor = true;
            this.Alumnos.Click += new System.EventHandler(this.Alumnos_Click);
            // 
            // comboBoxEjemplar
            // 
            this.comboBoxEjemplar.Location = new System.Drawing.Point(121, 131);
            this.comboBoxEjemplar.Name = "comboBoxEjemplar";
            this.comboBoxEjemplar.Size = new System.Drawing.Size(100, 27);
            this.comboBoxEjemplar.TabIndex = 53;
            // 
            // Ejemplar
            // 
            this.Ejemplar.AutoSize = true;
            this.Ejemplar.Location = new System.Drawing.Point(21, 134);
            this.Ejemplar.Name = "Ejemplar";
            this.Ejemplar.Size = new System.Drawing.Size(68, 19);
            this.Ejemplar.TabIndex = 52;
            this.Ejemplar.Text = "Ejemplar";
            // 
            // comboBoxBibliotecarios
            // 
            this.comboBoxBibliotecarios.FormattingEnabled = true;
            this.comboBoxBibliotecarios.Location = new System.Drawing.Point(121, 173);
            this.comboBoxBibliotecarios.Name = "comboBoxBibliotecarios";
            this.comboBoxBibliotecarios.Size = new System.Drawing.Size(100, 27);
            this.comboBoxBibliotecarios.TabIndex = 51;
            this.comboBoxBibliotecarios.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TablaPrestamos
            // 
            this.TablaPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaPrestamos.Location = new System.Drawing.Point(244, 6);
            this.TablaPrestamos.Name = "TablaPrestamos";
            this.TablaPrestamos.Size = new System.Drawing.Size(627, 284);
            this.TablaPrestamos.TabIndex = 48;
            // 
            // comboBoxLibro
            // 
            this.comboBoxLibro.FormattingEnabled = true;
            this.comboBoxLibro.Location = new System.Drawing.Point(121, 90);
            this.comboBoxLibro.Name = "comboBoxLibro";
            this.comboBoxLibro.Size = new System.Drawing.Size(100, 27);
            this.comboBoxLibro.TabIndex = 47;
            this.comboBoxLibro.SelectedIndexChanged += new System.EventHandler(this.comboBoxLibro_SelectedIndexChanged);
            this.comboBoxLibro.TextChanged += new System.EventHandler(this.comboBoxLibro_TextChanged);
            // 
            // comboBoxAlumno
            // 
            this.comboBoxAlumno.FormattingEnabled = true;
            this.comboBoxAlumno.Location = new System.Drawing.Point(121, 53);
            this.comboBoxAlumno.Name = "comboBoxAlumno";
            this.comboBoxAlumno.Size = new System.Drawing.Size(100, 27);
            this.comboBoxAlumno.TabIndex = 46;
            this.comboBoxAlumno.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlumno_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 176);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 19);
            this.label16.TabIndex = 45;
            this.label16.Text = "Bibliotecario";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 93);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 19);
            this.label17.TabIndex = 44;
            this.label17.Text = "Libro";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 19);
            this.label18.TabIndex = 43;
            this.label18.Text = "Alumno";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tablaLibros);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.ejemplares_txt);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.generoLibro_txt);
            this.tabPage2.Controls.Add(this.editorial_txt);
            this.tabPage2.Controls.Add(this.autor_txt);
            this.tabPage2.Controls.Add(this.isnb_txt);
            this.tabPage2.Controls.Add(this.libro_txt);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(894, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Libros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tablaLibros
            // 
            this.tablaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaLibros.Location = new System.Drawing.Point(240, 6);
            this.tablaLibros.Name = "tablaLibros";
            this.tablaLibros.Size = new System.Drawing.Size(571, 285);
            this.tablaLibros.TabIndex = 38;
            this.tablaLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "Ejemplares";
            // 
            // ejemplares_txt
            // 
            this.ejemplares_txt.Location = new System.Drawing.Point(119, 238);
            this.ejemplares_txt.Name = "ejemplares_txt";
            this.ejemplares_txt.Size = new System.Drawing.Size(100, 26);
            this.ejemplares_txt.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "Genero";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "Editorial";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 19);
            this.label10.TabIndex = 33;
            this.label10.Text = "Autor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 19);
            this.label11.TabIndex = 32;
            this.label11.Text = "ISNB";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 19);
            this.label12.TabIndex = 31;
            this.label12.Text = "Titulo";
            // 
            // generoLibro_txt
            // 
            this.generoLibro_txt.Location = new System.Drawing.Point(119, 197);
            this.generoLibro_txt.Name = "generoLibro_txt";
            this.generoLibro_txt.Size = new System.Drawing.Size(100, 26);
            this.generoLibro_txt.TabIndex = 30;
            // 
            // editorial_txt
            // 
            this.editorial_txt.Location = new System.Drawing.Point(119, 155);
            this.editorial_txt.Name = "editorial_txt";
            this.editorial_txt.Size = new System.Drawing.Size(100, 26);
            this.editorial_txt.TabIndex = 29;
            // 
            // autor_txt
            // 
            this.autor_txt.Location = new System.Drawing.Point(119, 117);
            this.autor_txt.Name = "autor_txt";
            this.autor_txt.Size = new System.Drawing.Size(100, 26);
            this.autor_txt.TabIndex = 28;
            // 
            // isnb_txt
            // 
            this.isnb_txt.Location = new System.Drawing.Point(119, 78);
            this.isnb_txt.Name = "isnb_txt";
            this.isnb_txt.Size = new System.Drawing.Size(100, 26);
            this.isnb_txt.TabIndex = 27;
            // 
            // libro_txt
            // 
            this.libro_txt.Location = new System.Drawing.Point(119, 41);
            this.libro_txt.Name = "libro_txt";
            this.libro_txt.Size = new System.Drawing.Size(100, 26);
            this.libro_txt.TabIndex = 26;
            this.libro_txt.TextChanged += new System.EventHandler(this.libro_txt_TextChanged);
            // 
            // Eliminar_Alumno
            // 
            this.Eliminar_Alumno.AutoSize = true;
            this.Eliminar_Alumno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Eliminar_Alumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Eliminar_Alumno.Depth = 0;
            this.Eliminar_Alumno.Location = new System.Drawing.Point(485, 318);
            this.Eliminar_Alumno.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Eliminar_Alumno.MouseState = MaterialSkin.MouseState.HOVER;
            this.Eliminar_Alumno.Name = "Eliminar_Alumno";
            this.Eliminar_Alumno.Primary = false;
            this.Eliminar_Alumno.Size = new System.Drawing.Size(74, 36);
            this.Eliminar_Alumno.TabIndex = 100;
            this.Eliminar_Alumno.Text = "Eliminar ";
            this.Eliminar_Alumno.UseVisualStyleBackColor = true;
            this.Eliminar_Alumno.Click += new System.EventHandler(this.Eliminar_Alumno_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(174, 312);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(84, 36);
            this.materialFlatButton1.TabIndex = 101;
            this.materialFlatButton1.Text = "Prestamo";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click_1);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(588, 312);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(95, 36);
            this.materialFlatButton2.TabIndex = 102;
            this.materialFlatButton2.Text = "Devolucion";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // BiblioMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 397);
            this.Controls.Add(tabControl01);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BiblioMax";
            this.Text = "BiblioMax";
            this.Load += new System.EventHandler(this.BiblioMax_Load);
            tabControl01.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumno)).EndInit();
            this.Alumnos.ResumeLayout(false);
            this.Alumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPrestamos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridAlumno;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage Alumnos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox generoLibro_txt;
        private System.Windows.Forms.TextBox editorial_txt;
        private System.Windows.Forms.TextBox autor_txt;
        private System.Windows.Forms.TextBox isnb_txt;
        private System.Windows.Forms.TextBox libro_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ejemplares_txt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView tablaLibros;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBoxAlumno;
        private System.Windows.Forms.DataGridView TablaPrestamos;
        private System.Windows.Forms.ComboBox localidad_txt;
        private System.Windows.Forms.ComboBox comboBoxBibliotecarios;
        private System.Windows.Forms.Label Ejemplar;
        private MaterialSkin.Controls.MaterialFlatButton registrar_boton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField apellido_txt;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField nombre_txt;
        private MaterialSkin.Controls.MaterialSingleLineTextField direccion_txt;
        private MaterialSkin.Controls.MaterialSingleLineTextField telefono_txt;
        private MaterialSkin.Controls.MaterialSingleLineTextField dni_txt;
        private MaterialSkin.Controls.MaterialSingleLineTextField mail_txt;
        public System.Windows.Forms.ComboBox comboBoxLibro;
        public System.Windows.Forms.ComboBox comboBoxEjemplar;
        private MaterialSkin.Controls.MaterialFlatButton Eliminar_Alumno;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
    }
}

