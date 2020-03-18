#include "Line.h"
#include<iostream>
using namespace std;

Line::Line()
{
    size = 100;
    str = new char[size];

}
int  Line::maxwlen()
{
    return strlen(str);
}

void  Line::inputString()
{
    cin.getline(str, size);
}

void  Line::printString()
{
    cout << str << endl;
}

void  Line::lineupper()
{
    for (int i = 0; i < strlen(str); i++)
    {
        if ((str[i - 1] == ' ') || (i == 0))
            str[i] = toupper(str[i]);
    }
}
bool Line::search(char ch)
{
    string s = str;
    int i = 0;
    bool f = false;
    for (i = s.find(ch, i++); i != string::npos; i = s.find(ch, i + 1))
        f = true;
    return f;
}


