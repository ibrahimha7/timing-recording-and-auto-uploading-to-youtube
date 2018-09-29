using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using AutoItX3Lib;
using System.Threading;
using WindowsInput;
using System.Runtime.InteropServices;

namespace y01
{
    public partial class Form1 : Form
    {
        //Timer t = new Timer();
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        

        /*
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        
        
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bvk, byte bscan, uint dwflags, IntPtr dwextrainfo);
        
        
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool Setforgroundwinows(IntPtr hwnd);
        */
        
        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hwnd);

        
       // private bool _start;
        private void Start()
        {

            string wind_name_str = window_name.Text;

            IntPtr hwnd = FindWindow(null, wind_name_str);
            
            SetForegroundWindow(hwnd);
            Thread.Sleep(200);
            
            SendKeys.Send("^o");
   
        }
        private void Stop()
        {

            string wind_name_str = window_name.Text;

            IntPtr hwnd = FindWindow(null, wind_name_str);

            SetForegroundWindow(hwnd);
            Thread.Sleep(200);

            SendKeys.Send("^p");

            Thread.Sleep(5000);

            run_Click(new object(), new EventArgs());

        }




        public Form1()
        {
            InitializeComponent();
            //timer interval
            t.Interval = 1000;  //in milliseconds

            t.Tick += new EventHandler(this.t_Tick);
            t.Tick += new EventHandler(this.fake_timer_fun);

            //start timer when form loads
            t.Start(); //this will use t_Tick() method
            
            
            

            
        }
        private void fake_timer_fun(object sender, EventArgs e)
        {


            string Timer = timer.Text;
            

            //Time For Prayer for Start Recording
            string Start_Timer1 = Start_Timer1box.Text;
            string Start_Timer2 = Start_Timer2box.Text;
            string Start_Timer3 = Start_Timer3box.Text;
            string Start_Timer4 = Start_Timer4box.Text;

            //string STOP_Record_Fajr = timer.Text;

            string Stop_Timer1 = Stop_Timer1box.Text;
            string Stop_Timer2 = Stop_Timer2box.Text;
            string Stop_Timer3 = Stop_Timer3box.Text;
            string Stop_Timer4 = Stop_Timer4box.Text;
            





            

            //Condtion That Ceck for Start Record For Every Prayer
            if (Timer.ToString() == Start_Timer1.ToString())
            {


                Start();
                // SendKeys.Send("^o");

            }

            else if ((Timer.ToString() == Stop_Timer1.ToString()))
            {
                //STOP Recording Timer
                Stop();

                //SendKeys.Send("^p");

                

            }
            


            
            else if (Timer.ToString() == Start_Timer2.ToString())
            {

                //IntPtr obswindow = FindWindow(null, taskname_str);
                //recrun_Click(new object(), new EventArgs());
                Start();


            }
            else if ((Timer.ToString() == Stop_Timer2.ToString()))
            {
                //STOP Recording Timer

                Stop();


            }

            else if (Timer.ToString() == Start_Timer3.ToString())
            {
                //IntPtr obswindow = FindWindow(null, taskname_str);
                //recrun_Click(new object(), new EventArgs());
                Start();


            }
            else if ((Timer.ToString() == Stop_Timer3.ToString()))
            {
                //STOP Recording Timer

                Stop();


            }
            else if (Timer.ToString() == Start_Timer4.ToString())
            {
                //IntPtr obswindow = FindWindow(null, taskname_str);
                //recrun_Click(new object(), new EventArgs());
                Start();


            }
            else if ((Timer.ToString() == Stop_Timer4.ToString()))
            {
                //STOP Recording Timer

                Stop();


            }



        }
        
        private void fake_timer_fun2(object sender, EventArgs e)
        {


            

            
           
            

        }
        
        private void clock_Click(object sender, EventArgs e)
        {
           

        }
        private void t_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";

            //padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            //update label
            
            timer.Text = time;

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            if (fdb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                MessageBox.Show(fdb.SelectedPath);
            folderpath.Text=fdb.SelectedPath;
        }



