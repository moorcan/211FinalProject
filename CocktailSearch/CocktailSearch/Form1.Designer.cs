namespace CocktailSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dropdown_glass = new System.Windows.Forms.ComboBox();
            this.dropdown_alcohol = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.popularDrink5 = new System.Windows.Forms.PictureBox();
            this.popularDrink4 = new System.Windows.Forms.PictureBox();
            this.popularDrink3 = new System.Windows.Forms.PictureBox();
            this.popularDrink2 = new System.Windows.Forms.PictureBox();
            this.popularDrink1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.drinkList = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.measure6 = new System.Windows.Forms.Label();
            this.measure3 = new System.Windows.Forms.Label();
            this.measure5 = new System.Windows.Forms.Label();
            this.measure2 = new System.Windows.Forms.Label();
            this.measure4 = new System.Windows.Forms.Label();
            this.measure1 = new System.Windows.Forms.Label();
            this.ingrediant6 = new System.Windows.Forms.Label();
            this.ingrediant3 = new System.Windows.Forms.Label();
            this.ingrediant5 = new System.Windows.Forms.Label();
            this.ingrediant2 = new System.Windows.Forms.Label();
            this.ingrediant4 = new System.Windows.Forms.Label();
            this.ingrediant1 = new System.Windows.Forms.Label();
            this.instructions = new System.Windows.Forms.Label();
            this.resultPicture = new System.Windows.Forms.PictureBox();
            this.drinkName = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popularDrink5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popularDrink4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popularDrink3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popularDrink2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popularDrink1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPicture)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchBar);
            this.groupBox1.Controls.Add(this.dropdown_glass);
            this.groupBox1.Controls.Add(this.dropdown_alcohol);
            this.groupBox1.Font = new System.Drawing.Font("KacstOffice", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.groupBox1.Location = new System.Drawing.Point(26, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dropdown_glass
            // 
            this.dropdown_glass.FormattingEnabled = true;
            this.dropdown_glass.Items.AddRange(new object[] {
            "Shot glass",
            "Pint glass",
            "martini glass"});
            this.dropdown_glass.Location = new System.Drawing.Point(19, 121);
            this.dropdown_glass.Name = "dropdown_glass";
            this.dropdown_glass.Size = new System.Drawing.Size(197, 37);
            this.dropdown_glass.TabIndex = 5;
            this.dropdown_glass.Text = "Glass Type";
            this.dropdown_glass.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dropdown_alcohol
            // 
            this.dropdown_alcohol.FormattingEnabled = true;
            this.dropdown_alcohol.Items.AddRange(new object[] {
            "Wiskey",
            "Vodka",
            "Rum",
            "Scotch",
            "Gin"});
            this.dropdown_alcohol.Location = new System.Drawing.Point(19, 78);
            this.dropdown_alcohol.Name = "dropdown_alcohol";
            this.dropdown_alcohol.Size = new System.Drawing.Size(197, 37);
            this.dropdown_alcohol.TabIndex = 4;
            this.dropdown_alcohol.Text = "Ingredients";
            this.dropdown_alcohol.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.popularDrink5);
            this.groupBox2.Controls.Add(this.popularDrink4);
            this.groupBox2.Controls.Add(this.popularDrink3);
            this.groupBox2.Controls.Add(this.popularDrink2);
            this.groupBox2.Controls.Add(this.popularDrink1);
            this.groupBox2.Font = new System.Drawing.Font("KacstOffice", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.groupBox2.Location = new System.Drawing.Point(307, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 177);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Popular Drinks";
            // 
            // popularDrink5
            // 
            this.popularDrink5.Image = global::CocktailSearch.Properties.Resources.strawberr_drink;
            this.popularDrink5.Location = new System.Drawing.Point(624, 36);
            this.popularDrink5.Name = "popularDrink5";
            this.popularDrink5.Size = new System.Drawing.Size(150, 143);
            this.popularDrink5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.popularDrink5.TabIndex = 4;
            this.popularDrink5.TabStop = false;
            this.popularDrink5.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // popularDrink4
            // 
            this.popularDrink4.Image = global::CocktailSearch.Properties.Resources.strawberr_drink;
            this.popularDrink4.Location = new System.Drawing.Point(468, 36);
            this.popularDrink4.Name = "popularDrink4";
            this.popularDrink4.Size = new System.Drawing.Size(150, 143);
            this.popularDrink4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.popularDrink4.TabIndex = 3;
            this.popularDrink4.TabStop = false;
            this.popularDrink4.Click += new System.EventHandler(this.popularDrink4_Click);
            // 
            // popularDrink3
            // 
            this.popularDrink3.Image = global::CocktailSearch.Properties.Resources.strawberr_drink;
            this.popularDrink3.Location = new System.Drawing.Point(312, 36);
            this.popularDrink3.Name = "popularDrink3";
            this.popularDrink3.Size = new System.Drawing.Size(150, 143);
            this.popularDrink3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.popularDrink3.TabIndex = 2;
            this.popularDrink3.TabStop = false;
            this.popularDrink3.Click += new System.EventHandler(this.popularDrink3_Click);
            // 
            // popularDrink2
            // 
            this.popularDrink2.Image = global::CocktailSearch.Properties.Resources.strawberr_drink;
            this.popularDrink2.Location = new System.Drawing.Point(156, 36);
            this.popularDrink2.Name = "popularDrink2";
            this.popularDrink2.Size = new System.Drawing.Size(150, 143);
            this.popularDrink2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.popularDrink2.TabIndex = 1;
            this.popularDrink2.TabStop = false;
            this.popularDrink2.Click += new System.EventHandler(this.popularDrink2_Click);
            // 
            // popularDrink1
            // 
            this.popularDrink1.Image = global::CocktailSearch.Properties.Resources.strawberr_drink;
            this.popularDrink1.Location = new System.Drawing.Point(0, 36);
            this.popularDrink1.Name = "popularDrink1";
            this.popularDrink1.Size = new System.Drawing.Size(150, 143);
            this.popularDrink1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.popularDrink1.TabIndex = 0;
            this.popularDrink1.TabStop = false;
            this.popularDrink1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CocktailSearch.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 191);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // drinkList
            // 
            this.drinkList.FormattingEnabled = true;
            this.drinkList.ItemHeight = 29;
            this.drinkList.Items.AddRange(new object[] {
            "Moscow Mule"});
            this.drinkList.Location = new System.Drawing.Point(19, 36);
            this.drinkList.Name = "drinkList";
            this.drinkList.Size = new System.Drawing.Size(197, 178);
            this.drinkList.TabIndex = 5;
            this.drinkList.SelectedIndexChanged += new System.EventHandler(this.drinkList_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.measure6);
            this.groupBox3.Controls.Add(this.measure3);
            this.groupBox3.Controls.Add(this.measure5);
            this.groupBox3.Controls.Add(this.measure2);
            this.groupBox3.Controls.Add(this.measure4);
            this.groupBox3.Controls.Add(this.measure1);
            this.groupBox3.Controls.Add(this.ingrediant6);
            this.groupBox3.Controls.Add(this.ingrediant3);
            this.groupBox3.Controls.Add(this.ingrediant5);
            this.groupBox3.Controls.Add(this.ingrediant2);
            this.groupBox3.Controls.Add(this.ingrediant4);
            this.groupBox3.Controls.Add(this.ingrediant1);
            this.groupBox3.Controls.Add(this.instructions);
            this.groupBox3.Controls.Add(this.resultPicture);
            this.groupBox3.Controls.Add(this.drinkName);
            this.groupBox3.Font = new System.Drawing.Font("KacstOffice", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.groupBox3.Location = new System.Drawing.Point(307, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(772, 518);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Drink Result";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("KacstOffice", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(418, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(200, 45);
            this.label15.TabIndex = 19;
            this.label15.Text = "Ingredients";
            // 
            // measure6
            // 
            this.measure6.Location = new System.Drawing.Point(552, 300);
            this.measure6.Name = "measure6";
            this.measure6.Size = new System.Drawing.Size(214, 29);
            this.measure6.TabIndex = 18;
            this.measure6.Text = "1 1/2 oz";
            // 
            // measure3
            // 
            this.measure3.Location = new System.Drawing.Point(552, 180);
            this.measure3.Name = "measure3";
            this.measure3.Size = new System.Drawing.Size(214, 29);
            this.measure3.TabIndex = 12;
            this.measure3.Text = "1 1/2 oz";
            // 
            // measure5
            // 
            this.measure5.Location = new System.Drawing.Point(552, 259);
            this.measure5.Name = "measure5";
            this.measure5.Size = new System.Drawing.Size(214, 29);
            this.measure5.TabIndex = 17;
            this.measure5.Text = "3 Wedges";
            // 
            // measure2
            // 
            this.measure2.Location = new System.Drawing.Point(552, 139);
            this.measure2.Name = "measure2";
            this.measure2.Size = new System.Drawing.Size(214, 29);
            this.measure2.TabIndex = 11;
            this.measure2.Text = "3 Wedges";
            // 
            // measure4
            // 
            this.measure4.Location = new System.Drawing.Point(552, 221);
            this.measure4.Name = "measure4";
            this.measure4.Size = new System.Drawing.Size(214, 29);
            this.measure4.TabIndex = 16;
            this.measure4.Text = "6 oz";
            // 
            // measure1
            // 
            this.measure1.Location = new System.Drawing.Point(552, 101);
            this.measure1.Name = "measure1";
            this.measure1.Size = new System.Drawing.Size(214, 29);
            this.measure1.TabIndex = 10;
            this.measure1.Text = "6 oz";
            this.measure1.Click += new System.EventHandler(this.measurment_Click);
            // 
            // ingrediant6
            // 
            this.ingrediant6.Location = new System.Drawing.Point(334, 300);
            this.ingrediant6.Name = "ingrediant6";
            this.ingrediant6.Size = new System.Drawing.Size(162, 29);
            this.ingrediant6.TabIndex = 15;
            this.ingrediant6.Text = "Wiskey";
            this.ingrediant6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ingrediant3
            // 
            this.ingrediant3.Location = new System.Drawing.Point(324, 180);
            this.ingrediant3.Name = "ingrediant3";
            this.ingrediant3.Size = new System.Drawing.Size(172, 29);
            this.ingrediant3.TabIndex = 9;
            this.ingrediant3.Text = "Wiskey";
            this.ingrediant3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ingrediant5
            // 
            this.ingrediant5.Location = new System.Drawing.Point(329, 259);
            this.ingrediant5.Name = "ingrediant5";
            this.ingrediant5.Size = new System.Drawing.Size(167, 29);
            this.ingrediant5.TabIndex = 14;
            this.ingrediant5.Text = "Lime";
            this.ingrediant5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ingrediant2
            // 
            this.ingrediant2.Location = new System.Drawing.Point(329, 139);
            this.ingrediant2.Name = "ingrediant2";
            this.ingrediant2.Size = new System.Drawing.Size(167, 29);
            this.ingrediant2.TabIndex = 8;
            this.ingrediant2.Text = "Lime";
            this.ingrediant2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ingrediant2.Click += new System.EventHandler(this.label4_Click);
            // 
            // ingrediant4
            // 
            this.ingrediant4.Location = new System.Drawing.Point(319, 221);
            this.ingrediant4.Name = "ingrediant4";
            this.ingrediant4.Size = new System.Drawing.Size(177, 29);
            this.ingrediant4.TabIndex = 13;
            this.ingrediant4.Text = "Ginger Beer";
            this.ingrediant4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ingrediant1
            // 
            this.ingrediant1.Location = new System.Drawing.Point(324, 101);
            this.ingrediant1.Name = "ingrediant1";
            this.ingrediant1.Size = new System.Drawing.Size(172, 29);
            this.ingrediant1.TabIndex = 7;
            this.ingrediant1.Text = "Ginger Beer";
            this.ingrediant1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // instructions
            // 
            this.instructions.AutoSize = true;
            this.instructions.Font = new System.Drawing.Font("KacstOffice", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.instructions.Location = new System.Drawing.Point(20, 398);
            this.instructions.MaximumSize = new System.Drawing.Size(700, 0);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(696, 75);
            this.instructions.TabIndex = 6;
            this.instructions.Text = "Rub rim of cocktail glass with lemon juice and dip rim in salt. Shake schnapps, t" +
    "equila, triple sec, lemon juice, and strawberries with ice, strain into the salt" +
    "-rimmed glass, and serve.\r\n";
            this.instructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.instructions.Click += new System.EventHandler(this.label2_Click);
            // 
            // resultPicture
            // 
            this.resultPicture.Image = global::CocktailSearch.Properties.Resources.strawberr_drink;
            this.resultPicture.Location = new System.Drawing.Point(25, 93);
            this.resultPicture.Name = "resultPicture";
            this.resultPicture.Size = new System.Drawing.Size(281, 284);
            this.resultPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resultPicture.TabIndex = 5;
            this.resultPicture.TabStop = false;
            this.resultPicture.Click += new System.EventHandler(this.resultPicture_Click);
            // 
            // drinkName
            // 
            this.drinkName.AutoSize = true;
            this.drinkName.Location = new System.Drawing.Point(20, 38);
            this.drinkName.Name = "drinkName";
            this.drinkName.Size = new System.Drawing.Size(60, 29);
            this.drinkName.TabIndex = 0;
            this.drinkName.Text = "Mule";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.drinkList);
            this.groupBox4.Font = new System.Drawing.Font("KacstOffice", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.groupBox4.Location = new System.Drawing.Point(26, 487);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 230);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select a Drink:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 751);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1098, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(118, 17);
            this.status.Text = "toolStripStatusLabel1";
            this.status.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Location = new System.Drawing.Point(0, 729);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1098, 22);
            this.statusStrip2.TabIndex = 10;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(19, 36);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(197, 37);
            this.searchBar.TabIndex = 6;
            this.searchBar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 773);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popularDrink5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popularDrink4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popularDrink3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popularDrink2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popularDrink1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPicture)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox dropdown_alcohol;
        private System.Windows.Forms.ComboBox dropdown_glass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox popularDrink1;
        private System.Windows.Forms.PictureBox popularDrink5;
        private System.Windows.Forms.PictureBox popularDrink4;
        private System.Windows.Forms.PictureBox popularDrink3;
        private System.Windows.Forms.PictureBox popularDrink2;
        private System.Windows.Forms.ListBox drinkList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.PictureBox resultPicture;
        private System.Windows.Forms.Label drinkName;
        private System.Windows.Forms.Label ingrediant3;
        private System.Windows.Forms.Label ingrediant2;
        private System.Windows.Forms.Label ingrediant1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label measure6;
        private System.Windows.Forms.Label measure3;
        private System.Windows.Forms.Label measure5;
        private System.Windows.Forms.Label measure2;
        private System.Windows.Forms.Label measure4;
        private System.Windows.Forms.Label measure1;
        private System.Windows.Forms.Label ingrediant6;
        private System.Windows.Forms.Label ingrediant5;
        private System.Windows.Forms.Label ingrediant4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.TextBox searchBar;
    }
}

