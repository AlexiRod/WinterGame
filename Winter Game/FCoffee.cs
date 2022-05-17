using System;
using System.Threading;
using System.Windows.Forms;
using Winter_Game.Properties;

namespace Winter_Game
{
    public partial class FCoffee : Form
    {
        public FCoffee()
        {
            InitializeComponent();
        }

        static int mil = 1;
        static int sli = 1;
        static int temp = 0;

        
        public static int isCready = 0;
        public static int countC;
        public static int good;




        private void FCoffee_Load(object sender, EventArgs e)
        {
            mil = 1;
            sli = 1;
            good = 0;
            temp = 0;
            isCready = 0;
        }
        private void pictureBoxK2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void Marshmellow()
        {
            if (pictureBoxMilk.Top < pictureBoxSlivki.Top)
            {
                pictureBoxM1.Top = pictureBoxMilk.Top - pictureBoxM1.Height;
                pictureBoxM2.Top = pictureBoxMilk.Top - pictureBoxM1.Height;
                pictureBoxM3.Top = pictureBoxMilk.Top - pictureBoxM1.Height;
                pictureBoxM4.Top = pictureBoxMilk.Top - pictureBoxM1.Height;
                pictureBoxM5.Top = pictureBoxMilk.Top - pictureBoxM1.Height;
                pictureBoxM6.Top = pictureBoxMilk.Top - pictureBoxM1.Height;
            }
            else
            {
                pictureBoxM1.Top = pictureBoxSlivki.Top - pictureBoxM1.Height;
                pictureBoxM2.Top = pictureBoxSlivki.Top - pictureBoxM1.Height;
                pictureBoxM3.Top = pictureBoxSlivki.Top - pictureBoxM1.Height;
                pictureBoxM4.Top = pictureBoxSlivki.Top - pictureBoxM1.Height;
                pictureBoxM5.Top = pictureBoxSlivki.Top - pictureBoxM1.Height;
                pictureBoxM6.Top = pictureBoxSlivki.Top - pictureBoxM1.Height;
            }
        }


        private void bMilk_Click(object sender, EventArgs e)
        {
            if (mil == 1)
            {
                pictureBoxMilk.Visible = true;
                lblMilk.Text = "40";
                mil = 0;
            }

            mil = 0;

            pictureBoxMilk.Visible = true;
            pictureBoxLozhka.Visible = false;
            pictureBoxKastrulya.Image = Resources.Кастрюля;
            pictureBoxMilk.Height = pictureBoxMilk.Height + 1;
            pictureBoxMilk.Top = pictureBoxMilk.Top - 1;
            if (Convert.ToInt32(lblMilk.Text) >= 1100)
            {
                pictureBoxMilk.Top = 255;
                pictureBoxMilk.Height = 209;
                label5.Visible = true;
                lblMilk.Text = "1100";
            }
            else
                lblMilk.Text = Convert.ToString(Convert.ToUInt32(lblMilk.Text) + 10);

            if (pictureBoxSlivki.Visible == true)
            {
                pictureBoxK1.BackgroundImage = Resources.Сливки;
                pictureBoxK2.BackgroundImage = Resources.Сливки;
                pictureBoxK3.BackgroundImage = Resources.Сливки;
            }
            if (pictureBoxSlivki.Visible == true)
            {
                pictureBoxKa1.BackgroundImage = Resources.Сливки;
                pictureBoxKa2.BackgroundImage = Resources.Сливки;
                pictureBoxKa3.BackgroundImage = Resources.Сливки;
            }

            Marshmellow();
        }

        private void bSlivki_Click(object sender, EventArgs e)
        {
            if (sli == 1)
            {
                pictureBoxSlivki.Visible = true;
                lblSlivki.Text = "40";
                sli = 0;
            }

            sli = 0;

            pictureBoxSlivki.Visible = true;
            pictureBoxLozhka.Visible = false;
            pictureBoxKastrulya.Image = Resources.Кастрюля;
            pictureBoxSlivki.Height = pictureBoxSlivki.Height + 1;
            pictureBoxSlivki.Top = pictureBoxSlivki.Top - 1;
            if (Convert.ToInt32(lblSlivki.Text) >= 1100)
            {
                pictureBoxSlivki.Top = 260;
                pictureBoxSlivki.Height = 210;
                label7.Visible = true;
                lblSlivki.Text = "1100";
            }
            else
                lblSlivki.Text = Convert.ToString(Convert.ToUInt32(lblSlivki.Text) + 10);

            if (pictureBoxSlivki.Visible == true)
            {
                pictureBoxK1.BackgroundImage = Resources.Сливки;
                pictureBoxK2.BackgroundImage = Resources.Сливки;
                pictureBoxK3.BackgroundImage = Resources.Сливки;
            }
            if (pictureBoxSlivki.Visible == true)
            {
                pictureBoxKa1.BackgroundImage = Resources.Сливки;
                pictureBoxKa2.BackgroundImage = Resources.Сливки;
                pictureBoxKa3.BackgroundImage = Resources.Сливки;
            }

            Marshmellow();

        }

