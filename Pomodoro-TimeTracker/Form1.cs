namespace Pomodoro_TimeTracker
{
   public partial class Form1 : Form
   {
      System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

      #region Load Form
      public Form1()
      {
         InitializeComponent();
         DBAccess.LoadSetting();
         SetDefaultSizesAndLocations();
         timer.Interval = 100;
         timer.Tick += Timer_Tick;
      }

      private void SetDefaultSizesAndLocations()
      {
         Size = Settings.formSize;
         foreach (Panel panel in Controls.OfType<Panel>())
         {
            panel.Location = Settings.panelLocation;
            panel.Size = Settings.panelSize;
         }
      }

      #endregion

      #region PomodoroTimer
      bool pomodoroStarted = false;
      private void btnStartPomodoro_Click(object sender, EventArgs e)
      {
         pomodoroStarted = !pomodoroStarted;
         timer.Enabled = pomodoroStarted;
         btnStartPomodoro.Text = pomodoroStarted ? "Stop" : "Start";

      }

      private void Timer_Tick(object? sender, EventArgs e)
      {

      }

      #endregion

      private void btnAcceptMinutes_Click(object sender, EventArgs e)
         => DBAccess.UpdateSettings((int)nmPomodoroMinutes.Value, (int)nmPomodoroMinutes.Value);

      #region SwitchPanels
      private void btnMainPanel_Click(object sender, EventArgs e) => ChangePanelsVisible(panelMain);

      private void btnSettingsPanel_Click(object sender, EventArgs e) => ChangePanelsVisible(panelSettings);

      private void ChangePanelsVisible(Panel showedPanel)
      {
         foreach (Panel panel in Controls.OfType<Panel>())
         {
            panel.Hide();
         }
         showedPanel.Show();
      }

      #endregion

   }
}
