using System;

class Meeting
{
    private int start, finish;
    public Meeting(int start, int finish)
    {
        this.Start = start;
        this.Finish = finish;
    }
    public int Start { get => start; set => start = value; }
    public int Finish { get => finish; set => finish = value; }
}

class Ex4
{
    private static int meetingRoom(int[] s, int[] f, int n)
    {
        List<Meeting> meetings = InitList(s, f, n);

        int numOfMeetings = 0;
        int lastFinish = -1;
        for (int i = 0; i < n; i++)
        {
            if (lastFinish <= meetings[i].Start)
            {
                numOfMeetings++;
                lastFinish = meetings[i].Finish;
            }
        }
        return numOfMeetings;
    }

    private static List<Meeting> InitList(int[] s, int[] f, int n)
    {
        List<Meeting> meetings = new List<Meeting>();
        for (int i = 0; i < n; i++)
        {
            meetings.Add(new Meeting(s[i], f[i]));
        }
        meetings.Sort(delegate (Meeting x, Meeting y)
        {
            if (x.Start != y.Start) return x.Start.CompareTo(y.Start);
            return x.Finish.CompareTo(y.Finish);
        });
        return meetings;
    }

    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] s = new int[n];
        int[] f = new int[n];
        for(int i = 0; i < n; i++)
        {
            s[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i = 0; i < n; i++)
        {
            f[i] = Convert.ToInt32(Console.ReadLine());
        }
        System.Console.WriteLine(meetingRoom(s, f, n));
    }
}