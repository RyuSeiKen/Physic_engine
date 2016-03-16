using UnityEngine;
using System.Collections;

public class OurCamera : MonoBehaviour 
{

	Vector3 target = new Vector3();
	public float moveFactor = 10.0f;
	public float smoothRatio = 0.9f;

	void Start()
	{
		target = new Vector3();
		target.z = transform.localPosition.z;
	}

	void Update () 
	{
		float mouseX = Input.GetAxis ("Mouse X");
		float mouseY = Input.GetAxis ("Mouse Y");

		float dm = Time.deltaTime * moveFactor;
		target.x += mouseX * dm;
		target.y += mouseY * dm;

		Vector3 position = transform.localPosition;
		Vector3 newPosition = Vector3.Lerp (target, position, smoothRatio);
		transform.localPosition = newPosition;
//		transform.Translate (mouseX, mouseY, 0.0f);
	}
}