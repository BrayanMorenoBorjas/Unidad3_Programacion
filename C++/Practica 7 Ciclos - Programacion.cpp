#include <iostream>
using namespace std;
int main()
{
	int c, d, suma = 0;
	
	cout << "Este programa te permite visualizar los numeros dentro de un rango especifico y sumarlos" << "\n";
	for(c = 0; c < 10; c++){
		cout << "Introduce el numero" << endl;
		cin >> d;
		suma = suma + d;
	}
	cout << "La suma total dentro del rango es: " << suma << endl;
	
	return 0;
}
