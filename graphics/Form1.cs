namespace graphics
{    public partial class Form1 : Form
    {//  كود  للشاشه يكون لونها بيبي بلو 
        private Bitmap drawArea;
        private Pen pen;
        public Form1()
        {
            InitializeComponent();
            drawArea = new Bitmap(Canvas.Size.Width, Canvas.Size.Height);
            Canvas.Image = drawArea;

            using (Graphics g = Graphics.FromImage(drawArea))
            {
                g.Clear(Color.LightBlue);
            }

            pen = new Pen(Brushes.Black, 3);
        }
        // كود امكانيه اضافه نقط بيضاء علي الشاشه عند النقر عليها بالماوس 
        private const int RADIUS = 10;
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                 {
                 using (Graphics g = Graphics.FromImage(drawArea))
                    {
                     g.FillEllipse(Brushes.White, e.X - RADIUS, e.Y - RADIUS, RADIUS * 2, RADIUS * 2);
                     }
                Canvas.Refresh();
                 }
                        // كود اضافه حدود لونها اسود علي كل دائره
            if (e.Button == MouseButtons.Left)
                 {
              using (Graphics g = Graphics.FromImage(drawArea))
                     {
                    g.FillEllipse(Brushes.White, e.X - RADIUS, e.Y - RADIUS, RADIUS * 2, RADIUS * 2);
                     g.DrawEllipse(pen, e.X - RADIUS, e.Y - RADIUS, RADIUS * 2, RADIUS * 2);
                     }
                Canvas.Refresh();
                 }
        }
         
    }
}
