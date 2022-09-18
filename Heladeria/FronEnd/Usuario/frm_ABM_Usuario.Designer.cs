namespace Heladeria.FronEnd
{
    partial class frm_ABM_Usuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ABM_Usuario));
            this.lbl_ABM = new System.Windows.Forms.Label();
            this.txt_Patron = new System.Windows.Forms.TextBox();
            this.lbl_Patron = new System.Windows.Forms.Label();
            this.lbl_Perfiles = new System.Windows.Forms.Label();
            this.chk_Todos_Usuarios = new System.Windows.Forms.CheckBox();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Baja = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgr_Usuarios = new System.Windows.Forms.DataGridView();
            this.btn_3Puntos = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_Perfil = new Heladeria.Clases.ComboBox01();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ABM
            // 
            this.lbl_ABM.AutoSize = true;
            this.lbl_ABM.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ABM.Location = new System.Drawing.Point(27, 22);
            this.lbl_ABM.Name = "lbl_ABM";
            this.lbl_ABM.Size = new System.Drawing.Size(239, 39);
            this.lbl_ABM.TabIndex = 0;
            this.lbl_ABM.Text = "ABM Usuarios";
            // 
            // txt_Patron
            // 
            this.txt_Patron.Location = new System.Drawing.Point(84, 29);
            this.txt_Patron.Name = "txt_Patron";
            this.txt_Patron.Size = new System.Drawing.Size(121, 24);
            this.txt_Patron.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_Patron, "Puede ingresar un texto completo o una fraccion del mismo para buscar en el nombr" +
        "e d");
            // 
            // lbl_Patron
            // 
            this.lbl_Patron.AutoSize = true;
            this.lbl_Patron.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Patron.Location = new System.Drawing.Point(6, 29);
            this.lbl_Patron.Name = "lbl_Patron";
            this.lbl_Patron.Size = new System.Drawing.Size(72, 18);
            this.lbl_Patron.TabIndex = 3;
            this.lbl_Patron.Text = "Patrones:";
            // 
            // lbl_Perfiles
            // 
            this.lbl_Perfiles.AutoSize = true;
            this.lbl_Perfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Perfiles.Location = new System.Drawing.Point(6, 63);
            this.lbl_Perfiles.Name = "lbl_Perfiles";
            this.lbl_Perfiles.Size = new System.Drawing.Size(61, 18);
            this.lbl_Perfiles.TabIndex = 4;
            this.lbl_Perfiles.Text = "Perfiles:";
            // 
            // chk_Todos_Usuarios
            // 
            this.chk_Todos_Usuarios.AutoSize = true;
            this.chk_Todos_Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Todos_Usuarios.Location = new System.Drawing.Point(9, 96);
            this.chk_Todos_Usuarios.Name = "chk_Todos_Usuarios";
            this.chk_Todos_Usuarios.Size = new System.Drawing.Size(155, 22);
            this.chk_Todos_Usuarios.TabIndex = 5;
            this.chk_Todos_Usuarios.Text = "Todos los usuarios";
            this.toolTip1.SetToolTip(this.chk_Todos_Usuarios, "Selecciona todos los usuarios de la BD");
            this.chk_Todos_Usuarios.UseVisualStyleBackColor = true;
            this.chk_Todos_Usuarios.CheckedChanged += new System.EventHandler(this.chk_Todos_Usuarios_CheckedChanged);
            // 
            // btn_Alta
            // 
            this.btn_Alta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Alta.BackgroundImage")));
            this.btn_Alta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Alta.Location = new System.Drawing.Point(43, 404);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(71, 66);
            this.btn_Alta.TabIndex = 1;
            this.btn_Alta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btn_Alta, "Boton para agregar un usuario");
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_Alta_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.BackgroundImage")));
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Modificar.Location = new System.Drawing.Point(120, 404);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(71, 66);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btn_Modificar, "Boton para editar un usuario");
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Baja
            // 
            this.btn_Baja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Baja.BackgroundImage")));
            this.btn_Baja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Baja.Location = new System.Drawing.Point(197, 404);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(71, 66);
            this.btn_Baja.TabIndex = 3;
            this.btn_Baja.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btn_Baja, "Boton para eliminar un usuario");
            this.btn_Baja.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.BackgroundImage")));
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Buscar.Location = new System.Drawing.Point(272, 27);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(71, 66);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btn_Buscar, "Boton para inicar la busqueda ");
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir.BackgroundImage")));
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Location = new System.Drawing.Point(631, 404);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(71, 66);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btn_Salir, "Salir");
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgr_Usuarios);
            this.groupBox1.Controls.Add(this.btn_3Puntos);
            this.groupBox1.Controls.Add(this.lbl_Patron);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Controls.Add(this.txt_Patron);
            this.groupBox1.Controls.Add(this.lbl_Perfiles);
            this.groupBox1.Controls.Add(this.chk_Todos_Usuarios);
            this.groupBox1.Controls.Add(this.cmb_Perfil);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgr_Usuarios
            // 
            this.dgr_Usuarios.AllowUserToAddRows = false;
            this.dgr_Usuarios.AllowUserToDeleteRows = false;
            this.dgr_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_Usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_usuario,
            this.password,
            this.Nombre,
            this.Apellido,
            this.id_perfil,
            this.Email});
            this.dgr_Usuarios.Location = new System.Drawing.Point(6, 124);
            this.dgr_Usuarios.Name = "dgr_Usuarios";
            this.dgr_Usuarios.ReadOnly = true;
            this.dgr_Usuarios.Size = new System.Drawing.Size(644, 150);
            this.dgr_Usuarios.TabIndex = 16;
            this.dgr_Usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_3Puntos
            // 
            this.btn_3Puntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3Puntos.Location = new System.Drawing.Point(211, 63);
            this.btn_3Puntos.Name = "btn_3Puntos";
            this.btn_3Puntos.Size = new System.Drawing.Size(39, 30);
            this.btn_3Puntos.TabIndex = 2;
            this.btn_3Puntos.Text = "...";
            this.toolTip1.SetToolTip(this.btn_3Puntos, "Consulta");
            this.btn_3Puntos.UseVisualStyleBackColor = true;
            this.btn_3Puntos.Click += new System.EventHandler(this.btn_3Puntos_Click);
            // 
            // Id_usuario
            // 
            this.Id_usuario.HeaderText = "Id_Usuario";
            this.Id_usuario.Name = "Id_usuario";
            this.Id_usuario.ReadOnly = true;
            this.Id_usuario.Visible = false;
            // 
            // password
            // 
            this.password.HeaderText = "Contraseña";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // id_perfil
            // 
            this.id_perfil.HeaderText = "Perfil";
            this.id_perfil.Name = "id_perfil";
            this.id_perfil.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // cmb_Perfil
            // 
            this.cmb_Perfil.FormattingEnabled = true;
            this.cmb_Perfil.Location = new System.Drawing.Point(84, 64);
            this.cmb_Perfil.Name = "cmb_Perfil";
            this.cmb_Perfil.Pp_ConSeleccion = true;
            this.cmb_Perfil.Pp_descripcion = "nombre";
            this.cmb_Perfil.Pp_MensajeError = null;
            this.cmb_Perfil.Pp_Pk = "id_perfil";
            this.cmb_Perfil.Pp_tabla = "Perfiles";
            this.cmb_Perfil.Size = new System.Drawing.Size(121, 26);
            this.cmb_Perfil.TabIndex = 1;
            this.cmb_Perfil.SelectedIndexChanged += new System.EventHandler(this.cmb_Perfil_SelectedIndexChanged);
            // 
            // frm_ABM_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.lbl_ABM);
            this.Name = "frm_ABM_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM Usuarios";
            this.Load += new System.EventHandler(this.frm_ABM_Usuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ABM;
        private System.Windows.Forms.TextBox txt_Patron;
        private System.Windows.Forms.Label lbl_Patron;
        private System.Windows.Forms.Label lbl_Perfiles;
        private System.Windows.Forms.CheckBox chk_Todos_Usuarios;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Salir;
        private Clases.ComboBox01 cmb_Perfil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_3Puntos;
        private System.Windows.Forms.DataGridView dgr_Usuarios;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}