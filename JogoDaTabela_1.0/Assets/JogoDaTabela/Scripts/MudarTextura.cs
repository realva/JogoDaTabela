// Script para tentativa de se mudar uma textura de acordo com o evento
using UnityEngine;
using System.Collections;
[RequireComponent(typeof(BoxCollider))]

public class MudarTextura : MonoBehaviour {

	private BoxCollider[] colisores;
	public Texture[] texturas = new Texture[2];
	int posicao = 0;
	int maxText;

	// IrÃ¡ chamar o script na inicializaÃ§Ã£o 
	void Start () {
		// Cria uma variÃ¡vel que irÃ¡ lidar com todos os colisores presentes no objeto.
		colisores = gameObject.GetComponents<BoxCollider>();
		// Estabelece o valor mÃ¡ximo para se resetar o Ã­ndice no vetor de texturas.
		maxText = texturas.Length - 1;

	}
	
	// IrÃ¡ chamar o script a cada frame de execuÃ§Ã£o.
	void Update () {
		
	
	}
	// Trigger que irÃ¡ acionar a mudanÃ§a de texturas.
	void OnTriggerEnter(){
		// ApÃ³s a colisÃ£o, desativamos todos os possÃ­veis colisores do objeto.
		foreach (BoxCollider BoxColl in colisores) {
			BoxColl.enabled = false;
		}
		// Muda a textura do objeto para alguma das texturas presentes no vetor texturas.
		GetComponent<Renderer>().material.mainTexture = texturas [posicao];
		if (posicao == maxText) {
			posicao = 0;
		} else {
			posicao++;
		}

	}
}