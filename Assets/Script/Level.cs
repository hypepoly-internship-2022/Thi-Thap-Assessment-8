
using UnityEngine;

public class Level : MonoBehaviour
{

    [SerializeField] private GameObject prefabLevel;
    [SerializeField] private Transform inventory;
    [SerializeField] private int levelUWant;

    void Start()
    {
        spawnBtn(levelUWant);
    }

    void spawnBtn(int idx){
        for(int i=0; i<idx; i++){
            GameObject game = Instantiate(prefabLevel, new Vector3(0,0,0), Quaternion.identity);
            game.transform.SetParent(inventory);
            
            game.name = (i+1).ToString();;
        }   
    }

    void Update()
    {
        
    }
}
