using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    void Start()
    {
     
    }

    public void Jogar()
    {
        SceneManager.LoadScene("SelecionaPersonagems");
    }
    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void Guerreiro()
    {
        SceneManager.LoadScene("Guerreiro");
    }

    public void Assassino()
    {
        SceneManager.LoadScene("Assassino");
    }

    public void MortoVivo()
    {
        SceneManager.LoadScene("MortoVivo");
    }

    public void EscolhaDirecaoGuerreiro()
    {
        SceneManager.LoadScene("EscolhaDirecaoGuerreiro");
    }

    public void CaminhoDaDireita()
    {
        SceneManager.LoadScene("CaminhoDaDireita");
    }

    public void CaminhoDaEsquerda()
    {
        SceneManager.LoadScene("CaminhoDaEsquerda");
    }

    public void SelecionaPersonagems()
    {
        SceneManager.LoadScene("SelecionaPersonagems");
    }

    public void Venceu()
    {
        SceneManager.LoadScene("Venceu");
    }

    public void VocePerdeu()
    {
        SceneManager.LoadScene("VocePerdeu");
    }
}

