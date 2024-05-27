using UnityEngine;

[CreateAssetMenu(menuName = "Attributes/Carnivore", fileName = "Carnivore")]
public class Carnivore : ScriptableObject, IAttribute {
    public bool CanEat(IEatable food) {
        return food is Creature;
    }
}
