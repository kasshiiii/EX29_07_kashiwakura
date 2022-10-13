//まとめたバージョン
using System;

public class VariousSolids_Custom
{
    static void Main()
    {
        float value1 = 0, value2 = 0, value3 = 0;
        Console.WriteLine("直方体");
        value1 = InputFloat("幅を入力してください");
        value2 = InputFloat("高さを入力してください");
        value3 = InputFloat("奥行きを入力してください");
        Console.WriteLine("表面積 = " + Box.GetSurface(value1, value2, value3) + "\n体積 = " + Box.GetVolume(value1, value2, value3));

        Console.WriteLine("\n円柱");
        value1 = InputFloat("底面の半径を入力してください");
        value2 = InputFloat("高さを入力してください");
        Console.WriteLine("表面積 = " + Cylinder.GetSurface(value1, value2) + "\n体積 = " + Cylinder.GetVolume(value1, value2));

        Console.WriteLine("\n球");
        value1 = InputFloat("半径を入力してください");
        Console.WriteLine("表面積 = " + Sphere.GetSurface(value1) + "\n体積 = " + Sphere.GetVolume(value1));

        Console.WriteLine("\n三角柱");
        value1 = InputFloat("底面の底辺を入力してください");
        value2 = InputFloat("底面の高さを入力してください");
        value3 = InputFloat("高さを入力してください");
        Console.WriteLine("表面積 = " + TriangularPrism.GetSurface(value1, value2, value3) + "\n体積 = " + TriangularPrism.GetVolume(value1, value2, value3));
    }

    static float InputFloat(string outputString)
    {
        float input;
        while (true)
        {
            Console.WriteLine(outputString);
            if (float.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
        }
    }
}
static class Box
{
    public static float GetSurface(float width, float height, float depth)
    {
        return (width * height + width * depth + height * depth) * 2.0f;
    }
    public static float GetVolume(float width, float height, float depth)
    {
        return width * height * depth;
    }
}

static class Cylinder
{
    static public float GetSurface(float bottom, float height)
    {
        return bottom * 2.0f * MathF.PI * height + bottom * bottom * MathF.PI * 2.0f;
    }
    static public float GetVolume(float bottom, float height)
    {
        return bottom * bottom * MathF.PI * height;
    }
}

static class Sphere
{
    static public float GetSurface(float radius)
    {
        return 4.0f * MathF.PI * radius * radius;
    }
    static public float GetVolume(float radius)
    {
        return (4.0f / 3.0f) * MathF.PI * radius * radius * radius;
    }
}

static class TriangularPrism
{
    static public double GetSurface(float bottom, float bottomHeight, float height)
    {
        return bottom * bottomHeight + (bottom + bottomHeight + Math.Sqrt(bottom * bottom + bottomHeight * bottomHeight)) * height;
    }
    static public float GetVolume(float bottom, float bottomHeight, float height)
    {
        return bottom * bottomHeight / 2.0f * height;
    }
}


//分かれてるバージョン
/*
using System;

public class VariousSolids_Custom
{
    static void Main()
    {
        Console.WriteLine("直方体");
        Console.WriteLine("表面積 = " + Box.GetSurface(InputFloat("幅を入力してください"), InputFloat("高さを入力してください"), InputFloat("奥行きを入力してください")));
        Console.WriteLine("体積 = " + Box.GetVolume(InputFloat("幅を入力してください"), InputFloat("高さを入力してください"), InputFloat("奥行きを入力してください")));

        Console.WriteLine("\n円柱");
        Console.WriteLine("表面積 = " + Cylinder.GetSurface(InputFloat("底面の半径を入力してください"), InputFloat("高さを入力してください")));
        Console.WriteLine("体積 = " + Cylinder.GetSurface(InputFloat("底面の半径を入力してください"), InputFloat("高さを入力してください")));

        Console.WriteLine("\n球");
        Console.WriteLine("表面積 = " + Sphere.GetSurface(InputFloat("半径を入力して下さい")));
        Console.WriteLine("体積 = " + Sphere.GetVolume(InputFloat("半径を入力して下さい")));

        Console.WriteLine("\n三角柱");
        Console.WriteLine("表面積 = " + TriangularPrism.GetSurface(InputFloat("底面の底辺を入力して下さい"), InputFloat("底面の高さを入力して下さい"), InputFloat("高さを入力して下さい")));
        Console.WriteLine("体積 = " + TriangularPrism.GetVolume(InputFloat("底面の底辺を入力して下さい"), InputFloat("底面の高さを入力して下さい"), InputFloat("高さを入力して下さい")));

    }

    static float InputFloat(string outputString)
    {
        float input;
        while (true)
        {
            Console.WriteLine(outputString);
            if (float.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
        }
    }
}
static class Box
{
    public static float GetSurface(float width, float height, float depth)
    {
        return (width * height + width * depth + height * depth) * 2.0f;
    }
    public static float GetVolume(float width, float height, float depth)
    {
        return width * height * depth;
    }
}

static class Cylinder
{
    static public float GetSurface(float bottom, float height)
    {
        return bottom * 2.0f * MathF.PI * height + bottom * bottom * MathF.PI * 2.0f;
    }
    static public float GetVolume(float bottom, float height)
    {
        return bottom * bottom * MathF.PI * height;
    }
}
 
static class Sphere
{
    static public float GetSurface(float radius)
    {
        return 4.0f * MathF.PI * radius * radius;
    }
    static public float GetVolume(float radius)
    {
        return (4.0f / 3.0f) * MathF.PI * radius * radius * radius;
    }
}

static class TriangularPrism
{
    static public double GetSurface(float bottom,float bottomHeight,float height)
    {
        return bottom * bottomHeight + (bottom + bottomHeight + Math.Sqrt(bottom * bottom + bottomHeight * bottomHeight)) * height;
    }
    static public float GetVolume(float bottom, float bottomHeight, float height)
    {
        return bottom * bottomHeight / 2.0f * height;
    }
}
*/