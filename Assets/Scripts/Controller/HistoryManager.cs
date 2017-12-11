using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HistoryManager : MonoBehaviour {

    [System.Serializable]
    public class HistoricalEvent
    {
        public HistoricalEvent(string time, string text, MinigameController minigame)
        {
            this.time = time;
            this.text = text;
            this.minigame = minigame;
        }

        public string time;
        public string text;
        public MinigameController minigame;
    }
    
    public HistoricalEvent[] all_historical_events = new HistoricalEvent[]{
                                    new HistoricalEvent("2.6 Ma", "You invented stone tools",           null),
                                    new HistoricalEvent("2.3 Ma", "You lit a fire",                     null),
                                    new HistoricalEvent("500 ka", "You built a house",                  null),
                                    new HistoricalEvent("400 ka", "Those are some nice cave paintings", null),
                                    new HistoricalEvent("600 ka", "Got youself some designer clothes",  null),
                                    new HistoricalEvent("", "", null),
                                    new HistoricalEvent("", "", null),
                                    new HistoricalEvent("", "", null),
                                    new HistoricalEvent("", "", null),
                                    new HistoricalEvent("", "", null),
                                    new HistoricalEvent("", "", null),
                                    new HistoricalEvent("", "", null),
                                };


    private int current_event_index = 0;
    public HistoricalEvent get_next_event()
    {
        return all_historical_events[current_event_index++];
    }

    public bool _is_empty;

    public bool is_empty()
    {
        if (_is_empty)
        {
            Debug.Log("empty");
            return _is_empty;
        }

        if (current_event_index < all_historical_events.Length)
            return false;
        else
            return true;
    }
}
