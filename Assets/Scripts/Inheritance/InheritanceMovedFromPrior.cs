using System;
using UnityEngine.Scripting.APIUpdating;

namespace Inheritance {
    
    /// <summary> This class was moved and renamed, but has the moved from attribute </summary>
    /// <remarks>
    /// This attribute is extremely useful, but sadly not perfectly flexible
    ///  - You cant have more than one, if you have a big project names and namespaces can get messy sometimes,
    ///    this compromises your ability to easily deal with this problem
    ///  - If you want to mark a name change, you are forced to provide all 4 variables,
    ///    this is an issue with the constructor, which seems hard to solve
    ///    maybe the attribute should be split into multiple:
    ///    [MovedFromNamespace(string namespace)], [RenamedFrom(string name)], [MovedFromAssembly(string assembly)]
    /// </remarks>
    [Serializable]
    [MovedFrom(false, "InheritancePrior",
        null, "InheritanceMovedFromPrior")]
    public class InheritanceMovedFromPrior : InheritanceBaseClass { }
}