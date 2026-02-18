using System;
using System.Collections.Generic;
using System.Linq;
using LLDPractice.Interfaces;

namespace LLDPractice.Models
{
    public class CompositeStartPolicy : IStartPolicy
    {
        private readonly IEnumerable<IStartPolicy> _policies;
        private readonly IFailureHandlingStrategy _failureStrategy;

        public CompositeStartPolicy(IEnumerable<IStartPolicy> policies, IFailureHandlingStrategy failureStrategy)
        {
            _policies = policies;
            _failureStrategy = failureStrategy;
        }

        public void BeforeStart()
        {
            var collected = new List<Exception>();

            foreach (var policy in _policies)
            {
                try
                {
                    policy.BeforeStart();
                }
                catch (Exception ex)
                {
                    _failureStrategy.Handle(ex, collected);
                }
            }

            if (collected.Any())
                throw new AggregateException(collected);
            }
    }

}