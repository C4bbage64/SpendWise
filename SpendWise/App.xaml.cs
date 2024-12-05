namespace SpendWise
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Set AppShell as the main page
            MainPage = new AppShell();
        }

        /*protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }*/
    }
}