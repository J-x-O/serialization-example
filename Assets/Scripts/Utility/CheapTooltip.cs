using UnityEngine;

namespace Utility {
    public class CheapTooltip : MonoBehaviour {

        [TextArea(3, 25)]
        [SerializeField] private string _content;

    }
}