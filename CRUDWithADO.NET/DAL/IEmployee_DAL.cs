using CRUDWithADONET.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDWithADONET.DAL
{
    public interface IEmployee_DAL
    {
        public List<Employee> GetAll();
        public bool Insert(Employee model);
        public Employee GetById(int id);
        public bool Update(Employee model);
        public bool Delete(int Id);
    }
}
