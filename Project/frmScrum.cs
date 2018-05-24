using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication83
{
    public partial class frmScrum : Form
    {
        public frmScrum()
        {
            InitializeComponent();
        }
        ListBox[] taskbilgi = new ListBox[3];
        public object lb_item = null;
        public object lb_item2 = null;
        public object lb_item3 = null;
        private void button1_Click(object sender, EventArgs e)
        {
 
            gpDone.Visible = true;
            gbInProgess.Visible = true;
            gbNotStarted.Visible = true;
            Task task = new Task();
            task.Kisi = txtKisi.Text;
            task.Tarih = dtpTarih.Value;
            if (cmbStory.SelectedIndex == 0)
            {
                lbNotStarted1.Items.Add(task.Kisi + " - " + task.Tarih);
                lbNotStarted1.Visible = true;
                lbInProgress1.Visible = true;
                lbDone1.Visible = true;

            }
            if (cmbStory.SelectedIndex == 1)
            {
                lbNotStarted2.Items.Add(task.Kisi + " - " + task.Tarih);
                lbNotStarted2.Visible = true;
                lbInProgress2.Visible = true;
                lbDone2.Visible = true;

            }
            if (cmbStory.SelectedIndex == 2)
            {
                lbNotStarted3.Items.Add(task.Kisi + " - " + task.Tarih);

                lbNotStarted3.Visible = true;
                lbInProgress3.Visible = true;
                lbDone3.Visible = true;
            }
            if (cmbStory.SelectedIndex == 3)
            {
                lbNotStarted4.Items.Add(task.Kisi + " - " + task.Tarih);

                lbNotStarted4.Visible = true;
                lbInProgress4.Visible = true;
                lbDone4.Visible = true;
            }

            txtKisi.Clear();

        }



        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
                lbNotStarted1.Items.Add(file);

        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {

            lb_item = null;
            if (lbNotStarted1.Items.Count == 0)
            {
                return;
            }
            Point nokta = new Point(e.X, e.Y);
            int sira = lbNotStarted1.IndexFromPoint(nokta);
            lbNotStarted1.IndexFromPoint(nokta);
            if (e.Button == MouseButtons.Left)
            {

                lbNotStarted1.DoDragDrop(lbNotStarted1.Items[sira], DragDropEffects.Move);
            }


        }

        private void listBox2_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {

            lb_item2 = null;
            lbInProgress1.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
            //alma işlemi format belirle

        }

        private void listBox1_DragLeave(object sender, EventArgs e)
        {

            lb_item = lbNotStarted1.SelectedItem;
            lbNotStarted1.Items.Remove(lbNotStarted1.SelectedItem);
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {


            lb_item2 = null;
            if (lbInProgress1.Items.Count == 0)
            {
                return;
            }
            Point nokta = new Point(e.X, e.Y);
            int sira = lbInProgress1.IndexFromPoint(nokta);
            lbInProgress1.IndexFromPoint(nokta);
            if (e.Button == MouseButtons.Left)
            {

                lbInProgress1.DoDragDrop(lbInProgress1.Items[sira], DragDropEffects.Move);
            }



        }

        private void listBox2_DragLeave(object sender, EventArgs e)
        {

            lb_item2 = lbInProgress1.SelectedItem;
            lbInProgress1.Items.Remove(lbInProgress1.SelectedItem);

        }



        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {



            //if (e.Data.GetData(typeof(ListBox.SelectedObjectCollection)) != null)
            //{
            //    e.Effect = DragDropEffects.Move;
            //}
            //else
            //{
            //    e.Effect = DragDropEffects.None;
            //}


        }

        private void listBox3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            if (lb_item2 != null)
            {
                lbDone1.Items.Add(lb_item2);
                lb_item2 = null;
            }
        }
        int i = 0;
        int top = 35;
        int ust = 60;
        //int kaydir = 500;
        private void btnStoryEkle_Click(object sender, EventArgs e)
        {
            


            gpDone.Visible = true;
            gbInProgess.Visible = true;
            gbNotStarted.Visible = true;
            Label[] storybaslik = new Label[5];
            TextBox[] storyaciklama = new TextBox[5];

            Story story = new Story();



            





            if (cmbStory.Items.IndexOf(txtStoryBasligi.Text) != -1)
                MessageBox.Show("Kayıtlı Story Var");

            else
            {
                story.StoryBasligi = txtStoryBasligi.Text;
                story.StoryAciklamasi = txtStoryAciklama.Text;


                storybaslik[i] = new Label();

                storybaslik[i].Name = "lblstory" + i.ToString();
                storybaslik[i].Text = story.StoryBasligi;
                this.Controls.Add(storybaslik[i]);
                storybaslik[i].Top = top;
                storybaslik[i].Left = 250;
                storybaslik[i].Width = 200;
                storybaslik[i].ForeColor = Color.Red;

                storybaslik[i].Font = new Font("Tahoma", 12, FontStyle.Bold);


                top = top + 150;
                i++;

                storyaciklama[i] = new TextBox();
                storyaciklama[i].Text = story.StoryAciklamasi;
                storyaciklama[i].Name = "txtstoryaciklama" + i;
                storyaciklama[i].Multiline = true;
                storyaciklama[i].Location = new Point(250, ust);
                storyaciklama[i].Size = new Size(230, 120);

                this.Controls.Add(storyaciklama[i]);


                ust = ust + 150;


                cmbStory.Items.Add(txtStoryBasligi.Text);
            }

            txtStoryBasligi.Clear();
            txtStoryAciklama.Clear();
            
        }

        private void lbl_StoryIsmi_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbInProgress1.Visible = false;
            lbInProgress2.Visible = false;
            lbInProgress3.Visible = false;
            lbInProgress4.Visible = false;
            lbDone1.Visible = false;
            lbDone2.Visible = false;
            lbDone3.Visible = false;
            lbDone4.Visible = false;
            lbNotStarted1.Visible = false;
            lbNotStarted2.Visible = false;
            lbNotStarted3.Visible = false;
            lbNotStarted4.Visible = false;
            gpDone.Visible = false;
            gbInProgess.Visible = false;
            gbNotStarted.Visible = false;

        }
     


        private void button1_Click_1(object sender, EventArgs e)
        {
            cmbStory.Items.Remove(cmbStory.SelectedItem);
            cmbStory.Text = null;
        }

        private void cmbStory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_MouseDown(object sender, MouseEventArgs e)
        {

            lb_item = null;
            if (lbNotStarted2.Items.Count == 0)
            {
                return;
            }
            Point nokta = new Point(e.X, e.Y);
            int sira = lbNotStarted2.IndexFromPoint(nokta);
            lbNotStarted2.IndexFromPoint(nokta);
            if (e.Button == MouseButtons.Left)
            {

                lbNotStarted2.DoDragDrop(lbNotStarted2.Items[sira], DragDropEffects.Move);
            }

        }

        private void listBox4_DragDrop(object sender, DragEventArgs e)
        {

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
                lbNotStarted2.Items.Add(file);
        }

        private void listBox4_DragEnter(object sender, DragEventArgs e)
        {


        }

        private void listBox4_DragLeave(object sender, EventArgs e)
        {
            lb_item3 = lbNotStarted2.SelectedItem;
            lbNotStarted2.Items.Remove(lbNotStarted2.SelectedItem);
        }

        private void listBox5_MouseDown(object sender, MouseEventArgs e)
        {
            lb_item3 = null;
            if (lbInProgress2.Items.Count == 0)
            {
                return;
            }
            Point nokta = new Point(e.X, e.Y);
            int sira = lbInProgress2.IndexFromPoint(nokta);
            lbInProgress2.IndexFromPoint(nokta);
            if (e.Button == MouseButtons.Left)
            {

                lbInProgress2.DoDragDrop(lbInProgress2.Items[sira], DragDropEffects.Move);
            }
        }

        private void listBox5_DragDrop(object sender, DragEventArgs e)
        {
            lb_item3 = null;
            lbInProgress2.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
            //alma işlemi format belirle
        }

        private void listBox5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(ListBox.SelectedObjectCollection)) != null)
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox5_DragLeave(object sender, EventArgs e)
        {
            lb_item3 = lbInProgress2.SelectedItem;
            lbInProgress2.Items.Remove(lbInProgress2.SelectedItem);
        }

        private void listBox5_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listBox6_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            if (lb_item3 != null)
            {
                lbDone2.Items.Add(lb_item3);
                lb_item3 = null;
            }
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox7_MouseDown(object sender, MouseEventArgs e)
        {
            lb_item = null;
            if (lbNotStarted3.Items.Count == 0)
            {
                return;
            }
            Point nokta = new Point(e.X, e.Y);
            int sira = lbNotStarted3.IndexFromPoint(nokta);
            lbNotStarted3.IndexFromPoint(nokta);
            if (e.Button == MouseButtons.Left)
            {

                lbNotStarted3.DoDragDrop(lbNotStarted3.Items[sira], DragDropEffects.Move);
            }
        }

        private void listBox7_DragLeave(object sender, EventArgs e)
        {
            lb_item3 = lbNotStarted3.SelectedItem;
            lbNotStarted3.Items.Remove(lbNotStarted3.SelectedItem);
        }

        private void listBox7_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
                lbNotStarted3.Items.Add(file);
        }

        private void listBox8_MouseDown(object sender, MouseEventArgs e)
        {
            lb_item3 = null;
            if (lbInProgress3.Items.Count == 0)
            {
                return;
            }
            Point nokta = new Point(e.X, e.Y);
            int sira = lbInProgress3.IndexFromPoint(nokta);
            lbInProgress3.IndexFromPoint(nokta);
            if (e.Button == MouseButtons.Left)
            {

                lbInProgress3.DoDragDrop(lbInProgress3.Items[sira], DragDropEffects.All);
            }
        }

        private void listBox8_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listBox8_DragLeave(object sender, EventArgs e)
        {
            lb_item3 = lbInProgress3.SelectedItem;
            lbInProgress3.Items.Remove(lbInProgress3.SelectedItem);
        }

        private void listBox8_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(ListBox.SelectedObjectCollection)) != null)
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox8_DragDrop(object sender, DragEventArgs e)
        {
            lb_item3 = null;
            lbInProgress3.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
            //alma işlemi format belirle
        }

        private void listBox9_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            if (lb_item3 != null)
            {
                lbDone3.Items.Add(lb_item3);
                lb_item3 = null;
            }
        }

        private void listBox12_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            if (lb_item3 != null)
            {
                lbDone4.Items.Add(lb_item3);
                lb_item3 = null;
            }
        }

        private void listBox10_MouseDown(object sender, MouseEventArgs e)
        {
            lb_item = null;
            if (lbNotStarted4.Items.Count == 0)
            {
                return;
            }
            Point nokta = new Point(e.X, e.Y);
            int sira = lbNotStarted4.IndexFromPoint(nokta);
            lbNotStarted4.IndexFromPoint(nokta);
            if (e.Button == MouseButtons.Left)
            {

                lbNotStarted4.DoDragDrop(lbNotStarted4.Items[sira], DragDropEffects.Move);
            }
        }

        private void listBox10_DragLeave(object sender, EventArgs e)
        {
            lb_item3 = lbNotStarted4.SelectedItem;
            lbNotStarted4.Items.Remove(lbNotStarted4.SelectedItem);
        }

        private void listBox10_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
                lbNotStarted4.Items.Add(file);
        }

        private void listBox11_MouseDown(object sender, MouseEventArgs e)
        {
            lb_item3 = null;
            if (lbInProgress4.Items.Count == 0)
            {
                return;
            }
            Point nokta = new Point(e.X, e.Y);
            int sira = lbInProgress4.IndexFromPoint(nokta);
            lbInProgress4.IndexFromPoint(nokta);
            if (e.Button == MouseButtons.Left)
            {

                lbInProgress4.DoDragDrop(lbInProgress4.Items[sira], DragDropEffects.All);
            }
        }

        private void listBox11_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listBox11_DragLeave(object sender, EventArgs e)
        {
            lb_item3 = lbInProgress4.SelectedItem;
            lbInProgress4.Items.Remove(lbInProgress4.SelectedItem);
        }

        private void listBox11_DragEnter(object sender, DragEventArgs e)
        {



            e.Effect = DragDropEffects.None;

        }

        private void listBox11_DragDrop(object sender, DragEventArgs e)
        {
            lb_item3 = null;
            lbInProgress4.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
            //alma işlemi format belirle
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
    }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void flyoutPanelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

