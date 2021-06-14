using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimerApp
{
    public partial class Form1 : Form
    {
        private int ss, mm, savedSeconds, savedMinutes;

        // buttons to choose which timer will choose. this would set and the coresponding minutes for each individual timers.
        private bool PButtonClicked = false, SButtonClicked = false, LButtonClicked = false;

        public Form1()
        {
            InitializeComponent();

     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PButtonClicked = true;
            timeOutputLabel.Text = "24:00";
            this.BackColor = Color.FromArgb(219, 82, 77);

            ss = 10;
            mm = 0;
        }

        // timer_ticks methods

        private void PTimer_Tick(object sender, EventArgs e)
        {
            
            if (ss > 0)
            {
                ss--;
                timeOutputLabel.Text = mm.ToString() + ":" + ss.ToString();
                savedSeconds = ss;
            }
            else
            {
                if (mm > 0)
                {
                    mm--;
                    ss = 60;            // change this for faster debugging!
                    timeOutputLabel.Text = mm.ToString() + ":" + ss.ToString();
                    savedMinutes = mm;
                    savedSeconds = ss;
                }
                else
                {
                    //this.tabControl1.SelectedTab = Short_Break;

                    timeOutputLabel.ForeColor = System.Drawing.Color.Green;
                    timeOutputLabel.Text = "break time!";


                    PTimer.Stop();
                    PTimer.Dispose();
                    PTimer.Enabled = false;

                    BreakTime();

                    //startStopButton
                }
            }
        }
        private void STimer_Tick(object sender, EventArgs e)
        {
            if (ss > 0)
            {
                ss--;
                timeOutputLabel.Text = mm.ToString() + ":" + ss.ToString();
                savedSeconds = ss;
            }
            else
            {
                if (mm > 0)
                {
                    mm--;
                    ss = 60;            // change this for faster debugging!
                    timeOutputLabel.Text = mm.ToString() + ":" + ss.ToString();
                    savedMinutes = mm;
                    savedSeconds = ss;
                }
                else
                {
                    //this.tabControl1.SelectedTab = Short_Break;

                    timeOutputLabel.ForeColor = System.Drawing.Color.Green;
                    timeOutputLabel.Text = "break time!";

                    PTimer.Stop();
                    PTimer.Dispose();
                    PTimer.Enabled = false;

                    //startStopButton
                }
            }
        }
        private void LTimer_Tick(object sender, EventArgs e)
        {
            if (ss > 0)
            {
                ss--;
                timeOutputLabel.Text = mm.ToString() + ":" + ss.ToString();
                savedSeconds = ss;
            }
            else
            {
                if (mm > 0)
                {
                    mm--;
                    ss = 60;            // change this for faster debugging!
                    timeOutputLabel.Text = mm.ToString() + ":" + ss.ToString();
                    savedMinutes = mm;
                    savedSeconds = ss;
                }
                else
                {
                    //this.tabControl1.SelectedTab = Short_Break;

                    timeOutputLabel.ForeColor = System.Drawing.Color.Green;
                    timeOutputLabel.Text = "break time!";

                    PTimer.Stop();
                    PTimer.Dispose();
                    PTimer.Enabled = false;

                    //startStopButton
                }
            }
        }

        private void BreakTime() {
            // change the block code with try catch for the file path of the sounds.

            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Alarm04.wav");
            simpleSound.Play();
            

        }


        //
        //  timer type buttons
        //


        private void PomodoroButton_Click(object sender, EventArgs e)
        {
            // designs for the labels and the back color of the form
            timeOutputLabel.Text = "24:00";
            this.BackColor = Color.FromArgb(219, 82, 77);

            PButtonClicked = true;
            ss = 10;
            mm = 0;
        }

        private void shortBreakButton_Click(object sender, EventArgs e)
        {
            timeOutputLabel.Text = "5:00";
            this.BackColor = Color.FromArgb(70, 142, 145);

            SButtonClicked = true;

            ss = 60;
            mm = 1;
           

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 settingsForm = new Form2();
            settingsForm.Show();
        }

        

        private void longBreakButton_Click(object sender, EventArgs e)
        {
            timeOutputLabel.Text = "15:00";
            this.BackColor = Color.FromArgb(67, 126, 168);

            LButtonClicked = true;

            ss = 60;
            mm = 1;

        }


        // start stop button
        private void startStopButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                    if (PButtonClicked == true)
                    {
                        startStopButton.Text = "Stop";
                        CreatePomodoroTimer();
                        PTimer.Start();
                        PButtonClicked = false;

                        pomodoroButton.Enabled = false;
                        shortBreakButton.Enabled = false;
                        longBreakButton.Enabled = false;
                    }
                    else if (PButtonClicked == false)
                    {
                        PTimer.Stop();
                        startStopButton.Text = "Start";
                        PButtonClicked = true;

                        pomodoroButton.Enabled = true;
                        shortBreakButton.Enabled = true;
                        longBreakButton.Enabled = true;
                    }
                    else if (SButtonClicked == true)
                    {
                        startStopButton.Text = "Stop";
                        CreateShortBreakTimer();
                        STimer.Start();
                        SButtonClicked = false;

                        pomodoroButton.Enabled = false;
                        shortBreakButton.Enabled = false;
                        longBreakButton.Enabled = false;
                    }
                    else if (SButtonClicked == false)
                    {
                        STimer.Stop();
                        startStopButton.Text = "Start";
                        SButtonClicked = true;

                        pomodoroButton.Enabled = true;
                        shortBreakButton.Enabled = true;
                        longBreakButton.Enabled = true;
                    }

                    else if (LButtonClicked == true)
                    {
                        startStopButton.Text = "Stop";
                        CreateLongBreakTimer();
                        LTimer.Start();
                        LButtonClicked = false;

                        pomodoroButton.Enabled = false;
                        shortBreakButton.Enabled = false;
                        longBreakButton.Enabled = false;
                    }
                    else if (LButtonClicked == false) {
                        LTimer.Stop();
                        startStopButton.Text = "Start";
                        LButtonClicked = true;

                        pomodoroButton.Enabled = true;
                        shortBreakButton.Enabled = true;
                        longBreakButton.Enabled = true;
                    }
      
            }
            catch (System.IO.IOException x)
            {
                Console.WriteLine(x.HResult);
                Console.WriteLine(x.Message);
                Console.WriteLine(x.StackTrace);
            }
        }

        

        // on form load

        


        private void CreatePomodoroTimer() {
            // create an instance of an object PTimer
            Timer PTimer = new Timer();

            // add the event Tick and the event handler for the method that will process the timer event to the timer
            PTimer.Tick += new EventHandler(PTimer_Tick);
            // set interval

            PTimer.Interval = 1000;
            //this.ss = setSeconds(ss); // set the value of seconds inside of this constructor 
            //this.mm = setMinutes(mm); // set the value of minutes inside of this constructor named Form1
          
        }

        private void CreateShortBreakTimer() {
            // create an instance of an object PTimer
            Timer STimer = new Timer();

            // add the event Tick and the event handler for the method that will process the timer event to the timer
            PTimer.Tick += new EventHandler(STimer_Tick);
            // set interval

            PTimer.Interval = 1000;
        }

        private void CreateLongBreakTimer() {
            // create an instance of an object PTimer
            Timer LTimer = new Timer();

            // add the event Tick and the event handler for the method that will process the timer event to the timer
            PTimer.Tick += new EventHandler(LTimer_Tick);
            // set interval

            PTimer.Interval = 1000;
        }
    }
}