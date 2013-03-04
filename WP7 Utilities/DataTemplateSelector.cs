using System.Windows;
using System.Windows.Controls;

namespace WP7_Utilities
{
	/// <summary>
	/// Helper class inspired from WPF's DataTemplateSelector:
	/// Use a class derived from this one and override SelectTemplate
	/// to implement fine tuning of what DataTemplate a specific item
	/// should have.
	/// </summary>
	public abstract class DataTemplateSelector : ContentControl
	{
		/// <summary>
		/// When the content of the ContentControl is changed
		/// (typically with a binding on Content property), reselect the
		/// appropriate template and set it as the ContentTemplate
		/// </summary>
		/// <param name="oldContent">The old content of the ContentControl</param>
		/// <param name="newContent">The new content of the ContentControl</param>
		protected override void OnContentChanged(object oldContent, object newContent)
		{
			base.OnContentChanged(oldContent, newContent);

			ContentTemplate = SelectTemplate(newContent, this);
		}

		/// <summary>
		/// Select the most appropriate template for item, when added to container.
		/// </summary>
		/// <param name="item">The item which template to select</param>
		/// <param name="container">The container in which the template will be placed</param>
		/// <returns>The most appropriate DataTemplate or null.</returns>
		public virtual DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			return null;
		}
	}
}
