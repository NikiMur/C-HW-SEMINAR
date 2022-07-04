

Console.WriteLine("введите цифру ");

string number = Console.ReadLine();

int i =0, j = number.Length-1;

while ((i<j) && (number[i] == number[j]))
    { 
      i++;
      j--;
    }

if (number[i] == number[j])
  {
    Console.WriteLine(number +" - это палиндром!");
  }
else
  {
Console.WriteLine(number +" - это не палиндром!");
  }

