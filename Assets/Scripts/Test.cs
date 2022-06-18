using UnityEngine;

public class Test : MonoBehaviour // Inherits from MonoBehaviour
{
    public Vector3 movJugador; // Vector3 variable movJugador
    public float speed = 10.0f;
    public Vector3 escalaJugador;
    private int vida = 100;

    void Start()
    {
        transform.localScale += escalaJugador;
    }


    void Update()
    {
        MovimientoJugador();
        DañoJugador();
        Debug.Log("Vida Jugador: " + vida);
    }


    void MovimientoJugador ()
    {
        transform.Translate(movJugador * speed * Time.deltaTime);
    }

    void CuracionJugador()
    {
        vida += 1;
    }

    void DañoJugador()
    {
        vida -= 1;
    }
 
        
}
