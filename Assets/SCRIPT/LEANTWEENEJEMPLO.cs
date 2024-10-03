using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEANTWEENEJEMPLO : MonoBehaviour
{

    //  LeanTween.scale(GameObject, vector3.one * seteasy(LeanTweenType.easeOutElastic) para animar un 0objeto rapido
   //  [SerializeField]
   // float sizeToScale = 2f;


   //  [SerializeField]
  //  float durationAnim = 0.75f;

    
    // [SerializeField]
   //  float finalYPos = 0.5f;
     
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.scale(gameObject, Vector3.one * 2,0.75f);
    }
    // LeanTween.moveLocalY(gameObject, 0.5 , durationanim).setEase(LeanTweenType.easeInOutElastic);
    // Update is called once per frame
    void Update()
    {
       
    }
}
