using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Dialogue;
using UnityEngine.SceneManagement;

public class ProgSalon : MonoBehaviour
{
    public float time = 0;
    public GameObject Prof;

    public void Start()
    {
        //PRIMERA VEZ QUE ENTRAS

        if (PlayerPrefs.GetInt("Progress") == 9)
        {
            Prof.SetActive(false);
            int l = PlayerPrefs.GetInt("Lang");

            string[] names =
            {
            "Luciel",
            "EO",
            "Luciel"
            };


            if (l == 1)
            {
                string[] sentences =
                {
                "?Hola?",
                "Creo que no hay nadie.",
                "Pero se supone que ten?amos programaci?n ahora."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 10);
            }


            if (l == 0)
            {
                string[] sentences =
                {
                //TRADUCIR ESTO A INGL?S
                "Hi?",
                "I think there?s nobody here.",
                "But we were supposed to have programming class now."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 10);
            }
        }

        //DESPU?S DEL JUEGO

        if (PlayerPrefs.GetInt("Progress") == 13)
        {
            int l = PlayerPrefs.GetInt("Lang");
            transform.Translate(0,-3,0);

            string[] names =
            {
            "Gaddi",
            "Luciel",
            "EO",
            "EO",
            "Luciel"
            };


            if (l == 1)
            {
                string[] sentences =
                {
                "?Felicidades! Aprobaron mi materia.",
                "?En serio no creen que todo es demasiado simple?",
                "Lu, deja de inventarte cosas, nos quedan 5 materias.",
                "?Seguro que no fumaste lo mismo que la profe de filo?",
                "Perd?n, dorm? 2 horas anoche, seguro son cosas m?as.",
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 14);
            }


            if (l == 0)
            {
                string[] sentences =
                {
                //TRADUCIR ESTO A INGL?S
                "Congratulations! You approved my subject..",
                "Don?t you really think this is too easy?",
                "Lu, stop imagining things, we still have 5 subjects to approve.",
                "Are you sure you didn?t smoke the same that the philosophy teacher smoked?",
                "Sorry, I only slept two hours yesterday, I need to calm down.",
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 14);
            }
        }
    }



    //UPDATE

    public void Update()
    {
        if (PlayerPrefs.GetInt("Progress") == 10 && DialogueTrigger.dialogueActive == false)
        {
            time += Time.deltaTime;
            
            if (time > 2)
            {
                Prof.SetActive(true);
                PlayerPrefs.SetInt("Progress", 11);
            }
        }
        if (PlayerPrefs.GetInt("Progress") == 11 && DialogueTrigger.dialogueActive == false)
        {
            int l = PlayerPrefs.GetInt("Lang");

            string[] names =
            {
            "Gaddi",
            "EO",
            "Luciel",
            "Brun",
            "Gaddi",
            "Gaddi",
            "Masinha",
            "Gaddi",
            "Gaddi"
            };


            if (l == 1)
            {
                string[] sentences =
                {
                "?Hola! Perdonen, vengo del m?dico.",
                "S?, claro, el m?dico.",
                "En fin.",
                "?C?mo podemos aprobar tu materia?",
                "Eehhhh.",
                "?Saben c?digo binario?",
                "?Es eso de los unos y ceros?",
                "S?, b?sicamente.",
                "Supongo que pueden hacer esta prueba entonces."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 12);
            }


            if (l == 0)
            {
                string[] sentences =
                {
                //TRADUCIR A INGL?S
                "Hi! Sorry, I come from the doctor.",
                "Yeah, of course, the doctor.",
                "Anyways.",
                "How can we approve your subject?",
                "Mmmm.",
                "Do you know binary code?",
                "That weird thing of the 1s and 0s?",
                "Yes, basically..",
                "I suppose you can do this test then."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 12);
            }
        }
        if (PlayerPrefs.GetInt("Progress") == 12 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene("ProgramationGame");
        if (PlayerPrefs.GetInt("Progress") == 14 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene("LevelSelector2");
    }
}
