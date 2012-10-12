using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class parent : Form
    {
        bool player = false; //Var. Player oznacava koji igrac igra, 0--prvi igrac, 1--drugi igrac
        short taken1 = 0; //Var. taken oznacava koje dugme(1-9) je vec odigrano, 0 nije zauzeto, 1 zauzeto sa X, 2 zauzeto sa O
        short taken2 = 0; //short koristim da smanjim kolicinu koristene memorije
        short taken3 = 0;
        short taken4 = 0;
        short taken5 = 0;
        short taken6 = 0;
        short taken7 = 0;
        short taken8 = 0;
        short taken9 = 0;

        public parent()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (taken1 == 0) // ako polje nije iskoristeno, moze se postaviti
            {
                btn1.Text = setBtn();
                changePlayer();
                if (player == false)
                {
                    taken1 = 1;
                }
                if (player == true)
                {
                    taken1 = 2;
                }
                changePlayer();
            }
            checkState();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (taken2 == 0) // ako polje nije iskoristeno, moze se postaviti
            {
                btn2.Text = setBtn();
                changePlayer();
                if (player == false)
                {
                    taken2 = 1;
                }
                if (player == true)
                {
                    taken2 = 2;
                }
                changePlayer();
            }

            checkState();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (taken3 == 0) // ako polje nije iskoristeno, moze se postaviti
            {
                btn3.Text = setBtn();
                changePlayer();
                if (player == false)
                {
                    taken3 = 1;
                }
                if (player == true)
                {
                    taken3 = 2;
                }
                changePlayer();
            }
            checkState();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (taken6 == 0) // ako polje nije iskoristeno, moze se postaviti
            {
                btn6.Text = setBtn();
                changePlayer();
                if (player == false)
                {
                    taken6 = 1;
                }
                if (player == true)
                {
                    taken6 = 2;
                }
                changePlayer();
            }
            checkState();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (taken5 == 0) // ako polje nije iskoristeno, moze se postaviti
            {
                btn5.Text = setBtn();
                changePlayer();
                if (player == false)
                {
                    taken5 = 1;
                }
                if (player == true)
                {
                    taken5 = 2;
                }
                changePlayer();
            }
            checkState();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (taken4 == 0) // ako polje nije iskoristeno, moze se postaviti
            {
                btn4.Text = setBtn();
                changePlayer();
                if (player == false)
                {
                    taken4 = 1;
                }
                if (player == true)
                {
                    taken4 = 2;
                }
                changePlayer();
            }
            checkState();

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (taken7 == 0) // ako polje nije iskoristeno, moze se postaviti
            {
                btn7.Text = setBtn();
                changePlayer();
                if (player == false)
                {
                    taken7 = 1;
                }
                if (player == true)
                {
                    taken7 = 2;
                }
                changePlayer();
            }
            checkState();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (taken8 == 0) // ako polje nije iskoristeno, moze se postaviti
            {
                btn8.Text = setBtn();
                changePlayer();
                if (player == false)
                {
                    taken8 = 1;
                }
                if (player == true)
                {
                    taken8 = 2;
                }
                changePlayer();
            }
            checkState();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (taken9 == 0) // ako polje nije iskoristeno, moze se postaviti
            {
                btn9.Text = setBtn();
                changePlayer();
                if (player == false)
                {
                    taken9 = 1;
                }
                if (player == true)
                {
                    taken9 = 2;
                }
                changePlayer();
            }
            checkState();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            setupForGame();
        }
        private void setupForGame()
        {
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = true;
            btn6.Visible = true;
            btn7.Visible = true;
            btn8.Visible = true;
            btn9.Visible = true;

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            player = false;//postavit na prvog igraca


            lblWelcome.Visible = false;
            btnYes.Visible = false;
            btnExit.Visible = false;
            lblCurrentPlayer.Visible = true;

        }

        private void changePlayer()//mjenja trenutnog igraca
        {
            if (player == true)
            {
                player = false;
                lblCurrentPlayer.Text = "Player: 2(O)";
            }
            else
            {
                
                    player = true;
                    lblCurrentPlayer.Text = "Player: 1(X)";
            }
        }
        private string setBtn()
        {
            if (player == true)
            {
                changePlayer();
                return "O";
            }
            else if (player == false)
            {
                changePlayer();
                return "X";
            }
            return "";
        }

        private void checkState()
        {
            if (taken1 == 1 && taken2 == 1 && taken3 == 1)
            {
                MessageBox.Show("Congrats, player 1(X)!!!\n You WON!", "Yaay!");
                setMainMenu();
            }
            if (taken1 == 2 && taken2 == 2 && taken3 == 2)
            {
                MessageBox.Show("Congrats, player 2(O)!!!\n You WON!", "Yaay!");
                setMainMenu();
            }
            if (taken4 == 1 && taken5 == 1 && taken6 == 1)
            {
                MessageBox.Show("Congrats, player 1(X)!!!\n You WON!", "Yaay!");
                setMainMenu();
            }
            if (taken4 == 2 && taken5 == 2 && taken6 == 2)
            {
                MessageBox.Show("Congrats, player 2(O)!!!\n You WON!", "Yaay!");
                setMainMenu();
            }
            if (taken7 == 1 && taken8 == 1 && taken9 == 1)
            {
                MessageBox.Show("Congrats, player 1(X)!!!\n You WON!", "Yaay!");
                setMainMenu();
            }
            if (taken7 == 2 && taken8 == 2 && taken9 == 2)
            {
                MessageBox.Show("Congrats, player 1(X)!!!\n You WON!", "Yaay!");
                setMainMenu();
            }
            

            /*
             * 
             * 
             * Horizontalno player 1 i 2
             * 
             * */
            if (taken1 == 1 && taken4 == 1 && taken7 == 1)
            {
                MessageBox.Show("Congrats, player 1(X)!!!\n You WON!", "Yaay!");
                setMainMenu();
            }
            if (taken2 == 1 && taken5 == 1 && taken8 == 1)
            {
                MessageBox.Show("Congrats, player 1(X)!!!\n You WON!", "Yaay!");
                setMainMenu();
            }
            if (taken3 == 1 && taken6 == 1 && taken9 == 1)
            {
                MessageBox.Show("Congrats, player 1(X)!!!\n You WON!", "Yaay!");
                setMainMenu();
            }


            if (taken1 == 2 && taken4 == 2 && taken7 == 2)
            {
                MessageBox.Show("Congrats, player 2(O)!!!\n You WON!", "Yaay!");
                setMainMenu();
            }
            if (taken2 == 2 && taken5 == 2 && taken8 == 2)
            {
                MessageBox.Show("Congrats, player 2(O)!!!\n You WON!", "Yaay!");
                setMainMenu();
            }
            if (taken3 == 2 && taken6 == 2 && taken9 == 2)
            {
                MessageBox.Show("Congrats, player 2(O)!!!\n You WON!", "Yaay!");
                setMainMenu();
            }


            /*
             * 
             * Vertikalno zavrseno!
             * 
             * 
             * */

            if (taken1 == 1 && taken5 == 1 && taken9 == 1)
            {
                MessageBox.Show("Congrats, player 1(X)!!!\n You WON!", "Yaay!");
                setMainMenu();
            }
            if (taken3 == 1 && taken5 == 1 && taken7 == 1)
            {
                MessageBox.Show("Congrats, player 1(X)!!!\n You WON!", "Yaay!");
                setMainMenu();
            }

            if (taken1 == 2 && taken5 == 2 && taken9 == 2)
            {
                MessageBox.Show("Congrats, player 2(O)!!!\n You WON!", "Yaay!");
                setMainMenu();
            }
            if (taken3 == 2 && taken5 == 2 && taken7 == 2)
            {
                MessageBox.Show("Congrats, player 2(O)!!!\n You WON!", "Yaay!");
                setMainMenu();
            }



        }
        private void setMainMenu()
        {

            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
            btn4.Visible = false;
            btn5.Visible = false;
            btn6.Visible = false;
            btn7.Visible = false;
            btn8.Visible = false;
            btn9.Visible = false;

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            player = false;//postavit na prvog igraca


            lblWelcome.Visible = true;
            btnYes.Visible = true;
            btnExit.Visible = true;

            lblCurrentPlayer.Visible = false;
            taken1 = 0; //Var. taken oznacava koje dugme(1-9) je vec odigrano, 0 nije zauzeto, 1 zauzeto sa X, 2 zauzeto sa O
            taken2 = 0;
            taken3 = 0;
            taken4 = 0;
            taken5 = 0;
            taken6 = 0;
            taken7 = 0;
            taken8 = 0;
            taken9 = 0;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuNewGame_Click(object sender, EventArgs e)
        {
            setupForGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
