namespace WinFormsApp1
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
            lbNombre = new Label();
            label2 = new Label();
            rbConsulta = new RadioButton();
            rbQueja = new RadioButton();
            rbSugerencia = new RadioButton();
            lblPrivacidad = new LinkLabel();
            chkRespuesta = new CheckBox();
            btnEnviar = new Button();
            txtNom = new TextBox();
            txtcon = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(99, 85);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(54, 15);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 302);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Confirmación";
            // 
            // rbConsulta
            // 
            rbConsulta.AutoSize = true;
            rbConsulta.Location = new Point(99, 150);
            rbConsulta.Name = "rbConsulta";
            rbConsulta.Size = new Size(72, 19);
            rbConsulta.TabIndex = 2;
            rbConsulta.TabStop = true;
            rbConsulta.Text = "Consulta";
            rbConsulta.UseVisualStyleBackColor = true;
            // 
            // rbQueja
            // 
            rbQueja.AutoSize = true;
            rbQueja.Location = new Point(99, 175);
            rbQueja.Name = "rbQueja";
            rbQueja.Size = new Size(59, 19);
            rbQueja.TabIndex = 3;
            rbQueja.TabStop = true;
            rbQueja.Text = "Queja ";
            rbQueja.UseVisualStyleBackColor = true;
            // 
            // rbSugerencia
            // 
            rbSugerencia.AutoSize = true;
            rbSugerencia.Location = new Point(99, 200);
            rbSugerencia.Name = "rbSugerencia";
            rbSugerencia.Size = new Size(83, 19);
            rbSugerencia.TabIndex = 4;
            rbSugerencia.TabStop = true;
            rbSugerencia.Text = "Sugerencia";
            rbSugerencia.UseVisualStyleBackColor = true;
            // 
            // lblPrivacidad
            // 
            lblPrivacidad.AutoSize = true;
            lblPrivacidad.Location = new Point(206, 403);
            lblPrivacidad.Name = "lblPrivacidad";
            lblPrivacidad.Size = new Size(139, 15);
            lblPrivacidad.TabIndex = 5;
            lblPrivacidad.TabStop = true;
            lblPrivacidad.Text = "Ver politica de privacidad";
            lblPrivacidad.LinkClicked += lblPrivacidad_LinkClicked;
            // 
            // chkRespuesta
            // 
            chkRespuesta.AutoSize = true;
            chkRespuesta.Location = new Point(99, 225);
            chkRespuesta.Name = "chkRespuesta";
            chkRespuesta.Size = new Size(147, 19);
            chkRespuesta.TabIndex = 6;
            chkRespuesta.Text = "Deseo recibir respuesta";
            chkRespuesta.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(99, 260);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 7;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(166, 82);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(287, 23);
            txtNom.TabIndex = 8;
            // 
            // txtcon
            // 
            txtcon.Location = new Point(99, 320);
            txtcon.Multiline = true;
            txtcon.Name = "txtcon";
            txtcon.Size = new Size(354, 69);
            txtcon.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 120);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 10;
            label3.Text = "Motivo de contacto";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 38);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 11;
            label4.Text = "Formulario de contacto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtcon);
            Controls.Add(txtNom);
            Controls.Add(btnEnviar);
            Controls.Add(chkRespuesta);
            Controls.Add(lblPrivacidad);
            Controls.Add(rbSugerencia);
            Controls.Add(rbQueja);
            Controls.Add(rbConsulta);
            Controls.Add(label2);
            Controls.Add(lbNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNombre;
        private Label label2;
        private RadioButton rbConsulta;
        private RadioButton rbQueja;
        private RadioButton rbSugerencia;
        private LinkLabel lblPrivacidad;
        private CheckBox chkRespuesta;
        private Button btnEnviar;
        private TextBox txtNom;
        private TextBox txtcon;
        private Label label3;
        private Label label4;
    }
}
