/*Написать программу, которая из имеющегося массива строк формирует массив строк, 
длина которого меньше либо равна три символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами*/

string inputString(){
    string str = Console.ReadLine() ?? "неизвестное сообщение"; // проверка на NULL
    return str;
}

void printArray(string[] arr){
    string res = "[";
    foreach (string value in arr ){
        res = res + value + ",";
    }
    res = res.TrimEnd(new Char[] {',', ' '}) + "]";

    Console.WriteLine(res);
}

void fillArray(ref string[] arr, int n){

    for (int i = 0; i < n; i++)
    {
        arr[i] = inputString();
    }
}

string[] makeResultArray(string[] arr){

    int count = 0;
    foreach (string value in arr ){
        if (value.Length <= 3){
            count++;
        }
    }
    int i = 0;
    if (count > 0){
        string[] resArray = new string[count];
        foreach (string value in arr ){
            if (value.Length <= 3){
                resArray[i] = value;
                i++;
            }
        }
        return resArray;
    
    }else{
        string[] resArray = new string[0];
        return resArray;
    }
    

}

Console.WriteLine("Нужен массив из 5 строк");
int i = 5;
string[] arr = new string[i];

Console.WriteLine("Введите строки, нажимая Enter");
 
fillArray(ref arr, i);

printArray(arr);

printArray(makeResultArray(arr));
    



//Console.WriteLine("Сумма произведений пар чисел: " + sum);

