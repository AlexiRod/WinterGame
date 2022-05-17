using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winter_Game.Properties;


namespace Winter_Game
{
    public partial class FOrder : Form
    {
       
        public FOrder()
        {
            InitializeComponent();
        }
        static int m = 1;
        static int n = 5;
        static int want;
        static int money = 1000;
        static int multi;
        static int guest;
        public static bool ib_Debug = true;

        Random random = new Random();

        private void FOrder_Load(object sender, EventArgs e)
        {
            bReady.Text = "Готов принять заказ!";
            lblMoney.Text = Convert.ToString(money);

          
            MoneyLocation();
        }
        private void FOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lRoub_Click(object sender, EventArgs e)
        {

        }
        private void buttonMoney_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void takeOrder_Click(object sender, EventArgs e)
        {


        }



        private void MoneyLocation()
        {
            if (lblMoney.Width == 31)  // 1
            {
                lRoub.Left = 174;
            }

            if (lblMoney.Width == 47)  // 10
            {
                lRoub.Left = 190;
            }

            if (lblMoney.Width == 63)  // 100
            {
                lRoub.Left = 206;
            }

            if (lblMoney.Width == 79)  // 1.000
            {
                lRoub.Left = 222;
            }

            if (lblMoney.Width == 95)  // 10.000
            {
                lRoub.Left = 247;
            }

            if (lblMoney.Width == 111)  // 100.000
            {
                lRoub.Left = 249;
            }

            if (lblMoney.Width == 127)  // 1.000.000
            {
                lRoub.Left = 270;
            }

            if (lblMoney.Width == 143)  // 10.000.000
            {
                lRoub.Left = 286;
            }
        }

        private void GOtsenka()
        {
            if (FGlintv.good >= 0 && FGlintv.good <= 10)
            {
                labelGood.Text = "Господи! Это же отвратительно! Как вообще можно было приготовить такой противный глинтвейн?!!! Скорее, вызовите мне скорую! Я требую компенсацию за такое!";
                multi = 0;
            }

            if (FGlintv.good > 10 && FGlintv.good <= 20)
            {
                labelGood.Text = "Фуу! Это отвратительно! Меня тошнит... Какая гадость! Противный глинтвейн! Я требую компенсацию за такое!";
                multi = 1;
            }

            if (FGlintv.good > 20 && FGlintv.good <= 30)
            {
                labelGood.Text = "Бе! Как противно! До сих пор это отвратное послевкусие! Больше не буду брать здесь глинтвейн! Я отказываюсь за это платить.";
                multi = 2;
            }

            if (FGlintv.good > 30 && FGlintv.good <= 40)
            {
                labelGood.Text = "Кхе, кхе! Что вы сюда добавили!? На вкус очень горько... или... кисло... Не делайте так больше! До сих пор этот привкус.";
                multi = 3;
            }

            if (FGlintv.good > 40 && FGlintv.good <= 50)
            {
                labelGood.Text = "Кхм... в целом, неплохо. Чувствуется, что вы старались, я хотя бы ощущаю отдаленный вкус глинтвейна, но, советую поменять рецепт. Так себе.";
                multi = 4;
            }

            if (FGlintv.good > 50 && FGlintv.good <= 60)
            {
                labelGood.Text = "Очень неплохо! Я узнаю этот вкус. Вы старались, но, советую еще доработать рецепт. Видимо, дело в пропорциях";
                multi = 5;
            }

            if (FGlintv.good > 60 && FGlintv.good <= 70)
            {
                labelGood.Text = "Ммммм... Это вкусно! вы угадали с пропорциями, и, в целом получилось хорошо. Такое можно продавать. Думаю, люди скоро потянутся к вам.";
                multi = 6;
            }

            if (FGlintv.good > 70 && FGlintv.good <= 80)
            {
                labelGood.Text = "О, да я смотрю вы разбираетесь в кулинарии! Это очень вкусно! Глинтвейн зашел на ура! Вы почти все сделали хорошо. Я обязательно зайду к вам с друзьями.";
                multi = 7;
            }

            if (FGlintv.good > 80 && FGlintv.good <= 90)
            {
                labelGood.Text = "Как это вкусно! Пропорции подобраны почти идеально! Хочется еще и еще! Глинтвейн почти идеален! Я обязательно расскажу о вашей лавке друзьям.";
                multi = 8;
            }

            if (FGlintv.good > 90 && FGlintv.good <= 100)
            {
                labelGood.Text = "Господи! Это же гениально! Как это вкусно! Напиток богов! Лучший глинтвейн, что я когда-либо пробовал! Плачу за него вдвойне!";
                multi = 9;
            }
        }
        private void COtsenka()

