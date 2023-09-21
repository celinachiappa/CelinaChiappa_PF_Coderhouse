namespace SistemaGestión_CelinaChiappa
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
            lblBienvenido = new Label();
            lblInsertUsuario = new Label();
            lblContraseña = new Label();
            txtbxUsuario = new TextBox();
            txbxContraseña = new TextBox();
            bttIngresar = new Button();
            lblCoderName = new Label();
            bttnNuevoUser = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.BackColor = SystemColors.ActiveCaptionText;
            lblBienvenido.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenido.ForeColor = Color.SeaShell;
            lblBienvenido.Location = new Point(137, 100);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(605, 44);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "Bienvenido al sistema de gestión";
            // 
            // lblInsertUsuario
            // 
            lblInsertUsuario.AutoSize = true;
            lblInsertUsuario.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblInsertUsuario.ForeColor = Color.FromArgb(255, 255, 128);
            lblInsertUsuario.Location = new Point(315, 203);
            lblInsertUsuario.Name = "lblInsertUsuario";
            lblInsertUsuario.Size = new Size(152, 25);
            lblInsertUsuario.TabIndex = 1;
            lblInsertUsuario.Text = "Usuario/Email";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblContraseña.ForeColor = Color.FromArgb(255, 255, 128);
            lblContraseña.Location = new Point(315, 276);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(130, 25);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            // 
            // txtbxUsuario
            // 
            txtbxUsuario.Location = new Point(315, 231);
            txtbxUsuario.Name = "txtbxUsuario";
            txtbxUsuario.Size = new Size(171, 27);
            txtbxUsuario.TabIndex = 3;
            // 
            // txbxContraseña
            // 
            txbxContraseña.Location = new Point(315, 304);
            txbxContraseña.Name = "txbxContraseña";
            txbxContraseña.Size = new Size(171, 27);
            txbxContraseña.TabIndex = 4;
            // 
            // bttIngresar
            // 
            bttIngresar.BackColor = SystemColors.ButtonFace;
            bttIngresar.BackgroundImageLayout = ImageLayout.Center;
            bttIngresar.Font = new Font("Gill Sans MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            bttIngresar.Location = new Point(312, 362);
            bttIngresar.Name = "bttIngresar";
            bttIngresar.Size = new Size(90, 37);
            bttIngresar.TabIndex = 5;
            bttIngresar.Text = "Ingresar";
            bttIngresar.UseVisualStyleBackColor = false;
            bttIngresar.Click += bttnIngresar_Click;
            // 
            // lblCoderName
            // 
            lblCoderName.Font = new Font("Haettenschweiler", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblCoderName.ForeColor = SystemColors.ButtonFace;
            lblCoderName.ImageAlign = ContentAlignment.MiddleLeft;
            lblCoderName.Location = new Point(12, 9);
            lblCoderName.Name = "lblCoderName";
            lblCoderName.Size = new Size(118, 33);
            lblCoderName.TabIndex = 6;
            lblCoderName.Text = "CoderHouse";
            // 
            // bttnNuevoUser
            // 
            bttnNuevoUser.BackgroundImageLayout = ImageLayout.Center;
            bttnNuevoUser.Font = new Font("Gill Sans MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            bttnNuevoUser.Location = new Point(715, 456);
            bttnNuevoUser.Name = "bttnNuevoUser";
            bttnNuevoUser.Size = new Size(128, 37);
            bttnNuevoUser.TabIndex = 7;
            bttnNuevoUser.Text = " Crear Usuario";
            bttnNuevoUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(12, 476);
            label1.Name = "label1";
            label1.Size = new Size(223, 20);
            label1.TabIndex = 8;
            label1.Text = "Proyecto Final- Celina Chiappa";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(866, 505);
            Controls.Add(label1);
            Controls.Add(bttnNuevoUser);
            Controls.Add(lblCoderName);
            Controls.Add(bttIngresar);
            Controls.Add(txbxContraseña);
            Controls.Add(txtbxUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblInsertUsuario);
            Controls.Add(lblBienvenido);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private Label lblInsertUsuario;
        private Label lblContraseña;
        private TextBox txtbxUsuario;
        private TextBox txbxContraseña;
        private Button bttIngresar;
        private Label lblCoderName;
        private Button bttnNuevoUser;
        private Label label1;
    }
}