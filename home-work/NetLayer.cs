using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace home_work
{
	class NetLayer
	{
		List<Neuron> _neuronlist = new List<Neuron>();
		bool _hide = false;
		int _neuroncount = 0;
		

		public NetLayer(int neuroncount, bool hide, int weightcount, double learningrate)
		{
			List<double> Wlist = new List<double>();
			_hide = hide;
			_neuroncount = neuroncount;

			Random rnd = new Random();
			for (int i = 0; i < weightcount; i++)
			{
				Wlist.Add(rnd.NextDouble());
			}

			int count = _neuroncount;
			for (int i = 0; i < count; i++)
			{
				rnd = new Random();
				Thread.Sleep(100);
				Wlist[0] = rnd.NextDouble();
				Neuron n = new Neuron(Wlist, learningrate);
				_neuronlist.Add(n);
			}

		}

		public void Clear()
		{
			_hide = false;
			_neuroncount = 0;
			foreach (var i in _neuronlist)
			{
				i.Clear();
			}
			_neuronlist.Clear();
		}
		public bool isHideLayer() { return _hide; }

		public List<double> GetW(int neuronid)
		{
			return _neuronlist[neuronid].GetW();
		}

		public List<double> GetY()
		{
			List<double> list = new List<double>();
			int count = _neuroncount;
			for (int i = 0; i < count; i++)
			{
				list.Add(_neuronlist[i].GetY());
			}
			return list;
		}

		public List<double> GetSigma()
		{
			List<double> list = new List<double>();
			int count = _neuroncount;
			for (int i = 0; i < count; i++)
			{
				list.Add(_neuronlist[i].GetSigma());
			}
			return list;
		}

		public void CountY(List<double> Xlist)
		{
			int count = _neuroncount;
			for (int i = 0; i < count; i++)
			{
				_neuronlist[i].CountY(Xlist);
			}
		}

		public void CountSigma(double ExpectOutput)
		{
			int count = _neuroncount;
			for (int i = 0; i < count; i++)
			{
				_neuronlist[i].CountSigma(ExpectOutput);
			}
		}

		public void CountSigma(List<List<KeyValuePair<double, double>>> multisigmalist)
		{
			Dictionary<double, double> diction = new Dictionary<double, double>();
			int count = _neuroncount;
			for (int i = 0; i < count; i++)
			{
				diction.Clear();
				foreach (var item in multisigmalist)
				{
					diction[item[i].Key] = item[i].Value;
				}
				_neuronlist[i].CountSigma(diction);
			}
		}

		public void FixW()
		{
			int count = _neuroncount;
			for (int i = 0; i < count; i++)
			{
				_neuronlist[i].FixW();
			}
		}
	}
}
