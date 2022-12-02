using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Btn : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textLevel;
    [SerializeField] private GameObject[] star = new GameObject[3];

    private TextMeshProUGUI text;
    private Image star1;
    private Image star2;
    private Image star3;
    private int ranStar;
    // Start is called before the first frame update
    void Start()
    {
        text = textLevel.GetComponent<TextMeshProUGUI>();
        star1 = star[0].GetComponent<Image>();
        star2 = star[1].GetComponent<Image>();
        star3 = star[2].GetComponent<Image>();
        text.text = this.name;

        RandomStar();
    }

    public void OnClickBtnLevel(){
        Debug.Log("Click: " + this.name);
    }

    void RandomStar(){
        ranStar = Random.Range(0,4);

        switch(ranStar){
            case 0:
                break;
            case 1: 
                star1.color = Color.white;
                break;
            case 2: 
                star1.color = Color.white;
                star2.color = Color.white;
                break;
            case 3: 
                star1.color = Color.white;
                star2.color = Color.white;
                star3.color = Color.white;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
