using UnityEngine;
using System.Collections;

public class MudarTexturaKeyCode : MonoBehaviour
{

    public GameObject[] objetos = new GameObject[63];
    public Texture[] texturas = new Texture[63];
    int posicao = 0;
    int maxText;

    // Irá chamar o script na inicializaÃ§Ã£o 
    void Start()
    {

        // Estabelece o valor mÃ¡ximo para se resetar o Ã­ndice no vetor de texturas.
        maxText = texturas.Length - 1;

    }

    // Irá chamar o script a cada frame de execuÃ§Ã£o.
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.T))
        {

            foreach (GameObject objeto in objetos)
            {

                // Altera a textura dos Metais uma vez que a tecla T seja pressionada.
                objeto.GetComponent<Renderer>().material.mainTexture = texturas[posicao];
                // Garante que as mudanÃ§as de textura nao extrapolem o tamanho do vetor de texturas.
                if (posicao == maxText)
                {
                    posicao = 0;
                }
                else
                {
                    posicao++;
                }
            }

        }
    }
}