using System;
using System.Windows;

namespace WPFCore.Windows
{
    /// <summary>
    /// The base class for all views that are WPF windows.
    /// </summary>
    public abstract class WindowView : Window, IView
    {
        ViewModelBase viewModel;

        /// <summary>
        /// Is raised when the view model this view is associated with is changed.
        /// </summary>
        public event EventHandler ViewModelChanged;

        /// <summary>
        /// The view model that is associated with this view.
        /// </summary>
        public ViewModelBase ViewModel
        {
            get { return viewModel; }
            protected set
            {
                viewModel = value;
                OnViewModelChanged(EventArgs.Empty);
            }
        }

        IViewModel IView.ViewModel => ViewModel;

        /// <summary>
        /// Raises the ViewModelChanged event.
        /// </summary>
        protected virtual void OnViewModelChanged(EventArgs e)
        {
            ViewModelChanged?.Invoke(this, e);
        }
    }
}
