using System;

namespace EP407
{
    class Program
    {
        static void Main(string[] args)
        {
            //　生徒３名の名簿
            Student[] students = new Student[3];
            // 情報登録
            students[0] = new Student();
            students[1] = new Student("b", 2, 13);
            students[2] = new Student("c", 2, 13);
            // 情報開示
            foreach(Student s in students)
            {
                s.ShowInformation();
            }
        }
    }
}
