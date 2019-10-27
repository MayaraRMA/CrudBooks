using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudBooks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //ListView Properties
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            //Construct Columns
            listView1.Columns.Add("Título", 400);
            listView1.Columns.Add("Classificação", 150);
            listView1.Columns.Add("Edição", 100);
            listView1.Columns.Add("Ano", 100);
            listView1.Columns.Add("ISBN", 200);    
        }
        //Add to Lv
        private void add(String title, String classification, String edition, String year, String isbn)
        {
            String[] row = { title, classification, edition, year, isbn };

            ListViewItem item = new ListViewItem(row);

            listView1.Items.Add(item);
        }

        //update
        private void update()
        {
            listView1.SelectedItems[0].SubItems[0].Text = titleTxtBox.Text;
            listView1.SelectedItems[0].SubItems[1].Text = classTxtBox.Text;
            listView1.SelectedItems[0].SubItems[2].Text = editionTxtBox.Text;
            listView1.SelectedItems[0].SubItems[3].Text = yearTxtMask.Text;
            listView1.SelectedItems[0].SubItems[4].Text = isbnTxtBox.Text;

            //clear txt
            titleTxtBox.Text = "";
            classTxtBox.Text = "";
            editionTxtBox.Text = "";
            yearTxtMask.Text = "";
            isbnTxtBox.Text = "";
        }

        private void delete()
        {
            if(MessageBox.Show("Tem certeza que deseja excluir esse livro?", "EXCLUIR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning )==DialogResult.OK)
            {
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);

                //clear txt
                titleTxtBox.Text = "";
                classTxtBox.Text = "";
                editionTxtBox.Text = "";
                yearTxtMask.Text = "";
                isbnTxtBox.Text = "";
            }
        }

        private void TurnOffButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            //clear txt
            titleTxtBox.Text = "";
            classTxtBox.Text = "";
            editionTxtBox.Text = "";
            yearTxtMask.Text = "";
            isbnTxtBox.Text = "";
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            update();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            add(titleTxtBox.Text, classTxtBox.Text, editionTxtBox.Text, yearTxtMask.Text, isbnTxtBox.Text);


            //clear txt
            titleTxtBox.Text = "";
            classTxtBox.Text = "";
            editionTxtBox.Text = "";
            yearTxtMask.Text = "";
            isbnTxtBox.Text = "";


        }

        private void ListView1_MouseClick(object sender, MouseEventArgs e)
        {
            titleTxtBox.Text = listView1.SelectedItems[0].SubItems[0].Text;
            classTxtBox.Text = listView1.SelectedItems[0].SubItems[1].Text;
            editionTxtBox.Text = listView1.SelectedItems[0].SubItems[2].Text;
            yearTxtMask.Text = listView1.SelectedItems[0].SubItems[3].Text;
            isbnTxtBox.Text = listView1.SelectedItems[0].SubItems[4].Text;
            

        }
    }
}
