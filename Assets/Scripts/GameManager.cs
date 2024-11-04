using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Inicializamos una variable del tipo "render", para manegar el aspecto
    private Renderer render;

    //Variable donde almacenar el playerPref
    public int charNum;

    //Dos variables para pasarle por el inspector los dos materiales
    public Material matrRed;
    public Material matrGreen;


    void Start()
    {
        //Obtengo el componente render del game object asociado al script
        render = GetComponent<Renderer>();

        //Guardamos el playerPref en la varible charNum
        charNum = PlayerPrefs.GetInt("Char");

    }

    // Update is called once per frame
    void Update()
    {
        //llamada al método Establecer color, tambien se puede llamar en el start
        EstablecerColor();
    }

    //método para establecer el color. Puede ser privado.
    public void EstablecerColor()
    {
        //Lee el charNum y busca a que caso corresponde.
        switch (charNum)
        {
            case 0:
                Debug.Log("Error"); //Si charNum = 0, ocurre esto.
                break;
            case 1:
                render.material = matrRed; //Si charNum = 1, coloca el material rojo.
                break;
            case 2:
                render.material = matrGreen; //Si charNum = 2, coloca el material verde.
                break;
            default:
                Debug.Log("Error, no encontrado"); //Si charNum = 1, ocurra esto.
                break;
        }
    }
}
