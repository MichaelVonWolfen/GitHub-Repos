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
            this.tb_RoomName = new System.Windows.Forms.TextBox();
            this.tb_RoomType = new System.Windows.Forms.TextBox();
            this.tB_HotelName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.b_UnocupiedRooms = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.availeble_Rooms_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // availeble_Rooms_gridView
            // 
            this.availeble_Rooms_gridView.AllowUserToAddRows = false;
            this.availeble_Rooms_gridView.AllowUserToDeleteRows = false;
            this.availeble_Rooms_gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.availeble_Rooms_gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.availeble_Rooms_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availeble_Rooms_gridView.Enabled = false;
            this.availeble_Rooms_gridView.Location = new System.Drawing.Point(12, 244);
            this.availeble_Rooms_gridView.Name = "availeble_Rooms_gridView";
            this.availeble_Rooms_gridView.ReadOnly = true;
            this.availeble_Rooms_gridView.Size = new System.Drawing.Size(791, 338);
            this.availeble_Rooms_gridView.TabIndex = 0;
            this.availeble_Rooms_gridView.SelectionChanged += new System.EventHandler(this.Availeble_Rooms_gridView_SelectionChanged);
            this.availeble_Rooms_gridView.MouseEnter += new System.EventHandler(this.Availeble_Rooms_gridView_MouseEnter);
            // 
            // b_Reset
            // 
            this.b_Reset.Location = new System.Drawing.Point(669, 14);
            this.b_Reset.Name = "b_Reset";
            this.b_Reset.Size = new System.Drawing.Size(134, 21);
            this.b_Reset.TabIndex = 1;
            this.b_Reset.Text = "Reset";
            this.b_Reset.UseVisualStyleBackColor = true;
            this.b_Reset.Click += new System.EventHandler(this.B_Reset_Click);
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Country.Enabled = false;
            this.comboBox_Country.FormattingEnabled = true;
            this.comboBox_Country.Location = new System.Drawing.Point(15, 38);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Country.TabIndex = 2;
            this.comboBox_Country.SelectedValueChanged += new System.EventHandler(this.ComboBox_Country_SelectedValueChanged);
            // 
            // b_Hotels
            // 
            this.b_Hotels.Location = new System.Drawing.Point(669, 54);
            this.b_Hotels.Name = "b_Hotels";
            this.b_Hotels.Size = new System.Drawing.Size(134, 21);
            this.b_Hotels.TabIndex = 3;
            this.b_Hotels.Text = "Hotels";
            this.b_Hotels.UseVisualStyleBackColor = true;
            this.b_Hotels.Click += new System.EventHandler(this.B_Hotels_Click);
            // 
            // b_Rooms
            // 
            this.b_Rooms.Location = new System.Drawing.Point(669, 94);
            this.b_Rooms.Name = "b_Rooms";
            this.b_Rooms.Size = new System.Drawing.Size(134, 21);
            this.b_Rooms.TabIndex = 4;
            this.b_Rooms.Text = "Ocupied Rooms";
            this.b_Rooms.UseVisualStyleBackColor = true;
            this.b_Rooms.Click += new System.EventHandler(this.B_Rooms_Click);
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
            this.comboBox_Hotels.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Hotels_SelectedIndexChanged);
            // 
            // button_Reservation
            // 
            this.button_Reservation.Enabled = false;
            this.button_Reservation.Location = new System.Drawing.Point(669, 174);
            this.button_Reservation.Name = "button_Reservation";
            this.button_Reservation.Size = new System.Drawing.Size(134, 21);
            this.button_Reservation.TabIndex = 10;
            this.button_Reservation.Text = "Reservation";
            this.button_Reservation.UseVisualStyleBackColor = true;
            this.button_Reservation.Click += new System.EventHandler(this.Button_Reservation_Click);
            // 
            // tb_RoomName
            // 
            this.tb_RoomName.Enabled = false;
            this.tb_RoomName.Location = new System.Drawing.Point(330, 38);
            this.tb_RoomName.Name = "tb_RoomName";
            this.tb_RoomName.Size = new System.Drawing.Size(155, 20);
            this.tb_RoomName.TabIndex = 11;
            // 
            // tb_RoomType
            // 
            this.tb_RoomType.Enabled = false;
            this.tb_RoomType.Location = new System.Drawing.Point(330, 104);
            this.tb_RoomType.Name = "tb_RoomType";
            this.tb_RoomType.Size = new System.Drawing.Size(155, 20);
            this.tb_RoomType.TabIndex = 12;
            // 
            // tB_HotelName
            // 
            this.tB_HotelName.Enabled = false;
            this.tB_HotelName.Location = new System.Drawing.Point(330, 170);
            this.tB_HotelName.Name = "tB_HotelName";
            this.tB_HotelName.Size = new System.Drawing.Size(155, 20);
            this.tB_HotelName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Room Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Family Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Hotel Name";
            // 
            // b_UnocupiedRooms
            // 
            this.b_UnocupiedRooms.Location = new System.Drawing.Point(669, 134);
            this.b_UnocupiedRooms.Name = "b_UnocupiedRooms";
            this.b_UnocupiedRooms.Size = new System.Drawing.Size(134, 21);
            this.b_UnocupiedRooms.TabIndex = 17;
            this.b_UnocupiedRooms.Text = "Unocupied Rooms";
            this.b_UnocupiedRooms.UseVisualStyleBackColor = true;
            this.b_UnocupiedRooms.Click += new System.EventHandler(this.B_UnocupiedRooms_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 594);
            this.Controls.Add(this.b_UnocupiedRooms);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tB_HotelName);
            this.Controls.Add(this.tb_RoomType);
            this.Controls.Add(this.tb_RoomName);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Managementul Hotelurilor";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox tb_RoomName;
        private System.Windows.Forms.TextBox tb_RoomType;
        private System.Windows.Forms.TextBox tB_HotelName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_UnocupiedRooms;
    }
}

