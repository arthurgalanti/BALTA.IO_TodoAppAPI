using Todo.Domain.Entities;

namespace Todo.Domain.Tests.EntityTests;

[TestClass]
public class TodoItemTests
{
    private readonly TodoItem _validTodo = new TodoItem("Titulo", DateTime.Now, "ArthurGalanti");
    
    [TestMethod]
    public void DadoUmNovoTodoOMesmoNaoPodeSerConcluido()
    {
        Assert.AreEqual(_validTodo.Done, false);
    }
}