namespace GK3
{
    public partial class Form1 : Form
    {
        private Painter painter;
        private readonly int dim = 350;
        private Point previousLocation;

        public Form1()
        {
            painter = new Painter(dim);
            InitializeComponent();
            painter.PaintCurves();
            curveBox.Image = painter.Curves;
            cBox.Image = painter.C.Bitmap;
            mBox.Image = painter.M.Bitmap;
            yBox.Image = painter.Y.Bitmap;
            kBox.Image = painter.K.Bitmap;
            curveBox.Invalidate();
            painter.CalculateY(0);
        }

        private void buttonCurveLoad_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using StreamReader sr = new(openFileDialog.FileName);
                    for (int j = 0; j < 4; ++j)
                    {
                        for (int i = 0; i < 4; ++i)
                        {
                            painter.points[j, i].X = int.Parse(sr.ReadLine()!);
                            painter.points[j, i].Y = int.Parse(sr.ReadLine()!);
                        }
                        for (int i = 0; i < dim; ++i) painter.Val[j, i] = int.Parse(sr.ReadLine()!);
                    }
                    ReloadCurves();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wybrany plik tesktowy nie zawiera danych opisujących odpowiednie krzywe.", "Niepoprawny plik");
                }
            }
        }

        private void buttonCurveSave_Click(object sender, EventArgs e)
        {
            using StreamWriter writer = new(AppDomain.CurrentDomain.BaseDirectory + "curves.txt");
            for (int j = 0; j < 4; ++j)
            {
                for (int i = 0; i < 4; ++i)
                {
                    writer.WriteLine(painter.points[j, i].X);
                    writer.WriteLine(painter.points[j, i].Y);
                }
                for (int i = 0; i < dim; ++i) writer.WriteLine(painter.Val[j, i]);
            }
        }

        private void buttonPictureSelect_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.BMP;*.JPG;*.GIF;*.jpg;*.jpeg;*.PNG;*.png";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                painter.Image = Statics.ResizeImage(Image.FromFile(openFileDialog.FileName), dim);
                painter.GrayScaleImage = Statics.MakeGrayscale(painter.Image);
                if (checkBoxCiB.Checked) originalBox.Image = painter.GrayScaleImage;
                else originalBox.Image = painter.Image;
                originalBox.Refresh();
                painter.PaintCMYK();
                reloadCMYK();
            }
        }

        private void buttonSavePictures_Click(object sender, EventArgs e)
        {
            painter.C.Bitmap.Save("C.png");
            painter.M.Bitmap.Save("M.png");
            painter.Y.Bitmap.Save("Y.png");
            painter.K.Bitmap.Save("K.png");
        }

        private void checkBoxCiB_CheckedChanged(object sender, EventArgs e)
        {
            painter.IsGrayscale = ((CheckBox)sender).Checked;
            if (checkBoxCiB.Checked) originalBox.Image = painter.GrayScaleImage;
            else originalBox.Image = painter.Image;
            originalBox.Refresh();
            painter.PaintCMYK();
            reloadCMYK();
        }

        private void curveBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && painter.selectedIndex < 5)
            {
                if (painter.selectedIndex == 1 || painter.selectedIndex == 2)
                {
                    painter.points[painter.Active, painter.selectedIndex].X = 
                        Math.Min(Math.Max(painter.points[painter.Active, painter.selectedIndex].X + e.X - previousLocation.X, 0), dim - 1);
                }
                painter.points[painter.Active, painter.selectedIndex].Y = 
                    Math.Min(Math.Max(painter.points[painter.Active, painter.selectedIndex].Y + e.Y - previousLocation.Y, 0), dim - 1);
                previousLocation = e.Location;
                painter.CalculateY(painter.Active);
                ReloadCurves();
            }
            previousLocation = e.Location;
        }

        private void buttonC0_Click(object sender, EventArgs e)
        {
            int val = dim - 1;
            for (int i = 0; i < 4; ++i) painter.points[3, i].Y = val;
            for (int i = 0; i < dim; ++i) painter.Val[3, i] = 0;
            for (int j = 0; j < 3; ++j)
            {
                painter.points[j, 0] = new Point(0, 349);
                painter.points[j, 1] = new Point(117, 233);
                painter.points[j, 2] = new Point(233, 117);
                painter.points[j, 3] = new Point(349, 0);
                for (int i = 0; i < dim; ++i) painter.Val[j, i] = i;
            }
            ReloadCurves();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            painter.points[3, 0] = new Point(0, 349);
            painter.points[3, 1] = new Point(117, 233);
            painter.points[3, 2] = new Point(233, 117);
            painter.points[3, 3] = new Point(349, 0);
            for (int i = 0; i < dim; ++i) painter.Val[3, i] = i;
            int val = dim - 1;
            for (int j = 0; j < 3; ++j)
            {
                for (int i = 0; i < 4; ++i) painter.points[j, i].Y = val;
                for (int i = 0; i < dim; ++i) painter.Val[j, i] = 0;
            }
            ReloadCurves();
        }

        private void buttonUCR_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 3; ++j)
            {
                painter.points[j, 0] = new Point(0, 349);
                painter.points[j, 1] = new Point(117, 233);
                painter.points[j, 2] = new Point(233, 0);
                painter.points[j, 3] = new Point(349, 50);
            }
            painter.points[3, 0] = new Point(0, 349);
            painter.points[3, 1] = new Point(349, 349);
            painter.points[3, 2] = new Point(300, 280);
            painter.points[3, 3] = new Point(349, 10);
            for (int i = 0; i < 4; ++i) painter.CalculateY(i);
            ReloadCurves();
        }

        private void buttonGCR_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 3; ++j)
            {
                painter.points[j, 0] = new Point(0, 349);
                painter.points[j, 1] = new Point(180, 150);
                painter.points[j, 2] = new Point(220, 110);
                painter.points[j, 3] = new Point(349, 100);
            }
            painter.points[3, 0] = new Point(0, 349);
            painter.points[3, 1] = new Point(330, 345);
            painter.points[3, 2] = new Point(300, 120);
            painter.points[3, 3] = new Point(349, 0);
            for (int i = 0; i < 4; ++i) painter.CalculateY(i);
            ReloadCurves();
        }

        private void reloadCMYK()
        {
            cBox.Invalidate();
            mBox.Invalidate();
            yBox.Invalidate();
            kBox.Invalidate();
        }

        private void checkBoxShowAll_CheckedChanged(object sender, EventArgs e)
        {
            painter.AllVisible = ((CheckBox)sender).Checked;
            painter.PaintCurves();
            curveBox.Invalidate();
        }

        private void radioButtonC_CheckedChanged(object sender, EventArgs e) { RadioButtonAction(); }
        private void radioButtonM_CheckedChanged(object sender, EventArgs e) { RadioButtonAction(); }
        private void radioButtonY_CheckedChanged(object sender, EventArgs e) { RadioButtonAction(); }
        private void radioButtonK_CheckedChanged(object sender, EventArgs e) { RadioButtonAction(); }

        private void RadioButtonAction()
        {
            if (radioButtonC.Checked) painter.Active = 0;
            else if (radioButtonM.Checked) painter.Active = 1;
            else if (radioButtonY.Checked) painter.Active = 2;
            else painter.Active = 3;
            painter.selectedIndex = 5;
            painter.PaintCurves();
            curveBox.Invalidate();
        }

        private void curveBox_MouseDown(object sender, MouseEventArgs e)
        {
            Point p;
            for (int i = 0; i < 4; ++i)
            {
                p = painter.points[painter.Active, i];
                if (Math.Sqrt((e.X - p.X) * (e.X - p.X) + (e.Y - p.Y) * (e.Y - p.Y)) <= 10)
                {
                    painter.selectedIndex = i;
                    painter.PaintCurves();
                    curveBox.Invalidate();
                    return;
                }
            }
            painter.selectedIndex = 5;
            painter.PaintCurves();
            curveBox.Invalidate();
        }

        private void ReloadCurves()
        {
            painter.PaintCurves();
            painter.PaintCMYK();
            curveBox.Invalidate();
            reloadCMYK();
        }
    }
}
