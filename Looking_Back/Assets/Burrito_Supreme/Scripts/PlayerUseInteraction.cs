using UnityEngine;
using UnityEngine.UI;

public class PlayerUseInteraction : MonoBehaviour {

    public Text uiReference;
    private InteractableThing interactableThing;
    
    void Update()
    {
        
        // Boolean logic in Unity:
        /*
        bool a = true;
        bool b = false;
        bool c; 
        
        c = a && b; // AND operator
        c = a || b; // OR operator
        c = !c; // NOT operator
        */
        
        // Figure out if we can interact!
        bool canInteract = (interactableThing != null) &&
            (interactableThing.gameObject.activeInHierarchy) &&
            interactableThing.isInteractable;

        // Set the on-screen text from the object!
        if (interactableThing != null) { 
            uiReference.text = interactableThing.textThatShowsUpWhenApproached;
        }

        // Show the on-screen text depending on whether or not we have a thing to interact with
        uiReference.gameObject.SetActive(canInteract);

        // If keycode's pressed....
        if (Input.GetKeyDown(KeyCode.E)) {
            
            Debug.Log("GOT E");
            // Check for a Usable object in range
            if (interactableThing != null) {
                Debug.Log("TRIGGERING " + interactableThing.name);

                // Trigger it
                interactableThing.Interact();
            }            
        }
        
    }

    private void OnTriggerEnter(Collider other) {
        // When you run into a trigger...
        // Just keep a reference to it
        InteractableThing newThing = other.GetComponent<InteractableThing>();
        if (newThing != null) {
            interactableThing = newThing;
            Debug.Log("GOT NEW INTERACTABLE THING: " + interactableThing.name);
            newThing.OnPlayerApproached();
        }
        

        // And maybe do a log
        Debug.Log("RAN INTO TRIGGER: " + other.name);
    }

    private void OnTriggerExit(Collider other) {
        InteractableThing newThing = other.GetComponent<InteractableThing>();
        
        // Check to see if it's any interactable object...
        if (newThing != null) {
            newThing.OnPlayerExited();
        }
        
        // Check to see if it has the same interactable thing as we already have
        // If so, lose the reference
        if (newThing != null && newThing == interactableThing) {
            interactableThing = null;
            Debug.Log("LOST INTERACTABLE THING: " + newThing.name);
        }
    }
}
