using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/Events/GameEvent", order = 1)]
public class GameEvent : ScriptableObject
{
    public List<EventListener> listeners = new List<EventListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }
    public void Register(EventListener listener)
    {
        listeners.Add(listener);
    }

    public void Unregister(EventListener listener)
    {
        listeners.Remove(listener);
    }

}
