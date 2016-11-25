using System;
using System.ComponentModel;

namespace WPFCore
{
    /// <summary>
    /// The base class of all view models.
    /// </summary>
    public abstract class ViewModelBase : NotifyPropertyChangedBase, IViewModel
    {
        IView view;

        /// <summary>
        /// Is raised when the view this view model is associated with is changed.
        /// </summary>
        public event EventHandler ViewChanged;

        /// <summary>
        /// The view that is associated with this view model.
        /// </summary>
        public IView View
        {
            get { return view; }
            protected set
            {
                view = value;

                OnViewChanged(EventArgs.Empty);
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(View)));
            }
        }

        internal void SetViewInternal(IView value)
        {
            View = value;
        }

        /// <summary>
        /// Raises the ViewChanged event.
        /// </summary>
        protected virtual void OnViewChanged(EventArgs e)
        {
            ViewChanged?.Invoke(this, e);
        }
    }
}
