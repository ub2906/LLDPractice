using System;
using System.Collections.Generic;
using LLDPractice.Interfaces;

namespace LLDPractice.Models
{
    public class AggregateFailure : IFailureHandlingStrategy
    {
        public void Handle(Exception ex, List<Exception> collected)
        {
            collected.Add(ex);
        }
    }
}