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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabControl tabControl01;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiblioMax));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridAlumno = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Eliminar_Alumno = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.mail_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.direccion_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.localidad_txt = new System.Windows.Forms.ComboBox();
            this.telefono_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.registrar_boton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dni_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.nombre_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.apellido_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.Alumnos = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.comboBoxEjemplar = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Ejemplar = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxBibliotecarios = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxLibro = new System.Windows.Forms.ComboBox();
            this.comboBoxAlumno = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.TablaPrestamos = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.TablaSuspensiones = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tablaLibros = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.editorial_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.libro_txt = new System.Windows.Forms.TextBox();
            this.ejemplares_txt = new System.Windows.Forms.TextBox();
            this.isnb_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.autor_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.generoLibro_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            tabControl01 = new System.Windows.Forms.TabControl();
            tabControl01.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumno)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Alumnos.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPrestamos)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaSuspensiones)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLibros)).BeginInit();
            this.panel5.SuspendLayout();
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
            tabControl01.Controls.Add(this.tabPage3);
            tabControl01.Controls.Add(this.tabPage2);
            tabControl01.Cursor = System.Windows.Forms.Cursors.Hand;
            tabControl01.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tabControl01.HotTrack = true;
            tabControl01.ImageList = this.imageList1;
            tabControl01.ItemSize = new System.Drawing.Size(57, 37);
            tabControl01.Location = new System.Drawing.Point(1, 3);
            tabControl01.Name = "tabControl01";
            tabControl01.Padding = new System.Drawing.Point(40, 3);
            tabControl01.SelectedIndex = 0;
            tabControl01.ShowToolTips = true;
            tabControl01.Size = new System.Drawing.Size(953, 452);
            tabControl01.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.dataGridAlumno);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.ImageIndex = 3;
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(945, 407);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Alumnos";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
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
            this.dataGridAlumno.Location = new System.Drawing.Point(242, 20);
            this.dataGridAlumno.Name = "dataGridAlumno";
            this.dataGridAlumno.ReadOnly = true;
            this.dataGridAlumno.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridAlumno.Size = new System.Drawing.Size(680, 313);
            this.dataGridAlumno.TabIndex = 99;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Eliminar_Alumno);
            this.panel2.Location = new System.Drawing.Point(230, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 391);
            this.panel2.TabIndex = 102;
            // 
            // Eliminar_Alumno
            // 
            this.Eliminar_Alumno.AutoSize = true;
            this.Eliminar_Alumno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Eliminar_Alumno.BackColor = System.Drawing.Color.Silver;
            this.Eliminar_Alumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Eliminar_Alumno.Depth = 0;
            this.Eliminar_Alumno.Location = new System.Drawing.Point(322, 347);
            this.Eliminar_Alumno.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Eliminar_Alumno.MouseState = MaterialSkin.MouseState.HOVER;
            this.Eliminar_Alumno.Name = "Eliminar_Alumno";
            this.Eliminar_Alumno.Primary = false;
            this.Eliminar_Alumno.Size = new System.Drawing.Size(74, 36);
            this.Eliminar_Alumno.TabIndex = 100;
            this.Eliminar_Alumno.Text = "Eliminar ";
            this.Eliminar_Alumno.UseVisualStyleBackColor = false;
            this.Eliminar_Alumno.Click += new System.EventHandler(this.Eliminar_Alumno_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.materialLabel8);
            this.panel1.Controls.Add(this.mail_txt);
            this.panel1.Controls.Add(this.direccion_txt);
            this.panel1.Controls.Add(this.localidad_txt);
            this.panel1.Controls.Add(this.telefono_txt);
            this.panel1.Controls.Add(this.registrar_boton1);
            this.panel1.Controls.Add(this.dni_txt);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.nombre_txt);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.apellido_txt);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Location = new System.Drawing.Point(5, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 391);
            this.panel1.TabIndex = 101;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(64, 11);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(78, 19);
            this.materialLabel8.TabIndex = 28;
            this.materialLabel8.Text = "REGISTRO";
            this.materialLabel8.Click += new System.EventHandler(this.materialLabel8_Click);
            // 
            // mail_txt
            // 
            this.mail_txt.Depth = 0;
            this.mail_txt.Hint = "";
            this.mail_txt.Location = new System.Drawing.Point(88, 253);
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
            this.direccion_txt.Location = new System.Drawing.Point(90, 210);
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
            this.localidad_txt.Location = new System.Drawing.Point(93, 298);
            this.localidad_txt.Name = "localidad_txt";
            this.localidad_txt.Size = new System.Drawing.Size(110, 28);
            this.localidad_txt.TabIndex = 6;
            this.localidad_txt.Tag = "";
            this.localidad_txt.SelectedIndexChanged += new System.EventHandler(this.localidad_txt_SelectedIndexChanged);
            // 
            // telefono_txt
            // 
            this.telefono_txt.Depth = 0;
            this.telefono_txt.Hint = "";
            this.telefono_txt.Location = new System.Drawing.Point(88, 168);
            this.telefono_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.telefono_txt.Name = "telefono_txt";
            this.telefono_txt.PasswordChar = '\0';
            this.telefono_txt.SelectedText = "";
            this.telefono_txt.SelectionLength = 0;
            this.telefono_txt.SelectionStart = 0;
            this.telefono_txt.Size = new System.Drawing.Size(110, 23);
            this.telefono_txt.TabIndex = 3;
            this.telefono_txt.UseSystemPasswordChar = false;
            this.telefono_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefono_txt_KeyPress);
            // 
            // registrar_boton1
            // 
            this.registrar_boton1.AutoSize = true;
            this.registrar_boton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registrar_boton1.BackColor = System.Drawing.Color.Silver;
            this.registrar_boton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrar_boton1.Depth = 0;
            this.registrar_boton1.Location = new System.Drawing.Point(68, 336);
            this.registrar_boton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registrar_boton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.registrar_boton1.Name = "registrar_boton1";
            this.registrar_boton1.Primary = false;
            this.registrar_boton1.Size = new System.Drawing.Size(84, 36);
            this.registrar_boton1.TabIndex = 7;
            this.registrar_boton1.Text = "Registrar";
            this.registrar_boton1.UseVisualStyleBackColor = false;
            this.registrar_boton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // dni_txt
            // 
            this.dni_txt.Depth = 0;
            this.dni_txt.Hint = "";
            this.dni_txt.Location = new System.Drawing.Point(88, 130);
            this.dni_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.dni_txt.Name = "dni_txt";
            this.dni_txt.PasswordChar = '\0';
            this.dni_txt.SelectedText = "";
            this.dni_txt.SelectionLength = 0;
            this.dni_txt.SelectionStart = 0;
            this.dni_txt.Size = new System.Drawing.Size(110, 23);
            this.dni_txt.TabIndex = 2;
            this.dni_txt.UseSystemPasswordChar = false;
            this.dni_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dni_txt_KeyPress);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(15, 54);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 19);
            this.materialLabel1.TabIndex = 21;
            this.materialLabel1.Text = "Apellido";
            // 
            // nombre_txt
            // 
            this.nombre_txt.Depth = 0;
            this.nombre_txt.Hint = "";
            this.nombre_txt.Location = new System.Drawing.Point(88, 91);
            this.nombre_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.PasswordChar = '\0';
            this.nombre_txt.SelectedText = "";
            this.nombre_txt.SelectionLength = 0;
            this.nombre_txt.SelectionStart = 0;
            this.nombre_txt.Size = new System.Drawing.Size(110, 23);
            this.nombre_txt.TabIndex = 1;
            this.nombre_txt.UseSystemPasswordChar = false;
            this.nombre_txt.Click += new System.EventHandler(this.nombre_txt_Click);
            this.nombre_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_txt_KeyPress);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(15, 95);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(63, 19);
            this.materialLabel2.TabIndex = 22;
            this.materialLabel2.Text = "Nombre";
            // 
            // apellido_txt
            // 
            this.apellido_txt.Depth = 0;
            this.apellido_txt.Hint = "";
            this.apellido_txt.Location = new System.Drawing.Point(88, 54);
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
            this.apellido_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellido_txt_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(15, 134);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(34, 19);
            this.materialLabel3.TabIndex = 23;
            this.materialLabel3.Text = "DNI";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(15, 300);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(74, 19);
            this.materialLabel7.TabIndex = 27;
            this.materialLabel7.Text = "Localidad";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(15, 172);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(69, 19);
            this.materialLabel4.TabIndex = 24;
            this.materialLabel4.Text = "Telefono";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(15, 253);
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
            this.materialLabel5.Location = new System.Drawing.Point(15, 214);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(73, 19);
            this.materialLabel5.TabIndex = 25;
            this.materialLabel5.Text = "Direccion";
            // 
            // Alumnos
            // 
            this.Alumnos.Controls.Add(this.panel3);
            this.Alumnos.Controls.Add(this.panel4);
            this.Alumnos.ImageIndex = 2;
            this.Alumnos.Location = new System.Drawing.Point(4, 41);
            this.Alumnos.Name = "Alumnos";
            this.Alumnos.Padding = new System.Windows.Forms.Padding(3);
            this.Alumnos.Size = new System.Drawing.Size(945, 407);
            this.Alumnos.TabIndex = 0;
            this.Alumnos.Text = "Prestamos";
            this.Alumnos.UseVisualStyleBackColor = true;
            this.Alumnos.Click += new System.EventHandler(this.Alumnos_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.materialLabel9);
            this.panel3.Controls.Add(this.materialFlatButton1);
            this.panel3.Controls.Add(this.comboBoxEjemplar);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.Ejemplar);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.comboBoxBibliotecarios);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.comboBoxLibro);
            this.panel3.Controls.Add(this.comboBoxAlumno);
            this.panel3.Location = new System.Drawing.Point(8, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 394);
            this.panel3.TabIndex = 103;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(53, 25);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(141, 19);
            this.materialLabel9.TabIndex = 102;
            this.materialLabel9.Text = "NUEVO PRESTAMO";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(100, 329);
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
            // comboBoxEjemplar
            // 
            this.comboBoxEjemplar.Location = new System.Drawing.Point(113, 169);
            this.comboBoxEjemplar.Name = "comboBoxEjemplar";
            this.comboBoxEjemplar.Size = new System.Drawing.Size(159, 28);
            this.comboBoxEjemplar.TabIndex = 53;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 20);
            this.label18.TabIndex = 43;
            this.label18.Text = "Alumno";
            // 
            // Ejemplar
            // 
            this.Ejemplar.AutoSize = true;
            this.Ejemplar.Location = new System.Drawing.Point(13, 172);
            this.Ejemplar.Name = "Ejemplar";
            this.Ejemplar.Size = new System.Drawing.Size(71, 20);
            this.Ejemplar.TabIndex = 52;
            this.Ejemplar.Text = "Ejemplar";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 131);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 20);
            this.label17.TabIndex = 44;
            this.label17.Text = "Libro";
            // 
            // comboBoxBibliotecarios
            // 
            this.comboBoxBibliotecarios.FormattingEnabled = true;
            this.comboBoxBibliotecarios.Location = new System.Drawing.Point(113, 211);
            this.comboBoxBibliotecarios.Name = "comboBoxBibliotecarios";
            this.comboBoxBibliotecarios.Size = new System.Drawing.Size(159, 28);
            this.comboBoxBibliotecarios.TabIndex = 51;
            this.comboBoxBibliotecarios.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 214);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 20);
            this.label16.TabIndex = 45;
            this.label16.Text = "Bibliotecario";
            // 
            // comboBoxLibro
            // 
            this.comboBoxLibro.FormattingEnabled = true;
            this.comboBoxLibro.Location = new System.Drawing.Point(113, 128);
            this.comboBoxLibro.Name = "comboBoxLibro";
            this.comboBoxLibro.Size = new System.Drawing.Size(159, 28);
            this.comboBoxLibro.TabIndex = 47;
            this.comboBoxLibro.SelectedIndexChanged += new System.EventHandler(this.comboBoxLibro_SelectedIndexChanged);
            this.comboBoxLibro.TextChanged += new System.EventHandler(this.comboBoxLibro_TextChanged);
            // 
            // comboBoxAlumno
            // 
            this.comboBoxAlumno.FormattingEnabled = true;
            this.comboBoxAlumno.Location = new System.Drawing.Point(113, 91);
            this.comboBoxAlumno.Name = "comboBoxAlumno";
            this.comboBoxAlumno.Size = new System.Drawing.Size(159, 28);
            this.comboBoxAlumno.TabIndex = 46;
            this.comboBoxAlumno.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlumno_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.materialFlatButton2);
            this.panel4.Controls.Add(this.TablaPrestamos);
            this.panel4.Location = new System.Drawing.Point(296, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(639, 394);
            this.panel4.TabIndex = 104;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(274, 339);
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
            // TablaPrestamos
            // 
            this.TablaPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaPrestamos.Location = new System.Drawing.Point(13, 15);
            this.TablaPrestamos.Name = "TablaPrestamos";
            this.TablaPrestamos.Size = new System.Drawing.Size(612, 296);
            this.TablaPrestamos.TabIndex = 48;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.ImageIndex = 1;
            this.tabPage3.Location = new System.Drawing.Point(4, 41);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(945, 407);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Suspenciones";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.materialFlatButton3);
            this.panel7.Controls.Add(this.TablaSuspensiones);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(935, 387);
            this.panel7.TabIndex = 105;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(434, 343);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(155, 36);
            this.materialFlatButton3.TabIndex = 102;
            this.materialFlatButton3.Text = "Quirtar suspension ";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // TablaSuspensiones
            // 
            this.TablaSuspensiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaSuspensiones.Location = new System.Drawing.Point(120, 12);
            this.TablaSuspensiones.Name = "TablaSuspensiones";
            this.TablaSuspensiones.Size = new System.Drawing.Size(754, 310);
            this.TablaSuspensiones.TabIndex = 48;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tablaLibros);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.ImageIndex = 4;
            this.tabPage2.Location = new System.Drawing.Point(4, 41);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(945, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Libros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tablaLibros
            // 
            this.tablaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaLibros.Location = new System.Drawing.Point(297, 15);
            this.tablaLibros.Name = "tablaLibros";
            this.tablaLibros.Size = new System.Drawing.Size(623, 308);
            this.tablaLibros.TabIndex = 38;
            this.tablaLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // panel6
            // 
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(285, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(650, 384);
            this.panel6.TabIndex = 40;
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.materialFlatButton4);
            this.panel5.Controls.Add(this.editorial_txt);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.libro_txt);
            this.panel5.Controls.Add(this.ejemplares_txt);
            this.panel5.Controls.Add(this.isnb_txt);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.autor_txt);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.generoLibro_txt);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(7, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(272, 383);
            this.panel5.TabIndex = 39;
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Location = new System.Drawing.Point(97, 323);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(74, 36);
            this.materialFlatButton4.TabIndex = 102;
            this.materialFlatButton4.Text = "Agregar";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            // 
            // editorial_txt
            // 
            this.editorial_txt.Location = new System.Drawing.Point(137, 167);
            this.editorial_txt.Name = "editorial_txt";
            this.editorial_txt.Size = new System.Drawing.Size(100, 27);
            this.editorial_txt.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Ejemplares";
            // 
            // libro_txt
            // 
            this.libro_txt.Location = new System.Drawing.Point(137, 53);
            this.libro_txt.Name = "libro_txt";
            this.libro_txt.Size = new System.Drawing.Size(100, 27);
            this.libro_txt.TabIndex = 26;
            this.libro_txt.TextChanged += new System.EventHandler(this.libro_txt_TextChanged);
            // 
            // ejemplares_txt
            // 
            this.ejemplares_txt.Location = new System.Drawing.Point(137, 250);
            this.ejemplares_txt.Name = "ejemplares_txt";
            this.ejemplares_txt.Size = new System.Drawing.Size(100, 27);
            this.ejemplares_txt.TabIndex = 36;
            // 
            // isnb_txt
            // 
            this.isnb_txt.Location = new System.Drawing.Point(137, 90);
            this.isnb_txt.Name = "isnb_txt";
            this.isnb_txt.Size = new System.Drawing.Size(100, 27);
            this.isnb_txt.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Genero";
            // 
            // autor_txt
            // 
            this.autor_txt.Location = new System.Drawing.Point(137, 129);
            this.autor_txt.Name = "autor_txt";
            this.autor_txt.Size = new System.Drawing.Size(100, 27);
            this.autor_txt.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Editorial";
            // 
            // generoLibro_txt
            // 
            this.generoLibro_txt.Location = new System.Drawing.Point(137, 209);
            this.generoLibro_txt.Name = "generoLibro_txt";
            this.generoLibro_txt.Size = new System.Drawing.Size(100, 27);
            this.generoLibro_txt.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Autor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Titulo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "ISNB";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "chicken-leg_821023.png");
            this.imageList1.Images.SetKeyName(1, "ask_2859734.png");
            this.imageList1.Images.SetKeyName(2, "growth_938418.png");
            this.imageList1.Images.SetKeyName(3, "salesman_939426.png");
            this.imageList1.Images.SetKeyName(4, "books_1050267.png");
            this.imageList1.Images.SetKeyName(5, "ebook_4670966.png");
            this.imageList1.Images.SetKeyName(6, "chicken-leg_821023.png");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // BiblioMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 455);
            this.Controls.Add(tabControl01);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BiblioMax";
            this.Text = "BiblioMax";
            this.Load += new System.EventHandler(this.BiblioMax_Load);
            tabControl01.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumno)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Alumnos.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPrestamos)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaSuspensiones)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaLibros)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel7;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private System.Windows.Forms.DataGridView TablaSuspensiones;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
    }
}

