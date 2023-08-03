using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MainProject4_Sec10
{
    public class Data
    {
        private static Data _instance;
        private List<Student> _students;
        private List<Teacher> _teachers;
        private List<Subject> _subjects;

        private Data()
        {
            _students = new List<Student>();
            _teachers = new List<Teacher>();
            _subjects = new List<Subject>();
        }

        public static Data Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Data();
                }
                return _instance;
            }
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public void AddSubject(Subject subject)
        {
            _subjects.Add(subject);
        }

        public List<Student> GetStudentsByClassAndSection(string classAndSection)
        {
            return _students.Where(s => s.ClassAndSection == classAndSection).ToList();
        }

        public List<Subject> GetSubjectsTaughtByTeacher(string teacherName)
        {
            return _subjects.Where(s => s.Teacher != null && s.Teacher.Name == teacherName).ToList();
        }
    }
}

