using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    [SerializeField] string EventDescription;
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
