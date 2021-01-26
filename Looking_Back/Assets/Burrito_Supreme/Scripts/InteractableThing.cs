using UnityEngine;
using UnityEngine.Events;

public class InteractableThing : MonoBehaviour {

    public bool isInteractable = true;
    public string textThatShowsUpWhenApproached = "YOU CAN INTERACT WITH THIS NOW";

    public UnityEvent onInteracted;
    public UnityEvent onPlayerApproached;
    public UnityEvent onPlayerExited;

    public void Interact() {
        if (isInteractable) {
            onInteracted.Invoke();
        }
    }

    public void OnPlayerApproached() {
        if (isInteractable)
        
        onPlayerApproached.Invoke();

    }

    public void OnPlayerExited() {
        onPlayerExited.Invoke();
    }

    public void Deactivate()
    {
        isInteractable = false;
    }
}
