using System;
using System.Text;

namespace Library
{
    public class Paciente
    {
    //Se define como atributo
        public string name;       
        private string phoneNumber {get; set;}

        //Se crea el método constructor
        public Paciente (string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber; 
        }
        //metodos de la clase
        public static string GetNamePaciente (string name)
        {
            return name;
        }
        public static string GetPhoneNumber (string phoneNumber)
        {
            return phoneNumber;
        }
    }
}