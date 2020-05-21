#include <iostream>
#include <string>

using namespace std;

int cacl(string s,char c)
{
	int count = 0;
	for (int i = 0; i < s.length(); i++)
	{
		if (s[i]==c) count++;
	}
	return count;
}

int main()
{
	string s = "";
	char c;
	cout << "Enter string" << endl;
	cin >> s;
	cout << "Enter symvol" << endl;
	cin >> c;
	int(*fncPtr)(string s,char c) = cacl;
	cout << "In your string " << (*fncPtr)(s,c) << " char" << endl;
	return 0;
}