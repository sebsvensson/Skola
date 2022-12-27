using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp25_lab2
{
    interface IKurs
    {
        string Namn { get; set; }
        string Kurskod { get; set; }
        DateTime Startdatum { get; set; }
        DateTime Slutdatum { get; set; }
        bool LärareRegistrerad(Lärare lärare);
        void RegistreraLärare(Lärare lärare);
        void AvregistreraLärare(Lärare lärare);
        void RegistreraStudent(Student student);
        bool StudentRegistrerad(Student student);
        void AvregistreraStudent(Student student);
        void RegistreraLaborationsuppgift(string namn, double poäng, DateTime startdatum, DateTime slutdatum);
        void AvregistreraLaborationsuppgift(Laborationsuppgift laborationsuppgift);
        void Radera();

    }
}
