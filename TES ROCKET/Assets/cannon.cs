using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour {


	public GameObject cannonBall;
	public float shootForce = 0f;

	public GameObject CurrCannon;
	//public float divisionShoot = 35f;

	float rasio;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space) && CurrCannon == null) 
		{
			
			GameObject projectile = (GameObject)Instantiate 
				(cannonBall, transform.position, transform.rotation);
			projectile.GetComponent<Rigidbody> ().AddForce (projectile.transform.forward * shootForce);
		
			//rasio = shootForce / divisionShoot;
			projectile.GetComponent<Rigidbody> ().AddTorque (projectile.transform.right * (shootForce/(shootForce/(30))));
			//projectile.GetComponent<Rigidbody> ().AddTorque (projectile.transform.up * 100);

			/*GetComponent<Rigidbody>().AddTorque(transform.up * float * float)
			target.rigidbody.AddTorquet.ransform.Rotate(Vector3(0,speed,0));
			*/
			CurrCannon = projectile;

		}

	}

	public void LuncurRocket()
	{
		if ( CurrCannon == null) 
		{

			GameObject projectile = (GameObject)Instantiate 
				(cannonBall, transform.position, transform.rotation);
			projectile.GetComponent<Rigidbody> ().AddForce (projectile.transform.forward * shootForce);

			//rasio = shootForce / divisionShoot;
			projectile.GetComponent<Rigidbody> ().AddTorque (projectile.transform.right * (shootForce/(shootForce/(30))));
			//projectile.GetComponent<Rigidbody> ().AddTorque (projectile.transform.up * 100);

			/*GetComponent<Rigidbody>().AddTorque(transform.up * float * float)
			target.rigidbody.AddTorquet.ransform.Rotate(Vector3(0,speed,0));
			*/
			CurrCannon = projectile;

		}
	}
}
