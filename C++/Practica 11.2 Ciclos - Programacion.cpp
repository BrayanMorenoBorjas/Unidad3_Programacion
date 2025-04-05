#include <iostream>   
using namespace std; 
  
int main() 
{
	float x, f;
	for (x <= 10; x++;)
	{
	cout << "Este programa te pernmite calular una ecuacion" << "\n";
	cout << "Ingresa el valor de x:" << "\n";
	cin >> x;
	f=x/(1+(x*x));
	cout << "El resultado de la funcion: ";
	cout << f << "\n";
	}
}
