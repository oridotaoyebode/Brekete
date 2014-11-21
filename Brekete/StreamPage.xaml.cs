using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.PlayerFramework.Adaptive;

namespace Brekete
{
  public partial class StreamPage : PhoneApplicationPage
  {
    public StreamPage()
    {
      InitializeComponent();
      player.Plugins.Add(new AdaptivePlugin());
    }

    protected override void OnNavigatedFrom(NavigationEventArgs e)
    {
      player.Dispose();
      base.OnNavigatedFrom(e);
    }
  }
}