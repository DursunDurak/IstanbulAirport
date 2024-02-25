using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace IstanbulAirport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int  günlükkalkan_ucaksayisi_belirlenen, günlükinen_ucaksayisi_belirlenen,
             günlükkalkan_ucaksayisi_min, günlükkalkan_ucaksayisi_max, 
             günlükinen_ucaksayisi_min, günlükinen_ucaksayisi_max, kötühava_kalkisiptal_orani, 
             kötühava_inisiptal_orani, kötühava_olmaorani, kötühava_olma_gercek , aydakigünsayisi,
             aylikkalkan_ucaksayisi_tahmini, aylikinen_ucaksayisi_tahmini ;

        private void button1_Click(object sender, EventArgs e) { }

        private int günlükkalkan_ucaksayisi_gerceklesen, günlükinen_ucaksayisi_gerceklesen;
        //Hesapla butonuna her basıldığında aydaki gün sayısına eşit olarak tahmini aylık iniş ve kalkış sayılarını hesaplar toplayarak devam eder
        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int aydakigünsayisi = int.Parse(txtBox_aydakigünsayisi.Text);
            for (int i = 0; i <= aydakigünsayisi; i++)
            {
                hesapla();
            }
            return;
        }   
        void hesapla()
            {
            
            // günlük kalkan tahmini uçak sayısını hesaplama
            int günlükkalkan_ucaksayisi_min = int.Parse(txtBox_günlükkalkan_ucaksayisi_min.Text);
            int günlükkalkan_ucaksayisi_max = int.Parse(txtBox_günlükkalkan_ucaksayisi_max.Text);

            int günlükkalkan_ucaksayisi_belirlenen = random.Next(günlükkalkan_ucaksayisi_min, günlükkalkan_ucaksayisi_max);
            
            // günlük inen tahmini uçak sayısını hesaplama
            int günlükinen_ucaksayisi_min = int.Parse(txtBox_günlükinen_ucaksayisi_min.Text);
            int günlükinen_ucaksayisi_max = int.Parse(txtBox_günlükinen_ucaksayisi_max.Text);

            int günlükinen_ucaksayisi_belirlenen = random.Next(günlükinen_ucaksayisi_min, günlükinen_ucaksayisi_max);
            

            //kötü hava iptal oranlarını hesaplama
            int kötühava_kalkisiptal_orani = int.Parse(txtBox_kötühava_kalkisiptal_orani.Text);
            int kötühava_inisiptal_orani = int.Parse(txtBox_kötühava_inisiptal_orani.Text);
            int kötühava_olmaorani = int.Parse(txtBox_kötühava_olmaorani.Text);
            int kötühava_olma_gercek = random.Next(1, 100);

                if (kötühava_olma_gercek <= 30)
                {

                    int günlükkalkan_ucaksayisi_gerceklesen = (günlükkalkan_ucaksayisi_belirlenen * kötühava_kalkisiptal_orani) / 100;
                    int günlükinen_ucaksayisi_gerceklesen = (günlükinen_ucaksayisi_belirlenen * kötühava_inisiptal_orani) / 100;


                    lbl_günlükinen_ucaksayisi_belirlenen.Text = Convert.ToString(günlükinen_ucaksayisi_belirlenen);
                    lbl_günlükkalkan_ucaksayisi_belirlenen.Text = Convert.ToString(günlükkalkan_ucaksayisi_belirlenen);
                    lbl_günlükkalkan_ucaksayisi_gerceklesen.Text = Convert.ToString(günlükkalkan_ucaksayisi_gerceklesen);
                    lbl_günlükinen_ucaksayisi_gerceklesen.Text = Convert.ToString(günlükinen_ucaksayisi_gerceklesen);
                    
                }
                else
                {
                    int günlükkalkan_ucaksayisi_gerceklesen = günlükkalkan_ucaksayisi_belirlenen;
                    int günlükinen_ucaksayisi_gerceklesen = günlükinen_ucaksayisi_belirlenen;

                    lbl_günlükinen_ucaksayisi_belirlenen.Text = Convert.ToString(günlükinen_ucaksayisi_belirlenen);
                    lbl_günlükkalkan_ucaksayisi_belirlenen.Text = Convert.ToString(günlükkalkan_ucaksayisi_belirlenen);
                    lbl_günlükkalkan_ucaksayisi_gerceklesen.Text = Convert.ToString(günlükkalkan_ucaksayisi_gerceklesen);
                    lbl_günlükinen_ucaksayisi_gerceklesen.Text = Convert.ToString(günlükinen_ucaksayisi_gerceklesen);
                   
                }

                  aylikkalkan_ucaksayisi_tahmini += int.Parse(lbl_günlükkalkan_ucaksayisi_gerceklesen.Text);
                  aylikinen_ucaksayisi_tahmini += int.Parse(lbl_günlükinen_ucaksayisi_gerceklesen.Text);


                  lbl_aylikinen_ucaksayisi_tahmini.Text = Convert.ToString(aylikinen_ucaksayisi_tahmini);
                 lbl_aylikkalkan_ucaksayisi_tahmini.Text = Convert.ToString(aylikkalkan_ucaksayisi_tahmini);

            }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtBox_günlükkalkan_ucaksayisi_min.Text = "50";
            txtBox_günlükkalkan_ucaksayisi_max.Text = "70";
            txtBox_günlükinen_ucaksayisi_min.Text = "50";
            txtBox_günlükinen_ucaksayisi_max.Text = "70";
            txtBox_kötühava_kalkisiptal_orani.Text = "60";
            txtBox_kötühava_inisiptal_orani.Text = "40";
            txtBox_kötühava_olmaorani.Text = "30";
            txtBox_aydakigünsayisi.Text = "30";
        }
    }
}


//günlük tahmini uçuşu hesapla ramdom 50/70 arası sonra hava kötü mü diye bak %30 0-100 arası
//random 30 dan küçükse tahmini uçuşlar için kalkışı 60/100 inişleri 40/100 le çarp
//sonra bu olay 30 kere dönecek


