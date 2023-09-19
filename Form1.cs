using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyNeuralNetwork
{
    public partial class Form1 : Form
    {
        int inputLayerNeurons = 784;
        int hiddenLayerNeurons = 120;
        int outputLayerNeurons = 6;
        double learningRate = 0.2;
        NeuralNetwork neuralNetwork;
        Pen pen = new Pen(Color.DarkOliveGreen, 20f);
        private Point startPoint;
        Graphics graphics;
        
        public Form1()
        {
            InitializeComponent();
            drawPicture.Image = new Bitmap(drawPicture.Width, drawPicture.Height);
            answerLabel.Anchor = AnchorStyles.None;
            neuralNetwork = new NeuralNetwork(inputLayerNeurons, hiddenLayerNeurons, outputLayerNeurons, learningRate);
            numberList.Items.AddRange(AddNumbers());
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private void drawPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point endPoint = new Point(e.X, e.Y);
                Bitmap image = (Bitmap)drawPicture.Image;
                using (Graphics graphics = Graphics.FromImage(image))
                {
                    graphics.DrawLine(pen, startPoint, endPoint);
                }
                drawPicture.Image = image;
                startPoint = endPoint;
            }
        }
        private void drawPicture_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = new Point(e.X, e.Y);
            if (e.Button == MouseButtons.Right)
            {
                CleanImage();
            }
        }
        
        private void CleanButton_Click(object sender, EventArgs e)
        {
            CleanImage();
        }
        private void CleanImage()
        {
            drawPicture.Image = (Image)new Bitmap(drawPicture.Width, drawPicture.Height);
            inputPicture.Image = (Image)new Bitmap(inputPicture.Width, inputPicture.Height);
        }
        
        private void PredictButton_Click(object sender, EventArgs e)
        {
            inputPicture.Image = new Bitmap(drawPicture.Image, 28, 28);
            double[] arrayImage = LeadImage((Bitmap)inputPicture.Image);
            double[,] answer = neuralNetwork.Predict(arrayImage);

            answerLabel.Text =  $"{CheckDigit(answer)}";
        }
        private void TrainButton_Click(object sender, EventArgs e)
        {
            int literalNumber = int.Parse(numberList.Text);
            double[] targets = CreateLearnStuff(int.Parse(numberList.Text));
            double[] arrayImage = LeadImage((Bitmap)inputPicture.Image);
            neuralNetwork.Train(arrayImage, targets);
        }

        public double[] LeadImage(Bitmap image)
        {
            double[] res = new double[image.Width * image.Width];

            Bitmap img = new Bitmap(image);
            int count = 0;
            for (int i = 0; i < img.Width; i++)
                for (int j = 0; j < img.Height; j++)
                {
                    if (img.GetPixel(i, j).R > 1 || img.GetPixel(i, j).G > 1 || img.GetPixel(i, j).B > 1)
                        res[count] = 1.0;
                    else
                        res[count] = 0.0;
                    count++;
                }
            return res;
        }

        private double[] CreateLearnStuff(int target)
        {
            double[] targets = new double[outputLayerNeurons];
            for (int i = 0; i < targets.Length; i++)
                targets[i] = 0.01;
            targets[target] = 0.99;
            return targets;
        }

        private List<string> AddNumbers()
        {
            List<string> numbers = new List<string>();
            for (int i = 0; i < outputLayerNeurons; i++)
                numbers.Add(i.ToString());
            return numbers;
        }
        private int CheckDigit(double[,] resultOutputs)
        {
            int number = -1;
            double mass = 0;
            for (int i = 0; i < resultOutputs.GetLength(0); i++)
            {
                if (resultOutputs[i, 0] > mass)
                {
                    mass = resultOutputs[i, 0];
                    number = i;
                }
            }
            return number;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            neuralNetwork.Serialize();
        }
        private void UploadButton_Click(object sender, EventArgs e)
        {
            neuralNetwork.Deserialize();
        }
        
    }
}
