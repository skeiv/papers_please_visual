using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paperplease_visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            bool flag = true;
            int total = 0;
            int errors = 0;
            int errorsCount = 0;
            if ((BirthDate.Text == "") || (fname.Text == "") || (mname.Text == "") || (lname.Text == "") || (city.Text == ""))
            {
                string message = "Вы не ввели некоторые паспортные данные. Продолжить?";
                string caption = "Неверно введены данные";
                DialogResult result;
                result = MessageBox.Show(message, caption);
            }
            else
            {
                Passport restoredPerson = new Passport(BirthDate.Text, fname.Text, mname.Text, lname.Text, city.Text);
                if ((gAge.Text == "") || (gFname.Text == "") || ((gLname.Text != "") && (gMname.Text == "")))
                {
                    string message = "Вы не ввели некоторые входные данные или ввели неправильно. Продолжить?";
                    string caption = "Неверно введены данные";
                    DialogResult result;
                    result = MessageBox.Show(message, caption);
                }
                else
                {
                    #region Проверка введенных данных
                    int age = 0;
                    DateTime bd = DateTime.Now;
                    try
                    {
                        age = Convert.ToInt32(gAge.Text);
                    }
                    catch (FormatException ex)
                    {
                        string message = ex.Message;
                        string caption = "Неверно введены данные";
                        gAge.Text = "";
                        flag = false;
                        DialogResult result;
                        result = MessageBox.Show(message, caption);
                    }
                    try
                    {
                        bd = DateTime.Parse(BirthDate.Text.Replace(":", "/"));
                    }
                    catch (FormatException ex)
                    {
                        string message = ex.Message;
                        string caption = "Неверно введены данные";
                        BirthDate.Text = "";
                        flag = false;
                        DialogResult result;
                        result = MessageBox.Show(message, caption);
                    }
                    #endregion
                    if (flag)
                    {
                        List<string> name = new List<string> { restoredPerson.fname, restoredPerson.mname, restoredPerson.lname };
                        List<string> gname = new List<string>();
                        gname.Add(gFname.Text);
                        if (gMname.Text != "") gname.Add(gMname.Text);
                        if (gLname.Text != "") gname.Add(gLname.Text);
                        int span = Convert.ToInt32(Math.Truncate(DateTime.Now.Subtract(bd).TotalDays / 365));

                        for (int i = 0; i < gname.Count; i++)
                        {
                            int a = 0;
                            if (name[i].Length < gname[i].Length) a = name[i].Length;
                            else a = gname[i].Length;
                            errors += Math.Abs(name[i].Length - gname[i].Length);
                            for (int j = 0; j < a; j++)
                            {
                                if (name[i][j] != gname[i][j])
                                {
                                    errors++;
                                }
                            }
                        }
                        if ((errors <= 2) && (span == age) && (city.Text != tabuCity.Text))
                        {
                            acceptedTable.Rows.Add(restoredPerson.birth, restoredPerson.lname + ' ' + restoredPerson.fname + ' ' + restoredPerson.mname, restoredPerson.city);
                        }
                        else
                        {
                            if (span != age)
                            {
                                errorsCount++;
                            }
                            if (errors > 2)
                            {
                                errorsCount++;
                            }
                            if (tabuCity.Text == city.Text)
                            {
                                errorsCount++;
                            }
                            Random rnd = new Random();
                            if ((rnd.Next(2) == 1) && checkBox.Checked)
                            {
                                total += errorsCount * 250;
                                Total.Text = Convert.ToString(Convert.ToInt32(Total.Text) + total);
                                suspectTable.Rows.Add(restoredPerson.birth, restoredPerson.lname + ' ' + restoredPerson.fname + ' ' + restoredPerson.mname, restoredPerson.city);
                            }
                            else
                            {
                                deniedTable.Rows.Add(restoredPerson.birth, restoredPerson.lname + ' ' + restoredPerson.fname + ' ' + restoredPerson.mname, restoredPerson.city);
                            }
                        }
                    }
                }
            }
        }
    }
}
