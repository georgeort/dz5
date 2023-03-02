// 1
void FirstTask(int masiveLen){
    if (masiveLen < 0) masiveLen *= -1;
    int[] masive = new int [masiveLen];
    int counter = 0;
    for (int i = 0; i < masiveLen; i++){
        masive[i] = new Random().Next(100, 1000);
        if(masive[i]%2 == 0) counter++;}
    Console.WriteLine($"[{String.Join(",", masive)}]");
    Console.WriteLine($"Количество чётных чисел: {counter}");}
FirstTask(12);
// 2
void SecondTask(int masiveLen, int start, int end){
    if (masiveLen < 0) masiveLen *= -1;
    int[] masive = new int [masiveLen];
    int sum = 0;
    for (int i = 0; i < masiveLen; i++){
        masive[i] = new Random().Next(start, end+1);
        if(i%2 == 1) sum+=masive[i];}
    Console.WriteLine($"[{String.Join(",", masive)}]");
    Console.WriteLine($"Сумма чисел на не чётных позициях: {sum}");}
SecondTask(-12, 12, 200);
// 3
void ThirdTask(int masiveLen, double digit){
    if (masiveLen == 0){
        Console.WriteLine("[]");
        Console.WriteLine("Разница между максимальным и минимальным элементом массива: 0");
        return;
    }
    Random rndNumber = new Random();
    if (masiveLen < 0) masiveLen *= -1;
    int[] masive = new int [masiveLen];
    int max = masive[0];
    int min = masive[0];
    for (int i = 0; i < masiveLen; i++){
        masive[i] = (int)(rndNumber.NextDouble()*Math.Pow(10,digit));
        if(masive[i]>max) max = masive[i];
        if(masive[i]<min) min = masive[i];}
    Console.WriteLine($"[{String.Join(" ", masive)}]");
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {max-min}");}
ThirdTask(12,5);
// 4 доп
void FourthTask(int masiveLen, int start, int end){
    if (masiveLen < 0) masiveLen *= -1;
    int[] masive = new int [masiveLen];
    for (int i = 0; i < masiveLen; i++) masive[i] = new Random().Next(start, end+1);
    if (masiveLen%2 == 0){
        int[] mults = new int [masiveLen/2];
        for (int i = 0; i < masiveLen/2; i++) mults[i]=masive[i] * masive[masiveLen-i-1];
        Console.WriteLine($"[{String.Join(" ", masive)}]");
        Console.WriteLine($"Произведение пар чисел: {String.Join(" ", mults)}");
    }else{
        int[] mults = new int [masiveLen/2+1];
        for (int i = 0; i < masiveLen/2; i++) mults[i]=masive[i] * masive[masiveLen-i-1];
        mults[masiveLen/2] = masive[masiveLen/2];
        Console.WriteLine($"[{String.Join(" ", masive)}]");
        Console.WriteLine($"Произведение пар чисел: {String.Join(" ", mults)}");
    }
}
FourthTask(1, 12, 14);