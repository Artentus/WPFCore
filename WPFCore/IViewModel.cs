using System;
using System.ComponentModel;

namespace WPFCore
{
    /// <summary>
    /// A view model component in the MVVM pattern.
    /// </summary>
    public interface IViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Is raised when the view this view model is associated with is changed.
        /// </summary>
        event EventHandler ViewChanged;

        /// <summary>
        /// The view that is associated with this view model.
        /// </summary>
        IView View { get; }
    }
}
