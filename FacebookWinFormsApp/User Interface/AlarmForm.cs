using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using BasicFacebookFeatures.Observer;

namespace BasicFacebookFeatures.User_Interface
{
    public partial class AlarmForm : Form, INotifier
    {
        private Timer AlarmTimer { get; set; }

        private Timer StopWatchTimer { get; set; }

        private eAlarmModes AlarmInterval { get; set; }

        private int m_AlarmTime = 0;
        private int m_StopWatchTime = 0;

        public event Action<string> ReportObserverDelegate;

        private int AlarmTimeCounter { get; set; }

        public bool WaitToTriggerAlarm { get; private set; } = false;

        private bool isStopWatchWorking { get; set; } = false;

        private enum eAlarmModes
        {
            None = 0,
            OneMinute,
            FiveMinutes,
            TenMinutes,
            TwentyMinutes,
            ThirtyMinutes,
            OneHour,
        }

        public AlarmForm()
        {
            InitializeComponent();
            initializeAlarm();
        }

        private int AlarmTimeTotal
        {
            get
            {
                return m_AlarmTime;
            }

            set
            {
                m_AlarmTime = value;
                labelUsingTime.Text = Time;
            }
        } 

        private bool IsActivateAlarm
        {
            get
            {
                const int k_Minute = 60;
                bool isAlarmActivated = false;

                if(!WaitToTriggerAlarm)
                {
                    switch(AlarmInterval)
                    {
                        case eAlarmModes.None:
                            break;
                        case eAlarmModes.OneMinute:
                            if (AlarmTimeCounter == k_Minute)
                            {
                                isAlarmActivated = true;
                            }

                            break;
                        case eAlarmModes.FiveMinutes:
                            if (AlarmTimeCounter == (5 * k_Minute)) 
                            {
                                isAlarmActivated = true;
                            }

                            break;
                        case eAlarmModes.TenMinutes:
                            if (AlarmTimeCounter == (10 * k_Minute))
                            {
                                isAlarmActivated = true;
                            }

                            break;
                        case eAlarmModes.TwentyMinutes:
                            if (AlarmTimeCounter == (20 * k_Minute))
                            {
                                isAlarmActivated = true;
                            }

                            break;
                        case eAlarmModes.ThirtyMinutes:
                            if (AlarmTimeCounter == (30 * k_Minute))
                            {
                                isAlarmActivated = true;
                            }

                            break;
                        case eAlarmModes.OneHour:
                            if (AlarmTimeCounter == (60 * k_Minute))
                            {
                                isAlarmActivated = true;
                            }

                            break;
                    }
                }
                else
                {
                    isAlarmActivated = true;
                }

                return isAlarmActivated;
            }
        }

        public string Time
        {
            get
            {
                return secondsToTime(AlarmTimeTotal);
            }
        }

        private void initializeAlarm()
        {
            AlarmTimer = new Timer();
            StopWatchTimer = new Timer();

            showAlarmHandler();
            StopWatchTimer.Interval = 1000;
            StopWatchTimer.Tick += new EventHandler(stopWatchTimer_onTick);
            AlarmTimer.Interval = 1000;
            AlarmTimer.Tick += new EventHandler(alarmTimer_OnTick);
            AlarmTimer.Start();
            labelUsingTime.Text = Time;
            comboBoxSelectAlarm.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach(eAlarmModes alarmMode in Enum.GetValues(typeof(eAlarmModes)))
            {
                comboBoxSelectAlarm.Items.Add(alarmMode.ToString());
            }

            comboBoxSelectAlarm.Text = comboBoxSelectAlarm.Items[1].ToString();
            AlarmInterval = eAlarmModes.OneMinute;
        }

        private void stopWatchTimer_onTick(object i_Sender, EventArgs i_E)
        {
            m_StopWatchTime++;
            labelStopWatchTime.Text = secondsToTime(m_StopWatchTime);
        }

        private void alarmTimer_OnTick(object i_Sender, EventArgs i_E)
        {
            AlarmTimeCounter++;
            AlarmTimeTotal++;

            if(AlarmTimeCounter % 10 == 0)
            {
                if(IsActivateAlarm)
                {
                    WaitToTriggerAlarm = true;
                }
            }
        }

        private string secondsToTime(int i_Seconds)
        {
            int hours = 00;
            int minutes = 00;
            int secs = 00;

            while(i_Seconds > 0)
            {
                i_Seconds--;
                secs++;

                if(secs == 60)
                {
                    secs = 0;
                    minutes++;
                    if(minutes == 60)
                    {
                        minutes = 0;
                        hours++;
                    }
                }
            }

            StringBuilder stringTime = new StringBuilder();
            List<int> times = new List<int>();
            times.Add(hours);
            times.Add(minutes);
            times.Add(secs);

            foreach(int time in times)
            {
                if(time < 10)
                {
                    stringTime.Append($"0 {time} : ");
                }
                else
                {
                    stringTime.Append($"{time} : ");
                }
            }

            stringTime.Remove(stringTime.Length - 2, 2);
            return stringTime.ToString();
        }

        public void Bell()
        {
            WaitToTriggerAlarm = false;
            AlarmTimeCounter = 0;
        }

        private void comboBoxSelectAlarm_SelectedIndexChanged(object i_Sender, EventArgs e)
        {
            AlarmInterval = (eAlarmModes)Enum.Parse(typeof(eAlarmModes), comboBoxSelectAlarm.SelectedItem.ToString());
            comboBoxSelectAlarm.Text = comboBoxSelectAlarm.SelectedItem.ToString();
        }

        private void toolStripMenuItemAlarm_Click(object sender, EventArgs e)
        {
            showAlarmHandler();
        }

        private void showAlarmHandler()
        {
            panelAlarmContent.Show();
            panelContentStopWatch.Hide();
        }

        private void toolStripMenuItemStopWatch_Click(object sender, EventArgs e)
        {
            panelAlarmContent.Hide();
            panelContentStopWatch.Show();
        }

        private void buttonStartStopWatch_Click(object sender, EventArgs e)
        {
            if(!isStopWatchWorking)
            {
                StopWatchTimer.Start();
                isStopWatchWorking = true;
                buttonStartStopWatch.Text = "Stop";
            }
            else
            {
                buttonStartStopWatch.Text = "Resume";
                isStopWatchWorking = false;
                StopWatchTimer.Stop();
            }
        }

        private void buttonResetStopWatch_Click(object sender, EventArgs e)
        {
            StopWatchTimer.Stop();
            buttonStartStopWatch.Text = "Start";
            m_StopWatchTime = 0;
            labelStopWatchTime.Text = secondsToTime(0);
        }

        public void Notify(string i_Message)
        {
            if (ReportObserverDelegate != null)
            {
                ReportObserverDelegate.Invoke(i_Message);
            }
        }
    }
}
