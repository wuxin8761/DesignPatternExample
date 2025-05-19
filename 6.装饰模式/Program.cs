using _6.装饰模式;

// 5. 使用示例
ILogger logger = new ConsoleLogger();
logger.Log("用户登录");

// 加上时间戳的日志
// TimestampLoggerDecorator 实际上使用的是 ConsoleLogger的Log方法，
// 只不过在其基础上进行了装饰，添加了时间戳
ILogger timestampLogger = new TimestampLoggerDecorator(new ConsoleLogger());
timestampLogger.Log("用户登出");

// 同时输出控制台并写入文件
// 先添加时间戳，又再其基础上进行装饰，输出到控制台并写入文件
ILogger fullLogger = new FileLoggerDecorator(
    new TimestampLoggerDecorator(new ConsoleLogger()));
fullLogger.Log("系统重启");
