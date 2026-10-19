
// namespace Infrastructure;

// public class TeacherService
// {
// public List<TeacherService> teachers = new List<TeacherService>();
// public List<TeacherService> GetTeacher()
// {
//     return teachers;
// }
// public void AddTeacher(TeacherService teacher)
// {
//     teachers.Add(teacher);
// }
// public void UpdateTeacher(TeacherService teacher)
// {
//  var oldTeacher = teachers.Find(t => t.Id == teacher.Id);
//  if (oldTeacher != null)
//  {
//      oldTeacher.Name = teacher.Name;
//      oldTeacher.Age = teacher.Age;
//  }
//  }
//  public void Delete(int id)
//  {
// var teacher = teachers.Find(t => t.Id == id);
// if (teacher != null)
// {
//  teachers.Remove(teacher);
// }
//     }
// }