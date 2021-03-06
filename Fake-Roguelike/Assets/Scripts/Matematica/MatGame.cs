using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MatGame : MonoBehaviour
{
    public int battleTime = 0;
    public float time = 0;
    public GameObject redSmallVertical, redBigVertical, redSmallHorizontal, redBigHorizontal, redSingle, redMarker, purpleBigVertical, purpleBigHorizontal;
    public AudioSource alert, swish, music;
    void Start()
    {
        //NO BORRAR, ESTO SIRVE PARA DEBUGS
        PlayerPrefs.SetFloat("MatSpeed", 0.6f);
        PlayerPrefs.SetInt("Progress", 24);

    }

    void Update()
    {
        if (PlayerPrefs.GetInt("Progress") == 24 || PlayerPrefs.GetInt("Progress") == 25) StageOne();
        if (PlayerPrefs.GetInt("Progress") == 26 || PlayerPrefs.GetInt("Progress") == 27) StageTwo();
        if (PlayerPrefs.GetInt("Progress") == 28 || PlayerPrefs.GetInt("Progress") == 29 || PlayerPrefs.GetInt("Progress") == 30) StageThree();
        if (PlayerPrefs.GetInt("Progress") == 31) End();
        if (PlayerPrefs.GetInt("Progress") == 32 && !DialogueTrigger.dialogueActive) SceneManager.LoadScene("OutsideMat");
        if (battleTime >= 1) time += Time.deltaTime;
    }


    void StageOne()
    {
        if (PlayerPrefs.GetInt("Progress") == 24)
        {
            int l = PlayerPrefs.GetInt("Lang");

            string[] names =
            {
            "Masinha",
            "Masinha",
            "Luciel",
            "Luciel",
            "Karen",
            "Karen",
            "Masinha",
            "Masinha",
            "Jaime",
            "Jaime",
            "Brun",
            "Brun",
            "EO",
            "Masinha",
            "EO",
            "Karen",
            };


            if (l == 1)
            {
                string[] sentences =
                {
                "AAAAAAAAAAAAAAAAAAAAAAAAAAH",
                "??POR QU? SOY UN H?MSTER?!",
                "Viar dijo algo al respecto hace rato?",
                "Creo que esto es parte del escrito de matem?tica.",
                "Hola?",
                "?Est?n listos para ser animales por el resto de sus vidas?",
                "NO.",
                "QUIERO IRME.",
                "Al entrar a este sal?n sellaron su destino?",
                "No pueden escapar.",
                "No.",
                "Pero podemos pasar esto.",
                "No, no podemos, pero vamos a intentar.",
                "?Podr?as ser un poquito menos negativo?",
                "Estoy siendo realista.",
                "Que comience el escrito, entonces.",
            };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 25);
            }


            if (l == 0)
            {
                string[] sentences =
                {
                //TRADUCIR ESTO A INGL?S
                "AAAAAAAAAAAAAAAAAAAAAAAAAAH",
                "WHY AM I A HAMSTER?!!",
                "Viar said something about it a while ago?",
                "I think it?s part of the math test.",
                "Hi?",
                "Are you ready to be animals for the rest of your lives?",
                "NO.",
                "I WANNA GO.",
                "At the moment you came into the class you sealed your destiny?",
                "You cannot escape.",
                "No.",
                "But we can overcome this.",
                "No, we can?t, but we're gonna try.",
                "Could you be a bit less negative ?",
                "I?m being realistic.",
                "Let the test begin, then.",
            };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 25);
            }
        }

        if (PlayerPrefs.GetInt("Progress") == 25 && !DialogueTrigger.dialogueActive && battleTime == 0) { battleTime = 1; time = 0; music.Play(); music.loop = true; }

        //STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 

        if (time > 1 && battleTime == 1) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, 0.39f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 1.2 && battleTime == 2) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, 0.26f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 1.4 && battleTime == 3) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, 0.13f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 1.6 && battleTime == 4) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, 0.00f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 1.8 && battleTime == 5) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, -0.13f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 2 && battleTime == 6) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, -0.26f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 2.2 && battleTime == 7) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, -0.39f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 2.4 && battleTime == 8) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, -0.52f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 2.6 && battleTime == 9) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, -0.65f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 2.8 && battleTime == 10) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, -0.78f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 3 && battleTime == 11) { Instantiate(redBigHorizontal, new Vector3(-1.2f, -0.52f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 4 && battleTime == 12) { Instantiate(redBigHorizontal, new Vector3(-1.2f, -0.13f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 5 && battleTime == 13) { Instantiate(redBigHorizontal, new Vector3(-1.2f, 0.26f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }

        if (time > 6.5 && battleTime == 14)
        {
            Instantiate(redSmallVertical, new Vector3(-1.2f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-1.2f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-1.2f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.72f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.72f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.72f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.24f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.24f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.24f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.24f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.24f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.24f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.72f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.72f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.72f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.96f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.96f, 0.13f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.48f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.48f, 0.13f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0f, 0.13f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.48f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.48f, 0.13f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.96f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.96f, 0.13f, 0), gameObject.transform.rotation);

            battleTime++;

            alert.Play();
        }
        if (time > 7.5 && battleTime == 15)
        {
            Instantiate(redBigHorizontal, new Vector3(-1.2f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redBigHorizontal, new Vector3(-1.2f, -0.52f, 0), gameObject.transform.rotation);
            battleTime++;
            alert.Play();
        }

        if (time > 8.5 && battleTime == 16) { Instantiate(redBigHorizontal, new Vector3(-1.2f, 0f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }

        if (time > 10 && battleTime == 17)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            battleTime++;
            swish.Play();
            PlayerPrefs.SetInt("Progress", 26);
        }
    }

    void StageTwo()
    {
        if (PlayerPrefs.GetInt("Progress") == 26)
        {
            int l = PlayerPrefs.GetInt("Lang");

            string[] names =
            {
            "Luciel",
            "Luciel",
            "Luciel",
            "Luciel",
            "EO",
            "EO",
            "Masinha",
            "Brun",
            };


            if (l == 1)
            {
                string[] sentences =
                {
                 "?Vieron eso?",
                "?Un marcador gigante acaba de volar en el medio del sal?n! ",
                "?Y salen l?pices del piso!",
                "?Esto es imposible!",
                "Los profesores se van a quedar sin l?pices y marcadores eventualmente.",
                "Solo tenemos que aguantar.",
                "Lo dec?s como si fuera f?cil.",
                "Est?n atentos, vamos bien.",
            };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 27);
            }


            if (l == 0)
            {
                string[] sentences =
                {
                //TRADUCIR ESTO A INGL?S
                 "Did you see that?",
                "A giant marker has flown through the room!",
                "And there are pens coming from under the floor!",
                "This is impossible!",
                "The professors are going to run out of items sometime.",
                "We only have to resist.",
                "You?re saying it as if it was easy.",
                "Be careful, we?re doing well.",
            };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 27);
            }
        }

        if ((PlayerPrefs.GetInt("Progress") == 27 && !DialogueTrigger.dialogueActive) && battleTime == 18 || battleTime == 0) { battleTime = 1; time = 0; }

        //STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 

        if (time > 2 && battleTime == 1)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.53f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);
            swish.Play();
            battleTime++;
        }

        if (time > 3 && battleTime == 2)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.14f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);
            swish.Play();
            battleTime++;
        }

        if (time > 4 && battleTime == 3)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.53f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);
            Instantiate(redBigVertical, new Vector3(0.48f, 0.39f, 0), gameObject.transform.rotation);

            swish.Play();
            alert.Play();
            battleTime++;
        }

        if (time > 5 && battleTime == 4)
        {
            Instantiate(redMarker, new Vector3(-1.9f, -0.53f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.14f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redBigVertical, new Vector3(-0.24f, 0.39f, 0), gameObject.transform.rotation);

            swish.Play();
            alert.Play();
            battleTime++;
        }

        if (time > 6 && battleTime == 5)
        {
            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redBigVertical, new Vector3(-0.48f, 0.39f, 0), gameObject.transform.rotation);

            swish.Play();
            alert.Play();
            battleTime++;
        }

        if (time > 7 && battleTime == 6)
        {
            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redBigVertical, new Vector3(-1.2f, 0.39f, 0), gameObject.transform.rotation);

            swish.Play();
            alert.Play();
            battleTime++;
        }

        if (time > 8 && battleTime == 7)
        {
            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.14f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);
            Instantiate(redBigVertical, new Vector3(-0.48f, 0.39f, 0), gameObject.transform.rotation);

            swish.Play();
            alert.Play();
            battleTime++;
        }

        if (time > 10 && battleTime == 8)
        {
            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.53f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.14f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);

            swish.Play();
            battleTime++;
        }

        if (time > 12 && battleTime == 9)
        {
            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.14f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);

            swish.Play();
            battleTime++;
        }

        if (time > 13 && battleTime == 10)
        {
            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.53f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);
            swish.Play();
            battleTime++;
        }

        if (time > 15 && battleTime == 11)
        {
            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.53f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);
            Instantiate(redBigVertical, new Vector3(-1.2f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redBigVertical, new Vector3(0.48f, 0.39f, 0), gameObject.transform.rotation);
            alert.Play();
            swish.Play();
            battleTime++;
        }

        if (time > 18 && battleTime == 12)
        {
            battleTime++;
            PlayerPrefs.SetInt("Progress", 28);
            battleTime = 0;
        }

    }

    void StageThree()
    {
        if (PlayerPrefs.GetInt("Progress") == 28)
        {
            int l = PlayerPrefs.GetInt("Lang");

            string[] names =
            {
            //"Karen & Jaime",
            "Karen",
            "Karen",
            "Karen",
            "Jaime",
            "Luciel",
            "Luciel",
            "Karen",
            };


            if (l == 1)
            {
                string[] sentences =
                {
                "?Acepten que no pueden pasar esto! ",
                "No estudiaron.",
                "No vinieron a una sola clase.",
                "?No podemos permitir que pasen el a?o as?!",
                "Pero? ?No es ilegal hacer eso?",
                "Digo, privar a un estudiante de aprobar un escrito.",
                "?La ley no importa si tengo m?s marcadores y l?pices que ustedes!",
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 29);
            }


            if (l == 0)
            {
                string[] sentences =
                {
                //TRADUCIR ESTO A INGL?S
                "Accept you can?t with this! ",
                "You didn?t study!",
                "You didn?t come to any class!",
                "We?re not gonna allow you to pass like this!",
                "But? isn?t that illegal?",
                "I mean, deprive a student of passing.",
                "The law doesn?t matter if I have more pencils and markers than you!",
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 29);
            }
        }

        if ((PlayerPrefs.GetInt("Progress") == 29 && !DialogueTrigger.dialogueActive)) { battleTime = 1; time = 0; PlayerPrefs.SetInt("Progress", 30); }

        //STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 

        if (time > 2 && battleTime == 1)
        {
            Instantiate(redBigVertical, new Vector3(-0.72f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redBigVertical, new Vector3(0.00f, 0.39f, 0), gameObject.transform.rotation);

            alert.Play();
            battleTime++;
        }

        if (time > 3 && battleTime == 2)
        {
            Instantiate(redSmallVertical, new Vector3(-1.2f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-1.2f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-1.2f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.72f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.72f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.72f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.24f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.24f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.24f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.24f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.24f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.24f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.72f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.72f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.72f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.96f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.96f, 0.13f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.48f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.48f, 0.13f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0f, 0.13f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.48f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.48f, 0.13f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.96f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.96f, 0.13f, 0), gameObject.transform.rotation);


            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.14f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);

            swish.Play();
            battleTime++;

            alert.Play();
        }

        if (time > 4 && battleTime == 3)
        {
            Instantiate(redSmallVertical, new Vector3(-1.2f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-1.2f, -0.39f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.72f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.72f, -0.39f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.24f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.24f, -0.39f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.24f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.24f, -0.39f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.72f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.72f, -0.39f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.96f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.96f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.96f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.48f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.48f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.48f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.48f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.48f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.48f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.96f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.96f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.96f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.53f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);

            swish.Play();
            battleTime++;

            alert.Play();

        }

        if (time > 5 && battleTime == 4)
        {
            Instantiate(redSmallVertical, new Vector3(-1.2f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-1.2f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-1.2f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.72f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.72f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.72f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.24f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.24f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.24f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.24f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.24f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.24f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.72f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.72f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.72f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.96f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.96f, 0.13f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.48f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.48f, 0.13f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0f, 0.13f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.48f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.48f, 0.13f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.96f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.96f, 0.13f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.14f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);

            swish.Play();
            battleTime++;

            alert.Play();
        }

        if (time > 6 && battleTime == 5)
        {
            Instantiate(redSmallVertical, new Vector3(-1.2f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-1.2f, -0.39f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.72f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.72f, -0.39f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.24f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.24f, -0.39f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.24f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.24f, -0.39f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.72f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.72f, -0.39f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.96f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.96f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.96f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.48f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.48f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.48f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.48f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.48f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.48f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.96f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.96f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.96f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.53f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);


            battleTime++;

            swish.Play();
            alert.Play();

        }

        if (time > 8 && battleTime == 6)
        {
            Instantiate(purpleBigVertical, new Vector3(-1.2f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(purpleBigVertical, new Vector3(0.48f, 0.39f, 0), gameObject.transform.rotation);

            battleTime++;

            alert.Play();
        }

        if (time > 10 && battleTime == 7)
        {
            Instantiate(redSmallHorizontal, new Vector3(-0.48f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSingle, new Vector3(0.00f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallHorizontal, new Vector3(0.00f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSingle, new Vector3(-0.24f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallHorizontal, new Vector3(-0.48f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSingle, new Vector3(0.00f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallHorizontal, new Vector3(0.00f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSingle, new Vector3(-0.24f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallHorizontal, new Vector3(-0.48f, -0.65f, 0), gameObject.transform.rotation);
            Instantiate(redSingle, new Vector3(0.00f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.53f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.14f, 0), gameObject.transform.rotation);

            battleTime++;

            swish.Play();
            alert.Play();
        }

        if (time > 11 && battleTime == 8)
        {
            Instantiate(redSmallHorizontal, new Vector3(-0.48f, 0.26f, 0), gameObject.transform.rotation);
            Instantiate(redSingle, new Vector3(0.00f, 0.26f, 0), gameObject.transform.rotation);
            Instantiate(redSmallHorizontal, new Vector3(0.00f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redSingle, new Vector3(-0.24f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redSmallHorizontal, new Vector3(-0.48f, -0.26f, 0), gameObject.transform.rotation);
            Instantiate(redSingle, new Vector3(0.00f, -0.26f, 0), gameObject.transform.rotation);
            Instantiate(redSmallHorizontal, new Vector3(0.00f, -0.52f, 0), gameObject.transform.rotation);
            Instantiate(redSingle, new Vector3(-0.24f, -0.52f, 0), gameObject.transform.rotation);
            Instantiate(redSmallHorizontal, new Vector3(-0.48f, -0.78f, 0), gameObject.transform.rotation);
            Instantiate(redSingle, new Vector3(0.00f, -0.78f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.14f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);


            battleTime++;

            swish.Play();
            alert.Play();
        }

        if (time > 13 && battleTime == 9)
        {
            Instantiate(purpleBigHorizontal, new Vector3(-1.2f, -0.52f, 0), gameObject.transform.rotation);
            Instantiate(purpleBigHorizontal, new Vector3(-1.2f, -0.13f, 0), gameObject.transform.rotation);

            battleTime++;

            alert.Play();
        }

        if (time > 15 && battleTime == 10)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);

            battleTime++;

            swish.Play();
        }

        if (time > 16 && battleTime == 11)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);

            battleTime++;

            swish.Play();
        }

        if (time > 17 && battleTime == 12)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);

            battleTime++;

            swish.Play();
        }

        if (time > 18 && battleTime == 13)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);

            battleTime++;

            swish.Play();
        }

        if (time > 19 && battleTime == 14)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);

            battleTime++;

            swish.Play();
        }

        if (time > 20 && battleTime == 15)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);

            battleTime++;

            swish.Play();
        }

        if (time > 20 && battleTime == 16)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);

            battleTime++;

            swish.Play();
        }

        if (time > 22 && battleTime == 17)
        {
            Instantiate(purpleBigHorizontal, new Vector3(-1.2f, 0.26f, 0), gameObject.transform.rotation);

            battleTime++;

            alert.Play();
        }

        if (time > 24 && battleTime == 18)
        {
            PlayerPrefs.SetInt("Progress", 31);
        }
    }

    void End()
    {
        int l = PlayerPrefs.GetInt("Lang");

        string[] names =
        {
            "Luciel",
            "Luciel",
            "Masinha",
            "Brun",
            "Luciel",
            "EO",
            "EO",
            "Karen",
            "Luciel",
            "Jaime",
            "Jaime",

            };


        if (l == 1)
        {
            string[] sentences =
            {
            "?R?pido! ",
            "?El resultado es 2! ?Escriban eso!",
            "??Est?s seguro?!",
            "Es nuestra ?nica oportunidad.",
            "Estoy tan seguro como puedo estarlo. ",
            "Confiemos, entonces.",
            "No tenemos una respuesta mejor de todas formas.",
            "?Est?n listos?",
            "S?.",
            "Damos el escrito por terminado, entonces.",
            "Esperen afuera, va a tomar un rato corregirlo.",
            };

            Dialogue.names = names;
            Dialogue.sentences = sentences;
            DialogueTrigger.dialogueActive = true;
            PlayerPrefs.SetInt("Progress", 32);
        }


        if (l == 0)
        {
            string[] sentences =
            {
                //TRADUCIR ESTO A INGL?S
            "Fast! ",
            "The result is 2! Write that!",
            "You sure?!",
            " It?s our only opportunity",
            "I?m as sure as I can be. ",
            "Let?s trust him then.",
            "We don?t have a better answer anyways.",
            "Are you ready?",
            "Yes.",
            "The test is done then.",
            "Wait outside, we?re going to correct it and it will take a while.",
            };

            Dialogue.names = names;
            Dialogue.sentences = sentences;
            DialogueTrigger.dialogueActive = true;
            PlayerPrefs.SetInt("Progress", 32);
        }
    }
}
