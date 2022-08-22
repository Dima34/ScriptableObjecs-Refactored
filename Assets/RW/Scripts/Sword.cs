using UnityEngine;
using System;

[Serializable]
public class Sword : MonoBehaviour
{
    [SerializeField]
    SwordData _swordData;
    [SerializeField]
    GameEvent _onSwordClick;
    
    private void OnMouseDown() {
        _onSwordClick.Fire(_swordData);
    }
}
