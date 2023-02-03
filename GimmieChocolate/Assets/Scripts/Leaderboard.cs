using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Dan.Main;

public class Leaderboard : MonoBehaviour
{
    [SerializeField] private List<TextMeshProUGUI> names;
    [SerializeField] private List<TextMeshProUGUI> scores;
    private string publicKey = "df11696bd337f463c9270d124d8985c143c90c1345ccf2fa0de1f729c67d981e";

    public void Start()
    {
        GetLeaderBoard();
    }
    public void GetLeaderBoard()
    {
        LeaderboardCreator.GetLeaderboard(publicKey,((msg)=>
        {
            // set names & scores
            int loopLength = (msg.Length < names.Count) ? msg.Length : names.Count;
            for(int i = 0; i < loopLength; ++i)
            {
                names[i].text = msg[i].Username;
                scores[i].text = msg[i].Score.ToString();
            }
        }));
    }

    public void SetLeaderboardEntry(string username, int score)
    {
        LeaderboardCreator.UploadNewEntry(publicKey, username, score, ((msg) =>
        {
            //username.Substring(0, 6);
            GetLeaderBoard();
        }));
    }
}
