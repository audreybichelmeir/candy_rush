using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    public int health;
    public bool hasDied;

	void Start () {
        hasDied = false;

	}
	
	void Update () 
    {
        if (gameObject.transform.position.y < -6 )
        {
            hasDied = true;
            //Debug.Log("Player Has Died"); //valid
        }
        if (hasDied == true)
        {
            //repawn point
        }

    }

}
