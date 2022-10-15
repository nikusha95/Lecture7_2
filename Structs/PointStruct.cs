namespace Structs;

public struct PointStruct
{
    public int x; //.
    public int y; //.


    public PointStruct(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public double Distance(int x1, int y1)
    {
        return Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2));
    }

}