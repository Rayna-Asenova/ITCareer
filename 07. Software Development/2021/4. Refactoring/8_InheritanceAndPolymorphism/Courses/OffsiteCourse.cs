﻿using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism.Courses
{
    public class OffsiteCourse : CourseData
    {
        public string Town { get; set; }

        public OffsiteCourse(string name) 
            : base(name)
        {
            // nope
        }

        public OffsiteCourse(string courseName, string teacherName) 
            : base(courseName, teacherName)
        {
            // nope
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students) 
            : base(courseName, teacherName, students)
        {
            // nope
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }
            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }
            result.Append(" }");
            return result.ToString();
        }
    }
}
