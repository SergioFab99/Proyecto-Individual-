using UnityEngine;
using TMPro; // Espacio de nombres para Text Mesh Pro

public class ContadorEnemigos : MonoBehaviour
{
    // Referencia al componente TMP_Text del objeto Text Mesh Pro UI
    public TMP_Text textoEnemigos;

    // Variable para almacenar la cantidad de enemigos en la escena
    private int cantidadEnemigos;

    // Método que se ejecuta al iniciar el juego
    private void Start()
    {
        // Obtener la cantidad de enemigos en la escena usando el método GameObject.FindGameObjectsWithTag
        cantidadEnemigos = GameObject.FindGameObjectsWithTag("Enemy1").Length;

        // Asignar el texto al componente TMP_Text usando la propiedad text
        textoEnemigos.text = "Enemigos: " + cantidadEnemigos;
    }

    // Método que se ejecuta cada frame
    private void Update()
    {
        // Obtener la nueva cantidad de enemigos en la escena
        int nuevaCantidad = GameObject.FindGameObjectsWithTag("Enemy1").Length;

        // Si la nueva cantidad es diferente a la anterior, actualizar la variable y el texto
        if (nuevaCantidad != cantidadEnemigos)
        {
            cantidadEnemigos = nuevaCantidad;
            textoEnemigos.text = "Enemigos: " + cantidadEnemigos;
        }
    }
}
