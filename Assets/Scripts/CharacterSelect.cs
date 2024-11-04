using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Char", 0);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void RedOne()
    {
        PlayerPrefs.SetInt("Char", 1);
        PlayerPrefs.Save();
        SceneManager.LoadScene("Game");
    }

    public void GreenOne()
    {
        PlayerPrefs.SetInt("Char", 2);
        PlayerPrefs.Save();
        SceneManager.LoadScene("Game");
    }
}
