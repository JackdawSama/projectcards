using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageCards : MonoBehaviour
{
    public GameObject card;
    // Start is called before the first frame update
    void Start()
    {
        DisplayCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayCard()
    {
        Instantiate(card, new Vector3 (0, 0, 0), Quaternion.identity);
    }
}
