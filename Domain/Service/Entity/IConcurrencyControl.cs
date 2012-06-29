namespace Domain.Service.Entity
{
    public interface IConcurrencyControl
    {
        byte[] RowVersion { get; set; }
    }
}
