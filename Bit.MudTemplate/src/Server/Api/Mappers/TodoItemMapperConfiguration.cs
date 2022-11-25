using MudTemplate.Server.Api.Models.TodoItem;
using MudTemplate.Shared.Dtos.TodoItem;

namespace MudTemplate.Server.Api.Mappers;

public class TodoItemMapperConfiguration : Profile
{
    public TodoItemMapperConfiguration()
    {
        CreateMap<TodoItem, TodoItemDto>().ReverseMap();
    }
}
