using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Services
{
	public class StudentService:IStudentService
	{
		private readonly IStudentRepository _studentRepository;

		public StudentService(IStudentRepository studentRepository)
		{
			_studentRepository = studentRepository;
		}
		public void Create(Student student)
		{
			_studentRepository.Add(student);
		}
		public void Update(Student student)
		{
			_studentRepository.Update(student);
		}
		public Student GetById(Guid id)
		{
			return new Student();
		}
		public List<Student> GetAll()
		{
			return new List<Student>();
		}
		public void Delete(Guid id)
		{
			
		}
	}
}
