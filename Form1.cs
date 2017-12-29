using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.DirectoryServices;
using System.IO;
using System.Xml;
using System.Data.SqlServerCe;
using System.Web;



namespace plakatanima
{
    public partial class Form1 : Form
    {
        int[] koseler1 = new int[9]; 

        
        int[] siniral = new int[4];
        int[] harfsolsag = new int[26];
        int[] harfustalt = new int[26];

        DirectoryInfo dir;
        FileInfo[] dosyalar;

        public Form1()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                      

            dir = new DirectoryInfo(Application.StartupPath);
            dosyalar = dir.GetFiles();


            string deger = "araç1.bmp";
            comboBox1.Text=deger;
            foreach (FileInfo newDir in dosyalar)
            {
                if (newDir.Name.EndsWith(".bmp"))
                    comboBox1.Items.Add(newDir.Name);
            }

            

        }

      
     

       

      
        private string foto(Image resmim)
        {
            int[] d = new int[26];
            int[] r = new int[26];
            ImageProcessor resim = new ImageProcessor(resmim);
            return resim.bul();
          
        }
      
        private void plakaboyut_Click(object sender, EventArgs e)
        {


            //BOYUTLANDIR
            Image resmim = resim2.Image;
            ImageProcessor resim = new ImageProcessor(resmim);
            resim.Img = resim.Boyutlandir(resim2.Image.Width * 2, resim2.Image.Height);
            resim2.Image = resim.Img;
            //pictureBox5.Image = resim.Img;



           //etrafýný temizle
            siniral = resim.Satir();

            resim.Img = resim.Sinirbeyazlat(siniral[0], siniral[1], siniral[2], siniral[3]);

            resim.Img = resim.Kes(siniral[0], siniral[2], siniral[1], siniral[3]);

            resim2.Image = resim.Img;
            //pictureBox6.Image = resim.Img;

            //harfleri ayýr
            textBox1.Text = "";
           
            harfsolsag = resim.Harfkoorbulsolsag();
            harfustalt = resim.Harfkoorbulustalt();

            for (int sayi = 0; sayi < harfsolsag.Length; sayi = sayi + 2)
            {
                if (harfsolsag[sayi] != 0)
                {

                    Image resmim1 = resim2.Image;
                    ImageProcessor resim1 = new ImageProcessor(resmim1);

                    resim1.Img = resim1.Kes(0, harfsolsag[sayi], resmim1.Height, harfsolsag[sayi + 1]);




                    PictureBox pb2 = new System.Windows.Forms.PictureBox();
                    pb2.Location = new System.Drawing.Point(440 + sayi * 20, 400);
                    pb2.Name = sayi.ToString();
                    pb2.Size = new System.Drawing.Size(12, 20);
                    pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    pb2.TabIndex = 0;
                    pb2.TabStop = false;
                    Controls.Add(pb2);



                    textBox1.Text = textBox1.Text + foto(resim1.Img);
                    pb2.Image = resim1.Img;
                }




            }
            plakaboyut.Visible = false;
            textBox1.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            resim2.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DirectoryInfo s = new DirectoryInfo(Application.StartupPath);




            Image image1 = Image.FromFile(comboBox1.SelectedItem.ToString());
            //load the bitmap from image

            Bitmap bmp = (Bitmap)image1;

            resim1.Image = bmp;
            //label1.Text = resim1.Image.Width.ToString();
            //label2.Text = resim1.Image.Height.ToString();

            yeni_plakayeri.Visible = true;
            button1.Visible = false;
            comboBox1.Visible = false;

           
            
        }

        private void resim1_Click(object sender, EventArgs e)
        {

        }

