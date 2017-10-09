using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    private Key key;
    private bool _isUnlocked = false;
    private bool _isOpening = false;
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 

    void Update() {
        // If the door is opening and it is not fully raised
        // Animate the door raising up
        if (!_isOpening) {
            
        }
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
        // Set the "opening" boolean to true
        // (optionally) Else
        // Play a sound to indicate the door is locked
        if (key.isCollected && _isUnlocked) {
            _isOpening = true;
        } else {
            
        }
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        _isUnlocked = true;
    }
}
