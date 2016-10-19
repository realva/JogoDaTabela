using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

    public bool paused;
    public GameObject botao;


	// Use this for initialization
	void Start () {
        botao.SetActive(false);
        paused = false;
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            paused = !paused;
        }
        if (paused == true)
        {
            botao.SetActive(true);
            Time.timeScale = 0;
        }
            else if (!paused){
            botao.SetActive(false); 
                 Time.timeScale = 1;
        }
	
	}

    public void pause()
    {


    }
}
