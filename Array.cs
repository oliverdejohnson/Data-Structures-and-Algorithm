Public Class ArrayUtil
{

static void PrintArray(int[] myArray)
        {
            foreach (int i in myArray) Console.Write(i + "\t");
        }

 /// <summary>
        /// Takes two sorted arrays and produce a merge of sorted arrays
        /// </summary>
        /// <param name="sArray1"></param>
        /// <param name="sArray2"></param>
        /// <returns></returns>
        static int[] MergeSortedArrays(int[] sArray1, int[] sArray2)
        {
            int sizeOfMergedArray = sArray1.Length + sArray2.Length;

            int[] MergedArray = new int[sizeOfMergedArray];

            int i = 0, j = 0, k = 0;// starting indexes of s1,s2,and m arrays

            while (i < sArray1.Length && j < sArray2.Length)
            {
                if (sArray1[i] < sArray2[j])
                {
                    MergedArray[k] = sArray1[i];
                    i++;

                }
                else
                {
                    MergedArray[k] = sArray2[j];
                    j++;

                }

                k++;
            }

            //edge cases of Sarray1
            while (i < sArray1.Length) { MergedArray[k] = sArray1[i]; i++; k++; }

            while (j < sArray2.Length) { MergedArray[k] = sArray2[j]; j++; k++; }

            return MergedArray;
        }
        
        /// <summary>
    /// Swaps the elements in position i and j in the given array
    /// </summary>
    /// <param name="i"></param>
    /// <param name="j"></param>
    /// <param name="myarray"></param>
    static void SwapElements(int i, int j, ref int[] myarray)
    {
        int temp = myarray[i];
        myarray[i] = myarray[j];
        myarray[j] = temp;
    }
    
    /// <summary>
    /// A recursive implementation of the Merge Sort Algorithm in C#
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="l"></param>
    /// <param name="r"></param>
    /// <returns></returns>
    static int[] MergeSort(int[] arr, int l, int r)
    {
        int[] result = new int[arr.Length];
        if (l < r)
        {
            // Find the middle point
            int m = (l + r) / 2;

            // Sort first and second halves
            MergeSort(arr, l, m);
            MergeSort(arr, m + 1, r);

            // Merge the sorted halves
           result =  Merge(arr, l, m, r);
        }

        return result;
    }

    static int[] Merge(int[] arr, int l, int m, int r)
    {
        // Find sizes of two subarrays to be merged
        int n1 = m - l + 1;
        int n2 = r - m;

        int[] arr2 = new int[arr.Length];

        /* Create temp arrays */
        int[] L = new int[n1];
        int[] R = new int[n2];

        /*Copy data to temp arrays*/
        for (int ii = 0; ii < n1; ++ii)
            L[ii] = arr[l + ii];
        for (int jj = 0; jj < n2; ++jj)
            R[jj] = arr[m + 1 + jj];


        /* Merge the temp arrays */

        // Initial indexes of first and second subarrays
        int i = 0, j = 0;

        // Initial index of merged subarry array
        int k = l;
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr2[k] = L[i];
                i++;
            }
            else
            {
                arr2[k] = R[j];
                j++;
            }
            k++;
        }

        /* Copy remaining elements of L[] if any */
        while (i < n1)
        {
            arr2[k] = L[i];
            i++;
            k++;
        }

        /* Copy remaining elements of R[] if any */
        while (j < n2)
        {
            arr2[k] = R[j];
            j++;
            k++;
        }

        return arr2;
        
    }
    
    static bool IsElementsUnique(int[] inArray)
        {
            bool result = false;
            int found = 0;

            for (int i = 0; i < inArray.Length; i++)
                for (int j = i + 1; j < inArray.Length; j++)
                {
                    if (inArray[i] == inArray[j]) found++;
                }

            if (found > 0) result = true;

            return result;
        }
        
        
        
        static bool IsElementsUnique2(int[] inArray)
        {
            bool foundDup = false;
            HashSet<int> myHashSet = new HashSet<int>();

            for (int i = 0; i < inArray.Length; i++)
            {
                if (!myHashSet.Add(inArray[i])) foundDup = true;
            }

            return foundDup;
        }

        static bool IsElementsUnique3(int[] inArray)
        {
            bool dupExist = true;
            HashSet<int> myHashSet = new HashSet<int>(inArray);

            if (inArray.Length == myHashSet.Count()) dupExist = false;


            return dupExist;
        }
       
        
         static string ReverseString(string somestring)
        {
            // string newSentence = string.Empty;
            string s = somestring;
            char[] chrArray = s.ToCharArray();
            Array.Reverse(chrArray);

            return new string(chrArray);
        }

        static string Reverse(string s)
        {
            string s1 = s;
            int n = s1.Length;
            StringBuilder sb = new StringBuilder(s1);
            for (int i = 0; i < (n >> 1); ++i)
            {
                char c = sb[i];
                sb[i] = sb[n - 1 - i];
                sb[n - 1 - i] = c;
            }
            return sb.ToString();
        }

        static string Reverse2(string s)
        {
            string s1 = s;
            int n = s1.Length;
            char[] sb = s1.ToCharArray();
            for (int i = 0; i < (n >> 1); ++i)  //most efficient
            {
                char c = sb[i];
                sb[i] = sb[n - 1 - i];
                sb[n - 1 - i] = c;
            }
            return new string(sb);
        }

        static string Reverse3(string s)
        {
            string s1 = s;
            int n = s1.Length;
            char[] sb = s1.ToCharArray();
            for (int i = 0; i < n; ++i)
            {
                char c = sb[i];
                sb[i] = sb[n - 1 - i];
                sb[n - 1 - i] = c;
            }
            return new string(sb);
        }

        static bool IsPalindrome(string mystring)
        {
            if (mystring.Equals(ReverseString(mystring))) return true;
            else return false;
        }




}
