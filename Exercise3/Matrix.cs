using System.Text;

namespace CSharp.Exercise3
{
    public class Matrix
    {
        int[,] matrix;

        public Matrix(int n, int m)
        {
            matrix = new int[n, m];
        }

        public int N
        {
            get { return matrix.GetLength(0); }
        }

        public int M
        {
            get { return matrix.GetLength(1); }
        }

        public int this[int idxn, int idxm]
        {
            get { return matrix[idxn, idxm]; }
            set { matrix[idxn, idxm] = value; }
        }

        static public Matrix operator +(Matrix lhs, Matrix rhs)
        {
            if(lhs.N != rhs.N || lhs.M != rhs.M) return null;

            Matrix result = new Matrix(lhs.N, lhs.M);

            for(int i = 0; i < lhs.N; ++i){
                for(int j = 0; j < lhs.M; ++j){
                    result[i, j] = lhs[i, j] + rhs[i, j];
                }
            }

            return result;
        }

        public override string ToString(){
            if(this == null) return "";
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i < this.N; i++){
                for(int j = 0; j < this.M; j++){
                    builder.Append(this[i, j] + " ").ToString();
                }
                builder.Append("\n");
            }
            string result = builder.ToString();
            return result;
        }
    }
}