        private void bKoritsa_Click(object sender, EventArgs e)
        {
            if (pictureBoxMilk.Visible == false)
            {
                MessageBox.Show("Сначала налейте молоко или сливки!");
            }
            else
            {
                pictureBoxLozhka.Visible = false;
                pictureBoxKastrulya.Image = Resources.Кастрюля;

                if (Convert.ToInt32(lblKoritsa.Text) >= 3)
                {
                    pictureBoxK3.Visible = true;
                    lblKoritsa.Text = "4";
                    label8.Visible = true;
                }
                else
                {
                    lblKoritsa.Text = Convert.ToString(Convert.ToInt32(lblKoritsa.Text) + 1);
                }



                if (Convert.ToInt32(lblKoritsa.Text) == 1)
                {
                    pictureBoxK1.Visible = true;
                    this.pictureBoxK1.BringToFront();
                }

                if (Convert.ToInt32(lblKoritsa.Text) == 2)
                {
                    pictureBoxK2.Visible = true;
                    this.pictureBoxK2.BringToFront();
                }
                if (Convert.ToInt32(lblKoritsa.Text) == 4)
                {
                    pictureBoxK3.Visible = true;
                    this.pictureBoxK3.BringToFront();
                }

                if (pictureBoxSlivki.Visible == true)
                {
                    pictureBoxK1.BackgroundImage = Resources.Сливки;
                    pictureBoxK2.BackgroundImage = Resources.Сливки;
                    pictureBoxK3.BackgroundImage = Resources.Сливки;
                }
            }
        }

        private void bKakao_Click(object sender, EventArgs e)
        {
            if (pictureBoxMilk.Visible == false)
            {
                MessageBox.Show("Сначала налейте молоко или сливки!");
            }
            else
            {
                pictureBoxLozhka.Visible = false;
                pictureBoxKastrulya.Image = Resources.Кастрюля;

                if (Convert.ToInt32(lblKakao.Text) >= 14)
                {
                    pictureBoxKa3.Visible = true;
                    lblKakao.Text = "15";
                    label14.Visible = true;
                }
                else
                {
                    lblKakao.Text = Convert.ToString(Convert.ToInt32(lblKakao.Text) + 1);
                }



                if (Convert.ToInt32(lblKakao.Text) == 1)
                {
                    pictureBoxKa1.Visible = true;
                    this.pictureBoxKa1.BringToFront();
                }

                if (Convert.ToInt32(lblKakao.Text) == 7)
                {
                    pictureBoxKa2.Visible = true;
                    this.pictureBoxKa2.BringToFront();
                }
                if (Convert.ToInt32(lblKakao.Text) == 11)
                {
                    pictureBoxKa3.Visible = true;
                    this.pictureBoxKa3.BringToFront();
                }

                if (pictureBoxSlivki.Visible == true)
                {
                    pictureBoxKa1.BackgroundImage = Resources.Сливки;
                    pictureBoxKa2.BackgroundImage = Resources.Сливки;
                    pictureBoxKa3.BackgroundImage = Resources.Сливки;
                }
            }
        }

        private void bSgush_Click(object sender, EventArgs e)
        {
            if (pictureBoxMilk.Visible == false)
            {
                MessageBox.Show("Сначала налейте молоко или сливки!");
            }
            else
            {
                pictureBoxLozhka.Visible = true;
                pictureBoxKastrulya.Image = Resources.Кастрюля2;

                if (Convert.ToInt32(lblSgush.Text) >= 15)
                {
                    lblSgush.Text = "15";
                    label17.Visible = true;
                }
                else
                {
                    lblSgush.Text = Convert.ToString(Convert.ToUInt32(lblSgush.Text) + 1);
                }
            }
        }

