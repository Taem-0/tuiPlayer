using Terminal.Gui.App;
using Terminal.Gui.Configuration;
using Terminal.Gui.ViewBase;
using Terminal.Gui.Views;
using tuiPlayer;
using tuiPlayer.Views;

ConfigurationManager.Enable(ConfigLocations.All);

Application
    .Create()
    .Run<MainWindow>()
    .Dispose();

namespace tuiPlayer
{
    public sealed class MainWindow : Runnable
    {
        public MainWindow()
        {
            queuePane queuePane = new()
            {
                Width = Dim.Fill(),
                Height = Dim.Fill()
            };

            Add(queuePane);
        }
    }
}