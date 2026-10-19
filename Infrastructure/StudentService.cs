
// namespace Infrastructure;

// public class StudentService
// {
//     public List<StudentService> students = new List<StudentService>();

//     public List<StudentService> GetStudents()
//     {
//         return students;
//     }
//     public void AddStudent(StudentService student)
//     {
//         students.Add(student);
//     }
//     public void UpdateStudent(StudentService student)
//     {
//         var oldStudent = students.Find(s => s.Id == student.Id);
//         if (oldStudent != null)
//         {
//             oldStudent.Name = student.Name;
//             oldStudent.Age = student.Age;
//         }
//     }
//     public void Delete(int id)
//     {
//         var student = students.Find(s => s.Id == id);

//         if (student != null)
//         {
//             students.Remove(student);
//         }
//     }
// }