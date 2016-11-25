using System;

namespace WPFCore
{
    /// <summary>
    /// A view component in the MVVM pattern.
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// Is raised when the view model this view is associated with is changed.
        /// </summary>
        event EventHandler ViewModelChanged;

        /// <summary>
        /// The view model that is associated with this view.
        /// </summary>
        IViewModel ViewModel { get; }
    }
}