        private void resim2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void yeni_plakayeri_Click(object sender, EventArgs e)
        {

            //BOYUTLANDIRMA
            Image resmim = resim1.Image;
            ImageProcessor resim = new ImageProcessor(resmim);
            resim.Img = resim.Boyutlandir(320, 240);
            resim1.Image = resim.Img;
            //label1.Text = resim1.Image.Width.ToString();
            //label2.Text = resim1.Image.Height.ToString();

            
            //GRÝYE ÇEVÝRME
            resim.Img = resim.griyecevir();
            //resim1.Image = resim.Img;
            pictureBox1.Image = resim.Img;
            resim2.Image = resim.Img;
            resim2.Visible = false;


            //Siyah beyaz
            resim.Img = resim.binary();
            //resim1.Image = resim.Img;
            pictureBox2.Image = resim.Img;

           
            //YOÐUNLUK TARAMASI
            koseler1 = resim.Yogunluk();

            //label3.Text = koseler1[0].ToString();
            //label4.Text = koseler1[1].ToString();
            //label5.Text = koseler1[2].ToString();
            //label6.Text = koseler1[3].ToString();
            //label7.Text = koseler1[4].ToString();
            //label8.Text = koseler1[5].ToString();
            //label9.Text = koseler1[6].ToString();
            //label10.Text = koseler1[7].ToString();

            //resim1.Image = resim.Img;


            Image image2 = resim1.Image;


            Bitmap bmp1 = (Bitmap)image2;

            resim1.Image = bmp1;








            //PLAKA KISMINI ÇEKME
            resim2.Visible = true;
             resmim = resim2.Image;
             resim = new ImageProcessor(resmim);
            resim.Img = resim.Kes(koseler1[1], koseler1[0], koseler1[7], koseler1[6]);
            resim2.Image = resim.Img;
            //pictureBox3.Image = resim.Img;

            //NETLEÞTÝRME
             resmim = resim2.Image;
             resim = new ImageProcessor(resmim);
            resim2.Image = resim.Netlestir();
            //pictureBox4.Image = resim.Netlestir();


            plakaboyut.Visible = true;
            yeni_plakayeri.Visible = false;
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

       
      

        

      

        

    }




    public class ImageProcessor
    {
        public ImageProcessor()
        {
           
        }
        public ImageProcessor(Image parImage)
        {
            Img = parImage;
        }

        private Image _Img;
        private Bitmap bmp;

       
        public Image Img
        {
            get { return _Img; }
            set { _Img = value; bmp = new Bitmap(_Img); 
            }


        }

        public Image Boyutlandir(int width, int height) { return _Img.GetThumbnailImage(width, height, null, new IntPtr(12000000)); }

        public Image Kes(int y1, int x1, int y2, int x2)
        {
            Bitmap b = new Bitmap(x2 - x1, y2 - y1); 
            for (int i = x1; i < x2; i++)
            { 
                for (int j = y1; j < y2; j++) 
            { 
                    b.SetPixel(i - x1, j - y1, bmp.GetPixel(i, j));
                } 
            } 
            return b; }

        public Image Sinirbeyazlat(int ust, int alt, int sol, int sag)
        {


            if (ust != 0)
            for (int ust1 = 0; ust1 <= ust+1; ust1++)
                for (int s1 = 0; s1 < bmp.Width; s1++)
                    bmp.SetPixel(s1, ust1, Color.White);
           if (sol != 0)
            for (int sol1 = 0; sol1 <= sol+1; sol1++)
                for (int s1 = 0; s1 < bmp.Height; s1++)
                    bmp.SetPixel(sol1, s1, Color.White);

           if(alt !=0 )
            for (int alt1 = bmp.Height-1; alt1 >= alt-1; alt1--)
                for (int s1 = 0; s1 < bmp.Width; s1++)
                    bmp.SetPixel(s1, alt1, Color.White);
          if (sag != 0)
            for (int sag1 = sag-1; sag1 <bmp.Width; sag1++)
                for (int s1 = 0; s1 < bmp.Height; s1++)
                    bmp.SetPixel(sag1, s1, Color.White);
                    
            
            return bmp;
        }


        public Image RenkDegistir(Color clr1, Color clr2) { for (int i = 0; i < bmp.Width; i++) { for (int j = 0; j < bmp.Height; j++) { if (bmp.GetPixel(i, j) == clr1) { bmp.SetPixel(i, j, clr2); } } } return bmp; }

