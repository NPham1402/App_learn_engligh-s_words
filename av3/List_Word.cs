using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace av3
{
    class List_Word
    {
        SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-CB0987P;Initial Catalog=developent;Integrated Security=True");
        Words [] listword;
        public List_Word()
        {
        
        }
        public List_Word(int d)
        {
            
            string cmtext2 = "select stt,Word,Type_of_word,Mean ,the_date_add from Word_study ,history_word where STT=id";
            string cmtext1 = "select count(stt) as count from Word_study ,history_word where STT=id";
            SqlCommand cm1 = new SqlCommand(cmtext1, con2);
            SqlCommand cm2 = new SqlCommand(cmtext2, con2);
            con2.Open();
            SqlDataReader dr = cm1.ExecuteReader();
            dr.Read();
            int temp = (int)dr["count"];
            con2.Close();
            con2.Open();
            listword = new Words[temp];
            int i = 0;
            SqlDataReader dr2 = cm2.ExecuteReader();
            while (dr2.Read())
            {

                string[] words = dr2["The_date_add"].ToString().Split(' ');
                listword[i] = new Words((string)dr2["Word"], (string)dr2["Type_of_word"], (string)dr2["Mean"],words[0]);                
                i++;
             
            }
            for (int y = 0; y <listword.Length; y++)
            {
                Console.WriteLine(listword[y].word + " " + listword[y].tow + " " + listword[y].mean);
            }
            con2.Close();
            int a = listword.Length;
        }
        public string xuat_word(int id)
        {
            return listword[id].word; 
        }
        public string xuat_tow(int id)
        {
            return listword[id].tow;
        }
        public string xuat_mean(int id)
        {
            return listword[id].mean;
        }
        private int tinh_toan_so_luong(string date_add)
        {
            int num = 0;
            for (int i = 0; i < listword.Length; i++)
            {
                if (listword[i].date_add==date_add)
                {
                    num++;
                }
            }
            return num;
        }
        public int xuat_date_min(string date_add)
        {
            int a = 0;
            int i;
            for ( i = 0; i <listword.Length; i++)
            {
                if (listword[i].date_add == date_add&&listword[i-1].date_add!=date_add)
                {
                    a = i;
                    break;
                }
            }
            Console.WriteLine("Min:"+a);
            Console.WriteLine(i);
            return a;
        }
        public int xuat_date_max(string date_add)
        {
            int a = 0;
            int i;
            for (i = 0; i < listword.Length; i++)
            {
                if (i==listword.Length-1)
                {
                    a = listword.Length - 1;
                    break;
                }
                if (listword[i].date_add == date_add && listword[i + 1].date_add != date_add)
                {
                    a = i;
                    break;
                }
            }
            Console.WriteLine(i);
            Console.WriteLine("max:"+a);
            return a;
        }
    }
}
