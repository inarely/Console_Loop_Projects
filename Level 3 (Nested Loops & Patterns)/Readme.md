# Level 3 — Nested Loops & Patterns

Exercises in this level focus on **nested loops**, **pattern printing**, and **digit-based logic** without arrays.  
You will practice controlling rows vs. columns, computing with indices, and extracting digits using division/modulo.

---

## Tasks Overview

### 15. **Multiplication Table NxN**
Input: `N (1 ≤ N ≤ 9)`.  
Print an `N×N` multiplication table. Rows correspond to multiplying by `1..N`.  
Values are space-separated.

### 16. **Right Triangle**
Input: `H (1 ≤ H ≤ 20)` and a single character `C`.  
Print a right triangle of height `H`: on the i-th line print `i` copies of `C`.

### 17. **Hollow Rectangle**
Input: `W (≥2)`, `H (≥2)`, and a character `C`.  
Print a `W×H` rectangle whose border is made of `C` and the inside is spaces.

### 18. **Chessboard Pattern**
Input: `N (N ≥ 1)`.  
Print an `N×N` grid where cells alternate:
- print `#` when `(i + j) % 2 == 0`,
- print `.` otherwise.
(You may swap the symbols if you prefer the opposite start.)

### 19. **Digits With Sum S**
Input: `S (0..18)`.  
Print all **two-digit** numbers whose digit sum equals `S`, separated by spaces, on one line.

### 20. **Palindromes in Range**
Input: `A` and `B (0 ≤ A ≤ B ≤ 99999)`.  
Print all numbers in `[A; B]` that are palindromes.  
Check palindromes by reversing the number in a loop and comparing with the original.

### 21. **Armstrong 3-Digit**
Print all three-digit Armstrong numbers (sum of the cubes of digits equals the number itself).  
Expected output: `153 370 371 407`.

---

## Learning Goals

- Master **nested loops** (row loop + column loop).
- Build console **patterns** and align output neatly.
- Use **modulo** and **integer division** to extract digits.
- Apply loop control for digit computations and validations.