        public Image griyecevir() { 
            for (int i = 0; i < bmp.Width; i++) { 
                for (int j = 0; j < bmp.Height; j++) { 
                    int hede = (bmp.GetPixel(i, j).R + bmp.GetPixel(i, j).G + bmp.GetPixel(i, j).B) / 3; 
                    bmp.SetPixel(i, j, Color.FromArgb(hede, hede, hede)); 
                } 
            } 
            return bmp;
        }
       



        public int[] Yogunluk()
        {
            int enyukseksiyahsayisi = 0;
            int[] koseler = new int[9];
            Color c = Color.Black;


            
            for (int i = 0; i < bmp.Width-110; i++)
            {
                for (int j = 0; j < bmp.Height-27; j++)
                {
                    int siyahsayisi = 0;

                    for (int k=i;k<i+110 ;k++ )
                    {
                        for (int l=j;l<j+27 ;l++) {

                            if (bmp.GetPixel(k, l).Equals(Color.FromArgb(0,0,0)))
                               
                                {
                                siyahsayisi = siyahsayisi + 1;

                                if (siyahsayisi > enyukseksiyahsayisi) {

                                    enyukseksiyahsayisi = siyahsayisi;
                                    koseler[0] = i;//x1 top
                                    koseler[1] = j;//y1 left
                                    koseler[2] = i + 110;//x2//right
                                    koseler[3] = j;//y1//left
                                    koseler[4] = i;//x1//top
                                    koseler[5] = j+27;//botton
                                    koseler[6] = i + 110;//x2//right
                                    koseler[7] = j + 27;//y2//button
                                    koseler[8] = enyukseksiyahsayisi;

                                }

                            }
 
                        }
                    }   
                }

                bmp.SetPixel(koseler[0], koseler[1], Color.FromArgb(255, 0, 0));
                bmp.SetPixel(koseler[2], koseler[3], Color.FromArgb(255, 0, 0));
                bmp.SetPixel(koseler[4], koseler[5], Color.FromArgb(255, 0, 0));
                bmp.SetPixel(koseler[6], koseler[7], Color.FromArgb(255, 0, 0));
            }
            return koseler;
        }


        public Image binary()
        {
            for (int i = 0; i < bmp.Width-1 ; i++)
            {
                for (int j = 0; j < bmp.Height-1 ; j++)
                {

                    int r = bmp.GetPixel(i, j).R;
                    int g = bmp.GetPixel(i, j).G;
                    int b = bmp.GetPixel(i, j).B;


                    int r1 = bmp.GetPixel(i + 1, j).R;
                    int g1 = bmp.GetPixel(i + 1, j).G;
                    int b1 = bmp.GetPixel(i + 1, j).B;

                    int r2 = bmp.GetPixel(i, j + 1).R;
                    int g2 = bmp.GetPixel(i, j + 1).G;
                    int b2 = bmp.GetPixel(i, j + 1).B;

                    if ((System.Math.Sqrt((r - r1) * (r - r1) + (g - g1) * (g - g1) + (b - b1) * (b - b1)) >= 40) || (System.Math.Sqrt((r - r2) * (r - r2) + (g - g2) * (g - g2) + (b - b2) * (b - b2)) >= 40))
                    {
                        bmp.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        bmp.SetPixel(i, j, Color.FromArgb(255, 255, 255));

                    }


                }
            }
            return bmp;
        }



        public int[] Satir()
        {
             int[] siyahnokta1=new int[bmp.Height];
               // int[] beyaznokta = new int[bmp.Height];
             int[] siyahnokta2 = new int[bmp.Width];

            //satýrlardaki sýyah nokta sayýlarýný sayýp dýzýye atar
            for (int i = 0; i < bmp.Height; i++)
            {              
                for (int j = 0; j < bmp.Width; j++)
                {

                    if (Color.Black.R == bmp.GetPixel(j, i).R)
                        if (Color.Black.G == bmp.GetPixel(j, i).G)
                            if (Color.Black.B == bmp.GetPixel(j, i).B)
                                siyahnokta1[i] = siyahnokta1[i] + 1;
                }
            
            }

            //sutunlardaki sýyah nokta sayýlarýný sayýp dýzýye atar
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)

