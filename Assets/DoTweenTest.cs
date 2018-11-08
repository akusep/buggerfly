using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class DoTweenTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DOTween.To(() => transform.position, x => transform.position = x, new Vector3(2, 2, 2), 1)
               .SetEase(Ease.InOutElastic);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
