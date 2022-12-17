using CatalogScolar.Domain.Entities;
using MediatR;

namespace CatalogScolar.Application.Commands;

public class AccountActivateCommand : IRequest<User>
{
    public string Key { get; set; }
}
