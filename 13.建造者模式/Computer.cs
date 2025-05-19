namespace _13.建造者模式;

// 1. Product 类：Computer
public class Computer
{
    public string CPU { get; set; }
    public string RAM { get; set; }
    public string HardDrive { get; set; }
    public string GraphicsCard { get; set; }

    public override string ToString()
    {
        return $"CPU: {CPU}, RAM: {RAM}, HardDrive: {HardDrive}, GraphicsCard: {GraphicsCard}";
    }
}