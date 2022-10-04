// int Max(int arg1, int arg2, int arg3)
// {
//     int big = arg1;
//     if(arg2 > big) big = arg2;
//     if(arg3 > big) big = arg3;
//     return big;
// }

// int a1 = 1225;
// int b1 = 2431;
// int c1 = 3695;
// int a2 = 1428;
// int b2 = 6233;
// int c2 = 8330;
// int a3 = 2398;
// int b3 = 1213;
// int c3 = 3303;

// int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
// Console.Write(max);
Console.Clear();

int Min(int arg1, int arg2, int arg3)
{
    int small = arg1;
    if(arg2 < small) small = arg2;
    if(arg3 < small) small = arg3;
    return small;
}

int a1 = 1225;
int b1 = 2431;
int c1 = 3695;
int a2 = 1428;
int b2 = 6233;
int c2 = 8330;
int a3 = 2398;
int b3 = 1213;
int c3 = 3303;

int min = Min(Min(a1, b1, c1), Min(a2, b2, c2), Min(a3, b3, c3));
Console.Write(min);