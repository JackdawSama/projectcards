using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards : MonoBehaviour
{
    private bool cardRevealed = false;
    public Color faceColour;
    public Color backColour;
    // Start is called before the first frame update
    void Start()
    {
        HideCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideCard()
    {
        GetComponent<SpriteRenderer>().color = backColour;
        cardRevealed = false;
    }

    public void RevealCard()
    {
        GetComponent<SpriteRenderer>().color = faceColour;
        cardRevealed = true;
    }

    public void OnMouseDown() 
    {
        if(!cardRevealed)
        {
            RevealCard();
            Debug.Log(cardRevealed);
        }
        else
        {
            HideCard();
            Debug.Log(cardRevealed);
        }
    }
}
