using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.EventSystems;



public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

    public List<string> Reds = new List<string>();
    public List<string> Blues = new List<string>();
    public List<string> Greens = new List<string>();

    public GameObject SuccessText;


    //public List<string> Colors = new List<string>(new string[] { "red", "blue", "green" });

    public void OnPointerEnter(PointerEventData eventData) {

        if (eventData.pointerDrag == null)
            return;

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            d.placeHolderParent = this.transform;
        }
    }

    public void OnPointerExit(PointerEventData eventData) {

        if (eventData.pointerDrag == null)
            return;

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null && d.placeHolderParent == this.transform)
        {
            d.placeHolderParent = d.parentToReturnTo;
        }
    }

    public void OnDrop(PointerEventData eventData) {
        //Random.Range(0, 4);
        // Debug.Log(eventData.pointerDrag.name + " dropped on " + gameObject.name + " tag: " + eventData.pointerDrag.tag);

        switch (eventData.pointerDrag.tag)
        {
            case "red":
                Reds.Add(eventData.pointerDrag.tag);
                if (Reds.Count == 3) {
                    Debug.Log("red " + Reds.Count);
                    SuccessText.SetActive(true);

                }
                break;
            case "blue":
                Blues.Add(eventData.pointerDrag.tag);
                if (Blues.Count == 3)
                {
                    Debug.Log("blue " + Blues.Count);
                    SuccessText.SetActive(true);

                }
                break;
            case "green":
                Greens.Add(eventData.pointerDrag.tag);
                if (Greens.Count == 3)
                {
                    Debug.Log("green " + Greens.Count);
                    SuccessText.SetActive(true);

                }
                break;
            default:
                Debug.Log("color not found");
                break;
        }

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null) {
            d.parentToReturnTo = this.transform;
        }
    }
}
