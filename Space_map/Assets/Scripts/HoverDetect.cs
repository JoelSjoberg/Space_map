using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverDetect : MonoBehaviour {



    private void OnMouseEnter()
    {
        transform.localScale = transform.localScale * 2f;
    }

    private void OnMouseExit()
    {
        transform.localScale = transform.localScale / 2f;
    }
}
