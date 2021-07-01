namespace Oop_basic
{
  public class Person {
    // Propiedades
    public string Name = "Alfonso";
    public string LastName;
    public int Age = 30;

    // Constructor
    public Person(string lastName, string name, int age) {
      this.LastName = lastName;
      this.Name = name;
      this.Age = age;
    }

    // Metodos
    public void Saludo() {
      var nombreCompleto = NombreCompleto();
      System.Console.WriteLine($"  Hola, mi nombre es {nombreCompleto} y tengo {this.Age} años! :3");
    }

    private string NombreCompleto() {
      return $"{this.Name} {this.LastName}";
    }


  }

}