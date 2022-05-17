using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winter_Game.Properties;

namespace Winter_Game
{
    public partial class FTea : Form
    {
        public FTea()
        {
            InitializeComponent();
        }

        Random random = new Random();

        public static int gAll;
        public static int wantTea;
        public static int isTready = 0;


        public static int good;
        public static int goodTea;
        public static int goodKip;
        public static int goodSugar;
        public static int goodLemon;
        public static int goodMilk;


        static int itogtea;
        static int sachar;
        static int limon;
        static int moloko;
        static int ready = 3;
        static int g1;
        public static int g2;
        static int g3;
        static int g4;
        static int g5;
        static int tea1;
        static int tea2;
        static int tea3;
        static int tea4;
        static int tea5;
        static int tea6;
        static int tea7;
        static int tea8;
        static int tea9;
        static int kolMilk = 0;


        private void pictureBoxG1_Click(object sender, EventArgs e)
        {

        }

        

        private void lblMilk_Click(object sender, EventArgs e)
        {

        }

        private void FTea_MouseEnter(object sender, EventArgs e)
        {
           
            
        }

        private void FTea_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Minute.Text) != 0 && Convert.ToInt32(Second.Text) != 0)
            {
                timerTime1.Enabled = true;
            }

            do
            {

                tea1 = random.Next(1, 10);
                tea2 = random.Next(1, 10);
                tea3 = random.Next(1, 10);
                tea4 = random.Next(1, 10);
                tea5 = random.Next(1, 10);
                tea6 = random.Next(1, 10);
                tea7 = random.Next(1, 10);
                tea8 = random.Next(1, 10);
                tea9 = random.Next(1, 10);


            } while (tea1 == tea2 || tea1 == tea3 || tea1 == tea4 || tea1 == tea5 || tea1 == tea6 || tea1 == tea7 || tea1 == tea8 || tea1 == tea9
                     || tea2 == tea3 || tea2 == tea4 || tea2 == tea5 || tea2 == tea6 || tea2 == tea7 || tea2 == tea8 || tea2 == tea9
                     || tea3 == tea4 || tea3 == tea5 || tea3 == tea6 || tea3 == tea7 || tea3 == tea8 || tea3 == tea9
                      || tea4 == tea5 || tea4 == tea6 || tea4 == tea7 || tea4 == tea8 || tea4 == tea9
                      || tea5 == tea6 || tea5 == tea7 || tea5 == tea8 || tea5 == tea9
                      || tea6 == tea7 || tea6 == tea8 || tea6 == tea9
                      || tea7 == tea8 || tea7 == tea9
                       || tea8 == tea9);


            Paket(pictureBoxT1, tea1);
            Paket(pictureBoxT2, tea2);
            Paket(pictureBoxT3, tea3);
            Paket(pictureBoxT4, tea4);
            Paket(pictureBoxT5, tea5);
            Paket(pictureBoxT6, tea6);
            Paket(pictureBoxT7, tea7);
            Paket(pictureBoxT8, tea8);
            Paket(pictureBoxT9, tea9);




            // Формирование заказа




            // Заказ чая

            textBoxOrder.Text = "Я бы хотел ";
            wantTea = random.Next(1, 10);
            stringTea(textBoxOrder, wantTea);

            // Количество сахара

            sachar = random.Next(0, 5);


            if (sachar == 0)
            {
                pictureBoxG3.Visible = true;
                g3 = 1;

                if (g1 + g2 + g3 + g4 + g5 == 5)
                {
                    pictureBoxGAll.Visible = true;
                    gAll = 1;
                    buttonGotov.Enabled = true;
                    buttonGotov.Visible = true;
                }
                textBoxOrder.Text = textBoxOrder.Text + " Думаю, сахар мне не нужен.";
            }
            if (sachar == 1 || sachar == 2)
            {
                textBoxOrder.Text = textBoxOrder.Text + " Добавьте к чаю немного сахара.";
            }
            if (sachar == 3 || sachar == 4)
            {
                textBoxOrder.Text = textBoxOrder.Text + " Добавьте к чаю побольше сахара. Я сластена.";
            }


            // Количество лимона


            limon = random.Next(0, 5);
            

            if (limon == 0)
            {
                pictureBoxG4.Visible = true;
                g4 = 1;

                if (g1 + g2 + g3 + g4 + g5 == 5)
                {
                    pictureBoxGAll.Visible = true;
                    gAll = 1;
                    buttonGotov.Enabled = true;
                    buttonGotov.Visible = true;
                }

                textBoxOrder.Text = textBoxOrder.Text + " Думаю, лимон мне не нужен.";
            }
            if (limon == 1 || limon == 2)
            {
                textBoxOrder.Text = textBoxOrder.Text + " Добавьте к чаю пару долек лимона.";
            }
            if (limon == 3 || limon == 4)
            {
                textBoxOrder.Text = textBoxOrder.Text + " Добавьте к чаю побольше лимона. Я люблю кисленькое.";
            }


            // Количество молока





            moloko = random.Next(0, 6);

            if (moloko == 0)
            {
                pictureBoxG5.Visible = true;
                g5 = 1;

                if (g1 + g2 + g3 + g4 + g5 == 5)
                {
                    pictureBoxGAll.Visible = true;
                    gAll = 1;
                    buttonGotov.Enabled = true;
                    buttonGotov.Visible = true;
                }
                textBoxOrder.Text = textBoxOrder.Text + " Думаю, молоко мне не нужно.";
            }
            if (moloko == 1 || moloko == 2)
            {
                textBoxOrder.Text = textBoxOrder.Text + " Добавьте чуть-чуть молока.";
            }
            if (moloko == 3 || moloko == 4)
            {
                textBoxOrder.Text = textBoxOrder.Text + " Добавьте около трети-четверти кружки молока.";
            }
            if (moloko == 5)
            {
                textBoxOrder.Text = textBoxOrder.Text + " Разбавьте чай напополам с молоком.";
            }







        }

        private void stringTea(TextBox text, int wtea)
        {
            if (wtea == 1)
            {
                text.Text = text.Text + "чего-то крепкого и бодрящего. С нотками настоящего английского чая. ";
            }
            if (wtea == 2)
            {
                text.Text = text.Text + "чего-нибудь классически английского. Я плохо спал сегодня и на завтрак хочу выпить бодрящего чая.";
            }
            if (wtea == 3)
            {
                text.Text = text.Text + "чего-то что напомнило бы мне о приближающейся весне. Хочу вновь вспомнить картину цветущей природы";
            }
            if (wtea == 4)
            {
                text.Text = text.Text + "что-то, что напомнит мне о моих далеких путешествиях. На Шри-Ланке я пил такой чай с деловыми партнерами. Хочу опять вспомнить эту удивительную страну.";
            }
            if (wtea == 5)
            {
                text.Text = text.Text + "чего-нибудь дающего заряд энергии и позитива на целый день. Этакую искру, дающую свет в эти серые будни.";
            }
            if (wtea == 6)
            {
                text.Text = text.Text + "какой-нибудь ягодный чай. Эти ягоды росли на моей даче. Я срывал их с куста и добавлял в чай, но, часто колол себе руки о шипы на втеках.";
            }
            if (wtea == 7)
            {
                text.Text = text.Text + "чего-то сладенького. В детстве я пил этот чай, когда болел. Конкртено таких пакетиков у нас не было, но бабушка добавляла в чай нужный продукт и вкус был таким же";
            }
            if (wtea == 8)
            {
                text.Text = text.Text + "какой - нибудь ягодный чай. В детстве я любил собирать эти ягоды на даче, а потом добавлять в чай. Приходилось нагибаться к самому краю грядки, но оно того стоило.";
            }
            if (wtea == 9)
            {
                text.Text = text.Text + "чего-то сладкого, но не слишком. Этот чай имеет кремовый вкус, потому что основной ингредиент его часто используется в кремах и другой кулинарии.";
            }
        }

        private void Paket(PictureBox paket, int tea)
        {
            if (tea == 1)
            {
                paket.Image = Resources.grey;
            }
            if (tea == 2)
            {
                paket.Image = Resources.breakfast;
            }
            if (tea == 3)
            {
                paket.Image = Resources.spring;
            }
            if (tea == 4)
            {
                paket.Image = Resources.ceylon;
            }
            if (tea == 5)
            {
                paket.Image = Resources.lemon;
            }
            if (tea == 6)
            {
                paket.Image = Resources.barberry;
            }
            if (tea == 7)
            {
                paket.Image = Resources.honey;
            }
            if (tea == 8)
            {
                paket.Image = Resources.strawberry;
            }
            if (tea == 9)
            {
                paket.Image = Resources.vanila;
            }
        }


        private void Choose(int tea, PictureBox paket)
        {
            if (paket.Image == Resources.grey)
            {
                tea = 1;
            }
            if (paket.Image == Resources.breakfast)
            {
                tea = 2;
            }
            if (paket.Image == Resources.spring)
            {
                tea = 3;
            }
            if (paket.Image == Resources.ceylon)
            {
                tea = 4;
            }
            if (paket.Image == Resources.lemon)
            {
                tea = 5;
            }
            if (paket.Image == Resources.barberry)
            {
                tea = 6;
            }
            if (paket.Image == Resources.honey)
            {
                tea = 7;
            }
            if (paket.Image == Resources.strawberry)
            {
                tea = 8;
            }
            if (paket.Image == Resources.vanila)
            {
                tea = 9;
            }
        }




        private void timerTime1_Tick(object sender, EventArgs e)
        {
            Second.Text = Convert.ToString(Convert.ToInt32(Second.Text) - 1);
            if (Convert.ToInt32(Second.Text) < 10)
            {
                if (Second.Text != "00")
                {
                    Second.Text = "0" + Convert.ToString(Convert.ToInt32(Second.Text));
                }
            }
            if (Convert.ToInt32(Second.Text) <= 0)
            {
                Second.Text = "99";
                Minute.Text = Convert.ToString(Convert.ToInt32(Minute.Text) - 1);
            }
            if (Convert.ToInt32(Minute.Text) == 0)
            {
                timerTime1.Enabled = false;
                Minute.Text = "0";
                Second.Text = "00";
            }

            if (Convert.ToInt32(Second.Text) == 0 && Convert.ToInt32(Minute.Text) == 0)
            {
                MessageBox.Show("Время вышло!!!");
                paketsEnab();
                bMilk.Enabled = false;
                bLimon.Enabled = false;
                bChainik.Enabled = false;
                bSugar.Enabled = false;

                buttonGotov.Enabled = true;

            }
        }

       
        private void bKipuatok_Click(object sender, EventArgs e)
        {
            ready = ready - 1;

            if (ready == 2)
            {

                bChainik.Enabled = false;
                bChainik.Text = "Готовится";
                bChainik.ForeColor = Color.Gray;
                timerKipuatok.Enabled = true;
            }


            if (ready == 1)
            {

                bChainik.Enabled = false;
                pictureBoxG1.Visible = true;
                g1 = 1;
                if (g1 + g2 + g3 + g4 + g5 == 5)
                {
                    pictureBoxGAll.Visible = true;
                    gAll = 1;
                    buttonGotov.Enabled = true;
                    buttonGotov.Visible = true;
                }
            }
        }

        private void timerKipuatok_Tick(object sender, EventArgs e)
        {
            bChainik.ForeColor = Color.Green;
            bChainik.Enabled = true;
            bChainik.Text = "Готов";
            timerKipuatok.Enabled = false;
        }

        private void bLimon_Click(object sender, EventArgs e)
        {
            pictureBoxG4.Visible = true;
            g4 = 1;

            if (g1 + g2 + g3 + g4 + g5 == 5)
            {
                pictureBoxGAll.Visible = true;
                gAll = 1;
                buttonGotov.Enabled = true;
                buttonGotov.Visible = true;
            }

            if (Convert.ToInt32(lblLimon.Text) >= 7)
            {
                lblLimon.Text = "8";
                label5.Visible = true;
            }
            else
            {
                lblLimon.Text = Convert.ToString(Convert.ToInt32(lblLimon.Text) + 1);
            }
        }

        private void bSugar_Click(object sender, EventArgs e)
        {
            pictureBoxG3.Visible = true;
            g3 = 1;

            if (g1 + g2 + g3 + g4 + g5 == 5)
            {
                pictureBoxGAll.Visible = true;
                gAll = 1;
                buttonGotov.Enabled = true;
                buttonGotov.Visible = true;
            }

            if (Convert.ToInt32(lblSugar.Text) >= 7)
            {
                lblSugar.Text = "8";
                label8.Visible = true;
            }
            else
            {
                lblSugar.Text = Convert.ToString(Convert.ToInt32(lblSugar.Text) + 1);
            }
        }

        private void bMilk_Click(object sender, EventArgs e)
        {
            pictureBoxG5.Visible = true;
            g5 = 1;

            if (g1 + g2 + g3 + g4 + g5 == 5)
            {
                pictureBoxGAll.Visible = true;
                gAll = 1;
                buttonGotov.Enabled = true;
                buttonGotov.Visible = true;
            }


            if (lblMilk.Text == "1/2")
            {
                lblMilk.Text = "1/2";
                label10.Visible = true;
                kolMilk = 5;
            }
            else
            {
                if (lblMilk.Text == "1/3")
                {
                    lblMilk.Text = "1/2";
                    kolMilk = 5;
                }
                else
                {
                    if (lblMilk.Text == "1/4")
                    {
                        lblMilk.Text = "1/3";
                        kolMilk = 4;
                    }
                    else
                        if(lblMilk.Text == "1/8")
                        {
                            lblMilk.Text = "1/4";
                            kolMilk = 3;
                        }
                        else
                             if (lblMilk.Text == "1/16")
                             {
                                lblMilk.Text = "1/8";
                                kolMilk = 2;
                             }
                             else
                                 if (lblMilk.Text == "0")
                                 {
                                     lblMilk.Text = "1/16";
                                     kolMilk = 1;
                                 }
                }
            }
        }

        private void g2Ready()
        {
            pictureBoxG2.Visible = true;
            g2 = 1;
            if (g1 + g2 + g3 + g4 + g5 == 5)
            {
                pictureBoxGAll.Visible = true;
                gAll = 1;
                buttonGotov.Enabled = true;
                buttonGotov.Visible = true;
            }
        }

        private void paketsEnab()
        {
            pictureBoxT1.Enabled = false;
            pictureBoxT2.Enabled = false;
            pictureBoxT3.Enabled = false;
            pictureBoxT4.Enabled = false;
            pictureBoxT5.Enabled = false;
            pictureBoxT6.Enabled = false;
            pictureBoxT7.Enabled = false;
            pictureBoxT8.Enabled = false;
            pictureBoxT9.Enabled = false;

            pictureBoxStop1.Visible = true;
            pictureBoxStop1.BackgroundImage = pictureBoxT1.Image;
            pictureBoxStop2.Visible = true;
            pictureBoxStop2.BackgroundImage = pictureBoxT2.Image;
            pictureBoxStop3.Visible = true;
            pictureBoxStop3.BackgroundImage = pictureBoxT3.Image;
            pictureBoxStop4.Visible = true;
            pictureBoxStop4.BackgroundImage = pictureBoxT4.Image;
            pictureBoxStop5.Visible = true;
            pictureBoxStop5.BackgroundImage = pictureBoxT5.Image;
            pictureBoxStop6.Visible = true;
            pictureBoxStop6.BackgroundImage = pictureBoxT6.Image;
            pictureBoxStop7.Visible = true;
            pictureBoxStop7.BackgroundImage = pictureBoxT7.Image;
            pictureBoxStop8.Visible = true;
            pictureBoxStop8.BackgroundImage = pictureBoxT8.Image;
            pictureBoxStop9.Visible = true;
            pictureBoxStop9.BackgroundImage = pictureBoxT9.Image;
        }

        private void pictureBoxT1_Click(object sender, EventArgs e)
        {
            Choose(tea1, pictureBoxT1);
            g2Ready();
            paketsEnab();
            itogtea = tea1;
        }

        private void pictureBoxT2_Click(object sender, EventArgs e)
        {
            Choose(tea2, pictureBoxT2);
            g2Ready();
            paketsEnab();
            itogtea = tea2;
        }

        private void pictureBoxT3_Click(object sender, EventArgs e)
        {
            Choose(tea3, pictureBoxT3);
            g2Ready();
            paketsEnab();
            itogtea = tea3;
        }

        private void pictureBoxT4_Click(object sender, EventArgs e)
        {
            Choose(tea4, pictureBoxT4);
            g2Ready();
            paketsEnab();
            itogtea = tea4;
        }

        private void pictureBoxT5_Click(object sender, EventArgs e)
        {
            Choose(tea5, pictureBoxT5);
            g2Ready();
            paketsEnab();
            itogtea = tea5;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Choose(tea6, pictureBoxT6);
            g2Ready();
            paketsEnab();
            itogtea = tea6;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Choose(tea7, pictureBoxT7);
            g2Ready();
            paketsEnab();
            itogtea = tea7;
        }

        private void pictureBoxT8_Click(object sender, EventArgs e)
        {
            Choose(tea8, pictureBoxT8);
            g2Ready();
            paketsEnab();
            itogtea = tea8;
        }

        private void pictureBoxT9_Click(object sender, EventArgs e)
        {
            Choose(tea9, pictureBoxT9);
            g2Ready();
            paketsEnab();
            itogtea = tea9;
        }

        private void buttonGotov_Click(object sender, EventArgs e)
        {
            FOrder order = new FOrder();
            isTready = 1;
            this.Hide();



            // Оценка:



            // Чайного пакетика


            if (itogtea == wantTea)
            {
                goodTea = 10;
            }
            else
            {
                goodTea = 0;  // Для наглядности
            }


            if (g1 == 1)
            {
                goodKip = 10;
            }
            else
            {
                goodKip = 0;  // Для наглядности
            }


            if (goodTea == 10 && goodKip == 10)
            {

                // Оценка сахара

                if (Convert.ToInt32(lblSugar.Text) >= sachar - 1 && Convert.ToInt32(lblSugar.Text) <= sachar + 1)
                {
                    goodSugar = 10;
                }
                else
                if (Convert.ToInt32(lblSugar.Text) >= sachar - 2 && Convert.ToInt32(lblSugar.Text) < sachar - 1)
                {
                    goodSugar = 5;
                }
                else
                if (Convert.ToInt32(lblSugar.Text) > sachar + 1 && Convert.ToInt32(lblSugar.Text) <= sachar + 2)
                {
                    goodSugar = 5;
                }
                else
                {
                    goodSugar = 0;
                }


                // Оценка лимона

                if (Convert.ToInt32(lblLimon.Text) >= limon - 1 && Convert.ToInt32(lblSugar.Text) <= limon + 1)
                {
                    goodLemon = 10;
                }
                else
                if (Convert.ToInt32(lblLimon.Text) >= limon - 2 && Convert.ToInt32(lblLimon.Text) < limon - 1)
                {
                    goodLemon = 5;
                }
                else
                if (Convert.ToInt32(lblLimon.Text) > limon + 1 && Convert.ToInt32(lblLimon.Text) <= limon + 2)
                {
                    goodLemon = 5;
                }
                else
                {
                    goodLemon = 0;
                }



                // Оценка молока



                if (kolMilk >= moloko - 1 && kolMilk <= moloko + 1)
                {
                    goodMilk = 10;
                }
                else
                if (kolMilk >= moloko - 2 && kolMilk < moloko - 1)
                {
                    goodMilk = 5;
                }
                else
                if (kolMilk > moloko  + 1 && kolMilk <= moloko + 2)
                {
                    goodMilk = 5;
                }
                else
                {
                    goodMilk = 0;
                }
            }



            good = goodKip + goodTea + goodLemon + goodSugar + goodMilk;
            ready = 3;

            this.Close();
        }

        private void pictureBoxStop1_Click(object sender, EventArgs e)
        {

        }
    }
}
