using System;

namespace ByndyusoftInternship
{
    public class ArrayHelper
    {
        public static int GetMinSum(int[] arr)
        {
            if ((arr?.Length ?? 0) < 2) throw new ArgumentException();

            ref int _FirstMinValue = ref ((arr[0] <= arr[1]) ? ref arr[0] : ref arr[1]);
            ref int _SecondMinValue = ref ((arr[1] > arr[0]) ? ref arr[1] : ref arr[0]);

            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] < _FirstMinValue)
                {
                    _SecondMinValue = ref _FirstMinValue;
                    _FirstMinValue = ref arr[i];
                }
                else if (arr[i] < _SecondMinValue)
                {
                   _SecondMinValue = ref arr[i];
                }
            }

            return checked(_FirstMinValue + _SecondMinValue);
        }
    }
}
