using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TJFramework;
using static TJFramework.Logger.Manager;
using static TJFramework.TJFrameworkManager;

namespace PolymorphismTest1
{
  public partial class RadForm1 : RadForm, IEventStartWork, IOutputMessage
  {
    public CxTextWriter TxtWriter { get; private set; }

    public RadForm1()
    {
      InitializeComponent();
    }

    public void OutputMessage(string message)
    {
      TxtMessage.AppendText(message + Environment.NewLine + Environment.NewLine);
    }

    public void LogError(Exception ex, string note)
    {
      string s = $"{note} {ex.Message} {ex.StackTrace}";
      Log.Save(ex, s);
      Ms.Message(MsgType.Error, $"Произошла ошибка", ex.Message, null, MsgPos.BottomRight, 20);
    }

    public async Task WrappedFunction(Func<Task> method, string note = "")
    {
      try
      {
         await method();
      }
      catch (Exception ex)
      {
        LogError(ex, note);
      }
    }

    public void ButtonClickHandler(RadButton button, Func<Task> method)
    {
      button.Click += async (s, e) => await WrappedFunction(method, button.Name);
    }

    public void EventStartWork()
    {
      ButtonClickHandler(BtnStart, Start);
      RedirectConsoleOutput();
    }

    internal void RedirectConsoleOutput()
    {
      TxtWriter = new CxTextWriter(this); Console.SetOut(TxtWriter);
    }


    internal async Task Start()
    {
      OutputMessage("Start");
      await Task.Delay(100);
      CxExperiment experiment = new CxExperiment();
      OutputMessage("-------------------------------- Test N 1");
      experiment.Test1();
      OutputMessage("-------------------------------- Test N 2");
      experiment.Test2();
      OutputMessage("-------------------------------- Test N 3");
      experiment.Test3();
      OutputMessage("End");
    }
  }
}
