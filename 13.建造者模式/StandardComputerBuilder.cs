namespace _13.建造者模式;

// 3. 具体建造者：StandardComputerBuilder
public class StandardComputerBuilder : IComputerBuilder
{
    private Computer _computer = new(); //  = new Computer(); 推荐在 C# 9+ 中使用，更简洁

    public IComputerBuilder SetCPU(string cpu)
    {
        _computer.CPU = cpu;
        return this;
    }

    public IComputerBuilder SetRAM(string ram)
    {
        _computer.RAM = ram;
        return this;
    }

    public IComputerBuilder SetHardDrive(string hardDrive)
    {
        _computer.HardDrive = hardDrive;
        return this;
    }

    public IComputerBuilder SetGraphicsCard(string graphicsCard)
    {
        _computer.GraphicsCard = graphicsCard;
        return this;
    }

    public Computer Build()
    {
        return _computer;
    }
}