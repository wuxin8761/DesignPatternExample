namespace _10.模版方法模式;

// 1. 定义抽象类（模板）
// 抽象类，定义算法骨架和固定步骤
public abstract class CharacterLoader
{
    // 模板方法，定义算法骨架
    public void LoadCharacter()
    {
        LoadModel();
        LoadAnimations();
        LoadSkills(); // 可变部分
        InitializeUI();
    }

    // 固定步骤
    private void LoadModel()
    {
        Console.WriteLine("加载模型资源...");
    }

    private void LoadAnimations()
    {
        Console.WriteLine("加载动画资源...");
    }

    private void InitializeUI()
    {
        Console.WriteLine("初始化UI组件...");
    }

    // 可变步骤（由子类实现）
    protected abstract void LoadSkills();
}