namespace Pomodoro_TimeTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         monthCalendar1 = new MonthCalendar();
         nmPomodoroMinutes = new NumericUpDown();
         nmPauseMinutes = new NumericUpDown();
         lbPomodorMinutes = new Label();
         lbPauseMinutes = new Label();
         btnAcceptMinutes = new Button();
         btnStartPomodoro = new Button();
         lbPomodoroPauseTime = new Label();
         lbTotalTaskTime = new Label();
         lbTotalSubtaskTime = new Label();
         lbTotalActionTime = new Label();
         panelMain = new Panel();
         btnMainPanel = new Button();
         btnSettingsPanel = new Button();
         panelSettings = new Panel();
         ((System.ComponentModel.ISupportInitialize)nmPomodoroMinutes).BeginInit();
         ((System.ComponentModel.ISupportInitialize)nmPauseMinutes).BeginInit();
         panelMain.SuspendLayout();
         SuspendLayout();
         // 
         // monthCalendar1
         // 
         monthCalendar1.Location = new Point(601, 18);
         monthCalendar1.Name = "monthCalendar1";
         monthCalendar1.TabIndex = 0;
         // 
         // nmPomodoroMinutes
         // 
         nmPomodoroMinutes.Font = new Font("Segoe UI Semibold", 10.909091F, FontStyle.Bold);
         nmPomodoroMinutes.Location = new Point(154, 15);
         nmPomodoroMinutes.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
         nmPomodoroMinutes.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
         nmPomodoroMinutes.Name = "nmPomodoroMinutes";
         nmPomodoroMinutes.Size = new Size(45, 27);
         nmPomodoroMinutes.TabIndex = 1;
         nmPomodoroMinutes.Value = new decimal(new int[] { 25, 0, 0, 0 });
         // 
         // nmPauseMinutes
         // 
         nmPauseMinutes.Font = new Font("Segoe UI Semibold", 10.909091F, FontStyle.Bold);
         nmPauseMinutes.Location = new Point(154, 48);
         nmPauseMinutes.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
         nmPauseMinutes.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
         nmPauseMinutes.Name = "nmPauseMinutes";
         nmPauseMinutes.Size = new Size(45, 27);
         nmPauseMinutes.TabIndex = 2;
         nmPauseMinutes.Value = new decimal(new int[] { 5, 0, 0, 0 });
         // 
         // lbPomodorMinutes
         // 
         lbPomodorMinutes.AutoSize = true;
         lbPomodorMinutes.Font = new Font("Segoe UI Semibold", 10.181818F, FontStyle.Bold, GraphicsUnit.Point, 0);
         lbPomodorMinutes.Location = new Point(17, 18);
         lbPomodorMinutes.Name = "lbPomodorMinutes";
         lbPomodorMinutes.Size = new Size(131, 19);
         lbPomodorMinutes.TabIndex = 3;
         lbPomodorMinutes.Text = "pomodoro minutes:";
         // 
         // lbPauseMinutes
         // 
         lbPauseMinutes.AutoSize = true;
         lbPauseMinutes.Font = new Font("Segoe UI Semibold", 10.181818F, FontStyle.Bold, GraphicsUnit.Point, 0);
         lbPauseMinutes.Location = new Point(46, 51);
         lbPauseMinutes.Name = "lbPauseMinutes";
         lbPauseMinutes.Size = new Size(102, 19);
         lbPauseMinutes.TabIndex = 4;
         lbPauseMinutes.Text = "pause minutes:";
         // 
         // btnAcceptMinutes
         // 
         btnAcceptMinutes.Font = new Font("Segoe UI Semibold", 10.909091F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btnAcceptMinutes.Location = new Point(209, 15);
         btnAcceptMinutes.Name = "btnAcceptMinutes";
         btnAcceptMinutes.Size = new Size(85, 60);
         btnAcceptMinutes.TabIndex = 5;
         btnAcceptMinutes.Text = "Accept";
         btnAcceptMinutes.UseVisualStyleBackColor = true;
         btnAcceptMinutes.Click += btnAcceptMinutes_Click;
         // 
         // btnStartPomodoro
         // 
         btnStartPomodoro.Font = new Font("Segoe UI Semibold", 10.909091F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btnStartPomodoro.Location = new Point(17, 88);
         btnStartPomodoro.Name = "btnStartPomodoro";
         btnStartPomodoro.Size = new Size(85, 31);
         btnStartPomodoro.TabIndex = 6;
         btnStartPomodoro.Text = "Start";
         btnStartPomodoro.UseVisualStyleBackColor = true;
         btnStartPomodoro.Click += btnStartPomodoro_Click;
         // 
         // lbPomodoroPauseTime
         // 
         lbPomodoroPauseTime.AutoSize = true;
         lbPomodoroPauseTime.Font = new Font("Segoe UI Semibold", 10.181818F, FontStyle.Bold, GraphicsUnit.Point, 0);
         lbPomodoroPauseTime.Location = new Point(127, 94);
         lbPomodoroPauseTime.Name = "lbPomodoroPauseTime";
         lbPomodoroPauseTime.Size = new Size(77, 19);
         lbPomodoroPauseTime.TabIndex = 7;
         lbPomodoroPauseTime.Text = "Pomodoro:";
         // 
         // lbTotalTaskTime
         // 
         lbTotalTaskTime.AutoSize = true;
         lbTotalTaskTime.Font = new Font("Segoe UI Semibold", 10.181818F, FontStyle.Bold, GraphicsUnit.Point, 0);
         lbTotalTaskTime.Location = new Point(127, 142);
         lbTotalTaskTime.Name = "lbTotalTaskTime";
         lbTotalTaskTime.Size = new Size(104, 19);
         lbTotalTaskTime.TabIndex = 8;
         lbTotalTaskTime.Text = "Total task time:";
         // 
         // lbTotalSubtaskTime
         // 
         lbTotalSubtaskTime.AutoSize = true;
         lbTotalSubtaskTime.Font = new Font("Segoe UI Semibold", 10.181818F, FontStyle.Bold, GraphicsUnit.Point, 0);
         lbTotalSubtaskTime.Location = new Point(127, 175);
         lbTotalSubtaskTime.Name = "lbTotalSubtaskTime";
         lbTotalSubtaskTime.Size = new Size(126, 19);
         lbTotalSubtaskTime.TabIndex = 9;
         lbTotalSubtaskTime.Text = "Total subtask time:";
         // 
         // lbTotalActionTime
         // 
         lbTotalActionTime.AutoSize = true;
         lbTotalActionTime.Font = new Font("Segoe UI Semibold", 10.181818F, FontStyle.Bold, GraphicsUnit.Point, 0);
         lbTotalActionTime.Location = new Point(127, 204);
         lbTotalActionTime.Name = "lbTotalActionTime";
         lbTotalActionTime.Size = new Size(118, 19);
         lbTotalActionTime.TabIndex = 10;
         lbTotalActionTime.Text = "Total action time:";
         // 
         // panelMain
         // 
         panelMain.Controls.Add(lbPomodorMinutes);
         panelMain.Controls.Add(lbTotalActionTime);
         panelMain.Controls.Add(monthCalendar1);
         panelMain.Controls.Add(lbTotalSubtaskTime);
         panelMain.Controls.Add(nmPomodoroMinutes);
         panelMain.Controls.Add(lbTotalTaskTime);
         panelMain.Controls.Add(nmPauseMinutes);
         panelMain.Controls.Add(lbPomodoroPauseTime);
         panelMain.Controls.Add(lbPauseMinutes);
         panelMain.Controls.Add(btnStartPomodoro);
         panelMain.Controls.Add(btnAcceptMinutes);
         panelMain.Location = new Point(12, 36);
         panelMain.Name = "panelMain";
         panelMain.Size = new Size(837, 522);
         panelMain.TabIndex = 11;
         // 
         // btnMainPanel
         // 
         btnMainPanel.Font = new Font("Segoe UI Semibold", 10.909091F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btnMainPanel.Location = new Point(16, 3);
         btnMainPanel.Name = "btnMainPanel";
         btnMainPanel.Size = new Size(85, 31);
         btnMainPanel.TabIndex = 12;
         btnMainPanel.Text = "Main";
         btnMainPanel.UseVisualStyleBackColor = true;
         btnMainPanel.Click += btnMainPanel_Click;
         // 
         // btnSettingsPanel
         // 
         btnSettingsPanel.Font = new Font("Segoe UI Semibold", 10.909091F, FontStyle.Bold, GraphicsUnit.Point, 0);
         btnSettingsPanel.Location = new Point(107, 3);
         btnSettingsPanel.Name = "btnSettingsPanel";
         btnSettingsPanel.Size = new Size(85, 31);
         btnSettingsPanel.TabIndex = 13;
         btnSettingsPanel.Text = "Settings";
         btnSettingsPanel.UseVisualStyleBackColor = true;
         btnSettingsPanel.Click += btnSettingsPanel_Click;
         // 
         // panelSettings
         // 
         panelSettings.Location = new Point(737, 12);
         panelSettings.Name = "panelSettings";
         panelSettings.Size = new Size(62, 44);
         panelSettings.TabIndex = 14;
         panelSettings.Visible = false;
         // 
         // Form1
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(861, 567);
         Controls.Add(panelSettings);
         Controls.Add(btnSettingsPanel);
         Controls.Add(btnMainPanel);
         Controls.Add(panelMain);
         MaximizeBox = false;
         Name = "Form1";
         Text = "pomodoro time tracker";
         ((System.ComponentModel.ISupportInitialize)nmPomodoroMinutes).EndInit();
         ((System.ComponentModel.ISupportInitialize)nmPauseMinutes).EndInit();
         panelMain.ResumeLayout(false);
         panelMain.PerformLayout();
         ResumeLayout(false);
      }

      #endregion

      private MonthCalendar monthCalendar1;
      private NumericUpDown nmPomodoroMinutes;
      private NumericUpDown nmPauseMinutes;
      private Label lbPomodorMinutes;
      private Label lbPauseMinutes;
      private Button btnAcceptMinutes;
      private Button btnStartPomodoro;
      private Label lbPomodoroPauseTime;
      private Label lbTotalTaskTime;
      private Label lbTotalSubtaskTime;
      private Label lbTotalActionTime;
      private Panel panelMain;
      private Button btnMainPanel;
      private Button btnSettingsPanel;
      private Panel panelSettings;
   }
}