        {
            if (FCoffee.good >= 0 && FCoffee.good <= 10)
            {
                labelGood.Text = "Господи! Это же отвратительно! Как вообще можно было такое приготовить!!! Худшее какао! Скорее, вызовите мне скорую! Я требую компенсацию за такое!";
                multi = 0;
            }

            if (FCoffee.good > 10 && FCoffee.good <= 20)
            {
                labelGood.Text = "Фуу! Это отвратительно! Меня тошнит... Какая гадость!  Какое противное какао! Я требую компенсацию за такое!";
                multi = 1;
            }

            if (FCoffee.good > 20 && FCoffee.good <= 30)
            {
                labelGood.Text = "Бе! Как противно! До сих пор это отвратное послевкусие! Больше не буду брать здесь какао! Я отказываюсь за это платить.";
                multi = 2;
            }

            if (FCoffee.good > 30 && FCoffee.good <= 40)
            {
                labelGood.Text = "Кхе, кхе! Что вы сюда добавили!? На вкус очень горько... или... кисло... Не делайте так больше! До сих пор этот привкус.";
                multi = 3;
            }

            if (FCoffee.good > 40 && FCoffee.good <= 50)
            {
                labelGood.Text = "Кхм... в целом, неплохо.  Чувствуется, что вы старались, я хотя бы ощущаю отдаленный вкус какао, но, советую поменять рецепт. Так себе.";
                multi = 4;
            }

            if (FCoffee.good > 50 && FCoffee.good <= 60)
            {
                labelGood.Text = "Очень неплохо! Я узнаю вкус какао. Вы старались, но, советую еще доработать рецепт. Видимо, что-то не так с пропорциями";
                multi = 5;
            }

            if (FCoffee.good > 60 && FCoffee.good <= 70)
            {
                labelGood.Text = "Ммммм... Это вкусно! вы угадали с пропорциями, и, в целом получилось хорошо. Такое можно продавать. Думаю, люди скоро потянутся к вам.";
                multi = 6;
            }

            if (FCoffee.good > 70 && FCoffee.good <= 80)
            {
                labelGood.Text = "О, да я смотрю вы разбираетесь в кулинарии! Это очень вкусно! Вы почти все сделали хорошо. Я обязательно зайду к вам с друзьями.";
                multi = 7;
            }

            if (FCoffee.good > 80 && FCoffee.good <= 90)
            {
                labelGood.Text = "Как это вкусно! Пропорции подобраны почти идеально! Хочется еще и еще! Это какао напоминает мне о днях моей юности. Я обязательно расскажу о вашей лавке друзьям.";
                multi = 8;
            }

            if (FCoffee.good > 90 && FCoffee.good <= 100)
            {
                labelGood.Text = "Господи! Это же гениально! Как это вкусно! Напиток богов! Лучшее, что я когда-либо пробовал! Просто идеальное какао! Плачу за него вдвойне!";
                multi = 9;
            }
        }
        private void BOtsenka()
        {
            if (FBiscuit.good >= 0 && FBiscuit.good <= 10)
            {
                labelGood.Text = "Господи! Это же отвратительно! Как вообще можно было такое приготовить!!! Худшее печенье! Скорее, вызовите мне скорую! Я требую компенсацию за такое!";
                multi = 0;
            }

            if (FBiscuit.good > 10 && FBiscuit.good <= 20)
            {
                labelGood.Text = "Фуу! Это отвратительно! Меня тошнит... Какая гадость! Какое противное печенье! Я требую компенсацию за такое!";
                multi = 1;
            }

            if (FBiscuit.good > 20 && FBiscuit.good <= 30)
            {
                labelGood.Text = "Бе! Как противно! До сих пор это отвратное послевкусие! Больше не буду брать здесь печенье! Я отказываюсь за это платить.";
                multi = 2;
            }

            if (FBiscuit.good > 30 && FBiscuit.good <= 40)
            {
                labelGood.Text = "Кхе, кхе! Что вы сюда добавили!? На вкус очень горько... или... кисло... Не делайте так больше! До сих пор этот привкус.";
                multi = 3;
            }

            if (FBiscuit.good > 40 && FBiscuit.good <= 50)
            {
                labelGood.Text = "Кхм... в целом, неплохо.  Чувствуется, что вы старались, я хотя бы ощущаю отдаленный вкус печенья, но, советую поменять рецепт. Так себе.";
                multi = 4;
            }

            if (FBiscuit.good > 50 && FBiscuit.good <= 60)
            {
                labelGood.Text = "Очень неплохо! Я узнаю вкус печенья. Вы старались, но, советую еще доработать рецепт. Видимо, что-то не так с пропорциями, или температура не та";
                multi = 5;
            }

            if (FBiscuit.good > 60 && FBiscuit.good <= 70)
            {
                labelGood.Text = "Ммммм... Это вкусно! вы угадали с пропорциями и температурой, и, в целом получилось хорошо. Такое можно продавать. Думаю, люди скоро потянутся к вам.";
                multi = 6;
            }

            if (FBiscuit.good > 70 && FBiscuit.good <= 80)
            {
                labelGood.Text = "О, да я смотрю вы разбираетесь в кулинарии! Это очень вкусно! Вы почти все сделали хорошо. Пропорции и темпреатура подобаны почти идеально. Я обязательно зайду к вам с друзьями.";
                multi = 7;
            }

            if (FBiscuit.good > 80 && FBiscuit.good <= 90)
            {
                labelGood.Text = "Как это вкусно! Пропорции и температура подобраны почти идеально! Хочется еще и еще! Это печенье напоминает мне о днях моей юности. Я обязательно расскажу о вашей лавке друзьям.";
                multi = 8;
            }

            if (FBiscuit.good > 90 && FBiscuit.good <= 100)
            {
                labelGood.Text = "Господи! Это же гениально! Как это вкусно! Пища богов! Лучшее, что я когда-либо пробовал! Просто идеальное печенье! Плачу за него вдвойне!";
                multi = 9;
            }
        }
        private void TOtsenka()
        {
            if (FTea.g2 == 0)
            {
                labelGood.Text = "Эй! Что это такое!? Тут даже чайного пакетика нет! Тоже мне, Экспрес-чай! Один обман. Я требую компенсацию за такое!";
                multi = 0;
            }
            else

            if (FTea.goodTea == 0)
            {
                labelGood.Text = "Эй! Что это такое!? Я просил другой чай! Один обман. Я требую компенсацию за такое!";
                multi = 2;
            }
            else
            
            if (FTea.goodKip == 0)
            {
                labelGood.Text = "Эй! Что это такое!? Тут даже кипятка нет! Тоже мне, Экспрес-чай! Один обман. Я требую компенсацию за такое!";
                multi = 0;
            }
            else
            
            if (FTea.good == 20)
            {
                labelGood.Text = "Кхе-кхе! Что за!? Я просил вообще другое! Вы вообще слушали, когда я говорил про то что и сколько мне нужно в чае? Я отказываюсь за это платить!";
                multi = 3;
            }

            if (FTea.good > 20 && FTea.good <= 35)
            {
                labelGood.Text = "Кхм... В общем и целом, неплохо. Хотябы похоже на то, что я заказывал.";
                multi = 5;
            }

            if (FTea.good > 35 && FTea.good <= 40)
            {
                labelGood.Text = "Ммм... неплохо, очень неплохо! Пропорции почти как нужно. Действительно, быстро и вкусно!";
                multi = 6;
            }

            if (FTea.good > 40 && FTea.good <= 45)
            {
                labelGood.Text = "Ммм... Это очень вкусно! Пропорции почти идеальные! Это, и в правду, очень быстро и вкусно! Буду брать у вас чай, когда опаздываю";
                multi = 8;
            }

            if (FTea.good > 45 && FTea.good <= 50)
            {
                labelGood.Text = "Это же идеально! Пропорции соблюдены как нужно. Я вновь наслаждаюсь этим вкусом! Обязательно расскажу о вашей лавке друзьям";
                multi = 9;
            }
        }


