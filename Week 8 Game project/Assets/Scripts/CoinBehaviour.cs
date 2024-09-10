using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    [SerializeField] private float value = 5;
    public ScoreBehaviour scoreBehaviour;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnPickup(){
        score.currentScore += value;
    }
    void OnCollisionEnter(Collision collision){
        if(collision.tag == "Player"){
            OnPickup();
        }
    }

}
