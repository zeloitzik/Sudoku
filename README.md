# Sudoku
A sudoku solver using basic backtracking.

This code is heavily inspired by Josh Ackland's solution.(The idea of using hashsets I took from him)
Pseudo code for understanding:
1. Start in the first empty cell
2. Try placing digits 1 through 9 and check if the digit is valid.
   Validity check: 
   1. If valid == true
   2. Go to the next cell and start over --> 2.
   3. else
   4. Remove the input and, reset the cell to empty ('.')
3. If all digits 1 through 9 have been tried. Backtrack to previous cells, and try a different digit(repeating steps 2-3)

The following gif is a visual representation of the algorithm:



![](https://github.com/zeloitzik/Sudoku/blob/main/Sudoku_solved_by_bactracking.gif)
