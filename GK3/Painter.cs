using System.Drawing.Drawing2D;

namespace GK3
{
    public class Painter
    {
        public Bitmap Curves { get; set; }
        public Bitmap Image { get; set; }
        public Bitmap GrayScaleImage { get; set; }
        public DirectBitmap C {  get; set; }
        public DirectBitmap M { get; set; }
        public DirectBitmap Y { get; set; }
        public DirectBitmap K { get; set; }
        public int[,] Val { get; set; }
        private readonly int dim;
        private readonly Pen[] pens = new Pen[4] { new(Color.Cyan), new(Color.Magenta), new(Color.Yellow), new(Color.Black) };
        private readonly Brush brush = new SolidBrush(Color.Black);
        private readonly Brush selectionBrush = new SolidBrush(Color.Lime);
        public Point[,] points = new Point[4, 4];
        public int Active { get; set; }
        public bool AllVisible {  get; set; }
        public bool IsGrayscale { get; set; }
        public int selectedIndex { get; set; }

        public Painter(int dim)
        {
            this.dim = dim;
            AllVisible = true;
            selectedIndex = 5;
            Curves = new Bitmap(dim, dim);
            C = new DirectBitmap(dim, dim);
            M = new DirectBitmap(dim, dim);
            Y = new DirectBitmap(dim, dim);
            K = new DirectBitmap(dim, dim);
            Val = new int[4, dim];
            for (int j = 0; j < 4; ++j) for (int i = 0; i < dim; ++i) Val[j, i] = i;
            for (int i = 0; i < 4; ++i)
            {
                points[i, 0] = new Point(0, 349);
                points[i, 1] = new Point(117, 233);
                points[i, 2] = new Point(233, 117);
                points[i, 3] = new Point(349, 0);
            }
            PaintCurves();
        }

        public void PaintCurves()
        {
            Graphics g = Graphics.FromImage(Curves);
            g.Clear(Color.White);
            if (AllVisible)
            {
                for (int i = 0; i < 4; ++i)
                {
                    g.DrawBezier(pens[i], points[i, 0], points[i, 1], points[i, 2], points[i, 3]);
                    for (int j = 0; j < 4; ++j)
                    {
                        if (selectedIndex == j && Active == i) g.FillEllipse(selectionBrush, new Rectangle(new Point(points[i, j].X - 5, points[i, j].Y - 5), new Size(10, 10)));
                        else g.FillEllipse(brush, new Rectangle(new Point(points[i, j].X - 5, points[i, j].Y - 5), new Size(10, 10)));
                    }
                }
            }
            else
            {
                g.DrawBezier(pens[Active], points[Active, 0], points[Active, 1], points[Active, 2], points[Active, 3]);
                for (int j = 0; j < 4; ++j)
                {
                    if (selectedIndex == j) g.FillEllipse(selectionBrush, new Rectangle(new Point(points[Active, j].X - 5, points[Active, j].Y - 5), new Size(10, 10)));
                    else g.FillEllipse(brush, new Rectangle(new Point(points[Active, j].X - 5, points[Active, j].Y - 5), new Size(10, 10)));
                }
            }
        }

        public void PaintCMYK()
        {
            if (Image is null) return;
            (int, int, int, int) temp;
            if (IsGrayscale)
            {
                for (int i = 0; i < dim; ++i)
                {
                    for (int j = 0; j < dim; ++j)
                    {
                        temp = Statics.RGBtoCMYK(GrayScaleImage.GetPixel(i, j));
                        C.SetPixel(i, j, Color.FromArgb(255 - Math.Min(temp.Item1 + Val[0, temp.Item4], 255), 255, 255));
                        M.SetPixel(i, j, Color.FromArgb(255, 255 - Math.Min(temp.Item2 + Val[1, temp.Item4], 255), 255));
                        Y.SetPixel(i, j, Color.FromArgb(255, 255, 255 - Math.Min(temp.Item3 + Val[2, temp.Item4], 255)));
                        K.SetPixel(i, j, Color.FromArgb(255 - Val[3, temp.Item4], 255 - Val[3, temp.Item4], 255 - Val[3, temp.Item4]));
                    }
                }
            }
            else
            {
                for (int i = 0; i < dim; ++i)
                {
                    for (int j = 0; j < dim; ++j)
                    {
                        temp = Statics.RGBtoCMYK(Image.GetPixel(i, j));
                        C.SetPixel(i, j, Color.FromArgb(255 - Math.Min(temp.Item1 + Val[0, temp.Item4], 255), 255, 255));
                        M.SetPixel(i, j, Color.FromArgb(255, 255 - Math.Min(temp.Item2 + Val[1, temp.Item4], 255), 255));
                        Y.SetPixel(i, j, Color.FromArgb(255, 255, 255 - Math.Min(temp.Item3 + Val[2, temp.Item4], 255)));
                        K.SetPixel(i, j, Color.FromArgb(255 - Val[3, temp.Item4], 255 - Val[3, temp.Item4], 255 - Val[3, temp.Item4]));
                    }
                }
            }
        }

        public void CalculateY(int index)
        {
            GraphicsPath myPath = new();
            myPath.AddBeziers(new Point[] { points[index, 0], points[index, 1], points[index, 2], points[index, 3] });
            myPath.Flatten();
            int n = myPath.PathPoints.Length - 1;
            double[] slopes = new double[n];
            for (int i = 0; i < n; ++i) slopes[i] = (myPath.PathPoints[i + 1].Y - myPath.PathPoints[i].Y)/(myPath.PathPoints[i + 1].X - myPath.PathPoints[i].X);
            int currentSlope = 0;
            for (int i = 0; i < dim; ++i)
            {
                while (i > myPath.PathPoints[currentSlope + 1].X) ++currentSlope;
                Val[index, i] = 255 - (int)(((myPath.PathPoints[currentSlope].Y - slopes[currentSlope] * (myPath.PathPoints[currentSlope].X - i))/dim)*255);
            }
        }
    }
}
