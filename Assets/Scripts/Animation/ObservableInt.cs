using System;
using UnityEngine;

namespace Animation {

    /// <summary>
    /// It would be great if there was an interface like this,
    /// that would make the class appear as a property in the editor
    /// </summary>
    [Serializable]
    public class ObservableInt : IAnimatedProperty<int> {

        public event Action OnChange;
        
        [SerializeField] private int _value;

        public int Get() => _value;
        public void Set(int value) {
            _value = value;
            OnChange?.Invoke();
        }

        public static implicit operator int(ObservableInt value) => value._value;
    }
}