using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace home_work
{
	class NetDB
	{
		List<KeyValuePair<List<double>, double>> _alldata	= new List<KeyValuePair<List<double>, double>>();
		List<KeyValuePair<List<double>, double>> _traindata = new List<KeyValuePair<List<double>, double>>();
		List<KeyValuePair<List<double>, double>> _testdata	= new List<KeyValuePair<List<double>, double>>();
		List<double> _classify = new List<double>();

		public List<KeyValuePair<List<double>, double>> GetAllData() { return _alldata; }
		public List<KeyValuePair<List<double>, double>> GetTrainData() { return _traindata; }
		public List<KeyValuePair<List<double>, double>> GetTestData() { return _testdata; }

		public List<double> GetClassify() { return _classify; }
		public void ReadFile(string file)
		{
			if (file.Length == 0)
				return;

			_alldata.Clear();
			_traindata.Clear();
			_testdata.Clear();
			_classify.Clear();

			List<string> listdata = new List<string>();
			string[] lines = File.ReadAllLines(file);
			foreach (string line in lines)
			{
				listdata.Clear();
				string[] sublines = line.Split('	');
				if (sublines.Length <= 1)
				{
					sublines = line.Split(' ');
				}
				foreach (var i in sublines)
				{
					if (i != "")
						listdata.Add(i);
				}
				int count = listdata.Count;
				List<double> list = new List<double>();
				list.Add(-1);
				for (int i = 0; i < count; i++)
				{
					if (i == count - 1)
					{
						KeyValuePair<List<double>, double> pair = new KeyValuePair<List<double>, double>(list, Double.Parse(listdata[i]));
						_alldata.Add(pair);

						if (_classify.Exists(x => x.Equals(Double.Parse(listdata[i]))) == false)
						{
							_classify.Add(Double.Parse(listdata[i]));
						}
					}
					else
					{
						list.Add(Double.Parse(listdata[i]));
					}
				}
			}

			PreapareTrainingData();
		}

		public void PreapareTrainingData()
		{
			_testdata.Clear();
			_traindata.Clear();

			Random random = new Random();
			KeyValuePair<List<double>, double> data = new KeyValuePair<List<double>, double>();
			int swap_positon = 0; 

			for (int i = 1; i < _alldata.Count; i++)
			{
				data = _alldata[i];
				swap_positon = random.Next(0, i);
				_alldata[i] = _alldata[swap_positon];
				_alldata[swap_positon] = data;
			}

			int count = _alldata.Count/3;
			for (int i = 1; i < _alldata.Count; i++)
			{
				if (i < count)
				{
					_testdata.Add(_alldata[i]);
				} 
				else
				{
					_traindata.Add(_alldata[i]);
				}
			}
		}
	}
}
