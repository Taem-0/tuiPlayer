using Terminal.Gui.App;
using Terminal.Gui.Configuration;
using tuiPlayer.Views;

ConfigurationManager.Enable(ConfigLocations.All);

Application
  .Create()
  .Init()
  .Run<mainWindow>()
  .Dispose();


    
            

            
        

       
    
