using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class score_and_time : MonoBehaviour
{
    float timer = 90f;
    public int score = 0;
    [SerializeField] Slider s;
    [SerializeField] TMP_Text scores;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scores.text = score.ToString();
        timer -= Time.deltaTime;
        if(timer >= 0f)
        {
            s.value = timer;
        }
        if(timer < 0f)
        {
            //finish game move to next scene
        }
    }
}
