using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winter_Game.Properties;

namespace Winter_Game
{
    public partial class FBiscuit : Form
    {
        public FBiscuit()
        {
            InitializeComponent();
        }

        static int temp = 0;


        public static int isBready = 0;
        public static int countB;
        public static int good;



        private void FBiscuit_Load(object sender, EventArgs e)
        {
            good = 0;
            temp = 0;
            isBready = 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblKoritsa_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureKoritsa_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void bMuka_Click(object sender, EventArgs e)
        {
            pictureBoxLozhka.Visible = false;
            pictureBoxMaslo.Visible = false;



            if (Convert.ToInt32(lblMuka.Text) >= 780)
            {
                pictureBoxM9.Visible = true;
                lblMuka.Text = "800";
                label5.Visible = true;
            }
            else
            {
                lblMuka.Text = Convert.ToString(Convert.ToInt32(lblMuka.Text) + 20);
            }



            if (Convert.ToInt32(lblMuka.Text) == 20)
            {
                pictureBoxM1.Visible = true;
                this.pictureBoxM1.BringToFront();
            }

            if (Convert.ToInt32(lblMuka.Text) == 100)
            {
                pictureBoxM2.Visible = true;
                this.pictureBoxM2.BringToFront();
            }
            if (Convert.ToInt32(lblMuka.Text) == 200)
            {
                pictureBoxM3.Visible = true;
                this.pictureBoxM3.BringToFront();
            }
            if (Convert.ToInt32(lblMuka.Text) == 300)
            {
                pictureBoxM4.Visible = true;
                this.pictureBoxM4.BringToFront();
            }
            if (Convert.ToInt32(lblMuka.Text) == 400)
            {
                pictureBoxM5.Visible = true;
                this.pictureBoxM5.BringToFront();
            }
            if (Convert.ToInt32(lblMuka.Text) == 500)
            {
                pictureBoxM6.Visible = true;
                this.pictureBoxM6.BringToFront();
            }
            if (Convert.ToInt32(lblMuka.Text) == 600)
            {
                pictureBoxM7.Visible = true;
                this.pictureBoxM7.BringToFront();
            }
            if (Convert.ToInt32(lblMuka.Text) == 700)
            {
                pictureBoxM8.Visible = true;
                this.pictureBoxM8.BringToFront();
            }
            if (Convert.ToInt32(lblMuka.Text) == 800)
            {
                pictureBoxM9.Visible = true;
                this.pictureBoxM9.BringToFront();
            }
        }

        private void bYaitsa_Click(object sender, EventArgs e)
        {
            pictureBoxLozhka.Visible = false;
            pictureBoxMaslo.Visible = false;


            if (Convert.ToInt32(lblYaitsa.Text) >= 3)
            {
                pictureBoxY4.Visible = true;
                lblYaitsa.Text = "4";
                label8.Visible = true;
            }
            else
            {
                lblYaitsa.Text = Convert.ToString(Convert.ToInt32(lblYaitsa.Text) + 1);
            }



            if (Convert.ToInt32(lblYaitsa.Text) == 1)
            {
                pictureBoxY1.Visible = true;
                this.pictureBoxY1.BringToFront();
            }

            if (Convert.ToInt32(lblYaitsa.Text) == 2)
            {
                pictureBoxY2.Visible = true;
                this.pictureBoxY2.BringToFront();
            }
            if (Convert.ToInt32(lblYaitsa.Text) == 3)
            {
                pictureBoxY3.Visible = true;
                this.pictureBoxY3.BringToFront();
            }
            if (Convert.ToInt32(lblYaitsa.Text) == 4)
            {
                pictureBoxY4.Visible = true;
                this.pictureBoxY4.BringToFront();
            }
        }

        private void bKoritsa_Click(object sender, EventArgs e)
        {
            pictureBoxLozhka.Visible = false;
            pictureBoxMaslo.Visible = false;


            if (Convert.ToInt32(lblKoritsa.Text) >= 3)
            {
                pictureBoxK3.Visible = true;
                lblKoritsa.Text = "4";
                label7.Visible = true;
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

        }

        private void bMed_Click(object sender, EventArgs e)
        {
            pictureBoxMaslo.Visible = false;


            if (Convert.ToInt32(lblMed.Text) >= 5)
            {
                pictureBoxLozhka.Visible = true;
                lblMed.Text = "6";
                label17.Visible = true;
            }
            else
            {
                pictureBoxLozhka.Visible = true;
                lblMed.Text = Convert.ToString(Convert.ToInt32(lblMed.Text) + 1);
            }

        }

        private void bImbir_Click(object sender, EventArgs e)
        {
            pictureBoxLozhka.Visible = false;
            pictureBoxMaslo.Visible = false;


            if (Convert.ToInt32(lblImbir.Text) >= 3)
            {
                pictureBoxI3.Visible = true;
                lblImbir.Text = "4";
                label16.Visible = true;
            }
            else
            {
                lblImbir.Text = Convert.ToString(Convert.ToInt32(lblImbir.Text) + 1);
            }



            if (Convert.ToInt32(lblImbir.Text) == 1)
            {
                pictureBoxI1.Visible = true;
                this.pictureBoxI1.BringToFront();
            }

            if (Convert.ToInt32(lblImbir.Text) == 2)
            {
                pictureBoxI2.Visible = true;
                this.pictureBoxI2.BringToFront();
            }
            if (Convert.ToInt32(lblImbir.Text) == 3)
            {
                pictureBoxI3.Visible = true;
                this.pictureBoxI3.BringToFront();
            }
            if (Convert.ToInt32(lblImbir.Text) == 4)
            {
                pictureBoxI4.Visible = true;
                this.pictureBoxI4.BringToFront();
            }
        }

        private void bMaslo_Click(object sender, EventArgs e)
        {
            pictureBoxLozhka.Visible = false;
            pictureBoxMaslo.Visible = true;

            if (Convert.ToInt32(lblMaslo.Text) >= 280)
            {
                lblMaslo.Text = "300";
                label14.Visible = true;
            }
            else
            {
                lblMaslo.Text = Convert.ToString(Convert.ToInt32(lblMaslo.Text) + 20);
            }
        }

        private void bTemp_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxTemp.Text) >= 1 && Convert.ToInt32(textBoxTemp.Text) <= 300)
            {
                temp = Convert.ToInt32(textBoxTemp.Text);
                MessageBox.Show("Температура установлена!");
            }
            else
                MessageBox.Show("Установите температуру от 1 до 300 градусов");
        }

