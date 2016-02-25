using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace k_means
{
    public partial class second : Telerik.WinControls.UI.RadForm
    {
        public second(int give, string[] d)
        {
            InitializeComponent();
            k = give;
            data = d;
            count=data.Length;
        }
        public string[] data;
        public int k;
        public int count;


        int maximum(string[] g)
        {
            int max=Int32.Parse(g[0]);
            for(int i=0;i<count;i++)
                if( ( Int32.Parse(g[i]) ) > max )
                    max = Int32.Parse(g[i]);
            return max;
        }

        bool check(int[] c, string data)
        {
            bool t=false;
            for (int i = 0; i < k; i++)
                for (int j = 0; j < i; j++)
                    if (c[j] == Int32.Parse(data))
                        t = true;
            return t;
        }

        private void second_Load(object sender, EventArgs e)
        {
            int[] c = new int[k];
            int random_number=0;
            Random rand;
            string [,] save_random_number=new string [k,2];
            for (int i = 0; i < k; i++)
            {
                rand = new Random(i+1);
                random_number = rand.Next(1, count);

                for (int j = 0; j < i; j++)
                    if (c[j] == Int32.Parse(data[random_number]))
                    {
                        rand = new Random(i+8);
                        random_number = rand.Next(1, count);
                    }


                c[i] = Int32.Parse(data[random_number]);
                

                save_random_number[i,0] = random_number.ToString();
            }
            int min=maximum(data),increase=1,index=0;
            bool k_index=true;

            for (int f = 0; f < k; f++)
                save_random_number[f, 1] = c[f].ToString();
            
            for (int i = 0; i < count; i++)
            {
                min = maximum(data);
                for (int f = 0; f < k; f++)
                    if (i ==Int32.Parse( save_random_number[f,0]))
                        k_index = false;
                if (k_index)
                {
                    for (int j = 0; j < k; j++)
                    {
                        int x;
                        if ((Int32.Parse(data[i])) > c[j])
                            x = (Int32.Parse(data[i])) - c[j];
                        else
                            x = c[j] - (Int32.Parse(data[i]));

                        if (x <= min)
                        {
                            index = j;
                            min = x;
                        }
                    }
                    save_random_number[index, 1] += "," + data[i];
                }
                k_index = true;
            }



            showing(save_random_number);


        }
        public int index_of_temp = 0;
        int max_string(int k,string[,] s)
        {
            int max=0;
            
            for (int i = 0; i < k; i++)
                if (max < s[i, 1].Length)
                {
                    index_of_temp = i;
                    max = s[i, 1].Length;
                }
            return max;
        }

        void showing(string[,] s)
        {
            for (int i = 0; i < k; i++)
                dataGridView1.Columns.Add("s1", "خوشه   " + (i+1));

            for (int i = 0; i < k; i++)
            {
                string[] temp = s[i, 1].Split(',');
                if (i == index_of_temp)
                    dataGridView1.Rows.Insert(0, temp.Length);
                for (int j = 0; j < temp.Length; j++)
                    dataGridView1.Rows[j].Cells[i].Value = temp[j];
            }
        }

        private void glassButton3_Click(object sender, EventArgs e)
        {
            firstmenu d = new firstmenu();
            d.Show();
            this.Hide();
        }

        private void second_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
