
 // 1-masala. Pragrammaga parol qo'yish
string password = "";
do
{
    System.Console.WriteLine("Enter password: ");
    password = Console.ReadLine();
}while (password != "dilshod");

// 2-masala. 3 ta son kiritiladi kiritilgan uchta sondan eng kichigini ekranga chiqarish talab etiladi
System.Console.WriteLine("kiritilgan 3 ta sondan eng kichigini ekranga chiqarish talab etiladi ");
System.Console.WriteLine("sonlarni ketma ketlikda kiriting : ");
int firstnum = Convert.ToInt32(Console.ReadLine());
int secondnum = Convert.ToInt32(Console.ReadLine());
int threenum = Convert.ToInt32(Console.ReadLine());

if (firstnum <= secondnum && firstnum <= threenum)
{
    System.Console.WriteLine($"kiritilgan sonlarning kichigi {firstnum} ");
}
else

if (secondnum <= firstnum && secondnum <= threenum)
{
    System.Console.WriteLine($"kiritilgan sonlarning kichigi {secondnum} ");
}
else
{
    System.Console.WriteLine($"kiritilgan sonlarning kichigi {threenum} ");
}

// 3-masala ikkita butun son kkiritiladi. Kiritilgan ikki son orasidagi butun sonlarni yig'indisini hisoblash talab etiladi

System.Console.WriteLine("ikkita  butun son kiriting : ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
int secondnumber = Convert.ToInt32(Console.ReadLine());
int result =0;
if (secondnumber>firstnumber)
{
    for (int i = firstnumber+1; i < secondnumber; i++ )
    {
        result +=i;
    }
     System.Console.WriteLine($" {firstnumber} bilan {secondnumber} orasidagi butun sonlar yig'indisi {result} ga teng ");
}
else 
if(secondnumber<firstnumber)
{
    for (int i = secondnumber+1; i < firstnumber; i++ )
    {
        result +=i;
    }
     System.Console.WriteLine($" {secondnumber}  bilan {firstnumber} orasidagi butun sonlar yig'indisi {result} ga teng ");
}
else
{
    System.Console.WriteLine("kiritilgan sonlar bir biriga teng, ular orasida butun sonlar yo'q ");
}

// 4 - masala kiritilgan sonning raqamlari yig'indisini hisoblash talab etiladi
int son = 0,b =0,c =0; // dasturdagi o'zgaruvchilar
System.Console.WriteLine("Ixtiyoriy butun son kiriting: ");
son = Convert.ToInt32(Console.ReadLine());

do
{
    b = son % 10;              // ajratilgan oxirgi raqam
    c += b;                //raqamlar yig;indisi
    son = son / 10;              // oxirgi raqamidan ajratilgan son
}while (son != 0);
System.Console.WriteLine($"Kiritilgan sonning raqamlari yig'indisi {c} ");

System.Console.WriteLine("Etiboringiz uchun raxmat!");
Console.ReadKey();