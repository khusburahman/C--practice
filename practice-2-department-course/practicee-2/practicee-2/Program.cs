

using practicee_2;

Course course1=new Course();
course1.Code = "CSE-101";
course1.Tittle = "Programing language-1";
course1.Credit = 3.0;

Course course2 = new Course();
course2.Code = "CSE-101";
course2.Tittle = "Programing language-1";
course2.Credit = 3.0;

Course course3 = new Course();
course3.Code = "CSE-101";
course3.Tittle = "Programing language-1";
course1.Credit = 3.0;


Course course4 = new Course();
course4.Code = "CSE-101";
course4.Tittle = "Programing language-1";
course4.Credit = 3.0;

Course course5 = new Course();
course5.Code = "CSE-101";
course5.Tittle = "Programing language-1";
course5.Credit = 3.0;


Department department1 = new Department();
department1.Code = "CSE";
department1.Name = "Computer science & ENgineering";
//department1.courses=new List<Course>();
department1.courses.Add(course1);
department1.courses.Add(course2);
department1.courses.Add(course3);
department1.courses.Add(course4);
department1.courses.Add(course5);

//foreach(Course course in department1.courses)
//{
//    Console.WriteLine(course.GetInfo());
//}

Console.WriteLine(Department.GetInfo());
Console.ReadKey(true);