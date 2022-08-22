using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



[CreateAssetMenu(fileName = "New GameEvent", menuName = "New Game Event", order = 52)]
public class GameEvent : ScriptableObject {
    UnityEvent<Object> gameEvent = new UnityEvent<Object>();

    public void AddListener(UnityAction<Object> listener){
        gameEvent.AddListener(listener);
    }

    public void Fire(Object obj = null){
        gameEvent.Invoke(obj);
    }
}