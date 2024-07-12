using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Desktop_Folder.Properties;
using System.Resources;
using System.Runtime.InteropServices;



namespace Desktop_Folder
{
    public partial class Form1 : Form
    {
        Icon[] IconForFile = new Icon[9];
        Bitmap[] Icons = new Bitmap[9];

        bool[] ButtonHasFunction = new bool[9];

        bool Button1Clicked = false;
        bool Button2Clicked = false;
        bool Button3Clicked = false;
        bool Button4Clicked = false;
        bool Button5Clicked = false;
        bool Button6Clicked = false;
        bool Button7Clicked = false;
        bool Button8Clicked = false;
        bool Button9Clicked = false;

        public string[] ButtonProcess = new string[9];

        string FileLocation = "E:/College/C#/Desktop Folder/Desktop Folder/bin/Debug/Files/files.txt";
        string ImageFileLocation = "E:/College/C#/Desktop Folder/Desktop Folder/bin/Debug/Files/Images/";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(FileLocation))
            {
                ButtonProcess[0] = sr.ReadLine();
                ButtonProcess[1] = sr.ReadLine();
                ButtonProcess[2] = sr.ReadLine();
                ButtonProcess[3] = sr.ReadLine();
                ButtonProcess[4] = sr.ReadLine();
                ButtonProcess[5] = sr.ReadLine();
                ButtonProcess[6] = sr.ReadLine();
                ButtonProcess[7] = sr.ReadLine();
                ButtonProcess[8] = sr.ReadLine();
                sr.Close();
            }

            for (int i = 0; i < ButtonHasFunction.Length; i++)
            {
                if (ButtonProcess[i] == "")
                {
                    ButtonHasFunction[i] = false;
                }
                else { ButtonHasFunction[i] = true; }
            }

