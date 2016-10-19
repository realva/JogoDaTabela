using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {



    // mov chama o objeto de movimentação do personagem. Utilizei-o para criar um switch que não permite que o personagem de mova durante dialogos
	public GameObject textBox;
    public GameObject nextButton;
    public GameObject sair;
    public Text theText;
    public GameObject mov;

    // Arquivos a serem carregados de uma pasta com os dialogos e criação de um string de linhas
    public TextAsset textFile;
    public TextAsset npc;
    public string[] textlines;

    //começo e fim do string de linhas
    public static int currentLine;
    private int endAtLine;



    // Use this for initialization
    void Start()
    {
		//textBox.SetActive (false);
		//nextButton.SetActive (false);
        if (textFile != null)
        {
            textlines = (textFile.text.Split('\n'));
        }
        if (endAtLine == 0)
        {
            endAtLine = textlines.Length;
        }

    }

    // Caso tecla Enter seja pressionada, nova linha do dialogo será inserida
    void Update()
    {
		theText.text = textlines[currentLine];

    }
    
    //O mesmo, mas criado para o botão abaixo da caixa de dialogos
    public void proximoTexto()
    {
       
		if (currentLine >= endAtLine-1) {
			textBox.SetActive (false);
			nextButton.SetActive (false);
			currentLine = 0;
			mov.SetActive (true);

		} else {
			mov.SetActive (false);
			currentLine++;
		}
    }

    //Receber novo pacote de textos. Não funcionando.
    public void npccontrol()
    {
        //textFile = npc;
        //textBox.SetActive(true);
        Debug.Log("AQUI CLICOU CARALHO");
    }

    public void sairAplicativo()
	{
		//textFile = npc;
		//textBox.SetActive(true);
		Application.Quit ();
		Debug.Log ("AQUI CLICOU CARALHO");
	}
		
		
}
