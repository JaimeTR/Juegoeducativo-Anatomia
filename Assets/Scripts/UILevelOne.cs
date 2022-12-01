using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class UILevelOne : MonoBehaviour
{
    public GameObject imgHumanModel;
    public GameObject imgHeart;
    public GameObject imgBrain;
    public GameObject imgLungs;
    public GameObject imgLiver;
    public GameObject imgKidneys;
  //  public GameObject tempOrgan;
    public GameObject tempNext;

    private Vector3 origin, ans1, ans2, ans3, ans4;

    public TMP_Text txtQuestion;
    public TMP_Text txtEnd;

    public GameObject btnRight;
    public GameObject btnWrong1;
    public GameObject btnWrong2;
    public GameObject btnWrong3;

    private int quizQuestion = 0;

    List<string> questions = new List<string>()
        {
            " ¿Que organo es este?",
            " El cerebro podría ser considerado: ",
            " ¿Qué órgano es este?",
            " La función principal del corazón es: ",
            " ¿Qué órgano es este?",
            " Los pulmones principalmente: ",
            " ¿Qué órgano es este?",
            " Los riñones ayudan a: ",
            " ¿Qué órgano es este?",
            " Una de las principales funciones del hígado es: "
        };

    List<string> rightAnswers = new List<string>()
        {
            " Cerebro",
            " El centro de control del cuerpo.",
            " Corazón",
            " Bombear sangre por todo el cuerpo.",
            " Pulmones",
            " Llevar oxígeno a su sangre.",
            " Riñones",
            " Mantén tu cuerpo limpio de desechos.",
            " Hígado",
            " Almacenar combustible para su cuerpo."
        };

        List<string> wrongAnswers1 = new List<string>()
        {
            " Corazón",
            " La parte menos importante del cuerpo.",
            " Cerebro",
            " Digerir comida.",
            " Intestino delgado",
            " Eliminar los desechos del cuerpo.",
            " Pulmones",
            " Expande tu pecho cuando respiras.",
            " Vejiga",
            " Avisarle cuando su cuerpo tiene hambre."
        };

        List<string> wrongAnswers2 = new List<string>()
        {
            " Vesícula biliar",
            " El órgano más duradero de su cuerpo.",
            " Riñones",
            " Eliminar los desechos del cuerpo.",
            " Bazo",
            " Almacenar agua para su uso posterior.",
            " Estómago",
            " Mantén tu cuerpo caliente.",
            " Arterias",
            " Almacenar sangre del corazon"
        };

        List<string> wrongAnswers3 = new List<string>()
        {
            " Glándula pituitaria",
            " El órgano más pequeño de tu cuerpo.",
            " Hígado",
            " Controlar el sistema nervioso",
            " Corazón",
            " Lleva dióxido de carbono a la sangre.",
            " Cerebelo",
            " Almacenar grasa del cuerpo",
            " Cerebro",
            " Ayudar a fortalecer sus músculos."
        };

    int lvlPage = 0;

    // Start is called before the first frame update
    private void Start()
    {
        ans1 = btnRight.transform.position;
        ans2 = btnWrong1.transform.position;
        ans3 = btnWrong2.transform.position;
        ans4 = btnWrong3.transform.position;
        origin = imgHeart.transform.position;
        tempNext = GameObject.Find("BrainNext");
        UpdatePage(lvlPage);
        Debug.Log(tempNext.name);
    }

    public void NextPage()
    {
        lvlPage++;
        UpdatePage(lvlPage);
    }

    public void BackPage()
    {
        lvlPage--;
        UpdatePage(lvlPage);
    }
    
    void initIntro()
    {
        imgHeart.transform.position = new Vector3(-1000,-1000, 0);
        imgLungs.transform.position = new Vector3(-1000, -1000, 0);
        imgLiver.transform.position = new Vector3(-1000, -1000, 0);
        imgKidneys.transform.position = new Vector3(-1000, -1000, 0);

        imgBrain.SetActive(true);
    }

    void QuizTime(bool isQuiz)
    {
        if(isQuiz == true) {
            txtQuestion.text = questions[quizQuestion];
            btnRight.GetComponentInChildren<TMP_Text>().text = rightAnswers[quizQuestion];
            btnWrong1.GetComponentInChildren<TMP_Text>().text = wrongAnswers1[quizQuestion];
            btnWrong2.GetComponentInChildren<TMP_Text>().text = wrongAnswers2[quizQuestion];
            btnWrong3.GetComponentInChildren<TMP_Text>().text = wrongAnswers3[quizQuestion];
           
            quizQuestion++;
        }
        else { 
            txtQuestion.text = "Arrastre el órgano al lugar correcto en el modelo.";
        }
        btnRight.SetActive(isQuiz);
        btnWrong1.SetActive(isQuiz);
        btnWrong2.SetActive(isQuiz);
        btnWrong3.SetActive(isQuiz);

    }

    void ChangeOrder(GameObject num1, GameObject num2, GameObject num3, GameObject num4) {
        num1.transform.position = ans1;
        num2.transform.position = ans2;
        num3.transform.position = ans3;
        num4.transform.position = ans4;
    }

    void UpdatePage(int page)
    {
        switch (page)
        {
            case 0:
                QuizTime(false);
                initIntro();
                break;
            case 1:
                QuizTime(true);
                break;
            case 2:
                ChangeOrder(btnWrong2, btnWrong3, btnRight, btnWrong1);
                QuizTime(true);
                break;
            case 3:
                QuizTime(false);
                imgHeart.transform.position = origin;
                imgHeart.SetActive(true);
                tempNext = GameObject.Find("HeartNext");
                break;
            case 4:
                ChangeOrder(btnRight, btnWrong3, btnWrong2, btnWrong1);
                QuizTime(true);
                break;
             case 5:
                ChangeOrder(btnWrong2, btnWrong3, btnWrong1, btnRight);
                QuizTime(true);
                break;
            case 6:
                QuizTime(false);
                imgLungs.transform.position = origin;
                imgLungs.SetActive(true);
                tempNext = GameObject.Find("LungsNext");
                break;
            case 7:
                ChangeOrder(btnWrong2, btnWrong3, btnRight, btnWrong1);
                QuizTime(true);
                break;
            case 8:
                QuizTime(true);
                break;
            case 9:
                QuizTime(false);
                imgKidneys.transform.position = origin;
                imgKidneys.SetActive(true);
                tempNext = GameObject.Find("KidneysNext");
                break;
            case 10:
                ChangeOrder(btnWrong2, btnWrong3, btnWrong1, btnRight);
                QuizTime(true);
                break;
            case 11:
                ChangeOrder(btnWrong2, btnRight, btnWrong3, btnWrong1);
                QuizTime(true);
                break;
            case 12:
                QuizTime(false);
                imgLiver.transform.position = origin;
                imgLiver.SetActive(true);
                tempNext = GameObject.Find("LiverNext");
                break;
            case 13:
                ChangeOrder(btnRight, btnWrong3, btnWrong1, btnWrong2);
                QuizTime(true);
                break;
            case 14:
                ChangeOrder(btnWrong1, btnRight, btnWrong3, btnWrong2);
                QuizTime(true);
                break;
            case 15:
                QuizTime(false);
                txtQuestion.text = "";
                txtEnd.text = "¡Felicidades! Ahora puede identificar algunos de los principales órganos del cuerpo humano.";
                break;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        if (tempNext.activeSelf == false && btnRight.activeSelf == false)
        {
            NextPage();
        }
    }
}
