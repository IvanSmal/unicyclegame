/*
* Copyright (c) 2007-2009 SlimDX Group
* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
*/
using System;
using System.Media;
using System.IO;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;
using SlimDX;
using SlimDX.DirectInput;
using SlimDX.XInput;
using System.Collections.Generic;

namespace unicyclegame
{
    public partial class MainForm : Form
    {
        Joystick joystick;

        JoystickState state = new JoystickState();
        int numPOVs;
        int SliderCount;
        double tilt;

        StreamWriter log;

        void CreateDevice()
        {
            // make sure that DirectInput has been initialized
            DirectInput dinput = new DirectInput();

            // search for devices
            foreach (DeviceInstance device in dinput.GetDevices(DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly))
            {
                // create the device
                try
                {
                    joystick = new Joystick(dinput, device.InstanceGuid);
                    joystick.SetCooperativeLevel(this, CooperativeLevel.Exclusive | CooperativeLevel.Foreground);
                    break;
                }
                catch (DirectInputException)
                {
                }
            }

            if (joystick == null)
            {
                MessageBox.Show("There are no joysticks attached to the system.");
                return;
            }

            foreach (DeviceObjectInstance deviceObject in joystick.GetObjects())
            {
                if ((deviceObject.ObjectType & ObjectDeviceType.Axis) != 0)
                    joystick.GetObjectPropertiesById((int)deviceObject.ObjectType).SetRange(-1000, 1000);

                UpdateControl(deviceObject);
            }

            // acquire the device
            joystick.Acquire();

            // set the timer to go off 12 times a second to read input
            // NOTE: Normally applications would read this much faster.
            // This rate is for demonstration purposes only.
            timer.Interval = 1000 / 30;
            timer.Start();
        }

        void ReadImmediateData()
        {
            if (joystick.Acquire().IsFailure)
                return;

            if (joystick.Poll().IsFailure)
                return;

            state = joystick.GetCurrentState();
            if (Result.Last.IsFailure)
                return;

            UpdateUI();
        }

        void ReleaseDevice()
        {
            timer.Stop();

            if (joystick != null)
            {
                joystick.Unacquire();
                joystick.Dispose();
            }
            joystick = null;
        }

        #region Boilerplate

        public Image uniImage;
        public Controller c;
        int t, time;

        System.IO.Stream fallLeft, fallRight;
        System.Media.SoundPlayer playLeft, playRight;

        public MainForm()
        {

            fallLeft = unicyclegame.Properties.Resources.ResourceManager.GetStream("fallleft");
            fallRight = unicyclegame.Properties.Resources.ResourceManager.GetStream("fallright");

            log = File.AppendText(Environment.CurrentDirectory + "/" + DateTime.Now.Ticks + ".csv");

            playLeft = new System.Media.SoundPlayer();
            playLeft.Stream = fallLeft;

            playRight = new System.Media.SoundPlayer();
            playRight.Stream = fallRight;

            tilt = 0;
            t = 0;
            time = 0;
            InitializeComponent();
            uniImage = (Image)unicycle.Image.Clone();
            c = new Controller(UserIndex.One);
            unicycle.SizeMode = PictureBoxSizeMode.CenterImage;
            CreateDevice();

            blockPanel.Hide();

            startCounterLabel.Text = "Get Ready...";
            isStartingSequence = true;

            shouldPlaySound = true;
            UpdateUI();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ReadImmediateData();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ReleaseDevice();
            Close();
        }

        bool hasrestarted;

        bool isStartingSequence;
        int startingSequenceTimer;

        int games;

        private void DoStartingSequence()
        {
            if (startingSequenceTimer == 20) {
                isStartingSequence = false;
                startCounterLabel.Hide();
                return;
            }

            if (startingSequenceTimer == 0)
            {
                games++;

                levelLabel.Text = games.ToString();

                if (games >= 0)
                {
                    shouldVibrate = true;
                    shouldPlaySound = true;
                }

                if (games >= 10)
                {
                    shouldVibrate = true;
                    shouldPlaySound = false;
                }

                if (games >= 20)
                {
                    shouldPlaySound = true;
                    shouldVibrate = false;
                }

                if (games >= 30)
                {
                    shouldPlaySound = false;
                    shouldVibrate = false;
                }

                if (games >= 40)
                {
                    shouldPlaySound = true;
                    shouldVibrate = true;
                    blockPanel.Show();
                }

                if (games >= 40)
                {
                    shouldPlaySound = true;
                    shouldVibrate = false;
                    blockPanel.Show();
                }


                initialized = false;
                playRight.Stop();
                playLeft.Stop();
                vibrate(0);
            }

            if (startingSequenceTimer == 5)
            {
                unicycle.Image = RotateImage(uniImage, new PointF(505, 697), 0);
                startCounterLabel.Show();
            }

            startCounterLabel.Text = ((int)((19 - startingSequenceTimer) / 5) + 1).ToString();

            startingSequenceTimer++;
            // Console.WriteLine(startingSequenceTimer);
        }

