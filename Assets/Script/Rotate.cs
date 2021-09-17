using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour 
{
	public MeshRenderer m_renderer;
	public float rotateAngle = 90;
	public Vector3 randomValue;


	void Start()
	{
		m_renderer = GetComponent<MeshRenderer> ();
	}

	void Update () 
	{
		transform.Rotate (Vector3.up * rotateAngle * Time.deltaTime);
	}

	public void FlipSpinFunction()
	{
		rotateAngle = -rotateAngle;
		m_renderer.material.color = Random.ColorHSV();
		//transform.position = new Vector3 (Random.Range (-3, 3), 1.8f, Random.Range(-3,3));
	}

	public void RnadomRangefunction()
	{
		float min = -5;
		float max = 5;


		randomValue = new Vector3 (Random.Range(min, max), 1.8f, Random.Range(min, max));
		/*do {
			randomValue.x = Random.Range (min, max);
			randomValue.z = Random.Range (min, max);
			Debug.Log(randomValue.x);
			Debug.Log(randomValue.z);
		} while(randomValue.x == Random.Range (-2, 2) || randomValue.z == Random.Range (-2, 2));*/


		/*while (randomValue.x == Random.Range (-2, 2) || randomValue.z == Random.Range (-2, 2)) 
		{
			randomValue.x = Random.Range (min, max);
			randomValue.x = Random.Range (min, max);
		}*/

		if (-2 <= randomValue.x && randomValue.x <= 2) 
		{
			RnadomRangefunction ();
		} 
		else 
		{
			gameObject.transform.position = randomValue;
		}
		
	}
}
