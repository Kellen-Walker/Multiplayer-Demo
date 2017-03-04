using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
	{
		GameObject hit = collision.gameObject;
		PlayerHealth health = hit.GetComponent<PlayerHealth>();
		if (health  != null)
		{
			health.TakeDamage(10);
		}

		Destroy(gameObject);
	}
}