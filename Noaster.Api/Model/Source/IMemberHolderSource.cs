using System.Collections;

namespace Noaster.Api.Model.Source
{
    public interface IMemberHolderSource : IMemberHolder
    {
        new IList getMembers();
    }
}