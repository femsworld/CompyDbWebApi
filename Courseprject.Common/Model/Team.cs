namespace Courseprject.Common.Model;

public class Team : BaseEntity
{
    string Name { get; set; } = default!;
    public List<Employee> Employees { get; set; } = default!;

}