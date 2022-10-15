namespace Structs;

public class PointClass
{
    public int x; //.
    public int y; //.


    public PointClass(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public double Distance(int x1, int y1)
    {
        return Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2));
    }

    public void Test()
    {
        //TODO
    }
}