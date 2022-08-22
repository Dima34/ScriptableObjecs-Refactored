using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField] GameEvent _eventToListen;
    [SerializeField] UnityEvent _responce; 

    private void OnEnable() {
        _eventToListen.AddListener(Raise);
    }

    public void Raise(){
        _responce.Invoke();
    }
}
