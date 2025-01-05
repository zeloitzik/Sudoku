# Sudoku
A sudoku solver using basic backtracking.

Josh Ackland's solution heavily inspires the code. 
Pseudo code for understanding:
1. Start in the first empty cell
2. Try placing digits 1 through 9 and check if the digit is valid.
   Validity check: 
   1. If valid == true
   2. Go to the next cell and start over --> 2.
   3. else
   4. Remove the input and, reset the cell to empty ('.')
3. If all digits 1 through 9 have been tried. Backtrack to previous cells, and try a different digit(repeating steps 2-3)
