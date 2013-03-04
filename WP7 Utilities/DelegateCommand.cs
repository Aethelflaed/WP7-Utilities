using System;
using System.Windows.Input;

namespace WP7_Utilities
{
	/// <summary>
	/// A generic implementation of the ICommand interface providing
	/// a constructor taking lambdas as action and predicate.
	/// </summary>
	/// <typeparam name="T">The type of the command parameter</typeparam>
	public class DelegateCommand<T> : ICommand
	{
		private readonly Action<T> action;
		private readonly Func<T, bool> predicate;

		public event EventHandler CanExecuteChanged;

		/// <summary>
		/// Calls the underlying predicate using the given parameter
		/// and returns true by default if no predicate is defined.
		/// </summary>
		/// <param name="parameter"></param>
		/// <returns>True if the command can be executed, false otherwise</returns>
		public bool CanExecute(object parameter)
		{
			if (predicate != null)
			{
				return predicate((T)parameter);
			}
			return true;
		}

		public void Execute(object parameter)
		{
			if (action != null)
			{
				action((T)parameter);
			}
		}

		public DelegateCommand(Action<T> action, Func<T, bool> predicate = null)
		{
			this.action = action;
			this.predicate = predicate;
		}

		public void RaiseCanExecuteChanged()
		{
			if (CanExecuteChanged != null)
			{
				CanExecuteChanged(this, EventArgs.Empty);
			}
		}
	}
}
