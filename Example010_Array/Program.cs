// Найти элемент массива равный find и плюс генератор случ чисел в ме

int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };

int n = array.Length; //возвращает длину или кол-во элю массива
int find = 18;

int index = 0;

while ( index < n )

{

  if(array[index] == find)
  {
    Console.WriteLine(index);
    break; //будет искать до первого элемента
  }
  index++;
}