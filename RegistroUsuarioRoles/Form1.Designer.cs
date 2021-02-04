
namespace RegistroUsuarioRoles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.texboxEmail = new System.Windows.Forms.TextBox();
            this.comboboxRoles = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ConfirmarClaveTexbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.idNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ClaveTexbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.texboxUsuario = new System.Windows.Forms.TextBox();
            this.texboxNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.texboxAlias = new System.Windows.Forms.TextBox();
            this.ButtonGuardar = new System.Windows.Forms.Button();
            this.ButtonEliminar = new System.Windows.Forms.Button();
            this.ButtonLimpiar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 15);
            this.label8.TabIndex = 58;
            this.label8.Text = "Rol ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 51;
            this.label6.Text = "Fecha Ingreso:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(566, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 19);
            this.checkBox1.TabIndex = 62;
            this.checkBox1.Text = "Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // texboxEmail
            // 
            this.texboxEmail.Location = new System.Drawing.Point(391, 114);
            this.texboxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.texboxEmail.Name = "texboxEmail";
            this.texboxEmail.Size = new System.Drawing.Size(235, 23);
            this.texboxEmail.TabIndex = 43;
            // 
            // comboboxRoles
            // 
            this.comboboxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxRoles.FormattingEnabled = true;
            this.comboboxRoles.Items.AddRange(new object[] {
            "Pastor",
            "Invitado automatico",
            "Doctor",
            "Ingenierto",
            "Artista",
            "Youtuber",
            "Gamer"});
            this.comboboxRoles.Location = new System.Drawing.Point(489, 46);
            this.comboboxRoles.Name = "comboboxRoles";
            this.comboboxRoles.Size = new System.Drawing.Size(137, 23);
            this.comboboxRoles.TabIndex = 56;
            this.comboboxRoles.SelectedIndexChanged += new System.EventHandler(this.comboboxRoles_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "  ";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(475, 77);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 23);
            this.dateTimePicker1.TabIndex = 50;
            this.dateTimePicker1.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ConfirmarClaveTexbox
            // 
            this.ConfirmarClaveTexbox.Location = new System.Drawing.Point(411, 163);
            this.ConfirmarClaveTexbox.Name = "ConfirmarClaveTexbox";
            this.ConfirmarClaveTexbox.PasswordChar = '*';
            this.ConfirmarClaveTexbox.Size = new System.Drawing.Size(112, 23);
            this.ConfirmarClaveTexbox.TabIndex = 59;
            this.ConfirmarClaveTexbox.TextChanged += new System.EventHandler(this.ConfirmarClaveTexbox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 15);
            this.label9.TabIndex = 57;
            this.label9.Text = "Confirmar Clave";
            // 
            // idNumericUpDown1
            // 
            this.idNumericUpDown1.Location = new System.Drawing.Point(60, 13);
            this.idNumericUpDown1.Name = "idNumericUpDown1";
            this.idNumericUpDown1.Size = new System.Drawing.Size(38, 23);
            this.idNumericUpDown1.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 15);
            this.label7.TabIndex = 54;
            this.label7.Text = "ID";
            // 
            // ClaveTexbox
            // 
            this.ClaveTexbox.Location = new System.Drawing.Point(205, 163);
            this.ClaveTexbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClaveTexbox.Name = "ClaveTexbox";
            this.ClaveTexbox.PasswordChar = '*';
            this.ClaveTexbox.Size = new System.Drawing.Size(101, 23);
            this.ClaveTexbox.TabIndex = 49;
            this.ClaveTexbox.TextChanged += new System.EventHandler(this.ClaveTexbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 48;
            this.label4.Text = "Clave:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 52;
            this.label5.Text = "Alias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nombre:";
            // 
            // texboxUsuario
            // 
            this.texboxUsuario.Location = new System.Drawing.Point(60, 119);
            this.texboxUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.texboxUsuario.Name = "texboxUsuario";
            this.texboxUsuario.Size = new System.Drawing.Size(211, 23);
            this.texboxUsuario.TabIndex = 44;
            // 
            // texboxNombre
            // 
            this.texboxNombre.Location = new System.Drawing.Point(60, 82);
            this.texboxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.texboxNombre.Name = "texboxNombre";
            this.texboxNombre.Size = new System.Drawing.Size(182, 23);
            this.texboxNombre.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBuscar);
            this.groupBox1.Controls.Add(this.texboxAlias);
            this.groupBox1.Controls.Add(this.texboxNombre);
            this.groupBox1.Controls.Add(this.texboxUsuario);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.texboxEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboboxRoles);
            this.groupBox1.Controls.Add(this.ClaveTexbox);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ConfirmarClaveTexbox);
            this.groupBox1.Controls.Add(this.idNumericUpDown1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 204);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.Location = new System.Drawing.Point(104, 11);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(29, 30);
            this.buttonBuscar.TabIndex = 64;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // texboxAlias
            // 
            this.texboxAlias.Location = new System.Drawing.Point(60, 51);
            this.texboxAlias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.texboxAlias.Name = "texboxAlias";
            this.texboxAlias.Size = new System.Drawing.Size(154, 23);
            this.texboxAlias.TabIndex = 63;
            // 
            // ButtonGuardar
            // 
            this.ButtonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("ButtonGuardar.Image")));
            this.ButtonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonGuardar.Location = new System.Drawing.Point(189, 213);
            this.ButtonGuardar.Name = "ButtonGuardar";
            this.ButtonGuardar.Size = new System.Drawing.Size(94, 38);
            this.ButtonGuardar.TabIndex = 66;
            this.ButtonGuardar.Text = "Guardar";
            this.ButtonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonGuardar.UseVisualStyleBackColor = true;
            this.ButtonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEliminar.Image")));
            this.ButtonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonEliminar.Location = new System.Drawing.Point(289, 213);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(89, 38);
            this.ButtonEliminar.TabIndex = 67;
            this.ButtonEliminar.Text = "Eliminar";
            this.ButtonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonEliminar.UseVisualStyleBackColor = true;
            this.ButtonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // ButtonLimpiar
            // 
            this.ButtonLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("ButtonLimpiar.Image")));
            this.ButtonLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonLimpiar.Location = new System.Drawing.Point(384, 213);
            this.ButtonLimpiar.Name = "ButtonLimpiar";
            this.ButtonLimpiar.Size = new System.Drawing.Size(87, 38);
            this.ButtonLimpiar.TabIndex = 68;
            this.ButtonLimpiar.Text = "Limpiar";
            this.ButtonLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonLimpiar.UseVisualStyleBackColor = true;
            this.ButtonLimpiar.Click += new System.EventHandler(this.ButtonLimpiar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(640, 254);
            this.Controls.Add(this.ButtonLimpiar);
            this.Controls.Add(this.ButtonEliminar);
            this.Controls.Add(this.ButtonGuardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox texboxEmail;
        private System.Windows.Forms.ComboBox comboboxRoles;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox ConfirmarClaveTexbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown idNumericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox texboxAlias;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox ClaveTexbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texboxUsuario;
        private System.Windows.Forms.TextBox texboxNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonGuardar;
        private System.Windows.Forms.Button ButtonEliminar;
        private System.Windows.Forms.Button ButtonLimpiar;
        private System.Windows.Forms.Button buttonBuscar;
    }
}

