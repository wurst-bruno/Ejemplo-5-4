//9. Realizá un programa que resuelva el siguiente problema:  
//Tres personas aportan diferente capital a una sociedad.Se desea saber qué porcentaje del total aportó 
//cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado  por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego  
//mostrar lo pedido en el siguiente formato:  
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej09 : MonoBehaviour
{

    public string persona1;
    public string persona2;
    public string persona3;

    public float CapitalAportado1;
    public float CapitalAportado2;
    public float CapitalAportado3;

    float Porcentaje1;
    float Porcentaje2;
    float Porcentaje3;

    float Total;


    // Start is called before the first frame update
    void Start()
    {
        Total = CapitalAportado1 + CapitalAportado2 + CapitalAportado3;

        Porcentaje1 = CapitalAportado1 / Total * 100;
        Porcentaje2 = CapitalAportado2 / Total * 100;
        Porcentaje3 = CapitalAportado3 / Total * 100;

        Debug.Log("Nombre: " + persona1 +  " capital aportado: $" + CapitalAportado1 + ", Porcentaje del capital: %" + Porcentaje1 + ", Monto total aportado: $" + Total );
        Debug.Log("Nombre: " + persona2 + " capital aportado: $" + CapitalAportado2 + ", Porcentaje del capital: %" + Porcentaje2 + ", Monto total aportado: $" + Total);
        Debug.Log("Nombre: " + persona3 + " capital aportado: $" + CapitalAportado3 + ", Porcentaje del capital: %" + Porcentaje3 + ", Monto total aportado: $" + Total);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
