Console.WriteLine("Введите размер массива строк!");
int sizeArray = Convert.ToInt32(Console.ReadLine());

string[] сreatinArray(int sizeNumber){
string[] strArray = new string[sizeNumber];
Console.WriteLine("Введите массив строк,через \"Enter\".\n");
for (int i = 0; i < strArray.Length; i++){
string str = Console.ReadLine();
strArray[i] = str;
}
return strArray;
}

string[] newCreatinArray(string[] olgArray){
string[] newStrArray = new string[olgArray.Length];
for (int i = 0; i < olgArray.Length; i++)
    if(olgArray[i].Length <= 3){
        newStrArray[i]= olgArray[i];
}
return newStrArray.Where(x => x != null).ToArray();
}

void arrayOutput(string[] arrayStr){
    Console.WriteLine("\nНовый массив строк!\n");
for (int i = 0; i < arrayStr.Length; i++)
{
    Console.WriteLine(arrayStr[i]);
}
}

arrayOutput(newCreatinArray(сreatinArray(sizeArray)));

