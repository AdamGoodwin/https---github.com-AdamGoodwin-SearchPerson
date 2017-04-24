using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using SearchPersonDomain.Classes;
using SearchPersonDomain.DataModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfShare
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            DataHelpers.NewDbWithSeed();
        }
    }
}
