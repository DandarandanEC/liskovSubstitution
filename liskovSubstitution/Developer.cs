using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace liskovSubstitution
{

    #region Developer CLASS
    class Developer
    {
        public string name { get; set; }

        public string company { get; set; }

        public Developer(string name, string company) {
            this.name = name;
            this.company = company;
        }

        public void createHtml()
        {
            Console.WriteLine("I create wonderful User Interfaces");
        }

        public void createDatabaseTable()
        {
            Console.WriteLine("I create Normalized Database Tables");
        }

        public void createCICDPipelines()
        {
            Console.WriteLine("I automate deployments");
        }

        public void createEndpoints()
        {
            Console.WriteLine("I create Restful APIs");
        }
    }
    #endregion

    #region FrontEndDeveloper CLASS
    class FrontEndDeveloper
    {
        public string name { get; set; }

        public string company { get; set; }

        public FrontEndDeveloper(string name, string company)
        {
            this.name = name;
            this.company = company;
        }

        public static FrontEndDeveloper CreateFrontEndDeveloper(string name, string company)
        {
            return new FrontEndDeveloper(name, company);
        }

        public void createHtml()
        {
            Console.WriteLine($"I am {name} from {company} and I make wonderful User Interfaces");
        }
    }
    #endregion

    #region BackEndDeveloper CLASS
    class BackEndDeveloper
    {
        public string name { get; set; }

        public string company { get; set; }

        public BackEndDeveloper(string name, string company)
        {
            this.name = name;
            this.company = company;
        }

        public static BackEndDeveloper CreateBackeEndDeveloper(string name, string company)
        {
            return new BackEndDeveloper(name, company);
        }

        public void createEndpoints()
        {
            Console.WriteLine($"I am {name} from {company} and I create Restful APIs");
        }

        public void createDatabaseTable()
        {
            Console.WriteLine($"I am {name} from {company} and I create Normalized Database Tables");
        }
    }
    #endregion

    #region DevOpsEngineer CLASS
    class DevOpsEngineer
    {
        public string name { get; set; }

        public string company { get; set; }

        public DevOpsEngineer(string name, string company)
        {
            this.name = name;
            this.company = company;
        }

        public static DevOpsEngineer CreateDevOpsEngineerDeveloper(string name, string company)
        {
            return new DevOpsEngineer(name, company);
        }

        public void createCICDPipelines()
        {
            Console.WriteLine($"I am {name} from {company} and I automate deployments");
        }
    }
    #endregion

    #region FullStackDeveloper CLASS
    class FullStackDeveloper : Developer
    {
        public void icreateHtml()
        {
            Console.WriteLine($"I am {name} from {company} and I create wonderful User Interfaces");
        }

        public void icreateDatabaseTable()
        {
            Console.WriteLine($"I am {name} from {company} and I create Normalized Database Tables");
        }

        public void icreateCICDPipelines()
        {
            Console.WriteLine($"I am {name} from {company} and I automate deployments");
        }

        public void icreateEndpoints()
        {
            Console.WriteLine($"I am {name} from {company} and I create Restful APIs");
        }
        public FullStackDeveloper(string name, string company) : base(name, company)
        {
            
        }

        public void createFullStackDeveloper()
        {
            //Console.WriteLine($"I am {name} from {company} and I develop full-stack applications");
            icreateHtml();
            icreateDatabaseTable();
            icreateCICDPipelines();
            icreateEndpoints();
        }
    }
    #endregion

    #region ReactDeveloper CLASS w/ FrontEndDeveloper BASE CLASS
    class ReactDeveloper : FrontEndDeveloper
    {
        public ReactDeveloper (string name, string company) : base (name, company)
        {

        }

        public void createReactComponent()
        {
            Console.WriteLine("As a ReactDeveloper: I create React components");
        }
    }
    #endregion

    #region NodeJSDeveloper CLASS w/ BackEndDeveloper BASE CLASS
    class NodeJSDeveloper : BackEndDeveloper
    {
        public NodeJSDeveloper(string name, string company) : base(name, company)
        {

        }

        public void createNodeJSComponent()
        {
            Console.WriteLine("As a NodeJSDeveloper: I create NodeJS components");
        }
    }
    #endregion

    #region JenkinksDevOpsEngineer CLASS w/ DevOpsEngineer BASE CLASS
    class JenkinksDevOpsEngineer : DevOpsEngineer
    {
        public JenkinksDevOpsEngineer(string name, string company) : base(name, company)
        {

        }

        public void createJenkinksComponent()
        {
            Console.WriteLine("As a JenkinksEngineer: I create Jenkinks components");
        }
    }
    #endregion


}
