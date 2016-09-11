using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

    public Text text;
    public Text question;
    private enum States {
        cenario_1, cenario_1_1, cenario_1_2, cenario_1_3, cenario_1_4,
        cenario_2, cenario_2_1, cenario_2_2, cenario_2_3, cenario_2_4,
        cenario_3, cenario_3_1, cenario_3_2, cenario_3_3, cenario_3_4,
        cenario_4, cenario_4_1, cenario_4_2, cenario_4_3, cenario_4_4,
        cenario_5, cenario_5_1, cenario_5_2, cenario_5_3, cenario_5_4,
        cenario_6
    };
    private States myState;
    private string availableOptions = "\n\n(Pressione 1, 2, 3 ou 4 para escolher uma das opções)";
    private string backToQuestion = "\n\nPressione ENTER pra voltar";

    // Use this for initialization
    void Start () {
        myState = States.cenario_1;
    }
	
	// Update is called once per frame
	void Update () {
        if (myState == States.cenario_1) { state_cenario_1(); }
        else if (myState == States.cenario_1_1) { state_cenario_1_1(); }
        else if (myState == States.cenario_1_2) { state_cenario_1_2(); }
        else if (myState == States.cenario_1_3) { state_cenario_1_3(); }
        else if (myState == States.cenario_1_4) { state_cenario_1_4(); }
        else if (myState == States.cenario_2) { state_cenario_2(); }
        else if (myState == States.cenario_2_1) { state_cenario_2_1(); }
        else if (myState == States.cenario_2_2) { state_cenario_2_2(); }
        else if (myState == States.cenario_2_3) { state_cenario_2_3(); }
        else if (myState == States.cenario_2_4) { state_cenario_2_4(); }
        else if (myState == States.cenario_3) { state_cenario_3(); }
        else if (myState == States.cenario_3_1) { state_cenario_3_1(); }
        else if (myState == States.cenario_3_2) { state_cenario_3_2(); }
        else if (myState == States.cenario_3_3) { state_cenario_3_3(); }
        else if (myState == States.cenario_3_4) { state_cenario_3_4(); }
        else if (myState == States.cenario_4) { state_cenario_4(); }
        else if (myState == States.cenario_4_1) { state_cenario_4_1(); }
        else if (myState == States.cenario_4_2) { state_cenario_4_2(); }
        else if (myState == States.cenario_4_3) { state_cenario_4_3(); }
        else if (myState == States.cenario_4_4) { state_cenario_4_4(); }
        else if (myState == States.cenario_5) { state_cenario_5(); }
        else if (myState == States.cenario_5_1) { state_cenario_5_1(); }
        else if (myState == States.cenario_5_2) { state_cenario_5_2(); }
        else if (myState == States.cenario_5_3) { state_cenario_5_3(); }
        else if (myState == States.cenario_5_4) { state_cenario_5_4(); }
        else if (myState == States.cenario_6) { state_cenario_6(); }
    }

    void change_state(States state)
    {
        myState = state;
    }

    void return_to_state(States state)
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)) { change_state(state); }
    }

    void state_cenario_1()
    {
        question.text = "Marllon, um desenvolvedor de Games Educativos, durante o desenvolvimento do game \"Tabuada na Fazenda\", " +
                    "se deparou com um bug crítico que prejudicava os dados da aplicação.\n\n" +
                    "No mesmo momento, seu gerente Joás, que está na sala ao lado, enviou uma mensagem no Skype dizendo: \"estou indo ai pra gente conversar\".\n" +
                    "O que Marllon deve fazer?" + availableOptions;

        text.text = "1) TENTAR debugar o código\n" + 
                    "2) QUESTIONAR os colegas da equipe\n" + 
                    "3) NOTIFICAR o líder da equipe (Giordani)\n" + 
                    "4) COLOCAR o martelo no bug";

        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)) { change_state(States.cenario_1_1); }
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2)) { change_state(States.cenario_1_2); }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3)) { change_state(States.cenario_1_3); }
        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4)) { change_state(States.cenario_1_4); }
    }

    void state_cenario_1_1()
    {
        question.text = "";
        text.text = "Não consegue encontrar o problema." + backToQuestion;

        return_to_state(States.cenario_1);
    }

    void state_cenario_1_2()
    {
        question.text = "";
        text.text = "Não conseguem identificar a raiz do problema." + backToQuestion;

        return_to_state(States.cenario_1);
    }

    void state_cenario_1_3()
    {
        question.text = "";
        text.text = "Ele está muito ocupado configurando uma nova instância na Amazon." + backToQuestion;

        return_to_state(States.cenario_1);
    }

    void state_cenario_1_4()
    {
        change_state(States.cenario_2);
    }

    void state_cenario_2()
    {
        question.text = "Após adicionar códigos de procedências duvidosa, os dados da aplicação voltam ao seu estado normal " + 
                        "e aparentemente tudo está funcionando como deveria.\n\n" + 
                        "Joás chega então na sala questionando Marllon, se já estava pronta a release para ser instalada nos tablets." + availableOptions;

        text.text = "Marllon responde que:\n" + 
                    "1) ESTA pronto (e gera uma build)\n" +
                    "2) DEVEMOS realizar mais testes pra garantir a qualidade do aplicativo\n" +
                    "3) TENHO que conversar com o Giordani primeiro\n" +
                    "4) JOÁS... ~olhos do Gato de Botas~";

        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)) { change_state(States.cenario_2_1); }
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2)) { change_state(States.cenario_2_2); }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3)) { change_state(States.cenario_2_3); }
        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4)) { change_state(States.cenario_2_4); }
    }

    void state_cenario_2_1()
    {
        change_state(States.cenario_3);
    }

    void state_cenario_2_2()
    {
        question.text = "";
        text.text = "Joás responde que \"Esse aplicativo nunca está pronto!\"" + backToQuestion;

        return_to_state(States.cenario_2);
    }

    void state_cenario_2_3()
    {
        question.text = "";
        text.text = "Joás responde que \"O Giordani não sabe de nada não\"" + backToQuestion;

        return_to_state(States.cenario_2);
    }

    void state_cenario_2_4()
    {
        question.text = "";
        text.text = "Joás responde \"Não me venha com xorumelas, esse aplicativo lixoso tem que estar pronto logo!\"" + backToQuestion;

        return_to_state(States.cenario_2);
    }

    void state_cenario_3()
    {
        question.text = "Marllon então gera uma build duvidosa para ser instalada em 1000 tables " + 
                        "que serão enviados para diversas escolas em 40 municípios.\n\n" + 
                        "Joás então requisita que Marllon envie para o Dr João (presidente da empresa) essa build, " + 
                        "para que ele instale no seu tablet e teste o jogo.\n\n" + 
                        "10 minutos após o envio do build, Dr João liga furioso, solicitando falar com o Joás, " + 
                        "informando que a única coisa que está funcionando no jogo é vídeo da apresentação inicial." + availableOptions;

        text.text = "Marllon...\n" +
                    "1) ARREGALA os olhos, coloca a mão no rosto e fica em silêncio\n" +
                    "2) OLHA para os lados, chama a equipe e pergunta o que commitaram por último\n" + 
                    "3) CHAMA o Giordani, pedindo ajuda para lidar com essa situação\n" + 
                    "4) RELATA que colocou um martelo em um bug \"simples\"";

        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)) { change_state(States.cenario_3_1); }
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2)) { change_state(States.cenario_3_2); }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3)) { change_state(States.cenario_3_3); }
        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4)) { change_state(States.cenario_3_4); }
    }

    void state_cenario_3_1()
    {
        question.text = "";
        text.text = "Joás o encara com uma expressão de choque." + backToQuestion;

        return_to_state(States.cenario_3);
    }

    void state_cenario_3_2()
    {
        question.text = "";
        text.text = "\"O último commit de modificação no aplicativo foi o seu Marllon...\", responde um dos membros da equipe." + backToQuestion;

        return_to_state(States.cenario_3);
    }

    void state_cenario_3_3()
    {
        question.text = "";
        text.text = "Giordani responde \"O que aconteceu?\"" + backToQuestion;

        return_to_state(States.cenario_3);
    }

    void state_cenario_3_4()
    {
        change_state(States.cenario_4);
    }

    void state_cenario_4()
    {
        question.text = "Joás após inúmeras expressões inimagináveis, puxa a cadeira da Ludimila (RP da empresa), " + 
                        "senta ao lado do Marllon e solicita uma melhor explicação.\n\n" + 
                        "Contudo em panos limpos, Joás então pergunta: \"Eu quero uma solução, seu iiiiiixxxxcroto, já pensou nela?\"" + availableOptions;

        text.text = "Marllon...\n" +
                    "1) RESPONDE que tentou tratar o problema mas não conseguiu\n" +
                    "2) ESSE bug não é tão sério assim, deve ser outra coisa\n" +
                    "3) CHAMA o desenvolvedor Web (Patrick) e o Mobile (Phillipe) para discutir uma solução\n" +
                    "4) PROPÔE colocar um martelo de \"OURO\" de alta qualidade nesse bug";

        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)) { change_state(States.cenario_4_1); }
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2)) { change_state(States.cenario_4_2); }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3)) { change_state(States.cenario_4_3); }
        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4)) { change_state(States.cenario_4_4); }
    }

    void state_cenario_4_1()
    {
        change_state(States.cenario_5);
    }

    void state_cenario_4_2()
    {
        question.text = "";
        text.text = "Joás responde: \"Eu não quero saber, quero uma aplicação que funcione!\"" + backToQuestion;

        return_to_state(States.cenario_4);
    }

    void state_cenario_4_3()
    {
        question.text = "";
        text.text = "Giordani responde: \"Deixe eles trabalharem agora, afinal de contas já estão atrasados demais com suas demandas.\"" + backToQuestion;

        return_to_state(States.cenario_4);
    }

    void state_cenario_4_4()
    {
        question.text = "";
        text.text = "Joás responde: \"Você está partindo o meu coração Marllon. Eu só tenho me decepcionado com essa equipe.\"" + backToQuestion;

        return_to_state(States.cenario_4);
    }

    void state_cenario_5()
    {
        question.text = "Marllon, após o restante do expediente de trabalho tentando corrigir o bug, chega a uma conclusão:" + availableOptions;

        text.text = "1) DE FATO fizemos tudo as pressas e esse aplicativo não poderá ser liberado hoje. " + 
                        "Precisamos de mais 2 dias para testar e solucionar esse bug.\n" +
                    "2) CHORA...\n" +
                    "3) OLHA para o Giordani\n" + 
                    "4) FAZ uma piada envolvendo Star Wars, dizendo que a \"força não está do meu lado!\"";

        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)) { change_state(States.cenario_5_1); }
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2)) { change_state(States.cenario_5_2); }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3)) { change_state(States.cenario_5_3); }
        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4)) { change_state(States.cenario_5_4); }
    }

    void state_cenario_5_1()
    {
        question.text = "";
        text.text = "Patrick e Phillipe não deixam de perceber a audácia nas palavras de Marllon, que pela primeira vez, " + 
                    "assumiu a posição de Liderança de Equipe e relatou a situação real do projeto, o que chama a atenção " + 
                    "de Joás que automaticamente o abraça, emocionado e informa que tentará ganhar mais 2 dias...\n\n" + 
                    "Pressione ENTER para saber mais sobre o desenrolar dessa história.";

        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            change_state(States.cenario_6);
        }
    }

    void state_cenario_5_2()
    {
        question.text = "";
        text.text = "Joás da um mata-leão em Marllon e diz: \"seu ixxxxxxxxcroto! Vamos ficar sem emprego agora. Já vou acionar a minha network.\"" + backToQuestion;

        return_to_state(States.cenario_5);
    }

    void state_cenario_5_3()
    {
        question.text = "";
        text.text = "Giordani olha de volta" + backToQuestion;

        return_to_state(States.cenario_5);
    }

    void state_cenario_5_4()
    {
        question.text = "";
        text.text = "Um silêncio assustador domina a sala" + backToQuestion;

        return_to_state(States.cenario_5);
    }

    void state_cenario_6()
    {
        question.text = "(Pression J para JOGAR NOVAMENTE)";
        text.fontSize = 21;
        text.text = "Joás conseguiu ganhar mais 2 dias com Dr João, alegando que as entregas sempre foram " +
                    "realizadas nos prazos estipulados e esse foi um cenário raro, mas que toda equipe está trabalhando " +
                    "sem pausa em prol de liberar uma nova release de melhor qualidade.\n\n" +
                    "Após 40 horas trabalhadas em 2 dias, Marllon e sua equipe liberam uma nova release com um " +
                    "martelo de cristal no bug anterior, que por sinal não foi descoberto por completo.\n\n" +
                    "Passaram a noite então, instalando o aplicativo em 1000 tablets.No final da noite, comeram uma pizza e viveram felizes para sempre.";

        if (Input.GetKeyDown(KeyCode.J))
        {
            text.fontSize = 24;
            change_state(States.cenario_1);
        }
    }

}
