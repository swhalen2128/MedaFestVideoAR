using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.Video;



public class FoundObject : MonoBehaviour, IFocusable {
    public GameObject prize;
    private Vector3 loc;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnFocusEnter()
    {

        loc = gameObject.transform.position;
        
        Instantiate(prize);
        prize.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        Destroy(gameObject);

    }

    public void OnFocusExit()
    {
        
    }


}
