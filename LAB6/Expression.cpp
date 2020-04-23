#include "Expression.h"
#include <iostream>
#include <math.h>

using namespace std;

Expression::Expression(double a,  double c, double d)
{
	this->a = a;
	this->c = c;
	this->d = d;
}

double Expression::Calculate()
{
	if ((2 * c - a) < 0)
	{
		throw domain_error("Logarithm from negative value not possible");
	}
	if ((a / 4 + c) == 0)
	{
		throw "Division by zero exception";
	}

	return log((2 * c - a)  + d - 152);
}

Expression* Expression::operator +(int num)
{
	return new Expression(this->a + num,  this->c + num, this->d + num);
}

Expression* Expression::operator +(Expression example)
{
	return new Expression(this->a + example.a,  this->c + example.c, this->d + example.d);
}

Expression* Expression::operator -(int num)
{
	return new Expression(this->a - num,  this->c - num, this->d - num);
}

Expression* Expression::operator -(Expression example)
{
	return new Expression(this->a - example.a,  this->c - example.c, this->d - example.d);
}