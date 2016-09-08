using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

    public Text text;

	// Use this for initialization
	void Start () {
        text.text = "Marllon, um desenvolvedor de jogos, durante o desenvolvimento do game \"Tabuada na Fazenda\", " +
                "se deparou com um bug crítico que prejudicava os dados da aplicação.\n\n" +
                "No mesmo momento, seu gerente Joás, que está na sala ao lado, enviou uma mensagem no Skype dizendo: \"estou indo ai pra gente conversar\".\n\n" +
                "O que Marllon deve fazer?";
    }
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown("space"))
        {
            text.text = "Vai saber...";
        }
	}
}
