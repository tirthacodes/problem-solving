**Problem Statement: Compare Playing Cards**

You are given two playing cards. Each card is represented by a rank, which can be one of the following: Ace (A), 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack (J), Queen (Q), or King (K).

Write a program that compares the two cards and determines which card is greater based on the following hierarchy:

1. Ace (A) > King (K) > Queen (Q) > Jack (J) > 10 > 9 > 8 > 7 > 6 > 5 > 4 > 3 > 2.

In case both cards have the same rank, the program should output the rank of the card. If the ranks are also equal, the program should output "Equal".

**Input:**

The input consists of two lines. Each line contains a playing card represented by its rank (e.g., "A" for Ace, "10" for Ten).

**Output:**

The output is a single line containing the rank of the greater card or "Equal" if both cards are of the same rank.

**Example:**

*Input:*
```
A
10
```

*Output:*
```
A
```

