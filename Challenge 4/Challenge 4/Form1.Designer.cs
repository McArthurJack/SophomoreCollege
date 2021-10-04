
namespace Challenge_4
{
    partial class Form1
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
            this.coordinates = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.latitudeTextBox = new System.Windows.Forms.TextBox();
            this.longitudeTextBox = new System.Windows.Forms.TextBox();
            this.authorizationLabel = new System.Windows.Forms.Label();
            this.authorizationTextbox = new System.Windows.Forms.TextBox();
            this.fireButton = new System.Windows.Forms.Button();
            this.countdownLabel = new System.Windows.Forms.Label();
            this.countdownTimerLabel = new System.Windows.Forms.Label();
            this.abortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coordinates
            // 
            this.coordinates.AutoSize = true;
            this.coordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coordinates.Location = new System.Drawing.Point(58, 39);
            this.coordinates.Name = "coordinates";
            this.coordinates.Size = new System.Drawing.Size(161, 24);
            this.coordinates.TabIndex = 0;
            this.coordinates.Text = "Enter Coordinates";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.Location = new System.Drawing.Point(48, 79);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(75, 18);
            this.xLabel.TabIndex = 1;
            this.xLabel.Text = "Latitude   :";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yLabel.Location = new System.Drawing.Point(48, 108);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(76, 18);
            this.yLabel.TabIndex = 2;
            this.yLabel.Text = "Longitude:";
            // 
            // latitudeTextBox
            // 
            this.latitudeTextBox.Location = new System.Drawing.Point(129, 77);
            this.latitudeTextBox.Name = "latitudeTextBox";
            this.latitudeTextBox.Size = new System.Drawing.Size(100, 20);
            this.latitudeTextBox.TabIndex = 3;
            // 
            // longitudeTextBox
            // 
            this.longitudeTextBox.Location = new System.Drawing.Point(129, 106);
            this.longitudeTextBox.Name = "longitudeTextBox";
            this.longitudeTextBox.Size = new System.Drawing.Size(100, 20);
            this.longitudeTextBox.TabIndex = 4;
            // 
            // authorizationLabel
            // 
            this.authorizationLabel.AutoSize = true;
            this.authorizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorizationLabel.Location = new System.Drawing.Point(58, 148);
            this.authorizationLabel.Name = "authorizationLabel";
            this.authorizationLabel.Size = new System.Drawing.Size(156, 24);
            this.authorizationLabel.TabIndex = 5;
            this.authorizationLabel.Text = "Authorization Key";
            // 
            // authorizationTextbox
            // 
            this.authorizationTextbox.Location = new System.Drawing.Point(51, 185);
            this.authorizationTextbox.Name = "authorizationTextbox";
            this.authorizationTextbox.Size = new System.Drawing.Size(178, 20);
            this.authorizationTextbox.TabIndex = 6;
            // 
            // fireButton
            // 
            this.fireButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fireButton.Location = new System.Drawing.Point(163, 238);
            this.fireButton.Name = "fireButton";
            this.fireButton.Size = new System.Drawing.Size(269, 84);
            this.fireButton.TabIndex = 7;
            this.fireButton.Text = "Initiate Lazer";
            this.fireButton.UseVisualStyleBackColor = true;
            this.fireButton.Click += new System.EventHandler(this.fireButton_Click);
            // 
            // countdownLabel
            // 
            this.countdownLabel.AutoSize = true;
            this.countdownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel.Location = new System.Drawing.Point(331, 39);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(190, 25);
            this.countdownLabel.TabIndex = 8;
            this.countdownLabel.Text = "Countdown till Fire";
            // 
            // countdownTimerLabel
            // 
            this.countdownTimerLabel.AutoSize = true;
            this.countdownTimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownTimerLabel.Location = new System.Drawing.Point(408, 71);
            this.countdownTimerLabel.Name = "countdownTimerLabel";
            this.countdownTimerLabel.Size = new System.Drawing.Size(51, 55);
            this.countdownTimerLabel.TabIndex = 9;
            this.countdownTimerLabel.Text = "0";
            // 
            // abortButton
            // 
            this.abortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abortButton.Location = new System.Drawing.Point(336, 148);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(185, 57);
            this.abortButton.TabIndex = 10;
            this.abortButton.Text = "ABORT";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "Form";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 357);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.countdownTimerLabel);
            this.Controls.Add(this.countdownLabel);
            this.Controls.Add(this.fireButton);
            this.Controls.Add(this.authorizationTextbox);
            this.Controls.Add(this.authorizationLabel);
            this.Controls.Add(this.longitudeTextBox);
            this.Controls.Add(this.latitudeTextBox);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.coordinates);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label coordinates;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.TextBox latitudeTextBox;
        private System.Windows.Forms.TextBox longitudeTextBox;
        private System.Windows.Forms.Label authorizationLabel;
        private System.Windows.Forms.TextBox authorizationTextbox;
        private System.Windows.Forms.Button fireButton;
        private System.Windows.Forms.Label countdownLabel;
        private System.Windows.Forms.Button abortButton;
        public System.Windows.Forms.Label countdownTimerLabel;
    }
}

