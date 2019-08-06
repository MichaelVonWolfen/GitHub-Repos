namespace Managementul_Hotelurilor
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
            this.availeble_Rooms_gridView = new System.Windows.Forms.DataGridView();
            this.b_Reset = new System.Windows.Forms.Button();
            this.comboBox_Country = new System.Windows.Forms.ComboBox();
            this.b_Hotels = new System.Windows.Forms.Button();
            this.b_Rooms = new System.Windows.Forms.Button();
            this.comboBox_city = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Hotels = new System.Windows.Forms.ComboBox();
            this.button_Reservation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.availeble_Rooms_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // availeble_Rooms_gridView
            // 
            this.availeble_Rooms_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availeble_Rooms_gridView.Enabled = false;
            this.availeble_Rooms_gridView.Location = new System.Drawing.Point(12, 244);
            this.availeble_Rooms_gridView.Name = "availeble_Rooms_gridView";
            this.availeble_Rooms_gridView.Size = new System.Drawing.Size(776, 194);
            this.availeble_Rooms_gridView.TabIndex = 0;
            // 
            // b_Reset
            // 
            this.b_Reset.Location = new System.Drawing.Point(645, 38);
            this.b_Reset.Name = "b_Reset";
            this.b_Reset.Size = new System.Drawing.Size(134, 21);
            this.b_Reset.TabIndex = 1;
            this.b_Reset.Text = "Reset";
            this.b_Reset.UseVisualStyleBackColor = true;
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Country.FormattingEnabled = true;
            this.comboBox_Country.Location = new System.Drawing.Point(15, 38);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Country.TabIndex = 2;
            this.comboBox_Country.SelectedValueChanged += new System.EventHandler(this.ComboBox_Country_SelectedValueChanged);
            // 
            // b_Hotels
            // 
            this.b_Hotels.Location = new System.Drawing.Point(645, 92);
            this.b_Hotels.Name = "b_Hotels";
            this.b_Hotels.Size = new System.Drawing.Size(134, 21);
            this.b_Hotels.TabIndex = 3;
            this.b_Hotels.Text = "Hotels";
            this.b_Hotels.UseVisualStyleBackColor = true;
            // 
            // b_Rooms
            // 
            this.b_Rooms.Location = new System.Drawing.Point(645, 146);
            this.b_Rooms.Name = "b_Rooms";
            this.b_Rooms.Size = new System.Drawing.Size(134, 21);
            this.b_Rooms.TabIndex = 4;
            this.b_Rooms.Text = "Rooms";
            this.b_Rooms.UseVisualStyleBackColor = true;
            // 
            // comboBox_city
            // 
            this.comboBox_city.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_city.Enabled = false;
            this.comboBox_city.FormattingEnabled = true;
            this.comboBox_city.Location = new System.Drawing.Point(15, 104);
            this.comboBox_city.Name = "comboBox_city";
            this.comboBox_city.Size = new System.Drawing.Size(121, 21);
            this.comboBox_city.TabIndex = 5;
            this.comboBox_city.SelectedValueChanged += new System.EventHandler(this.ComboBox_city_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hotel";
            // 
            // comboBox_Hotels
            // 
            this.comboBox_Hotels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Hotels.Enabled = false;
            this.comboBox_Hotels.FormattingEnabled = true;
            this.comboBox_Hotels.Location = new System.Drawing.Point(15, 170);
            this.comboBox_Hotels.Name = "comboBox_Hotels";
            this.comboBox_Hotels.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Hotels.TabIndex = 9;
            // 
            // button_Reservation
            // 
            this.button_Reservation.Location = new System.Drawing.Point(645, 200);
            this.button_Reservation.Name = "button_Reservation";
            this.button_Reservation.Size = new System.Drawing.Size(134, 21);
            this.button_Reservation.TabIndex = 10;
            this.button_Reservation.Text = "Reservation";
            this.button_Reservation.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Reservation);
            this.Controls.Add(this.comboBox_Hotels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_city);
            this.Controls.Add(this.b_Rooms);
            this.Controls.Add(this.b_Hotels);
            this.Controls.Add(this.comboBox_Country);
            this.Controls.Add(this.b_Reset);
            this.Controls.Add(this.availeble_Rooms_gridView);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Managementul Hotelurilor";
            ((System.ComponentModel.ISupportInitialize)(this.availeble_Rooms_gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView availeble_Rooms_gridView;
        private System.Windows.Forms.Button b_Reset;
        private System.Windows.Forms.ComboBox comboBox_Country;
        private System.Windows.Forms.Button b_Hotels;
        private System.Windows.Forms.Button b_Rooms;
        private System.Windows.Forms.ComboBox comboBox_city;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Hotels;
        private System.Windows.Forms.Button button_Reservation;
    }
}

