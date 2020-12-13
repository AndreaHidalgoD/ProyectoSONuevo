namespace WindowsFormsApplication1
{
    partial class G1
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
            this.buttonLlum = new System.Windows.Forms.Button();
            this.textBoxG1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonG1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLlum
            // 
            this.buttonLlum.Location = new System.Drawing.Point(33, 259);
            this.buttonLlum.Name = "buttonLlum";
            this.buttonLlum.Size = new System.Drawing.Size(20, 25);
            this.buttonLlum.TabIndex = 0;
            this.buttonLlum.Text = "buttonLlum";
            this.buttonLlum.UseVisualStyleBackColor = true;
            this.buttonLlum.Click += new System.EventHandler(this.buttonLlum_Click);
            // 
            // textBoxG1
            // 
            this.textBoxG1.Location = new System.Drawing.Point(429, 465);
            this.textBoxG1.Name = "textBoxG1";
            this.textBoxG1.Size = new System.Drawing.Size(100, 22);
            this.textBoxG1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "RESPUESTA:";
            // 
            // buttonG1
            // 
            this.buttonG1.Location = new System.Drawing.Point(642, 445);
            this.buttonG1.Name = "buttonG1";
            this.buttonG1.Size = new System.Drawing.Size(114, 53);
            this.buttonG1.TabIndex = 3;
            this.buttonG1.Text = "Comprobar Respuesta";
            this.buttonG1.UseVisualStyleBackColor = true;
            this.buttonG1.Click += new System.EventHandler(this.buttonG1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // G1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Groga1llum;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonG1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxG1);
            this.Controls.Add(this.buttonLlum);
            this.DoubleBuffered = true;
            this.Name = "G1";
            this.Text = "G1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLlum;
        private System.Windows.Forms.TextBox textBoxG1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonG1;
        private System.Windows.Forms.Button button1;
    }
}