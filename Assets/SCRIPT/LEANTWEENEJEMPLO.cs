using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEANTWEENEJEMPLO : MonoBehaviour
{
    public float movementEjeX;
    public float movementEjeY;
    public float movementEjeZ;
    public float fastmovement = 1.5f;


    public float movementSpeed = 1.5;

    // LeanTween.scale(GameObject, vector3.one * seteasy(LeanTweenType.easeOutElastic) para animar un 0objeto rapido

    // [SerializeField]
  //  LeanTweenType animCurve;

  //  [SerializeField]
  //  float sizeToScale = 2f;


     //[SerializeField]
 //  float durationAnim = 0.75f;

    
    // [SerializeField]
    //float finalYPos = 0.5f;
     
    // Start is called before the first frame update
    void Start()
    {

       // LeanTween.scale(gameObject, Vector3.one * 2,0.75f);
      //  LeanTween.moveLocalY(gameObject, 0.5f, durationAnim).setEase(LeanTweenType.easeInOutElastic);
    }
    // LeanTween.moveLocalY(gameObject, 0.5 , durationanim).setEase(LeanTweenType.easeInOutElastic);
    // Update is called once per frame
    void Update()
    {
        transform.Translate(movementEjeX, movementEjeY, movimientoEjeZ);

        Vector3 movement = new Vector3();

        if (Input.GetKeyDown(KeyCode.Space))
        {
         


        }




    }
}
