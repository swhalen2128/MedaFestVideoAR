using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GazeHandler : MonoBehaviour, IFocusable {

    private Material mat;
    public Material vid;
    public GameObject vdi1;
    
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnFocusEnter()
    {
        var com = gameObject.GetComponent<Renderer>();
        mat = com.material;
        com.material = vid;
        vdi1.GetComponent<VideoPlayer>().Play();
    }

    public void OnFocusExit()
    {
        vdi1.GetComponent<VideoPlayer>().Pause();
    }
}