        private void restart_Click(object sender, EventArgs e)
        {
            hasrestarted = true;
            shouldVibrate = false;
        }

        /// <summary>
        /// Creates a new Image containing the same image only rotated
        /// </summary>
        /// <param name=""image"">The <see cref=""System.Drawing.Image"/"> to rotate
        /// <param name=""offset"">The position to rotate from.
        /// <param name=""angle"">The amount to rotate the image, clockwise, in degrees
        /// <returns>A new <see cref=""System.Drawing.Bitmap"/"> of the same size rotated.</see>
        /// <exception cref=""System.ArgumentNullException"">Thrown if <see cref=""image"/"> 
        /// is null.</see>
        public static Bitmap RotateImage(Image image, PointF offset, float angle)
        {
            if (image == null)
                throw new ArgumentNullException("image");

            //create a new empty bitmap to hold rotated image
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //make a graphics object from the empty bitmap
            Graphics g = Graphics.FromImage(rotatedBmp);

            //Put the rotation point in the center of the image
            g.TranslateTransform(offset.X, offset.Y);

            //rotate the image
            g.RotateTransform(angle);

            //move the image back
            g.TranslateTransform(-offset.X, -offset.Y);

            //draw passed in image onto graphics object
            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;
        }

        int initState;
        void UpdateUI()
        {
            if (isStartingSequence)
            {
                DoStartingSequence();
                return;
            }

            if (hasrestarted == true)
            {
                hasrestarted = false;
                tilt = 0;
                t = 0;
                time = 0;
            }
            if (initState == 0) initState = state.X;

            if (joystick == null)
                createDeviceButton.Text = "Create Device";
            else
                createDeviceButton.Text = "Release Device";

            string strText = null;

            double gausnoise = Utils.RandGauss(0, 1);

            // int tilt = (int)Math.Pow(5, noise);

            // noise = (int)(tilt + state.X / 10);

            double difficulty = (double)time / 300 + 1;

            if (state.X < 50 && state.X > -50 )
            {
                // t = 0;
                // initState = state.X;
                t++;
            }
            else
            {
                // t++;
                if (t > 0 && Math.Abs(tilt) < 89) t --;
                
                // noise = Utils.RandGauss(0, 1);
            }

            if (tilt >-1 && tilt <1) {
                tilt = Utils.RandGauss(0, 1);
            }

            // t++;
            time++;

      

            difficultyLabel.Text = (difficulty * 1000).ToString();

            tilt = tilt * Math.Pow((1 + (.005 * difficulty)), t);
            tilt += state.X / (100);

            int arrayPosition = time;
            if (Math.Abs(tilt) >= 90)
            {
                isStartingSequence = true;
                startingSequenceTimer = 0;
                if (tilt > 0)
                {
                    tilt = 90;
                    hasrestarted = true;
                    shouldVibrate = false;
                    // System.Threading.Thread.Sleep(1000);

                }
                else
                {
                    tilt = -90;
                    hasrestarted = true;
                    shouldVibrate = false;
                    // System.Threading.Thread.Sleep(1000);
                }
            }


            log.WriteLine(games + "," + difficulty + "," + tilt + "," + state.X + "," + state.Y);
           

            vibrate((int)tilt);
            
            noiseLabel.Text = tilt.ToString();
            

            unicycle.Image = RotateImage(uniImage, new PointF(505, 697), (int)tilt);

            label_X.Text = state.X.ToString(CultureInfo.CurrentCulture);
            label_Y.Text = state.Y.ToString(CultureInfo.CurrentCulture);
            label_Z.Text = state.Z.ToString(CultureInfo.CurrentCulture);

            label_XRot.Text = state.RotationX.ToString(CultureInfo.CurrentCulture);
            label_YRot.Text = state.RotationY.ToString(CultureInfo.CurrentCulture);
            label_ZRot.Text = state.RotationZ.ToString(CultureInfo.CurrentCulture);

            int[] slider = state.GetSliders();

            label_S0.Text = slider[0].ToString(CultureInfo.CurrentCulture);
            label_S1.Text = slider[1].ToString(CultureInfo.CurrentCulture);

            int[] pov = state.GetPointOfViewControllers();

            label_P0.Text = pov[0].ToString(CultureInfo.CurrentCulture);
            label_P1.Text = pov[1].ToString(CultureInfo.CurrentCulture);
            label_P2.Text = pov[2].ToString(CultureInfo.CurrentCulture);
            label_P3.Text = pov[3].ToString(CultureInfo.CurrentCulture);

            bool[] buttons = state.GetButtons();


            for (int b = 0; b < buttons.Length; b++)
            {
                if (buttons[b])
                    strText += b.ToString("00 ", CultureInfo.CurrentCulture);
            }
            label_ButtonList.Text = strText;
        }

