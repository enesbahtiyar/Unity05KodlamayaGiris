using UnityEngine;

public class IfElse : MonoBehaviour
{
    [Header("Weather")]
    [Tooltip("To change the activity change this text")]
    public string weather = "Rainy";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (weather == "Rainy")
        {
            Debug.Log("Cinema");
        }
        else if (weather == "Sunny")
        {
            Debug.Log("Picnic");
        }
        else
        {
            Debug.Log("Cleaning Home");
        }



        switch(weather)
        {
            case "Rainy":
                Debug.Log("Cinema");
                break;
            case "Sunny":
                Debug.Log("Picnic");
                break;
            default:
                Debug.Log("Cleaning Home");
                break;
        }
    }
}
