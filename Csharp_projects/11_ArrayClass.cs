class Program{
    static void Main(string[] args){
        int [] arr= new int[]{2,3,11,4,5,7};

        DisplaySort(arr);
        DisplayIndex(arr);
        DisplayCopy(arr);
    }
    static void DisplaySort(int[] a){
        Array.Sort(a);
        Console.WriteLine("sorted array:\t");
        foreach(int i in a){
            Console.Write(" "+i);
        }}
        static void DisplayIndex(int[] ind){
       int index=Array.IndexOf(ind,5);
       Console.WriteLine("Index of 5 is:\t"+ index);
        }
        static void DisplayCopy(int[] cop)
        {
            int [] newarr=new int[cop.Length];
            Array.Copy(cop,newarr,cop.Length);
            Console.WriteLine("For Coy array");
            foreach(int c in newarr)
            
            {
                Console.Write(" "+c);
            }

        }
    }
