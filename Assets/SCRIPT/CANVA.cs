using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class CANVA : MonoBehaviour
{
    [SerializeField]
    GameObject popup;

    [SerializeField]
    GameObject background;

    [SerializeField]
    float timeAnim;

    [SerializeField]
    LeanTweenType animCurve;

    //Start is called before the first frame update
    void Start()
    {

        HidePopup();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if ((popup.activeSelf))
               {
                HidePopup();
                }

            else
            {
                ShowPopUp();
            }
        }
    }
    public void ShowPopUp()
        {

            background.SetActive(true);
            popup.SetActive(true);
            LeanTween.moveLocalY(popup, -900f, 0f);
            LeanTween.moveLocalY(popup, 0f, timeAnim).setEase(animCurve);
    
}

    public void HidePopup()
        //LEANTWEEN ES UNA ANIMACIÓN
    {
        LeanTween.moveLocalY(popup, -900f, timeAnim).setEase(animCurve).setOnComplete(() =>
        {
            popup.SetActive(false);
        });
        LeanTween.alphaCanvas(background.GetComponent<CanvasGroup>(), 0f, timeAnim).setOnComplete(() =>
        {
            background.SetActive(false);

        LeanTween.alphaCanvas(background.GetComponent<CanvasGroup>(), 1f,timeAnim);
    });

        }

    // PARA QUE EL ALFA SE PONGA EN 1 PONERLO A 0 SEGUNGOS
   // Canvas GROUP

}
