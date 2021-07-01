namespace Oop_basic
{
  public class Estudiante : Person {
    // Propiedades
    public bool Approved;
    // Constructor
    public Estudiante(string lastName, string name, int age, bool approved) : base(lastName, name, age) {
      this.LastName = lastName;
      this.Name = name;
      this.Age = age;
      this.Approved = approved;
    }

    // Metodos 
    


  }

}