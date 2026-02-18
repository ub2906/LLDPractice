using System;
using System.Collections.Generic;

namespace LLDPractice.Interfaces
{
    public interface IFailureHandlingStrategy
    {
        void Handle(Exception ex, List<Exception> collected);
    }
}