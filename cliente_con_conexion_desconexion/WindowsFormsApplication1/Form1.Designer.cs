namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Usuari = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConQuienJuego = new System.Windows.Forms.RadioButton();
            this.Mascorta = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.partida = new System.Windows.Forms.TextBox();
            this.MasPuntos = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UsuariLogIn = new System.Windows.Forms.TextBox();
            this.contrasenyaLogIn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ContrasenyaSignIn = new System.Windows.Forms.TextBox();
            this.UsuariSignIn = new System.Windows.Forms.TextBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contSer = new System.Windows.Forms.Label();
            this.Enter = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonAceptarF1 = new System.Windows.Forms.Button();
            this.buttonRechazarF1 = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuari
            // 
            this.Usuari.AutoSize = true;
            this.Usuari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuari.Location = new System.Drawing.Point(22, 38);
            this.Usuari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Usuari.Name = "Usuari";
            this.Usuari.Size = new System.Drawing.Size(108, 31);
            this.Usuari.TabIndex = 1;
            this.Usuari.Text = "Usuario";
            this.Usuari.Click += new System.EventHandler(this.Usuario_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(155, 38);
            this.ID.Margin = new System.Windows.Forms.Padding(4);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(217, 22);
            this.ID.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 193);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.ConQuienJuego);
            this.groupBox1.Controls.Add(this.Mascorta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.partida);
            this.groupBox1.Controls.Add(this.MasPuntos);
            this.groupBox1.Controls.Add(this.Usuari);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Location = new System.Drawing.Point(31, 128);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(620, 327);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ConQuienJuego
            // 
            this.ConQuienJuego.AutoSize = true;
            this.ConQuienJuego.Location = new System.Drawing.Point(155, 86);
            this.ConQuienJuego.Margin = new System.Windows.Forms.Padding(4);
            this.ConQuienJuego.Name = "ConQuienJuego";
            this.ConQuienJuego.Size = new System.Drawing.Size(201, 21);
            this.ConQuienJuego.TabIndex = 7;
            this.ConQuienJuego.TabStop = true;
            this.ConQuienJuego.Text = "Dime con quien has jugado";
            this.ConQuienJuego.UseVisualStyleBackColor = true;
            // 
            // Mascorta
            // 
            this.Mascorta.AutoSize = true;
            this.Mascorta.Location = new System.Drawing.Point(155, 115);
            this.Mascorta.Margin = new System.Windows.Forms.Padding(4);
            this.Mascorta.Name = "Mascorta";
            this.Mascorta.Size = new System.Drawing.Size(270, 21);
            this.Mascorta.TabIndex = 7;
            this.Mascorta.TabStop = true;
            this.Mascorta.Text = "Dime cual ha sido la partida más corta";
            this.Mascorta.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Partida";
            // 
            // partida
            // 
            this.partida.Location = new System.Drawing.Point(20, 135);
            this.partida.Margin = new System.Windows.Forms.Padding(4);
            this.partida.Name = "partida";
            this.partida.Size = new System.Drawing.Size(81, 22);
            this.partida.TabIndex = 9;
            // 
            // MasPuntos
            // 
            this.MasPuntos.AutoSize = true;
            this.MasPuntos.Location = new System.Drawing.Point(155, 144);
            this.MasPuntos.Margin = new System.Windows.Forms.Padding(4);
            this.MasPuntos.Name = "MasPuntos";
            this.MasPuntos.Size = new System.Drawing.Size(336, 21);
            this.MasPuntos.TabIndex = 8;
            this.MasPuntos.TabStop = true;
            this.MasPuntos.Text = "Dime que jugador tiene más puntos en la partida";
            this.MasPuntos.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(31, 625);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 65);
            this.button3.TabIndex = 10;
            this.button3.Text = "Log out";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Usuari";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Contrasenya";
            // 
            // UsuariLogIn
            // 
            this.UsuariLogIn.Location = new System.Drawing.Point(127, 56);
            this.UsuariLogIn.Name = "UsuariLogIn";
            this.UsuariLogIn.Size = new System.Drawing.Size(100, 22);
            this.UsuariLogIn.TabIndex = 14;
            this.UsuariLogIn.TextChanged += new System.EventHandler(this.UsuariLogIn_TextChanged);
            // 
            // contrasenyaLogIn
            // 
            this.contrasenyaLogIn.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.contrasenyaLogIn.Location = new System.Drawing.Point(127, 84);
            this.contrasenyaLogIn.Name = "contrasenyaLogIn";
            this.contrasenyaLogIn.PasswordChar = '*';
            this.contrasenyaLogIn.Size = new System.Drawing.Size(100, 22);
            this.contrasenyaLogIn.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "SIGN IN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Usuari";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Contrasenya";
            // 
            // ContrasenyaSignIn
            // 
            this.ContrasenyaSignIn.Location = new System.Drawing.Point(127, 222);
            this.ContrasenyaSignIn.Name = "ContrasenyaSignIn";
            this.ContrasenyaSignIn.PasswordChar = '*';
            this.ContrasenyaSignIn.Size = new System.Drawing.Size(100, 22);
            this.ContrasenyaSignIn.TabIndex = 19;
            // 
            // UsuariSignIn
            // 
            this.UsuariSignIn.Location = new System.Drawing.Point(127, 187);
            this.UsuariSignIn.Name = "UsuariSignIn";
            this.UsuariSignIn.Size = new System.Drawing.Size(100, 22);
            this.UsuariSignIn.TabIndex = 20;
            // 
            // SignIn
            // 
            this.SignIn.Location = new System.Drawing.Point(161, 250);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(66, 32);
            this.SignIn.TabIndex = 22;
            this.SignIn.Text = "go";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(161, 112);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(66, 30);
            this.Login.TabIndex = 23;
            this.Login.Text = "go";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.SignIn);
            this.groupBox2.Controls.Add(this.Login);
            this.groupBox2.Controls.Add(this.ContrasenyaSignIn);
            this.groupBox2.Controls.Add(this.UsuariSignIn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.UsuariLogIn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.contrasenyaLogIn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(1033, 45);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(239, 321);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrar";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // contSer
            // 
            this.contSer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contSer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contSer.Location = new System.Drawing.Point(377, 501);
            this.contSer.Name = "contSer";
            this.contSer.Size = new System.Drawing.Size(224, 122);
            this.contSer.TabIndex = 27;
            this.contSer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.contSer.Click += new System.EventHandler(this.contSer_Click);
            // 
            // Enter
            // 
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.Location = new System.Drawing.Point(1033, 551);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(277, 139);
            this.Enter.TabIndex = 28;
            this.Enter.Text = "ENTER";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(665, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(352, 493);
            this.dataGridView2.TabIndex = 29;
            // 
            // buttonAceptarF1
            // 
            this.buttonAceptarF1.Location = new System.Drawing.Point(1043, 467);
            this.buttonAceptarF1.Name = "buttonAceptarF1";
            this.buttonAceptarF1.Size = new System.Drawing.Size(103, 46);
            this.buttonAceptarF1.TabIndex = 33;
            this.buttonAceptarF1.Text = "ACEPTAR";
            this.buttonAceptarF1.UseVisualStyleBackColor = true;
            this.buttonAceptarF1.Click += new System.EventHandler(this.buttonAceptarF1_Click);
            // 
            // buttonRechazarF1
            // 
            this.buttonRechazarF1.Location = new System.Drawing.Point(1219, 467);
            this.buttonRechazarF1.Name = "buttonRechazarF1";
            this.buttonRechazarF1.Size = new System.Drawing.Size(101, 44);
            this.buttonRechazarF1.TabIndex = 34;
            this.buttonRechazarF1.Text = "RECHAZAR";
            this.buttonRechazarF1.UseVisualStyleBackColor = true;
            this.buttonRechazarF1.Click += new System.EventHandler(this.buttonRechazarF1_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(1043, 433);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(277, 22);
            this.textBoxNom.TabIndex = 35;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(778, 551);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(226, 96);
            this.buttonEnviar.TabIndex = 36;
            this.buttonEnviar.Text = "ENVIAR";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 735);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.buttonRechazarF1);
            this.Controls.Add(this.buttonAceptarF1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.contSer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usuari;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ConQuienJuego;
        private System.Windows.Forms.RadioButton MasPuntos;
        private System.Windows.Forms.RadioButton Mascorta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox partida;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UsuariLogIn;
        private System.Windows.Forms.TextBox contrasenyaLogIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ContrasenyaSignIn;
        private System.Windows.Forms.TextBox UsuariSignIn;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label contSer;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonAceptarF1;
        private System.Windows.Forms.Button buttonRechazarF1;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button buttonEnviar;
    }
}

