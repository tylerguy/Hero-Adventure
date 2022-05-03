using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour
{
    public float health;
    [SerializeField] private Image HealthBarImage;

    // Start is called before the first frame update
    void Start()
    {


        health = 1f;


    }

    // Update is called once per frame
    void Update()
    {
        HealthBarImage.fillAmount = health;

        if (HealthBarImage.fillAmount <= 1f)
        {
            HealthBarImage.color = Color.green;
        }
        if (HealthBarImage.fillAmount <= 0.7f)
        {
            HealthBarImage.color = Color.yellow;
        }
        if (HealthBarImage.fillAmount <= 0.3f)
        {
            HealthBarImage.color = Color.red;
        }
    }
}