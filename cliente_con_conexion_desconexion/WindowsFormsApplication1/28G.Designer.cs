namespace WindowsFormsApplication1
{
    partial class _28G
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
            this.buttonTelefono = new System.Windows.Forms.Button();
            this.buttonCarpeta = new System.Windows.Forms.Button();
            this.buttonImpresora = new System.Windows.Forms.Button();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxImpresora = new System.Windows.Forms.TextBox();
            this.textBoxCarpeta = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTelefono
            // 
            this.buttonTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTelefono.Location = new System.Drawing.Point(304, 274);
            this.buttonTelefono.Name = "buttonTelefono";
            this.buttonTelefono.Size = new System.Drawing.Size(101, 34);
            this.buttonTelefono.TabIndex = 0;
            this.buttonTelefono.Text = "Usar Teléfono";
            this.buttonTelefono.UseVisualStyleBackColor = true;
            this.buttonTelefono.Click += new System.EventHandler(this.buttonTelefono_Click);
            // 
            // buttonCarpeta
            // 
            this.buttonCarpeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCarpeta.Location = new System.Drawing.Point(209, 388);
            this.buttonCarpeta.Name = "buttonCarpeta";
            this.buttonCarpeta.Size = new System.Drawing.Size(144, 29);
            this.buttonCarpeta.TabIndex = 2;
            this.buttonCarpeta.Text = "Usar carpeta";
            this.buttonCarpeta.UseVisualStyleBackColor = true;
            this.buttonCarpeta.Click += new System.EventHandler(this.buttonCarpeta_Click);
            // 
            // buttonImpresora
            // 
            this.buttonImpresora.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImpresora.Location = new System.Drawing.Point(424, 248);
            this.buttonImpresora.Name = "buttonImpresora";
            this.buttonImpresora.Size = new System.Drawing.Size(113, 33);
            this.buttonImpresora.TabIndex = 3;
            this.buttonImpresora.Text = "Usar impresora";
            this.buttonImpresora.UseVisualStyleBackColor = true;
            this.buttonImpresora.Click += new System.EventHandler(this.buttonImpresora_Click);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(197, 274);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(101, 22);
            this.textBoxTelefono.TabIndex = 4;
            // 
            // textBoxImpresora
            // 
            this.textBoxImpresora.Location = new System.Drawing.Point(424, 220);
            this.textBoxImpresora.Name = "textBoxImpresora";
            this.textBoxImpresora.Size = new System.Drawing.Size(107, 22);
            this.textBoxImpresora.TabIndex = 5;
            this.textBoxImpresora.TextChanged += new System.EventHandler(this.textBoxImpresora_TextChanged);
            // 
            // textBoxCarpeta
            // 
            this.textBoxCarpeta.Location = new System.Drawing.Point(210, 360);
            this.textBoxCarpeta.Name = "textBoxCarpeta";
            this.textBoxCarpeta.Size = new System.Drawing.Size(143, 22);
            this.textBoxCarpeta.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(900, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // _28G
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Scenario28G;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 489);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxCarpeta);
            this.Controls.Add(this.textBoxImpresora);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.buttonImpresora);
            this.Controls.Add(this.buttonCarpeta);
            this.Controls.Add(this.buttonTelefono);
            this.Name = "_28G";
            this.Text = "_28G";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTelefono;
        private System.Windows.Forms.Button buttonCarpeta;
        private System.Windows.Forms.Button buttonImpresora;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxImpresora;
        private System.Windows.Forms.TextBox textBoxCarpeta;
        private System.Windows.Forms.Button button2;
    }
}