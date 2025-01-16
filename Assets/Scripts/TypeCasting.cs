using UnityEngine;

public class TypeCasting : MonoBehaviour
{
    //Iki çesit type casting var 

    //Implicit Casting
    /* Otomatik Olarak yapılır 
     * Küçük çaplı bir data türünden büyük çaplı bir data türüne geçiş yaparken kullandığımız kod dili otomatik olarak geçişi yapar
     */

    int number = 9;
    float floatNumber;


    //Explicit Casting
    /* Manuel olarak yapmanız lazım 
     * Büyük çaplı bir data türünden küçük çaplı bir data türüne geçerken bizim ekstra olarak belirtip geçişi sağladığımız casting türü
     * (hangi türe çevirmek istiyorsam)
     */

    double doubleNumber = 9.71;
    int intNumber;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        intNumber = (int)doubleNumber;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(intNumber);
        Debug.Log(doubleNumber);
    }
}
