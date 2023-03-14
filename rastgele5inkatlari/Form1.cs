using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rastgele5inkatlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[10];
            int sayi1 = 0, sayi2 = 0;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            Random rnd = new Random();
            int i = 0;
            while (i < 10)// "i" ,10 den küçük olduğu sürece döngüye devam eder.
               {
                  int sayi = rnd.Next(sayi1, sayi2);// sayi1 ile sayi2 arasında rasgele bir sayı üretip onu "sayi" değişkenine atar.
                  if (sayilar.Contains(sayi))// "sayilar" dizisinin içinde "sayi" nın değeri olup olmadığını kontrol eder.
                  continue;// Eğer var ise döngünün içindeki başka hiçbir koda bakmadan devam eder.         
                  sayilar[i] = sayi;//Burada "sayi"değişkeninin değerini "sayilar"dizisinin "i" ninci elemanına atıyoruz.
                                    // Yani "i" 5 ise "sayilar" dizisinin 5. elemanına(sayilar[5]) .
                  i++;// "i" değişkeninin değerini 1 arttırıyoruz.
                }//Burada ise koşulu kontrol eder ve koşul sağlanıyor ise devam eder ,sağlanmıyor ise döngü biter.
                //Array.Sort(sayilar);//Bu diziyi küçükten büyüğe sıralar.
                foreach (int sayi in sayilar)//Burada dizi içindeki sayıları sırasıyla "sayi"değişkenine atar.
                listBox1.Items.Add(sayi.ToString());//listbox1de görüntülenir.
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();// listeyi temizlemek için.
            listBox2.Items.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                sayi=int.Parse(listBox1.Items[i].ToString());
                if( sayi%5==0)
                {
                    listBox2.Items.Add(sayi);
                }
            }
        }
    }
}
