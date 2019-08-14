namespace Managementul_Hotelurilor
{
    partial class Form_Reservations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Reservations));
            this.GV_OcupiedRooms = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GV_OcupiedRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_OcupiedRooms
            // 
            this.GV_OcupiedRooms.AllowCustomTheming = false;
            this.GV_OcupiedRooms.AllowUserToAddRows = false;
            this.GV_OcupiedRooms.AllowUserToDeleteRows = false;
            this.GV_OcupiedRooms.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.GV_OcupiedRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GV_OcupiedRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GV_OcupiedRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV_OcupiedRooms.BackgroundColor = System.Drawing.Color.White;
            this.GV_OcupiedRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GV_OcupiedRooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GV_OcupiedRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV_OcupiedRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GV_OcupiedRooms.ColumnHeadersHeight = 40;
            this.GV_OcupiedRooms.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.GV_OcupiedRooms.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GV_OcupiedRooms.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.GV_OcupiedRooms.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.GV_OcupiedRooms.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GV_OcupiedRooms.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.GV_OcupiedRooms.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.GV_OcupiedRooms.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.GV_OcupiedRooms.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.GV_OcupiedRooms.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GV_OcupiedRooms.CurrentTheme.Name = null;
            this.GV_OcupiedRooms.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GV_OcupiedRooms.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GV_OcupiedRooms.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.GV_OcupiedRooms.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.GV_OcupiedRooms.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GV_OcupiedRooms.DefaultCellStyle = dataGridViewCellStyle3;
            this.GV_OcupiedRooms.EnableHeadersVisualStyles = false;
            this.GV_OcupiedRooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.GV_OcupiedRooms.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.GV_OcupiedRooms.HeaderBgColor = System.Drawing.Color.Empty;
            this.GV_OcupiedRooms.HeaderForeColor = System.Drawing.Color.White;
            this.GV_OcupiedRooms.Location = new System.Drawing.Point(16, 85);
            this.GV_OcupiedRooms.Name = "GV_OcupiedRooms";
            this.GV_OcupiedRooms.ReadOnly = true;
            this.GV_OcupiedRooms.RowHeadersVisible = false;
            this.GV_OcupiedRooms.RowTemplate.Height = 40;
            this.GV_OcupiedRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV_OcupiedRooms.Size = new System.Drawing.Size(859, 651);
            this.GV_OcupiedRooms.TabIndex = 55;
            this.GV_OcupiedRooms.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.GV_OcupiedRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(106)))), ((int)(((byte)(237)))));
            this.panel2.Location = new System.Drawing.Point(-107, -15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 20);
            this.panel2.TabIndex = 56;
            // 
            // Form_Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 759);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GV_OcupiedRooms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Reservations";
            this.Text = "Rooms already ocupied";
            this.Load += new System.EventHandler(this.Form_Reservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_OcupiedRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView GV_OcupiedRooms;
        private System.Windows.Forms.Panel panel2;
    }
}