            if (ButtonHasFunction[0])//Button1
            {
                Icons[0] = (Bitmap)Image.FromFile(ImageFileLocation + "Button1Image.bmp");
                button1.BackgroundImage = Icons[0];
                button1.Visible = true;
                button2.Visible = true;

            }
            if (ButtonHasFunction[1])//Button2
            {
                Icons[1] = (Bitmap)Image.FromFile(ImageFileLocation + "Button2Image.bmp");
                button2.BackgroundImage = Icons[1];
                button2.Visible = true;
                button3.Visible = true;
            }
            if (ButtonHasFunction[2])//Button3
            {
                Icons[2] = (Bitmap)Image.FromFile(ImageFileLocation + "Button3Image.bmp");
                button3.BackgroundImage = Icons[2];
                button3.Visible = true;
                button4.Visible = true;
            }
            if (ButtonHasFunction[3])//Button4
            {
                Icons[3] = (Bitmap)Image.FromFile(ImageFileLocation + "Button4Image.bmp");
                button4.BackgroundImage = Icons[3];
                button4.Visible = true;
                button5.Visible = true;
            }
            if (ButtonHasFunction[4])//Button5
            {
                Icons[4] = (Bitmap)Image.FromFile(ImageFileLocation + "Button5Image.bmp");
                button5.BackgroundImage = Icons[4];
                button5.Visible = true;
                button6.Visible = true;
            }
            if (ButtonHasFunction[5])//Button6
            {
                Icons[5] = (Bitmap)Image.FromFile(ImageFileLocation + "Button6Image.bmp");
                button6.BackgroundImage = Icons[5];
                button6.Visible = true;
                button7.Visible = true;
            }
            if (ButtonHasFunction[6])//Button7
            {
                Icons[6] = (Bitmap)Image.FromFile(ImageFileLocation + "Button7Image.bmp");
                button7.BackgroundImage = Icons[6];
                button7.Visible = true;
                button8.Visible = true;
            }
            if (ButtonHasFunction[7])//Button8
            {
                Icons[7] = (Bitmap)Image.FromFile(ImageFileLocation + "Button8Image.bmp");
                button8.BackgroundImage = Icons[7];
                button8.Visible = true;
                button9.Visible = true;
            }
            if (ButtonHasFunction[8])//Button9
            {
                Icons[8] = (Bitmap)Image.FromFile(ImageFileLocation + "Button9Image.bmp");
                button9.BackgroundImage = Icons[8];
                button9.Visible = true;
            }
        }

        //Move Form------------------------------------------------------------------------
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        //Move Form------------------------------------------------------------------------

        private void button1_Click(object sender, EventArgs e)//Button 1
        {
            if (ButtonProcess[0] == "")
            {
                Button1Clicked = true;
                AddNew();
            }
            else
            {
                Process.Start(ButtonProcess[0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)//Button 2
        {
            if (ButtonProcess[1] == "")
            {
                Button2Clicked = true;
                AddNew();
            }
            else
            {
                Process.Start(ButtonProcess[1]);
            }
        }

        private void button3_Click(object sender, EventArgs e)//Button 3
        {
            if (ButtonProcess[2] == "")
            {
                Button3Clicked = true;
                AddNew();
            }
            else
            {
                Process.Start(ButtonProcess[2]);
            }
        }

        private void button4_Click(object sender, EventArgs e)//Button 4
        {
            if (ButtonProcess[3] == "")
            {
                Button4Clicked = true;
                AddNew();
            }
            else
            {
                Process.Start(ButtonProcess[3]);
            }
        }

        private void button5_Click(object sender, EventArgs e)//Button 5
        {
            if (ButtonProcess[4] == "")
            {
                Button5Clicked = true;
                AddNew();
            }
            else
            {
                Process.Start(ButtonProcess[4]);
            }
        }

        private void button6_Click(object sender, EventArgs e)//Button 6
        {
            if (ButtonProcess[5] == "")
            {
                Button6Clicked = true;
                AddNew();
            }
            else
            {
                Process.Start(ButtonProcess[5]);
            }
        }
        private void button7_Click(object sender, EventArgs e)//Button 7
        {
            if (ButtonProcess[6] == "")
            {
                Button7Clicked = true;
                AddNew();
            }
            else
            {
                Process.Start(ButtonProcess[6]);
            }
        }
        private void button8_Click(object sender, EventArgs e)//Button 8
        {
            if (ButtonProcess[7] == "")
            {
                Button8Clicked = true;
                AddNew();
            }
            else
            {
                Process.Start(ButtonProcess[7]);
            }
        }

        private void button9_Click(object sender, EventArgs e)//Button 9
        {
            if (ButtonProcess[8] == "")
            {
                Button9Clicked = true;
                AddNew();
            }
            else
            {
                Process.Start(ButtonProcess[8]);
            }
        }

        private void AddNew()
        {
            exeFileDialog.Filter = "Programs|*.exe";
            exeFileDialog.Title = "Select a program";
            exeFileDialog.InitialDirectory = "C:";
            //Button1-----------------------------------------------------------------------------------------------
            if (Button1Clicked)
            {
                DialogResult result = exeFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ButtonProcess[0] = exeFileDialog.FileNames[0];
                    IconForFile[0] = Icon.ExtractAssociatedIcon(ButtonProcess[0]);
                    Icons[0] = IconForFile[0].ToBitmap();
                    button1.BackgroundImage = Icons[0];
                    SaveImage();

                    using (StreamWriter sw = new StreamWriter(FileLocation))
                    {
                        for (int i = 0; i < ButtonProcess.Length; i++)
                        {
                            sw.WriteLine(ButtonProcess[i]);
                        }
                        sw.Close();
                    }
                    button2.Visible = true;
                }
                else
                {
                    return;
                }
                Button1Clicked = false;
            }
            //Button2-----------------------------------------------------------------------------------------------
            if (Button2Clicked)
            {
                DialogResult result = exeFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ButtonProcess[1] = exeFileDialog.FileNames[0];
                    IconForFile[1] = Icon.ExtractAssociatedIcon(ButtonProcess[1]);
                    Icons[1] = IconForFile[1].ToBitmap();
                    button2.BackgroundImage = Icons[1];
                    SaveImage();

                    using (StreamWriter sw = new StreamWriter(FileLocation))
                    {
                        for (int i = 0; i < ButtonProcess.Length; i++)
                        {
                            sw.WriteLine(ButtonProcess[i]);
                        }
                        sw.Close();
                    }
                    button3.Visible = true;
                }
                else
                {
                    return;
                }
                Button2Clicked = false;
            }
            //Button3-----------------------------------------------------------------------------------------------
            if (Button3Clicked)
            {
                DialogResult result = exeFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ButtonProcess[2] = exeFileDialog.FileNames[0];
                    IconForFile[2] = Icon.ExtractAssociatedIcon(ButtonProcess[2]);
                    Icons[2] = IconForFile[2].ToBitmap();
                    button3.BackgroundImage = Icons[2];
                    SaveImage();

                    using (StreamWriter sw = new StreamWriter(FileLocation))
                    {
                        for (int i = 0; i < ButtonProcess.Length; i++)
                        {
                            sw.WriteLine(ButtonProcess[i]);
                        }
                        sw.Close();
                    }
                    button4.Visible = true;
                    if (Height < 220)
                    {
                        Height = 220;
                    }
                }
                else
                {
                    return;
                }
                Button3Clicked = false;
            }
            //Button4-----------------------------------------------------------------------------------------------
            if (Button4Clicked)
            {
                DialogResult result = exeFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ButtonProcess[3] = exeFileDialog.FileNames[0];
                    IconForFile[3] = Icon.ExtractAssociatedIcon(ButtonProcess[3]);
                    Icons[3] = IconForFile[3].ToBitmap();
                    button4.BackgroundImage = Icons[3];
                    SaveImage();

                    using (StreamWriter sw = new StreamWriter(FileLocation))
                    {
                        for (int i = 0; i < ButtonProcess.Length; i++)
                        {
                            sw.WriteLine(ButtonProcess[i]);
                        }
                        sw.Close();
                    }
                    button5.Visible = true;
                    if (Height < 220)
                    {
                        Height = 220;
                    }
                }
                else
                {
                    return;
                }
                Button4Clicked = false;
            }
            //Button5-----------------------------------------------------------------------------------------------
            if (Button5Clicked)
            {
                DialogResult result = exeFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ButtonProcess[4] = exeFileDialog.FileNames[0];
                    IconForFile[4] = Icon.ExtractAssociatedIcon(ButtonProcess[4]);
                    Icons[4] = IconForFile[4].ToBitmap();
                    button5.BackgroundImage = Icons[4];
                    SaveImage();

                    using (StreamWriter sw = new StreamWriter(FileLocation))
                    {
                        for (int i = 0; i < ButtonProcess.Length; i++)
                        {
                            sw.WriteLine(ButtonProcess[i]);
                        }
                        sw.Close();
                    }
                    button6.Visible = true;
                    if (Height < 220)
                    {
                        Height = 220;
                    }
                }
                else
                {
                    return;
                }
                Button5Clicked = false;
            }
            //Button6-----------------------------------------------------------------------------------------------
            if (Button6Clicked)
            {
                DialogResult result = exeFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ButtonProcess[5] = exeFileDialog.FileNames[0];
                    IconForFile[5] = Icon.ExtractAssociatedIcon(ButtonProcess[5]);
                    Icons[5] = IconForFile[5].ToBitmap();
                    button7.BackgroundImage = Icons[6];
                    SaveImage();

                    using (StreamWriter sw = new StreamWriter(FileLocation))
                    {
                        for (int i = 0; i < ButtonProcess.Length; i++)
                        {
                            sw.WriteLine(ButtonProcess[i]);
                        }
                        sw.Close();
                    }
                    button7.Visible = true;
                    if (Height < 320)
                    {
                        Height = 320;
                    }
                }
                else
                {
                    return;
                }
                Button6Clicked = false;
            }
            //Button7-----------------------------------------------------------------------------------------------
            if (Button7Clicked)
            {
                DialogResult result = exeFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ButtonProcess[6] = exeFileDialog.FileNames[0];
                    IconForFile[6] = Icon.ExtractAssociatedIcon(ButtonProcess[6]);
                    Icons[6] = IconForFile[6].ToBitmap();
                    button7.BackgroundImage = Icons[6];
                    SaveImage();

                    using (StreamWriter sw = new StreamWriter(FileLocation))
                    {
                        for (int i = 0; i < ButtonProcess.Length; i++)
                        {
                            sw.WriteLine(ButtonProcess[i]);
                        }
                        sw.Close();
                    }
                    button8.Visible = true;
                    if (Height < 320)
                    {
                        Height = 320;
                    }
                }
                else
                {
                    return;
                }
                Button7Clicked = false;
            }
            //Button8-----------------------------------------------------------------------------------------------
            if (Button8Clicked)
            {
                DialogResult result = exeFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ButtonProcess[7] = exeFileDialog.FileNames[0];
                    IconForFile[7] = Icon.ExtractAssociatedIcon(ButtonProcess[7]);
                    Icons[7] = IconForFile[7].ToBitmap();
                    button8.BackgroundImage = Icons[7];
                    SaveImage();

                    using (StreamWriter sw = new StreamWriter(FileLocation))
                    {
                        for (int i = 0; i < ButtonProcess.Length; i++)
                        {
                            sw.WriteLine(ButtonProcess[i]);
                        }
                        sw.Close();
                    }
                    button9.Visible = true;
                    if (Height < 320)
                    {
                        Height = 320;
                    }
                }
                else
                {
                    return;
                }
                Button8Clicked = false;
            }
            //Button9-----------------------------------------------------------------------------------------------
            if (Button9Clicked)
            {
                DialogResult result = exeFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ButtonProcess[8] = exeFileDialog.FileNames[0];
                    IconForFile[8] = Icon.ExtractAssociatedIcon(ButtonProcess[8]);
                    Icons[8] = IconForFile[8].ToBitmap();
                    button9.BackgroundImage = Icons[8];
                    SaveImage();

                    using (StreamWriter sw = new StreamWriter(FileLocation))
                    {
                        for (int i = 0; i < ButtonProcess.Length; i++)
                        {
                            sw.WriteLine(ButtonProcess[i]);
                        }
                        sw.Close();
                    }
                }
                else
                {
                    return;
                }
                Button9Clicked = false;
            }
        }

        private void SaveImage()
        {
            if (Button1Clicked)
            {
                Thread.Sleep(30);
                Bitmap bmpToSave = new Bitmap(Icons[0]);
                using (MemoryStream s = new MemoryStream())
                {
                    bmpToSave.Save(ImageFileLocation + "Button1Image.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                    s.Close();
                }
            }
            if (Button2Clicked)
            {
                Thread.Sleep(30);
                Bitmap bmpToSave = new Bitmap(Icons[1]);
                using (MemoryStream s = new MemoryStream())
                {
                    bmpToSave.Save(ImageFileLocation + "Button2Image.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                    s.Close();
                }

            }
            if (Button3Clicked)
            {
                Thread.Sleep(30);
                Bitmap bmpToSave = new Bitmap(Icons[2]);
                using (MemoryStream s = new MemoryStream())
                {
                    bmpToSave.Save(ImageFileLocation + "Button3Image.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                    s.Close();
                }
            }
            if (Button4Clicked)
            {
                Thread.Sleep(30);
                Bitmap bmpToSave = new Bitmap(Icons[3]);
                using (MemoryStream s = new MemoryStream())
                {
                    bmpToSave.Save(ImageFileLocation + "Button4Image.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                    s.Close();
                }
            }
            if (Button5Clicked)
            {
                Thread.Sleep(30);
                Bitmap bmpToSave = new Bitmap(Icons[4]);
                using (MemoryStream s = new MemoryStream())
                {
                    bmpToSave.Save(ImageFileLocation + "Button5Image.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                    s.Close();
                }
            }
            if (Button6Clicked)
            {
                Thread.Sleep(30);
                Bitmap bmpToSave = new Bitmap(Icons[5]);
                bmpToSave.Save(ImageFileLocation + "Button6Image.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            }
            if (Button7Clicked)
            {
                Thread.Sleep(30);
                Bitmap bmpToSave = new Bitmap(Icons[6]);
                bmpToSave.Save(ImageFileLocation + "Button7Image.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            }
            if (Button8Clicked)
            {
                Thread.Sleep(30);
                Bitmap bmpToSave = new Bitmap(Icons[7]);
                bmpToSave.Save(ImageFileLocation + "Button8Image.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            }
            if (Button9Clicked)
            {
                Thread.Sleep(30);
                Bitmap bmpToSave = new Bitmap(Icons[8]);
                bmpToSave.Save(ImageFileLocation + "Button9Image.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            }
        }


        private void RCDelete_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    // Get the control that is displaying this context menu
                    Control sourceControl = owner.SourceControl;
                    sourceControl.BackgroundImage = Resources.add;
                    switch (sourceControl.Name)
                    {
                        case "button1":
                            ButtonProcess[0] = "";
                            ButtonHasFunction[0] = false;
                            button1.BackgroundImage = Resources.add;
                            using (StreamWriter sw = new StreamWriter(FileLocation))
                            {
                                for (int i = 0; i < ButtonProcess.Length; i++)
                                {
                                    sw.WriteLine(ButtonProcess[i]);
                                }
                                sw.Close();
                            }
                            break;
                        case "button2":
                            ButtonProcess[1] = "";
                            ButtonHasFunction[1] = false;
                            button2.BackgroundImage = Resources.add;
                            using (StreamWriter sw = new StreamWriter(FileLocation))
                            {
                                for (int i = 0; i < ButtonProcess.Length; i++)
                                {
                                    sw.WriteLine(ButtonProcess[i]);
                                }
                                sw.Close();
                            }
                            break;
                        case "button3":
                            ButtonProcess[2] = "";
                            ButtonHasFunction[2] = false;
                            button3.BackgroundImage = Resources.add;
                            using (StreamWriter sw = new StreamWriter(FileLocation))
                            {
                                for (int i = 0; i < ButtonProcess.Length; i++)
                                {
                                    sw.WriteLine(ButtonProcess[i]);
                                }
                                sw.Close();
                            }
                            break;
                        case "button4":
                            ButtonProcess[3] = "";
                            ButtonHasFunction[3] = false;
                            button4.BackgroundImage = Resources.add;
                            using (StreamWriter sw = new StreamWriter(FileLocation))
                            {
                                for (int i = 0; i < ButtonProcess.Length; i++)
                                {
                                    sw.WriteLine(ButtonProcess[i]);
                                }
                                sw.Close();
                            }
                            break;
                        case "button5":
                            ButtonProcess[4] = "";
                            ButtonHasFunction[4] = false;
                            button5.BackgroundImage = Resources.add;
                            using (StreamWriter sw = new StreamWriter(FileLocation))
                            {
                                for (int i = 0; i < ButtonProcess.Length; i++)
                                {
                                    sw.WriteLine(ButtonProcess[i]);
                                }
                                sw.Close();
                            }
                            break;
                        case "button6":
                            ButtonProcess[5] = "";
                            ButtonHasFunction[5] = false;
                            button6.BackgroundImage = Resources.add;
                            //File.Delete(ImageFileLocation + "Button6Image.bmp");
                            break;
                        case "button7":
                            ButtonProcess[6] = "";
                            ButtonHasFunction[6] = false;
                            button7.BackgroundImage = Resources.add;
                            using (StreamWriter sw = new StreamWriter(FileLocation))
                            {
                                for (int i = 0; i < ButtonProcess.Length; i++)
                                {
                                    sw.WriteLine(ButtonProcess[i]);
                                }
                                sw.Close();
                            }
                            break;
                        case "button8":
                            ButtonProcess[7] = "";
                            ButtonHasFunction[7] = false;
                            button8.BackgroundImage = Resources.add;
                            using (StreamWriter sw = new StreamWriter(FileLocation))
                            {
                                for (int i = 0; i < ButtonProcess.Length; i++)
                                {
                                    sw.WriteLine(ButtonProcess[i]);
                                }
                                sw.Close();
                            }
                            break;
                        case "button9":
                            ButtonProcess[8] = "";
                            ButtonHasFunction[8] = false;
                            button9.BackgroundImage = Resources.add;
                            using (StreamWriter sw = new StreamWriter(FileLocation))
                            {
                                for (int i = 0; i < ButtonProcess.Length; i++)
                                {
                                    sw.WriteLine(ButtonProcess[i]);
                                }
                                sw.Close();
                            }
                            break;

                    }

                }
            }

        }



        private void RCImageUpload_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    // Get the control that is displaying this context menu
                    Control sourceControl = owner.SourceControl;
                    switch (sourceControl.Name)
                    {
                        case "button1":
                            if(button1.BackgroundImage == Resources.add)
                            {

                            }
                            break;
                        case "button2":
                            

                            break;
                        case "button3":


                            break;
                        case "button4":


                            break;
                        case "button5":


                            break;
                        case "button6":


                            break;
                        case "button7":


                            break;
                        case "button8":


                            break;
                        case "button9":


                            break;
                    }
                }
            }
        }

        private void RCImageBrowser_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    // Get the control that is displaying this context menu
                    Control sourceControl = owner.SourceControl;
                    switch (sourceControl.Name)
                    {
                        case "button1":
                        
                        
                            break;
                        case "button2":
                        
                        
                            break;
                        case "button3":


                            break;
                        case "button4":


                            break;
                        case "button5":


                            break;
                        case "button6":


                            break;
                        case "button7":


                            break;
                        case "button8":


                            break;
                        case "button9":


                            break;
                    }

                }
            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}