using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public static int taskManager;
    public GameObject canva;
    public GameObject player;
    public GameObject newCamera;
    [SerializeField] private GameObject Barista1;
    [SerializeField] private GameObject Barista2;
    [SerializeField] private GameObject Fatina1;
    [SerializeField] private GameObject Fatina2;
    [SerializeField] private GameObject Cameriera1;
    [SerializeField] private GameObject Pinagente1;
    [SerializeField] private GameObject Pinagente2;
    [SerializeField] private GameObject Pinagente3;
    [SerializeField] private GameObject Pinagente4;
    [SerializeField] private GameObject Pinagente5;
    [SerializeField] private GameObject Lucifero1;
    [SerializeField] private GameObject Polizziotto1;
    [SerializeField] private GameObject Barista;
    [SerializeField] private GameObject Fatina;
    [SerializeField] private GameObject Cameriera;
    [SerializeField] private GameObject Piangente;
    [SerializeField] private GameObject Lucifero;
    [SerializeField] private GameObject Polizziotto;
    [SerializeField] private GameObject Indizio1;
    [SerializeField] private GameObject Indizio2;
    [SerializeField] private GameObject Indizio3;
    [SerializeField] private GameObject SchermataDialogoNera;
    [SerializeField] private GameObject Minigioco;
    [SerializeField] private GameObject Minigioco1;
    [SerializeField] private GameObject Biliardo;
    [SerializeField] private GameObject Biliardo1;
    [SerializeField] private GameObject Cavadavere;
    [SerializeField] private GameObject Biliardo5;

    // Start is called before the first frame update
    void Start()
    {
        taskManager = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Dialogues.canva == true){
            newCamera.SetActive(true);
            newCamera.transform.localPosition = player.transform.localPosition;
            player.SetActive(false);
            canva.SetActive(true);
        }else{
            canva.SetActive(false);
            player.SetActive(true);
            newCamera.SetActive(false);
        }
        if (taskManager == 4){
            //SchermataDialogoNera.SetActive(true);
            Barista.SetActive(false);
            Barista1.SetActive(true);
            Fatina.SetActive(false);
            Fatina1.SetActive(true);
            Cameriera1.SetActive(true);
            //Cameriera.SetActive(false);
        }
        if (taskManager == 9){
            Barista2.SetActive(true);
            Barista.SetActive(false);
        }
        if (taskManager == 10){
            Piangente.SetActive(false);
            Pinagente3.SetActive(true);
        }
        if (taskManager == 11){
            Minigioco.SetActive(false);
            Minigioco.SetActive(true);
        }
        if (taskManager == 12){
            Piangente.SetActive(false);
            Pinagente4.SetActive(true);
        }
        if (taskManager == 13){
            Biliardo.SetActive(false);
            Biliardo1.SetActive(true);
        }
        if (taskManager == 14){
            Piangente.SetActive(false);
            Pinagente5.SetActive(true);
        }
        if (taskManager == 15){
            Polizziotto1.SetActive(true);
        }
        if (taskManager == 16){
            Fatina.SetActive(false);
            Lucifero1.SetActive(true);
        }
        if (taskManager == 17){
            Cavadavere.SetActive(true);
        }
        print(taskManager);
    }
}
