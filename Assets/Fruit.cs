using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{

	public GameObject fruitSlicedPrefab;
	public float startForce = 15f;

	Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		rb.AddForce(transform.up * startForce, ForceMode.Impulse);
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Blade")
		{
			Vector3 direction = (col.transform.position - transform.position).normalized;

			Quaternion rotation = Quaternion.LookRotation(direction);

			GameObject slicedFruit = Instantiate(fruitSlicedPrefab, transform.position, rotation);
			Destroy(slicedFruit, 3f);
			Destroy(gameObject);
		}
	}

}