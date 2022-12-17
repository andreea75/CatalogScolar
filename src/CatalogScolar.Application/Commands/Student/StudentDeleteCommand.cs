using CatalogScolar.Domain.Entities;
using MediatR;

namespace CatalogScolar.Application.Commands;

public class StudentDeleteCommand : IRequest<Unit>
{
    public long Id { get; set; }
}
