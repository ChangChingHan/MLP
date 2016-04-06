using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace home_work
{
	class Neuron
	{
		List<double> _Wlist = null;
		List<double> _Xlist = null;
		double _Y = 0;
		double _sigma = 0;
		double _learningrate = 0;

		public double GetY() { return _Y; }
		public double GetSigma() { return _sigma; }
		public List<double> GetW() { return _Wlist; }


		public Neuron(List<double> Wlist, double learningrate)
		{
			_Wlist = new List<double>(Wlist);
			_learningrate = learningrate;
		}

		public void Clear()
		{
			_Wlist.Clear();
			_Xlist.Clear();
			_Y = 0;
			_sigma = 0;
			_learningrate = 0;
		}

		public double CountY(List<double> Xlist)
		{
			_Xlist = new List<double>(Xlist);
			double v = 0;
			int count = Xlist.Count();
			for (int i = 0; i < count; i++ )
			{
				v += (Xlist[i] * _Wlist[i]); 
			}
			v *= -1;
			_Y = (1 / (1 + Math.Exp(v)));
			return _Y;
		}

		public double CountSigma(double ExpectOutput)
		{
			_sigma = (ExpectOutput - _Y) * _Y * (1 - _Y);
			return _sigma;
		}

		public double CountSigma(Dictionary<double, double> diction)
		{
			double sum = 0;
			foreach(var i in diction)
			{
				sum += i.Key * i.Value;
			}
			_sigma = _Y * (1 - _Y) * sum;
			return _sigma;
		}

		public void FixW()
		{
			int count = _Wlist.Count();
			for (int i = 0; i < count; i++)
			{
				_Wlist[i] = _Wlist[i] + (_learningrate * _sigma * _Xlist[i]);
			}
		}
	}
}
