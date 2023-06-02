using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandTests
{
    [TestClass]
    public class CreateTodoCommandTests
    {
        private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", DateTime.Now,"");
        private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("1234", DateTime.Now,"1234567");
         
         public CreateTodoCommandTests()
         {
            _invalidCommand.Validate();
            _validCommand.Validate();
         }

        [TestMethod]
        public void DadoUmComandoInvalido()
        {
            Assert.AreEqual(_invalidCommand.IsValid, false);
        }

        [TestMethod]
        public void DadoUmComandoValido()
        {
            Assert.AreEqual(_validCommand.IsValid, true);
        }
        
    }
}