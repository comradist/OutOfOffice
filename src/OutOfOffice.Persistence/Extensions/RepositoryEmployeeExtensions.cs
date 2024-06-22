
using System.Reflection;
using System.Text;
using System.Linq.Dynamic.Core;
using OutOfOffice.Domain.Models.Entities;
using OutOfOffice.Persistence.Extensions.Utility;

namespace OutOfOffice.Persistence.Extensions;

public static class RepositoryEmployeeExtensions
{
    public static IQueryable<Employee> FilterEmployees(this IQueryable<Employee> employees, uint min, uint max)
    {
        // var returnEmloyees = employees.Where(x => x.Age >= min && x.Age <= max);
        // if (!returnEmloyees.Any())
        // {
        //     throw new CollectionBySearchParamBadRequest($"Not found any employees between {min} and {max} parameters");
        // }
        // return returnEmloyees;
        throw new NotImplementedException();
    }

    public static IQueryable<Employee> Search(this IQueryable<Employee> employees, string searchVar)
    {
        if (string.IsNullOrWhiteSpace(searchVar))
        {
            return employees;
        }

        var lowerCaseTerm = searchVar.Trim().ToLower();

        var returnEmployees = employees.Where(x => x.FullName.ToLower().Contains(lowerCaseTerm));
        if (!returnEmployees.Any())
        {
            //throw new CollectionBySearchParamBadRequest($"Not found any employees with searched term {searchVar}");
            throw new NotImplementedException();
        }
        return returnEmployees;
    }

    public static IQueryable<Employee> Sort(this IQueryable<Employee> employees, string orderByQueryString)
    {
        if (string.IsNullOrWhiteSpace(orderByQueryString))
        {
            return employees.OrderBy(x => x.FullName);
        }

        var orderQuery = OrderQueryBuilder.CreateOrderQuery<Employee>(orderByQueryString);

        if (string.IsNullOrWhiteSpace(orderQuery))
        {
            return employees.OrderBy(x => x.FullName);
        }

        //employees.OrderBy(item => item.Name).ThenByDescending(item => item.Age);
        return employees.OrderBy(orderQuery);
    }

}