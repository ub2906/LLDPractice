using System;
using System.Collections.Generic;
using LLDPractice.Interfaces;
using LLDPractice.Models;

namespace LLDPractice.Patterns
{

    public enum EnvironmentType
    {
        Production,
        Testing
    }
    public static class StartPolicyBuilder
    {
        public static IStartPolicy Build(EnvironmentType environment)
        {
            var policies = new List<IStartPolicy>
            {
                new InsurancePolicy(),
                new DiagnosticPolicy(),
                new LoggingPolicy()
            };

            IFailureHandlingStrategy failureStrategy =
                environment == EnvironmentType.Production
                    ? new StopOnFirstFailure()
                    : new AggregateFailure();

            return new CompositeStartPolicy(policies, failureStrategy);
        }
    }
}