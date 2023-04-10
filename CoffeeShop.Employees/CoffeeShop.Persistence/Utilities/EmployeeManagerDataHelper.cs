using CoffeeShop.Data.Entities;

namespace CoffeeShop.Persistence.Utilities;

public static class EmployeeManagerDataHelper
{
    static readonly string[] _departmentIds = {
                                "5af7e850-75d0-42cf-aeba-996811fe6012",
                                "5af7e850-75d0-42cf-aeba-996811fe6013",
                                "5af7e850-75d0-42cf-aeba-996811fe6014",
                                "5af7e850-75d0-42cf-aeba-996811fe6015",
                                "5af7e850-75d0-42cf-aeba-996811fe6016" };

    private static Guid GetGuid(string guid = "")
    {
        _ = Guid.TryParse(guid, out var id);

        return string.IsNullOrEmpty(guid) ? Guid.NewGuid() : id;
    }

    public static Department[] GetDepartments() => new Department[]
    {
        new Department { Id = GetGuid(_departmentIds[0]), Name = "Finance" },
        new Department { Id = GetGuid(_departmentIds[1]), Name = "Sales" },
        new Department { Id = GetGuid(_departmentIds[2]), Name = "Marketing" },
        new Department { Id = GetGuid(_departmentIds[3]), Name = "Human Resources" },
        new Department { Id = GetGuid(_departmentIds[4]), Name = "IT" }
    };

    public static Employee[] GetEmployees() => new Employee[]
    {
        new Employee { Id = GetGuid(), FirstName = "Sara", LastName = "Metroid", DepartmentId = GetGuid(_departmentIds[0]) },
        new Employee { Id = GetGuid(), FirstName = "Jasmin", LastName = "Curtis", DepartmentId = GetGuid(_departmentIds[0]), IsDeveloper = true },
        new Employee { Id = GetGuid(), FirstName = "Aaa", LastName = "Metroid", DepartmentId = GetGuid(_departmentIds[0]) },
        new Employee { Id = GetGuid(), FirstName = "Bbb", LastName = "Curtis", DepartmentId = GetGuid(_departmentIds[0]), IsDeveloper = true },
        new Employee { Id = GetGuid(), FirstName = "Anna", LastName = "Rockstar", DepartmentId = GetGuid(_departmentIds[1]) },
        new Employee { Id = GetGuid(), FirstName = "Julien", LastName = "Russell", DepartmentId = GetGuid(_departmentIds[1]), IsDeveloper = true },
        new Employee { Id = GetGuid(), FirstName = "Ccc", LastName = "Rockstar", DepartmentId = GetGuid(_departmentIds[1]) },
        new Employee { Id = GetGuid(), FirstName = "Ddd", LastName = "Russell", DepartmentId = GetGuid(_departmentIds[1]), IsDeveloper = true },
        new Employee { Id = GetGuid(), FirstName = "Ben", LastName = "Rockstar", DepartmentId = GetGuid(_departmentIds[2]) },
        new Employee { Id = GetGuid(), FirstName = "Alex", LastName = "Rider", DepartmentId = GetGuid(_departmentIds[2]), IsDeveloper = true },
        new Employee { Id = GetGuid(), FirstName = "Eee", LastName = "Rockstar", DepartmentId = GetGuid(_departmentIds[2]) },
        new Employee { Id = GetGuid(), FirstName = "Fff", LastName = "Rider", DepartmentId = GetGuid(_departmentIds[2]), IsDeveloper = true },
        new Employee { Id = GetGuid(), FirstName = "Sophie", LastName = "Ramos", DepartmentId = GetGuid(_departmentIds[3]) },
        new Employee { Id = GetGuid(), FirstName = "Yvonne", LastName = "Snider", DepartmentId = GetGuid(_departmentIds[3]), IsDeveloper = true },
        new Employee { Id = GetGuid(), FirstName = "Ggg", LastName = "Ramos", DepartmentId = GetGuid(_departmentIds[3]) },
        new Employee { Id = GetGuid(), FirstName = "Hhh", LastName = "Snider", DepartmentId = GetGuid(_departmentIds[3]), IsDeveloper = true },
        new Employee { Id = GetGuid(), FirstName = "Julia", LastName = "Developer", DepartmentId = GetGuid(_departmentIds[4]) },
        new Employee { Id = GetGuid(), FirstName = "Thomas", LastName = "Huber", DepartmentId = GetGuid(_departmentIds[4]), IsDeveloper = true },
        new Employee { Id = GetGuid(), FirstName = "Iii", LastName = "Developer", DepartmentId = GetGuid(_departmentIds[4]) },
        new Employee { Id = GetGuid(), FirstName = "Jjj", LastName = "Huber", DepartmentId = GetGuid(_departmentIds[4]), IsDeveloper = true },
    };

}