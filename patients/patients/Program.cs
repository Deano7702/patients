using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace patients
{
    /// <summary>
    /// Date: 13/07/2022
    /// Creator: Dean Mason
    /// Desc: Program reads data objects from a JSON file and creates patient objects to store relevant information, which is displayed to the console
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            List<patient> Patients = new List<patient>(); //List to store patient objects / records
            int JSONcounter = 0; //Counter to increment through JSON data objects

            try
            {
                dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(@"contactDetails.json")); // Read data from JSON file

                foreach (var contact in jsonFile) //For each JSON data object
                {
                    //Store data in respective variables
                    string full_name = (string)jsonFile[JSONcounter]["full_name"];
                    string mobile = (string)jsonFile[JSONcounter]["mobile"];
                    string street = (string)jsonFile[JSONcounter]["address"]["street"];
                    string city = (string)jsonFile[JSONcounter]["address"]["city"];

                    patient p = new patient(full_name, mobile, street, city); //Create a new patient object with data

                    Patients.Add(p); //Add patient to the patients list

                    JSONcounter++;
                }

                foreach (var patient in Patients) //For each patient in the patient list
                {
                    Console.WriteLine("Full Name: " + patient.FullName + "\nMobile: " + patient.Mobile + "\nStreet: " + patient.Street + "\nCity: " + patient.City + "\n"); //Display respective information to console
                }
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured retrieving data or the file was not found."); //Prompt error message to console
            }
        }
    } 
}
