using UnityEngine;
using System.Collections;

public class Spring : MonoBehaviour 
{
	float mass = 0.2f;
	public float stiffness = 0.1f;
	public Vector3 speed = new Vector3();

	void Update () 
	{
		Vector3 position = transform.localPosition;
		Vector3 forces = -stiffness * position - speed * 0.1f;

		Vector3 acceleration = forces / mass;

		speed += acceleration * Time.deltaTime;

		position += speed * Time.deltaTime;
		transform.localPosition = position;
	}
}
