using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
    //Se define como atributo
        public string name;       
        private string appoinmentPlace {get; set;}

    //Se crea el método constructor
        public Doctor (string name, string specialty)
        {
            this.name = name;
            this.appoinmentPlace = appoinmentPlace; 
        }
        //metodos de la clase
        public static string GetNameDoctor (string name)
        {
            return name;
        }
        public static string GetAppoinmentPlace (string appoinmentPlace)
        {
            return appoinmentPlace;
        }
    }
}
