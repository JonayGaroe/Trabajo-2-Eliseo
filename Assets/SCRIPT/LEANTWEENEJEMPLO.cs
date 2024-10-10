using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEANTWEENEJEMPLO : MonoBehaviour
{
    public float movementEjeX;
    public float movementEjeY;
    public float movementEjeZ;
    public float fastmovement = 1.5f;


    public float movementSpeed = 1.5f;

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


        // a la hora de moverse hay q poner ese comando el eje el tiempo el objeto y la animacion que es
        if (Input.GetKeyDown(KeyCode.Space))
        {

            LeanTween.moveY(gameObject, 13.01f, 0.5f).setEase(LeanTweenType.easeInOutBounce).setOnComplete(() =>
            {
                // Cuando la animación en el eje X termina, mover el cubo en el eje x y z
                LeanTween.moveX(gameObject, -2154.55f, 0.5f).setEase(LeanTweenType.easeInOutBounce).setOnComplete(() =>
                {
                    // Cuando la animación en el eje X termina, mover el cubo en el eje x y z
                    LeanTween.moveY(gameObject, 8.85f, 0.5f).setEase(LeanTweenType.easeInOutBounce).setOnComplete(() =>

                    {
                        // Cuando la animación en el eje X termina, mover el cubo en el eje x y z
                        LeanTween.moveX(gameObject, -2162.73f, 0.5f).setEase(LeanTweenType.easeInOutBounce);

                    });

                });

            });









            // el .setOnComplete (() => es para meter una animacion despues de otra se ciertra });
            //   LeanTween.moveY(gameObject, 4f, 0.5f).setEase(animCurve).setOnComplete(() => se cambia desde los type el float


        }
    }
}

