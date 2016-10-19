
// x=28 z=15
// z=25
// z=35
// x=18 z=15
// z=25
// z=35
// x=8 z=15
// z=25
// z=35
using UnityEngine;
using System.Collections;

public class RandomTable : MonoBehaviour {


	private float yposition = 5.9f;
	private bool control = true;
	private int flag1;
	private int flag2;
	public GameObject gases;
	public GameObject semimetais;
	public GameObject ametais;



	// Use this for initialization
	void Start () {

		while (control) {
			flag1 = (int)Random.Range (1, 6);
			flag2 = (int)Random.Range (1, 6);
			if (flag1 != flag2) {
				control = false;
			}
		}
		if (flag1 == 1) {
			
			gases.transform.position = new Vector3 (28, yposition, 15);
			print (gases.transform.position.x);

		}

		if (flag2 == 1) {

			semimetais.transform.position = new Vector3 (28, yposition, 15);
			print (semimetais.transform.position.x);

		}
		if (flag1 == 2) {

			gases.transform.position = new Vector3 (28, yposition, 25);
			print (gases.transform.position.x);

		}

		if (flag2 == 2) {

			semimetais.transform.position = new Vector3 (28, yposition, 25);
			print (semimetais.transform.position.x);

		}
		if (flag1 == 3) {

			gases.transform.position = new Vector3 (28, yposition, 35);
			print (gases.transform.position.x);

		}

		if (flag2 == 3) {

			semimetais.transform.position = new Vector3 (28, yposition, 35);
			print (semimetais.transform.position.x);

		}
		if (flag1 == 4) {

			gases.transform.position = new Vector3 (18, yposition, 15);
			print (gases.transform.position.x);

		}

		if (flag2 == 4) {

			semimetais.transform.position = new Vector3 (18, yposition, 15);
			print (semimetais.transform.position.x);

		}
		if (flag1 == 4) {

			gases.transform.position = new Vector3 (18, yposition, 15);
			print (gases.transform.position.x);

		}

		if (flag2 == 4) {

			semimetais.transform.position = new Vector3 (18, yposition, 15);
			print (semimetais.transform.position.x);

		}
		if (flag1 == 5) {

			gases.transform.position = new Vector3 (18, yposition, 25);
			print (gases.transform.position.x);

		}

		if (flag2 == 5) {

			semimetais.transform.position = new Vector3 (18, yposition, 25);
			print (semimetais.transform.position.x);

		}
		if (flag1 == 6) {

			gases.transform.position = new Vector3 (18, yposition, 35);
			print (gases.transform.position.x);

		}

		if (flag2 == 6) {

			semimetais.transform.position = new Vector3 (18, yposition, 35);
			print (semimetais.transform.position.x);

		}
			
	}
	
	// Update is called once per frame
	void Update () {

		//gases.transform.Rotate (0, 5, 0, Space.Self);
	
	}
}
