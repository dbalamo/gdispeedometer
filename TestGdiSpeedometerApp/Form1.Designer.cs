
namespace TestGdiSpeedometerApp
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gdiSpeedometer1 = new TestGdiSpeedometerApp.GDISpeedometer();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Percentage";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Accelerometer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Only Gauge";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(252, 35);
            this.button4.TabIndex = 6;
            this.button4.Text = "Increasing 1% Percentage";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // gdiSpeedometer1
            // 
            this.gdiSpeedometer1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.gdiSpeedometer1.CurrentValueFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.gdiSpeedometer1.Font = new System.Drawing.Font("Arial", 8F);
            this.gdiSpeedometer1.GaugeColor = System.Drawing.Color.DodgerBlue;
            this.gdiSpeedometer1.GaugeThickness = 3;
            this.gdiSpeedometer1.Location = new System.Drawing.Point(270, 26);
            this.gdiSpeedometer1.MaxSpeed = 100D;
            this.gdiSpeedometer1.MinSpeed = 0D;
            this.gdiSpeedometer1.Name = "gdiSpeedometer1";
            this.gdiSpeedometer1.NeedleColor = System.Drawing.Color.Red;
            this.gdiSpeedometer1.ShowGaugeScale = true;
            this.gdiSpeedometer1.ShowNeedle = true;
            this.gdiSpeedometer1.Size = new System.Drawing.Size(309, 289);
            this.gdiSpeedometer1.TabIndex = 5;
            this.gdiSpeedometer1.Text = "gdiSpeedometer1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(252, 35);
            this.button5.TabIndex = 7;
            this.button5.Text = "Increasing 0.1% Percentage";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 451);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.gdiSpeedometer1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private GDISpeedometer gdiSpeedometer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

