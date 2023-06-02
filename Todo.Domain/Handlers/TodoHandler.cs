using Flunt.Notifications;
using Todo.Domain.Commands;
using Todo.Domain.Commands.Contracts;
using Todo.Domain.Entities;
using Todo.Domain.Handlers.Contacts;
using Todo.Domain.Repositories;

namespace Todo.Domain.Handlers
{
    public class TodoHandler :
    Notifiable<Notification>,
     IHandler<CreateTodoCommand>
    {

        private readonly ITodoRepository _repository;

        public TodoHandler(ITodoRepository repository)
        {
            _repository = repository;
        }
        public ICommandResult Handle(CreateTodoCommand command)
        {
            // Fail Fast Validation
            command.Validate();
            if (!command.IsValid)
                return new GenericCommandResult(false,"Ops, parece que sua tarefa está errada", command.Notifications);

            // Gera o TodoItem
            var todo = new TodoItem(command.Title, command.Date, command.User);

            // Salvar um todo no banco
            _repository.Create(todo);

            // Notificar o usuario
            return new GenericCommandResult(true, "Tarefa salva", todo);
        }
    }
}