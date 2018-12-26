using DiaryMVVMApp1.Models;
using DiaryMVVMApp1.ViewModels;
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

        public DiaryListViewModel diaryListViewModel;
        public MainPage()
        {
            this.InitializeComponent();
            LoadDiaries();
            this.DataContext = diaryListViewModel;
        }

        private void LoadDiaries()
        {
            ObservableCollection<Diary> diaries = 
                new ObservableCollection<Diary>
            {
                new Diary
                {
                    Date="2018-11-11",
                    Weather="晴",
                    Content="阴"
                }
            };

            diaryListViewModel = 
                new DiaryListViewModel(diaries);
        }
    }
}
