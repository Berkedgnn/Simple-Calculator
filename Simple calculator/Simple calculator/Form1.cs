using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*if(sayac > 0)
                    {
                        sonuc += Convert.ToDouble(screen.Text.Substring(1,screen.Text.Length-1));
                        sayac = 0;
                    }
                    else
                    {
                        sonuc += Convert.ToDouble(screen.Text);
                    }
                   
                    break;
*/


namespace Simple_calculator
{
    public partial class Form1 : Form
    {
        //işlem yapılmak istenen sayıları hafızada tutmak için iki tane değişken ataması yapılır
        double mem_num1;
        double accumulatorresult;
        //işlemin ne olduğunu hafızaya alırız
        char islem = ' ';
        double sonuc;
        int sayac = 0;
        bool clear=false;
        int control = 0;
        char oncekiislem = ' ';
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            //burada birinci tuşa basınca ne yapılacağını (yani ekranda ne görünceğini) belirliyoruz. ekran değişkeninin adını screen belirledik.
            if (screen.Text == "0")
            {
                screen.Text = "";
            }
            if (clear == true)
            {
                screen.Text += "1";
            }
            else
            {
                screen.Text = screen.Text + "1";
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            //burada birinci tuşa basınca ne yapılacağını (yani ekranda ne görünceğini) belirliyoruz. ekran değişkeninin adını screen belirledik.
            if (screen.Text == "0")
            {
                screen.Text = "";
            }
            if (clear == true)
            {
                screen.Text += "2";
            }
            else
            {
                screen.Text = screen.Text + "2";
            }

        }

        private void nmbr3_Click(object sender, EventArgs e)
        {
           
            if (screen.Text == "0")
            {
                screen.Text = "";
            }
            if (clear == true)
            {
                screen.Text += "3";
            }
            else
            {
                screen.Text = screen.Text + "3";
            }
            
        }

