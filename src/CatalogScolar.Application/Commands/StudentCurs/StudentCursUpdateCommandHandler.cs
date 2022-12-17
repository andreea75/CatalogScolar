
using CatalogScolar.Domain.Entities;
using CatalogScolar.Domain.Repositories.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CatalogScolar.Application.Commands;

public class StudentCursUpdateCommandHandler : IRequestHandler<StudentCursUpdateCommand, StudentCurs>
{
    private IStudentCursRepository _studentCursRepository;

    public StudentCursUpdateCommandHandler(
        IStudentCursRepository studentCursRepository)
    {
        _studentCursRepository = studentCursRepository;
    }

    public async Task<StudentCurs> Handle(StudentCursUpdateCommand command, CancellationToken cancellationToken)
    {
        var entity = await _studentCursRepository.CreateOrUpdateAsync(command.StudentCurs);
        await _studentCursRepository.SaveChangesAsync();
        return entity;
    }
}
