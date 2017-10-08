using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    public GameObject coinPoof;

    public void OnCoinClicked() {
		Vector3 coinLocation = gameObject.transform.position;
		Destroy(gameObject);
        Instantiate(coinPoof, new Vector3(coinLocation.x, coinLocation.y, coinLocation.z), Quaternion.Euler(-90f, 0, 0));
        coinPoof.GetComponent<AudioSource>().Play();
    }
}
