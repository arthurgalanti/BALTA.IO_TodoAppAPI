using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class CreateTodoCommand : Notifiable<Notification>, ICommand
    { 
        public CreateTodoCommand() { }
        public CreateTodoCommand(string title, DateTime date, string user)
        {
            Title = title;
            Date = date;
            User = user;
        }

        public string Title { get; set; } = null!;
        public DateTime Date { get; set; }
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