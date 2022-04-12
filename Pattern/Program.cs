//int row = 5;
//int col = 4;
//for (int i = 0; i < row; i++)
//{

//    for (int j = 0; j < col; j++)
//    {

//        if ( i == row - 1 ||  j == 0)
//        {
//            Console.Write("*\t");
//        }
//        else
//        {
//            Console.Write("\t");
//        }
//    }
//    Console.Write("\n");
//}

//int row = 5;
//int col = 4;
//for (int i = 0; i < row; i++)
//{

//    for (int j = 0; j < col; j++)
//    {

//        if (i == row - 1 || j == col-1)
//        {
//            Console.Write("*\t");
//        }
//        else
//        {
//            Console.Write("\t");
//        }
//    }
//    Console.Write("\n");
//}

int row = 10;
int col = 5;
for (int i = 0; i < row; i++)
{

    for (int j = 0; j < col; j++)
    {

        if (i==0 || i == (row/2)-1  ||j==0  || j==col-1 && i<row/2)
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
    



