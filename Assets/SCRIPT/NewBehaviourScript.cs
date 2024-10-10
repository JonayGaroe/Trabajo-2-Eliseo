using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    float timeAnim;


    [SerializeField]
    GameObject sumas;
    
    int cuenta = 0;
    //[SerializeField]
    public TextMeshProUGUI cuentaText;

    // Start is called before the first frame update
    void Start()
    {
    

        cuenta = 0;


    }

    // Update is called once per frame
    void Update()
    {
        cuentaText.text = cuenta.ToString();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if ((sumas.activeSelf))
            {
                cuentaatras();
                cuenta = cuenta + 1;
            }
        }
    }
    public void cuentaatras()
    {
        cuenta = cuenta + 1;
        LeanTween.scale(sumas, Vector3.one * 0.5f, 0.0f);
        LeanTween.scale(sumas, Vector3.one * 0.8f, 0.5f).setEaseOutElastic();

    }

}



// puntuacion = puntuacion + 1;
// textoContador.text = puntuacion.ToString();






//LeanTween.scale(cuenta, Vector3.one * 0.5f, TimeAnim).setEase(LeanTweenType.easeOutElastic);
//LeanTween.scale(cuenta, Vector3.one * 0.5f, TimeAnim).setEase(LeanTweenType.easeOutElastic);
