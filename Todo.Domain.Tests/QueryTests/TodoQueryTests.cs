using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.QueryTests;

[TestClass]
public class TodoQueryTests
{
    private List<TodoItem> _items;

    public TodoQueryTests()
    {
        _items = new List<TodoItem>();
        _items.Add(new TodoItem("Tarefa 1", DateTime.Now, "UsuarioTeste"));
        _items.Add(new TodoItem("Tarefa 2", DateTime.Now, "ArthurGalanti"));
        _items.Add(new TodoItem("Tarefa 3", DateTime.Now, "UsuarioTeste"));
        _items.Add(new TodoItem("Tarefa 4", DateTime.Now, "Arthur"));
        _items.Add(new TodoItem("Tarefa 5", DateTime.Now, "ArthurGalanti"));
    }
    
    [TestMethod]
    public void DeveRetornarTarefasApenasDoUsuarioArthurGalanti()
    {
        var result = _items.AsQueryable().Where(TodoQueries.GetAll("ArthurGalanti"));
        Assert.AreEqual(2, result.Count());
    }
}