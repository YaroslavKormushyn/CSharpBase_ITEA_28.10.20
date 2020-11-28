using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ProgramTwoOptionTwo
{
    interface IDriveable
    {
        void Start();
        void Accelerate();
        void Brake();
    }
    class Car : IDriveable
    {
        public string Name { get; set; }
        public Car (string name)
        {
            this.Name = name;
        }

        public void Start()
        {
            Console.WriteLine("Start the car");
        }
        public void Accelerate()
        {
            Console.WriteLine("Increase the speed");
        }
        public void Brake()
        {
            Console.WriteLine("Stop the vehicle");
        }
    }
    class Bus : IDriveable
    {
        public void Start()
        {
            Console.WriteLine("Start the bus");
        }
        public void Accelerate()
        {
            Console.WriteLine("Increase the speed");
        }
        public void Brake()
        {
            Console.WriteLine("Stop the vehicle");
        }
    }
    class Motorcycle : IDriveable
    {
        public void Start()
        {
            Console.WriteLine("Start the car");
        }
        public void Accelerate()
        {
            Console.WriteLine("Increase the speed");
        }
        public void Brake()
        {
            Console.WriteLine("Stop the vehicle");
        }
    }
    public class Driver 
    {
        public string [] vehicles = {"BMW", "Toyota", "Hyundai"};
        
        public int parkingSpots = 6;
                          
        public Driver(int parkingSpots)
        { this.parkingSpots = parkingSpots; }

     
        public string Name {get; set;}
        public void Start() 
        {  
            Console.WriteLine("Start the vehicle"); 
        }
        public void Accelarate()
        {
            Console.WriteLine("Increasing my speed");
        }
        public void Brake()
        {
            Console.WriteLine("Stop the vehicle");
        }
        public void drivingSlowly()
        {
            Console.WriteLine("taking my time and obeying road rules while driving");
        }
        public void drivingFast()
        {
            Console.WriteLine("driving a car really fast");
        }
        public void AddVehicle(string []vehicles)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                return;
            }
        }
        public void removeVehicle(string []vehicles)
        {
            for (int i = 0; i < vehicles.Length; i--)
            {
                return;
            }
        }   
    }
    class Program
    {
        static void Main(string[] args)
        {
            Driver myObj = new Driver(6);
            myObj.Name = "John";
            myObj.parkingSpots = 6;
            Console.WriteLine(myObj.Name + " has " + myObj.parkingSpots + " parking spots" );
            Console.WriteLine(myObj.Name + " has " + myObj.vehicles.Length + " vehicles in his collection");
            Console.ReadLine();
        }
    }
}
