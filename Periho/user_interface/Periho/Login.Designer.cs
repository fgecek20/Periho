namespace Periho
{
    partial class Login
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
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.lblWhosUsing = new System.Windows.Forms.Label();
            this.btnEnrollNewUser = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblTestResult = new System.Windows.Forms.Label();
            this.tbNewUser = new System.Windows.Forms.TextBox();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUsers
            // 
            this.lbUsers.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 31;
            this.lbUsers.Location = new System.Drawing.Point(288, 177);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(175, 155);
            this.lbUsers.TabIndex = 0;
            // 
            // lblWhosUsing
            // 
            this.lblWhosUsing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWhosUsing.AutoSize = true;
            this.lblWhosUsing.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWhosUsing.Location = new System.Drawing.Point(217, 102);
            this.lblWhosUsing.Name = "lblWhosUsing";
            this.lblWhosUsing.Size = new System.Drawing.Size(347, 39);
            this.lblWhosUsing.TabIndex = 1;
            this.lblWhosUsing.Text = "Who\'s using the app?";
            this.lblWhosUsing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnrollNewUser
            // 
            this.btnEnrollNewUser.BackColor = System.Drawing.Color.Silver;
            this.btnEnrollNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnrollNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEnrollNewUser.Location = new System.Drawing.Point(368, 417);
            this.btnEnrollNewUser.Name = "btnEnrollNewUser";
            this.btnEnrollNewUser.Size = new System.Drawing.Size(129, 59);
            this.btnEnrollNewUser.TabIndex = 2;
            this.btnEnrollNewUser.Text = "Enroll New User";
            this.btnEnrollNewUser.UseVisualStyleBackColor = false;
            this.btnEnrollNewUser.Click += new System.EventHandler(this.btnEnrollNewUser_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Silver;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSelect.Location = new System.Drawing.Point(224, 417);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(129, 59);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblTestResult
            // 
            this.lblTestResult.AutoSize = true;
            this.lblTestResult.Location = new System.Drawing.Point(221, 501);
            this.lblTestResult.Name = "lblTestResult";
            this.lblTestResult.Size = new System.Drawing.Size(0, 13);
            this.lblTestResult.TabIndex = 4;
            // 
            // tbNewUser
            // 
            this.tbNewUser.Location = new System.Drawing.Point(368, 512);
            this.tbNewUser.Name = "tbNewUser";
            this.tbNewUser.Size = new System.Drawing.Size(129, 20);
            this.tbNewUser.TabIndex = 5;
            // 
            // btnEnroll
            // 
            this.btnEnroll.BackColor = System.Drawing.Color.Silver;
            this.btnEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnroll.Location = new System.Drawing.Point(404, 559);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(93, 33);
            this.btnEnroll.TabIndex = 6;
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.UseVisualStyleBackColor = false;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.tbNewUser);
            this.Controls.Add(this.lblTestResult);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnEnrollNewUser);
            this.Controls.Add(this.lblWhosUsing);
            this.Controls.Add(this.lbUsers);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 670);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 670);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Periho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Label lblWhosUsing;
        private System.Windows.Forms.Button btnEnrollNewUser;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblTestResult;
        private System.Windows.Forms.TextBox tbNewUser;
        private System.Windows.Forms.Button btnEnroll;
    }
}

