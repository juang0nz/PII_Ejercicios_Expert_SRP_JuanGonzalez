using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string appointmentResult = AppointmentService.CreateAppointment(Paciente.GetNamePaciente("Steven Jhonson"),"986782342",Paciente.GetPhoneNumber( "5555-555-555"), DateTime.Now, Doctor.GetAppoinmentPlace("Wall Street"),Doctor.GetNameDoctor( "Armand"));
            Console.WriteLine(appointmentResult);

            //string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            //Console.WriteLine(appointmentResult2);
        }
    }
}

/*

Criticas al codigo inicial:

En el codigo inicial faltaba definir los atributos así como tambien los getters y setters.

En primer lugar, dado que se le pueden agregar datos al doctor, como su especialidad, esto ya es una razón de cambio
y no se estaría cumpliendo el principio SRP. Por eso se debería crear una clase Doctor que sería donde se
guardara la informacion del doctor dentro de ellas puse como el lugar de cita, ya que depende del doctor a mi entender. 
Lo mismo ocurre con los datos del paciente.

Por otro lado, el lugar de la consulta es una razón de cambio también, pues si el doctor se muda por ejemplo, 
no estaría bien tener que cambiar toda la clase doctor por lo que se considera que debería ser una clase aparte.

La clase AppointmentService se le está dando mas de una responsabilidades, lo que tampoco cumple con SRP. Esta debe contener todos 
los atributos
del evento de crear la consulta. Observamos que en el código solo se usa DateTime.now pero creo que también debe tener la fecha de 
la consulta del paciente, la cual puede ser una razon de cambio.

*/