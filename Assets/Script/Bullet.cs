using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private void OnEnable()
    {
        Invoke("Hide", 1);
    }

    void Hide()
    {
        //re-cycle the gameObject

        this.gameObject.SetActive(false);

        Debug.Log("Hiding GameObject");
    }
}
