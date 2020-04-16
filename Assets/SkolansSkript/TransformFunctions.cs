using UnityEngine;
using System.Collections;

public class TransformFunctions : MonoBehaviour
{
	public float moveSpeed = 10f;
	public float turnSpeed = 50f;

	public CheckIfHasFallen collissionScript;


	void Update ()
	{
		if (collissionScript.state == false)
		{

			if (Input.GetKey(KeyCode.W))
			{
				transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
			}

			if (Input.GetKey(KeyCode.A))
			{
				transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
			}

			if (Input.GetKey(KeyCode.D))
			{
				transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

			}

			if (Input.GetKey(KeyCode.S))
			{
				transform.Translate(Vector3.forward * -moveSpeed * Time.deltaTime);

			}
		}
	}
}

		
