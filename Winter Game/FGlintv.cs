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
using System.Threading;

namespace Winter_Game
{
    public partial class FGlintv : Form
    {

        public static int isGready = 0;
        public static int countG;
        public static int good;

        public FGlintv()
        {
            InitializeComponent();

           
        }
        static int vin = 1;
        static int temp = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            vin = 1;
            good = 0;
            temp = 0;
            isGready = 0;
        }

        private void pictureBoxSugar_Click(object sender, EventArgs e)
        {

        }
        private void pictureBoxK3_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void bWine_Enter(object sender, EventArgs e)
        {
          
        }
        private void bWine_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void pictureBoxG3_Click(object sender, EventArgs e)
        {

        }
        private void label16_Click(object sender, EventArgs e)
        {

        }
        private void pictureBoxKastrulya_Click(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

       
        private void bWine_Click(object sender, EventArgs e)
        {
            if (vin == 1)
            {
                pictureBoxWine.Visible = true;
                lblWine.Text = "40";
            }
            
            vin = 0;

            pictureBoxWine.Visible = true;
            pictureBoxLozhka.Visible = false;
            pictureBoxKastrulya.Image = Resources.Кастрюля;
            pictureBoxWine.Height = pictureBoxWine.Height + 1;
            pictureBoxWine.Top = pictureBoxWine.Top - 1;
            if (Convert.ToInt32(lblWine.Text) >= 800)
            {
                pictureBoxWine.Top = 205;
                pictureBoxWine.Height = 231;
                label5.Visible = true;
                lblWine.Text = "800";
            }
            else
            lblWine.Text = Convert.ToString(Convert.ToUInt32(lblWine.Text) + 10);


        }


        
        private void bSugar_Click(object sender, EventArgs e)
        {
            if (pictureBoxWine.Visible == false)
            {
                MessageBox.Show("Сначала налейте вино!");
            }
            else
            {

                pictureBoxKastrulya.Image = Resources.Кастрюля2;

                pictureBoxLozhka.Visible = true;

                if (Convert.ToInt32(lblSugar.Text) >= 250)
                {
                    lblSugar.Text = "250";
                    label7.Visible = true;
                }
                else
                {
                    lblSugar.Text = Convert.ToString(Convert.ToUInt32(lblSugar.Text) + 10);
                }

               
            }

        }

        private void bKoritsa_Click(object sender, EventArgs e)
        {
            if (pictureBoxWine.Visible == false)
            {
                MessageBox.Show("Сначала налейте вино!");
            }
            else
            {
                pictureBoxLozhka.Visible = false;
                pictureBoxKastrulya.Image = Resources.Кастрюля;

                if (Convert.ToInt32(lblKoritsa.Text) >= 9)
                {
                    pictureBoxK4.Visible = true;
                    lblKoritsa.Text = "10";
                    label8.Visible = true;
                }
                else
                {
                    lblKoritsa.Text = Convert.ToString(Convert.ToInt32(lblKoritsa.Text) + 1);
                }



                if (Convert.ToInt32(lblKoritsa.Text) >= 1)
                {
                    pictureBoxK1.Visible = true;
                }

                if (Convert.ToInt32(lblKoritsa.Text) >= 4)
                {
                    pictureBoxK2.Visible = true;
                }
                if (Convert.ToInt32(lblKoritsa.Text) >= 7)
                {
                    pictureBoxK3.Visible = true;
                }

               
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (pictureBoxWine.Visible == false)
            {
                MessageBox.Show("Сначала налейте вино!");
            }
            else
            {
                pictureBoxLozhka.Visible = false;
                pictureBoxKastrulya.Image = Resources.Кастрюля;

                if (Convert.ToSingle(lblOrech.Text) >= 3.5f)
                {

                    lblOrech.Text = "4";
                    label14.Visible = true;
                }
                else
                {
                    lblOrech.Text = Convert.ToString(Convert.ToSingle(lblOrech.Text) + 0.5f);



                    if (Convert.ToSingle(lblOrech.Text) >= 0.5)
                    {
                        pictureBoxO1.Visible = true;
                    }

                    if (Convert.ToSingle(lblOrech.Text) >= 2)
                    {
                        pictureBoxO2.Visible = true;
                    }
                }


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (pictureBoxWine.Visible == false)
            {
                MessageBox.Show("Сначала налейте вино!");
            }
            else
            {
                
                    pictureBoxLozhka.Visible = false;
                    pictureBoxKastrulya.Image = Resources.Кастрюля;

                if (Convert.ToInt32(lblGvozdica.Text) >= 19)
                    {
                        pictureBoxG1.Visible = true;
                        lblGvozdica.Text = "20";
                        label17.Visible = true;
                    }
                    else
                    {
                        lblGvozdica.Text = Convert.ToString(Convert.ToInt32(lblGvozdica.Text) + 1);
                    }


                    if (Convert.ToInt32(lblGvozdica.Text) >= 1)
                    {
                        pictureBoxG1.Visible = true;
                    }

                    if (Convert.ToInt32(lblGvozdica.Text) >= 9)
                    {
                        pictureBoxG2.Visible = true;
                    }
                    if (Convert.ToInt32(lblGvozdica.Text) >= 14)
                    {
                        pictureBoxG3.Visible = true;
                    }

                  
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (pictureBoxWine.Visible == false)
            {
                MessageBox.Show("Сначала налейте вино!");
            }
            else
            {
                
                    pictureBoxLozhka.Visible = false;
                    pictureBoxKastrulya.Image = Resources.Кастрюля;

                    if (Convert.ToInt32(lblApelsin.Text) >= 9)
                    {
                        pictureBoxA1.Visible = true;
                        lblApelsin.Text = "10";
                        label20.Visible = true;
                    }
                    else
                    { 
                        lblApelsin.Text = Convert.ToString(Convert.ToInt32(lblApelsin.Text) + 1);
                    }


                    if (Convert.ToInt32(lblApelsin.Text) >= 1)
                    {
                        pictureBoxA1.Visible = true;
                    }

                    if (Convert.ToInt32(lblApelsin.Text) >= 3)
                    {
                        pictureBoxA2.Visible = true;
                    }
                    if (Convert.ToInt32(lblApelsin.Text) >= 6)
                    {
                        pictureBoxA3.Visible = true;
                    }

            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (pictureBoxWine.Visible == false)
            {
                MessageBox.Show("Налейте хотя бы вино!");
            }
            else
            {
                pictureBoxLozhka.Visible = false;
                pictureBoxKastrulya.Image = Resources.Кастрюля;
                
                bApelsin.Enabled = false;
                bKoritsa.Enabled = false;
                bWine.Enabled = false;
                bSugar.Enabled = false;
                bGvozdica.Enabled = false;
                bOrech.Enabled = false;
                
                if (temp <= 0)
                {
                    MessageBox.Show("Задайте температуру больше нуля в окошке под кнопкой и нажмите 'Oк'");
                }
                else
                {
                    bTemp.Enabled = false;
                    bVarka.Enabled = false;
                    pictureBoxPlita.Visible = true;
                    MessageBox.Show("Варим глинтвейн...");
                    Thread.Sleep(4000);
                    MessageBox.Show("Напиток готов!");


                    // Вино

                    if (Convert.ToInt32(lblWine.Text) >= 175*countG - 50 && Convert.ToInt32(lblWine.Text) <= 175*countG + 50)
                    {
                        good = good + 10;
                    }
                    else
                    if (Convert.ToInt32(lblWine.Text) > 175 * countG - 150 && Convert.ToInt32(lblWine.Text) < 175 * countG - 50)
                    {
                        good = good + 5;

                    }
                    else
                    if (Convert.ToInt32(lblWine.Text) > 175 * countG + 50 && Convert.ToInt32(lblWine.Text) < 175 * countG + 150)
                    {
                        good = good + 5;
                    }
                    else
                    {
                        good = good + 0;
                    }

                    // Сахар


                    if (Convert.ToInt32(lblSugar.Text) >= 25 * countG - 20 && Convert.ToInt32(lblSugar.Text) <= 25 * countG + 20)
                    {
                        good = good + 10;
                    }
                    else
                    if (Convert.ToInt32(lblSugar.Text) > 25 * countG - 60 && Convert.ToInt32(lblSugar.Text) < 25 * countG - 20)
                    {
                        good = good + 5;
                    }
                    else
                    if (Convert.ToInt32(lblSugar.Text) > 25 * countG + 20 && Convert.ToInt32(lblSugar.Text) < 25 * countG + 60)
                    {
                        good = good + 5;
                    }
                    else
                    {
                        good = good + 0;
                    }


                    // Корица


                    if (Convert.ToInt32(lblKoritsa.Text) >= 2 * countG - 1 && Convert.ToInt32(lblKoritsa.Text) <= 2 * countG + 1)
                    {
                        good = good + 10;
                    }
                    else
                    if (Convert.ToInt32(lblKoritsa.Text) > 2 * countG - 2 && Convert.ToInt32(lblKoritsa.Text) < 2 * countG - 1)
                    {
                        good = good + 5;
                    }
                    if (Convert.ToInt32(lblKoritsa.Text) > 2 * countG + 1 && Convert.ToInt32(lblKoritsa.Text) < 2 * countG + 3)
                    {
                        good = good + 5;
                    }
                    else
                    {
                        good = good + 0;
                    }


                    // Апельсины


                    if (Convert.ToInt32(lblApelsin.Text) >= 2 * countG - 1 && Convert.ToInt32(lblApelsin.Text) <= 2 * countG + 1)
                    {
                        good = good + 10;
                    }
                    else
                    if (Convert.ToInt32(lblApelsin.Text) > 2 * countG - 2 && Convert.ToInt32(lblApelsin.Text) < 2 * countG - 1)
                    {
                        good = good + 5;
                    }
                    if (Convert.ToInt32(lblApelsin.Text) > 2 * countG + 1 && Convert.ToInt32(lblApelsin.Text) < 2 * countG + 3)
                    {
                        good = good + 5;
                    }
                    else
                    {
                        good = good + 0;
                    }


                    // Гвоздика


                    if (Convert.ToInt32(lblGvozdica.Text) >= 4 * countG - 2 && Convert.ToInt32(lblGvozdica.Text) <= 4 * countG + 2)
                    {
                        good = good + 10;
                    }
                    else
                    if (Convert.ToInt32(lblGvozdica.Text) > 4 * countG - 4 && Convert.ToInt32(lblGvozdica.Text) < 4 * countG - 2)
                    {
                        good = good + 5;
                    }
                    else
                    if (Convert.ToInt32(lblGvozdica.Text) > 4 * countG + 2 && Convert.ToInt32(lblGvozdica.Text) < 4 * countG + 4)
                    {
                        good = good + 5;
                    }
                    else
                    {
                        good = good + 0;
                    }


                    // Мускатный орех



                    if (Convert.ToSingle(lblOrech.Text) < 0.5f || Convert.ToSingle(lblOrech.Text) > 3.5f)
                    {
                        good = good + 0;
                    }
                    if (Convert.ToSingle(lblOrech.Text) == 0.5f)
                    {
                        if (countG == 1 || countG == 2)
                        {
                            good = good + 5;
                        }
                        else
                        {
                            good = good + 0;
                        }
                    }
                    
                    if (Convert.ToSingle(lblOrech.Text) > 0.5f && Convert.ToSingle(lblOrech.Text) <= 1.5f)
                    {
                       if (countG == 1 || countG == 2)
                       {
                           good = good + 10;
                       }
                        else
                        {
                            good = good + 0;
                        }
                    }

                    if (Convert.ToSingle(lblOrech.Text) == 2.0f)
                    {
                        good = good + 5;
                    }

                    if (Convert.ToSingle(lblOrech.Text) >= 2.5f && Convert.ToSingle(lblOrech.Text) < 3.5f)
                    {
                        if (countG == 3 || countG == 4)
                        {
                            good = good + 10;
                        }
                        else
                        {
                            good = good + 0;
                        }
                    }

                    if (Convert.ToSingle(lblOrech.Text) == 3.5f)
                    {
                        if (countG == 3 || countG == 4)
                        {
                            good = good + 5;
                        }
                        else
                        {
                            good = good + 0;
                        }
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

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxTemp.Text) >=1 && Convert.ToInt32(textBoxTemp.Text) <= 110)
            {
                temp = Convert.ToInt32(textBoxTemp.Text);
                MessageBox.Show("Температура установлена!");
            }
            else
                MessageBox.Show("Установите температуру от 1 до 110 градусов");



        }

        private void button1_Click_3(object sender, EventArgs e)
        {

            FOrder order = new FOrder();
            isGready = 1;
            this.Hide();
            
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эээ, нееет. Не все так просто. Ты должен сам определить наиболее подходящий твоим гостям рецепт. Подскажу, на одну порцию глинтвейна нужно 175 мл вина. Остальное придумывай сам.  :)");
        }

        
    }
}
