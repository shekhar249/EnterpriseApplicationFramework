﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UI.Services.Interfaces.Services.TransactionManagerService;

namespace UI.TestApp1
{
    /// <summary>
    /// Interaction logic for Top.xaml
    /// </summary>
    public partial class TestApp1 : UserControl
    {
        public TestApp1(/*ITransactionManager txnManager*/)
        {
            InitializeComponent();
        }
    }
}
