﻿using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using TJFramework;
using TJFramework.FrameworkSettings;

namespace PolymorphismTest1
{
  static class Program
  {
  const string ApplicationUniqueName = "PolymorphismTest1";
  private static Mutex AxMutex = null;

  public static MySettings ApplicationSettings { get => TJFrameworkManager.ApplicationSettings<MySettings>(); } // User custom settings in Property Grid //

  public static TJStandardFrameworkSettings FrameworkSettings { get; } = TJFrameworkManager.FrameworkSettings; // Framework embedded settings //

  private static void TestEventPageChanged(string PageName)
  {
    MessageBox.Show("You have changed a page = " + PageName);
  }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      AxMutex = new Mutex(true, ApplicationUniqueName, out bool createdNew);
      if (!createdNew)
      {
        MessageBox.Show("Another instance of the application is already running.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      TJFrameworkManager.Logger.FileSizeLimitBytes = 1000000;
      TJFrameworkManager.Logger.Create();

      TJFrameworkManager.Service.CreateApplicationSettings<MySettings>();
      TJFrameworkManager.Service.AddForm<RadForm1>("Это форма номер 1");
      TJFrameworkManager.Service.SetMainFormCaption("Привет! Это главная форма 123.");
      //TJFrameworkManager.Service.SetMainPageViewOrientation(StripViewAlignment.Left);

      FrameworkSettings.HeaderFormSettings = "Настройки";
      FrameworkSettings.HeaderFormLog = "Сообщения";
      FrameworkSettings.HeaderFormExit = "Выход";
      //FrameworkSettings.ConfirmExitButtonText = "Подтвердите выход";

      FrameworkSettings.MainFormMinimizeToTray = false;
      FrameworkSettings.VisualEffectOnStart = true;
      FrameworkSettings.VisualEffectOnExit = true;

      FrameworkSettings.ValueColumnWidthPercent = 60;
      FrameworkSettings.MainPageViewReducePadding = true;
      FrameworkSettings.RememberMainFormLocation = true;
      FrameworkSettings.PageViewFont = new Font("Verdana", 10);

      FrameworkSettings.FontAlertText = new Font("Verdana", 8);
      FrameworkSettings.FontAlertCaption = new Font("Verdana", 8);
      FrameworkSettings.MaxAlertCount = 3;
      FrameworkSettings.LimitNumberOfAlerts = true;
      FrameworkSettings.SecondsAlertAutoClose = 5;

      Action ExampleOfVisualSettingsAndEvents = () =>
      {
        FrameworkSettings.MainFormMargin = 50;
        FrameworkSettings.PageViewItemSize = new Size(200, 30);
        FrameworkSettings.ItemSizeMode = PageViewItemSizeMode.EqualSize;
        FrameworkSettings.PageViewItemSpacing = 50;
        FrameworkSettings.PropertyGridPadding = new Padding(155, 100, 45, 25);

        // Привязка различных событий фреймворка к методам класса CxManager //
        //TJFrameworkManager.Service.EventPageChanged = Manager.EventPageChanged;
        //TJFrameworkManager.Service.EventBeforeMainFormClose = Manager.EventBeforeMainFormClose;
        //TJFrameworkManager.Service.EventBeforeMainFormCloseAsync = Manager.EventBeforeMainFormCloseAsync();
      };

      TJFrameworkManager.Run();
    }
  }
}