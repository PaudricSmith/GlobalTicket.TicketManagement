using GlobalTicket.TicketManagement.Application.Responses;

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