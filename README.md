# ChessBishopAndPawnKata

This is my attempt on codewars Chess Fun [Bishop And Pawn Kata](https://www.codewars.com/kata/589425c2561a35dd1a0000a2)

According to wikipedia a chess board is composed of 64 squares:
* Vertically  1-8.
* Horizontally a-h.
* A bishop can move any number of squares diagonally, but cannot leap over other pieces.
* A pawn can move forward to the unoccupied square immediately in front of it on the same file, or on its first move it can advance two squares along the same file, provided both squares are unoccupied. A pawn can capture an opponent's piece on a square diagonally in front of it by moving to that square. A pawn has two special moves: the en passant capture and promotion.
* _Promotion_: When a pawn advances to the eighth rank, as part of the move, it is promoted and must be exchanged for the player's choice of queen, rook, bishop, or knight of the same color
* _En passant_: When a pawn makes a two-step advance from its starting position and there is an opponent's pawn on a square next to the destination square on an adjacent file, then the opponent's pawn can capture it en passant ("in passing"), moving to the square the pawn passed over. This can be done only on the turn immediately following the enemy pawn's two-square advance

Given the positions of a white bishop and a black pawn on the standard chess board, determine whether the bishop can capture the pawn in one move.
