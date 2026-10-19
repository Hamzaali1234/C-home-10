
// namespace Infrastructure;
// public class CourseService
// {
// public List<CourseService> courses = new List<CourseService>();
// public List<CourseService> GetCourses()
// {
//     return courses;
// }
// public void AddCourses(CourseService course)
// {
//     courses.Add(course);
// }
// public void UpdateCourse(CourseService course)
// {
//  var oldCourse = courses.Find(c => c.Id == course.Id);
//  if (oldCourse != null)
//  {
//      oldCourse.Name = course.Name;
//  }
// }
// public void Delete(int id)
// {
//  var course = courses.Find(c => c.Id == id);
//  if (course != null)
//  {
//  courses.Remove(course);
//  }
//  }
// }