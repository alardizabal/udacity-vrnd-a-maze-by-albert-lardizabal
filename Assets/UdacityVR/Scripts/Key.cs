using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject keyPoof;
    public Door door;
    public bool isCollected = false;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
		Vector3 keyLocation = gameObject.transform.position;
		// Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);
		// Instatiate the KeyPoof Prefab where this key is located
		// Make sure the poof animates vertically
		Instantiate(keyPoof, new Vector3(keyLocation.x, keyLocation.y, keyLocation.z), Quaternion.Euler(-90f, 0, 0));
		keyPoof.GetComponent<AudioSource>().Play();
		// Call the Unlock() method on the Door
		door.Unlock();
		// Set the Key Collected Variable to true
		isCollected = true;
    }

}
