#include <iostream>
using namespace std;

int main()
{
	int Num, lim;
	int count = 0;
	
	cout << "Este programa te permite saber la tabla de multiplicar de cualquier numero y poner un limite cuantos operaciones quieres que te aparezcan" << "\n";
	cout << "Ingresa la tabla de multiplicar que quieres ver: ";
	cin >> Num;
	
	cout << "Ingresa el numero maximo de multiplicaciones que quieres ver: "; 
	cin >> lim;
	
	do {
		cout << Num << " x " << count << " = " << Num*count <<endl;
		count++;  
	}
	while(count <= lim);
	return 0;
}
