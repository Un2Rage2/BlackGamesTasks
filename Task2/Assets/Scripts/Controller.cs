using UnityEngine;
using System.Collections;
using System.Security.Cryptography;


public class Controller : MonoBehaviour
{
	private Vector3 offset;
	public bool isControlled;
	void OnMouseDown()
	{
		offset = gameObject.transform.position -
		         Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5.8f));
		isControlled = true;
	}

	void OnMouseDrag()
	{
		if (isControlled)
		{
			var newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5.8f);
			transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
		}
	}
	
}
