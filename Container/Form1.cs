using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Container
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, Form> activeForms;

        public Form1()
        {
            InitializeComponent();
            activeForms = new Dictionary<string, Form>();
        }

        private void OpenForm<T>(string key) where T : Form
        {
            Form form;
            if (!activeForms.ContainsKey(key))
            {

            }
        }

        private void menu_options_Click(object sender, EventArgs e)
        {
            string key = "options";
            Options form;
            if (!activeForms.ContainsKey(key))
            {
                form = new Options
                {
                    MdiParent = this
                };
                form.FormClosing += (s, ea) =>
                {
                    ((Form)s).Dispose();
                    activeForms.Remove(key);
                };
                activeForms.Add(key, form);
                form.Show();
            }
            else
            {
                form = (Options)activeForms[key];
                form.Activate();
            }
        }
    }
}
