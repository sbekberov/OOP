#include <iostream>
#include"Class.cpp"
using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");
    Base BaseClass = Base("Bekberov");
    Derived DerivativeClass = Derived("Bekberov", 12345, "Selim");


    cout << "Первоначальные данные : " << endl;;
    DerivativeClass.output();
    cout << "Длина : " << DerivativeClass.GetLenth() << endl;

    cout << " " << endl;


    DerivativeClass.ReverseLine();
    DerivativeClass.ReverseNumber();

    cout << "Данные после операций : " << endl;
    DerivativeClass.output();
    cout << "Длина : " << DerivativeClass.GetLenth() << endl;
}