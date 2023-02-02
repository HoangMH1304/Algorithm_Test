using System;

class Ex2
{
    private const int INF = 1000000000;

    private static void shortestPath(int[,] edges, int v, int e)
    {
        List<int>[] adj = new List<int>[10000];
        for(int i = 0; i < e; i++)
        {
            int x = edges[i, 0], y = edges[i, 1];
            adj[x].Add(y);
        }

        List<int> d = new List<int>(new int[v + 1]);
        for(int i = 0; i <= v; i++) d[i] = INF;
        d[1] = 0;
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        pq.Enqueue(1, 0);
        while(pq.TryDequeue(out int vertex, out int distance))
        {
            if(distance > d[vertex]) continue;
            foreach(var it in adj[vertex])
            {
                if(d[it] > d[vertex] + 1)
                {
                    d[it] = d[vertex] + 1;
                    pq.Enqueue(it, d[it]);
                }
            }
        }
        for(int i = 1; i <= v; i++)
        {
            System.Console.Write(d[i] + " ");
        }
    }
    
    
    private static void Main(string[] args)
    {
        int v = Convert.ToInt32(Console.ReadLine());
        int e = Convert.ToInt32(Console.ReadLine());
        int[,] edges = new int[e, 2];
        for(int i = 0; i < e; i++)
        {
            edges[i, 0] = Convert.ToInt32(Console.ReadLine());
            edges[i, 1] = Convert.ToInt32(Console.ReadLine());
        }
        shortestPath(edges, v, e);
    }

}