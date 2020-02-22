# MaxDistance

This project provides the maximum distance of between the charecters in a given array.

A function MaxDistance(char[]) is implemented in c# which takes an input of array of charecters and return the maximum distance between charectes of the given string. For example,
for a given array "A", the maximum distance is defined as the largest difference between any A[i] and A[j] where i < j and A[i] comes before A[j] in the alphabet. 

# Sample Input/Output

1. 
A = [ g, b, c, j, b, d, h, a ]

There are 7 letters between ‘b’ and ‘j’ AND ‘b’ comes before ‘j’ alphabetically AND index of ‘j’ > index of ‘b’.

Maximum possible distance is 7

2.
A = [ A, C, E, Z ]

There are 24 letters between 'A' and 'Z' AND 'A' comes before 'Z' alphabetically AND index of 'Z' > index of 'A'

Maximum possible distance is 24

# Format

This method is not case sensitive since the difference is computed on the ASCII values of the alphabets.

This program returns -1 in special cases like,

	i.  	numerical input
	ii. 	Special charecters
	iii.	null input
	iv.		mixed case input	

