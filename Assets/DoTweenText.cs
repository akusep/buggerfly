using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class DoTweenText : MonoBehaviour
{

    public Text teksti;
    public Transform kyltti;

    // Use this for initialization
    void Start()
    {
        teksti.DOText("TEreteksljelskje", 2);
        kyltti.DOScale(2, 2);
    }

}