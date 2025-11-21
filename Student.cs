using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Studentcpp
{
    internal class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public Student(int id, string name, int age)
            {
                Id = id;
                Name = name;
                Age = age;
            }
        }
    }

