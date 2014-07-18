namespace Slms.Data.Contracts
{
    /// <summary>
    /// Specifies that the object that implements this interface is identified by an object of specified generic parameter.
    /// </summary>
    /// <typeparam name="TKey">The Type for the identifier.</typeparam>
    public interface IIdentifiable<TKey>
    {
        TKey Id { get; set; }
    }
}
