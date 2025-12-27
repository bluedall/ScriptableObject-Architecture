using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    // class name . method name ;
    // each method that asigned to the unity event, the name of its class and method should write here.
    [SerializeField] string [] EventDescription;
    [SerializeField] GameEvent gameEvent;
    [SerializeField] UnityEvent UnityEvent;
    private void OnEnable()
    {
        gameEvent.Register(this);
    }
    private void OnDisable()
    {
        gameEvent.Unregister(this);
    }
    public void OnEventRaised()
    {
        UnityEvent?.Invoke();
    }
}


