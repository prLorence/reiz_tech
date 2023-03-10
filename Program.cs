// See https://aka.ms/new-console-template for more information

using reiz_tech;

class Program {
  static void Main() {
    int hours = int.Parse(Console.ReadLine());
    float minutes = float.Parse(Console.ReadLine());
    var Clock = new Clock(hours, minutes);
    Console.WriteLine(Clock.GetDegrees());
  }
}
