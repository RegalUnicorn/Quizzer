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

namespace Quizzer
{
    /// <summary>
    /// Interaction logic for MCRadioButton.xaml
    /// </summary>
    public partial class MCRadioButton : RadioButton
    {
        public int id = 0;  
        public MCRadioButton(int idT)
        {
            id = idT;
            InitializeComponent();
        }
    }
}
