#include<iostream>
#include "text.h"

using namespace std;

Text DelText(Text txt);
bool search();

int main()
{
    Text mytext;

    mytext.inputtext();
    mytext.charDelete();
    cout << "After this string deleting: " << endl;
    mytext.printT();
    mytext.upper();
    cout << "\nIf take first letters to upper case: ";
    mytext.printT();

    cout << "The length of the biggest string: " << mytext.maxlensearch() << endl;

    int n;
    cout << "Choose what string to del: ";
    cin >> n;

    mytext.delline(n);
    mytext.printT();
   
    mytext = DelText(mytext);
    cout << "\nText after deleting all strings: ";
    mytext.printT();

    char i;
    cin >> i;
}

Text DelText(Text txt)
{
    for (int i = 0; i <= txt.n; ++i)
    {
        txt.delline(i);
    }

    txt.n = txt.n - 1;
    return txt;
}
