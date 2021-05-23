
//#include "pch.h"
#include <iostream>
#include <fstream>


using namespace std;


// Complete the timeInWords function below.
string timeInWords(int h, int m) {

    return "";
}


int main()
{
    ofstream fout("OUTPUT1.TXT", fstream::out | fstream::app);

    int h;
    cin >> h;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    int m;
    cin >> m;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    string result = timeInWords(h, m);

    fout << result.c_str() << "\n";
    fout.close();

    return 0;
}
