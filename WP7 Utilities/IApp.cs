using Microsoft.Phone.Controls;

namespace WP7_Utilities
{
	/// <summary>
	/// An interface the Application implementation should implements
	/// in order to provide generic access to the app frame
	/// </summary>
	public interface IApp
	{
		/// <summary>
		/// Access the application root frame
		/// </summary>
		PhoneApplicationFrame RootFrame { get; }
	}
}
