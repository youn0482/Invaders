using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Invaders
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {
        public GamePage()
        {
            this.InitializeComponent();


            Canvas.SetTop(player, Window.Current.Bounds.Height - (player.Height + 20));
            Canvas.SetLeft(player, Window.Current.Bounds.Width / 2);


        }

       
             private void Grid_KeyDown(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs args)
                {
                    if (args.VirtualKey == Windows.System.VirtualKey.Right)
                        Canvas.SetLeft(player, Canvas.GetLeft(player) + 30);
                    else if (args.VirtualKey == Windows.System.VirtualKey.Left)
                        Canvas.SetLeft(player, Canvas.GetLeft(player) - 30);
                }
    
    }
}
