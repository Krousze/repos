// helloWorld.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h" // auto when created
//#include "stdafx.h" // told by docs to add; cannot open source file "stdafx.h"
#include <iostream> // auto when created; known as pre-processor directive. Tells compiler to locate the file that contains code for a library known as iostream (allows for input and output to streams, such as console window).

using namespace std; // told by docs to add; makes it so we don't have to type std:: in front of things like cout

int main() // must have method for all cpp programs; entry point for application
{
    /*std::cout << "Hello World!\n";*/ // auto when created
	
	// ==========================================================================
	// portability refers to the process of compiling your code, without major changes, across different compilers or different platforms. Platforms typically mean computer hardware, operating systems, CPU architectures, or device form factors. Compilers refer to the process of turning your code into executable form. Each platform or operating system may have different compilers available

	// Intrinsic data types:
		// These are types that contain the data literals directly
		// /

	//  C++ supports two methods of initializing a variable:
	int myVar = 0;
	int yourVar{ 1 };

	int myInt = 0;
	// explicit casting:
	long myLong = (long)myInt;
	long myLong = long(myInt);

	//C++ also provides a cast operator that is more restrictive in its usage. This in the form static_cast (type). This static cast operator can be used for converting numeric values or to numeric values. As an example:
	char ch;
	int i = 65;
	float f = 2.5;
	double dbl;
	ch = static_cast<char>(i);   // int to char
	dbl = static_cast<double>(f);   // float to double

	// Complex Data Types (Arrays)
		// also referred to as compound data types; mostly because they store more than one piece of data or potentially more than one data type.
		// Array:
			// a set of objects that are grouped together and managed as a unit
			// a sequence of elements, all of which are the same type
			// can build simple arrays that have:
				// one dimension (a list), 
				// two dimensions (a table), 
				// three dimensions (a cube), 
				// and so on
			// Arrays in C++ have the following features:
				// Every element in the array contains a value.
				// Arrays are zero - indexed, that is, the first item in the array is element 0.
				// The size of an array is the total number of elements that it can contain.
				// Arrays can be single - dimensional, multidimensional, or jagged.
				// The rank of an array is the number of dimensions in the array.
				// Arrays of a particular type can only hold elements of that type.
			// To declare a single-dimensional array, you specify the type of elements in the array and use brackets, [] to indicate that a variable is an array.
			// a single-dimensional array of integers with elements zero through nine.
			int arrayName[10];
			// or
			int myArrayName[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			// You can also declare an array and only initialize some of the elements:
			int arrayName[10] = { 1, 2, 3 }; /* In this case, we have declared an array of size 10 
				but have only assigned values to the first three elements.The compiler will initialize
				the remaining elements to the default value for the data type the array holds.In this
				case, int data type, the remaining values are initialized to 0. */

			/* The last element in a dimension is at index N-1, where N is the size of the dimension. 
				If you are using some other languages, such as C#, and you attempt to access an element 
				outside this range, the C# runtime will throw an exception (error). C++ doesn't offer 
				such protection. If you attempt to access an element that is outside the bounds of your
				array, you will still return data, but you have no idea what that data is.

			The reason for this is because an array is simply a pointer to a memory location.The first 
				element of the array is the starting memory address for the entire array.If you have an 
				array of integer data types, then the number of the elements multiplied by the size of 
				the int data type on your system, determines how much memory is used by the array, and 
				at the same time, permits the access of the elements in the array by performing math on
				the memory address to get at the required element.If you attempt to access oldNumbers[5], 
				the program will simply return the data found at the memory address that is the next 
				memory address location beyond the last array element.This can be a dangerous situation 
				and is in fact, the result of some security issues found in software. */
	// Strings
		/* Strings are a series of characters. C++ represents strings in one of two ways. The first 
			maintains backward compatibility with the C language and represents the string as a character 
			array. There is one aspect to a C-style string that is important to note. The last character 
			of every string you store is the null character string, typically represented by the ASCII 
			code for 0 which is \0. This is necessary so that the compiler knows when the string ends. An 
			example demonstrates a C-style string stored in a character array: */
		char isAString[6] = { 'H', 'e', 'l', 'l', 'o', '\0'}; 
		char isNotAString[5] = { 'H', 'e', 'l', 'l', 'o'}; 
		cout << isAString << endl; 
		cout << isNotAString << endl;
		/* The most common mistake made by users of the C-style string is to forget to make the char array 
			large enough to accommodate the \0 character, but also forgetting include the \0. In the 
			previous example, a programmer might think that an array of size 5 would be large enough to 
			contain Hello because that's how many characters are in the word. However, the null character 
			would not be included in the second array, which could result in errors in code that uses this 
			array. The reason is that C++ does not consider the isNotAString array to be a string. */

		/* An alternative method of declaring a character array for use as a string is to simply initialize
			it with a string literal. A string literal is a sequence of characters enclosed in the double 
			quotes ("). For example: */
		char isAString[6] = "Hello"; // creates an array of size 6 and assigns the string literal Hello to the array
		char isAnotherString[] = "Array size is inferred"; // lets the compiler infer the size from the string literal itself
	// String Class:
		//
	// ==========================================================================
	
	cout << "Hello World! ";
	return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
