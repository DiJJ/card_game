using UnityEngine;
using UnityEngine.Assertions;

public class AttributeCard : MonoBehaviour {
    [SerializeField] private FallOnCard _fallOnCard;
    [SerializeField] private ScriptableObject _attribute;

    private void ApplyAttribute(GameObject card) {
        if (card.TryGetComponent(out Creature creature)) {
            creature.AddAttribute(_attribute as IAttribute);
            gameObject.SetActive(false);
        }
    }

    private void OnEnable() {
        _fallOnCard.OnCardDrop += ApplyAttribute;
    }

    private void OnDisable() {
        _fallOnCard.OnCardDrop -= ApplyAttribute;
    }

#if UNITY_EDITOR
    private void OnValidate() {
        Assert.IsTrue(_attribute != null && _attribute is IAttribute);
    }
#endif
}
