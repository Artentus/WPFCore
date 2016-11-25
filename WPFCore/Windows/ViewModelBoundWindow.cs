using System.Windows;

namespace WPFCore.Windows
{
    /// <summary>
    /// The base class for all WPF windows that have a view model set as their data context.
    /// </summary>
    public abstract class ViewModelBoundWindow : WindowView
    {
        private void DataContextChangedHandler(object sender, DependencyPropertyChangedEventArgs e)
        {
            ViewModel?.SetViewInternal(null);

            ViewModelBase newViewModel = e.NewValue as ViewModelBase;
            newViewModel?.SetViewInternal(this);
            ViewModel = newViewModel;
        }

        protected ViewModelBoundWindow()
        {
            DataContextChanged += DataContextChangedHandler;
        }
    }
}
