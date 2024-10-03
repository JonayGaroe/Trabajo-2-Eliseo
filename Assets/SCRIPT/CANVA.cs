using System.Collections;
using System.Collections.Generic;
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
        background.SetActive(false);
        popup.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            background.SetActive(true);
        popup.SetActive(true);
            LeanTween.moveLocalY(popup, -900f, 0f);
            LeanTween.moveLocalY(popup, 0f, timeAnim).setEase(animCurve);
        }
    }
}
