﻿using EwidencjaZlecen.App.Common;
using EwidencjaZlecen.Domain.Entity;
using EwidencjaZlecen.Domain
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EwidencjaZlecen.App.Concrete
{
    public class JobService : BaseService<Job>
    {

        //public int SearchJobByIdView()
        //{
        //    Console.WriteLine("Proszę o wskazanie ID roboty do odnalezienia");
        //    var actionSearch = Console.ReadLine();
        //    Int32.TryParse(actionSearch.ToString(), out int id);
        //    return id;
        //}
        //public void SearchJobById(int searchJob)
        //{
        //    Job jobToFind = new Job(); //Inicjalizujemy produkt żeby nie wywaliło null
        //    foreach (var job in Jobs)
        //    {
        //        if (job.Id == searchJob)
        //        {
        //            jobToFind = job;
        //            break;
        //        }
        //    }
        //    Console.WriteLine($"Robota o ID: {jobToFind.Id} i nazwie {jobToFind.Name} wykonywana jest dla {jobToFind.Client} i została ostatnio zmodyfikowana {jobToFind.ModifyDate}");
        //}

        //public string SearchJobByClientView()
        //{
        //    Console.WriteLine("Proszę o wpisanie nazwiska i imienia klienta do odnalezienia");
        //    string actionSearch = Console.ReadLine();
        //    return actionSearch;
        //}
        //public void SearchJobByClient(string searchJobClient)
        //{
        //    Job jobToFindClient = new Job(); //Inicjalizujemy produkt żeby nie wywaliło null
        //    foreach (var job in Jobs)
        //    {
        //        if (job.Client == searchJobClient)
        //        {
        //            jobToFindClient = job;
        //            Console.WriteLine($"Robota o ID: {jobToFindClient.Id} i nazwie {jobToFindClient.Name} wykonywana jest dla {jobToFindClient.Client} i została ostatnio zmodyfikowana {jobToFindClient.ModifyDate}");
        //        }
        //    }
        //}

        //public void ListJobs()
        //{
        //    Job listOfJobs = new Job();
        //    foreach (var job in Jobs)
        //    {
        //        listOfJobs = job;
        //        Console.WriteLine($"Robota o ID: {listOfJobs.Id} i nazwie {listOfJobs.Name} wykonywana jest dla {listOfJobs.Client} i została ostatnio zmodyfikowana {listOfJobs.ModifyDate}");
        //    }

        }
    }
}
