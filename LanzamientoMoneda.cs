using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzamientoMoneda : MonoBehaviour /*AguilaySol*/ {
	AguilaySol tirada = new AguilaySol();
	private Transform mov = null;
	public float vel;

	// Use this for initialization
	void Start () {
		
			mov = GetComponent<Transform> ();
			


	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q))
		{
			tirada.lanzamientoDeMoneda ();

		

			if (tirada.getResultado == 1) 
			{
				mov.rotation = Quaternion.Euler (180, -90, 0);
				print("Aguila");


			} else 
			{
				mov.rotation = Quaternion.Euler (0, -90, 0);
				print ("sello");

			}

		}

		/*if (Input.GetKeyDown (KeyCode.W))
		{
			for (int i = 0; i <= 10; i++) 
			{
				if (tirada.getResultado == 1) 
				{
					print("Aguila");
				} else {
					print ("sello");
				}

			}


		}*/
	}
}
