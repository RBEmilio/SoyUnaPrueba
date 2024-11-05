using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
   //Hola
   //Adios
    void Start()
    {
        //Inicializamos el PlayerPref "char" en 0
        PlayerPrefs.SetInt("Char", 0);
        PlayerPrefs.Save(); //Guardas las playerPrefs
    }

    void Update()
    {
        
    }

    //Método del botón rojo
    public void RedOne()
    {
        //Colocamos en "char" el valor 1
        PlayerPrefs.SetInt("Char", 1);
        PlayerPrefs.Save(); //Guardamos las especificaciones
        SceneManager.LoadScene("Game"); //Cambio de escena
    }
    //Método del botón verde
    public void GreenOne()
    {
        //Colocamos en "char" el valor 2
        PlayerPrefs.SetInt("Char", 2);
        PlayerPrefs.Save();//Guardamos las especificaciones
        SceneManager.LoadScene("Game");//Cambio de escena
    }
}
