namespace PolymorphismTest1
{
  partial class RadForm1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
      this.radPopupContainer1 = new Telerik.WinControls.UI.RadPopupContainer();
      this.TxtMessage = new Telerik.WinControls.UI.RadTextBox();
      this.BtnStart = new Telerik.WinControls.UI.RadButton();
      ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
      this.radPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.radPopupContainer1)).BeginInit();
      this.radPopupContainer1.PanelContainer.SuspendLayout();
      this.radPopupContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.TxtMessage)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.BtnStart)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      this.SuspendLayout();
      // 
      // radPanel1
      // 
      this.radPanel1.Controls.Add(this.BtnStart);
      this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.radPanel1.Location = new System.Drawing.Point(0, 0);
      this.radPanel1.Name = "radPanel1";
      this.radPanel1.Size = new System.Drawing.Size(1142, 95);
      this.radPanel1.TabIndex = 0;
      // 
      // radPopupContainer1
      // 
      this.radPopupContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.radPopupContainer1.Location = new System.Drawing.Point(0, 95);
      this.radPopupContainer1.Name = "radPopupContainer1";
      // 
      // radPopupContainer1.PanelContainer
      // 
      this.radPopupContainer1.PanelContainer.Controls.Add(this.TxtMessage);
      this.radPopupContainer1.PanelContainer.Size = new System.Drawing.Size(1140, 680);
      this.radPopupContainer1.Size = new System.Drawing.Size(1142, 682);
      this.radPopupContainer1.TabIndex = 0;
      // 
      // TxtMessage
      // 
      this.TxtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TxtMessage.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.TxtMessage.Location = new System.Drawing.Point(0, 0);
      this.TxtMessage.Multiline = true;
      this.TxtMessage.Name = "TxtMessage";
      // 
      // 
      // 
      this.TxtMessage.RootElement.StretchVertically = true;
      this.TxtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.TxtMessage.Size = new System.Drawing.Size(1140, 680);
      this.TxtMessage.TabIndex = 0;
      // 
      // BtnStart
      // 
      this.BtnStart.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.BtnStart.Location = new System.Drawing.Point(28, 31);
      this.BtnStart.Name = "BtnStart";
      this.BtnStart.Size = new System.Drawing.Size(148, 30);
      this.BtnStart.TabIndex = 0;
      this.BtnStart.Text = "Старт теста";
      // 
      // RadForm1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1142, 777);
      this.Controls.Add(this.radPopupContainer1);
      this.Controls.Add(this.radPanel1);
      this.Name = "RadForm1";
      // 
      // 
      // 
      this.RootElement.ApplyShapeToControl = true;
      this.Text = "RadForm1";
      ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
      this.radPanel1.ResumeLayout(false);
      this.radPopupContainer1.PanelContainer.ResumeLayout(false);
      this.radPopupContainer1.PanelContainer.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.radPopupContainer1)).EndInit();
      this.radPopupContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.TxtMessage)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.BtnStart)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Telerik.WinControls.UI.RadPanel radPanel1;
    private Telerik.WinControls.UI.RadPopupContainer radPopupContainer1;
    private Telerik.WinControls.UI.RadTextBox TxtMessage;
    private Telerik.WinControls.UI.RadButton BtnStart;
  }
}