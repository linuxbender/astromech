using System;

namespace Domain.Service.Entity
{
    public interface IStampControl
    {
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }

        string CreatedBy { get; set; }
        string UpdatedBy { get; set; }
    }
}