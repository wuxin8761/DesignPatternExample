namespace _10.模版方法模式;

// 2. 实现具体子类
// 战士角色加载器
public class WarriorLoader : CharacterLoader
{
    protected override void LoadSkills()
    {
        Console.WriteLine("加载战士专属技能：冲锋、斩击");
    }
}