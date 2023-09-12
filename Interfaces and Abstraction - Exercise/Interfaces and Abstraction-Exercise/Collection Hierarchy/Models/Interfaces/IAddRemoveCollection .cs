

namespace Collection_Hierarchy.Models.Interfaces
{
    public interface IAddRemoveCollection : IAddCollection
    {
        void Remove(List<string>elements,int count);
    }
}
