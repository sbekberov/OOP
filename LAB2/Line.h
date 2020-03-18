#pragma once
class Line
{
private:
	char* word;
	int size;

public:
	char* str;

	Line();
	bool search(char ch);
	int maxwlen();
	void printString();
	void lineupper();
	void inputString();
};

