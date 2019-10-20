using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;  

namespace featuretracker.Models
{   
    public class Project
    {
        
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate {get; set;}
        public string Name {get; set;}
        public int UserID {get; set;}
        // public int[] ReadAuthUserID {get; set;}
        // public int[] PostAuthUserID {get; set;}
        // public Card Cards {get; set;}

    }

    public class Card
    {
        
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate {get; set;}
        public string Title {get; set;}
        public int UserID {get; set;}
        public string Category {get; set;}
        public Columns column {get; set;}

    }

    public enum Columns
    {
        ToDo,
        InProgress,
        Finished
    }
}