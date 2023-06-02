using Flunt.Notifications;
using Flunt.Validations;

namespace Todo.Domain.Commands.Contracts
{
    public class UpdateTodoCommand : Notifiable<Notification>, ICommand
    {
        public UpdateTodoCommand()
        {
        }

        public UpdateTodoCommand(Guid id, string title, string user)
        {
            Id = id;
            Title = title;
            User = user;
        }

        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string User {get; set; } = null!;
        public void Validate()
        {
             AddNotifications(
                new Contract<Notification>()
                .Requires()
                .IsGreaterThan(Title, 3, "Title", "Por favor, descreva melhor esta tarefa!")
                .IsGreaterThan(User, 6, "User", "Usuário inválido!")
            );
        }
    }
}