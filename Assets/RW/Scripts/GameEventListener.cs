using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

[Serializable]
public class GameEventListener : MonoBehaviour
{
    [SerializeField] GameEvent _eventToListen;
    [SerializeField] UnityEvent<UnityEngine.Object> _responce = null; 

    private void OnEnable() {
        _eventToListen.AddListener(Raise);
    }

    public void Raise(UnityEngine.Object obj){
        _responce.Invoke(obj);
    }
}
