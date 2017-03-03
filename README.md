# Matrix Rotation
You are given a 2D matrix, a, of dimension MxN and a positive integer R.  
You have to rotate the matrix R times and return the resultant matrix. Rotation should be in anti-clockwise direction.  

Rotation of a 4x5 matrix is represented by the following figure. Note that in one rotation, you have to shift elements by one step only.  
It is guaranteed that the minimum of M and N will be even.

![alt tag](https://hr-challenge-images.s3.amazonaws.com/2517/matrix-rotation.png)

Constraints:  
2 <= M, N <= 300  
1 <= R <= 10<sup>9</sup>  
min(M, N) % 2 == 0  
1 <= aij <= 10<sup>8</sup>, where i ∈ [1..M] & j ∈ [1..N]  
