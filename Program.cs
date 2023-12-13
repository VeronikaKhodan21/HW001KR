string[] A = new string[] {"Hello", "2", "world", ":-."};
void Chec(string[] array){
    for (int i = 0; i < array.Length; i++)
    {
     char [] CharArray =A[i].Select(c => c).ToArray();   
     if(3>= CharArray.Length){
        Console.Write($"{array[i]} ");
     }
    }
}
Chec(A);




