using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //list of courses each with atleast 2 students; use initializers
            List<Course> courses = new List<Course>()
            {
                new Course() { CourseId = 1, Name = "Biology 101", Students = new List<Student>() {
                    new Student() { StudentId = 1, Name = "James" },
                    new Student() { StudentId = 2, Name = "Jordan" }}                
                },
                new Course() { CourseId = 2, Name = "Chemistry 101", Students = new List<Student>() {
                    new Student() { StudentId = 3, Name = "Lael" },
                    new Student() { StudentId = 4, Name = "Perri" }}
                },
                new Course() { CourseId = 3, Name = "Physics 101", Students = new List<Student>() {
                    new Student() { StudentId = 5, Name = "Shane" },
                    new Student() { StudentId = 6, Name = "Kareem" }}
                }

            };
            //iterate through list; print out info and students in each course
            foreach (var course in courses)
            {
                Label1.Text += String.Format("<br />Course: {0}-{1}", course.CourseId, course.Name);
                foreach (var student in course.Students)
                {
                    Label1.Text += String.Format("<br />&nbsp;&nbsp;Student: {0}-{1}", student.StudentId, student.Name);
                }
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //create dictionary of 3 students; StudentId as key; each in 2 courses; use initializers
            Course course1 = new Course() {CourseId = 1, Name = "Geography"};
            Course course2 = new Course() { CourseId = 2, Name = "History" };
            Course course3 = new Course() { CourseId = 3, Name = "Psychology" };

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                { 1, new Student{ StudentId = 1, Name = "James", Courses = new List<Course> { course1, course2 } } },
                { 2, new Student{ StudentId = 2, Name = "Jordan", Courses = new List<Course> { course2, course3 } } },
                { 3, new Student{ StudentId = 3, Name = "Lael", Courses = new List<Course> { course1, course3 } } }

            };
            //iterate through dictionary; print out info and course each student is in
            foreach (var student in students)
            {
                Label1.Text += String.Format("<br />Student: {0}-{1}", student.Value.StudentId, student.Value.Name);
                foreach (var course in student.Value.Courses)
                {
                    Label1.Text += String.Format("<br />&nbsp;&nbsp;Course: {0}-{1}", course.CourseId, course.Name);
                }

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //track each students grade(0-100) in a course
            Student student = new Student();
            student.StudentId = 6;
            student.Name = "John";
            student.Enroll = new List<Enrollment>()
            {
                new Enrollment { Grade = 98, Course = new Course{CourseId = 1, Name = "Anatomy" } },
                new Enrollment { Grade = 92, Course = new Course{CourseId = 2, Name = "Physiology" } }

            };
            //print out each course per student and their grade in that course
            Label1.Text += String.Format("<br />Student: {0} {1}", student.StudentId, student.Name);
            foreach (var enrollment in student.Enroll)
            {
                Label1.Text += String.Format("<br />&nbsp;&nbsp;Enrolled in: {0}- Grade: {1}", enrollment.Course.Name, enrollment.Grade);
            }
        }
    }
}