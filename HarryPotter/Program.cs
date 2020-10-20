using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTheory
{
    class Program
    {
        static int V = 10;
        int [,] shortpathMatrix= new int[10,10];
        int[] shortpatharray = new int[10];
        int[] closenessarray = new int[10];
        int[] eccentricityrray = new int[10];
        int minDistance(int[] dist, bool[] sptSet)
        {
            // Initialize min value 
            int min = int.MaxValue, min_index = -1;

            for (int v = 0; v < V; v++)
                if (sptSet[v] == false && dist[v] <= min)
                {
                    min = dist[v];
                    min_index = v;
                }

            return min_index;
        }

        // A utility function to print 
        // the constructed distance array 
        void printSolution(int[] dist, int n,int src)
        {
            Console.Write("Vertex Distance "+ "from Source\n");
            for (int i = 0; i < V; i++)
            {
                Console.Write(i + " \t\t " + dist[i] + "\n");
                shortpathMatrix[src,i] = dist[i];
                shortpatharray[i]=dist[i];
            }
              

        }
        
        public int max1(int[] array)
        {
            int max = 0;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];

                }
            }
            return max;
        }
        public int min(int[] array)
        {
            int min = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }
            return index;
        }

        public void findeccentricitycent()
        {
            int[] temp = new int[10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    temp[i] = shortpathMatrix[i,j];
                }
                eccentricityrray[i] = max1(temp);
                //Console.WriteLine(eccentricityrray[i]);
            }
            //Console.WriteLine("eccentiricitycentreality" + " " + vertexList[min(eccentricityrray)].label);
        }

        public void findclosenesscent()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    closenessarray[i] = shortpathMatrix[i,j] + closenessarray[i];
                }
                //Console.WriteLine(closenessarray[i]);
            }
            //Console.WriteLine(("closenesscentreality"+" "+vertexList[min(closenessarray)].label);
        }
        // Function that implements Dijkstra's 
        // single source shortest path algorithm 
        // for a graph represented using adjacency 
        // matrix representation 
        void dijkstra(int[,] graph, int src)
        {
            int[] dist = new int[V]; // The output array. dist[i] 
            // will hold the shortest 
            // distance from src to i 

            // sptSet[i] will true if vertex 
            // i is included in shortest path 
            // tree or shortest distance from 
            // src to i is finalized 
            bool[] sptSet = new bool[V];

            // Initialize all distances as 
            // INFINITE and stpSet[] as false 
            for (int i = 0; i < V; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
            }

            // Distance of source vertex 
            // from itself is always 0 
            dist[src] = 0;

            // Find shortest path for all vertices 
            for (int count = 0; count < V - 1; count++)
            {
                // Pick the minimum distance vertex 
                // from the set of vertices not yet 
                // processed. u is always equal to 
                // src in first iteration. 
                int u = minDistance(dist, sptSet);

                // Mark the picked vertex as processed 
                sptSet[u] = true;

                // Update dist value of the adjacent 
                // vertices of the picked vertex. 
                for (int v = 0; v < V; v++)

                    // Update dist[v] only if is not in 
                    // sptSet, there is an edge from u 
                    // to v, and total weight of path 
                    // from src to v through u is smaller 
                    // than current value of dist[v] 
                    if (!sptSet[v] && graph[u, v] != 0 &&
                         dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                        dist[v] = dist[u] + graph[u, v];
            }

            // print the constructed distance array 
            printSolution(dist, V,src);
        }

        // Driver Code 
        static void Main(string[] args)
        {
            //Adjacency Matrix
            string character = " ";
            string character2 = " ";

            int[,] adjMatrix = new int[,] { { 0,1,1,1,1,1,1,1,1,1 }, 
                                           { 1,0,1,1,1,0,1,0,0,1 }, 
                                           { 1,1,0,1,1,0,1,0,0,0 }, 
                                           { 1,1,1,0,1,1,1,1,1,0 }, 
                                           { 1,1,1,1,0,1,0,0,0,0}, 
                                           { 1,0,0,1,1,0,0,0,1,0 }, 
                                           { 1,1,1,1,0,0,0,0,0,0 }, 
                                           { 1,0,0,1,0,0,0,0,1,0 }, 
                                           { 1,0,0,1,0,1,0,1,0,0 }, 
                                           { 1,1,0,0,0,0,0,0,0,0 } };
            Program t = new Program();
            int sum = 0;
            int max_degree = 0;
            int maxIndex = 0;
            int minIndex1 = 0;
            int minIndex2 = 0;
            int closenesscent = 0;
            int eccentricitycent = 0;
         //   int closeness = 0;
            string degree_char = " ";
            string degree_char1 = " ";
            string degree_char2 = " ";
            int[] degree_centrality = new int[adjMatrix.GetLength(0)];

            for (int i = 0; i < adjMatrix.GetLength(0); i++)
            {
                
                //Define Characters in Row
                if (i == 0)
                {
                    character = "Harry Potter";
                    Console.WriteLine(character + " is connected to: ");
                   
                }
                else if (i == 1)
                {
                    character = "Ron Weasley";
                    Console.WriteLine(character + " is connected to: ");
                }
                else if (i == 2)
                {
                    character = "Hermonie Granger";
                    Console.WriteLine(character + " is connected to: ");
                }
                else if (i == 3)
                {
                    character = "Voldemort";
                    Console.WriteLine(character + " is connected to: ");
                }
                else if (i == 4)
                {
                    character = "Dumbledore";
                    Console.WriteLine(character + " is connected to: ");
                }
                else if (i == 5)
                {
                    character = "Snape";
                    Console.WriteLine(character + " is connected to: ");
                }
                else if (i == 6)
                {
                    character = "Malfoy";
                    Console.WriteLine(character + " is connected to: ");
                }
                else if (i == 7)
                {
                    character = "James Potter";
                    Console.WriteLine(character + " is connected to: ");
                }
                else if (i == 8)
                {
                    character = "Lily Potter";
                    Console.WriteLine(character + " is connected to: ");
                }
                else if (i == 9)
                {
                    character = "Ginny Weasley";
                    Console.WriteLine(character + " is connected to: ");
                }

                for (int j = 0; j < adjMatrix.GetLength(1); j++)
                {
                    //Define Characters in Column
                    if (j == 0)
                    {
                        character2 = "Harry Potter";
                    }
                    else if (j == 1)
                    {
                        character2 = "Ron Weasley";
                    }
                    else if (j == 2)
                    {
                        character2 = "Hermonie Granger";
                    }
                    else if (j == 3)
                    {
                        character2 = "Voldemort";
                    }
                    else if (j == 4)
                    {
                        character2 = "Dumbledore";
                    }
                    else if (j == 5)
                    {
                        character2 = "Snape";
                    }
                    else if (j == 6)
                    {
                        character2 = "Malfoy";
                    }
                    else if (j == 7)
                    {
                        character2 = "James Potter";
                    }
                    else if (j == 8)
                    {
                        character2 = "Lily Potter";
                    }
                    else if (j == 9)
                    {
                        character2 = "Ginny Weasley";
                    }
                    ///////////////
                    if (character == "Harry Potter" && adjMatrix[i, j] == 1)
                    {
                        Console.Write(character2 + ", ");
                    }
                    if (character == "Ron Weasley" && adjMatrix[i, j] == 1)
                    {
                        Console.Write(character2 + ", ");
                    }
                    if (character == "Hermonie Granger" && adjMatrix[i, j] == 1)
                    {
                        Console.Write(character2 + ", ");
                    }
                    if (character == "Voldemort" && adjMatrix[i, j] == 1)
                    {
                        Console.Write(character2 + ", ");
                    }
                    if (character == "Dumbledore" && adjMatrix[i, j] == 1)
                    {
                        Console.Write(character2 + ", ");
                    }
                    if (character == "Snape" && adjMatrix[i, j] == 1)
                    {
                        Console.Write(character2 + ", ");
                    }
                    if (character == "Malfoy" && adjMatrix[i, j] == 1)
                    {
                        Console.Write(character2 + ", ");
                    }
                    if (character == "James Potter" && adjMatrix[i, j] == 1)
                    {
                        Console.Write(character2 + ", ");
                    }
                    if (character == "Lily Potter" && adjMatrix[i, j] == 1)
                    {
                        Console.Write(character2 + ", ");
                    }
                    if (character == "Ginny Weasley" && adjMatrix[i, j] == 1)
                    {
                        Console.Write(character2 + ", ");
                    }

                    //Degree Centrality Hesapla
                    sum += adjMatrix[i, j];
                    degree_centrality[i] = sum;

                    
                   
                }
                for (int j = 0; j < 10; j++)
                {
                    t.dijkstra(adjMatrix, j);
                }

                t.findclosenesscent();
                t.findeccentricitycent();
                sum = 0;
                Console.WriteLine();
                Console.WriteLine();
                max_degree = degree_centrality.Max();
                maxIndex = degree_centrality.ToList().IndexOf(max_degree);
                if (maxIndex == i)
                {
                    degree_char = character;
                }
                
                eccentricitycent = t.eccentricityrray.Min();
                minIndex1 = t.eccentricityrray.ToList().IndexOf(eccentricitycent);
                if (minIndex1 == i)
                {
                    degree_char1 = character;
                }

                closenesscent = t.closenessarray.Min();
                minIndex2 = t.closenessarray.ToList().IndexOf(closenesscent);
                if (minIndex2 == i)
                {
                    degree_char2 = character;
                }
                
            }

            Console.WriteLine("Most important character according to degree centrality: " + degree_char+ " Degree:"+max_degree);
            Console.WriteLine("Most important character according to closeness centrality: " + " Degree:" + closenesscent);
            Console.WriteLine("Most important character according to eccentricity centrality: " + " Degree:" + eccentricitycent);
           
            Console.ReadLine();
        }
    }

}