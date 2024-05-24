using UnityEngine;

public class GameCanvas : MonoBehaviour, IGameUI {
    [field: SerializeField] 
    public Transform HandTransform { get; private set; }
}

public interface IGameUI {
    Transform HandTransform { get; }
}