        private void bMarsh_Click(object sender, EventArgs e)
        {
            if (pictureBoxMilk.Visible == false)
            {
                MessageBox.Show("Сначала налейте молоко или сливки!");
            }
            else
            {
                pictureBoxLozhka.Visible = false;
                pictureBoxKastrulya.Image = Resources.Кастрюля;


                if (Convert.ToInt32(lblMarsh.Text) >= 49)
                {
                    lblKakao.Text = "50";
                    label20.Visible = true;
                }
                else
                {
                    lblMarsh.Text = Convert.ToString(Convert.ToInt32(lblMarsh.Text) + 5);
                }

                if (Convert.ToInt32(lblMarsh.Text) == 5)
                {
                    pictureBoxM1.Visible = true;
                    this.pictureBoxM1.BringToFront();
                }

                if (Convert.ToInt32(lblMarsh.Text) == 15)
                {
                    pictureBoxM2.Visible = true;
                    this.pictureBoxM2.BringToFront();
                }
                if (Convert.ToInt32(lblMarsh.Text) == 25)
                {
                    pictureBoxM3.Visible = true;
                    this.pictureBoxM3.BringToFront();
                }
                if (Convert.ToInt32(lblMarsh.Text) == 35)
                {
                    pictureBoxM4.Visible = true;
                    this.pictureBoxM4.BringToFront();
                }
                if (Convert.ToInt32(lblMarsh.Text) == 40)
                {
                    pictureBoxM5.Visible = true;
                    this.pictureBoxM5.BringToFront();
                }
                if (Convert.ToInt32(lblMarsh.Text) == 49)
                {
                    pictureBoxM6.Visible = true;
                    this.pictureBoxM6.BringToFront();
                }


                Marshmellow();

            }
        }

