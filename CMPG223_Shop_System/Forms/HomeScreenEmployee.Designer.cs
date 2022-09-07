
namespace CMPG223_Shop_System.Forms
{
    partial class HomeScreenEmployee
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
            this.pnlNavigate = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnMaintainDevelopers = new System.Windows.Forms.Button();
            this.btnMaintainOrders = new System.Windows.Forms.Button();
            this.btnMaintainConsoles = new System.Windows.Forms.Button();
            this.btnMaintainGames = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlNavigate.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavigate
            // 
            this.pnlNavigate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlNavigate.Controls.Add(this.btnExit);
            this.pnlNavigate.Controls.Add(this.btnSettings);
            this.pnlNavigate.Controls.Add(this.btnMaintainDevelopers);
            this.pnlNavigate.Controls.Add(this.btnMaintainOrders);
            this.pnlNavigate.Controls.Add(this.btnMaintainConsoles);
            this.pnlNavigate.Controls.Add(this.btnMaintainGames);
            this.pnlNavigate.Controls.Add(this.btnHome);
            this.pnlNavigate.Controls.Add(this.panel2);
            this.pnlNavigate.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigate.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigate.Name = "pnlNavigate";
            this.pnlNavigate.Size = new System.Drawing.Size(200, 566);
            this.pnlNavigate.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExit.Image = global::CMPG223_Shop_System.Properties.Resources.icons8_shutdown_26px_1;
            this.btnExit.Location = new System.Drawing.Point(0, 500);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 64);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.Leave += new System.EventHandler(this.btnExit_Leave);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSettings.Image = global::CMPG223_Shop_System.Properties.Resources.icons8_settings_48px;
            this.btnSettings.Location = new System.Drawing.Point(0, 432);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 68);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.Leave += new System.EventHandler(this.btnSettings_Leave);
            // 
            // btnMaintainDevelopers
            // 
            this.btnMaintainDevelopers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaintainDevelopers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintainDevelopers.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintainDevelopers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMaintainDevelopers.Image = global::CMPG223_Shop_System.Properties.Resources.icons8_dev_64px;
            this.btnMaintainDevelopers.Location = new System.Drawing.Point(0, 368);
            this.btnMaintainDevelopers.Name = "btnMaintainDevelopers";
            this.btnMaintainDevelopers.Size = new System.Drawing.Size(200, 64);
            this.btnMaintainDevelopers.TabIndex = 9;
            this.btnMaintainDevelopers.Text = "Maintain developers";
            this.btnMaintainDevelopers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaintainDevelopers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaintainDevelopers.UseVisualStyleBackColor = true;
            this.btnMaintainDevelopers.Click += new System.EventHandler(this.button6_Click);
            this.btnMaintainDevelopers.Leave += new System.EventHandler(this.btnMaintainDevelopers_Leave);
            // 
            // btnMaintainOrders
            // 
            this.btnMaintainOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaintainOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintainOrders.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintainOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMaintainOrders.Image = global::CMPG223_Shop_System.Properties.Resources.icons8_add_shopping_cart_60px;
            this.btnMaintainOrders.Location = new System.Drawing.Point(0, 304);
            this.btnMaintainOrders.Name = "btnMaintainOrders";
            this.btnMaintainOrders.Size = new System.Drawing.Size(200, 64);
            this.btnMaintainOrders.TabIndex = 8;
            this.btnMaintainOrders.Text = "Maintain orders";
            this.btnMaintainOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaintainOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaintainOrders.UseVisualStyleBackColor = true;
            this.btnMaintainOrders.Click += new System.EventHandler(this.btnMaintainOrders_Click);
            this.btnMaintainOrders.Leave += new System.EventHandler(this.btnMaintainOrders_Leave);
            // 
            // btnMaintainConsoles
            // 
            this.btnMaintainConsoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnMaintainConsoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaintainConsoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintainConsoles.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintainConsoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMaintainConsoles.Image = global::CMPG223_Shop_System.Properties.Resources.icons8_visual_game_boy_64px_1;
            this.btnMaintainConsoles.Location = new System.Drawing.Point(0, 236);
            this.btnMaintainConsoles.Name = "btnMaintainConsoles";
            this.btnMaintainConsoles.Size = new System.Drawing.Size(200, 68);
            this.btnMaintainConsoles.TabIndex = 5;
            this.btnMaintainConsoles.Text = "Maintain Consoles";
            this.btnMaintainConsoles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaintainConsoles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaintainConsoles.UseVisualStyleBackColor = false;
            this.btnMaintainConsoles.Click += new System.EventHandler(this.btnMaintainConsoles_Click);
            this.btnMaintainConsoles.Leave += new System.EventHandler(this.btnMaintainConsoles_Leave);
            // 
            // btnMaintainGames
            // 
            this.btnMaintainGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnMaintainGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaintainGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintainGames.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintainGames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMaintainGames.Image = global::CMPG223_Shop_System.Properties.Resources.icons8_game_controller_52px;
            this.btnMaintainGames.Location = new System.Drawing.Point(0, 168);
            this.btnMaintainGames.Name = "btnMaintainGames";
            this.btnMaintainGames.Size = new System.Drawing.Size(200, 68);
            this.btnMaintainGames.TabIndex = 4;
            this.btnMaintainGames.Text = "Maintain Games";
            this.btnMaintainGames.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaintainGames.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaintainGames.UseVisualStyleBackColor = false;
            this.btnMaintainGames.Click += new System.EventHandler(this.btnMaintainGames_Click);
            this.btnMaintainGames.Leave += new System.EventHandler(this.btnMaintainGames_Leave);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnHome.Image = global::CMPG223_Shop_System.Properties.Resources.icons8_home_50px;
            this.btnHome.Location = new System.Drawing.Point(0, 100);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 68);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.Leave += new System.EventHandler(this.btnHome_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(-1, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome back EmployeeName!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CMPG223_Shop_System.Properties.Resources.icons8_name_tag_64px_2;
            this.pictureBox1.Location = new System.Drawing.Point(64, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 57);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HomeScreenEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.pnlNavigate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeScreenEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeScreen";
            this.pnlNavigate.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavigate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnMaintainGames;
        private System.Windows.Forms.Button btnMaintainConsoles;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMaintainOrders;
        private System.Windows.Forms.Button btnMaintainDevelopers;
    }
}