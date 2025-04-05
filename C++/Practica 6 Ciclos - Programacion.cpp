#include <iostream>
using namespace std;
int main()
{
	int choose = 1;
	cout <<"Este programa te permite verificar si un numero es par o impar" << "\n";
	
	while( choose == 1){
		int Num;
		cout << "Introduce el numero que se quiere verificar" << endl;
		cin >> Num;
		if (Num%2 == 0) {
			cout << "El numero es par" << endl;
		}
		else {
			cout << "El numero es impar" << endl;
		}
	}
	return 0;
}
