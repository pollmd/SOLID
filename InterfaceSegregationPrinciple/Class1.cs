using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    public interface IProgrammer
    {
        void WorkOnTask();
    }

    public interface ILead 
    {
        void CreateSubTask();
        void AssingTask();
    }

    public class Lead : ILead
    {
        public void AssingTask() 
        { 
        }
        

        public void CreateSubTask()
        {
        }     
    }

    public class Programmer : IProgrammer
    {
        public void WorkOnTask()
        {
            //implementare
        }
    }

    public class TeamLead : ILead, IProgrammer
    {
        public void AssingTask()
        {
        }

        public void CreateSubTask()
        {
        }

        public void WorkOnTask()
        {
        }
    }
}
