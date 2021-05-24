#!/bin/bash

echo "Build 'Problem #1' (C++)"
clang++-7 -pthread -std=c++17 -o bin/Debug/problem_1 \
sources/rdi-problems-set/problem_1/problem_1.cpp

echo "Build 'Problem #2' (C#)"
mcs -out:bin/Debug/problem_2.exe \
sources/rdi-problems-set/problem_2/problem_2.cs

echo "Build 'Problem #3' (C#)"
mcs -out:bin/Debug/problem_3.exe \
sources/rdi-problems-set/problem_3/problem_3.cs

