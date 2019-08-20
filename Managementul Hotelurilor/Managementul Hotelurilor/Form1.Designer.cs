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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation2 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroStyleManager_change_to_dark_or_light_mode = new MetroFramework.Components.MetroStyleManager(this.components);
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel_for_current_selected = new System.Windows.Forms.Panel();
            this.button_Reservation = new Bunifu.Framework.UI.BunifuFlatButton();
            this.b_RoomsOcupied = new Bunifu.Framework.UI.BunifuFlatButton();
            this.b_UnocupiedRooms = new Bunifu.Framework.UI.BunifuFlatButton();
            this.b_Hotels = new Bunifu.Framework.UI.BunifuFlatButton();
            this.b_Reset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.b_LightDark_theme = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MouseDetect = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.comboBox_Country = new Bunifu.UI.WinForms.BunifuDropdown();
            this.comboBox_city = new Bunifu.UI.WinForms.BunifuDropdown();
            this.comboBox_Hotels = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.tb_RoomName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.tb_RoomType = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.tB_HotelName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.availeble_Rooms_gridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager_change_to_dark_or_light_mode)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availeble_Rooms_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager_change_to_dark_or_light_mode
            // 
            this.metroStyleManager_change_to_dark_or_light_mode.Owner = null;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuTransition1.SetDecoration(this.bunifuLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuLabel1.Location = new System.Drawing.Point(206, 15);
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
            this.panel1.Controls.Add(this.bunifuPictureBox1);
            this.panel1.Controls.Add(this.panel_for_current_selected);
            this.panel1.Controls.Add(this.button_Reservation);
            this.panel1.Controls.Add(this.b_RoomsOcupied);
            this.panel1.Controls.Add(this.b_UnocupiedRooms);
            this.panel1.Controls.Add(this.b_Hotels);
            this.panel1.Controls.Add(this.b_Reset);
            this.panel1.Controls.Add(this.b_LightDark_theme);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuTransition1.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 749);
            this.panel1.TabIndex = 39;
            this.panel1.MouseEnter += new System.EventHandler(this.Panel1_MouseEnter_Leave);
            this.panel1.MouseLeave += new System.EventHandler(this.Panel1_MouseEnter_Leave);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuPictureBox1.BorderRadius = 24;
            this.bunifuTransition1.SetDecoration(this.bunifuPictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPictureBox1.Image = global::Managementul_Hotelurilor.Properties.Resources.icons8_menu_48;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(6, 38);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(48, 48);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 52;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // panel_for_current_selected
            // 
            this.panel_for_current_selected.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.panel_for_current_selected, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel_for_current_selected.Location = new System.Drawing.Point(0, 111);
            this.panel_for_current_selected.Name = "panel_for_current_selected";
            this.panel_for_current_selected.Size = new System.Drawing.Size(6, 60);
            this.panel_for_current_selected.TabIndex = 51;
            // 
            // button_Reservation
            // 
            this.button_Reservation.Active = false;
            this.button_Reservation.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(190)))));
            this.button_Reservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Reservation.BorderRadius = 0;
            this.button_Reservation.ButtonText = "Reserve";
            this.button_Reservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.button_Reservation, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button_Reservation.DisabledColor = System.Drawing.Color.Gray;
            this.button_Reservation.Enabled = false;
            this.button_Reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reservation.Iconcolor = System.Drawing.Color.Transparent;
            this.button_Reservation.Iconimage = global::Managementul_Hotelurilor.Properties.Resources.icons8_reservation_48;
            this.button_Reservation.Iconimage_right = null;
            this.button_Reservation.Iconimage_right_Selected = null;
            this.button_Reservation.Iconimage_Selected = null;
            this.button_Reservation.IconMarginLeft = 0;
            this.button_Reservation.IconMarginRight = 0;
            this.button_Reservation.IconRightVisible = true;
            this.button_Reservation.IconRightZoom = 0D;
            this.button_Reservation.IconVisible = true;
            this.button_Reservation.IconZoom = 90D;
            this.button_Reservation.IsTab = false;
            this.button_Reservation.Location = new System.Drawing.Point(1, 349);
            this.button_Reservation.Name = "button_Reservation";
            this.button_Reservation.Normalcolor = System.Drawing.Color.Empty;
            this.button_Reservation.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(220)))));
            this.button_Reservation.OnHoverTextColor = System.Drawing.Color.White;
            this.button_Reservation.selected = false;
            this.button_Reservation.Size = new System.Drawing.Size(196, 61);
            this.button_Reservation.TabIndex = 50;
            this.button_Reservation.Text = "Reserve";
            this.button_Reservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Reservation.Textcolor = System.Drawing.Color.White;
            this.button_Reservation.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_Reservation.Click += new System.EventHandler(this.Button_Reservation_Click);
            // 
            // b_RoomsOcupied
            // 
            this.b_RoomsOcupied.Active = false;
            this.b_RoomsOcupied.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(190)))));
            this.b_RoomsOcupied.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_RoomsOcupied.BorderRadius = 0;
            this.b_RoomsOcupied.ButtonText = "Boocked";
            this.b_RoomsOcupied.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.b_RoomsOcupied, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_RoomsOcupied.DisabledColor = System.Drawing.Color.Gray;
            this.b_RoomsOcupied.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_RoomsOcupied.Iconcolor = System.Drawing.Color.Transparent;
            this.b_RoomsOcupied.Iconimage = global::Managementul_Hotelurilor.Properties.Resources.icons8_saving_book_48;
            this.b_RoomsOcupied.Iconimage_right = null;
            this.b_RoomsOcupied.Iconimage_right_Selected = null;
            this.b_RoomsOcupied.Iconimage_Selected = null;
            this.b_RoomsOcupied.IconMarginLeft = 0;
            this.b_RoomsOcupied.IconMarginRight = 0;
            this.b_RoomsOcupied.IconRightVisible = true;
            this.b_RoomsOcupied.IconRightZoom = 0D;
            this.b_RoomsOcupied.IconVisible = true;
            this.b_RoomsOcupied.IconZoom = 90D;
            this.b_RoomsOcupied.IsTab = false;
            this.b_RoomsOcupied.Location = new System.Drawing.Point(2, 227);
            this.b_RoomsOcupied.Name = "b_RoomsOcupied";
            this.b_RoomsOcupied.Normalcolor = System.Drawing.Color.Empty;
            this.b_RoomsOcupied.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(220)))));
            this.b_RoomsOcupied.OnHoverTextColor = System.Drawing.Color.White;
            this.b_RoomsOcupied.selected = false;
            this.b_RoomsOcupied.Size = new System.Drawing.Size(196, 61);
            this.b_RoomsOcupied.TabIndex = 49;
            this.b_RoomsOcupied.Text = "Boocked";
            this.b_RoomsOcupied.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_RoomsOcupied.Textcolor = System.Drawing.Color.White;
            this.b_RoomsOcupied.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.b_RoomsOcupied.Click += new System.EventHandler(this.B_Rooms_Click);
            // 
            // b_UnocupiedRooms
            // 
            this.b_UnocupiedRooms.Active = false;
            this.b_UnocupiedRooms.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(190)))));
            this.b_UnocupiedRooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_UnocupiedRooms.BorderRadius = 0;
            this.b_UnocupiedRooms.ButtonText = "Not Boocked";
            this.b_UnocupiedRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.b_UnocupiedRooms, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_UnocupiedRooms.DisabledColor = System.Drawing.Color.Gray;
            this.b_UnocupiedRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_UnocupiedRooms.Iconcolor = System.Drawing.Color.Transparent;
            this.b_UnocupiedRooms.Iconimage = global::Managementul_Hotelurilor.Properties.Resources.icons8_generic_book_file_type_48;
            this.b_UnocupiedRooms.Iconimage_right = null;
            this.b_UnocupiedRooms.Iconimage_right_Selected = null;
            this.b_UnocupiedRooms.Iconimage_Selected = null;
            this.b_UnocupiedRooms.IconMarginLeft = 0;
            this.b_UnocupiedRooms.IconMarginRight = 0;
            this.b_UnocupiedRooms.IconRightVisible = true;
            this.b_UnocupiedRooms.IconRightZoom = 0D;
            this.b_UnocupiedRooms.IconVisible = true;
            this.b_UnocupiedRooms.IconZoom = 90D;
            this.b_UnocupiedRooms.IsTab = false;
            this.b_UnocupiedRooms.Location = new System.Drawing.Point(0, 288);
            this.b_UnocupiedRooms.Name = "b_UnocupiedRooms";
            this.b_UnocupiedRooms.Normalcolor = System.Drawing.Color.Empty;
            this.b_UnocupiedRooms.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(220)))));
            this.b_UnocupiedRooms.OnHoverTextColor = System.Drawing.Color.White;
            this.b_UnocupiedRooms.selected = false;
            this.b_UnocupiedRooms.Size = new System.Drawing.Size(197, 61);
            this.b_UnocupiedRooms.TabIndex = 48;
            this.b_UnocupiedRooms.Text = "Not Boocked";
            this.b_UnocupiedRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_UnocupiedRooms.Textcolor = System.Drawing.Color.White;
            this.b_UnocupiedRooms.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.b_UnocupiedRooms.Click += new System.EventHandler(this.B_UnocupiedRooms_Click);
            // 
            // b_Hotels
            // 
            this.b_Hotels.Active = false;
            this.b_Hotels.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(190)))));
            this.b_Hotels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_Hotels.BorderRadius = 0;
            this.b_Hotels.ButtonText = "Find Rooms";
            this.b_Hotels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.b_Hotels, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_Hotels.DisabledColor = System.Drawing.Color.Gray;
            this.b_Hotels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Hotels.Iconcolor = System.Drawing.Color.Transparent;
            this.b_Hotels.Iconimage = global::Managementul_Hotelurilor.Properties.Resources.icons8_search_48;
            this.b_Hotels.Iconimage_right = null;
            this.b_Hotels.Iconimage_right_Selected = null;
            this.b_Hotels.Iconimage_Selected = null;
            this.b_Hotels.IconMarginLeft = 0;
            this.b_Hotels.IconMarginRight = 0;
            this.b_Hotels.IconRightVisible = true;
            this.b_Hotels.IconRightZoom = 0D;
            this.b_Hotels.IconVisible = true;
            this.b_Hotels.IconZoom = 90D;
            this.b_Hotels.IsTab = false;
            this.b_Hotels.Location = new System.Drawing.Point(0, 166);
            this.b_Hotels.Name = "b_Hotels";
            this.b_Hotels.Normalcolor = System.Drawing.Color.Empty;
            this.b_Hotels.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(220)))));
            this.b_Hotels.OnHoverTextColor = System.Drawing.Color.White;
            this.b_Hotels.selected = false;
            this.b_Hotels.Size = new System.Drawing.Size(197, 61);
            this.b_Hotels.TabIndex = 47;
            this.b_Hotels.Text = "Find Rooms";
            this.b_Hotels.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_Hotels.Textcolor = System.Drawing.Color.White;
            this.b_Hotels.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.b_Hotels.Click += new System.EventHandler(this.B_Hotels_Click);
            // 
            // b_Reset
            // 
            this.b_Reset.Active = false;
            this.b_Reset.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(190)))));
            this.b_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_Reset.BorderRadius = 0;
            this.b_Reset.ButtonText = "Reset";
            this.b_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.b_Reset, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_Reset.DisabledColor = System.Drawing.Color.Gray;
            this.b_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Reset.Iconcolor = System.Drawing.Color.Transparent;
            this.b_Reset.Iconimage = global::Managementul_Hotelurilor.Properties.Resources.icons8_reboot_48;
            this.b_Reset.Iconimage_right = null;
            this.b_Reset.Iconimage_right_Selected = null;
            this.b_Reset.Iconimage_Selected = null;
            this.b_Reset.IconMarginLeft = 0;
            this.b_Reset.IconMarginRight = 0;
            this.b_Reset.IconRightVisible = true;
            this.b_Reset.IconRightZoom = 0D;
            this.b_Reset.IconVisible = true;
            this.b_Reset.IconZoom = 90D;
            this.b_Reset.IsTab = false;
            this.b_Reset.Location = new System.Drawing.Point(1, 105);
            this.b_Reset.Name = "b_Reset";
            this.b_Reset.Normalcolor = System.Drawing.Color.Empty;
            this.b_Reset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(220)))));
            this.b_Reset.OnHoverTextColor = System.Drawing.Color.White;
            this.b_Reset.selected = false;
            this.b_Reset.Size = new System.Drawing.Size(196, 61);
            this.b_Reset.TabIndex = 46;
            this.b_Reset.Text = "Reset";
            this.b_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_Reset.Textcolor = System.Drawing.Color.White;
            this.b_Reset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.b_Reset.Click += new System.EventHandler(this.B_Reset_Click);
            // 
            // b_LightDark_theme
            // 
            this.b_LightDark_theme.Active = false;
            this.b_LightDark_theme.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(190)))));
            this.b_LightDark_theme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_LightDark_theme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_LightDark_theme.BorderRadius = 0;
            this.b_LightDark_theme.ButtonText = "Go Dark";
            this.b_LightDark_theme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.b_LightDark_theme, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_LightDark_theme.DisabledColor = System.Drawing.Color.Gray;
            this.b_LightDark_theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_LightDark_theme.Iconcolor = System.Drawing.Color.Transparent;
            this.b_LightDark_theme.Iconimage = global::Managementul_Hotelurilor.Properties.Resources.icons8_sun_48;
            this.b_LightDark_theme.Iconimage_right = global::Managementul_Hotelurilor.Properties.Resources.icons8_moon_symbol_48;
            this.b_LightDark_theme.Iconimage_right_Selected = null;
            this.b_LightDark_theme.Iconimage_Selected = null;
            this.b_LightDark_theme.IconMarginLeft = 0;
            this.b_LightDark_theme.IconMarginRight = 0;
            this.b_LightDark_theme.IconRightVisible = true;
            this.b_LightDark_theme.IconRightZoom = 0D;
            this.b_LightDark_theme.IconVisible = true;
            this.b_LightDark_theme.IconZoom = 90D;
            this.b_LightDark_theme.IsTab = false;
            this.b_LightDark_theme.Location = new System.Drawing.Point(1, 683);
            this.b_LightDark_theme.Name = "b_LightDark_theme";
            this.b_LightDark_theme.Normalcolor = System.Drawing.Color.Empty;
            this.b_LightDark_theme.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(220)))));
            this.b_LightDark_theme.OnHoverTextColor = System.Drawing.Color.White;
            this.b_LightDark_theme.selected = false;
            this.b_LightDark_theme.Size = new System.Drawing.Size(198, 66);
            this.b_LightDark_theme.TabIndex = 1;
            this.b_LightDark_theme.Text = "Go Dark";
            this.b_LightDark_theme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.b_LightDark_theme.Textcolor = System.Drawing.Color.White;
            this.b_LightDark_theme.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(50, 49);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(127, 26);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.bunifuTransition1.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(-15, -15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 20);
            this.panel2.TabIndex = 40;
            // 
            // MouseDetect
            // 
            this.MouseDetect.Interval = 10;
            this.MouseDetect.Tick += new System.EventHandler(this.MouseDetect_Tick);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            this.bunifuTransition1.Interval = 50;
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox_Country.BorderRadius = 1;
            this.comboBox_Country.Color = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.bunifuTransition1.SetDecoration(this.comboBox_Country, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.comboBox_Country.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.comboBox_Country.DisabledColor = System.Drawing.Color.Gray;
            this.comboBox_Country.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_Country.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.comboBox_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Country.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.comboBox_Country.Enabled = false;
            this.comboBox_Country.FillDropDown = false;
            this.comboBox_Country.FillIndicator = false;
            this.comboBox_Country.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.comboBox_Country.FormattingEnabled = true;
            this.comboBox_Country.Icon = null;
            this.comboBox_Country.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.comboBox_Country.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.comboBox_Country.ItemBackColor = System.Drawing.Color.White;
            this.comboBox_Country.ItemBorderColor = System.Drawing.Color.White;
            this.comboBox_Country.ItemForeColor = System.Drawing.Color.Black;
            this.comboBox_Country.ItemHeight = 26;
            this.comboBox_Country.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.comboBox_Country.Location = new System.Drawing.Point(206, 89);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.Size = new System.Drawing.Size(217, 32);
            this.comboBox_Country.TabIndex = 42;
            this.comboBox_Country.Text = null;
            this.comboBox_Country.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Country_SelectedValueChanged);
            // 
            // comboBox_city
            // 
            this.comboBox_city.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_city.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox_city.BorderRadius = 1;
            this.comboBox_city.Color = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.bunifuTransition1.SetDecoration(this.comboBox_city, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.comboBox_city.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.comboBox_city.DisabledColor = System.Drawing.Color.Gray;
            this.comboBox_city.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_city.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.comboBox_city.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_city.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.comboBox_city.Enabled = false;
            this.comboBox_city.FillDropDown = false;
            this.comboBox_city.FillIndicator = false;
            this.comboBox_city.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.comboBox_city.FormattingEnabled = true;
            this.comboBox_city.Icon = null;
            this.comboBox_city.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.comboBox_city.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.comboBox_city.ItemBackColor = System.Drawing.Color.White;
            this.comboBox_city.ItemBorderColor = System.Drawing.Color.White;
            this.comboBox_city.ItemForeColor = System.Drawing.Color.Black;
            this.comboBox_city.ItemHeight = 26;
            this.comboBox_city.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.comboBox_city.Location = new System.Drawing.Point(538, 89);
            this.comboBox_city.Name = "comboBox_city";
            this.comboBox_city.Size = new System.Drawing.Size(217, 32);
            this.comboBox_city.TabIndex = 43;
            this.comboBox_city.Text = null;
            this.comboBox_city.SelectedIndexChanged += new System.EventHandler(this.ComboBox_city_SelectedValueChanged);
            // 
            // comboBox_Hotels
            // 
            this.comboBox_Hotels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Hotels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox_Hotels.BorderRadius = 1;
            this.comboBox_Hotels.Color = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.bunifuTransition1.SetDecoration(this.comboBox_Hotels, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.comboBox_Hotels.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.comboBox_Hotels.DisabledColor = System.Drawing.Color.Gray;
            this.comboBox_Hotels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_Hotels.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.comboBox_Hotels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Hotels.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.comboBox_Hotels.Enabled = false;
            this.comboBox_Hotels.FillDropDown = false;
            this.comboBox_Hotels.FillIndicator = false;
            this.comboBox_Hotels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Hotels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.comboBox_Hotels.FormattingEnabled = true;
            this.comboBox_Hotels.Icon = null;
            this.comboBox_Hotels.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.comboBox_Hotels.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.comboBox_Hotels.ItemBackColor = System.Drawing.Color.White;
            this.comboBox_Hotels.ItemBorderColor = System.Drawing.Color.White;
            this.comboBox_Hotels.ItemForeColor = System.Drawing.Color.Black;
            this.comboBox_Hotels.ItemHeight = 26;
            this.comboBox_Hotels.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.comboBox_Hotels.Location = new System.Drawing.Point(848, 89);
            this.comboBox_Hotels.Name = "comboBox_Hotels";
            this.comboBox_Hotels.Size = new System.Drawing.Size(217, 32);
            this.comboBox_Hotels.TabIndex = 44;
            this.comboBox_Hotels.Text = null;
            this.comboBox_Hotels.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Hotels_SelectedIndexChanged);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuTransition1.SetDecoration(this.bunifuLabel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.bunifuLabel2.Location = new System.Drawing.Point(283, 171);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(62, 15);
            this.bunifuLabel2.TabIndex = 45;
            this.bunifuLabel2.Text = "Room Name";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // tb_RoomName
            // 
            this.tb_RoomName.AcceptsReturn = false;
            this.tb_RoomName.AcceptsTab = false;
            this.tb_RoomName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_RoomName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_RoomName.BackColor = System.Drawing.Color.Transparent;
            this.tb_RoomName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_RoomName.BackgroundImage")));
            this.tb_RoomName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.tb_RoomName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tb_RoomName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.tb_RoomName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.tb_RoomName.BorderRadius = 1;
            this.tb_RoomName.BorderThickness = 2;
            this.tb_RoomName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTransition1.SetDecoration(this.tb_RoomName, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tb_RoomName.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RoomName.DefaultText = "";
            this.tb_RoomName.Enabled = false;
            this.tb_RoomName.FillColor = System.Drawing.Color.White;
            this.tb_RoomName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.tb_RoomName.HideSelection = true;
            this.tb_RoomName.IconLeft = null;
            this.tb_RoomName.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.tb_RoomName.IconPadding = 10;
            this.tb_RoomName.IconRight = null;
            this.tb_RoomName.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.tb_RoomName.Location = new System.Drawing.Point(206, 193);
            this.tb_RoomName.MaxLength = 32767;
            this.tb_RoomName.MinimumSize = new System.Drawing.Size(100, 35);
            this.tb_RoomName.Modified = false;
            this.tb_RoomName.Name = "tb_RoomName";
            this.tb_RoomName.PasswordChar = '\0';
            this.tb_RoomName.ReadOnly = true;
            this.tb_RoomName.SelectedText = "";
            this.tb_RoomName.SelectionLength = 0;
            this.tb_RoomName.SelectionStart = 0;
            this.tb_RoomName.ShortcutsEnabled = true;
            this.tb_RoomName.Size = new System.Drawing.Size(217, 35);
            this.tb_RoomName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.tb_RoomName.TabIndex = 46;
            this.tb_RoomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_RoomName.TextMarginLeft = 5;
            this.tb_RoomName.TextPlaceholder = "";
            this.tb_RoomName.UseSystemPasswordChar = false;
            // 
            // tb_RoomType
            // 
            this.tb_RoomType.AcceptsReturn = false;
            this.tb_RoomType.AcceptsTab = false;
            this.tb_RoomType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_RoomType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_RoomType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_RoomType.BackColor = System.Drawing.Color.Transparent;
            this.tb_RoomType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_RoomType.BackgroundImage")));
            this.tb_RoomType.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.tb_RoomType.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tb_RoomType.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.tb_RoomType.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.tb_RoomType.BorderRadius = 1;
            this.tb_RoomType.BorderThickness = 2;
            this.tb_RoomType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTransition1.SetDecoration(this.tb_RoomType, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tb_RoomType.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RoomType.DefaultText = "";
            this.tb_RoomType.Enabled = false;
            this.tb_RoomType.FillColor = System.Drawing.Color.White;
            this.tb_RoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.tb_RoomType.HideSelection = true;
            this.tb_RoomType.IconLeft = null;
            this.tb_RoomType.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.tb_RoomType.IconPadding = 10;
            this.tb_RoomType.IconRight = null;
            this.tb_RoomType.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.tb_RoomType.Location = new System.Drawing.Point(538, 193);
            this.tb_RoomType.MaxLength = 32767;
            this.tb_RoomType.MinimumSize = new System.Drawing.Size(100, 35);
            this.tb_RoomType.Modified = false;
            this.tb_RoomType.Name = "tb_RoomType";
            this.tb_RoomType.PasswordChar = '\0';
            this.tb_RoomType.ReadOnly = true;
            this.tb_RoomType.SelectedText = "";
            this.tb_RoomType.SelectionLength = 0;
            this.tb_RoomType.SelectionStart = 0;
            this.tb_RoomType.ShortcutsEnabled = true;
            this.tb_RoomType.Size = new System.Drawing.Size(217, 35);
            this.tb_RoomType.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.tb_RoomType.TabIndex = 48;
            this.tb_RoomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_RoomType.TextMarginLeft = 5;
            this.tb_RoomType.TextPlaceholder = "";
            this.tb_RoomType.UseSystemPasswordChar = false;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuTransition1.SetDecoration(this.bunifuLabel3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.bunifuLabel3.Location = new System.Drawing.Point(617, 171);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(59, 15);
            this.bunifuLabel3.TabIndex = 47;
            this.bunifuLabel3.Text = "Family Type";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // tB_HotelName
            // 
            this.tB_HotelName.AcceptsReturn = false;
            this.tB_HotelName.AcceptsTab = false;
            this.tB_HotelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_HotelName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tB_HotelName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tB_HotelName.BackColor = System.Drawing.Color.Transparent;
            this.tB_HotelName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tB_HotelName.BackgroundImage")));
            this.tB_HotelName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.tB_HotelName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tB_HotelName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.tB_HotelName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.tB_HotelName.BorderRadius = 1;
            this.tB_HotelName.BorderThickness = 2;
            this.tB_HotelName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTransition1.SetDecoration(this.tB_HotelName, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tB_HotelName.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_HotelName.DefaultText = "";
            this.tB_HotelName.Enabled = false;
            this.tB_HotelName.FillColor = System.Drawing.Color.White;
            this.tB_HotelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.tB_HotelName.HideSelection = true;
            this.tB_HotelName.IconLeft = null;
            this.tB_HotelName.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.tB_HotelName.IconPadding = 10;
            this.tB_HotelName.IconRight = null;
            this.tB_HotelName.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.tB_HotelName.Location = new System.Drawing.Point(848, 193);
            this.tB_HotelName.MaxLength = 32767;
            this.tB_HotelName.MinimumSize = new System.Drawing.Size(100, 35);
            this.tB_HotelName.Modified = false;
            this.tB_HotelName.Name = "tB_HotelName";
            this.tB_HotelName.PasswordChar = '\0';
            this.tB_HotelName.ReadOnly = true;
            this.tB_HotelName.SelectedText = "";
            this.tB_HotelName.SelectionLength = 0;
            this.tB_HotelName.SelectionStart = 0;
            this.tB_HotelName.ShortcutsEnabled = true;
            this.tB_HotelName.Size = new System.Drawing.Size(217, 35);
            this.tB_HotelName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.tB_HotelName.TabIndex = 50;
            this.tB_HotelName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tB_HotelName.TextMarginLeft = 5;
            this.tB_HotelName.TextPlaceholder = "";
            this.tB_HotelName.UseSystemPasswordChar = false;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuTransition1.SetDecoration(this.bunifuLabel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.bunifuLabel4.Location = new System.Drawing.Point(927, 171);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(59, 15);
            this.bunifuLabel4.TabIndex = 49;
            this.bunifuLabel4.Text = "Hotel Name";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuTransition1.SetDecoration(this.bunifuLabel5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.bunifuLabel5.Location = new System.Drawing.Point(942, 53);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(28, 15);
            this.bunifuLabel5.TabIndex = 51;
            this.bunifuLabel5.Text = "Hotel";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuTransition1.SetDecoration(this.bunifuLabel6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.bunifuLabel6.Location = new System.Drawing.Point(636, 53);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(20, 15);
            this.bunifuLabel6.TabIndex = 52;
            this.bunifuLabel6.Text = "City";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.CursorType = null;
            this.bunifuTransition1.SetDecoration(this.bunifuLabel7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.bunifuLabel7.Location = new System.Drawing.Point(295, 53);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(39, 15);
            this.bunifuLabel7.TabIndex = 53;
            this.bunifuLabel7.Text = "Country";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // availeble_Rooms_gridView
            // 
            this.availeble_Rooms_gridView.AllowCustomTheming = false;
            this.availeble_Rooms_gridView.AllowUserToAddRows = false;
            this.availeble_Rooms_gridView.AllowUserToDeleteRows = false;
            this.availeble_Rooms_gridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.availeble_Rooms_gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.availeble_Rooms_gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.availeble_Rooms_gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.availeble_Rooms_gridView.BackgroundColor = System.Drawing.Color.White;
            this.availeble_Rooms_gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.availeble_Rooms_gridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.availeble_Rooms_gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.availeble_Rooms_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.availeble_Rooms_gridView.ColumnHeadersHeight = 40;
            this.availeble_Rooms_gridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.availeble_Rooms_gridView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.availeble_Rooms_gridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.availeble_Rooms_gridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.availeble_Rooms_gridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.availeble_Rooms_gridView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.availeble_Rooms_gridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.availeble_Rooms_gridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.availeble_Rooms_gridView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.availeble_Rooms_gridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.availeble_Rooms_gridView.CurrentTheme.Name = null;
            this.availeble_Rooms_gridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.availeble_Rooms_gridView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.availeble_Rooms_gridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.availeble_Rooms_gridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.availeble_Rooms_gridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuTransition1.SetDecoration(this.availeble_Rooms_gridView, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.availeble_Rooms_gridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.availeble_Rooms_gridView.EnableHeadersVisualStyles = false;
            this.availeble_Rooms_gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.availeble_Rooms_gridView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.availeble_Rooms_gridView.HeaderBgColor = System.Drawing.Color.Empty;
            this.availeble_Rooms_gridView.HeaderForeColor = System.Drawing.Color.White;
            this.availeble_Rooms_gridView.Location = new System.Drawing.Point(206, 293);
            this.availeble_Rooms_gridView.Name = "availeble_Rooms_gridView";
            this.availeble_Rooms_gridView.ReadOnly = true;
            this.availeble_Rooms_gridView.RowHeadersVisible = false;
            this.availeble_Rooms_gridView.RowTemplate.Height = 40;
            this.availeble_Rooms_gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.availeble_Rooms_gridView.Size = new System.Drawing.Size(859, 437);
            this.availeble_Rooms_gridView.TabIndex = 54;
            this.availeble_Rooms_gridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.availeble_Rooms_gridView.SelectionChanged += new System.EventHandler(this.Availeble_Rooms_gridView_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::Managementul_Hotelurilor.Properties.Resources.icons8_moon_symbol_48;
            this.ClientSize = new System.Drawing.Size(1088, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.availeble_Rooms_gridView);
            this.Controls.Add(this.bunifuLabel7);
            this.Controls.Add(this.bunifuLabel6);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.tB_HotelName);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.tb_RoomType);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.tb_RoomName);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.comboBox_Hotels);
            this.Controls.Add(this.comboBox_city);
            this.Controls.Add(this.comboBox_Country);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunifuLabel1);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = ".";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager_change_to_dark_or_light_mode)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availeble_Rooms_gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager metroStyleManager_change_to_dark_or_light_mode;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton b_LightDark_theme;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Timer MouseDetect;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private Bunifu.UI.WinForms.BunifuDropdown comboBox_Country;
        private Bunifu.UI.WinForms.BunifuDropdown comboBox_city;
        private Bunifu.UI.WinForms.BunifuDropdown comboBox_Hotels;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tb_RoomName;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tb_RoomType;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tB_HotelName;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private Bunifu.UI.WinForms.BunifuDataGridView availeble_Rooms_gridView;
        private Bunifu.Framework.UI.BunifuFlatButton button_Reservation;
        private Bunifu.Framework.UI.BunifuFlatButton b_RoomsOcupied;
        private Bunifu.Framework.UI.BunifuFlatButton b_UnocupiedRooms;
        private Bunifu.Framework.UI.BunifuFlatButton b_Hotels;
        private Bunifu.Framework.UI.BunifuFlatButton b_Reset;
        private System.Windows.Forms.Panel panel_for_current_selected;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}

