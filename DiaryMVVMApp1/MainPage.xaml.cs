using DiaryMVVMApp1.Models;
using DiaryMVVMApp1.ViewModels;
using DiaryMVVMApp1.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace DiaryMVVMApp1
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {

        
        public MainPage()
        {
            this.InitializeComponent();
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            RightFrame.Navigate(typeof(RemindContentPage));
        }

        private void MyPivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RightFrameViewChange();
        }

        private void EditAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            RightFrameViewChange();
        }

        private void RightFrameViewChange()
        {
            if (MyPivot.SelectedIndex == 0)
            {
                RightFrame.Navigate(typeof(RemindContentPage));
            }
            else
            {
                RightFrame.Navigate(typeof(DiaryContentPage));
            }
        }
    }
}
