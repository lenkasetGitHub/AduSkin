﻿using AduSkin.Demo.Data;
using AduSkin.Demo.Models;
using AduSkin.Demo.UserControls;
using AduSkin.Demo.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace AduSkin.Demo.ViewModel
{
   public class MainViewModel : ViewModelBase
   {
      public MainViewModel()
      {

      }

      /// <summary>
      /// 命令Command
      /// </summary>
      public ICommand OpenClick => new RelayCommand<string>((e) =>
      {
         switch (e)
         {
            case "AduSkinDemo":
               new AduSkinDemo().Show();
               return;
            default:
               break;
         }
      });

      /// <summary>
      /// 常见控件
      /// </summary>
      private UserControl _CommonControlCase = new CommonControlCase();
      public UserControl CommonControlCase
      {
         get { return _CommonControlCase; }
         set { Set(ref _CommonControlCase, value); }
      }
      /// <summary>
      /// 实用案例
      /// </summary>
      private UserControl _PracticalCase = new PracticalCase();
      public UserControl PracticalCase
      {
         get { return _PracticalCase; }
         set { Set(ref _PracticalCase, value); }
      }
      /// <summary>
      /// 关于
      /// </summary>
      private UserControl _AduSkinAbout = new AduSkinAbout();
      public UserControl AduSkinAbout
      {
         get { return _AduSkinAbout; }
         set { Set(ref _AduSkinAbout, value); }
      }
   }
}
