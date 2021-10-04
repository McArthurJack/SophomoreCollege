
namespace McArthurJA2
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
            this.searchButton = new System.Windows.Forms.Button();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.BrandTextBox = new System.Windows.Forms.TextBox();
            this.MfrLabel = new System.Windows.Forms.Label();
            this.MfrTextBox = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.CaloriesLabel = new System.Windows.Forms.Label();
            this.CaloriesTextBox = new System.Windows.Forms.TextBox();
            this.ProteinTextBox = new System.Windows.Forms.TextBox();
            this.ProteinLabel = new System.Windows.Forms.Label();
            this.Fat = new System.Windows.Forms.Label();
            this.FatTextBox = new System.Windows.Forms.TextBox();
            this.SodiumTextBox = new System.Windows.Forms.TextBox();
            this.FiberTextBox = new System.Windows.Forms.TextBox();
            this.SodiumLabel = new System.Windows.Forms.Label();
            this.FiberLabel = new System.Windows.Forms.Label();
            this.VitaminsTextBox = new System.Windows.Forms.TextBox();
            this.VitaminsLabel = new System.Windows.Forms.Label();
            this.PotassTextBox = new System.Windows.Forms.TextBox();
            this.PotassLabel = new System.Windows.Forms.Label();
            this.SugarsTextBox = new System.Windows.Forms.TextBox();
            this.SugarsLabel = new System.Windows.Forms.Label();
            this.CarboTextBox = new System.Windows.Forms.TextBox();
            this.CarboLabel = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.CupsTextBox = new System.Windows.Forms.TextBox();
            this.CupsLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.ShelfTextBox = new System.Windows.Forms.TextBox();
            this.ShelfLabel = new System.Windows.Forms.Label();
            this.queryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(98, 328);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(165, 74);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resultsListBox
            // 
            this.resultsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.ItemHeight = 16;
            this.resultsListBox.Location = new System.Drawing.Point(374, 50);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(405, 372);
            this.resultsListBox.TabIndex = 1;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.Location = new System.Drawing.Point(516, 16);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(106, 31);
            this.resultsLabel.TabIndex = 2;
            this.resultsLabel.Text = "Results";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.Location = new System.Drawing.Point(20, 51);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(44, 16);
            this.brandLabel.TabIndex = 3;
            this.brandLabel.Text = "Brand";
            // 
            // BrandTextBox
            // 
            this.BrandTextBox.Location = new System.Drawing.Point(71, 51);
            this.BrandTextBox.Name = "BrandTextBox";
            this.BrandTextBox.Size = new System.Drawing.Size(100, 20);
            this.BrandTextBox.TabIndex = 4;
            // 
            // MfrLabel
            // 
            this.MfrLabel.AutoSize = true;
            this.MfrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MfrLabel.Location = new System.Drawing.Point(28, 87);
            this.MfrLabel.Name = "MfrLabel";
            this.MfrLabel.Size = new System.Drawing.Size(37, 16);
            this.MfrLabel.TabIndex = 5;
            this.MfrLabel.Text = "MFR";
            // 
            // MfrTextBox
            // 
            this.MfrTextBox.Location = new System.Drawing.Point(71, 86);
            this.MfrTextBox.Name = "MfrTextBox";
            this.MfrTextBox.Size = new System.Drawing.Size(100, 20);
            this.MfrTextBox.TabIndex = 6;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(25, 118);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(40, 16);
            this.TypeLabel.TabIndex = 7;
            this.TypeLabel.Text = "Type";
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(71, 118);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.TypeTextBox.TabIndex = 8;
            // 
            // CaloriesLabel
            // 
            this.CaloriesLabel.AutoSize = true;
            this.CaloriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaloriesLabel.Location = new System.Drawing.Point(7, 152);
            this.CaloriesLabel.Name = "CaloriesLabel";
            this.CaloriesLabel.Size = new System.Drawing.Size(58, 16);
            this.CaloriesLabel.TabIndex = 9;
            this.CaloriesLabel.Text = "Calories";
            // 
            // CaloriesTextBox
            // 
            this.CaloriesTextBox.Location = new System.Drawing.Point(71, 151);
            this.CaloriesTextBox.Name = "CaloriesTextBox";
            this.CaloriesTextBox.Size = new System.Drawing.Size(100, 20);
            this.CaloriesTextBox.TabIndex = 10;
            // 
            // ProteinTextBox
            // 
            this.ProteinTextBox.Location = new System.Drawing.Point(246, 50);
            this.ProteinTextBox.Name = "ProteinTextBox";
            this.ProteinTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProteinTextBox.TabIndex = 12;
            // 
            // ProteinLabel
            // 
            this.ProteinLabel.AutoSize = true;
            this.ProteinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProteinLabel.Location = new System.Drawing.Point(190, 51);
            this.ProteinLabel.Name = "ProteinLabel";
            this.ProteinLabel.Size = new System.Drawing.Size(50, 16);
            this.ProteinLabel.TabIndex = 11;
            this.ProteinLabel.Text = "Protein";
            // 
            // Fat
            // 
            this.Fat.AutoSize = true;
            this.Fat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fat.Location = new System.Drawing.Point(213, 88);
            this.Fat.Name = "Fat";
            this.Fat.Size = new System.Drawing.Size(27, 16);
            this.Fat.TabIndex = 13;
            this.Fat.Text = "Fat";
            // 
            // FatTextBox
            // 
            this.FatTextBox.Location = new System.Drawing.Point(246, 87);
            this.FatTextBox.Name = "FatTextBox";
            this.FatTextBox.Size = new System.Drawing.Size(100, 20);
            this.FatTextBox.TabIndex = 14;
            // 
            // SodiumTextBox
            // 
            this.SodiumTextBox.Location = new System.Drawing.Point(246, 118);
            this.SodiumTextBox.Name = "SodiumTextBox";
            this.SodiumTextBox.Size = new System.Drawing.Size(100, 20);
            this.SodiumTextBox.TabIndex = 15;
            // 
            // FiberTextBox
            // 
            this.FiberTextBox.Location = new System.Drawing.Point(246, 152);
            this.FiberTextBox.Name = "FiberTextBox";
            this.FiberTextBox.Size = new System.Drawing.Size(100, 20);
            this.FiberTextBox.TabIndex = 16;
            // 
            // SodiumLabel
            // 
            this.SodiumLabel.AutoSize = true;
            this.SodiumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SodiumLabel.Location = new System.Drawing.Point(186, 118);
            this.SodiumLabel.Name = "SodiumLabel";
            this.SodiumLabel.Size = new System.Drawing.Size(54, 16);
            this.SodiumLabel.TabIndex = 17;
            this.SodiumLabel.Text = "Sodium";
            // 
            // FiberLabel
            // 
            this.FiberLabel.AutoSize = true;
            this.FiberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiberLabel.Location = new System.Drawing.Point(201, 153);
            this.FiberLabel.Name = "FiberLabel";
            this.FiberLabel.Size = new System.Drawing.Size(39, 16);
            this.FiberLabel.TabIndex = 18;
            this.FiberLabel.Text = "Fiber";
            // 
            // VitaminsTextBox
            // 
            this.VitaminsTextBox.Location = new System.Drawing.Point(71, 282);
            this.VitaminsTextBox.Name = "VitaminsTextBox";
            this.VitaminsTextBox.Size = new System.Drawing.Size(100, 20);
            this.VitaminsTextBox.TabIndex = 26;
            // 
            // VitaminsLabel
            // 
            this.VitaminsLabel.AutoSize = true;
            this.VitaminsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VitaminsLabel.Location = new System.Drawing.Point(6, 283);
            this.VitaminsLabel.Name = "VitaminsLabel";
            this.VitaminsLabel.Size = new System.Drawing.Size(59, 16);
            this.VitaminsLabel.TabIndex = 25;
            this.VitaminsLabel.Text = "Vitamins";
            // 
            // PotassTextBox
            // 
            this.PotassTextBox.Location = new System.Drawing.Point(71, 249);
            this.PotassTextBox.Name = "PotassTextBox";
            this.PotassTextBox.Size = new System.Drawing.Size(100, 20);
            this.PotassTextBox.TabIndex = 24;
            // 
            // PotassLabel
            // 
            this.PotassLabel.AutoSize = true;
            this.PotassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotassLabel.Location = new System.Drawing.Point(15, 250);
            this.PotassLabel.Name = "PotassLabel";
            this.PotassLabel.Size = new System.Drawing.Size(50, 16);
            this.PotassLabel.TabIndex = 23;
            this.PotassLabel.Text = "Potass";
            // 
            // SugarsTextBox
            // 
            this.SugarsTextBox.Location = new System.Drawing.Point(71, 217);
            this.SugarsTextBox.Name = "SugarsTextBox";
            this.SugarsTextBox.Size = new System.Drawing.Size(100, 20);
            this.SugarsTextBox.TabIndex = 22;
            // 
            // SugarsLabel
            // 
            this.SugarsLabel.AutoSize = true;
            this.SugarsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SugarsLabel.Location = new System.Drawing.Point(14, 218);
            this.SugarsLabel.Name = "SugarsLabel";
            this.SugarsLabel.Size = new System.Drawing.Size(51, 16);
            this.SugarsLabel.TabIndex = 21;
            this.SugarsLabel.Text = "Sugars";
            // 
            // CarboTextBox
            // 
            this.CarboTextBox.Location = new System.Drawing.Point(71, 182);
            this.CarboTextBox.Name = "CarboTextBox";
            this.CarboTextBox.Size = new System.Drawing.Size(100, 20);
            this.CarboTextBox.TabIndex = 20;
            // 
            // CarboLabel
            // 
            this.CarboLabel.AutoSize = true;
            this.CarboLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarboLabel.Location = new System.Drawing.Point(20, 183);
            this.CarboLabel.Name = "CarboLabel";
            this.CarboLabel.Size = new System.Drawing.Size(45, 16);
            this.CarboLabel.TabIndex = 19;
            this.CarboLabel.Text = "Carbo";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(246, 281);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(100, 20);
            this.RatingTextBox.TabIndex = 34;
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingLabel.Location = new System.Drawing.Point(193, 283);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(47, 16);
            this.RatingLabel.TabIndex = 33;
            this.RatingLabel.Text = "Rating";
            // 
            // CupsTextBox
            // 
            this.CupsTextBox.Location = new System.Drawing.Point(246, 248);
            this.CupsTextBox.Name = "CupsTextBox";
            this.CupsTextBox.Size = new System.Drawing.Size(100, 20);
            this.CupsTextBox.TabIndex = 32;
            // 
            // CupsLabel
            // 
            this.CupsLabel.AutoSize = true;
            this.CupsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CupsLabel.Location = new System.Drawing.Point(201, 249);
            this.CupsLabel.Name = "CupsLabel";
            this.CupsLabel.Size = new System.Drawing.Size(39, 16);
            this.CupsLabel.TabIndex = 31;
            this.CupsLabel.Text = "Cups";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(246, 216);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.WeightTextBox.TabIndex = 30;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(190, 217);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(50, 16);
            this.WeightLabel.TabIndex = 29;
            this.WeightLabel.Text = "Weight";
            // 
            // ShelfTextBox
            // 
            this.ShelfTextBox.Location = new System.Drawing.Point(246, 181);
            this.ShelfTextBox.Name = "ShelfTextBox";
            this.ShelfTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShelfTextBox.TabIndex = 28;
            // 
            // ShelfLabel
            // 
            this.ShelfLabel.AutoSize = true;
            this.ShelfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShelfLabel.Location = new System.Drawing.Point(202, 183);
            this.ShelfLabel.Name = "ShelfLabel";
            this.ShelfLabel.Size = new System.Drawing.Size(38, 16);
            this.ShelfLabel.TabIndex = 27;
            this.ShelfLabel.Text = "Shelf";
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryLabel.Location = new System.Drawing.Point(85, 16);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(219, 16);
            this.queryLabel.TabIndex = 35;
            this.queryLabel.Text = "Less than or Equal to Query Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.queryLabel);
            this.Controls.Add(this.RatingTextBox);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.CupsTextBox);
            this.Controls.Add(this.CupsLabel);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.ShelfTextBox);
            this.Controls.Add(this.ShelfLabel);
            this.Controls.Add(this.VitaminsTextBox);
            this.Controls.Add(this.VitaminsLabel);
            this.Controls.Add(this.PotassTextBox);
            this.Controls.Add(this.PotassLabel);
            this.Controls.Add(this.SugarsTextBox);
            this.Controls.Add(this.SugarsLabel);
            this.Controls.Add(this.CarboTextBox);
            this.Controls.Add(this.CarboLabel);
            this.Controls.Add(this.FiberLabel);
            this.Controls.Add(this.SodiumLabel);
            this.Controls.Add(this.FiberTextBox);
            this.Controls.Add(this.SodiumTextBox);
            this.Controls.Add(this.FatTextBox);
            this.Controls.Add(this.Fat);
            this.Controls.Add(this.ProteinTextBox);
            this.Controls.Add(this.ProteinLabel);
            this.Controls.Add(this.CaloriesTextBox);
            this.Controls.Add(this.CaloriesLabel);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.MfrTextBox);
            this.Controls.Add(this.MfrLabel);
            this.Controls.Add(this.BrandTextBox);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.searchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.TextBox BrandTextBox;
        private System.Windows.Forms.Label MfrLabel;
        private System.Windows.Forms.TextBox MfrTextBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.Label CaloriesLabel;
        private System.Windows.Forms.TextBox CaloriesTextBox;
        private System.Windows.Forms.TextBox ProteinTextBox;
        private System.Windows.Forms.Label ProteinLabel;
        private System.Windows.Forms.Label Fat;
        private System.Windows.Forms.TextBox FatTextBox;
        private System.Windows.Forms.TextBox SodiumTextBox;
        private System.Windows.Forms.TextBox FiberTextBox;
        private System.Windows.Forms.Label SodiumLabel;
        private System.Windows.Forms.Label FiberLabel;
        private System.Windows.Forms.TextBox VitaminsTextBox;
        private System.Windows.Forms.Label VitaminsLabel;
        private System.Windows.Forms.TextBox PotassTextBox;
        private System.Windows.Forms.Label PotassLabel;
        private System.Windows.Forms.TextBox SugarsTextBox;
        private System.Windows.Forms.Label SugarsLabel;
        private System.Windows.Forms.TextBox CarboTextBox;
        private System.Windows.Forms.Label CarboLabel;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.TextBox CupsTextBox;
        private System.Windows.Forms.Label CupsLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox ShelfTextBox;
        private System.Windows.Forms.Label ShelfLabel;
        private System.Windows.Forms.Label queryLabel;
    }
}
