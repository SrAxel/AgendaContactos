namespace Presentación
{
    partial class FrmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgenda));
            Contac = new Label();
            pvxFoto = new PictureBox();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            lsvListaContactos = new ListView();
            ((System.ComponentModel.ISupportInitialize)pvxFoto).BeginInit();
            SuspendLayout();
            // 
            // Contac
            // 
            Contac.AutoSize = true;
            Contac.BackColor = Color.Transparent;
            Contac.Location = new Point(69, 20);
            Contac.Name = "Contac";
            Contac.Size = new Size(61, 15);
            Contac.TabIndex = 2;
            Contac.Text = "Contactos";
            Contac.Click += label1_Click;
            // 
            // pvxFoto
            // 
            pvxFoto.BackColor = Color.Transparent;
            pvxFoto.Image = Properties.Resources.icons8_grupo_de_usuario_100;
            pvxFoto.Location = new Point(1, 1);
            pvxFoto.Name = "pvxFoto";
            pvxFoto.Size = new Size(62, 53);
            pvxFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pvxFoto.TabIndex = 3;
            pvxFoto.TabStop = false;
            pvxFoto.Click += pictureBox1_Click;
            // 
            // btnSalir
            // 
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 20;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(742, 406);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(84, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.Desktop;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnAgregar.IconSize = 18;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(751, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lsvListaContactos
            // 
            lsvListaContactos.BackColor = Color.GreenYellow;
            lsvListaContactos.Location = new Point(12, 60);
            lsvListaContactos.Name = "lsvListaContactos";
            lsvListaContactos.Size = new Size(814, 334);
            lsvListaContactos.TabIndex = 6;
            lsvListaContactos.UseCompatibleStateImageBehavior = false;
            // 
            // FrmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(838, 441);
            Controls.Add(lsvListaContactos);
            Controls.Add(btnAgregar);
            Controls.Add(btnSalir);
            Controls.Add(pvxFoto);
            Controls.Add(Contac);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAgenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda de Contactos";
            Load += FrmAgenda_Load;
            ((System.ComponentModel.ISupportInitialize)pvxFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private Label Contac;
        private PictureBox pvxFoto;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private ListView lsvListaContactos;
    }
}