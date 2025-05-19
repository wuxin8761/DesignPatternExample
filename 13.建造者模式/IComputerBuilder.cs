namespace _13.建造者模式;

// 2. Builder 抽象接口
public interface IComputerBuilder
{
    IComputerBuilder SetCPU(string cpu);
    IComputerBuilder SetRAM(string ram);
    IComputerBuilder SetHardDrive(string hardDrive);
    IComputerBuilder SetGraphicsCard(string graphicsCard);
    Computer Build();
}