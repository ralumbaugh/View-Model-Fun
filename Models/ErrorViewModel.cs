using System;
using System.Collections.Generic;

namespace ViewModelFun.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class User
    {
        public string FirstName {get;set;}
        public string LastName{get;set;}

        public User(string First, string Last)
        {
            FirstName = First;
            LastName = Last;
        }
    }
}