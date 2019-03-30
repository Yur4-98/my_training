using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyController : MonoBehaviour
{
    public GameObject TextObject;
    Text textComponent;
    public int coin;

    // Start is called before the first frame update
    void Start()
    {
        textComponent = TextObject.GetComponent<Text>();
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "coin")
        {
            coin = coin + 1;
            textComponent.text = coin.ToString() + "/5";
            Destroy(other.gameObject);
        }
    }
}


