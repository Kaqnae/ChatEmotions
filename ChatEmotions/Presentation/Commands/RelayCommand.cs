using System.Windows.Input;

namespace ChatEmotions.Presentation.Commands;

public class RelayCommand : ICommand
{
    private Action _execute;
    private Func<bool> _canExecute;

    public RelayCommand(Action execute, Func<bool> canExecute)
    {
        this._execute = execute;
        this._canExecute = canExecute;
    }

    public event EventHandler? CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }

    public bool CanExecute(object? parameter)
    {
        return _canExecute();
    }

    public void Execute(object? parameter)
    {
        _execute();
    }
}