#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

class Base
{
public:
	string first_line;

	Base(string a)
	{
		this->first_line = a;
	}

	int GetLenth()
	{
		return first_line.length();
	}
};

class Derived : public Base
{
	int number;
	string second_line;

public:
	Derived(string a, int b, string c): Base(a)
	
	{
		this->number = b;
		this->second_line = c;
	}

	void output()
	{
		cout << "Строка 1 : " << first_line << endl;
		cout << "Цифровая строка : " << number << endl;
		cout << "Строка 2 : " << second_line << endl;
	}

	void ReverseNumber()
	{
		int new_line = 0;
		int remainder;
		int n = number;
		while (n != 0)
		{
			remainder = n % 10;
			new_line = new_line * 10 + remainder;
			n /= 10;
		}
		number = new_line;
	}

	void ReverseLine()
	{
		string new_line = "";
		for (int i = int(second_line.length()) - 1; i >= 0; i--)
		{
			new_line += second_line[i];
		}
		second_line = new_line;
	}
};
