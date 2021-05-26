namespace WindowsFormsApp1.Forms
{
    partial class Create_Position
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
            this.cmbListMenueNames = new System.Windows.Forms.ComboBox();
            this.lb_menue_name = new System.Windows.Forms.Label();
            this.lb_category = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.lb_calories = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textCaloris = new System.Windows.Forms.TextBox();
            this.cmbListCategoris = new System.Windows.Forms.ComboBox();
            this.btnCreatePosition = new System.Windows.Forms.Button();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbListMenueNames
            // 
            this.cmbListMenueNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListMenueNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbListMenueNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbListMenueNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.cmbListMenueNames.FormattingEnabled = true;
            this.cmbListMenueNames.Location = new System.Drawing.Point(263, 31);
            this.cmbListMenueNames.Name = "cmbListMenueNames";
            this.cmbListMenueNames.Size = new System.Drawing.Size(180, 39);
            this.cmbListMenueNames.TabIndex = 0;
            // 
            // lb_menue_name
            // 
            this.lb_menue_name.AutoSize = true;
            this.lb_menue_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_menue_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(192)))));
            this.lb_menue_name.Location = new System.Drawing.Point(40, 41);
            this.lb_menue_name.Name = "lb_menue_name";
            this.lb_menue_name.Size = new System.Drawing.Size(217, 29);
            this.lb_menue_name.TabIndex = 1;
            this.lb_menue_name.Text = "Название меню:";
            // 
            // lb_category
            // 
            this.lb_category.AutoSize = true;
            this.lb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(192)))));
            this.lb_category.Location = new System.Drawing.Point(40, 120);
            this.lb_category.Name = "lb_category";
            this.lb_category.Size = new System.Drawing.Size(152, 29);
            this.lb_category.TabIndex = 2;
            this.lb_category.Text = "Категория:";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(192)))));
            this.lb_name.Location = new System.Drawing.Point(40, 196);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(141, 29);
            this.lb_name.TabIndex = 3;
            this.lb_name.Text = "Название:";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(192)))));
            this.lb_price.Location = new System.Drawing.Point(40, 260);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(83, 29);
            this.lb_price.TabIndex = 4;
            this.lb_price.Text = "Цена:";
            // 
            // lb_calories
            // 
            this.lb_calories.AutoSize = true;
            this.lb_calories.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_calories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(192)))));
            this.lb_calories.Location = new System.Drawing.Point(40, 330);
            this.lb_calories.Name = "lb_calories";
            this.lb_calories.Size = new System.Drawing.Size(129, 29);
            this.lb_calories.TabIndex = 5;
            this.lb_calories.Text = "Калории:";
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.textName.Location = new System.Drawing.Point(198, 193);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(121, 31);
            this.textName.TabIndex = 6;
            // 
            // textPrice
            // 
            this.textPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.textPrice.Location = new System.Drawing.Point(198, 257);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(121, 31);
            this.textPrice.TabIndex = 7;
            this.textPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrice_KeyPress);
            // 
            // textCaloris
            // 
            this.textCaloris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textCaloris.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCaloris.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCaloris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.textCaloris.Location = new System.Drawing.Point(198, 327);
            this.textCaloris.Name = "textCaloris";
            this.textCaloris.Size = new System.Drawing.Size(121, 31);
            this.textCaloris.TabIndex = 8;
            this.textCaloris.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCaloris_KeyPress);
            // 
            // cmbListCategoris
            // 
            this.cmbListCategoris.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListCategoris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbListCategoris.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbListCategoris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.cmbListCategoris.FormattingEnabled = true;
            this.cmbListCategoris.Items.AddRange(new object[] {
            "Горячее",
            "Гарнир",
            "Супы",
            "Салаты",
            "Напитки",
            "Десерты"});
            this.cmbListCategoris.Location = new System.Drawing.Point(263, 110);
            this.cmbListCategoris.Name = "cmbListCategoris";
            this.cmbListCategoris.Size = new System.Drawing.Size(180, 39);
            this.cmbListCategoris.TabIndex = 9;
            // 
            // btnCreatePosition
            // 
            this.btnCreatePosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.btnCreatePosition.FlatAppearance.BorderSize = 0;
            this.btnCreatePosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreatePosition.ForeColor = System.Drawing.Color.White;
            this.btnCreatePosition.Location = new System.Drawing.Point(529, 350);
            this.btnCreatePosition.Name = "btnCreatePosition";
            this.btnCreatePosition.Size = new System.Drawing.Size(234, 91);
            this.btnCreatePosition.TabIndex = 10;
            this.btnCreatePosition.Text = "Создать позицию";
            this.btnCreatePosition.UseVisualStyleBackColor = false;
            this.btnCreatePosition.Click += new System.EventHandler(this.btnCreatePosition_Click);
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.FlatAppearance.BorderSize = 0;
            this.btnAddPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.btnAddPicture.Location = new System.Drawing.Point(529, 239);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(234, 71);
            this.btnAddPicture.TabIndex = 11;
            this.btnAddPicture.Text = "Добавить изображение";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 235;
            this.iconPictureBox1.Location = new System.Drawing.Point(528, -2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(235, 235);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 12;
            this.iconPictureBox1.TabStop = false;
            // 
            // textDescription
            // 
            this.textDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.textDescription.Location = new System.Drawing.Point(198, 390);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(312, 31);
            this.textDescription.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(40, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Описание:";
            // 
            // Create_Position
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 453);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.btnCreatePosition);
            this.Controls.Add(this.cmbListCategoris);
            this.Controls.Add(this.textCaloris);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.lb_calories);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_category);
            this.Controls.Add(this.lb_menue_name);
            this.Controls.Add(this.cmbListMenueNames);
            this.Name = "Create_Position";
            this.Text = "Create_Position";
            this.Load += new System.EventHandler(this.Create_Position_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbListMenueNames;
        private System.Windows.Forms.Label lb_menue_name;
        private System.Windows.Forms.Label lb_category;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_calories;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textCaloris;
        private System.Windows.Forms.ComboBox cmbListCategoris;
        private System.Windows.Forms.Button btnCreatePosition;
        private System.Windows.Forms.Button btnAddPicture;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label1;
    }
}