        private void bVarka_Click(object sender, EventArgs e)
        {
            pictureBoxLozhka.Visible = false;
            pictureBoxMaslo.Visible = false;

            bMuka.Enabled = false;
            bKoritsa.Enabled = false;
            bMed.Enabled = false;
            bMaslo.Enabled = false;
            bImbir.Enabled = false;
            bYaitsa.Enabled = false;

            if (temp <= 0)
            {
                MessageBox.Show("Задайте температуру больше нуля в окошке под кнопкой и нажмите 'Oк'");
            }
            else
            {
                bTemp.Enabled = false;
                bVarka.Enabled = false;

                MessageBox.Show("Выпекаем печенье...");
                Thread.Sleep(4000);
                MessageBox.Show("Печенье готово!");



                // Мука

                if (Convert.ToInt32(lblMuka.Text) >= 60 * countB - 60 && Convert.ToInt32(lblMuka.Text) <= 60 * countB + 60)
                {
                    good = good + 10;
                }
                else
                        if (Convert.ToInt32(lblMuka.Text) > 60 * countB - 150 && Convert.ToInt32(lblMuka.Text) < 60 * countB - 60)
                {
                    good = good + 5;
                }
                if (Convert.ToInt32(lblMuka.Text) > 60 * countB + 60 && Convert.ToInt32(lblMuka.Text) < 60 * countB + 150)
                {
                    good = good + 5;
                }
                else
                {
                    good = good + 0;
                }

               
                // Яйца




                if (Convert.ToInt32(lblYaitsa.Text) >= 1 * (countB / 5) && Convert.ToInt32(lblYaitsa.Text) <= 1 * (countB / 5))
                {
                    good = good + 10;
                }
                else
                if (Convert.ToInt32(lblYaitsa.Text) > 1 * (countB / 5) - 3 && Convert.ToInt32(lblYaitsa.Text) <= 1 * (countB / 5) - 1)
                {
                    good = good + 5;
                }
                if (Convert.ToInt32(lblYaitsa.Text) >= 1 * (countB / 5) + 1 && Convert.ToInt32(lblYaitsa.Text) < 1 * (countB / 5) + 3)
                {
                    good = good + 5;
                }
                else
                {
                    good = good + 0;
                }



                
                // Корица



                if (Convert.ToInt32(lblKoritsa.Text) >= 1 * (countB / 5) && Convert.ToInt32(lblKoritsa.Text) <= 1 * (countB / 5))
                {
                    good = good + 10;
                }
                else
                if (Convert.ToInt32(lblKoritsa.Text) > 1 * (countB / 5) - 3 && Convert.ToInt32(lblKoritsa.Text) < 1 * (countB / 5) - 1)
                {
                    good = good + 5;
                }
                if (Convert.ToInt32(lblKoritsa.Text) > 1 * (countB / 5) + 1 && Convert.ToInt32(lblKoritsa.Text) < 1 * (countB / 5) + 3)
                {
                    good = good + 5;
                }
                else
                {
                    good = good + 0;
                }



               
                // Имбирь


                if (countB == 5)
                {
                    if (Convert.ToInt32(lblImbir.Text) == 1)
                    {
                        good = good + 10;
                    }
                    else
                        good = good + 0;
                }

                if (countB == 10)
                {
                    if (Convert.ToInt32(lblImbir.Text) == 2)
                    {
                        good = good + 10;
                    }
                    else
                        good = good + 0;
                }


                
                // Мед


                if (Convert.ToInt32(lblMed.Text) >= 2 * (countB / 5) - 1 && Convert.ToInt32(lblMed.Text) <= 2 * (countB / 5) + 1)
                {
                    good = good + 10;
                }
                else
               if (Convert.ToInt32(lblMed.Text) > 1 * (countB / 5) - 3 && Convert.ToInt32(lblMed.Text) < 1 * (countB / 5) - 1)
                {
                    good = good + 5;
                }
                if (Convert.ToInt32(lblMed.Text) > 1 * (countB / 5) + 1 && Convert.ToInt32(lblMed.Text) < 1 * (countB / 5) + 3)
                {
                    good = good + 5;
                }
                else
                {
                    good = good + 0;
                }

                
                // Масло


                if (Convert.ToInt32(lblMaslo.Text) >= 100 * (countB / 5) - 40 && Convert.ToInt32(lblMaslo.Text) <= 100 * (countB / 5) + 40)
                {
                    good = good + 10;
                }
                else
               if (Convert.ToInt32(lblMaslo.Text) > 100 * (countB / 5) - 80 && Convert.ToInt32(lblMaslo.Text) < 100 * (countB / 5) - 40)
                {
                    good = good + 5;
                }
                if (Convert.ToInt32(lblMaslo.Text) > 100 * (countB / 5) + 40 && Convert.ToInt32(lblMaslo.Text) < 100 * (countB / 5) + 80)
                {
                    good = good + 5;
                }
                else
                {
                    good = good + 0;
                }

                
                // Температура




                if (temp < 150 || temp > 230)
                {
                    good = good + 0;
                }

                if (temp >= 150 && temp < 160 || temp > 220 && temp <= 230)
                {
                    good = good + 10;
                }
                if (temp >= 160 && temp < 170 || temp > 210 && temp <= 220)
                {
                    good = good + 20;
                }
                if (temp >= 170 && temp < 180 || temp > 200 && temp <= 210)
                {
                    good = good + 30;
                }
                if (temp >= 180 && temp <= 200)
                {
                    good = good + 40;
                }

                MessageBox.Show("good = " + good);

                buttonGotov.Enabled = true;

            }
        }

        private void buttonGotov_Click(object sender, EventArgs e)
        {
            FOrder order = new FOrder();
            isBready = 1;
            this.Hide();
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эээ, нееет. Не все так просто. Ты должен сам определить наиболее подходящий твоим гостям рецепт. Подскажу, на 5 порций печенья нужно 300 г муки. Остальное придумывай сам.  :)");
        }
    }
}
