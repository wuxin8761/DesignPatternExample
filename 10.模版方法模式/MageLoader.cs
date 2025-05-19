namespace _10.模版方法模式;

// 法师角色加载器
public class MageLoader : CharacterLoader
{
    protected override void LoadSkills()
    {
        Console.WriteLine("加载法师专属技能：火球术、冰冻术");
    }
}