namespace Blackjack_Game
{
    partial class FrmGame
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
            this.GbxScore = new System.Windows.Forms.GroupBox();
            this.lblTieAmount = new System.Windows.Forms.Label();
            this.lblLossesAmount = new System.Windows.Forms.Label();
            this.lblWinAmount = new System.Windows.Forms.Label();
            this.lblTies = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.btnDeal = new System.Windows.Forms.Button();
            this.lblPlayerCardTotal = new System.Windows.Forms.Label();
            this.pbxDeck = new System.Windows.Forms.PictureBox();
            this.lblDealerCardTotal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.GbxScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDeck)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxScore
            // 
            this.GbxScore.BackColor = System.Drawing.Color.Transparent;
            this.GbxScore.Controls.Add(this.lblTieAmount);
            this.GbxScore.Controls.Add(this.lblLossesAmount);
            this.GbxScore.Controls.Add(this.lblWinAmount);
            this.GbxScore.Controls.Add(this.lblTies);
            this.GbxScore.Controls.Add(this.lblLosses);
            this.GbxScore.Controls.Add(this.lblWins);
            this.GbxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxScore.ForeColor = System.Drawing.SystemColors.Control;
            this.GbxScore.Location = new System.Drawing.Point(12, 36);
            this.GbxScore.Name = "GbxScore";
            this.GbxScore.Size = new System.Drawing.Size(167, 124);
            this.GbxScore.TabIndex = 0;
            this.GbxScore.TabStop = false;
            this.GbxScore.Text = "Scoreboard";
            // 
            // lblTieAmount
            // 
            this.lblTieAmount.AutoSize = true;
            this.lblTieAmount.Location = new System.Drawing.Point(87, 93);
            this.lblTieAmount.Name = "lblTieAmount";
            this.lblTieAmount.Size = new System.Drawing.Size(0, 17);
            this.lblTieAmount.TabIndex = 5;
            // 
            // lblLossesAmount
            // 
            this.lblLossesAmount.AutoSize = true;
            this.lblLossesAmount.Location = new System.Drawing.Point(87, 61);
            this.lblLossesAmount.Name = "lblLossesAmount";
            this.lblLossesAmount.Size = new System.Drawing.Size(0, 17);
            this.lblLossesAmount.TabIndex = 4;
            // 
            // lblWinAmount
            // 
            this.lblWinAmount.AutoSize = true;
            this.lblWinAmount.Location = new System.Drawing.Point(87, 29);
            this.lblWinAmount.Name = "lblWinAmount";
            this.lblWinAmount.Size = new System.Drawing.Size(0, 17);
            this.lblWinAmount.TabIndex = 3;
            // 
            // lblTies
            // 
            this.lblTies.AutoSize = true;
            this.lblTies.Location = new System.Drawing.Point(6, 93);
            this.lblTies.Name = "lblTies";
            this.lblTies.Size = new System.Drawing.Size(44, 17);
            this.lblTies.TabIndex = 2;
            this.lblTies.Text = "Ties:";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Location = new System.Drawing.Point(6, 61);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(64, 17);
            this.lblLosses.TabIndex = 1;
            this.lblLosses.Text = "Losses:";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(6, 29);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(48, 17);
            this.lblWins.TabIndex = 0;
            this.lblWins.Text = "Wins:";
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(991, 572);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 1;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Location = new System.Drawing.Point(1104, 572);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(75, 23);
            this.btnStay.TabIndex = 2;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // btnDeal
            // 
            this.btnDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeal.Location = new System.Drawing.Point(28, 572);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(75, 23);
            this.btnDeal.TabIndex = 3;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // lblPlayerCardTotal
            // 
            this.lblPlayerCardTotal.AutoSize = true;
            this.lblPlayerCardTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerCardTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCardTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlayerCardTotal.Location = new System.Drawing.Point(442, 578);
            this.lblPlayerCardTotal.Name = "lblPlayerCardTotal";
            this.lblPlayerCardTotal.Size = new System.Drawing.Size(140, 17);
            this.lblPlayerCardTotal.TabIndex = 3;
            this.lblPlayerCardTotal.Text = "Player Card Total:";
            // 
            // pbxDeck
            // 
            this.pbxDeck.Image = global::Blackjack_Game.Properties.Resources.Card_Back;
            this.pbxDeck.InitialImage = null;
            this.pbxDeck.Location = new System.Drawing.Point(1082, 36);
            this.pbxDeck.Name = "pbxDeck";
            this.pbxDeck.Size = new System.Drawing.Size(97, 89);
            this.pbxDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDeck.TabIndex = 6;
            this.pbxDeck.TabStop = false;
            // 
            // lblDealerCardTotal
            // 
            this.lblDealerCardTotal.AutoSize = true;
            this.lblDealerCardTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblDealerCardTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCardTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDealerCardTotal.Location = new System.Drawing.Point(442, 36);
            this.lblDealerCardTotal.Name = "lblDealerCardTotal";
            this.lblDealerCardTotal.Size = new System.Drawing.Size(142, 17);
            this.lblDealerCardTotal.TabIndex = 7;
            this.lblDealerCardTotal.Text = "Dealer Card Total:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1198, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerScore.ForeColor = System.Drawing.SystemColors.Control;
            this.lblComputerScore.Location = new System.Drawing.Point(599, 36);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(0, 17);
            this.lblComputerScore.TabIndex = 9;
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlayerScore.Location = new System.Drawing.Point(599, 578);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(0, 17);
            this.lblPlayerScore.TabIndex = 11;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Blackjack_Game.Properties.Resources.Table4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1198, 630);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.lblDealerCardTotal);
            this.Controls.Add(this.pbxDeck);
            this.Controls.Add(this.lblPlayerCardTotal);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.GbxScore);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGame";
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.GbxScore.ResumeLayout(false);
            this.GbxScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDeck)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxScore;
        private System.Windows.Forms.Label lblTies;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Label lblPlayerCardTotal;
        private System.Windows.Forms.PictureBox pbxDeck;
        private System.Windows.Forms.Label lblDealerCardTotal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblTieAmount;
        private System.Windows.Forms.Label lblLossesAmount;
        private System.Windows.Forms.Label lblWinAmount;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Label lblPlayerScore;
    }
}