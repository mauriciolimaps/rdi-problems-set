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

cd tests

echo \##  Problem 1 \#####################################
problem_1_test problem-1-01.txt
divider
problem_1_test problem-1-01.txt

echo
echo \##  Problem 2 \#####################################