        void UpdateControl(DeviceObjectInstance d)
        {
            if (ObjectGuid.XAxis == d.ObjectTypeGuid)
            {
                label_XAxis.Enabled = true;
                label_X.Enabled = true;
            }
            if (ObjectGuid.YAxis == d.ObjectTypeGuid)
            {
                label_YAxis.Enabled = true;
                label_Y.Enabled = true;
            }
            if (ObjectGuid.ZAxis == d.ObjectTypeGuid)
            {
                label_ZAxis.Enabled = true;
                label_Z.Enabled = true;
            }
            if (ObjectGuid.RotationalXAxis == d.ObjectTypeGuid)
            {
                label_XRotation.Enabled = true;
                label_XRot.Enabled = true;
            }
            if (ObjectGuid.RotationalYAxis == d.ObjectTypeGuid)
            {
                label_YRotation.Enabled = true;
                label_YRot.Enabled = true;
            }
            if (ObjectGuid.RotationalZAxis == d.ObjectTypeGuid)
            {
                label_ZRotation.Enabled = true;
                label_ZRot.Enabled = true;
            }

            if (ObjectGuid.Slider == d.ObjectTypeGuid)
            {
                switch (SliderCount++)
                {
                    case 0:
                        label_Slider0.Enabled = true;
                        label_S0.Enabled = true;
                        break;

                    case 1:
                        label_Slider1.Enabled = true;
                        label_S1.Enabled = true;
                        break;
                }
            }

            if (ObjectGuid.PovController == d.ObjectTypeGuid)
            {
                switch (numPOVs++)
                {
                    case 0:
                        label_POV0.Enabled = true;
                        label_P0.Enabled = true;
                        break;

                    case 1:
                        label_POV1.Enabled = true;
                        label_P1.Enabled = true;
                        break;

                    case 2:
                        label_POV2.Enabled = true;
                        label_P2.Enabled = true;
                        break;

                    case 3:
                        label_POV3.Enabled = true;
                        label_P3.Enabled = true;
                        break;
                }
            }
        }

        private void createDeviceButton_Click(object sender, EventArgs e)
        {
            
                
            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReleaseDevice();
        }

        #endregion

        bool shouldPlaySound;
        bool previousTilt, initialized;
        private void vibrate(int tilt) {
            bool isRight = tilt >= 0;
            if (previousTilt != isRight || !initialized) {
                if (tilt != 0)
                {
                    initialized = true;
                    previousTilt = isRight;
                }

                playRight.Stop();
                playLeft.Stop();

                if (tilt != 0 && shouldPlaySound)
                {
                    if (isRight)
                    {
                        playRight.Play();
                    }
                    else
                    {
                        playLeft.Play();
                    }
                }
            }

            if (shouldVibrate) 
            { 
                c.SetVibration(new Vibration
                    {
                        LeftMotorSpeed = (ushort)(0 + tilt * (1000 / 90)),
                        RightMotorSpeed = (ushort)(0 - tilt * (1000 / 90))
                    });
                }
            else
            {
                c.SetVibration(new Vibration
                    {
                        LeftMotorSpeed = (ushort)0,
                        RightMotorSpeed = (ushort)0
                    });
                }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        bool shouldVibrate;
        private void vibOffButton_Click(object sender, EventArgs e)
        {
            shouldVibrate = !shouldVibrate;
        }

        private void difficultyLabel_Click(object sender, EventArgs e)
        {

        }

        private void unicycle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
