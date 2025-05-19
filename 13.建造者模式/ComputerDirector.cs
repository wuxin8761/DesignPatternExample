namespace _13.建造者模式;

// 4. 指挥者（Director）类（可选）
public class ComputerDirector
{
    public void BuildGamingComputer(IComputerBuilder builder)
    {
        builder.SetCPU("Intel i9")
            .SetRAM("64GB")
            .SetHardDrive("2TB SSD")
            .SetGraphicsCard("NVIDIA RTX 4080");
    }

    public void BuildOfficeComputer(IComputerBuilder builder)
    {
        builder.SetCPU("Intel i5")
            .SetRAM("16GB")
            .SetHardDrive("512GB SSD")
            .SetGraphicsCard("Integrated Graphics");
    }
}