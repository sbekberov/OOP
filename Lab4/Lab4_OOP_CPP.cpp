#include <iostream>
#include "Square.h"

using namespace std;

int main()
{
	Square* K1 = new Square();
	Square* K2 = new Square(1, 2, 4, 2, 1, 5, 4, 5);
	Square* K3 = new Square((*K1));

	cout << "Coords of K1 square: \n" <<
		"Point A: (" << K1->GetX(a) << ";" << K1->GetY(a) << ") " <<
		"Point B: (" << K1->GetX(b) << ";" << K1->GetY(b) << ") " <<
		"Point C: (" << K1->GetX(c) << ";" << K1->GetY(c) << ") " <<
		"Point D: (" << K1->GetX(d) << ";" << K1->GetY(d) << ") " << endl << endl;

	cout << "Coords of K2 square: \n" <<
		"Point A: (" << K2->GetX(a) << ";" << K2->GetY(a) << ") " <<
		"Point B: (" << K2->GetX(b) << ";" << K2->GetY(b) << ") " <<
		"Point C: (" << K2->GetX(c) << ";" << K2->GetY(c) << ") " <<
		"Point D: (" << K2->GetX(d) << ";" << K2->GetY(d) << ") " << endl << endl;

	cout << "Coords of K3 square: \n" <<
		"Point A: (" << K3->GetX(a) << ";" << K3->GetY(a) << ") " <<
		"Point B: (" << K3->GetX(b) << ";" << K3->GetY(b) << ") " <<
		"Point C: (" << K3->GetX(c) << ";" << K3->GetY(c) << ") " <<
		"Point D: (" << K3->GetX(d) << ";" << K3->GetY(d) << ") " << endl << endl;
	cout << " " << endl;


	cout << "Side length of K1 square: " << K1->Side() << endl;
	cout << "Side length of K2 square: " << K2->Side() << endl;
	cout << "Side length of K3 square: " << K3->Side() << endl;
	cout << " " << endl;
	
	cout << "Square of K1 square: " << K1->square() << endl;
	cout << "Square of K2 square: " << K2->square() << endl;
	cout << "Square of K3 square: " << K3->square() << endl;
	cout << " " << endl;

	cout << "Perimetr of K1 square: " << K1->Perimetr() << endl << endl;
	cout << "Perimetr of K2 square: " << K2->Perimetr() << endl << endl;
	cout << "Perimetr of K3 square: " << K3->Perimetr() << endl << endl;
	cout << " " << endl;


	//P1 = *P3 - P2;
	//cout << "Square P1 after subtraction P3-P2: " << K1->square() << endl;

	char n;
	cin >> n;
	return 0;
}