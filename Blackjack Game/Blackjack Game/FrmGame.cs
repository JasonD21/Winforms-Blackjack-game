using Blackjack_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack_Game
{
    public partial class FrmGame : Form
    {
        int hand = 2;
        int computerHand = 2;
        const int maxCardsInhand = 5;
        const int playerX = 498;
        const int playerY = 479;
        const int computerX = 518;
        const int computerY = 80;
        PictureBox c1, c2, c3, c4, c5;
        PictureBox p1, p2, p3, p4, p5;
        Deck deck;
        Hand player;
        Hand computer;
        int computerSum = 0;
        int playerSum = 0;
        int x = 40 , z = 40, y = 40, win = 0, loss = 0, draw = 0;
        bool roundEnd;

        public FrmGame()
        {
            InitializeComponent();    
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            deck = new Deck();
            player = new Hand(hand, deck);
            computer = new Hand(hand, deck);

            btnHit.Enabled = false;
            btnStay.Enabled = false;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();

            FrmGame Game = new FrmGame();

            this.Hide();
            Game.ShowDialog();


         

            //FrmHome Home = new FrmHome();

            //this.Hide();
            //Home.ShowDialog();



            //player.Cards.Clear();
            //computer.Cards.Clear();

            //deck = new Deck();
            //player = new Hand(hand, deck);
            //computer = new Hand(hand, deck);

            //lblPlayerScore.Text = " ";
            //lblComputerScore.Text = " ";
            //lblWinAmount.Text = " ";
            //lblTieAmount.Text = " ";
            //lblLossesAmount.Text = " ";
            //lblPlayerScore.BackColor = Color.Transparent;
           
            //computerSum = 0;
            //playerSum = 0;
            //win = 0;
            //loss = 0;
            //draw = 0;
            //x = 40;
            //y = 40;
            //hand = 2;
            //computerHand = 2;

            //btnDeal.Enabled = true;
            //btnHit.Enabled = false;
            //btnStay.Enabled = false;

            //ClearCards();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            //if (player.Cards.Count > 2)
            //{
            //    player.Cards.Clear();
            //    computer.Cards.Clear();
            //    ClearCards();
            //}

            
            lblPlayerScore.BackColor = Color.Transparent;
            btnHit.Enabled = true;
            btnStay.Enabled = true;
            btnDeal.Enabled = false;
            roundEnd = false;

            p1 = new PictureBox
            {
                Location = new System.Drawing.Point(playerX, playerY),
                Size = new System.Drawing.Size(97, 89),
                TabStop = false,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = player.Cards[0].Image
                
            };
            this.Controls.Add(this.p1);

            c1 = new PictureBox
            {
                Location = new System.Drawing.Point(computerX, computerY),
                Size = new System.Drawing.Size(97, 89),
                TabStop = false,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = computer.Cards[0].Image
            };
            this.Controls.Add(this.c1);

            player.AddValue(player.Cards[0], ref playerSum);
            computer.AddValue(computer.Cards[0], ref computerSum);

            p2 = new PictureBox
            {
                Location = new System.Drawing.Point(playerX + 20, playerY - 20),
                Size = new System.Drawing.Size(97, 89),
                TabStop = false,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = player.Cards[1].Image
            };
            this.Controls.Add(this.p2);

            c2 = new PictureBox
            {
                Location = new System.Drawing.Point(computerX - 20, computerY),
                Size = new System.Drawing.Size(97, 89),
                TabStop = false,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Resources.Card_Back
            };
            this.Controls.Add(this.c2);

            player.AddValue(player.Cards[1], ref playerSum);

            lblPlayerScore.Text = playerSum.ToString();
            lblComputerScore.Text = computerSum.ToString();    
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            if (hand != maxCardsInhand)
            {
                player.Cards.Add(deck.DrawCard(player));
                player.AddValue(deck.DrawCard(player), ref playerSum);

                if (hand == 2)
                {
                    CreatePlayerPB(p3);
                }
                else if (hand == 3)
                {
                    CreatePlayerPB(p4);
                }
                else if (hand == 4)
                {
                    CreatePlayerPB(p5);
                }

                lblPlayerScore.Text = playerSum.ToString();

                if (playerSum == 21)
                {
                    lblPlayerScore.BackColor = Color.LightCyan;

                    Stay();
                }
                else if (playerSum > 21)
                {
                    lblPlayerScore.BackColor = Color.Red;
                    MessageBox.Show("Busted!!");
                    ++loss;
                    lblLossesAmount.Text = loss.ToString();
                    roundEnd = true;
                    btnHit.Enabled = false;
                    btnStay.Enabled = false;
                    btnDeal.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Max number of cards reached!");
            }

            ++hand;
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            Stay();
        }

        private void CheckScore()
        {
            if (computerSum > 21)
            {
                MessageBox.Show("Dealer Busts, Player wins!!");
                ++win;
                btnDeal.Enabled = true;
                lblWinAmount.Text = win.ToString();
                roundEnd = true;
            }
            else if (computerSum == 21)
            {
                MessageBox.Show("Dealer Blackjack, Draw!!");
                ++draw;
                btnDeal.Enabled = true;
                lblTieAmount.Text = draw.ToString();
                roundEnd = true;
            }
            else if (computerSum > playerSum)
            {
                MessageBox.Show("Dealer Win!!");
                ++loss;
                btnDeal.Enabled = true;
                lblLossesAmount.Text = loss.ToString();
                roundEnd = true;
            }
            else
            {
                MessageBox.Show("Player Wins!!");
                ++win;
                btnDeal.Enabled = true;
                lblWinAmount.Text = win.ToString();
                roundEnd = true;
            }
        }

        private void Stay()
        {
            btnHit.Enabled = false;
            btnStay.Enabled = false;

            c2.Image = computer.Cards[1].Image;
            computer.AddValue(computer.Cards[1], ref computerSum);

            lblComputerScore.Text = computerSum.ToString();

            if (computerHand != maxCardsInhand)
            {
                if (computerSum >= 17)
                {
                    CheckScore();
                    return;
                }

                while (roundEnd == false && computerSum < 17)
                {
                    computer.Cards.Add(deck.DrawCard(computer));
                    computer.AddValue(deck.DrawCard(computer), ref computerSum);

                    lblComputerScore.Text = computerSum.ToString();

                    if (computerHand == 2)
                    {
                        CreateComputerPB(c3);
                    }
                    else if (computerHand == 3)
                    {
                        CreateComputerPB(c4);
                    }
                    else if (computerHand == 4)
                    {
                        CreateComputerPB(c5);
                    }

                    ++computerHand;
                }
                CheckScore();
            }
            else
            {
                MessageBox.Show("Computer has max number of cards!");
            }
        }

        private void CreatePlayerPB(PictureBox pb)
        {
            pb = new PictureBox
            {
                Location = new System.Drawing.Point(playerX + x, playerY - y),
                Size = new System.Drawing.Size(97, 89),
                TabStop = false,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = deck.DrawCard(player).Image
            };
            this.Controls.Add(pb);
            x += 20;
            y += 20;           
        }

        private void CreateComputerPB(PictureBox pb)
        {
            pb = new PictureBox
            {
                Location = new System.Drawing.Point(computerX - z, computerY),
                Size = new System.Drawing.Size(97, 89),
                TabStop = false,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = deck.DrawCard(computer).Image
            };
            this.Controls.Add(pb);
            z += 20;
        }

        private void ClearCards()
        {
            if (p1 != null)
            {
                p1.Dispose();
            }
            if (p2 != null)
            {
                p2.Dispose();
            }
            if (p3 != null)
            {
                p3.Dispose();
            }
            if (p4 != null)
            {
                p4.Dispose();
            }
            if (p5 != null)
            {
                p5.Dispose();
            }
            if (c1 != null)
            {
                c1.Dispose();
            }
            if (c2 != null)
            {
                c2.Dispose();
            }
            if (c3 != null)
            {
                c3.Dispose();
            }
            if (c4 != null)
            {
                c4.Dispose();
            }
            if (c5 != null)
            {
                c5.Dispose();
            }
        }
    }
}