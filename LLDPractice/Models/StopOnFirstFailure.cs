using System;
using System.Collections.Generic;
using LLDPractice.Interfaces;

namespace LLDPractice.Models
{
    public class StopOnFirstFailure : IFailureHandlingStrategy
    {
        public void Handle(Exception ex, List<Exception> collected)
        {
            throw ex;
        }
    }
}