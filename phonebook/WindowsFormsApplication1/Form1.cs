using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization; 

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Data
        {
            public string name;
            public string surname;
            public string city;
            public string number;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter reader = new BinaryFormatter();
                FileStream input = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                Data[] Person = (Data[])reader.Deserialize(input);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < Person.Length; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1[0, i].Value = Person[i].name;
                    dataGridView1[1, i].Value = Person[i].surname;
                    dataGridView1[2, i].Value = Person[i].city;
                    dataGridView1[3, i].Value = Person[i].number;

                }


            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                FileStream output = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                int n = dataGridView1.RowCount;

                Data[] person = new Data[n - 1];

                for (int i = 0; i < n - 1; i++)
                {
                    person[i] = new Data();

                    person[i].name = dataGridView1[0, i].Value.ToString();
                    person[i].surname = dataGridView1[1, i].Value.ToString();
                    person[i].city = dataGridView1[2, i].Value.ToString();
                    person[i].number = dataGridView1[3, i].Value.ToString();

                }
                formatter.Serialize(output, person);

                output.Close();

            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        

        
       
    }
}