        private void bReady_Click(object sender, EventArgs e)
        {
            bReady.Text = "Ожидаем гостя";
            bReady.Enabled = false;
            Random random = new Random();
            int time = random.Next(0, 10) * 1000;
            Thread.Sleep(time);
            timerGuest.Enabled = true;
            lblMulti.Visible = false;
            pictureBoxOblako.Visible = false;
            labelGood.Visible = false;

            guest = random.Next(1, 3);


            if (guest == 1)
            {
                pictureBoxGuest.Width = 129;
                pictureBoxGuest.Height = 316;
                pictureBoxGuest.Top = 159;
                pictureBoxGuest.Left = 1335;
                pictureBoxGuest.Image = Resources.ощзощзощзощзощзощз;
            }
            if (guest == 2)
            {
                pictureBoxGuest.Width = 310;
                pictureBoxGuest.Height = 282;
                pictureBoxGuest.Top = 179;
                pictureBoxGuest.Left = 1335;
                pictureBoxGuest.Image = Resources._3461275_happy_tourist;
            }
        }

        
       

       

        private void takeOrder_Click_1(object sender, EventArgs e)
        {
            takeOrder.Enabled = false;
            takeOrder.Text = "Жду заказ";

            if (want == 1)
            {
                FGlintv form = new FGlintv();
                form.Show();
            }
            if (want == 2)
            {
                FCoffee form = new FCoffee();
                form.Show();
            }

            if (want == 3)
            {
                FBiscuit form = new FBiscuit();
                form.Show();
            }

            if (want == 4)
            {
                FTea form = new FTea();
                form.Show();
            }
        }


