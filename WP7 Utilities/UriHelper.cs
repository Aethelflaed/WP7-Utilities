using System;
using Microsoft.Phone.Controls;

namespace WP7_Utilities
{
	/// <summary>
	/// Provides with helpers to generate Uri
	/// </summary>
	public static class UriHelper
	{
		/// <summary>
		/// Generates the Uri corresponding to the given page
		/// </summary>
		/// <typeparam name="T">The type of the page</typeparam>
		/// <returns>The uri of the page, as a string</returns>
		public static string For<T>() where T : PhoneApplicationPage
		{
			string[] parts = typeof(T).FullName.Split('.');
			return "/" + String.Join("/", parts, 1, parts.Length - 1) + ".xaml";
		}
	}
}
