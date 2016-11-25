using System.Windows.Input;

namespace WPFCore.Commands
{
    /// <summary>
    /// Defines a command with one parameter.
    /// </summary>
    /// <typeparam name="T">The type of the commands parameter.</typeparam>
    public interface ICommand<in T> : ICommand
    {
        /// <summary>
        /// Evaluates if this command can be executed.
        /// </summary>
        /// <param name="parameter">The parameter passed to the command.</param>
        /// <returns>Returns true if this command can be executed, otherwise false.</returns>
        bool CanExecute(T parameter);

        /// <summary>
        /// Executes this command.
        /// </summary>
        /// <param name="parameter">The parameter passed to the command.</param>
        void Execute(T parameter);
    }
}
