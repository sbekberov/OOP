#include <math.h>
#include "Square.h"

Square* Square::Multiply(Square square, double number)
{
	Square* result = new Square(square);

	result->A.x = result->A.x * sqrt(number);
	result->A.y = result->A.y * sqrt(number);

	result->B.x = result->B.x * sqrt(number);
	result->B.y = result->B.y * sqrt(number);

	result->C.x = result->C.x * sqrt(number);
	result->C.y = result->C.y * sqrt(number);

	result->C.x = result->C.x * sqrt(number);
	result->C.y = result->C.y * sqrt(number);

	return result;
}

Square::Square()
{
	A.x = 5;
	A.y = -2;

	B.x = 0;
	B.y = -4;

	C.x = 1;
	C.y = 8;

	D.x = -4;
	D.y = 6;
}

Square::Square(double a1, double a2, double b1, double b2, double c1, double c2, double d1, double d2)
{
	A.x = a1;
	A.y = a2;

	B.x = b1;
	B.y = b2;

	C.x = c1;
	C.y = c2;

	D.x = d1;
	D.y = d2;
}

Square::Square(Square* other)
{
	A.x = other->A.x;
	A.y = other->A.y;

	B.x = other->B.x;
	B.y = other->B.y;

	C.x = other->C.x;
	C.y = other->C.y;

	D.x = other->D.x;
	D.y = other->D.y;
}

double Square::Side()
{
	return sqrt(pow(A.x - B.x, 2) + pow(A.y - B.y, 2));
}

double Square::square()
{
	double square = pow((sqrt(pow(A.x - B.x, 2) + pow(A.y - B.y, 2))), 2);
	return square;

	
}

double Square::Perimetr()
{
	double perim = 0;

	perim = (sqrt(pow(A.x - B.x, 2) + pow(A.y - B.y, 2)))*4;


	return perim;
}

double Square::GetX(Points point)
{
	if (point == a)
	{
		return A.x;
	}
	else if (point == b)
	{
		return B.x;
	}
	else if (point == c)
	{
		return C.x;
	}
	else if (point == d)
	{
		return D.x;
	}

	return 0;
}

double Square::GetY(Points point)
{
	if (point == a)
	{
		return A.y;
	}
	else if (point == b)
	{
		return B.y;
	}
	else if (point == c)
	{
		return C.y;
	}
	else if (point == d)
	{
		return D.y;
	}

	return 0;
}



/*

Square* Square::operator *(double number)
{
	Square* temp = this->Multiply(*this, number);
	return temp;
}

Square* Square::operator +(Square* second)
{
	Square* temp = new Square();
	double subtraction = this->square() + second->square();
	temp = *this * (subtraction / this->square());

	return temp;
}

Square* Square::operator + (double second)
{
	Square* temp = new Square();
	double subtraction = this->square() + second;
	temp = this->Multiply(*this, (subtraction / this->square()));

	return temp;
};*/