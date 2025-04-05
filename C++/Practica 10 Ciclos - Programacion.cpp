#include <iostream>   
using namespace std; 
  
int main() 
{
	int x, cua, cub, z;
	cout << "Este programa te permite calcular una ecuacion" << "\n";
	for (x=1; x<=50; x++) {
		cout << "Ingresa el valor de x: ";
		cin >> x;
		cua = x * x;
		cub = x * x * x;
		z = cua + cub;
		cout << "El reusltado de la ecuacion es: ";
		cout << z;
	}
	return 0;
}
