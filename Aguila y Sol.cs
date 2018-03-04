using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AguilaySol : MonoBehaviour {
	
	public int r;


	public void lanzamientoDeMoneda()
	{
		r = Random.Range (0,2);
	}


	public int getResultado
	{
		get { return r; }
			
	}


}
