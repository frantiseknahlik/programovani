Console.Clear();
Student student = new Student(16, "Franta");
Console.WriteLine("Student:" + student.name);
student.Greet();
ChangeStudent(student);
student.Greet();

void ChangeStudent(Student s)
{
    s.name = "Nothing";
}