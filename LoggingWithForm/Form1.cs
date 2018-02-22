﻿using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StulSoft.PCSharp.LoggingWithForm
{
    public partial class Form1 : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Form1));
        public Form1()
        {
            log.Info("Ctor of Form1");
            InitializeComponent();
        }
    }
}
