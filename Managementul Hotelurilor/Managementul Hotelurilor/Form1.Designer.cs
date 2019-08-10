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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.b_Reset = new MetroFramework.Controls.MetroButton();
            this.b_Hotels = new MetroFramework.Controls.MetroButton();
            this.b_RoomsOcupied = new MetroFramework.Controls.MetroButton();
            this.b_UnocupiedRooms = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.button_Reservation = new MaterialSkin.Controls.MaterialFlatButton();
            this.availeble_Rooms_gridView = new MetroFramework.Controls.MetroGrid();
            this.comboBox_Country = new MetroFramework.Controls.MetroComboBox();
            this.comboBox_city = new MetroFramework.Controls.MetroComboBox();
            this.comboBox_Hotels = new MetroFramework.Controls.MetroComboBox();
            this.tb_RoomName = new MetroFramework.Controls.MetroTextBox();
            this.tb_RoomType = new MetroFramework.Controls.MetroTextBox();
            this.tB_HotelName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager_change_to_dark_or_light_mode = new MetroFramework.Components.MetroStyleManager(this.components);
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.availeble_Rooms_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager_change_to_dark_or_light_mode)).BeginInit();
            this.SuspendLayout();
            // 
            // b_Reset
            // 
            this.b_Reset.Location = new System.Drawing.Point(653, 104);
            this.b_Reset.Name = "b_Reset";
            this.b_Reset.Size = new System.Drawing.Size(150, 23);
            this.b_Reset.TabIndex = 18;
            this.b_Reset.Text = "Reset";
            this.b_Reset.UseSelectable = true;
            this.b_Reset.Click += new System.EventHandler(this.B_Reset_Click);
            // 
            // b_Hotels
            // 
            this.b_Hotels.Location = new System.Drawing.Point(653, 142);
            this.b_Hotels.Name = "b_Hotels";
            this.b_Hotels.Size = new System.Drawing.Size(150, 23);
            this.b_Hotels.TabIndex = 19;
            this.b_Hotels.Text = "Hotels";
            this.b_Hotels.UseSelectable = true;
            this.b_Hotels.Click += new System.EventHandler(this.B_Hotels_Click);
            // 
            // b_RoomsOcupied
            // 
            this.b_RoomsOcupied.Location = new System.Drawing.Point(653, 182);
            this.b_RoomsOcupied.Name = "b_RoomsOcupied";
            this.b_RoomsOcupied.Size = new System.Drawing.Size(150, 23);
            this.b_RoomsOcupied.TabIndex = 20;
            this.b_RoomsOcupied.Text = "Ocupied Rooms";
            this.b_RoomsOcupied.UseSelectable = true;
            this.b_RoomsOcupied.Click += new System.EventHandler(this.B_Rooms_Click);
            // 
            // b_UnocupiedRooms
            // 
            this.b_UnocupiedRooms.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_UnocupiedRooms.ForeColor = System.Drawing.Color.Maroon;
            this.b_UnocupiedRooms.Location = new System.Drawing.Point(653, 222);
            this.b_UnocupiedRooms.Name = "b_UnocupiedRooms";
            this.b_UnocupiedRooms.Size = new System.Drawing.Size(150, 23);
            this.b_UnocupiedRooms.TabIndex = 21;
            this.b_UnocupiedRooms.Text = "Unocupied Rooms";
            this.b_UnocupiedRooms.UseSelectable = true;
            this.b_UnocupiedRooms.Click += new System.EventHandler(this.B_UnocupiedRooms_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(307, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Room Name";
            // 
            // button_Reservation
            // 
            this.button_Reservation.AutoSize = true;
            this.button_Reservation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Reservation.Depth = 0;
            this.button_Reservation.Enabled = false;
            this.button_Reservation.Location = new System.Drawing.Point(653, 271);
            this.button_Reservation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_Reservation.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_Reservation.Name = "button_Reservation";
            this.button_Reservation.Primary = false;
            this.button_Reservation.Size = new System.Drawing.Size(143, 36);
            this.button_Reservation.TabIndex = 25;
            this.button_Reservation.Text = "Make Reservation";
            this.button_Reservation.UseVisualStyleBackColor = true;
            this.button_Reservation.Click += new System.EventHandler(this.Button_Reservation_Click);
            // 
            // availeble_Rooms_gridView
            // 
            this.availeble_Rooms_gridView.AllowUserToAddRows = false;
            this.availeble_Rooms_gridView.AllowUserToDeleteRows = false;
            this.availeble_Rooms_gridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(154)))), ((int)(((byte)(201)))));
            this.availeble_Rooms_gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.availeble_Rooms_gridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.availeble_Rooms_gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.availeble_Rooms_gridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.availeble_Rooms_gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.availeble_Rooms_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.availeble_Rooms_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.availeble_Rooms_gridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.availeble_Rooms_gridView.Enabled = false;
            this.availeble_Rooms_gridView.EnableHeadersVisualStyles = false;
            this.availeble_Rooms_gridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.availeble_Rooms_gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.availeble_Rooms_gridView.Location = new System.Drawing.Point(15, 399);
            this.availeble_Rooms_gridView.Name = "availeble_Rooms_gridView";
            this.availeble_Rooms_gridView.ReadOnly = true;
            this.availeble_Rooms_gridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.availeble_Rooms_gridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.availeble_Rooms_gridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.availeble_Rooms_gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.availeble_Rooms_gridView.Size = new System.Drawing.Size(788, 338);
            this.availeble_Rooms_gridView.TabIndex = 26;
            this.availeble_Rooms_gridView.SelectionChanged += new System.EventHandler(this.Availeble_Rooms_gridView_SelectionChanged);
            this.availeble_Rooms_gridView.MouseEnter += new System.EventHandler(this.Availeble_Rooms_gridView_MouseEnter);
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.Enabled = false;
            this.comboBox_Country.FormattingEnabled = true;
            this.comboBox_Country.ItemHeight = 23;
            this.comboBox_Country.Location = new System.Drawing.Point(23, 104);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.Size = new System.Drawing.Size(121, 29);
            this.comboBox_Country.TabIndex = 27;
            this.comboBox_Country.UseSelectable = true;
            this.comboBox_Country.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Country_SelectedValueChanged);
            // 
            // comboBox_city
            // 
            this.comboBox_city.Enabled = false;
            this.comboBox_city.FormattingEnabled = true;
            this.comboBox_city.ItemHeight = 23;
            this.comboBox_city.Location = new System.Drawing.Point(23, 176);
            this.comboBox_city.Name = "comboBox_city";
            this.comboBox_city.Size = new System.Drawing.Size(121, 29);
            this.comboBox_city.TabIndex = 28;
            this.comboBox_city.UseSelectable = true;
            this.comboBox_city.SelectedValueChanged += new System.EventHandler(this.ComboBox_city_SelectedValueChanged);
            // 
            // comboBox_Hotels
            // 
            this.comboBox_Hotels.Enabled = false;
            this.comboBox_Hotels.FormattingEnabled = true;
            this.comboBox_Hotels.ItemHeight = 23;
            this.comboBox_Hotels.Location = new System.Drawing.Point(23, 242);
            this.comboBox_Hotels.Name = "comboBox_Hotels";
            this.comboBox_Hotels.Size = new System.Drawing.Size(121, 29);
            this.comboBox_Hotels.TabIndex = 29;
            this.comboBox_Hotels.UseSelectable = true;
            this.comboBox_Hotels.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Hotels_SelectedIndexChanged);
            // 
            // tb_RoomName
            // 
            this.tb_RoomName.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.tb_RoomName.CustomButton.Image = null;
            this.tb_RoomName.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.tb_RoomName.CustomButton.Name = "";
            this.tb_RoomName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_RoomName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_RoomName.CustomButton.TabIndex = 1;
            this.tb_RoomName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_RoomName.CustomButton.UseSelectable = true;
            this.tb_RoomName.CustomButton.Visible = false;
            this.tb_RoomName.Enabled = false;
            this.tb_RoomName.Lines = new string[0];
            this.tb_RoomName.Location = new System.Drawing.Point(307, 114);
            this.tb_RoomName.MaxLength = 32767;
            this.tb_RoomName.Name = "tb_RoomName";
            this.tb_RoomName.PasswordChar = '\0';
            this.tb_RoomName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_RoomName.SelectedText = "";
            this.tb_RoomName.SelectionLength = 0;
            this.tb_RoomName.SelectionStart = 0;
            this.tb_RoomName.ShortcutsEnabled = true;
            this.tb_RoomName.Size = new System.Drawing.Size(155, 23);
            this.tb_RoomName.TabIndex = 30;
            this.tb_RoomName.UseSelectable = true;
            this.tb_RoomName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_RoomName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_RoomType
            // 
            // 
            // 
            // 
            this.tb_RoomType.CustomButton.Image = null;
            this.tb_RoomType.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.tb_RoomType.CustomButton.Name = "";
            this.tb_RoomType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_RoomType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_RoomType.CustomButton.TabIndex = 1;
            this.tb_RoomType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_RoomType.CustomButton.UseSelectable = true;
            this.tb_RoomType.CustomButton.Visible = false;
            this.tb_RoomType.Enabled = false;
            this.tb_RoomType.Lines = new string[0];
            this.tb_RoomType.Location = new System.Drawing.Point(307, 180);
            this.tb_RoomType.MaxLength = 32767;
            this.tb_RoomType.Name = "tb_RoomType";
            this.tb_RoomType.PasswordChar = '\0';
            this.tb_RoomType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_RoomType.SelectedText = "";
            this.tb_RoomType.SelectionLength = 0;
            this.tb_RoomType.SelectionStart = 0;
            this.tb_RoomType.ShortcutsEnabled = true;
            this.tb_RoomType.Size = new System.Drawing.Size(155, 23);
            this.tb_RoomType.TabIndex = 31;
            this.tb_RoomType.UseSelectable = true;
            this.tb_RoomType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_RoomType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tB_HotelName
            // 
            // 
            // 
            // 
            this.tB_HotelName.CustomButton.Image = null;
            this.tB_HotelName.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.tB_HotelName.CustomButton.Name = "";
            this.tB_HotelName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tB_HotelName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tB_HotelName.CustomButton.TabIndex = 1;
            this.tB_HotelName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tB_HotelName.CustomButton.UseSelectable = true;
            this.tB_HotelName.CustomButton.Visible = false;
            this.tB_HotelName.Enabled = false;
            this.tB_HotelName.Lines = new string[0];
            this.tB_HotelName.Location = new System.Drawing.Point(307, 242);
            this.tB_HotelName.MaxLength = 32767;
            this.tB_HotelName.Name = "tB_HotelName";
            this.tB_HotelName.PasswordChar = '\0';
            this.tB_HotelName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tB_HotelName.SelectedText = "";
            this.tB_HotelName.SelectionLength = 0;
            this.tB_HotelName.SelectionStart = 0;
            this.tB_HotelName.ShortcutsEnabled = true;
            this.tB_HotelName.Size = new System.Drawing.Size(155, 23);
            this.tB_HotelName.TabIndex = 32;
            this.tB_HotelName.UseSelectable = true;
            this.tB_HotelName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tB_HotelName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(307, 219);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 33;
            this.metroLabel2.Text = "Hotel Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(307, 153);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.TabIndex = 34;
            this.metroLabel3.Text = "Family Type";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 75);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(55, 19);
            this.metroLabel4.TabIndex = 35;
            this.metroLabel4.Text = "Country";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 154);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(31, 19);
            this.metroLabel5.TabIndex = 36;
            this.metroLabel5.Text = "City";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 208);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(40, 19);
            this.metroLabel6.TabIndex = 37;
            this.metroLabel6.Text = "Hotel";
            // 
            // metroStyleManager_change_to_dark_or_light_mode
            // 
            this.metroStyleManager_change_to_dark_or_light_mode.Owner = null;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialFlatButton1.Location = new System.Drawing.Point(653, 49);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(133, 36);
            this.materialFlatButton1.TabIndex = 38;
            this.materialFlatButton1.Text = "Dark/Light Mode";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(540, 283);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "View Rooms";
            this.label1.MouseEnter += new System.EventHandler(this.Label1_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tB_HotelName);
            this.Controls.Add(this.tb_RoomType);
            this.Controls.Add(this.tb_RoomName);
            this.Controls.Add(this.comboBox_Hotels);
            this.Controls.Add(this.comboBox_city);
            this.Controls.Add(this.comboBox_Country);
            this.Controls.Add(this.availeble_Rooms_gridView);
            this.Controls.Add(this.button_Reservation);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.b_UnocupiedRooms);
            this.Controls.Add(this.b_RoomsOcupied);
            this.Controls.Add(this.b_Hotels);
            this.Controls.Add(this.b_Reset);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Hotel Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.availeble_Rooms_gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager_change_to_dark_or_light_mode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton b_Reset;
        private MetroFramework.Controls.MetroButton b_Hotels;
        private MetroFramework.Controls.MetroButton b_RoomsOcupied;
        private MetroFramework.Controls.MetroButton b_UnocupiedRooms;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MaterialSkin.Controls.MaterialFlatButton button_Reservation;
        private MetroFramework.Controls.MetroGrid availeble_Rooms_gridView;
        private MetroFramework.Controls.MetroComboBox comboBox_Country;
        private MetroFramework.Controls.MetroComboBox comboBox_city;
        private MetroFramework.Controls.MetroComboBox comboBox_Hotels;
        private MetroFramework.Controls.MetroTextBox tb_RoomName;
        private MetroFramework.Controls.MetroTextBox tb_RoomType;
        private MetroFramework.Controls.MetroTextBox tB_HotelName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Components.MetroStyleManager metroStyleManager_change_to_dark_or_light_mode;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Label label1;
    }
}

