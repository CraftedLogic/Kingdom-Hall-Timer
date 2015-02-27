namespace KingdomHallTimer
{
    partial class MainForm
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.playLoudSoundButton = new System.Windows.Forms.Button();
            this.dingBellButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.fiveMinutesButton = new System.Windows.Forms.Button();
            this.threeMinutesButton = new System.Windows.Forms.Button();
            this.twoMinutesButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.switchButton = new System.Windows.Forms.Button();
            this.counterLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 350);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.06061F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.36364F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.57576F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel3.Controls.Add(this.playLoudSoundButton, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.dingBellButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.aboutButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 223);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(444, 124);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // playLoudSoundButton
            // 
            this.playLoudSoundButton.BackgroundImage = global::KingdomHallTimer.Properties.Resources.Buzzerl;
            this.playLoudSoundButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playLoudSoundButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.playLoudSoundButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playLoudSoundButton.FlatAppearance.BorderSize = 0;
            this.playLoudSoundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playLoudSoundButton.Location = new System.Drawing.Point(207, 3);
            this.playLoudSoundButton.Name = "playLoudSoundButton";
            this.playLoudSoundButton.Size = new System.Drawing.Size(117, 118);
            this.playLoudSoundButton.TabIndex = 18;
            this.playLoudSoundButton.Text = "Buzzer";
            this.playLoudSoundButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.playLoudSoundButton.UseVisualStyleBackColor = true;
            this.playLoudSoundButton.Click += new System.EventHandler(this.playLoudSoundButton_Click);
            // 
            // dingBellButton
            // 
            this.dingBellButton.BackgroundImage = global::KingdomHallTimer.Properties.Resources.Loud_Bell;
            this.dingBellButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dingBellButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dingBellButton.FlatAppearance.BorderSize = 0;
            this.dingBellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dingBellButton.Location = new System.Drawing.Point(55, 3);
            this.dingBellButton.Name = "dingBellButton";
            this.dingBellButton.Size = new System.Drawing.Size(146, 118);
            this.dingBellButton.TabIndex = 14;
            this.dingBellButton.Text = "Bell";
            this.dingBellButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dingBellButton.UseVisualStyleBackColor = true;
            this.dingBellButton.Click += new System.EventHandler(this.dingBellButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.BackgroundImage = global::KingdomHallTimer.Properties.Resources._214_info;
            this.aboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aboutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.Location = new System.Drawing.Point(3, 3);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(46, 118);
            this.aboutButton.TabIndex = 19;
            this.aboutButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.fiveMinutesButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.threeMinutesButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.twoMinutesButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(444, 94);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // fiveMinutesButton
            // 
            this.fiveMinutesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fiveMinutesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fiveMinutesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fiveMinutesButton.FlatAppearance.BorderSize = 0;
            this.fiveMinutesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiveMinutesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveMinutesButton.Image = global::KingdomHallTimer.Properties.Resources.ClockPng;
            this.fiveMinutesButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.fiveMinutesButton.Location = new System.Drawing.Point(299, 3);
            this.fiveMinutesButton.Name = "fiveMinutesButton";
            this.fiveMinutesButton.Size = new System.Drawing.Size(142, 88);
            this.fiveMinutesButton.TabIndex = 15;
            this.fiveMinutesButton.Text = "05:00";
            this.fiveMinutesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fiveMinutesButton.UseVisualStyleBackColor = true;
            this.fiveMinutesButton.Click += new System.EventHandler(this.fiveMinutesButton_Click);
            // 
            // threeMinutesButton
            // 
            this.threeMinutesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.threeMinutesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.threeMinutesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threeMinutesButton.FlatAppearance.BorderSize = 0;
            this.threeMinutesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeMinutesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeMinutesButton.Image = global::KingdomHallTimer.Properties.Resources.ClockPng;
            this.threeMinutesButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.threeMinutesButton.Location = new System.Drawing.Point(151, 3);
            this.threeMinutesButton.Name = "threeMinutesButton";
            this.threeMinutesButton.Size = new System.Drawing.Size(142, 88);
            this.threeMinutesButton.TabIndex = 13;
            this.threeMinutesButton.Text = "03:00";
            this.threeMinutesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.threeMinutesButton.UseVisualStyleBackColor = true;
            this.threeMinutesButton.Click += new System.EventHandler(this.threeMinutesButton_Click);
            // 
            // twoMinutesButton
            // 
            this.twoMinutesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.twoMinutesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twoMinutesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoMinutesButton.FlatAppearance.BorderSize = 0;
            this.twoMinutesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoMinutesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoMinutesButton.Image = global::KingdomHallTimer.Properties.Resources.ClockPng;
            this.twoMinutesButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.twoMinutesButton.Location = new System.Drawing.Point(3, 3);
            this.twoMinutesButton.Name = "twoMinutesButton";
            this.twoMinutesButton.Size = new System.Drawing.Size(142, 88);
            this.twoMinutesButton.TabIndex = 12;
            this.twoMinutesButton.Text = "02:00";
            this.twoMinutesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.twoMinutesButton.UseVisualStyleBackColor = true;
            this.twoMinutesButton.Click += new System.EventHandler(this.twoMinutesButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.55013F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.44987F));
            this.tableLayoutPanel4.Controls.Add(this.switchButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.counterLabel, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(444, 114);
            this.tableLayoutPanel4.TabIndex = 17;
            // 
            // switchButton
            // 
            this.switchButton.BackgroundImage = global::KingdomHallTimer.Properties.Resources._412_play;
            this.switchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.switchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.switchButton.FlatAppearance.BorderSize = 0;
            this.switchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchButton.Location = new System.Drawing.Point(334, 3);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(107, 108);
            this.switchButton.TabIndex = 18;
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.BackColor = System.Drawing.Color.LightBlue;
            this.counterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.counterLabel.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLabel.ForeColor = System.Drawing.Color.Black;
            this.counterLabel.Location = new System.Drawing.Point(3, 0);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(325, 114);
            this.counterLabel.TabIndex = 17;
            this.counterLabel.Text = "00:00:01";
            this.counterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Kingdom Hall Timer";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button twoMinutesButton;
        private System.Windows.Forms.Button fiveMinutesButton;
        private System.Windows.Forms.Button threeMinutesButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button dingBellButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button switchButton;
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.Button playLoudSoundButton;
        private System.Windows.Forms.Button aboutButton;
    }
}

