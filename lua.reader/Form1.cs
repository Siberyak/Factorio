using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lua.reader
{
    public partial class Form1 : Form
    {
        private Storage _storage;

        public Form1()
        {
            LoadData();
            InitializeComponent();
        }

        void LoadData()
        {
            //var flag = false;
            //if (flag)
            //    Load();
            _storage = Storage.Load();
        }
    }
}
