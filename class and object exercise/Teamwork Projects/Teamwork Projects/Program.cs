using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int countRegisters = int.Parse(Console.ReadLine());
            List<TeamProject> project = new List<TeamProject>();

            for (int i = 0; i < countRegisters; i++)
            {   
               
                string[] input = Console.ReadLine().Split("-");

                string creator = input[0];
                string team = input[1];

                TeamProject newProject = new TeamProject(creator, team);
                var containTeamand = project.Where(x=>x.Team == team).ToList();
                if (containTeamand.Count > 0)
                {
                    newProject.CantCreateAnotherTeam();
                }
                else
                {
                    var containUser = project.Where(x => x.User == creator).ToList();
                    if (containUser.Count > 0)
                    {
                        foreach (var item in containUser)
                        {
                            newProject.isAllreadyExist();
                        }
                    }
                    else
                    {
                        project.Add(newProject);
                        newProject.CreateTeam();
                    }
                }
             
             
                

            }
            while (true)
            {
                string[] input = Console.ReadLine().Split("->");
                if(input[0]== "end of assignment")
                {
                    break;
                }

                string creator = input[0];
                string team = input[1];
                TeamProject newProject = new TeamProject(creator, team);
                var containUser = project.Where(x => x.User == creator).ToList();
                if (containUser.Count > 0)
                {
                    for (int i = 0; i < containUser.Count; i++)
                    {
                        newProject.CantCreateAnotherTeam();
                    }
                }
                else
                {
                    var isContaintTeam = project.Where(x => x.Team == team).ToList();
                    if (isContaintTeam.Count > 0)
                    {
                        project.Add(newProject);
                        newProject.CreateTeamSecond();
                    }
                    else
                    {
                        newProject.IsContaintTeam();
                    }
                    
                  

                }
            }
           
        }

    }

    class TeamProject
    {
        public string User { get; set; }
        public string Team { get; set; }
      
        

        public TeamProject(string user,string team)
        {
            this.User = user;
            this.Team = team;
        }

        public void CreateTeam()
        {
            Console.WriteLine($"Team {this.Team} has been created by {this.User}!");
            
        }
        public void isAllreadyExist()
        {
            Console.WriteLine($"{this.User} cannot create another team!");
        }

        public void CantCreateAnotherTeam()
        {
            Console.WriteLine($"{this.User} cannot create another team!");
        }
        public void CreateTeamSecond()
        {
            Console.WriteLine(this.Team);
        }
        public void IsContaintTeam()
        {
            Console.WriteLine($"Team {this.Team} does not exist!");
        }
        public void AllReadyCreateTeam()
        {
            Console.WriteLine($"Team {this.Team} was already created!");
        }
       
    }

}
