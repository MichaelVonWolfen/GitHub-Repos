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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
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
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.availeble_Rooms_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager_change_to_dark_or_light_mode)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_Reset
            // 
            this.b_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Reset.Location = new System.Drawing.Point(926, 104);
            this.b_Reset.Name = "b_Reset";
            this.b_Reset.Size = new System.Drawing.Size(150, 23);
            this.b_Reset.TabIndex = 18;
            this.b_Reset.Text = "Reset";
            this.b_Reset.UseSelectable = true;
            this.b_Reset.Click += new System.EventHandler(this.B_Reset_Click);
            // 
            // b_Hotels
            // 
            this.b_Hotels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Hotels.Location = new System.Drawing.Point(926, 142);
            this.b_Hotels.Name = "b_Hotels";
            this.b_Hotels.Size = new System.Drawing.Size(150, 23);
            this.b_Hotels.TabIndex = 19;
            this.b_Hotels.Text = "Hotels";
            this.b_Hotels.UseSelectable = true;
            this.b_Hotels.Click += new System.EventHandler(this.B_Hotels_Click);
            // 
            // b_RoomsOcupied
            // 
            this.b_RoomsOcupied.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_RoomsOcupied.Location = new System.Drawing.Point(926, 182);
            this.b_RoomsOcupied.Name = "b_RoomsOcupied";
            this.b_RoomsOcupied.Size = new System.Drawing.Size(150, 23);
            this.b_RoomsOcupied.TabIndex = 20;
            this.b_RoomsOcupied.Text = "Ocupied Rooms";
            this.b_RoomsOcupied.UseSelectable = true;
            this.b_RoomsOcupied.Click += new System.EventHandler(this.B_Rooms_Click);
            // 
            // b_UnocupiedRooms
            // 
            this.b_UnocupiedRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_UnocupiedRooms.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_UnocupiedRooms.ForeColor = System.Drawing.Color.Maroon;
            this.b_UnocupiedRooms.Location = new System.Drawing.Point(926, 222);
            this.b_UnocupiedRooms.Name = "b_UnocupiedRooms";
            this.b_UnocupiedRooms.Size = new System.Drawing.Size(150, 23);
            this.b_UnocupiedRooms.TabIndex = 21;
            this.b_UnocupiedRooms.Text = "Unocupied Rooms";
            this.b_UnocupiedRooms.UseSelectable = true;
            this.b_UnocupiedRooms.Click += new System.EventHandler(this.B_UnocupiedRooms_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(689, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Room Name";
            // 
            // button_Reservation
            // 
            this.button_Reservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Reservation.AutoSize = true;
            this.button_Reservation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Reservation.Depth = 0;
            this.button_Reservation.Enabled = false;
            this.button_Reservation.Location = new System.Drawing.Point(926, 271);
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(154)))), ((int)(((byte)(201)))));
            this.availeble_Rooms_gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.availeble_Rooms_gridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.availeble_Rooms_gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.availeble_Rooms_gridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.availeble_Rooms_gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.availeble_Rooms_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.availeble_Rooms_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.availeble_Rooms_gridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.availeble_Rooms_gridView.Enabled = false;
            this.availeble_Rooms_gridView.EnableHeadersVisualStyles = false;
            this.availeble_Rooms_gridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.availeble_Rooms_gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.availeble_Rooms_gridView.Location = new System.Drawing.Point(281, 406);
            this.availeble_Rooms_gridView.Name = "availeble_Rooms_gridView";
            this.availeble_Rooms_gridView.ReadOnly = true;
            this.availeble_Rooms_gridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.availeble_Rooms_gridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.availeble_Rooms_gridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.availeble_Rooms_gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.availeble_Rooms_gridView.Size = new System.Drawing.Size(788, 338);
            this.availeble_Rooms_gridView.TabIndex = 26;
            this.availeble_Rooms_gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Availeble_Rooms_gridView_CellContentClick);
            this.availeble_Rooms_gridView.SelectionChanged += new System.EventHandler(this.Availeble_Rooms_gridView_SelectionChanged);
            this.availeble_Rooms_gridView.MouseEnter += new System.EventHandler(this.Availeble_Rooms_gridView_MouseEnter);
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.Enabled = false;
            this.comboBox_Country.FormattingEnabled = true;
            this.comboBox_Country.ItemHeight = 23;
            this.comboBox_Country.Location = new System.Drawing.Point(466, 89);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.Size = new System.Drawing.Size(198, 29);
            this.comboBox_Country.TabIndex = 27;
            this.comboBox_Country.UseSelectable = true;
            this.comboBox_Country.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Country_SelectedValueChanged);
            // 
            // comboBox_city
            // 
            this.comboBox_city.Enabled = false;
            this.comboBox_city.FormattingEnabled = true;
            this.comboBox_city.ItemHeight = 23;
            this.comboBox_city.Location = new System.Drawing.Point(466, 161);
            this.comboBox_city.Name = "comboBox_city";
            this.comboBox_city.Size = new System.Drawing.Size(198, 29);
            this.comboBox_city.TabIndex = 28;
            this.comboBox_city.UseSelectable = true;
            this.comboBox_city.SelectedValueChanged += new System.EventHandler(this.ComboBox_city_SelectedValueChanged);
            // 
            // comboBox_Hotels
            // 
            this.comboBox_Hotels.Enabled = false;
            this.comboBox_Hotels.FormattingEnabled = true;
            this.comboBox_Hotels.ItemHeight = 23;
            this.comboBox_Hotels.Location = new System.Drawing.Point(466, 227);
            this.comboBox_Hotels.Name = "comboBox_Hotels";
            this.comboBox_Hotels.Size = new System.Drawing.Size(198, 29);
            this.comboBox_Hotels.TabIndex = 29;
            this.comboBox_Hotels.UseSelectable = true;
            this.comboBox_Hotels.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Hotels_SelectedIndexChanged);
            // 
            // tb_RoomName
            // 
            this.tb_RoomName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_RoomName.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.tb_RoomName.CustomButton.Image = null;
            this.tb_RoomName.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.tb_RoomName.CustomButton.Name = "";
            this.tb_RoomName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_RoomName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_RoomName.CustomButton.TabIndex = 1;
            this.tb_RoomName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_RoomName.CustomButton.UseSelectable = true;
            this.tb_RoomName.CustomButton.Visible = false;
            this.tb_RoomName.Enabled = false;
            this.tb_RoomName.Lines = new string[0];
            this.tb_RoomName.Location = new System.Drawing.Point(689, 99);
            this.tb_RoomName.MaxLength = 32767;
            this.tb_RoomName.Name = "tb_RoomName";
            this.tb_RoomName.PasswordChar = '\0';
            this.tb_RoomName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_RoomName.SelectedText = "";
            this.tb_RoomName.SelectionLength = 0;
            this.tb_RoomName.SelectionStart = 0;
            this.tb_RoomName.ShortcutsEnabled = true;
            this.tb_RoomName.Size = new System.Drawing.Size(221, 23);
            this.tb_RoomName.TabIndex = 30;
            this.tb_RoomName.UseSelectable = true;
            this.tb_RoomName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_RoomName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_RoomType
            // 
            this.tb_RoomType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.tb_RoomType.CustomButton.Image = null;
            this.tb_RoomType.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.tb_RoomType.CustomButton.Name = "";
            this.tb_RoomType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_RoomType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_RoomType.CustomButton.TabIndex = 1;
            this.tb_RoomType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_RoomType.CustomButton.UseSelectable = true;
            this.tb_RoomType.CustomButton.Visible = false;
            this.tb_RoomType.Enabled = false;
            this.tb_RoomType.Lines = new string[0];
            this.tb_RoomType.Location = new System.Drawing.Point(689, 165);
            this.tb_RoomType.MaxLength = 32767;
            this.tb_RoomType.Name = "tb_RoomType";
            this.tb_RoomType.PasswordChar = '\0';
            this.tb_RoomType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_RoomType.SelectedText = "";
            this.tb_RoomType.SelectionLength = 0;
            this.tb_RoomType.SelectionStart = 0;
            this.tb_RoomType.ShortcutsEnabled = true;
            this.tb_RoomType.Size = new System.Drawing.Size(221, 23);
            this.tb_RoomType.TabIndex = 31;
            this.tb_RoomType.UseSelectable = true;
            this.tb_RoomType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_RoomType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tB_HotelName
            // 
            this.tB_HotelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.tB_HotelName.CustomButton.Image = null;
            this.tB_HotelName.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.tB_HotelName.CustomButton.Name = "";
            this.tB_HotelName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tB_HotelName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tB_HotelName.CustomButton.TabIndex = 1;
            this.tB_HotelName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tB_HotelName.CustomButton.UseSelectable = true;
            this.tB_HotelName.CustomButton.Visible = false;
            this.tB_HotelName.Enabled = false;
            this.tB_HotelName.Lines = new string[0];
            this.tB_HotelName.Location = new System.Drawing.Point(689, 227);
            this.tB_HotelName.MaxLength = 32767;
            this.tB_HotelName.Name = "tB_HotelName";
            this.tB_HotelName.PasswordChar = '\0';
            this.tB_HotelName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tB_HotelName.SelectedText = "";
            this.tB_HotelName.SelectionLength = 0;
            this.tB_HotelName.SelectionStart = 0;
            this.tB_HotelName.ShortcutsEnabled = true;
            this.tB_HotelName.Size = new System.Drawing.Size(221, 23);
            this.tB_HotelName.TabIndex = 32;
            this.tB_HotelName.UseSelectable = true;
            this.tB_HotelName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tB_HotelName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(689, 204);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 33;
            this.metroLabel2.Text = "Hotel Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(689, 138);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.TabIndex = 34;
            this.metroLabel3.Text = "Family Type";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(466, 60);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(55, 19);
            this.metroLabel4.TabIndex = 35;
            this.metroLabel4.Text = "Country";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(466, 139);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(31, 19);
            this.metroLabel5.TabIndex = 36;
            this.metroLabel5.Text = "City";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(466, 193);
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
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialFlatButton1.Location = new System.Drawing.Point(926, 49);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(133, 36);
            this.materialFlatButton1.TabIndex = 38;
            this.materialFlatButton1.Text = "Dark/Light Mode";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuLabel1.Location = new System.Drawing.Point(206, 11);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(226, 32);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Hotel Management";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.bunifuButton1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 753);
            this.panel1.TabIndex = 39;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.ButtonText = "Bunifu Button";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.Location = new System.Drawing.Point(-1, 82);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties1;
            this.bunifuButton1.Size = new System.Drawing.Size(201, 45);
            this.bunifuButton1.TabIndex = 0;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.panel2.Location = new System.Drawing.Point(-15, -15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 20);
            this.panel2.TabIndex = 40;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(190)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "bunifuFlatButton1";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::Managementul_Hotelurilor.Properties.Resources.icons8_moon_symbol_48;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(-1, 133);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Empty;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(220)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(201, 48);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "bunifuFlatButton1";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::Managementul_Hotelurilor.Properties.Resources.icons8_moon_symbol_48;
            this.ClientSize = new System.Drawing.Size(1088, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunifuLabel1);
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
            this.Controls.Add(this.button_Reservation);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.b_UnocupiedRooms);
            this.Controls.Add(this.b_RoomsOcupied);
            this.Controls.Add(this.b_Hotels);
            this.Controls.Add(this.b_Reset);
            this.Controls.Add(this.availeble_Rooms_gridView);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = ".";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.availeble_Rooms_gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager_change_to_dark_or_light_mode)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}

