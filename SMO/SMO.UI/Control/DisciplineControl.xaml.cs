﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SMO.Core;
using SMO.UI.Views;
using Microsoft.Practices.Unity;

namespace SMO.UI.Control
{
	/// <summary>
	/// Interaction logic for DisciplineControl.xaml
	/// </summary>
	public partial class DisciplineControl : UserControl
	{
		public DisciplineControl()
		{
			this.InitializeComponent();
		   // DataContext = App.Container.Resolve<DisciplineView>();
		}
	}
}