// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hei, hva heter du?");
// var userName = Console.ReadLine();
// if (userName != "") Console.WriteLine($"Velkommen {userName}!");

//long

int tall = 1;

float deci = 0.01F;
double dub = 0.01;
decimal dci = 0.101M;

char bokstav = 'a';
string tekst = "hei";

bool santUsant = false;

int[] intArray = { 1, 2, 3, 4, 5, 6, };
string[] stringArray = { "Hi", "bye", "sly" };

string nothing = "This method is empty";

double sumIt()
{
    return tall + dub;
}
string notIt()
{
    return nothing ;
}

void Run()
{
    Console.WriteLine($"1 + 0.01 = {sumIt()}");
    Console.WriteLine(notIt());
}

Run();



//int a = 5;
//decimal b = 3.0M;

//decimal sum = a + b;

//Console.WriteLine($"5 + 3.0 = {sum}");

