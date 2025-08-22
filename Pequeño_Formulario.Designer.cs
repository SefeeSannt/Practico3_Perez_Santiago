namespace TallerDeProgramacion2.Práctico_2
{
    partial class Pequeño_Formulario
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
            LNya = new Label();
            Lmodificar = new Label();
            LNombre = new Label();
            LDni = new Label();
            LApellido = new Label();
            TDni = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            TGuardar = new Button();
            TEleminar = new Button();
            panel1 = new Panel();
            txtTelefono = new TextBox();
            label2 = new Label();
            label1 = new Label();
            chkMastercard = new CheckBox();
            chkNaranja = new CheckBox();
            chkVisa = new CheckBox();
            pictureBox1 = new PictureBox();
            RBMujer = new RadioButton();
            btnSalir = new Button();
            RBVaron = new RadioButton();
            lblTitulo = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.BackColor = SystemColors.ActiveCaption;
            LNya.Location = new Point(24, 105);
            LNya.Name = "LNya";
            LNya.Size = new Size(110, 15);
            LNya.TabIndex = 0;
            LNya.Text = "Nombre y Apellido:";
            // 
            // Lmodificar
            // 
            Lmodificar.AutoSize = true;
            Lmodificar.BackColor = SystemColors.ActiveCaption;
            Lmodificar.ForeColor = Color.Red;
            Lmodificar.Location = new Point(173, 105);
            Lmodificar.Name = "Lmodificar";
            Lmodificar.Size = new Size(58, 15);
            Lmodificar.TabIndex = 1;
            Lmodificar.Text = "modificar";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.BackColor = SystemColors.ActiveCaption;
            LNombre.Location = new Point(24, 201);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 2;
            LNombre.Text = "Nombre";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.BackColor = SystemColors.ActiveCaption;
            LDni.Location = new Point(24, 143);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 3;
            LDni.Text = "DNI";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.BackColor = SystemColors.ActiveCaption;
            LApellido.Location = new Point(24, 172);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 4;
            LApellido.Text = "Apellido";
            // 
            // TDni
            // 
            TDni.Location = new Point(173, 140);
            TDni.Name = "TDni";
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 5;
            TDni.TextChanged += TDni_TextChanged;
            TDni.KeyPress += onlyDigits_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(173, 169);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 6;
            TApellido.KeyPress += onlyLetters_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(173, 198);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 10;
            TNombre.TextChanged += TNombre_TextChanged;
            TNombre.KeyPress += onlyLetters_KeyPress;
            // 
            // TGuardar
            // 
            TGuardar.Image = Practico3.Properties.Resources.save;
            TGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            TGuardar.Location = new Point(12, 347);
            TGuardar.Name = "TGuardar";
            TGuardar.Size = new Size(105, 53);
            TGuardar.TabIndex = 8;
            TGuardar.Text = "Guardar";
            TGuardar.TextAlign = ContentAlignment.MiddleRight;
            TGuardar.UseVisualStyleBackColor = true;
            TGuardar.Click += button1_Click;
            // 
            // TEleminar
            // 
            TEleminar.Image = Practico3.Properties.Resources.deleteUser;
            TEleminar.ImageAlign = ContentAlignment.MiddleLeft;
            TEleminar.Location = new Point(138, 347);
            TEleminar.Name = "TEleminar";
            TEleminar.Size = new Size(105, 53);
            TEleminar.TabIndex = 9;
            TEleminar.Text = "Eliminar";
            TEleminar.TextAlign = ContentAlignment.MiddleRight;
            TEleminar.UseVisualStyleBackColor = true;
            TEleminar.Click += TEleminar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(chkMastercard);
            panel1.Controls.Add(chkNaranja);
            panel1.Controls.Add(chkVisa);
            panel1.Location = new Point(12, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 226);
            panel1.TabIndex = 11;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(161, 135);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 16;
            txtTelefono.KeyPress += onlyDigits_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 138);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 16;
            label2.Text = "Teléfono";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 168);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 16;
            label1.Text = "Tarjetas de credito:";
            // 
            // chkMastercard
            // 
            chkMastercard.AutoSize = true;
            chkMastercard.Location = new Point(161, 195);
            chkMastercard.Name = "chkMastercard";
            chkMastercard.Size = new Size(85, 19);
            chkMastercard.TabIndex = 17;
            chkMastercard.Text = "Mastercard";
            chkMastercard.UseVisualStyleBackColor = true;
            // 
            // chkNaranja
            // 
            chkNaranja.AutoSize = true;
            chkNaranja.Location = new Point(12, 195);
            chkNaranja.Name = "chkNaranja";
            chkNaranja.Size = new Size(67, 19);
            chkNaranja.TabIndex = 15;
            chkNaranja.Text = "Naranja";
            chkNaranja.UseVisualStyleBackColor = true;
            // 
            // chkVisa
            // 
            chkVisa.AutoSize = true;
            chkVisa.Location = new Point(93, 195);
            chkVisa.Name = "chkVisa";
            chkVisa.Size = new Size(47, 19);
            chkVisa.TabIndex = 16;
            chkVisa.Text = "Visa";
            chkVisa.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Practico3.Properties.Resources.maleUser;
            pictureBox1.Location = new Point(342, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Location = new Point(342, 236);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(56, 19);
            RBMujer.TabIndex = 14;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            RBMujer.CheckedChanged += RBMujer_CheckedChanged;
            // 
            // btnSalir
            // 
            btnSalir.Image = Practico3.Properties.Resources.exit;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(364, 347);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(105, 53);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // RBVaron
            // 
            RBVaron.AutoSize = true;
            RBVaron.Checked = true;
            RBVaron.Location = new Point(342, 211);
            RBVaron.Name = "RBVaron";
            RBVaron.Size = new Size(55, 19);
            RBVaron.TabIndex = 16;
            RBVaron.TabStop = true;
            RBVaron.Text = "Varon";
            RBVaron.UseVisualStyleBackColor = true;
            RBVaron.CheckedChanged += RBVaron_CheckedChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.HotTrack;
            lblTitulo.Location = new Point(60, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(198, 37);
            lblTitulo.TabIndex = 17;
            lblTitulo.Text = "Nuevo Cliente";
            // 
            // Pequeño_Formulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 421);
            Controls.Add(lblTitulo);
            Controls.Add(RBVaron);
            Controls.Add(btnSalir);
            Controls.Add(RBMujer);
            Controls.Add(pictureBox1);
            Controls.Add(TEleminar);
            Controls.Add(TGuardar);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(TDni);
            Controls.Add(LApellido);
            Controls.Add(LDni);
            Controls.Add(LNombre);
            Controls.Add(Lmodificar);
            Controls.Add(LNya);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Pequeño_Formulario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pequeño Formulario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNya;
        private Label Lmodificar;
        private Label LNombre;
        private Label LDni;
        private Label LApellido;
        private TextBox TDni;
        private TextBox TApellido;
        private TextBox TNombre;
        private Button TGuardar;
        private Button TEleminar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private RadioButton RBMujer;
        private CheckBox chkNaranja;
        private CheckBox chkVisa;
        private CheckBox chkMastercard;
        private Button btnSalir;
        private TextBox txtTelefono;
        private Label label2;
        private Label label1;
        private RadioButton RBVaron;
        private Label lblTitulo;
    }
}