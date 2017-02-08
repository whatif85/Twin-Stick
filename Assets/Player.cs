using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{

	void Start ()
	{
		
	}

	void Update ()
	{
		// the string names come from Edit>Project Settings>Input Manager for key binding
		Debug.Log ("H: " + CrossPlatformInputManager.GetAxis("Horizontal"));
		Debug.Log ("V: " + CrossPlatformInputManager.GetAxis("Vertical"));
	}
}
