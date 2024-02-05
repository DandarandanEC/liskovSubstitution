using liskovSubstitution;

class Program
{
    static void MakeFrontEndDeveloperCreateHTML(FrontEndDeveloper developer)
    {
        developer.createHtml();
    }

    static void MakeBackEndDeveloperCreateAPI(BackEndDeveloper developer)
    {
        developer.createDatabaseTable();
        developer.createEndpoints();
    }

    static void MakeDevOpsEngineerCreateCICDPipelines(DevOpsEngineer developer)
    {
        developer.createCICDPipelines();
    }

    static void MakeFullStackDeveloper(FullStackDeveloper developer)
    {
        developer.createFullStackDeveloper();
    }


    static void Main(string[] args)
    {
        ReactDeveloper reactDev = new ReactDeveloper("John", "ABC Inc.");
        NodeJSDeveloper nodeJSDev = new NodeJSDeveloper("Dan", "ABC Inc.");
        JenkinksDevOpsEngineer jenkinksDev = new JenkinksDevOpsEngineer("Edward", "ABC Inc.");

        Console.WriteLine("FrontEndDeveloper:");        
        var frontEndDev = FrontEndDeveloper.CreateFrontEndDeveloper("John", "ABC Inc.");
        frontEndDev.createHtml();
        Console.WriteLine();

        Console.WriteLine("ReactDeveloper:");
        MakeFrontEndDeveloperCreateHTML(reactDev);
        Console.WriteLine();

        Console.WriteLine("NodeJSDeveloper:");
        MakeBackEndDeveloperCreateAPI(nodeJSDev);
        Console.WriteLine();

        Console.WriteLine("JenkinksDevOpsEngineer:");
        MakeDevOpsEngineerCreateCICDPipelines(jenkinksDev);
        Console.WriteLine();

        Console.WriteLine("FullStackDeveloper:");
        FullStackDeveloper fullStackDeveloper = new FullStackDeveloper("Dan Edward", "ABC Inc.");
        fullStackDeveloper.createFullStackDeveloper();
    }
}