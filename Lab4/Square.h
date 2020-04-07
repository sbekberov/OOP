#pragma once
enum Points
{
	a,
	b,
	c,
	d
};

class Square {
private:
	struct Point {
	public:
		double x;
		double y;
	};
	Point A;
	Point B;
	Point C;
	Point D;
public:
	Square();
	Square(double a1, double a2, double b1, double b2, double c1, double c2, double d1, double d2);
	Square(Square* other);
	static Square* Multiply(Square square, double number);
	double Side();
	double square();
	double Perimetr();
	double GetX(Points point);
	double GetY(Points point);
	
	Square* operator *(double number);
	
	Square* operator -(double second);
};