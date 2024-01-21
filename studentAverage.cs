using classesAndObjectChallenge;

public class studentAverage{

  Program studentGrades = new Program();// blanko lang yung given variable kasi wala naman tayong ipriprint, kukunin lang naten yung mga grade kay user :).
  
  public double gettingSum(int eng, int sci, int math, int tle, int fil, int his, int rel, int pe){
  
   double result;

   result = eng + sci + math + tle + fil + his + rel + pe;

   return + result; 
  }

  public double gettingAverage(int eng, int sci, int math, int tle, int fil, int his, int rel, int pe){
  double average;

  average = gettingSum(eng, sci, math, tle, fil, his, rel, pe) / 8;

  return average;

  }

  public void finalResult(int eng, int sci, int math, int tle, int fil, int his, int rel, int pe){
   
    String result;

if (gettingAverage(eng, sci, math, tle, fil, his, rel, pe) >= 75) {
  Console.WriteLine("You Passed!");
} else {
   Console.WriteLine("You Failed!");
}
    
  }

}