                {

                    if (Color.Black.R == bmp.GetPixel(i, j).R)
                        if (Color.Black.G == bmp.GetPixel(i, j).G)
                            if (Color.Black.B == bmp.GetPixel(i, j).B)
                                siyahnokta2[i] = siyahnokta2[i] + 1;
                }

            }
            int[] sinirlar ={300,300,300,300};
            int [] ustaltsinir={0,27};
            int [] solsagsinir ={0,110};
           
            //yukarý dogru cýkar 
            for (int u = (int)(bmp.Height/2); u>0; u--)
            {

                if ((siyahnokta1[u - 1] - siyahnokta1[u]) > 10)
                {
                    //(2*(siyahnokta1[u-1] - siyahnokta1[u-2])))
                    ustaltsinir[0] = u;
                }
                        
            } 
            //ortadan asagý iner
            for (int p = (int)(bmp.Height / 2); p < bmp.Height; p++)
            {

                if ((siyahnokta1[p] - siyahnokta1[p-1]) > 10)
                {
                    //(2*(siyahnokta1[p+1] - siyahnokta1[p])))
                    ustaltsinir[1] = p-1;
                }
                        
                        
            }

            //ortadan sola gider
            for (int u = (int)(bmp.Width / 2); u > 0; u--)
            {



                if ((siyahnokta2[u -1] - siyahnokta2[u]) > 6)
                {
                     
                        //(2*(siyahnokta1[u-1] - siyahnokta1[u-2])))
                    solsagsinir[0] = u;
                   
                }

               

            }

            if (siyahnokta2[0] < 3 || siyahnokta2[1] < 3 || siyahnokta2[2] < 3)
                solsagsinir[0] = siyahnokta2[2];


            //ortadan saga gider
            for (int p = (int)(bmp.Width / 2); p < bmp.Width; p++)
            {

                if ((siyahnokta2[p] - siyahnokta2[p -1]) > 6)
                {
                    //(2*(siyahnokta1[p+1] - siyahnokta1[p])))
                    solsagsinir[1] = p-1;
                }


            }


