namespace Animation {

    /// <summary>
    /// it would be nice to provide a interface for custom value types
    /// so the animation system can be easily extended
    /// </summary>
    public interface IAnimatedProperty<T> {

        public void Set(T value);
    }
}