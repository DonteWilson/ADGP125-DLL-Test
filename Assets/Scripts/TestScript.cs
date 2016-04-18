﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{

    public ADGP125 classObject;
    public Text Info;
    
    public string txt;

	// Use this for initialization
	void Start ()
    {
        classObject = new ADGP125();
        //uses my function from the DLL that I created in visual studios
        txt = classObject.AD125();
        //I have successfully created a test that shows that my dll can be used within usntiy.
        print("ADGP125 DLL to Unity Test: " + txt);

        Info.text = txt;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
