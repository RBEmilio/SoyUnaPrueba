using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Renderer render;

    public int charNum;

    public Material matrRed;
    public Material matrGreen;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();
        charNum = PlayerPrefs.GetInt("Char");

    }

    // Update is called once per frame
    void Update()
    {
        EstablecerColor();
    }

    public void EstablecerColor()
    {
        switch (charNum)
        {
            case 0:
                Debug.Log("Error");
                break;
            case 1:
                render.material = matrRed;
                break;
            case 2:
                render.material = matrGreen;
                break;
            default:
                Debug.Log("Error, no encontrado");
                break;
        }
    }
}
