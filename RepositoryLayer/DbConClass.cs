using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class DbConClass : DbContext
    {

        //constructor
        public DbConClass() : base()
        {

        }
        //for Dependency Injection in program.cs ->to register service  builder.Services.AddDbContext
       
        public DbConClass(DbContextOptions options) : base(options)
        {

        }
        //add the dbset which is the domain model class that represent the db tables

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }


        //this is to specify which db server you're using and the db name and the auth type
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {  //pass the connection string, initial catalog is the db name u creating and integrated security is the auth true-> windows auth
           
            optionsBuilder.UseSqlServer("Data Source=Atty;Initial Catalog=AlgorizaDemo;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);

        }
    }


        }