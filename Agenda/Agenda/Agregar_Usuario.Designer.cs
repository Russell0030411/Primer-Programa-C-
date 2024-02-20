namespace Agenda
{
    partial class Agregar_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Usuario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtboxNombres = new System.Windows.Forms.TextBox();
            this.txtboxApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.comboGenero = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.msboxTelefono = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(86, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(83, 203);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres";
            // 
            // txtboxNombres
            // 
            this.txtboxNombres.Location = new System.Drawing.Point(86, 219);
            this.txtboxNombres.Name = "txtboxNombres";
            this.txtboxNombres.Size = new System.Drawing.Size(192, 20);
            this.txtboxNombres.TabIndex = 2;
            this.txtboxNombres.TextChanged += new System.EventHandler(this.txtboxNombres_TextChanged);
            // 
            // txtboxApellidos
            // 
            this.txtboxApellidos.Location = new System.Drawing.Point(86, 262);
            this.txtboxApellidos.Name = "txtboxApellidos";
            this.txtboxApellidos.Size = new System.Drawing.Size(192, 20);
            this.txtboxApellidos.TabIndex = 4;
            this.txtboxApellidos.TextChanged += new System.EventHandler(this.txtboxApellidos_TextChanged);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(83, 246);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(83, 295);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 5;
            this.lblGenero.Text = "Genero";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(83, 346);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(49, 13);
            this.lblContacto.TabIndex = 7;
            this.lblContacto.Text = "Teléfono";
            // 
            // comboGenero
            // 
            this.comboGenero.FormattingEnabled = true;
            this.comboGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.comboGenero.Location = new System.Drawing.Point(86, 318);
            this.comboGenero.Name = "comboGenero";
            this.comboGenero.Size = new System.Drawing.Size(192, 21);
            this.comboGenero.TabIndex = 9;
            this.comboGenero.SelectedIndexChanged += new System.EventHandler(this.comboGenero_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(86, 403);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(203, 403);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // msboxTelefono
            // 
            this.msboxTelefono.Location = new System.Drawing.Point(86, 372);
            this.msboxTelefono.Mask = "0000-0000";
            this.msboxTelefono.Name = "msboxTelefono";
            this.msboxTelefono.Size = new System.Drawing.Size(192, 20);
            this.msboxTelefono.TabIndex = 12;
            this.msboxTelefono.Tag = "";
            this.msboxTelefono.Text = "12345678";
            this.msboxTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msboxTelefono.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.msboxTelefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msboxTelefono_MaskInputRejected);
            // 
            // Agregar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(367, 438);
            this.Controls.Add(this.msboxTelefono);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.comboGenero);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtboxApellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtboxNombres);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(383, 477);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(383, 477);
            this.Name = "Agregar_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar_Usuario";
            this.Load += new System.EventHandler(this.Agregar_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtboxNombres;
        public System.Windows.Forms.TextBox txtboxApellidos;
        public System.Windows.Forms.ComboBox comboGenero;
        public System.Windows.Forms.MaskedTextBox msboxTelefono;
    }
}