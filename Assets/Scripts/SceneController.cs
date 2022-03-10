using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void HomeScreen()
    {
        SceneManager.LoadScene("HomeScreen");
    }

    public void CreditsScene()
    {
        SceneManager.LoadScene("CreditsScene");
    }

    public void PlanetsMenu()
    {
        SceneManager.LoadScene("PlanetsMenu");
    }

    public void Mercury()
    {
        SceneManager.LoadScene("Mercury");
    }

    public void Venus()
    {
        SceneManager.LoadScene("Venus");
    }

    public void Earth()
    {
        SceneManager.LoadScene("Earth");
    }

    public void Mars()
    {
        SceneManager.LoadScene("Mars");
    }

    public void Jupiter()
    {
        SceneManager.LoadScene("Jupiter");
    }

    public void Saturn()
    {
        SceneManager.LoadScene("Saturn");
    }

    public void Uranus()
    {
        SceneManager.LoadScene("Uranus");
    }

    public void Neptune()
    {
        SceneManager.LoadScene("Neptune");
    }
}
