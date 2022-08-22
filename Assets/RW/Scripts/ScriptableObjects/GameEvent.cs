using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu(fileName = "New GameEvent", menuName = "New Game Event", order = 52)]
public class GameEvent : ScriptableObject {
    UnityEvent gameEvent = new UnityEvent();

    public void AddListener(UnityAction listener){
        gameEvent.AddListener(listener);
    }

    public void Fire(){
        gameEvent.Invoke();
    }
}