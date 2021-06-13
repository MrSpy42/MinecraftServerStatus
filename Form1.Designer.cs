
namespace MinecraftServerStatus2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusValue = new System.Windows.Forms.Label();
            this.playersOnlineTextLabel = new System.Windows.Forms.Label();
            this.playersOnlineValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serverSoftwareValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pingValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ipValue = new System.Windows.Forms.Label();
            this.aboutBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.Location = new System.Drawing.Point(24, 26);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(81, 30);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Status :";
            // 
            // statusValue
            // 
            this.statusValue.AutoSize = true;
            this.statusValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusValue.Location = new System.Drawing.Point(111, 26);
            this.statusValue.Name = "statusValue";
            this.statusValue.Size = new System.Drawing.Size(23, 30);
            this.statusValue.TabIndex = 1;
            this.statusValue.Text = "?";
            // 
            // playersOnlineTextLabel
            // 
            this.playersOnlineTextLabel.AutoSize = true;
            this.playersOnlineTextLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playersOnlineTextLabel.Location = new System.Drawing.Point(24, 78);
            this.playersOnlineTextLabel.Name = "playersOnlineTextLabel";
            this.playersOnlineTextLabel.Size = new System.Drawing.Size(161, 30);
            this.playersOnlineTextLabel.TabIndex = 2;
            this.playersOnlineTextLabel.Text = "Players Online :";
            // 
            // playersOnlineValue
            // 
            this.playersOnlineValue.AutoSize = true;
            this.playersOnlineValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playersOnlineValue.Location = new System.Drawing.Point(191, 78);
            this.playersOnlineValue.Name = "playersOnlineValue";
            this.playersOnlineValue.Size = new System.Drawing.Size(74, 30);
            this.playersOnlineValue.TabIndex = 3;
            this.playersOnlineValue.Text = "?? / ??";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server Software :";
            // 
            // serverSoftwareValue
            // 
            this.serverSoftwareValue.AutoSize = true;
            this.serverSoftwareValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.serverSoftwareValue.Location = new System.Drawing.Point(209, 274);
            this.serverSoftwareValue.Name = "serverSoftwareValue";
            this.serverSoftwareValue.Size = new System.Drawing.Size(23, 30);
            this.serverSoftwareValue.TabIndex = 5;
            this.serverSoftwareValue.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(360, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ping :";
            // 
            // pingValue
            // 
            this.pingValue.AutoSize = true;
            this.pingValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pingValue.Location = new System.Drawing.Point(422, 26);
            this.pingValue.Name = "pingValue";
            this.pingValue.Size = new System.Drawing.Size(23, 30);
            this.pingValue.TabIndex = 7;
            this.pingValue.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "IP :";
            // 
            // ipValue
            // 
            this.ipValue.AutoSize = true;
            this.ipValue.Location = new System.Drawing.Point(53, 259);
            this.ipValue.Name = "ipValue";
            this.ipValue.Size = new System.Drawing.Size(12, 15);
            this.ipValue.TabIndex = 9;
            this.ipValue.Text = "?";
            // 
            // aboutBox
            // 
            this.aboutBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aboutBox.Location = new System.Drawing.Point(433, 280);
            this.aboutBox.Name = "aboutBox";
            this.aboutBox.Size = new System.Drawing.Size(55, 24);
            this.aboutBox.TabIndex = 10;
            this.aboutBox.Text = "About";
            this.aboutBox.UseVisualStyleBackColor = true;
            this.aboutBox.Click += new System.EventHandler(this.aboutBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(500, 331);
            this.Controls.Add(this.aboutBox);
            this.Controls.Add(this.ipValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pingValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverSoftwareValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playersOnlineValue);
            this.Controls.Add(this.playersOnlineTextLabel);
            this.Controls.Add(this.statusValue);
            this.Controls.Add(this.statusLabel);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Minecraft Server Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label statusValue;
        private System.Windows.Forms.Label playersOnlineTextLabel;
        private System.Windows.Forms.Label playersOnlineValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label serverSoftwareValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pingValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ipValue;
        private System.Windows.Forms.Button aboutBox;
    }
}