            sinirlar[0]=ustaltsinir[0];
            sinirlar[1]=ustaltsinir[1];
            sinirlar[2]=solsagsinir[0];
            sinirlar[3] =solsagsinir[1];


               
               
            
            return sinirlar;
        }


        public Image Netlestir()
        {

            double[,] array = new double[bmp.Width, bmp.Height];
      
            
      for (int i1 = 0; i1 < bmp.Width; i1++)
      {
          for (int j1 = 0; j1 < bmp.Height; j1++)
          {
               array[i1,j1] = (bmp.GetPixel(i1, j1).R + bmp.GetPixel(i1, j1).G + bmp.GetPixel(i1, j1).B) / 3;
              
          }

      }
            double ort,toplam =0;
             
            for (int i2 = 0; i2 < bmp.Width; i2++)
            {
                    for (int j2 = 0; j2 < bmp.Height; j2++)
                    {
                        toplam = toplam +array[i2,j2] ;

              
                    }
                 
            }
           
            
            ort = toplam / (bmp.Height*bmp.Width);

              
            for (int i = 0; i < bmp.Width; i++)
            {
                    for (int j = 0; j < bmp.Height; j++)
                    {

             if(array [i,j]> ort)
                    bmp.SetPixel(i, j, Color.White);
             else
                 bmp.SetPixel(i, j, Color.Black);

                    }
            }
     
    return bmp;


    }




        public int[] Harfkoorbulsolsag()
        {
            int[] satirsiyahnokta = new int[bmp.Height];
            // int[] beyaznokta = new int[bmp.Height];
            int[] sutunsiyahnokta = new int[bmp.Width];



            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {

                    if (Color.Black.R == bmp.GetPixel(j, i).R)
                        if (Color.Black.G == bmp.GetPixel(j, i).G)
                            if (Color.Black.B == bmp.GetPixel(j, i).B)
                                satirsiyahnokta[i] =  satirsiyahnokta[i] + 1;
                }

            }


            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {

                    if (Color.Black.R == bmp.GetPixel(i, j).R)
                        if (Color.Black.G == bmp.GetPixel(i, j).G)
                            if (Color.Black.B == bmp.GetPixel(i, j).B)
                                sutunsiyahnokta[i] = sutunsiyahnokta[i] + 1;
                }

            }
            
           
            int[] Harfkoordizi = new int[26];
            int z = 0;

            for (int u = 1 ; u <bmp.Width; u++)
            {


                
                if ((sutunsiyahnokta[u - 1] == 0 && sutunsiyahnokta[u] != 0) || (sutunsiyahnokta[u - 1] != 0 && sutunsiyahnokta[u] == 0))
                {
                    Harfkoordizi[z] = u;
                    z = z + 1;
                }

            }

            return Harfkoordizi;
        }

        public string s = "";
        public string bul()
        {
            int[] satirsiyahnokta = new int[bmp.Height];
            // int[] beyaznokta = new int[bmp.Height];
            int[] sutunsiyahnokta = new int[bmp.Width];


            string str = "";
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {

                    if (Color.Black.R == bmp.GetPixel(j, i).R)
                        if (Color.Black.G == bmp.GetPixel(j, i).G)
                            if (Color.Black.B == bmp.GetPixel(j, i).B)
                                satirsiyahnokta[i] = satirsiyahnokta[i] + 1;
                }
                if (i==0)
                {
                    str =  satirsiyahnokta[i].ToString();
                }
                else
                {
                    str = str+"/"+satirsiyahnokta[i];
                }
                
            }

            string stn = "";
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {

                    if (Color.Black.R == bmp.GetPixel(i, j).R)
                        if (Color.Black.G == bmp.GetPixel(i, j).G)
                            if (Color.Black.B == bmp.GetPixel(i, j).B)
                                sutunsiyahnokta[i] = sutunsiyahnokta[i] + 1;
                }
                if (i == 0)
                {
                    stn = sutunsiyahnokta[i].ToString();
                }
                else
                {
                    stn = stn + "/" + sutunsiyahnokta[i];
                }
            }
            DirectoryInfo adres = new DirectoryInfo(Application.StartupPath);
            SqlCeConnection bagla = new SqlCeConnection(@"Data Source=" + adres + "\\MyDatabase#1.sdf");
            bagla.Open();
            SqlCeCommand komut = new SqlCeCommand("Select karakter from veri where satir='"+str+"' and sütun ='"+stn+"'",bagla);
            SqlCeDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                s  = s +oku["karakter"].ToString();
            }
            bagla.Close();
            return s;
        }
        
        public int[] Harfkoorbulustalt()
        {
            int[] satirsiyahnokta = new int[bmp.Height];
            // int[] beyaznokta = new int[bmp.Height];
            int[] sutunsiyahnokta = new int[bmp.Width];


            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {

                    if (Color.Black.R == bmp.GetPixel(j, i).R)
                        if (Color.Black.G == bmp.GetPixel(j, i).G)
                            if (Color.Black.B == bmp.GetPixel(j, i).B)
                                satirsiyahnokta[i] = satirsiyahnokta[i] + 1;
                }

            }


            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {

                    if (Color.Black.R == bmp.GetPixel(i, j).R)
                        if (Color.Black.G == bmp.GetPixel(i, j).G)
                            if (Color.Black.B == bmp.GetPixel(i, j).B)
                                sutunsiyahnokta[i] = sutunsiyahnokta[i] + 1;
                }

            }
            

            int[] Harfkoordizi = new int[26];
            for (int u = 1; u < bmp.Height; u++)
            {


                int z = 0;
                if ((satirsiyahnokta[u - 1] == 0 && satirsiyahnokta[u] != 0 )|| (satirsiyahnokta[u - 1] != 0 && satirsiyahnokta[u] == 0))
                {
                    Harfkoordizi[z] = u;
                    z = z + 1;
                }

            }

            return Harfkoordizi;
        }












    }



}