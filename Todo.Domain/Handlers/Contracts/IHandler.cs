using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Handlers.Contacts;
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }