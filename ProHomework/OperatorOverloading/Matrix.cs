using System;
using System.Text;

namespace OperatorOverloading
{
    //Створiть та опишiть клас «Матриця». 
    //Виконайте перевантаження
    //+ (для додавання матриць), 
    //– (для віднімання матриць).
    //* (множення матриць одна на одну, множення матриці на число), 
    //== (перевірка матриць на рівність), 
    //!= і Equals.
    //Використовуйте механізм властивостей полів класу і механізм індексаторів.


    public class Matrix
    {
        private int[,] values;

        public int Rows { get; }
        public int Columns { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="random">Заполнить случайными значенниями</param>
        public Matrix(int rows, int columns, bool random = false)
        {
            Rows = rows;
            Columns = columns;

            values = new int[rows, columns];

            var r = new Random();

            if (random)
            {
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        values[i, j] = r.Next(0, 10);
                    }
                }
            }
        }

        public int GetValue(int row, int column)
        {
            return values[row, column];
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if (m1 != m2)
            {
                throw new ArgumentException("Матриці мають бути однакового розміру для додавання");
            }

            int rows = m1.Rows;
            int columns = m1.Columns;
            Matrix result = new Matrix(rows, columns);

            for (int i = 0; i < rows; i++)
            {               
                for (int j = 0; j < columns; j++)
                {
                    result.values[i, j] = m1.values[i, j] + m2.values[i,j];
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            if (m1 != m2)
            {
                throw new ArgumentException("Матриці мають бути однакового розміру для віднімання");
            }

            int rows = m1.Rows;
            int columns = m1.Columns;
            Matrix result = new Matrix(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result.values[i, j] = m1.values[i, j] - m2.values[i, j];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.Columns != m2.Rows)
            {
                throw new ArgumentException("Кількість стовпців першої матриці має дорівнювати кількості рядків другої матриці для множення");
            }

            int rows = m1.Rows;
            int columns = m2.Columns;
            int sharedDimension = m1.Columns;
            Matrix result = new Matrix(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int k = 0; k < sharedDimension; k++)
                    {
                        result.values[i, j] = m1.values[i, k] * m2.values[k, j];
                    }
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix matrix, int num)
        {
            int rows = matrix.Rows;
            int columns = matrix.Columns;
            Matrix result = new Matrix(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result.values[i, j] = matrix.values[i, j] * num;
                }
            }

            return result;
        }

        public static bool operator ==(Matrix m1, Matrix m2)
        {
            return m1.Rows == m2.Rows && m1.Columns == m2.Columns;
        }

        public static bool operator !=(Matrix m1, Matrix m2)
        {
            return !(m1 == m2);
        }

        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    result += values[i, j] + "\t";
                }

                result += "\n";
            }

            return result;
        }
    }
}
