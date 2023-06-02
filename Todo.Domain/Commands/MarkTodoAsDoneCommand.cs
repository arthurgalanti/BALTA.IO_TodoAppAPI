using Flunt.Notifications;

namespace Todo.Domain.Commands.Contracts
{
    public class MarkTodoAsDoneCommand : Notifiable<Notification>, ICommand
    {
        public MarkTodoAsDoneCommand()
        {
            
        }
        public MarkTodoAsDoneCommand(Guid id, string user)
        {
            Id = id;
            User = user;
        }

        public Guid Id { get; set; }
        public string User { get; set; } = null!;
        public void Validate()
        {
            AddNotifications(
                new Flunt.Validations.Contract<Notification>()
                .Requires()
                .IsGreaterThan(User, 6, "User", "Usuário inválido!")
            );
        }
    }
}