        private void timerGuest_Tick(object sender, EventArgs e)
        {
           

            if (pictureBoxGuest.Left >= 660)
            {
                pictureBoxGuest.Left = pictureBoxGuest.Left - 10;
            }
            if (pictureBoxGuest.Left <= 660)
            {
                bReady.Text = "Заказ получен";
                takeOrder.Enabled = true;
                takeOrder.Visible = true;
                takeOrder.Text = "Взять заказ";
                pictureBoxOblako.Visible = true;
                pictureBoxWant.Visible = true;

               
                want = random.Next(1, 5);
               
                if (want == 1)
                {
                    pictureBoxWant.Image = Resources.Glintv;
                    FGlintv.countG = random.Next(1, 5);
                    labelCount.Visible = true;
                    labelCount.Text = "x" + Convert.ToString(FGlintv.countG);
                    timerGuest.Enabled = false;
                }

                if (want == 2)
                {
                    pictureBoxWant.Image = Resources.TAG_6ba5bc2f058b526706c8a2f5;
                    FCoffee.countC = random.Next(1, 5);
                    labelCount.Visible = true;
                    labelCount.Text = "x" + Convert.ToString(FCoffee.countC);
                    timerGuest.Enabled = false;
                }

                if (want == 3)
                {
                    pictureBoxWant.Image = Resources.iПечеенье;
                    FBiscuit.countB = random.Next(1, 3) * 5;
                    labelCount.Visible = true;
                    labelCount.Text = "x" + Convert.ToString(FBiscuit.countB);
                    timerGuest.Enabled = false;
                }

                if (want == 4)
                {
                    pictureBoxWant.Image = Resources._27134_1;
                    pictureBoxWant.Height = 129;
                    pictureBoxWant.Width = 199;
                    timerGuest.Enabled = false;
                }
                MessageBox.Show("want " + want);

            }



        }

        private void FOrder_MouseEnter(object sender, EventArgs e)
        {
            if (FGlintv.isGready == 1)
            {
                pictureBoxReady.Visible = true;
                pictureBoxReady.Image = Resources.Glintv;
                bSell.Visible = true;
                bSell.Enabled = true;
                FGlintv.isGready = 0;
            }

            if (FCoffee.isCready == 1)
            {
                pictureBoxReady.Image = Resources.TAG_6ba5bc2f058b526706c8a2f5;
                pictureBoxReady.Visible = true;
                bSell.Visible = true;
                bSell.Enabled = true;
                FCoffee.isCready = 0;
            }

            if (FBiscuit.isBready == 1)
            {
                pictureBoxReady.Image = Resources.iПечеенье;
                pictureBoxReady.Visible = true;
                bSell.Visible = true;
                bSell.Enabled = true;
                FBiscuit.isBready  = 0;
            }

            if (FTea.isTready == 1)
            {
                pictureBoxReady.Image = Resources._27134_1;
                pictureBoxReady.Visible = true;
                bSell.Visible = true;
                bSell.Enabled = true;
                FTea.isTready = 0;
            }
        }

