using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndPoint : MonoBehaviour
{

    public int EndScore;
    public GameObject replay;

    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        replay.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        text.text = EndScore.ToString();

        if (EndScore >= 6)
        {
            replay.SetActive(true);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Score")
        {
            EndScore++;
        }
    }


}
