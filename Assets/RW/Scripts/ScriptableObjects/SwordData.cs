using UnityEngine;

[CreateAssetMenu(fileName = "New SwordData", menuName = "Sword Data", order = 51)]
public class SwordData : ScriptableObject
{
    [SerializeField]
    string _swordName;
    [SerializeField]
    string _description;
    [SerializeField]
    Sprite _icon;
    [SerializeField]
    int _goldCost;
    [SerializeField]
    int _attackDamage;

    public string SwordName {
        get{
            return _swordName;
        }
    }

    public string Description{
        get{
            return _description;
        }
    }

    public Sprite Icon{
        get{
            return _icon;
        }
    }

    public int GoldCost{
        get{
            return _goldCost;
        }
    }

    public int AttackDamage{
        get{
            return _attackDamage;
        }
    }
}
