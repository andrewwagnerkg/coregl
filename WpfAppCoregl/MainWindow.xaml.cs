namespace WpfAppCoregl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GLView.MouseWheel += OnMouseWheel;
            GLView.MouseDown += OnMouseDown;
            GLView.MouseUp += OnMouseUp;
        }

        private void Render() => GLView.InvalidateVisual();

        private void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            Render();
        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            Render();
        }

        private void OnMouseWheel(object sender, MouseWheelEventArgs e)
        {
            Render();
        }

        private void GLView_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            //TODO Render an image
            //it rises by Render method
        }
    }
}
