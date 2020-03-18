#define _CRT_SECURE_NO_WARNINGS
#include "text.h"
#include<iostream>
using namespace std;

void Text::delline(int ind)
{
    for (int i = ind; i <= n; i++)
    {
        str[i] = str[i + 1];
    }
    --n;
}
int Text::maxlensearch()
{

    int mx = str[0].maxwlen();
    for (int i = 0; i < n; i++)
    {
        if (mx < str[i].maxwlen())
        {
            mx = str[i].maxwlen();
        }
    }
    return  mx;
}
void  Text::printT()
{
    for (int i = 0; i < n; i++)
    {
        str[i].printString();
    }

}
void Text::charDelete()
{
    char ct;
    cout << "Enter char, what string you want to del:";
    cin >> ct;
    for (int j = 0; j < n; j++)
    {
        if (str[j].search(ct))
        {
            for (int i = j; i <= n; i++)
            {
                str[i] = str[i + 1];
            }
            --n;
        }

    }
}
void Text::newline()
{
    cout << "New Line:";
    str[n].inputString();
    ++n;
}
void Text::inputtext()
{
    cout << "Enter number of lines: ";
    cin >> n;
    n = n + 1;
    cout << "Enter text: " << endl;
    for (int i = 0; i < n; i++)
    {
        str[i].inputString();
    }
    cout << endl;
}
void Text::upper()
{
    for (int i = 0; i < n; i++)
    {
        str[i].lineupper();
    }
}


