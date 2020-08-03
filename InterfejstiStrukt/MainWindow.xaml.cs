using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace InterfejstiStrukt
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			Klasa k = new Klasa();
			TestStrukt ts = new TestStrukt();
			k.broj = 5;
			ts.broj = 5;
			kInc(k);
			sInc(ts);
			MessageBox.Show(k.broj.ToString());
			MessageBox.Show(ts.broj.ToString());
		}

		public void kInc(Klasa neka) => neka.broj++;
		public void sInc(TestStrukt tss) => tss.broj++;
	}

	public class A
	{ }
	
	public class B:A, INesto
	{
		public void Foo()
		{

		}

		public decimal Bla() => 0;
	}

	public interface INesto
	{
		void Foo();
		decimal Bla();
	}

	public class Klasa
	{
		public int broj;
	}

	public struct TestStrukt
	{
		public int broj;
		public void Foo() { }
	}
}