        private void bSell_Click(object sender, EventArgs e)
        {
            takeOrder.Text = "Пробуем...";
            pictureBoxWant.Visible = false;
            labelCount.Visible = false;
            labelGood.Visible = true;
            labelGood.Text = "...";
            bSell.Visible = false;
            bSell.Enabled = false;
            pictureBoxReady.Visible = false;

            

            if (want == 1)
            {
                GOtsenka();
                MessageBox.Show("Glintvein " + Convert.ToString(FGlintv.good));
            }
            if (want == 2)
            {
                COtsenka();
                MessageBox.Show("Coffee " + Convert.ToString(FCoffee.good));
            }

            if (want == 3)
            {
                BOtsenka();
                MessageBox.Show("Biscuit " + Convert.ToString(FBiscuit.good));
            }

            if (want == 4)
            {
                TOtsenka();
                MessageBox.Show("Tea " + Convert.ToString(FTea.good));
            }


            pictureBoxMoney.Enabled = true;
            pictureBoxMoney.Visible = true;
        }

        

        private void pictureBoxMoney_Click(object sender, EventArgs e)
        {
            pictureBoxMoney.Enabled = false;
            pictureBoxMoney.Visible = false;
            pictureBoxReady.Visible = false;
            pictureBoxOblako.Visible = false;
            labelGood.Visible = false;
            bSell.Visible = false;
            bSell.Enabled = false;

            FGlintv.good = 0;
            FCoffee.good = 0;
            FBiscuit.good = 0;

            if (multi == 0)
            {
                money = money - 100;
                lblMoney.Text = Convert.ToString(money);
                lblMulti.ForeColor = Color.Red;
                lblMulti.Text = "-100";
            }

            if (multi == 2)
            {
                money = money - 50;
                lblMoney.Text = Convert.ToString(money);
                lblMulti.ForeColor = Color.Red;
                lblMulti.Text = "-50";
            }

            if (multi == 3)
            {
                lblMulti.ForeColor = Color.Black;
                lblMulti.Text = "+0";
            }

            if (multi == 4)
            {
                money = money + 20;
                lblMoney.Text = Convert.ToString(money);
                lblMulti.ForeColor = Color.LightGreen;
                lblMulti.Text = "+20";
            }

            if (multi == 5)
            {
                money = money + 50;
                lblMoney.Text = Convert.ToString(money);
                lblMulti.ForeColor = Color.LightGreen;
                lblMulti.Text = "+50";
            }

            if (multi == 6)
            {
                money = money + 100;
                lblMoney.Text = Convert.ToString(money);
                lblMulti.ForeColor = Color.LightGreen;
                lblMulti.Text = "+100";
            }

            if (multi == 7)
            {
                money = money + 120;
                lblMoney.Text = Convert.ToString(money);
                lblMulti.ForeColor = Color.LightGreen;
                lblMulti.Text = "+120 !";
            }
            if (multi == 8)
            {
                money = money + 150;
                lblMoney.Text = Convert.ToString(money);
                lblMulti.ForeColor = Color.LightGreen;
                lblMulti.Text = "+150 !!!";
            }

            if (multi == 9)
            {
                money = money + 200;
                lblMoney.Text = Convert.ToString(money);
                lblMulti.ForeColor = Color.LawnGreen;
                lblMulti.Text = "+200 !!!!!";
            }

            lblMulti.Visible = true;

            MoneyLocation();

            timerGuest2.Enabled = true;

            
            takeOrder.Visible = false;
            bReady.Text = "Готов принять заказ!";
        }

        private void timerGuest2_Tick(object sender, EventArgs e)
        {
            if (pictureBoxGuest.Left >= -100)
            {
                pictureBoxGuest.Left = pictureBoxGuest.Left - 10;
            }
            else
            {
                bReady.Enabled = true;
                pictureBoxGuest.Left = 1350;
                timerGuest2.Enabled = false;
            }
        }

        

        
    }
}
