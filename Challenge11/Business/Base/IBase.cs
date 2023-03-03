using System;

namespace Business.Base
{
    internal interface IBase : IID
    {
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        DateTime DeletedAt { get; set; }
    }
}