        private void nmbr4_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "";
            }
            if (clear == true)
            {
                screen.Text += "4";
            }
            else
            {
                screen.Text = screen.Text + "4";
            }

        }

        private void nmbr5_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "";
            }
            if (clear == true)
            {
                screen.Text += "5";
            }
            else
            {
                screen.Text = screen.Text + "5";
            }

        }

        private void nmbr6_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "";
            }
            if (clear == true)
            {
                screen.Text += "6";
            }
            else
            {
                screen.Text = screen.Text + "6";
            }

        }

        private void nmbr7_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "";
            }
            if (clear == true)
            {
                screen.Text += "7";
            }
            else
            {
                screen.Text = screen.Text + "7";
            }

        }

        private void nmbr8_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "";
            }
            if (clear == true)
            {
                screen.Text += "8";
            }
            else
            {
                screen.Text = screen.Text + "8";
            }

        }

        private void nmbr9_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "";
            }
            if (clear == true)
            {
                screen.Text += "9";
            }
            else
            {
                screen.Text = screen.Text + "9";
            }

        }

        private void nmbr0_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "";
            }
            if (clear == true)
            {
                screen.Text += "0";
            }
            else
            {
                screen.Text = screen.Text + "0";
            }

        }

        private void plus_op_Click(object sender, EventArgs e)
        {
            oncekiislem = islem;//önceki islemi saptayabilmek icin bir değişken oluşturuyoruz
            islem = '+';
            mem_num1= Convert.ToDouble(screen.Text);
            screen.Text = "";//to clear screen
            clear = true;
            //bu adımda şu an seçilen işlemden önceki işlemi yapabilmek için önceki islem var'ı ile özel durum oluşturuyoruz.
            //5x10+ yapıldığında + tuşuna bastık ama arka planda sonucun çarpma işlemine göre güncellenmesi gerekir.
            if (oncekiislem != islem)
            {
                if (oncekiislem == 'x')
                {
                    sonuc *= mem_num1;
                }
                if (oncekiislem == '/')
                {
                    sonuc /= mem_num1;
                }
                if (oncekiislem == '-')
                {
                    sonuc -= mem_num1;
                }
                if(oncekiislem == ' ')
                {
                    sonuc += mem_num1;
                }
            }
            if(oncekiislem == islem)
            {
                sonuc += mem_num1;
            }
        }

        private void minus_op_Click(object sender, EventArgs e)
        {
           if(screen.Text == "0" && control == 0)
            {
                screen.Clear();
                screen.Text += "-";
                control++;
            }
            else
            {
                control++;
                if(sayac == 0 ) {
                    if (islem != '-' && screen.Text == "")// sayıyı girmişim sayı girlmesini beklemiyorum demek
                    {
                        screen.Clear();
                        screen.Text += "-";
                    }
                    else
                    {
                        if(islem == ' ')
                        {
                            if (sayac == 0)
                            {
                                sonuc = Convert.ToDouble(screen.Text);
                            }
                        }
                        if (islem == '-')
                        {
                            if (sayac == 0)
                            {
                               
                            }
                        }

                        islem = '-';
                    }
                }
                if(sayac > 0 && screen.Text == "")
                {
                    screen.Clear();
                    screen.Text += "-";
                    //sayac= 0;

                }
                
            }

           if(screen.Text != "" && screen.Text != "-" && control > 0)
            {
               
                //islem yaptığımızda kontrol değişkenini değiştirerek baştaki 0 durumuyla karışmasını engelleyebiliriz
                if(islem != '-')
                {
                    screen.Clear();
                    screen.Text += "-";
                }
                if(islem == '-')
                {
                    if(sayac != 0)//çünkü ilk durum dışında sonuctan mem_numu çıkarmak istemiyorum
                    {
                        mem_num1 = Convert.ToDouble(screen.Text);
                    }
                    screen.Text = "";//to clear screen
                    clear = true;
                    sayac++;
                    sonuc -= mem_num1;                  
                }               
            }    
        }

        private void cross_op_Click(object sender, EventArgs e)
        {
            islem = 'x';
            mem_num1 = Convert.ToDouble(screen.Text);
            screen.Text = "";//to clear screen
            clear = true;
            if(sonuc == 0)
            {
                sonuc++;
                sonuc *= mem_num1;
            }
            else
            {
                sonuc *= mem_num1;
            }
           
        }

        private void division_op_Click(object sender, EventArgs e)
        {
            islem = '/';
            mem_num1 = Convert.ToDouble(screen.Text);
            screen.Text = "";//to clear screen
            clear = true;
            if (sonuc == 0)
            {
                sonuc = mem_num1;
            }
            else
            {
                sonuc /= mem_num1;
            }
        }

        private void comma_Click(object sender, EventArgs e)
        {
            if (screen.Text.Contains(","))
            {
                MessageBox.Show("Birden fazla virgül kullanılamaz");
            }
            else
            {
                //bu kısımda ekranda 0 varsa temizlemeye gerek yok
                screen.Text = screen.Text + ",";
            }
            

        }
        private void sqrt_Click(object sender, EventArgs e)
        {

        }

        private void clr_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
            control = 0;
            sayac = 0;
            sonuc = 0;
            islem = ' ';
            mem_num1 = 0;
            oncekiislem = ' ';
        }

        private void ce_Click(object sender, EventArgs e)
        {
            if (screen.Text != "")
            {
                screen.Text = screen.Text.Remove((screen.Text.Length-1), 1);
            }
            else
            {
                
            }
        }

        private void equal_op_Click(object sender, EventArgs e)
        {
            
            switch (islem)
            {
                case '+':
                        sonuc += Convert.ToDouble(screen.Text);
                    break;

                case '-':
                    sonuc -= Convert.ToDouble(screen.Text);
                    sayac = 0;
                    break;
                case 'x':
                    sonuc *= Convert.ToDouble(screen.Text);
                    break;
                case '/':
                    if(Convert.ToDouble(screen.Text) != 0)
                    {
                     sonuc /= Convert.ToDouble(screen.Text);
                    }
                    else
                    {
                        MessageBox.Show("Geçerli sayı sıfıra bölünemez");
                    }
                    break;
                    
                default:
                   sonuc = Convert.ToDouble(screen.Text);//islem seçili olmasa da esittire basınca girilen sayıyı tekrar yazar.
                    break;
            }

            screen.Text= Convert.ToString(sonuc);
          

        }

        

    }
}
