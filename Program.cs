using System.ComponentModel.Design;
//task 3.1
var currentTime = DateTime.Now.Hour;
if (currentTime >= 11 && currentTime <= 14)
{
    Console.WriteLine("Time for lunch");

}
else {
    Console.WriteLine("Lunch is over");
}


//task 3.2

for (int i = 0; i <= 10; i++) {
    Console.WriteLine(i);
}

//task 4.1


string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday","Friday" };

for (int e = 0; e < daysOfTheWeek.Length; e++) {
    Console.WriteLine($"{daysOfTheWeek[e]}");
}

//task 4.2

int[] numbers = { 1,2,3,4,5,6};
int totalSum = 0;

for (int f = 0; f < numbers.Length; f++) { 

    totalSum += numbers[f];
}

Console.WriteLine(totalSum);
