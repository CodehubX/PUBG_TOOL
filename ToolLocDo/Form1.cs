using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ToolLocDo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btNguon_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK && ! String.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                tBNguon.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK && !String.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                tBLuu.Text = folderBrowserDialog.SelectedPath;
            }
        }
        Dictionary<Bitmap, FileInfo> AnhTim = new Dictionary<Bitmap, FileInfo>();
        private Thread autoThread;
        private void btBatDau_Click(object sender, EventArgs e)
        {
            if (btBatDau.Text == "Bắt đầu")
            {
                Rectangle rec;
                if (rB1.Checked || rB2.Checked)
                {
                    rec = new Rectangle(307, 72, 186, 27);
                }
                else
                    rec = new Rectangle(524, 277, 92, 84);

                btBatDau.Text = "Dừng";
                btBatDau.ForeColor = Color.Red;
                autoThread = new Thread(delegate ()
                {
                    LocDo(tBNguon.Text, tBLuu.Text, rec);
                });
                autoThread.IsBackground = true;
                autoThread.Start();
            }
            else
            {
                autoThread.Abort();
                btBatDau.Text = "Bắt đầu";
                btBatDau.ForeColor = Color.Black;
            }

            //CropAnh(tBNguon.Text, tBLuu.Text, rec);
            //MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);
        }
        private Bitmap LoadBitmapUnlocked(string file_name)
        {
            using (Bitmap bm = new Bitmap(file_name))
            {
                return new Bitmap(bm);
            }
        }
        private void LocDo(string folderIN, string folderOUT, Rectangle rec)
        {
            DirectoryInfo d;
            if (rB1.Checked)
                d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "data");
            else if (rB2.Checked)
                d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "data2");
            else if (rB3.Checked)
                d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "data3");
            else
                d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "data");
            FileInfo[] fi_data = d.GetFiles("*.png");
            foreach (FileInfo fi in fi_data)
            {
                AnhTim.Add(LoadBitmapUnlocked(fi.FullName), fi); // load data vào mảng động
            }
            Bitmap[] mangtim = AnhTim.Keys.ToArray();

            DirectoryInfo d_nguon = new DirectoryInfo(folderIN);
            FileInfo[] fi_nguon = d_nguon.GetFiles("*.png", SearchOption.AllDirectories);
            progressBar1.Minimum = 1;
            progressBar1.Maximum = fi_nguon.Length;
            int j = 1;
            int soAcc = 0;
            foreach (FileInfo fi in fi_nguon)
            {
                progressBar1.Value = j;
                Bitmap temp;
                try
                {
                    temp = LoadBitmapUnlocked(fi.FullName);              
                    temp = cropImage(temp, rec);

                    foreach (Bitmap bmp in mangtim)
                    {
                        if (ImageHelp.EmguCVSearch(temp, bmp))
                        {
                            soAcc++;
                            lbSoAcc.Text = soAcc.ToString();

                            FileInfo fi2 = AnhTim[bmp];
                            String folderLuu = folderOUT + "\\" + fi2.Name.Substring(0, fi2.Name.Length - 4);
                            if (!Directory.Exists(folderLuu))
                            {
                                Directory.CreateDirectory(folderLuu);
                            }
                            int i = 0;
                            while (true)
                            {
                                if (!Directory.Exists(folderLuu + "\\" + i))
                                {
                                    try
                                    {
                                        Directory.CreateDirectory(folderLuu + "\\" + i);
                                        if (cBXoaFileGoc.Checked)
                                        {
                                            File.Move(fi.FullName, folderLuu + "\\" + i + "\\" + fi.Name);
                                            File.Move(fi.FullName.Substring(0, fi.FullName.Length - fi.Name.Length) + "device_id.xml", folderLuu + "\\" + i + "\\" + "device_id.xml");
                                        }
                                        else
                                        {
                                            File.Copy(fi.FullName, folderLuu + "\\" + i + "\\" + fi.Name);
                                            File.Copy(fi.FullName.Substring(0, fi.FullName.Length - fi.Name.Length) + "device_id.xml", folderLuu + "\\" + i + "\\" + "device_id.xml");

                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        if (!cBBoQuaLoi.Checked)
                                            MessageBox.Show(ex.ToString());
                                    }
                                    break;
                                }
                                else
                                {
                                    i++;
                                }
                            }

                            break;
                        }
                        Thread.Sleep(2);
                    }
                    Thread.Sleep(2);
                    j++;
                }
                catch (Exception ex)
                {
                    if (!cBBoQuaLoi.Checked)
                        MessageBox.Show(ex.ToString());
                    continue;
                }
                
            }
            btBatDau.Text = "Bắt đầu";
            btBatDau.ForeColor = Color.Black;

        }
        private void CropAnh(string folderIN, string folderOUT , Rectangle rec)
        {
            DirectoryInfo d = new DirectoryInfo(folderIN);
            FileInfo[] fileInfos = d.GetFiles("*.png", SearchOption.AllDirectories);
            foreach (FileInfo file in fileInfos)
            {
                Bitmap bitmap = new Bitmap(file.FullName);
                Bitmap bitmap_Luu = cropImage(bitmap, rec);
                bitmap_Luu.Save(folderOUT + @"\" + file.Name);
            }

            
        }
        private static Bitmap cropImage(Bitmap img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }

        private void btDoiTen_Click(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "data");
            FileInfo[] fileInfos = d.GetFiles("*.png");
            foreach(FileInfo fi in fileInfos)
            {
                fi.MoveTo(fi.Name.Replace(" icon", "").Replace("icon ", ""));
            }
        }

        private void btCropAnh_Click(object sender, EventArgs e)
        {
            Rectangle rec = new Rectangle(307, 72, 186, 27);
            //Rectangle rec = new Rectangle(20, 5, 149, 16);
            CropAnh(tBNguon.Text, tBLuu.Text, rec);
            MessageBox.Show("Done!");
        }
    }
}