        private void bTemp_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxTemp.Text) >= 1 && Convert.ToInt32(textBoxTemp.Text) <= 110)
            {
                temp = Convert.ToInt32(textBoxTemp.Text);
                MessageBox.Show("Температура установлена!");
            }
            else
                MessageBox.Show("Установите температуру от 1 до 110 градусов");
        }

        private void bVarka_Click(object sender, EventArgs e)
        {
            if (pictureBoxMilk.Visible == false)
            {
                MessageBox.Show("Налейте хотя бы молоко или сливки!");
            }
            else
            {
                pictureBoxLozhka.Visible = false;
                pictureBoxKastrulya.Image = Resources.Кастрюля;

                bMilk.Enabled = false;
                bKoritsa.Enabled = false;
                bMarsh.Enabled = false;
                bSgush.Enabled = false;
                bSlivki.Enabled = false;
                bKakao.Enabled = false;

                if (temp <= 0)
                {
                    MessageBox.Show("Задайте температуру больше нуля в окошке под кнопкой и нажмите 'Oк'");
                }
                else
                {
                    bTemp.Enabled = false;
                    bVarka.Enabled = false;
                    pictureBoxPlita.Visible = true;
                    MessageBox.Show("Варим какао...");
                    Thread.Sleep(4000);
                    MessageBox.Show("Напиток готов!");



                    // Mолоко

                    if (Convert.ToInt32(lblMilk.Text) >= 250 * countC - 50 && Convert.ToInt32(lblMilk.Text) <= 250 * countC + 50)
                    {
                        good = good + 10;
                    }
                    else
                    if (Convert.ToInt32(lblMilk.Text) > 250 * countC - 150 && Convert.ToInt32(lblMilk.Text) < 250 * countC - 50)
                    {
                        good = good + 5;

                    }
                    else
                    if (Convert.ToInt32(lblMilk.Text) > 250 * countC + 50 && Convert.ToInt32(lblMilk.Text) < 250 * countC + 150)
                    {
                        good = good + 5;
                    }
                    else
                    {
                        good = good + 0;
                    }

                    // Сливки


                    if (Convert.ToInt32(lblSlivki.Text) >= 250 * countC - 50 && Convert.ToInt32(lblSlivki.Text) <= 250 * countC + 50)
                    {
                        good = good + 10;
                    }
                    else
                    if (Convert.ToInt32(lblSlivki.Text) > 250 * countC - 150 && Convert.ToInt32(lblSlivki.Text) < 250 * countC - 50)
                    {
                        good = good + 5;
                    }
                    else
                    if (Convert.ToInt32(lblSlivki.Text) > 250 * countC + 50 && Convert.ToInt32(lblSlivki.Text) < 250 * countC + 150)
                    {
                        good = good + 5;
                    }
                    else
                    {
                        good = good + 0;
                    }


                    // Корица


                    if (Convert.ToInt32(lblKoritsa.Text) >= 1 * countC  && Convert.ToInt32(lblKoritsa.Text) <= 1 * countC)
                    {
                        good = good + 10;
                    }
                    else
                    if (Convert.ToInt32(lblKoritsa.Text) > 1 * countC - 3 && Convert.ToInt32(lblKoritsa.Text) < 1 * countC - 1)
                    {
                        good = good + 5;
                    }
                    if (Convert.ToInt32(lblKoritsa.Text) > 1 * countC + 1 && Convert.ToInt32(lblKoritsa.Text) < 1 * countC + 3)
                    {
                        good = good + 5;
                    }
                    else
                    {
                        good = good + 0;
                    }


                    // Какао


                    if (Convert.ToInt32(lblKakao.Text) >= 3 * countC - 3 && Convert.ToInt32(lblKakao.Text) <= 3 * countC + 3)
                    {
                        good = good + 10;
                    }
                    else
                    if (Convert.ToInt32(lblKakao.Text) > 3 * countC - 9 && Convert.ToInt32(lblKakao.Text) < 3 * countC - 3)
                    {
                        good = good + 5;
                    }
                    if (Convert.ToInt32(lblKakao.Text) > 3 * countC + 3 && Convert.ToInt32(lblKakao.Text) < 3 * countC + 9)
                    {
                        good = good + 5;
                    }
                    else
                    {
                        good = good + 0;
                    }


                    // Сгущенка


                    if (Convert.ToInt32(lblSgush.Text) >= 3 * countC - 3 && Convert.ToInt32(lblSgush.Text) <= 3 * countC + 3)
                    {
                        good = good + 10;
                    }
                    else
                    if (Convert.ToInt32(lblSgush.Text) > 3 * countC - 9 && Convert.ToInt32(lblSgush.Text) < 3 * countC - 3)
                    {
                        good = good + 5;
                    }
                    if (Convert.ToInt32(lblSgush.Text) > 3 * countC + 3 && Convert.ToInt32(lblSgush.Text) < 3 * countC + 9)
                    {
                        good = good + 5;
                    }
                    else
                    {
                        good = good + 0;
                    }


                    // Маршмеллоу



                    if (Convert.ToInt32(lblMarsh.Text) >= 15 * countC - 5 && Convert.ToInt32(lblMarsh.Text) <= 15 * countC + 5)
                    {
                        good = good + 10;
                    }
                    else
                    if (Convert.ToInt32(lblMarsh.Text) > 15 * countC - 15 && Convert.ToInt32(lblMarsh.Text) < 15 * countC - 5)
                    {
                        good = good + 5;
                    }
                    if (Convert.ToInt32(lblMarsh.Text) > 15 * countC + 5 && Convert.ToInt32(lblMarsh.Text) < 15 * countC + 15)
                    {
                        good = good + 5;
                    }
                    else
                    {
                        good = good + 0;
                    }



                    // Температура

                    if (temp < 30 || temp > 100)
                    {
                        good = good + 0;
                    }

                    if (temp >= 30 && temp < 40 || temp > 90 && temp <= 100)
                    {
                        good = good + 10;
                    }
                    if (temp >= 40 && temp < 50 || temp > 80 && temp <= 90)
                    {
                        good = good + 20;
                    }
                    if (temp >= 50 && temp < 60 || temp > 70 && temp <= 80)
                    {
                        good = good + 30;
                    }
                    if (temp >= 60 && temp <= 70)
                    {
                        good = good + 40;
                    }

                    MessageBox.Show("good = " + good);

                    buttonGotov.Enabled = true;

                }
            }
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эээ, нееет. Не все так просто. Ты должен сам определить наиболее подходящий твоим гостям рецепт. Подскажу, на одну порцию какао нужно 250 мл молока. Остальное придумывай сам.  :)");
        }

        private void buttonGotov_Click(object sender, EventArgs e)
        {
            FOrder order = new FOrder();
            isCready = 1;
            this.Hide();
        }

        private void textBoxTemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}

