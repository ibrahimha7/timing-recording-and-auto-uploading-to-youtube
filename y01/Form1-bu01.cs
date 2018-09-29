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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

using System.Reflection;
using System.Diagnostics;


using Google.Apis.Http;

using Google.Apis.Util;

using System.Net.Http;


//fuck off
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


        
        int x = 0;
        
        

        
       // private bool _start;
        private void Start()
        {

            string wind_name_str = window_name.Text;

            IntPtr hwnd = FindWindow(null, wind_name_str);
            
            SetForegroundWindow(hwnd);
            Thread.Sleep(200);
            
            SendKeys.Send("^o");

            
            x = x + 1;


            counter.Text = x.ToString();

            
   
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


        public async Task Run()
        {
            string acount_str = acount.Text.ToString();
           

            UserCredential credential;
            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    // This OAuth 2.0 access scope allows an application to upload files to the
                    // authenticated user's YouTube channel, but doesn't allow other types of access.
                    new[] { YouTubeService.Scope.YoutubeUpload },
                    acount_str,
                    CancellationToken.None
                );
            }

            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = Assembly.GetExecutingAssembly().GetName().Name
            });

            string fps = folderpath.Text;
            string counter2 = counter.Text.ToString();




            var video = new Video();
            video.Snippet = new VideoSnippet();
            video.Snippet.Title = "Default Video Title" + counter2;
            video.Snippet.Description = "Default Video Description";
            video.Snippet.Tags = new string[] { "tag1", "tag2" };
            video.Snippet.CategoryId = "22"; // See https://developers.google.com/youtube/v3/docs/videoCategories/list
            video.Status = new VideoStatus();
            video.Status.PrivacyStatus = "unlisted"; // or "private" or "public"
            //MessageBox.Show(counter2);
            var filePath = fps + "\\foldername" + "//record_" + counter2 + "_upload.mp4"; // Replace with path to actual movie file.



            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                var videosInsertRequest = youtubeService.Videos.Insert(video, "snippet,status", fileStream, "video/*");
                videosInsertRequest.ProgressChanged += videosInsertRequest_ProgressChanged;
                videosInsertRequest.ResponseReceived += videosInsertRequest_ResponseReceived;
                await videosInsertRequest.UploadAsync();



            }

        }

        void videosInsertRequest_ProgressChanged(Google.Apis.Upload.IUploadProgress progress)
        {


            switch (progress.Status)
            {
                case UploadStatus.Uploading:
                    Debug.WriteLine("{0} bytes sent.", progress.BytesSent);
                    break;

                case UploadStatus.Failed:
                    Debug.WriteLine("An error prevented the upload from completing.\n{0}", progress.Exception);
                    break;

            }

        }

        void videosInsertRequest_ResponseReceived(Video video)
        {

            Debug.WriteLine("Video id '{0}' was successfully uploaded.", video.Id);
            /*
            string fps = folderpath.Text;
            string dis = fps + @"\foldername\record_to_upload.mp4";
            */
            // File.Delete(dis);

        }




        internal class UploadVideo
        {
            


            Form1 frmOne = new Form1();
            

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

            Run();


            


        }

        private void run_Click(object sender, EventArgs e)
        {

            //create
            string folderpath_str = folderpath.Text;
            System.IO.Directory.CreateDirectory(folderpath_str+"\\foldername");


            //cut
            string scr = folderpath_str + "//record.mp4";

            //fps + @"\foldername\record_" + value_of_x + "_upload.mp4"

            string counter_str = counter.Text;
            string dis = folderpath_str + "\\foldername" + "//record_" + counter_str + "_upload.mp4";
            File.Move(scr, dis);


            Thread.Sleep(100);

            
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
            /*
            usernametext.Text = Properties.Settings.Default.email;
            password.Text = Properties.Settings.Default.password;
            */

            window_name.Text = Properties.Settings.Default.window_name;

            folderpath.Text = Properties.Settings.Default.path;
            x = Properties.Settings.Default.x;

            counter.Text = Properties.Settings.Default.counter;

            counter.Text = Properties.Settings.Default.counter.ToString();

            acount.Text = Properties.Settings.Default.acount;

            
            // textBox1.Text = Properties.Settings.Default.x.ToString();


            Thread thread = new Thread(new ThreadStart(UpdateTextBoxThread));
            thread.Start();

        }
        public delegate void UpdateTextBoxDelegate(int value);

        public void UpdateTextBoxThread()
        {
            
        }
        public void InvokeUpdateTextBox(int loop)
        {
            counter.Text = loop.ToString();
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
            /*
            Properties.Settings.Default.email = usernametext.Text;
            Properties.Settings.Default.password = password.Text;
            */

            Properties.Settings.Default.window_name = window_name.Text;

            Properties.Settings.Default.path = folderpath.Text;
            Properties.Settings.Default.counter = counter.Text;

            Properties.Settings.Default.x = x;

            Properties.Settings.Default.acount = acount.Text;



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
