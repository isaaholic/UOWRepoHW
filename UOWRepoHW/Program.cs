using UOWRepoHW.Models;
using UOWRepoHW.Repositories;

UnitOfWork uf = new UnitOfWork();

var student = new Student()
{
    Id = 203,
    FirstName = "Isa",
    LastName = "Mammadli",
    Id_Group = 7,
    Term = 2
};

uf.StudentRepository.Add(student);

Console.WriteLine(uf.StudentRepository.GetById(203).FirstName);

var exStudent = uf.StudentRepository.GetById(203);

if (exStudent != null)
    uf.StudentRepository.Remove(exStudent);

uf.Save();