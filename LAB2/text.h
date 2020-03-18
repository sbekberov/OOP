#pragma once
#include "Line.h"
class Text
{
private:
    Line str[15];


public:
    int n;
    bool search(Line ln);
    void charDelete();
    void delline(int ind);
    int maxlensearch();
    void  printT();
    void inputtext();
    void upper();
    void newline();
};