        private void upload2_Click(object sender, EventArgs e)
        {
            string folderpath_str = folderpath.Text;


            IWebDriver driver = new FirefoxDriver();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 1, 1000));
            //var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("content-section")));


            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(2000);

            driver.Url = "https://youtube.com/";

            

            string user = usernametext.Text;
            string pass = password.Text;



            driver.FindElement(By.Id("text")).Click();
            

            IWebElement username = driver.FindElement(By.Id("identifierId"));
            username.SendKeys(user);
            
            driver.FindElement(By.Id("identifierNext")).Click();


            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);


            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("password"))).Click();
            driver.FindElement(By.Name("password")).SendKeys(pass);

       
            driver.FindElement(By.Id("passwordNext")).Click();


            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[contains(@aria-label,'Create a video or post')]"))).Click();
            //driver.FindElement(By.XPath("//button[contains(@aria-label,'Create a video or post')]")).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//yt-formatted-string[@class='style-scope ytd-compact-link-renderer'][contains(.,'Upload video')]"))).Click();
            //driver.FindElement(By.XPath("//yt-formatted-string[@class='style-scope ytd-compact-link-renderer'][contains(.,'Upload video')]")).Click();



            //driver.FindElement(By.Id("start-upload-button-single")).Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("start-upload-button-single"))).Click();
            IWebElement fileupload = driver.FindElement(By.Id("start-upload-button-single"));

            
            



            AutoItX3 autoit = new AutoItX3();
            autoit.WinActivate("File Upload");

            autoit.Send(folderpath_str+@"\foldername\record_to_upload.mp4");
            
            Thread.Sleep(1000);
            autoit.Send("{ENTER}");


            string dis3 = folderpath_str+@"\foldername\record_to_upload.mp4";
            Thread.Sleep(4000);
            File.Delete(dis3);


        }

        private void run_Click(object sender, EventArgs e)
        {

            //create
            string folderpath_str = folderpath.Text;
            System.IO.Directory.CreateDirectory(folderpath_str+"\\foldername");


            //cut
            string scr = folderpath_str + "//record.mp4";
            string dis = folderpath_str + "\\foldername" + "//record_to_upload.mp4";

            File.Move(scr, dis);


            Thread.Sleep(4000);

            upload2_Click(new object(), new EventArgs());

        }





        private void Form1_Load(object sender, EventArgs e)
        {
            Start_Timer1box.Text = Properties.Settings.Default.starttimer1;
            Start_Timer2box.Text = Properties.Settings.Default.starttimer2;
            Start_Timer3box.Text = Properties.Settings.Default.starttimer3;
            Start_Timer4box.Text = Properties.Settings.Default.starttimer4;

            Stop_Timer1box.Text = Properties.Settings.Default.stoptimer1;
            Stop_Timer2box.Text = Properties.Settings.Default.stoptimer2;
            Stop_Timer3box.Text = Properties.Settings.Default.stoptimer3;
            Stop_Timer4box.Text = Properties.Settings.Default.stoptimer4;

            usernametext.Text = Properties.Settings.Default.email;
            password.Text = Properties.Settings.Default.password;

            window_name.Text = Properties.Settings.Default.window_name;

            folderpath.Text = Properties.Settings.Default.path;

        }

        private void timer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.starttimer1 = Start_Timer1box.Text;
            Properties.Settings.Default.starttimer2 = Start_Timer2box.Text;
            Properties.Settings.Default.starttimer3 = Start_Timer3box.Text;
            Properties.Settings.Default.starttimer4 = Start_Timer4box.Text;

            Properties.Settings.Default.stoptimer1 = Stop_Timer1box.Text;
            Properties.Settings.Default.stoptimer2 = Stop_Timer2box.Text;
            Properties.Settings.Default.stoptimer3 = Stop_Timer3box.Text;
            Properties.Settings.Default.stoptimer4 = Stop_Timer4box.Text;

            Properties.Settings.Default.email = usernametext.Text;
            Properties.Settings.Default.password = password.Text;

            Properties.Settings.Default.window_name = window_name.Text;

            Properties.Settings.Default.path = folderpath.Text;



            Properties.Settings.Default.Save();
            

        }

        private void teisha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void taskfullname_TextChanged(object sender, EventArgs e)
        {

        }
        
        
        
        
    }
}
