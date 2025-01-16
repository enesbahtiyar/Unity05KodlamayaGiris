using UnityEngine;

public class StringQuestions : MonoBehaviour
{
    //Bir string oluşturun ardından bu stringi consola her bir harfin arasına boşluk koyarak yazdırın



    //Unity6 stringinden 6 harfini çıkarın ve bu cümleninin içinde kaç tane harf olduğunu yazdırın

    string text = "Unity 6 çok fena bir program";
    string newText = string.Empty;

    string unity6 = "Unity6";
    string newtext2 = string.Empty;

    private void Start()
    {
        foreach(char letter in text)
        {
            newText += letter + " ";
        }

        Debug.Log(newText);



        newtext2 = unity6.Replace("6", "");

        Debug.Log(newtext2 + "------" + newtext2.Length);
        
    }
}
