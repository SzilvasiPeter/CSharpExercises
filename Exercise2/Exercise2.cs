using System;

namespace CSharp.Exercise2
{
    public class Exercise2
    {

        static double avarage(double[,] array, int index){
            double sum = 0;
            for(int i = 0; i < array.GetLength(1); i++){
                sum += array[index, i];
                System.Console.WriteLine(array[index, i]);
            }
            //System.Console.WriteLine(sum/array.GetLength(1));
            return sum / array.GetLength(1);
        }

        static int min(double[] array){
            int minIdx = 0;
            for(int i = 1; i < array.Length; i++){
                if(array[minIdx] > array[i]){
                    minIdx = i;
                }
            }
            return minIdx;
        }

        static int max(double[] array){
            int maxIdx = 0;
            for(int i = 1; i < array.Length; i++){
                if(array[maxIdx] < array[i]){
                    maxIdx = i;
                }
            }
            return maxIdx;
        }
        static double[] minAndMax(double[] array){
            double min = 1000;
            double max = -1;
            int minIdx = 0;
            int maxIdx = 0;

            for(int i = 0; i < array.Length; i++){
                if(array[i] < min){
                    min = array[i];
                    minIdx = i;
                }

                if(array[i] > max){
                    max = array[i];
                    maxIdx = i;
                }
            }
            
            double[] minMax = {array[minIdx], array[maxIdx]};
            return minMax;
        }

        static void island(){
            System.Console.WriteLine("1: island, 0: ocean");
            string data = Console.ReadLine();
            
            int isLandCount = 0;
            int maxIsLandLength = 0;
            int i = 0;

            while(i < data.Length){
                if(data[i] == '1'){
                    isLandCount++;
                    int j = i;
                    int tmp = 0;

                    while(j < data.Length && data[j] == '1'){
                        ++j;
                        ++tmp;
                    }

                    i = j;

                    if(tmp > maxIsLandLength)
                        maxIsLandLength = tmp;
                }else{
                    ++i;
                }
            }

            System.Console.WriteLine("Max island length: " + maxIsLandLength);
            System.Console.WriteLine("Island number: " + isLandCount);
        }

        static void temperature(){
            Random r = new Random();
            double MIN = -20;
            double MAX = 30;
            double[,] days = new double[12,30];
            for(int i = 0; i < 12; i++){
                for(int j = 0; j < 30; j++){
                    days[i,j] = r.NextDouble() * (MAX - MIN) + MIN;
                }
            }

            int minXIndex = 0;
            int minYIndex = 0;

            int maxXIndex = 0;
            int maxYIndex = 0;

            int minusCount = 0;
            bool fiveMinusInAMonth = false;
            
            double[] monthsAvarage = new double[12];
            for(int i = 0; i < 12; i++){
                for(int j = 1; j < 30; j++){
                    if(days[i,j] < days[minXIndex,minYIndex]){
                        minXIndex = i;
                        minYIndex = j;
                    }

                    if(days[i,j] >= days[maxXIndex,maxYIndex]){
                        maxXIndex = i;
                        maxYIndex = j;
                    }
                    if(days[i,j] < 0){
                        minusCount++;
                        if(minusCount >= 5){
                            fiveMinusInAMonth = true;
                        }
                    }else{
                        minusCount = 0;
                    }
                }
                monthsAvarage[i] = avarage(days, i);
            }

            System.Console.WriteLine("The year minimum temperature: " + days[minXIndex, minYIndex]);
            System.Console.WriteLine("The year maximum temperature: " + days[maxXIndex, maxYIndex]);

            System.Console.WriteLine("The year coolest month: " + min(monthsAvarage));
            System.Console.WriteLine("The year warmest month: " + max(monthsAvarage));

            System.Console.WriteLine("Below zero temperature for five days in a row: " + fiveMinusInAMonth);
        }
        static void Main(string[] args)
        {
            // int[] array = {2,4,6,1,3,7,21,43,2,65,213,0,5,2,1,5};
            // int[] minmax;
            // minmax = minAndMax(array);

            // System.Console.WriteLine(array[minmax[0]] + " " + array[minmax[1]]);

            // island();

            temperature();
        }
    }
}