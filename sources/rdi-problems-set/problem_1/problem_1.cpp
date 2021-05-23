
//#include "pch.h"
#include <iostream>
#include <fstream>


using namespace std;


// Complete the timeInWords function below.
string timeInWords(int h, int m) {
    string numbers[] = { "midnight", "one",       "two",      "three"  ,  "four"   ,
                                     "five",      "six",      "seven"  ,  "eight"  ,
                                     "nine",      "ten",      "eleven" ,  "twelve" ,
                                     "thrirteen", "fourteen", "fifteen",  "sixteen",
                                     "seventeen", "eighteen", "nineteen"
    };
    string result;

    try
    {
        if ((h < 0) || (h > 12))
            throw "Invalide time value";

        if ((m < 0) || (m > 59))
            throw "Invalid minutes value";

        result = numbers[h];

        switch (m)
        {
        case 0:
            return result + "o' clock";

        case 15:
            return "quarter past " + result;

        case 30:
            return "half past " + result;

        case 45:
            return "quarter to " + result;

        }

        if (m > 30) {
            m = 60 - m;
            result = " to " + numbers[h + 1];
        }
        else {
            result = " past " + numbers[h];
        }

        if (m < 20)
            return numbers[m] + result;

        if (m >= 20)
            return "twenty" + (m > 20 ? " " + numbers[m % 20] : "") + result;

    }
    catch (string e)
    {
        throw e;
    }

    return result;
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
