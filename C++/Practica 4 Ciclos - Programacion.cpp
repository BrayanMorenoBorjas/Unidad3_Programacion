#include <iostream>
using namespace std;

int main()
{
	int i = 0;
	
	cout << "Este programa te permite sumar los numeros que introduzcas" << "\n";
	
	do {
		cout << "Ingresa un numero: " << "\n";
		cin >> i;
		int array [] = {i};
		cout << array[i] << endl;
		i++;
	}
	while (i <= 5);
	return 0;
	
}
