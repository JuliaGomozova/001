﻿string[] array = {"one", "two", "three", "four", "five", "six", "seven", "-1"};

int resultArraySize = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length == 3) 
        resultArraySize++;
}

string[] resultArray =  new string[resultArraySize];
