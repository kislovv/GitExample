using DllAnalyzer;

namespace MatrixWorker;

public class MatrixMath: IMatrixMath
{
        public int GetDeterminant(int[,] matrix)
        {    int n = matrix.GetLength(0);
            // Проверка на квадратность
            if (matrix.GetLength(0) != matrix.GetLength(1))        throw new ArgumentException("Матрица должна быть квадратной");
            // Базовый случай: 1x1
            if (n == 1)        return matrix[0, 0];
            // Базовый случай: 2x2
            if (n == 2)        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            int det = 0;
            for (int col = 0; col < n; col++)
            {        int[,] minor = GetMinor(matrix, 0, col);
                int cofactor = ((col % 2 == 0) ? 1 : -1) * matrix[0, col];        det += cofactor * GetDeterminant(minor);
            }
            return det;    
        }
        private static int[,] GetMinor(int[,] matrix, int rowToRemove, int colToRemove)
        {    int size = matrix.GetLength(0);
            int[,] minor = new int[size - 1, size - 1];
            int r = 0;    for (int i = 0; i < size; i++)
            {        if (i == rowToRemove) continue;
                int c = 0;
                for (int j = 0; j < size; j++)        {
                    if (j == colToRemove) continue;
                    minor[r, c] = matrix[i, j];            c++;
                }        r++;
            }    return minor;
        }
}
