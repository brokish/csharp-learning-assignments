namespace Assigment7_CarManagment.Services;

public class RefParamAssigment
{
    public void SwapNumbers(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}