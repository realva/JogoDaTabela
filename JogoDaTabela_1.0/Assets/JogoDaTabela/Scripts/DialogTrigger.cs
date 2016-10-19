using UnityEngine;
using System.Collections;

public class DialogTrigger : MonoBehaviour {

	public GameObject text;
	public GameObject button;
	private BoxCollider[] colisores;
	private bool flag = false;

	// Use this for initialization
	void Start () {
		colisores = gameObject.GetComponents<BoxCollider>();

	}
	
	// Update is called once per frame
	void Update () {
		
			
		}
	

	void OnTriggerEnter(){
		// ApÃ³s a colisÃ£o, desativamos todos os possÃ­veis colisores do objeto.
		/*foreach (BoxCollider BoxColl in colisores) {
			BoxColl.enabled = flag;
		}*/
		text.SetActive (!flag);
		button.SetActive (!flag);


	}
}
