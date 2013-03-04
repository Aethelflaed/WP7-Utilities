using System.ComponentModel;

namespace WP7_Utilities
{
	/// <summary>
	/// A base class providing basic implementation for view models.
	/// </summary>
	public abstract class ViewModelBase : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// Set the value of the given property and generates the PropertyChanged event.
		/// </summary>
		/// <typeparam name="T">The type of the property</typeparam>
		/// <param name="property">The reference to the property</param>
		/// <param name="value">The value to set</param>
		/// <param name="propertyName">The name of the property</param>
		protected void SetValue<T>(ref T property, T value, string propertyName)
		{
			property = value;
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
