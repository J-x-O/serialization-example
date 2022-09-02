using UnityEngine;

namespace Animation {
    public class ExampleAnimation : MonoBehaviour {
        
        // all of these show up in the animator
        [SerializeField] private int _intField;
        [SerializeField] private float _floatField;
        [SerializeField] private Vector2 _vector2Field;
        [SerializeField] private Vector3 _vector3Field;
        [SerializeField] private Color _colorField;
        
        // wrapper classes like this don't
        [Header("Custom Classes")]
        [SerializeField] private ObservableInt _observableInt;
    }
}