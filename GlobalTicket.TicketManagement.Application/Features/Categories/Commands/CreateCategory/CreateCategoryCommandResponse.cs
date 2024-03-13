using GlobalTicket.TicketManagement.Application.Responses;
using GloboTicket.TicketManagement.Application.Features.Categories.Commands.CreateCateogry;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandResponse : BaseResponse
    {
        public CreateCategoryCommandResponse() : base() 
        {
        }

        public CreateCategoryDto Category { get; set; } = default!;
    }
}