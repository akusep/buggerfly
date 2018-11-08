using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class MyTweens : MonoBehaviour
{

    public Text teksti;
    public Transform akunKyltti;
    public Transform marianKyltti;
    public Transform playButton;


    // Use this for initialization
    void Start()
    {
        teksti.DOText("BUGGERFLY", 2);

        playButton.DOPunchScale(new Vector3(0.2f, 0.2f, 0.2f), 1.5f, 7, 1)
        .SetLoops(-1)
            .SetDelay(3);


      //  akunKyltti.DOScale(1.05f, 1)
      //        .SetLoops(-1)
      //        .SetEase(Ease.OutElastic);

      //  marianKyltti.DOScale(1.05f, 1)
      //.SetLoops(-1)
      //.SetDelay(0.5f)
      //.SetEase(Ease.OutElastic);
    }

}