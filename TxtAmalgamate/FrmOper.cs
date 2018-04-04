using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using App;
using App.Win;

namespace TxtAmalgamate
{
    public partial class FrmOper : Form
    {
        public FrmOper()
        {
            InitializeComponent();
        }

        private void btyl_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tBdir.Text = fbd.SelectedPath;
            }
        }

        private void btoper_Click(object sender, EventArgs e)
        {
            Encoding en = Encoding.Default;
            StringBuilder strb = new StringBuilder();
            string path = tBdir.Text;
            string spath = tBsave.Text;
            List<string> paths = new List<string>();
            List<string> files = new List<string>();
            FileSys.GetAllDirFiles(path, ref files, ref paths, "*.txt");
            for (int i = 0; i < files.Count; i++)
            {
                string fpath = files[i];
                en = GetFileEncoding(fpath);
                StreamReader rd = new StreamReader(fpath, en);
                string StrRead = rd.ReadToEnd().ToString();
                StrRead = Filtrate(StrRead);
                strb.Append(StrRead);
            }
            FileStream fs = File.Create(spath);
            byte[] bContent = en.GetBytes(strb.ToString());
            fs.Write(bContent, 0, bContent.Length);
            fs.Close();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "文本文件(*.txt)|*.txt";
            sfd.Title = "保存文件";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                tBsave.Text = sfd.FileName;
            }
        }

        /// <summary>
        /// 返回文件的字符编码
        /// </summary>
        /// <param name="paths">文件路径</param>
        /// <returns>返回文件的字符编码</returns>
        public static Encoding GetFileEncoding(string paths)
        {
            Encoding en = Encoding.Default;
            try
            {
                FileStream fs = new FileStream(paths, FileMode.Open);
                ByteEncode be = new ByteEncode();
                string ens = be.GetByCode(fs);
                en = Encoding.GetEncoding(ens);
                fs.Close();
                fs = null;
            }
            catch 
            { 

            }
            return en;
        }

        private string Filtrate(string str) 
        {
            str = str.Replace("<p>","\r\n");
            str = str.Replace("document.write(\"", "");
            str = str.Replace("\");", "");
            str = str.Replace("document.write('", "");
            str = str.Replace("');", "");
            str = str.Replace("document.write", "");
            str = str.Replace("')", "");
            str = str.Replace("('", "");
            str = Often.OutTxt(str);
            str = str.Replace("　", "");
            while (str.IndexOf("\r\n\r\n") > -1)
            {
                str = str.Replace("\r\n\r\n", "\r\n");
            }
            while (str.IndexOf("  ") > -1)
            {
                str = str.Replace("  ", " ");
            }
            return str;
        }
    }
}
