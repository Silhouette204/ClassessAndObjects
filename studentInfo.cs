public class studentInfo{

  public void info(String name, int age, int year, String place){
 
   Console.WriteLine("Your name: " + name);
   Console.WriteLine("Your age: " + age);
   
   var yr = (year == 1) ? year + "st" : (year == 2) ? year + "nd" : (year == 3) ? year + "rd" : "th";
   Console.WriteLine("Your year: " + yr);

   Console.WriteLine("Living in: " + place);
  }

}