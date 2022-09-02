using System.Collections.Generic;
using UnityEngine;

namespace Inheritance {
    public class ExampleList : MonoBehaviour {

        [SerializeReference] [SerializeReferenceButton]
        private List<InheritanceBaseClass> _list;

    }
}