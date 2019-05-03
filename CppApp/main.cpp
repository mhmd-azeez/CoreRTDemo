#include <iostream>
#include "NativeLibrary.h"
using namespace std;

void main()
{
	int result = add(1, 2);
	cout << result << endl;
	cout << "Hello World!" << endl;
	system("pause");
}