using System;
using CqrsLearning.Events.Member;
using Ncqrs.Domain;

namespace CqrsLearning.Domain
{
    public class Member : AggregateRootMappedByConvention
    {
        private long nsi;
        private string firstName;
        private string lastName;
        private DateTime createdAt;

        /// <summary>
        /// Initializes a new instance of the <see cref="Member"/> class.
        /// </summary>
        /// <param name="nsi">The nsi.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        public Member(long nsi, string firstName, string lastName)
        {
            this.ApplyEvent(new MemberCreatedEvent
            {
                Nsi = nsi,
                FirstName = firstName,
                LastName = lastName,
                CreatedAt = DateTime.UtcNow
            });
        }

        protected virtual void OnMemberCreated(MemberCreatedEvent evnt)
        {
            this.nsi = evnt.Nsi;
            this.firstName = evnt.FirstName;
            this.lastName = evnt.LastName;
            this.createdAt = evnt.CreatedAt;
        }
    }
}
