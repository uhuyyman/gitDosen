using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git
{
    internal class Dosen
    {
        public int id;
        public string Nama;
        public int Nik;
        public string gender;
        public string course;

        public Dosen()
        {
            id = 16526666;
            Nama = "Azrul";
            Nik = 12345678;
            gender = "Laki-Laki";
            course = "Pemrograman Berorientasi Objek";
        }
        
        public void attDosen(string nama, int nik)
        {
            Nama = nama;
            Nik = nik;
        }

        public void addCourse(string newCourse)
        {
            course +=", "+ newCourse;
        }

        public void display()
        {
            Console.WriteLine("ID\t: " + id);
            Console.WriteLine("NAMA\t: " + Nama);
            Console.WriteLine("NIK\t: " + Nik);
            Console.WriteLine("GENDER\t: " + gender);
            Console.WriteLine("COURSE\t: " + course);
            Console.WriteLine();
        }
    }
}
