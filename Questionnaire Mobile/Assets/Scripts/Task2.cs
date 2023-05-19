using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Task2 : MonoBehaviour
{
    public QuestionList[] questions;
    public Text[] answersText;
    public Text qText;
    public Text CountText;

    List<object> qList;
    List<object> qList2;
    int randQ;

    Dictionary<string, List<string>> a = new Dictionary<string, List<string>>()
        {
            {"Прикладная информатика",
                new List<string> {
                    "К точным наукам (информатика, математика, физика)",
                    "Когда дают конкретную задачу и четкий план",
                    "Играть в компьютерные игры",
                    "Быть ответственным за техническую часть мероприятия",
                    "Чтобы лучше запомнить, мне нужно понять логику, разобраться",
                    "Делать свою работу независимо от других людей"
                }
            },

            {"Медиакоммуникации",
                new List<string> {
                    "К гуманитарным наукам (обществознание, литература, история)",
                    "Когда самостоятельно ставишь себе задачи и планируешь всю работу",
                    "Провести время в социальных сетях (писать посты, разучивать танец для Tiktok, снимать сторис)",
                    "Смонтировать видео поздравление и написать торжественную речь",
                    "С помощью картинок и образов",
                    "Работать в команде, в сотрудничестве с другими людьми"
                }
            },

            {"Реклама и связи с общественностью",
                new List<string> {
                    "К гуманитарным наукам (обществознание, литература, история)",
                    "Когда самостоятельно ставишь себе задачи и планируешь всю работу",
                    "Провести время в социальных сетях (писать посты, разучивать танец для Tiktok, снимать сторис)",
                    "Смонтировать видео поздравление и написать торжественную речь",
                    "С помощью картинок и образов",
                    "Работать в команде, в сотрудничестве с другими людьми"
                }
            },

            {"Музыкальное искусство эстрады",
                new List<string> {
                    "К творчеству (музыке, танцам, театру)",
                    "В творческом порыве, с  увлеченностью и вдохновением",
                    "Сходить в театр или на концерт",
                    "Придумывать сценарий и участвовать в спектакле",
                    "На слух",
                    "Управлять людьми, организовывать их работу"
                }
            },

            {"Народная художественная культура",
                new List<string>{
                    "К творчеству (музыке, танцам, театру)",
                    "В творческом порыве, с  увлеченностью и вдохновением",
                    "Сходить в театр или на концерт",
                    "Придумывать сценарий и участвовать в спектакле",
                    "На слух",
                    "Управлять людьми, организовывать их работу"
                }
            },

            {"Социально-культурная деятельность",
                new List<string>{
                    "К творчеству (музыке, танцам, театру)",
                    "В творческом порыве, с  увлеченностью и вдохновением",
                    "Сходить в театр или на концерт",
                    "Придумывать сценарий и участвовать в спектакле",
                    "На слух",
                    "Управлять людьми, организовывать их работу"
                }
            }
        };

    void Start()
    {
        CountText.text = $"{Task.count}/30";
        qList = new List<object>(questions);
        qList2 = qList;
        questionGenerate();
    }

    void questionGenerate()
    {
        CountText.text = $"{Task.count}/30";
        randQ = Random.Range(0, qList.Count - 1);
        QuestionList crntQ = qList[randQ] as QuestionList;
        qText.text = crntQ.question;
        for (int i = 0; i < crntQ.answers.Length; i++)
        {
            answersText[i].text = crntQ.answers[i];
            if (answersText[crntQ.answers.Length - 1].text.ToString() == "")
            {
                SceneManager.LoadScene(4);
                //print($"Прикладная информатика: {Task.n1} баллов");
                //print($"Медиакоммуникации: {Task.n2} баллов");
                //print($"Реклама и связи с общественностью: {Task.n3} баллов");
                //print($"Музыкальное искусство эстрады: {Task.n4} баллов");
                //print($"Народная художественная культура: {Task.n5} баллов");
                //print($"Социально-культурная деятельность: {Task.n6} баллов");
            }
        }
    }

    public void Check(int index)
    {
        foreach (var category in a)
        {
            for (int i = 0; i < category.Value.Count; i++)
            {
                if (answersText[index].text.ToString() == category.Value[i].ToString())
                {
                    switch (category.Key.ToString())
                    {
                        case "Прикладная информатика":
                            Task.n1++;
                            break;
                        case "Медиакоммуникации":
                            Task.n2++;
                            break;
                        case "Реклама и связи с общественностью":
                            Task.n3++;
                            break;
                        case "Музыкальное искусство эстрады":
                            Task.n4++;
                            break;
                        case "Народная художественная культура":
                            Task.n5++;
                            break;
                        case "Социально-культурная деятельность":
                            Task.n6++;
                            break;
                    }
                }
            }
        }
    }

    public void AnswerBttns(int index)
    {
        if (Task.count == 30)
        {
            Task.count = 30;
        }
        else
        {
            Task.count++;
        }
        Check(index);
        qList.RemoveAt(randQ);
        questionGenerate();
    }
}
[System.Serializable]
public class QuestionList2
{
    public string question;
    public string[] answers = new string[3];
}
