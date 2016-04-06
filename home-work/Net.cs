using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace home_work
{
	class Net
	{
		List<NetLayer> _net = new List<NetLayer>();
		Dictionary<double, KeyValuePair<double, double>> _classify = new Dictionary<double, KeyValuePair<double, double>>();

		public void Clear()
		{
			_classify.Clear();
			foreach (var i in _net)
			{
				i.Clear();
			}
			_net.Clear();
		}

		public void SetClassify(List<double> list)
		{
			double classrange = 1.0/list.Count;
			list.Sort();

			for (int i = 0; i < list.Count;i++)
			{
				_classify[list[i]] = new KeyValuePair<double, double>(classrange * i, classrange * (i + 1));
			}
		}

		public void CreateNetLayer(bool isHide, int neuroncount, int weightcount,double learningrate)
		{
			NetLayer layer = new NetLayer(neuroncount, isHide, weightcount, learningrate);
			_net.Add(layer);
		}

		private double BackNet(double y, double expectvalue, List<double> orginallist)
		{
			int count = _net.Count;
			List<List<KeyValuePair<double, double>>> mutisigmalist = new List<List<KeyValuePair<double, double>>>();
			List<double> sigmalist = new List<double>();
			List<double> wlist = new List<double>();
			double error = 0;

			KeyValuePair<double, double> classvalue = new KeyValuePair<double, double>();
			_classify.TryGetValue(expectvalue, out classvalue);

			if ((y > classvalue.Value) ||
				(y < classvalue.Key))
			{
				error = y - classvalue.Value;
				for (int i = count - 1; i >= 0; i--)
				{
					if (_net[i].isHideLayer())
					{
						_net[i].CountSigma(mutisigmalist);
						mutisigmalist.Clear();
					}
					else
					{
						_net[i].CountSigma(expectvalue);
						sigmalist = _net[i].GetSigma();
						for (int j = 0; j < sigmalist.Count; j++)
						{
							wlist = _net[i].GetW(j);
							List<KeyValuePair<double, double>> sigmapairlist = new List<KeyValuePair<double, double>>();
							for (int k = 1; k < wlist.Count; k++)
							{
								KeyValuePair<double, double> sigmapair = new KeyValuePair<double, double>(wlist[k], sigmalist[j]);
								sigmapairlist.Add(sigmapair);
							}
							mutisigmalist.Add(sigmapairlist);
						}
					}
				}

				for (int i = 0; i < count; i++)
				{
					_net[i].FixW();
				}
			}

			return error;
		}

		public double InputData(List<double> Xlist, double expectvalue)
		{
			List<double> orginallist = new List<double>(Xlist);
			int count = _net.Count;
			List<double> list = new List<double>(Xlist);
			double error = 0;

			for (int i = 0; i < count; i++)
			{
				_net[i].CountY(list);
				Xlist = _net[i].GetY();
				list.Clear();
				list.Add(-1);

				foreach (var item in Xlist)
				{
					list.Add(item);
				}
			}
			error = BackNet(Xlist[0], expectvalue, orginallist);
			list.Clear();
			foreach (var i in orginallist)
			{
				list.Add(i);
			}
			return error;
		}

		public double RecognizeData(List<double> Xlist, double expectvalue)
		{
			List<double> orginallist = new List<double>(Xlist);
			int count = _net.Count;
			List<double> list = new List<double>(Xlist);
			double error = 0;

			for (int i = 0; i < count; i++)
			{
				_net[i].CountY(list);
				Xlist = _net[i].GetY();
				list.Clear();
				list.Add(-1);

				foreach (var item in Xlist)
				{
					list.Add(item);
				}
			}

			KeyValuePair<double, double> classvalue = new KeyValuePair<double, double>();
			_classify.TryGetValue(expectvalue, out classvalue);

			if ((Xlist[0] > classvalue.Value) ||
				(Xlist[0] < classvalue.Key))
			{
				error = Xlist[0] - classvalue.Value;
			}
			return error;
		}
	}
}
