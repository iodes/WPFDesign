using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using WPFDesign.Designer.Xaml;

namespace WPFDesignSample
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string xaml = @"<Window xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
                                    xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml""
                                    xmlns:d=""http://schemas.microsoft.com/expression/blend/2008""
                                    xmlns:mc=""http://schemas.openxmlformats.org/markup-compatibility/2006""
                                    mc:Ignorable=""d""
                                    Title=""Window"" Height=""300"" Width=""300"">
                                <Grid>

                                </Grid>
                            </Window>";

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            using (var xmlReader = XmlReader.Create(new StringReader(xaml)))
            {
                // 디자이너 설정 적용
                var settings = new XamlLoadSettings();

                // 디자이너 창 불러오기
                designSurface.LoadDesigner(xmlReader, settings);
            }
        }
    }
}
