using UnityEngine;
using System.Collections;

public class OurCamera : MonoBehaviour 
{
	void Update () 
	{
		float mouseX = Input.GetAxis ("Mouse X");
		float mouseY = Input.GetAxis ("Mouse Y");
		transform.Translate (mouseX, mouseY, 0.0f);
	}
}
