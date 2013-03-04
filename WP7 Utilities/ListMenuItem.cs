using System;
using System.Windows.Input;
using Microsoft.Phone.Controls;
using System.Windows;

namespace WP7_Utilities
{
	/// <summary>
	/// Interface representing an element which will be displayed
	/// typically in a list
	/// </summary>
	public interface IListMenuItem
	{
		string Title { get; }
		ICommand Command { get; }
	}

	/// <summary>
	/// Default IListMenuItem implemetation
	/// </summary>
	public class ListMenuItem : IListMenuItem
	{
		private string _title;

		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		private ICommand _command;

		public ICommand Command
		{
			get { return _command; }
			set { _command = value; }
		}
	}

	/// <summary>
	/// An IListMenuItem implementation which permits to easily navigate to other pages.
	/// </summary>
	/// <typeparam name="T">The type of the destination page</typeparam>
	public class NavigationListMenuItem<T> : IListMenuItem where T : PhoneApplicationPage
	{
		private string _title;

		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		private ICommand _command = new DelegateCommand<IListMenuItem>(
			(e) =>
			{
				(Application.Current as IApp).RootFrame.Navigate(new Uri(UriHelper.For<T>(), UriKind.RelativeOrAbsolute));
			});

		public ICommand Command
		{
			get { return _command; }
		}
	}
}
