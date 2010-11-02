using System;
using Ncqrs.Eventing.Sourcing;

namespace CqrsLearning.Events.Member
{
    public class MemberCreatedEvent : SourcedEvent
    {
        public long Nsi { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
