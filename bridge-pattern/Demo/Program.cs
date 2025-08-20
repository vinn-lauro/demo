using Sample;

namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        BaseAbstraction flexible = new RefinedAbstraction();
        flexible.Implementation = new ImplementationA();
        flexible.Operation();
        flexible.Implementation = new ImplementationB();
        flexible.Operation();


        string platform = "linux";
        ILogger logger = new Logger();
        switch (platform)
        {
            case "windows":
                logger.Module = new WindowsLog();
                break;
            case "linux":
                logger.Module = new LinuxLog();
                break;
            default:
                throw new Exception("Unknown Operation System");
        }

        logger.Log("Success");

    }
}