//int[] arr = new int[5];
//arr[0] = 10;
//arr[1] = 20;
//arr[2] = 30;
//arr[3] = 40;
//arr[4] = 50;

//for(int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

//int[] arr2 = new int[5];

//for (int i = 0; i < arr2.Length; i++)
//{
//    Console.WriteLine("Enter Numbers");
//    arr2[i] = int.Parse(Console.ReadLine());
//}
//    for (int i = 0; i < arr2.Length; i++)
//    {
//        Console.WriteLine(arr2[i] + "\t");
//    }
//int[,]arr2= new int[3,4];
//for(int i=0; i<3; i++)
//{
//    for(int j=0; j<4; j++)
//    {
//        Console.WriteLine("Enter Number");
//        arr2[i,j]=int.Parse(Console.ReadLine());
//    }
//}

//for(int i=0; i<3; i++)
//{
//    for(int j=0; j<4; j++)
//    {
//        if(arr2[i,j]%5==0)
//        {
//            Console.Write("*\t");
//        }
//        else
//        {
//            Console.Write(arr2[i,j]+"\t");
//        }

//    }
//    Console.WriteLine(" ");
//}


//int[,]arr2= new int[3,4];
//for(int i=0; i<3; i++)
//{
//    for(int j=0; j<4; j++)
//    {
//        Console.WriteLine("Enter Number");
//        arr2[i,j]=int.Parse(Console.ReadLine());
//    }
//}

//for(int i=0; i<3; i++)
//{
//    for(int j=0; j<4; j++)
//    {
//        if(arr2[i,j]%5==0)
//        {
//            Console.Write("*\t");
//        }
//        else
//        {
//            Console.Write(arr2[i,j]+"\t");
//        }

//    }
//    Console.WriteLine(" ");
//}
int row = 3;
int col = 4;
for (int i = 0; i < row; i++)
{
   
    for (int j = 0; j < col; j++)
    {
       
        if (i == 0 || i == row-1 || j == 0 || j == col-1)
        {
            Console.Write("*\t");
        }
        else
        {
            Console.Write("\t");
        }
    }
    Console.Write("\n");
}