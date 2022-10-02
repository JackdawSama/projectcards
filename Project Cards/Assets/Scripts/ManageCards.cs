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
        for(int i = 0; i < 3; i++)
        {
            SetUpCards(i);
        }
    }

    private void SetUpCards(int spacing)
    {
        GameObject center = GameObject.Find("CoS");
        Vector2 newPos = new Vector3 (center.transform.position.x + (spacing + (spacing - 2) * 1), center.transform.position.y, center.transform.position.z);
        GameObject c = Instantiate(card, newPos, Quaternion.identity);
    }
}
