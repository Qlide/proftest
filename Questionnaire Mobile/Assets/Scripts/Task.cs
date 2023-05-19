using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Task : MonoBehaviour
{
    public QuestionList[] questions;
    public Text[] answersText;
    public Text qText;
    public Text CountText;
    public static int count;
    public static int n1;
    public static int n2;
    public static int n3;
    public static int n4;
    public static int n5;
    public static int n6;

    List<object> qList;
    List<object> qList2;
    int randQ;

    Dictionary<string, List<string>> q = new Dictionary<string, List<string>>()
        {
            {"Прикладная информатика",
                new List<string> {
                "Ты разбираешься в технике, можешь легко устранить любую неполадку в компьютере или хотел бы в этом разбираться?",
                "Скачивая новое приложение на телефон, тебе интересно узнать как оно работает?",
                "Тебе больше нравится решать задачи, где нужно много думать, \"ломать\" голову над решением?",
                "Тебе интересна профессия, которая даст возможность разработать собственную компьютерную игру и заработать на этом?"
                }
            },

            {"Медиакоммуникации",
                new List<string> {
                    "Тебя вдохновляют блогеры в социальных сетях и тебе бы тоже хотелось вещать на большую аудиторию в социальных сетях?",
                    "Тебе хотелось бы научится создавать разнообразный контент (фото, видео, текст, подкасты и тд)?",
                    "Ты считаешь, что для успешной карьеры нужно иметь широкий кругозор и знания во многих областях?",
                    "Жизнь для тебя была бы гораздо скучнее без социальных сетей?"
                }
            },

            {"Реклама и связи с общественностью",
                new List<string> {
                    "В будущем тебе бы хотелось создать рекламное агентство, реализовывать различные проекты и зарабатывать на этом?",
                    "Тебе было бы интересно продвигать других людей, делать их узнаваемыми и заметными в социальных сетях?",
                    "Тебе нравится находится в центре событий и иметь много знакомств?",
                    "Чтобы добиться успеха в бизнесе необходимо уметь продвигать и продавать свой товар или услугу?"
                }
            },

            {"Музыкальное искусство эстрады",
                new List<string> {
                    "Тебе интересно продюсирование музыкальных проектов и хотелось бы получить компетенции необходимые для этого?",
                    "Ты профессионально занимаешься музыкой (играешь на музыкальном инструменте, занимаешься вокалом или закончил музыкальную школу)?",
                    "В будущем тебе бы хотелось заниматься организацией концертов, разных мероприятий и зарабатывать на этом?",
                    "Тебе больше подходит управлять людьми, организовывать их работу?"
                }
            },

            {"Народная художественная культура",
                new List<string>{
                    "Ты с детства занимался творчеством (танцами, фотографией, рисованием)?",
                    "Тебе нравится выступать на сцене перед зрителями?",
                    "Тебе больше всего интересны профессии, которые дают возможность стать руководителем в какой-либо творческой сфере?",
                    "Ты можешь организовать работу людей в команде для создания творческого проекта, или хотел бы этому научиться?"
                }
            },

            {"Социально-культурная деятельность",
                new List<string>{
                    "Гуляя по незнакомому городу ты с большим удовольствием посетишь художественную галерею?",
                    "Твоя самая сильная сторона творческие способности, выраженный художественный вкус?",
                    "Важнее всего для тебя в жизни иметь интересную работу, связанную с творчеством и людьми?",
                    "Ты мечтаешь однажды организовать выставку с участием разных художников/фотографов?"
                }
            }
        };

    //public void OnClickPlay()
    //{
    //    qList = new List<object>(questions);
    //    questionGenerate();
    //}

    void Awake()
    {
        count = 1;
        n1 = 0;
        n2 = 0;
        n3 = 0;
        n4 = 0;
        n5 = 0;
        n6 = 0;
    }

    void Start()
    {
        qList = new List<object>(questions);
        qList2 = qList;
        questionGenerate();
        //print(q["Прикладная информатика"][2]);
        //print(q["Медиакоммуникации"][2]);
        //print(q["Реклама и связи с общественностью"][2]);
        //print(q["Музыкальное искусство эстрады"][2]);
        //print(q["Народная художественная культура"][2]);
        //print(q["Социально-культурная деятельность"][2]);
        //print(q.Keys[1]);
    }

    public void NextScene(int scene_Number)
    {
        SceneManager.LoadScene(scene_Number);
    }

    public void questionGenerate()
    {
        CountText.text = $"{count}/30";
        randQ = Random.Range(0, qList.Count - 1);
        QuestionList crntQ = qList[randQ] as QuestionList;
        qText.text = crntQ.question;
        //Debug.Log(crntQ.question);
        for (int i = 0; i < crntQ.answers.Length; i++)
        {
            answersText[i].text = crntQ.answers[i];
            //Debug.Log(crntQ.answers[i]);
            if (answersText[crntQ.answers.Length - 1].text.ToString() == "")
            {
                SceneManager.LoadScene(3);
                //print($"Прикладная информатика: {n1} баллов");
                //print($"Медиакоммуникации: {n2} баллов");
                //print($"Реклама и связи с общественностью: {n3} баллов");
                //print($"Музыкальное искусство эстрады: {n4} баллов");
                //print($"Народная художественная культура: {n5} баллов");
                //print($"Социально-культурная деятельность: {n6} баллов");
            }
        }
    }

    public void CheckPlus()
    {
        foreach (var category in q)
        {
            for (int i = 0; i < category.Value.Count; i++)
            {
                if (qText.text.ToString() == category.Value[i].ToString())
                {
                    switch (category.Key.ToString())
                    {
                        case "Прикладная информатика":
                            n1++;
                            break;
                        case "Медиакоммуникации":
                            n2++;
                            break;
                        case "Реклама и связи с общественностью":
                            n3++;
                            break;
                        case "Музыкальное искусство эстрады":
                            n4++;
                            break;
                        case "Народная художественная культура":
                            n5++;
                            break;
                        case "Социально-культурная деятельность":
                            n6++;
                            break;
                    }
                }
            }
        }
    }

    public void CheckMinus()
    {
        foreach (var category in q)
        {
            for (int i = 0; i < category.Value.Count; i++)
            {
                if (qText.text.ToString() == category.Value[i].ToString())
                {
                    switch (category.Key.ToString())
                    {
                        case "Прикладная информатика":
                            n1--;
                            break;
                        case "Медиакоммуникации":
                            n2--;
                            break;
                        case "Реклама и связи с общественностью":
                            n3--;
                            break;
                        case "Музыкальное искусство эстрады":
                            n4--;
                            break;
                        case "Народная художественная культура":
                            n5--;
                            break;
                        case "Социально-культурная деятельность":
                            n6--;
                            break;
                    }
                }
            }
        }
    }

    public void AnswerBttns(int index)
    {
        count++;
        if (answersText[index].text == "Да")
        {
            CheckPlus();
        }
        else
        {
            CheckMinus();
        }
        qList.RemoveAt(randQ);
        questionGenerate();
    }
}
[System.Serializable]
public class QuestionList
{
    public string question;
    public string[] answers = new string[2];
}

