using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing.Imaging;
using System.Threading;

namespace Emotion
{
    public partial class Form1 : Form
    {
        Image<Bgr, Byte> CameraImage;
        Capture camera;

        CascadeClassifier face;
        CascadeClassifier eye;
        CascadeClassifier smile;
        CascadeClassifier em;
        CascadeClassifier mouth;
        CascadeClassifier mouth2;

        public Form1()
        {
            InitializeComponent();

            face = new CascadeClassifier("haarcascade_frontalface_default.xml");
            eye = new CascadeClassifier("haarcascade_eye.xml");
            smile = new CascadeClassifier("haarcascade_smile.xml");
            em = new CascadeClassifier("haarcascade_frontalface_emotion.xml");
            mouth = new CascadeClassifier("haarcascade_mouth.xml");
            mouth2 = new CascadeClassifier("Mouth.xml");
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            Strelka.BackColor = Color.Transparent;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            camera = new Capture();
            Application.Idle += Application_Idle;
            button1.Enabled = false;
            timerOb.Start();
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            CameraImage = camera.QueryFrame().ToImage<Bgr, byte>().Resize(640, 480, Inter.Cubic);
          
            Rectangle[] facesDetected = face.DetectMultiScale(CameraImage, 1.2, 10, new Size(10, 10), new Size(640, 480));//И это то с вебкой 640х360, лол
            // Rectangle[] emDetected = em.DetectMultiScale(CameraImage, 1.2, 10, new Size(10, 10), new Size(640, 480));
            bool[] Timers = new bool[5];//булы на то, какие таймера запускать/останавливать с этого кадра
            imageBox1.Controls.Clear();//убрать предыдущие эмодзи
            double koof = 1.0 / facesDetected.Length;
            double proc = 0;
            double netproc = 0;
            foreach (Rectangle f in facesDetected)
            {
                    PictureBox Emotion = new PictureBox();
                    CameraImage.Draw(f, new Bgr(Color.Black), 2);//отрисовка квадрата вокруг лица

                    Point Txt = new Point(f.X, f.Y);

                    CameraImage.ROI = f;//ограничиваем область поиска найденным лицом
                
                    Rectangle[] eyesDetected = eye.DetectMultiScale(CameraImage, 1.2, 10, new Size(8, 8), new Size(160, 120));//находит все глаза и записывает координаты в массив
                    Rectangle[] smileDetected = smile.DetectMultiScale(CameraImage, 1.33, 40, new Size(16, 12), new Size(320, 240));//находит улыбки и записывает координаты в массив
                    Rectangle[] mouthDetected = mouth.DetectMultiScale(CameraImage, 1.33, 40, new Size(16, 12), new Size(320, 240));//наход рты раз
                    Rectangle[] mouth2Detected = mouth2.DetectMultiScale(CameraImage, 1.33, 40, new Size(16, 12), new Size(320, 240));//находит рты два

                    CameraImage.ROI = Rectangle.Empty;//возвращаем область в нормальное состояние для работы
                    bool TimerNet = true;//для определения, остается ли нейтральное лицо(для таймера)
                    Image emotion = Image.FromFile("neutral.png");
                    
                    Emotion.Width = 65;
                    Emotion.Height = 65;
                    Emotion.SizeMode = PictureBoxSizeMode.Zoom;

                    if (smileDetected.Length > 0)
                    {
                        emotion = Image.FromFile("happy.png");
                    Timers[1] = true;
                    TimerNet = false;
                    proc += koof * 1;
                    }
                    else
                    {
                        if (eyesDetected.Length == 0)
                        {
                            emotion = Image.FromFile("sleep.png");
                        Timers[4] = true;
                        TimerNet = false;
                        netproc += koof * 0.5;
                    }
                        if (eyesDetected.Length == 1)
                        {
                            emotion = Image.FromFile("wink.png");
                        Timers[3] = true;
                        TimerNet = false;
                        proc += koof * 0.5;
                    }
                        if ((mouthDetected.Length == 0 && mouth2Detected.Length == 0) && eyesDetected.Length > 1)
                        {
                            emotion = Image.FromFile("sad.png");
                        Timers[2] = true;
                        TimerNet = false;
                        proc -= koof * 1;
                    }
                    }
                if (TimerNet)
                {
                    Timers[0] = true;
                    netproc += koof * 0.5;
                }
                Point P = new Point(f.X - 40, f.Y - 65);
                Emotion.Location = P;
                Emotion.Image = emotion;
                Emotion.Parent = imageBox1;
                Emotion.BackColor = Color.Transparent;
            }
            YpravTimer(Timers);
            Shkala(proc, netproc);
            imageBox1.Image = CameraImage;//отрисовывает изображение на элементе формы
        }
        private void Shkala(double P, double N)
        {
            if (Math.Abs(P) >= N)
            {
                if (P < 0)
                    P += N;
                if (P > 0)
                    P -= N;
            }
            else P = 0;
            Point K = new Point(717, 394);
            K.Y -= (int)Math.Ceiling(132 * P);
            Strelka.Location = K;
        }
        private void YpravTimer(bool[] T)
        {
            if (T[0])
                NeturalT.Start();
            else
                NeturalT.Stop();
            if (T[1])
                HappyT.Start();
            else
                HappyT.Stop();
            if (T[2])
                SadT.Start();
            else
                SadT.Stop();
            if (T[3])
                WinkT.Start();
            else
                WinkT.Stop();
            if (T[4])
                SleepT.Start();
            else
                SleepT.Stop();
        }
        private void timerOb_Tick(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(label6.Text);
            i++;
            label6.Text = i.ToString();
        }

        private void NeturalT_Tick(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(label1.Text);
            i++;
            label1.Text = i.ToString();
        }

        private void HappyT_Tick(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(label2.Text);
            i++;
            label2.Text = i.ToString();
        }

        private void SadT_Tick(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(label3.Text);
            i++;
            label3.Text = i.ToString();
        }

        private void WinkT_Tick(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(label4.Text);
            i++;
            label4.Text = i.ToString();
        }

        private void SleepT_Tick(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(label5.Text);
            i++;
            label5.Text = i.ToString();
        }
    }

}

