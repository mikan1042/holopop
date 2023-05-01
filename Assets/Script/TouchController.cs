using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    Camera mainCamera;
    PuchiBox puchiBox;

    private void Awake()
    {
        mainCamera = Camera.main;
        puchiBox = GetComponent<PuchiBox>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            var hit = Physics2D.Raycast(mousePos, transform.forward, Mathf.Infinity);
            if (hit)
            {
                hit.transform.TryGetComponent(out Puchi puchi);
                if (puchi && puchi.stick)
                {
                    puchiBox.puchiList.Remove(puchi);
                    Destroy(puchi.gameObject);
                }
            }
        }
    }
}
