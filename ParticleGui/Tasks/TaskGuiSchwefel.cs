using System;
using System.Collections.Generic;
using System.Text;

using Functions;
using ParticleSwarm;
using System.Diagnostics;

namespace ParticleGui.Tasks
{
	class TaskGuiShwefel: ITaskGui
	{
		double[] _minvalues;
		double[] _maxvalues;

		#region ITaskGui Members

		public Task CreateTask (int dimension)
		{
			_minvalues = new double[dimension];
			_maxvalues = new double[dimension];

			for (int i = 0; i < dimension; i++)
			{
				_minvalues[i] = -500.0;
				_maxvalues[i] = 500.0;
			}

			Task task = new TaskSchwefel (_minvalues, _maxvalues);

			return task;
		}

		public string Name
		{
			get { return "Функция Швефеля"; }
		}


		public double[] MinValues
		{
			get
			{
				Debug.Assert (_minvalues != null);
				return _minvalues;
			}
		}


		public double[] MaxValues
		{
			get
			{
				Debug.Assert (_maxvalues != null);
				return _maxvalues;
			}
		}

		#endregion
	}
}
