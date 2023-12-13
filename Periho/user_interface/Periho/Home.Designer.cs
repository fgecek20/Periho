namespace Periho
{
    partial class Home
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblHeartrate = new System.Windows.Forms.Label();
            this.lblTemperatureValue = new System.Windows.Forms.Label();
            this.lblHeartRateValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWelcome.Location = new System.Drawing.Point(29, 32);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(283, 42);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome back, ";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTemperature.Location = new System.Drawing.Point(117, 215);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(226, 39);
            this.lblTemperature.TabIndex = 1;
            this.lblTemperature.Text = "Temperature:";
            // 
            // lblHeartrate
            // 
            this.lblHeartrate.AutoSize = true;
            this.lblHeartrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHeartrate.Location = new System.Drawing.Point(401, 215);
            this.lblHeartrate.Name = "lblHeartrate";
            this.lblHeartrate.Size = new System.Drawing.Size(181, 39);
            this.lblHeartrate.TabIndex = 2;
            this.lblHeartrate.Text = "Heart rate:";
            // 
            // lblTemperatureValue
            // 
            this.lblTemperatureValue.AutoSize = true;
            this.lblTemperatureValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTemperatureValue.Location = new System.Drawing.Point(199, 304);
            this.lblTemperatureValue.Name = "lblTemperatureValue";
            this.lblTemperatureValue.Size = new System.Drawing.Size(40, 39);
            this.lblTemperatureValue.TabIndex = 3;
            this.lblTemperatureValue.Text = "X";
            // 
            // lblHeartRateValue
            // 
            this.lblHeartRateValue.AutoSize = true;
            this.lblHeartRateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHeartRateValue.Location = new System.Drawing.Point(460, 304);
            this.lblHeartRateValue.Name = "lblHeartRateValue";
            this.lblHeartRateValue.Size = new System.Drawing.Size(40, 39);
            this.lblHeartRateValue.TabIndex = 4;
            this.lblHeartRateValue.Text = "X";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1285, 747);
            this.Controls.Add(this.lblHeartRateValue);
            this.Controls.Add(this.lblTemperatureValue);
            this.Controls.Add(this.lblHeartrate);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblWelcome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Periho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblHeartrate;
        private System.Windows.Forms.Label lblTemperatureValue;
        private System.Windows.Forms.Label lblHeartRateValue;
    }
}