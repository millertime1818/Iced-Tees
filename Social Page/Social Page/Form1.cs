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

namespace Social_Page
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //LV properties
            listView1.View = View.Details;
            //construct columns
            listView1.Columns.Add("designs", 250);
        }
        //populate with images
        private void populate()
        {
            //img list to hold images
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(50, 50);
            
            //load images from file
            String[] paths = { };
            paths = Directory.GetFiles(@"C:Iced Tees Project\Website\Social Page\bin\Debug\Designs");

            foreach(string path in paths)
            {
               imgs.Images.Add(Image.FromFile(path));
            }
            
            listView1.SmallImageList = imgs;
            listView1.Items.Add("SocraTees16", 0);
            listView1.Items.Add("MrTees", 1);
            listView1.Items.Add("ArisTeestle4", 2);
            listView1.Items.Add("MrTeeser", 3);
            listView1.Items.Add("novelTees78", 4);
            listView1.Items.Add("GWashingTees86", 5);
            listView1.Items.Add("MegaTdesigns", 6);
            listView1.Items.Add("User81234", 7);
            listView1.Items.Add("BostonTeesParty32", 8);
            listView1.Items.Add("xXTeesGuyXx", 9);
        }
        private void loadBtn_Click(object sender, EventArgs e)
        {
   
        }

        private void loadBtn_MouseClick(object sender, MouseEventArgs e)
        {
            populate();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            String selected = listView1.SelectedItems[0].SubItems[0].Text;
             
            MessageBox.Show(selected);
           
        }
    }
}
