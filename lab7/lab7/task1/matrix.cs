using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class matrix
    {
        private int[,] matr = new int[2, 2];
        private int deter = 0;

        public matrix()
        {
            matr[0, 0] = 0;
            matr[0, 1] = 0;
            matr[1, 0] = 0;
            matr[1, 1] = 0;
            SetDeter();
        }

        public matrix(int a1, int a2, int b1, int b2)
        {
            matr[0, 0] = a1;
            matr[0, 1] = a2;
            matr[1, 0] = b1;
            matr[1, 1] = b2;
            SetDeter();
        }

        //индексатор
        public int this[int ind1, int ind2]
        {
            get
            {
                if (ind1 >= 0 && ind1 < 2 && ind2 >= 0 && ind2 < 2)
                    return matr[ind1, ind2];
                else
                    throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (ind1 >= 0 && ind1 < 2 && ind2 >= 0 && ind2 < 2)
                {
                    matr[ind1, ind2] = value;
                    SetDeter();
                }
            }
        }
        public static matrix operator+(matrix mat1, matrix mat2)
        {
            matrix output = new matrix();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    output[i, j] = mat1[i, j] + mat2[i, j];
                }
            }
            return output;
        }

        public static matrix operator-(matrix mat1, matrix mat2)
        {
            matrix output = new matrix();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    output[i, j] = mat1[i, j] - mat2[i, j];
                }
            }
            return output;
        }

        public static matrix operator++(matrix mat)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    mat[i, j]++;
                }
            }
            mat.SetDeter();
            return mat;
        }

        public static matrix operator--(matrix mat)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    mat[i, j]--;
                }
            }
            mat.SetDeter();
            return mat;
        }

        public static matrix operator*(matrix mat1, matrix mat2)
        {
            matrix output = new matrix();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        output[i, j] += mat1[i, k] * mat2[k, j];
                    }
                }
            }
            return output;
        }

        public static matrix operator*(matrix mat, int number)
        {
            matrix output = new matrix();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    output[i, j] = mat[i, j] * number;
                }
            }
            return output;
        }

        public static matrix operator/(matrix mat, int number)
        {
            matrix output = new matrix();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    output[i, j] = mat[i, j] / number;
                }
            }
            return output;
        }

        public static bool operator==(matrix mat1, matrix mat2)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (mat1[i, j] != mat2[i, j])
                        return false;
                }
            }
            return true;
        }

        public static bool operator !=(matrix mat1, matrix mat2)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (mat1[i, j] != mat2[i, j])
                      return true;
                }
            }
            return false;
        }

        //перегрузка операторов преобразования типов
        public static explicit operator bool(matrix mat)
        {
            if (mat.deter != 0)
                return true;
            return false;
        }

        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    output += matr[i, j].ToString();
                    output += " ";
                }
            }
            return output;
        }

        public void SetDeter(int s_deter)
        {
            matr[0, 0] = s_deter;
            matr[0, 1] = 0;
            matr[1, 0] = 0;
            matr[1, 1] = 1;
            deter = s_deter;
        }
        public int GetDeter()
        {
            return deter;
        }
        private void SetDeter()
        {
            deter = matr[0, 0] * matr[1, 1] - matr[1, 0] * matr[0, 1];
        }
    }
}
