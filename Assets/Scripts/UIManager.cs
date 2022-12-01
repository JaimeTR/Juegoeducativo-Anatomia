using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    [Header("Title Scene", order = 0)]
    [Space(2f)]
    [Header("Intro Scene", order = 1)]
    public GameObject imgIntro;
    public GameObject btnBack;
    public GameObject btnNext;
    public TMP_Text txtIntro;
    [Space(2f)]
    [Header("Tutorial Scene", order = 2)]
    [Space(2f)]
    [Header("Level Scene", order = 3)]

    
    int introPage = 0;
    Scene currentScene;

    // Start is called before the first frame update
    private void Start()
    {
      //  Debug.Log();
    }

    public void SetScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

    }

    private void Awake()
    {
        //Debug.Log("change");
        currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "01IntroScene")
        {
            //Debug.Log("intro");
            initIntro();
        }
    }

    public void IntroNext()
    {
        introPage++;
        UpdateIntro(introPage);
    }

    public void IntroBack()
    {
        introPage--;
        UpdateIntro(introPage);
    }

    void initIntro()
    {
        txtIntro.fontSize = 20;
        txtIntro.horizontalAlignment = HorizontalAlignmentOptions.Center;
        txtIntro.text = "¿Qué hay dentro de nuestros cuerpos?\n\nAprende sobre los principales órganos del cuerpo y sus funciones";
        imgIntro.SetActive(true);
        btnBack.SetActive(false);
    }

    void UpdateIntro(int page)
    {
        switch (page)
        {
            case 0:
                initIntro();
                break;
            case 1:
                txtIntro.fontSize = 22;
                txtIntro.horizontalAlignment = HorizontalAlignmentOptions.Left;
                txtIntro.text = "Visión general\n\n" + "TITULO: ¿Qué hay dentro de nuestros cuerpos?\n" +
                "GRUPO: Desarrollado por el grupo04\n" + 
                "TEMA: Anatomía Humana\n" +
                "ENFOQUE PRINCIPAL: Aprender sobre los principales órganos del cuerpo y sus funciones.\n\n" +
                "NIVEL DE APRENDIZAJE: Grado 3-6\n";
                imgIntro.SetActive(false);
                btnBack.SetActive(true);
                break;
            case 2:
                txtIntro.text = "JUEGO EDUCATIVO - ANATOMIA\n" +
                "\nA muchos estudiantes jóvenes les resulta difícil aprender de un libro de texto y prefieren aprender a través de la estimulación visual. Por lo tanto, propongo desarrollar una simulación interactiva donde los estudiantes interactúen con un modelo virtual del cuerpo humano." +
                "\nPretendo que los usuarios arrastren y suelten diferentes órganos y los combinen con sus siluetas correspondientes en el modelo humano. Deseo construir dos tipos diferentes de texturas para estos órganos: un conjunto de modelos con colores realistas y otro con imágenes brillantes. Planeo que el usuario seleccione su modelo de textura preferido para jugar, ya sea la versión realista o la brillante codificada por colores (si esto es demasiado complicado, planeo mantener las texturas codificadas por colores)." +
                "\nDespués de cada partido, planeo activar una ventana emergente con una pregunta de prueba relevante sobre el órgano que el usuario debe responder. Después de esta pregunta, planeo proporcionar definiciones/información complementaria para conectar visualmente la información con el órgano respectivo. Al final del nivel, planeo tener una pequeña prueba (opcional) usando la información de esas ventanas emergentes, probando qué tan bien el usuario retuvo la información que se le dio en ese nivel. Es posible que el usuario desee omitir ese cuestionario o usarlo para probar lo que sabe." +
                "\nEn el Nivel 1, tengo la intención de concentrarme solo en los órganos más vitales: cerebro, corazón, pulmones, hígado y riñones.";
                break;
            
            case 3:
                txtIntro.text = "USUARIOS\n" +
                "\n•    Profesores" +
                "\n•    Padres" +
                "\n•    Estudiantes: de tercero a sexto año de primaria";
                break;
            case 5:
                txtIntro.text = "Persona\n" +
                "\nNombre: Julia" +
                "\nEdad: 12" +
                "\nGenero: Femenino" +
                "\nLocalizacion: Lima - Peru\n" +
                "\nNotas" +
                "\n•	Le encanta los perros" +
                "\n•	Le gusta aprender sobre el cuerpo humano" +
                "\n•	Quiere ser doctora\n" +
                "\nCaracteristicas de la persona:" +
                "\n•	Disléxico; luchas con el aprendizaje de libros de texto" +
                "\n•	Es hiperactivo; lucha por detenerse y analizare" +
                "\n•	Puede desanimarse fácilmente" +
                "\n•	Aprende mejor a través de la visualización y la simulación";
                break;
            case 6:
                txtIntro.text = "Justificación de las Decisiones de Persona\n" +
                "\nJulia representa a los usuarios que más se beneficiarían de esta aplicación: un estudiante de escuela primaria que necesita una simulación cinestésica para comprender adecuadamente el material que no le es familiar. En Julia, tenemos un usuario que desea aprender más sobre el tema en cuestión pero tiene problemas para aprender a través de métodos tradicionales. Esta aplicación se utilizará para estimular el aprendizaje de estudiantes como ella.";
                break;
            case 7:
                txtIntro.text = "Escenario del problema\n" +
                "\nJulia tiene una gran admiración por su tía, quien recientemente se graduó de la facultad de medicina para convertirse en cirujana. Le encanta ayudar a los demás y decide que algún día quiere seguir los pasos de su tía y convertirse en doctora. La maestra de cuarto grado de Julia había comenzado recientemente a cubrir la anatomía humana en la clase de ciencias, pero debido a los recortes presupuestarios, su escuela no tiene modelos humanos en las aulas para analizar. Por lo tanto, su maestra tiene que enseñar este material con solo un libro de texto obsoleto como guía. Julia, sin embargo, es disléxica y se confunde tratando de conectar los diferentes términos científicos que lee en sus libros, sin un modelo que la guíe. Como resultado, le va mal en su primer examen de anatomía. Desanimada por su falta de retención de información y su mala calificación en su clase de ciencias, comienza a cuestionar la futura carrera que eligió para sí misma.";
                break;
            case 8:
                txtIntro.text = "Escenario de actividad\n" +
                "\nLa semana después de la prueba, la maestra de Julia anuncia que observarán modelos humanos a través de una aplicación informática interactiva, en la que la maestra ejecuta su computadora y proyecta en la pizarra para que la clase los vea. Durante el recreo, Julia le pidió a su maestra un enlace a la aplicación en línea, y esa tarde fue a la biblioteca y usó las computadoras públicas allí para estudiar para su examen de la próxima semana. La aplicación ayudó inmediatamente a Julia a visualizar mejor el cuerpo humano y vincular diferentes órganos a su sistema de órganos correspondiente y sus funciones principales. Después de usar la aplicación durante una semana, Julia puede visualizar mejor lo que está aprendiendo y ahora conecta los diferentes términos que aprendió anteriormente a un modelo humano proporcional. Esto aumenta la retención de su memoria y la comprensión general de los diferentes sistemas de órganos. Obtiene un éxito en su próxima prueba, que reaviva la ambición que tenía anteriormente de convertirse en doctora. Esto hace que busque en su biblioteca local, así como en Internet, para complementar lo que ha aprendido en clase.";
                btnNext.SetActive(true);
                break;
            case 9:
                txtIntro.text = "Planeamiento del problema\n" +
                "\nA Julia le encanta ayudar a los demás y desea ser doctora algún día, pero la cantidad de información que debe aprender sobre el cuerpo humano la abruma. Necesita un modelo para visualizar lo que está aprendiendo para que no se confunda y comience a atrasarse en la clase de ciencias. Un tipo de aprendizaje más interactivo, en comparación con la forma en que aprende en la escuela, le permitiría conectar los puntos y desarrollar su comprensión del cuerpo humano y sus sistemas de órganos.";
                btnNext.SetActive(false);
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
