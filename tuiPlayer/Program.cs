using Terminal.Gui.App;
using Terminal.Gui.Configuration;
using Terminal.Gui.ViewBase;
using Terminal.Gui.Views;
using tuiPlayer;
using tuiPlayer.Views;

ConfigurationManager.Enable(ConfigLocations.All);

Application
    .Create()
    .Init()
    .Run<mainWindow>()
    .Dispose();


    
            /*queuePane queuePane = new()
            {
                Width = Dim.Fill(),
                Height = Dim.Fill()
            };

            Add(queuePane);
            */

            
        

       
    
