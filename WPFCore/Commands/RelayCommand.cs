using System;
using System.Windows.Input;

namespace WPFCore.Commands
{
    /// <summary>
    /// A relay command that does not take parameters.
    /// </summary>
    public sealed class RelayCommand : ICommand
    {
        readonly Action methodToExecute;
        readonly Func<bool> canExecuteEvaluator;

        /// <summary>
        /// Is raised when the ability of this command to be executed changes.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Creates a relay command.
        /// </summary>
        /// <param name="methodToExecute">A delegate that is invoked when the command is executed.</param>
        /// <param name="canExecuteEvaluator">A delegate that specifies if the command can be executed.</param>
        public RelayCommand(Action methodToExecute, Func<bool> canExecuteEvaluator)
        {
            this.methodToExecute = methodToExecute;
            this.canExecuteEvaluator = canExecuteEvaluator;
        }

        /// <summary>
        /// Creates a relay command.
        /// </summary>
        /// <param name="methodToExecute">A delegate that is invoked when the command is executed.</param>
        public RelayCommand(Action methodToExecute)
            : this(methodToExecute, () => true)
        { }

        /// <summary>
        /// Evaluates if this command can be executed.
        /// </summary>
        /// <returns>Returns true if this command can be executed, otherwise false.</returns>
        public bool CanExecute()
        {
            return canExecuteEvaluator.Invoke();
        }

        bool ICommand.CanExecute(object parameter)
        {
            return CanExecute();
        }

        /// <summary>
        /// Executes this command.
        /// </summary>
        public void Execute()
        {
            methodToExecute.Invoke();
        }

        void ICommand.Execute(object parameter)
        {
            Execute();
        }
    }
}
