using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace home_work
{
	public partial class Form1 : Form
	{
		string _filepath = "";
		NetDB _db = new NetDB();
		Net _net = new Net();

		public Form1()
		{
			InitializeComponent();
			learningrate.Text = "0.5";
			hidelayers.Text = "1";
			hideneuroncount.Text = "2";
			trainingloop.Text = "200";
		}

		private void selectdata_Click(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog();
			file.ShowDialog();
			_filepath = file.FileName;
			filename.Text = file.SafeFileName;
			_db.ReadFile(_filepath);
		}

		private void trainbutton_Click(object sender, EventArgs e)
		{
			List<KeyValuePair<List<double>, double>> dataset = _db.GetTrainData();
			if (dataset.Count == 0)
				return;

			List<double> list = new List<double>();
			double error = 0;
			double RMSE = 0;
			int index = 0;
			int loop = Int32.Parse(trainingloop.Text);
			if (loop == 0)
			{
				loop = 1000;
			}
			
			trainprogress.Text = "訓練中...";
			trainprogress.Update();
			trainRMSE.Clear();
			CreateNetModel(dataset);
			
			while (index < loop)
			{
				list.Clear();
				error = 0;
				foreach (var i in dataset)
				{
					list.Add(_net.InputData(i.Key, i.Value));
				}

				foreach (var v in list)
				{
					error += (v * v);
				}

				error = error / list.Count;
				RMSE = Math.Sqrt(error);

				trainRMSE.AppendText(RMSE.ToString() + "\n");
				index++;
				if (RMSE == 0)
				{
					break;
				}
			}

			string str = String.Format("訓練結束!!  辨識率:{0:0.000}%, 訓練次數:{1}次", 100 - (RMSE * 100), index);
			trainprogress.Text = str;
			trainprogress.Update();
		}

		private void CreateNetModel(List<KeyValuePair<List<double>, double>> dataset)
		{
			double learning = 0;
			int neuroncount = 0;
			int hidelayer = 0;

			learning = Double.Parse(learningrate.Text);
			if (learning == 0 || learning > 1)
			{
				learning = 0.5;
			}

			neuroncount = Int32.Parse(hideneuroncount.Text);
			if (neuroncount == 0)
			{
				neuroncount = dataset.First().Key.Count;
			}

			hidelayer = Int32.Parse(hidelayers.Text);
			if (hidelayer == 0)
			{
				hidelayer = 1;
			}
			_net.Clear();
			for (int i = 0; i < hidelayer; i++)
			{
				if (i > 0)
				{
					_net.CreateNetLayer(true, neuroncount, neuroncount + 1, learning);
				}
				else
				{
					_net.CreateNetLayer(true, neuroncount, dataset.First().Key.Count, learning);
				}
			}
			_net.CreateNetLayer(false, 1, neuroncount + 1, learning);
			_net.SetClassify(_db.GetClassify());
		}

		private void testbutton_Click(object sender, EventArgs e)
		{
			double error = 0;
			double RMSE = 0;
			List<double> list = new List<double>();
			List<KeyValuePair<List<double>, double>> dataset = _db.GetTestData();

			if (dataset.Count == 0)
				dataset = _db.GetTrainData();

			testprogress.Text = "測試中...";
			testprogress.Update();
			testRMSE.Clear();

			foreach (var i in dataset)
			{
				list.Add(_net.InputData(i.Key, i.Value));
			}

			foreach (var v in list)
			{
				error += (v * v);
			}

			error = error / list.Count;
			RMSE = Math.Sqrt(error);

			testRMSE.AppendText(RMSE.ToString() + "\n");

			string str = String.Format("測試結束!!  辨識率:{0:0.000}%", 100 - (RMSE * 100));
			testprogress.Text = str;
			testprogress.Update();
		}

		private void repreparedata_Click(object sender, EventArgs e)
		{
			_db.PreapareTrainingData();
		}
	}
}
