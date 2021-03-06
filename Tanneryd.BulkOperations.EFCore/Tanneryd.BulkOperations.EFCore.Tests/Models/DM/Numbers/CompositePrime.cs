// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tanneryd.BulkOperations.EFCore.Tests
{
    // CompositePrime
    public class CompositePrime
    {
        public long CompositeId { get; set; } // CompositeId (Primary key)
        public long PrimeId { get; set; } // PrimeId (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent Composite pointed by [CompositePrime].([CompositeId]) (FK_dbo.CompositePrime_dbo.Composite_CompositeId)
        /// </summary>
        public Composite Composite { get; set; } // FK_dbo.CompositePrime_dbo.Composite_CompositeId

        /// <summary>
        /// Parent Prime pointed by [CompositePrime].([PrimeId]) (FK_dbo.CompositePrime_dbo.Prime_PrimeId)
        /// </summary>
        public Prime Prime { get; set; } // FK_dbo.CompositePrime_dbo.Prime_PrimeId
    }

}
// </auto-generated>
