using System;

namespace WPFCore
{
    /// <summary>
    /// The base class of all views.
    /// </summary>
    public abstract class ViewBase : IView
    {
        IViewModel viewModel;

        /// <summary>
        /// Is raised when the view model this view is associated with is changed.
        /// </summary>
        public event EventHandler ViewModelChanged;

        /// <summary>
        /// The view model that is associated with this view.
        /// </summary>
        public IViewModel ViewModel
        {
            get { return viewModel; }
            protected set
            {
                viewModel = value;
                OnViewModelChanged(EventArgs.Empty);
            }
        }

        /// <summary>
        /// Raises the ViewModelChanged event.
        /// </summary>
        protected virtual void OnViewModelChanged(EventArgs e)
        {
            ViewModelChanged?.Invoke(this, e);
        }
    }
}
