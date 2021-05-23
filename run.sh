#!/bin/bash

function divider()
{
	echo --------------------------------------------------
}

function problem_1_test()
{
	echo
	output=OUTPUT1.TXT
	rm  $output
	echo Input:
	cat $1 
	cat $1 | ../bin/Debug/problem_1
	echo
	echo Output:
	cat $output
	echo
}


function problem_2_test()
{
	echo
	output=OUTPUT2.TXT
	rm  $output
	echo Input:
	cat $1 
	cat $1 | mono ../bin/Debug/problem_2.exe
	echo
	echo Output:
	cat $output
	echo
}




cd tests

echo \##  Problem 1 \#####################################
problem_1_test problem-1-01.txt
divider
problem_1_test problem-1-02.txt
divider
problem_1_test problem-1-03.txt
divider
problem_1_test problem-1-04.txt
divider
problem_1_test problem-1-05.txt
divider
problem_1_test problem-1-06.txt

echo
echo \##  Problem 2 \#####################################

problem_2_test problem-2-01.txt