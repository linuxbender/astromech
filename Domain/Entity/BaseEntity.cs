using System;
using Domain.Service.Entity;

namespace Domain.Entity
{
    abstract class BaseEntity : IEntity, IConcurrencyControl, IStampControl
    {
        /// <summary>
        /// IEntity
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        ///  IStampControl 
        /// </summary>
        public DateTime CreatedAt {get; set;}        
        public DateTime UpdatedAt {get; set;}

        public string CreatedBy {get; set;}                
        public string UpdatedBy {get; set;}

        /// <summary>
        /// IConcurrencyControl
        /// </summary>
        public byte[] RowVersion { get; set; }
    }
}