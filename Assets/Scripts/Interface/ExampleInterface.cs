using UnityEngine;

namespace Interface {
    
    /// <summary>
    /// Interface Fields can't be serialized by default.
    /// This behaviour hinders complex systems, which often depend on Interfaces.
    /// There are Workarounds, like Odin Inspector or other custom editors,
    /// but it seems like this should be supported out of the box.
    /// </summary>
    public class ExampleInterface : MonoBehaviour {

        [Tooltip("This field can be serialized and will show up in the editor")]
        [SerializeField] private BaseClass _working;
        
        [Tooltip("This field will not")]
        [SerializeField] private IBaseClass _sadness;

    }
}