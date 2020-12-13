namespace WindowsFormsApplication1
{
    partial class SalaActos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaActos));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Vermell = new System.Windows.Forms.Button();
            this.Taronja = new System.Windows.Forms.Button();
            this.Groc = new System.Windows.Forms.Button();
            this.Verd = new System.Windows.Forms.Button();
            this.Blau = new System.Windows.Forms.Button();
            this.Lila = new System.Windows.Forms.Button();
            this.Rosa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(599, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 82);
            this.button1.TabIndex = 7;
            this.button1.Text = "RESOLVER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 293);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "0";
            // 
            // Vermell
            // 
            this.Vermell.Location = new System.Drawing.Point(292, 243);
            this.Vermell.Name = "Vermell";
            this.Vermell.Size = new System.Drawing.Size(31, 19);
            this.Vermell.TabIndex = 9;
            this.Vermell.Text = "button2";
            this.Vermell.UseVisualStyleBackColor = true;
            this.Vermell.Click += new System.EventHandler(this.Vermell_Click);
            // 
            // Taronja
            // 
            this.Taronja.Location = new System.Drawing.Point(292, 268);
            this.Taronja.Name = "Taronja";
            this.Taronja.Size = new System.Drawing.Size(31, 19);
            this.Taronja.TabIndex = 10;
            this.Taronja.Text = "button3";
            this.Taronja.UseVisualStyleBackColor = true;
            this.Taronja.Click += new System.EventHandler(this.Taronja_Click);
            // 
            // Groc
            // 
            this.Groc.Location = new System.Drawing.Point(292, 293);
            this.Groc.Name = "Groc";
            this.Groc.Size = new System.Drawing.Size(31, 19);
            this.Groc.TabIndex = 11;
            this.Groc.Text = "button4";
            this.Groc.UseVisualStyleBackColor = true;
            this.Groc.Click += new System.EventHandler(this.Groc_Click);
            // 
            // Verd
            // 
            this.Verd.Location = new System.Drawing.Point(385, 243);
            this.Verd.Name = "Verd";
            this.Verd.Size = new System.Drawing.Size(31, 19);
            this.Verd.TabIndex = 12;
            this.Verd.Text = "button5";
            this.Verd.UseVisualStyleBackColor = true;
            this.Verd.Click += new System.EventHandler(this.Verd_Click);
            // 
            // Blau
            // 
            this.Blau.Location = new System.Drawing.Point(461, 232);
            this.Blau.Name = "Blau";
            this.Blau.Size = new System.Drawing.Size(31, 19);
            this.Blau.TabIndex = 13;
            this.Blau.Text = "button6";
            this.Blau.UseVisualStyleBackColor = true;
            this.Blau.Click += new System.EventHandler(this.Blau_Click);
            // 
            // Lila
            // 
            this.Lila.Location = new System.Drawing.Point(461, 257);
            this.Lila.Name = "Lila";
            this.Lila.Size = new System.Drawing.Size(31, 19);
            this.Lila.TabIndex = 14;
            this.Lila.Text = "button7";
            this.Lila.UseVisualStyleBackColor = true;
            this.Lila.Click += new System.EventHandler(this.Lila_Click);
            // 
            // Rosa
            // 
            this.Rosa.Location = new System.Drawing.Point(461, 282);
            this.Rosa.Name = "Rosa";
            this.Rosa.Size = new System.Drawing.Size(31, 19);
            this.Rosa.TabIndex = 15;
            this.Rosa.Text = "button8";
            this.Rosa.UseVisualStyleBackColor = true;
            this.Rosa.Click += new System.EventHandler(this.Rosa_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SalaActos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 480);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Rosa);
            this.Controls.Add(this.Lila);
            this.Controls.Add(this.Blau);
            this.Controls.Add(this.Verd);
            this.Controls.Add(this.Groc);
            this.Controls.Add(this.Taronja);
            this.Controls.Add(this.Vermell);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "SalaActos";
            this.Text = "SalaActos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Vermell;
        private System.Windows.Forms.Button Taronja;
        private System.Windows.Forms.Button Groc;
        private System.Windows.Forms.Button Verd;
        private System.Windows.Forms.Button Blau;
        private System.Windows.Forms.Button Lila;
        private System.Windows.Forms.Button Rosa;
        private System.Windows.Forms.Button button2;
    }
}