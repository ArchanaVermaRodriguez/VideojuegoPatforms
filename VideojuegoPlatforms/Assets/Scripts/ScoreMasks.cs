using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreMasks : MonoBehaviour
{
    public static ScoreMasks instance;
    public TextMeshProUGUI text;
    int score; 
    // Start is called before the first frame update
    void Start()
    {
       if(instance == null){
           instance = this;
       } 
    }

    public void ChangeScore(int maskValue){
        score += maskValue;
        text.text = "x" + score.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
