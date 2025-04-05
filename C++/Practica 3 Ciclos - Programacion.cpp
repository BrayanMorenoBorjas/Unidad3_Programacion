#include <iostream>
using namespace std;

int main()
{
	float Num, Total;
	cout << "Este programa suma los numeros que introduces y suma todo cuando se introduzca un cero (0)" << "\n";
	
	do {
		cout << "Introduce un numero: ";
		cin >> Num;
		
		Total = Total + Num;
		
    }
	while(Num != 0.0);
	cout << "La suma total es: " << Total;
	return 0;
}
