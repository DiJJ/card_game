using UnityEngine;

[CreateAssetMenu(menuName = "Attributes/Herbivore", fileName = "Herbivore")]
public class Herbivore : ScriptableObject, IAttribute {
    public bool CanEat(IEatable food) {
        return food is not Creature;
    }
}
