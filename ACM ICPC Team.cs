using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    public static List<int> acmTeam(List<string> topic)
    {
        int maxTopics = 0;
        int maxTeams = 0;
        int attendeeCount = topic.Count;
        int topicCount = topic[0].Length;
        
        
        for (int i = 0; i < attendeeCount - 1; i++)
        {
            for (int j = i + 1; j < attendeeCount; j++)
            {
                int currentTopics = 0;
                
                
                for (int k = 0; k < topicCount; k++)
                {
                    if (topic[i][k] == '1' || topic[j][k] == '1')
                    {
                        currentTopics++;
                    }
                }
                
            
                if (currentTopics > maxTopics)
                {
                    maxTopics = currentTopics;
                    maxTeams = 1;
                }
                else if (currentTopics == maxTopics)
                {
                    maxTeams++;
                }
            }
        }
        
        return new List<int> { maxTopics, maxTeams };
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
        int n = Convert.ToInt32(firstMultipleInput[0]);
        int m = Convert.ToInt32(firstMultipleInput[1]);
        
        List<string> topic = new List<string>();
        
        for (int i = 0; i < n; i++)
        {
            string topicItem = Console.ReadLine();
            topic.Add(topicItem);
        }
        
        List<int> result = Result.acmTeam(topic);
        
        Console.WriteLine(String.Join("\n", result));
    }
}
