using UnityEngine;

public class Coin : MonoBehaviour
{
    /*
     * VARIABLES
     * 
     */

    public static int coinsCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        Coin.coinsCounter++;
    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);

            Coin.coinsCounter--;
            Debug.Log("Comida");

            if (Coin.coinsCounter.Equals(0))
            {
                Debug.Log("El juego ha terminado");

                GameObject gameManager = GameObject.Find("GameManager");

                GameObject[] firework = GameObject.FindGameObjectsWithTag("Firework");

                foreach (GameObject d in firework)
                {



                    d.GetComponent<ParticleSystem>().Play();

                }



                Destroy(gameManager);
            }

        }

    }
}
