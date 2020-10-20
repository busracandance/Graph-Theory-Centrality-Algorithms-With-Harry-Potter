# Centrality-Algorithms-With-Harry-Potter


1. INTRODUCTION

  In order to be able to work on Centrality algorithms, firstly the characters and their relationships are needed. Before the application was passed, the Harry Potter film series was chosen. 10
characters were determined from this series. These characters are Harry Potter, Ron Weasley, Hermonie Granger, Voldemort, Dumbledore, Snape, Malfoy, James Potter, Lily Potter, Ginny
Weasley. The choice of films or books to apply Graph Theory algorithms may vary. The important thing is the characters and the relationships between them. Centrality measure algorithms consider
the number of connections of the nodes in the graphics. Various mathematical calculations to determine the characters in order of importance. Various representations may be used to determine
the relationships between the characters. Graph that includes nodes and edges or matrix are some examples of presentation types. Graph created in the application is undirected and unweighted. The
graphs can be classified as mainly directed, undirected, and weighted, unweighted. Undirected graph is that two linked nodes are duplex. Directed graphs can have a one-way connection between
two nodes. Weighted graph generally gives the weight of the link. The links between Harry Potter characters have no weight. It is therefore created as unweighted graph.

2. RELATED WORKS

  Much of the previous work on characterizing character networks explores undirected graphs. In “Mining and Modeling Character Networks”, Bonato et al. attempt to characterizing undirected
character networks; they use cooccurrence to match undirected edges between characters, causing the resulting networks to be dense in edges. They then build upon previous literature on picking
features from undirected graphs. In particular, they examine the topologies of “graphlets”, or subgraphs of k nodes. In addition, since the Laplacian matrices of these undirected networks are
symmetric and nonnegative, their eigenvalues are all real and reveal some attributes about the network. These features allow Bonato et al. to distinguish between these different undirected graph
random models.

  In Dimensionality of Social Networks Using Motifs and Eigenvalues research paper, Keyou You, Roberto Tempo, and Li Qiu examine that a social network model with nodes and links
sampled from an m-dimensional metric space best fits samples from real-world networks when m scales logarithmically with the number of nodes of the network. They used two different methods 
to prove their hypotheses: First method is distribution of motif counts, and the second exploits the eigenvalue distribution. The most important point of results is that both methods represent similar
scaling in how the dimensionality scales with network size.

  In "Social Network Analysis of Alice in Wonderland" research paper, Apoorv Agarwal, Augusto Corvalan, Jacob Jensen and Owen Rambow represent a network analysis of Alice in
Wonderland. They build novel types of networks in which links between characters are different types of social events. They analyzed networks based on these social events gives that insight into
the roles of characters in the story. Also, static network analysis has limitations which become apparent from our analysis. The propose is dynamic network analysis to overcome limitations. Also
they find important characters into certain roles.

  In "The complex social network from The Lord of the Rings" research paper, the main subject of this article is the analysis of the social structures emerging of the conjunction of "Lord of the
"Rings", where the social relations are described by the reference criteria, shared events and direct bonds, with the major centrality measures together with the structural entropy of first order. They
also use degree centrality and betweenness centrality in their research. 

  Enabling the doing of an analogy with the canonic ensemble of the mechanic statistics and enabling analyzing the degree of homogeneity of the bonds between the formed communities.

  In A Matrix Analysis of Different Centrality, Michele Benzi and Christine KLYMKO show how parameter dependent measures, such as Katz and subgraph centrality, can be “tuned” to
interpolate between degree and eigenvector centrality, which appear as limiting cases of the other measures. Node centrality measures including degree, eigenvector, Katz and subgraph centralities
are analyzed for both undirected and directed networks. They explicate their finding in terms of the local and global influence of a given node in the graph as measured by graph walks of different
length through that node. They analysis gives some guidance for the choice of parameters in Katz and subgraph centrality, and provides an explanation for the observed correlations between
different centrality measures and for the stability exhibited by the ranking vectors for certain parameter ranges. The important role played by the spectral gap of the adjacency matrix is also
highlighted.

  In "Distributed Algorithms for Computation of Centrality Measures in Complex Networks" paper is concerned with distributed computation of several commonly used centrality measures in
complex networks. In particular, they propose deterministic algorithms, which converge in finite time, for the distributed computation of the degree, closeness and betweenness centrality measures
in directed graphs. Regarding eigenvector centrality, they consider the PageRank problem as its typical variant, and design distributed randomized algorithms to compute PageRank for both fixed
and time-varying graphs. A key feature of the proposed algorithms is that they do not require to know the network size, which can graph, we introduce the novel concept of persistent graph, which
eliminates the effect of spamming nodes. Finally, the effectiveness of the proposed algorithms is illustrated via extensive simulations using a classical benchmark.

3. IMPLEMENTATION

3.1. Creating graph

  The application was written in Visual Studio environment using c # language. First, a 2- dimensional adjacency matrix of 5x5 was created. The matrix represents a character in each row
and each column. For example, the first row and the first column points to the e character. The locations defined in matrix 1 indicate that there is a connection between two characters, while the
places defined by 0 indicate that there is no edge between the two characters.


3.2.Defining connections

  After defining the graph, the links of the characters according to the adjacency matrix were defined. The two dimensional matrix was formed by forming a loop and ones and a zeros were
determined.


3.3. Dijkstra’s algorithm

  Dijkstra algorithm is used to find the shortest path from the source node to all other nodes. The algorithm is applied and the Harry Potter character is the distance to all other nodes. So Harry Potter has a connection to all other characters. Ron Weasley has 2 shortest
ways to reach some characters. This indicates that there is no direct connection to some characters. The algorithm basically works as follows: The algorithm initially assigns infinite value to all
nodes, assuming that there is no access. So in the initial state yet we cannot go to any node. It then navigates all nodes that are adjacent to the start node and updates the reach to these nodes. After
this update, the updated nodes update their neighbors and continue until all nodes are updated and there is no new update on the shape.

3.4. Centrality measures

  Centrality refers to how central a node is within a network. The Degree Centerity refers to the number of edges connected by an edge. For degree centrality, the connection numbers of the nodes
are calculated. This is the most central node according to the number of connections. After calculating the degree centrality, the most central node was Harry Potter.

  In a connected graph, closeness centrality (or closeness) of a node is a measure of centrality in a network, calculated as the reciprocal of the sum of the length of the shortest paths between the 
node and all other nodes in the graph. Thus, the more central a node is, the closer it is to all other nodes. The eccentricity is a node centrality index. The eccentricity of a node v is calculated by computing the shortest path between the node v
and all other nodes in the graph.

3.5. Bellman Ford algorithm

The Bellman Ford algorithm also provides the shortest distance from a node such as dijkstra to all other nodes. Bellman-Ford is also simpler than Dijkstra and suites well for distributed systems. Time
complexity of Bellman Ford is O(VE), which is more than Dijkstra.

4. CONCLUSION
  
  In the generated graph, all algorithms have shown that the most important character is Harry Potter. Because Harry Potter's distance to all characters is one. In other words, it is possible to reach
every desired node. Here Harry Potter is the Hub point of the graph. For other characters, the cost of reaching another nodE holds up to two, even if the link is not. Each node can reach the desired
character through Harry Potter. Ten characters were used in the project. The small number of characters allowed the results to be observed more easily. However, the algorithms, which have
high number of nodes, run smoothly and facilitate the analysis which is not easily understood.

  Although the project focuses on movie characters, graph theory algorithms can be used to perform useful analyzes in many sectors. The algorithms used for analysis are briefly centrality, closeness centrality, eccentricity
centrality, Dijkstra and Bellman Ford.

REFERENCES

[1] M.A. Ribeiro, R.A. Vosgerau, M.L.P. Andruchiw, S. Ely de Souza Pinto, The complex social network from the
Lord of the Rings, Rev. Bras. Ensino Fs. (2016) 38 1304.

[2] A. Agarwal, A. Corvalan, J. Jensen, O. Rambow, Social network analysis of “Alice in Wonderland”, In:
Proceedings of the Workshop on Computational Linguistics for Literature, 2012.

[3] Bonato, A., D’Angelo, D. R., Elenberg, E. R., Gleich, D. F., & Hou, Y. (2016). “Mining and modeling character
networks.” In Algorithms and Models for the Web Graph: 13th International Workshop, WAW 2016, Montreal, QC,
Canada, December 14–15, 2016, Proceedings 13 (pp. 100- 114). Springer International Publishing

[4] A. Bonato, D.F. Gleich, M. Kim, D. Mitsche, P. Pralat, A. Tian, S.J. Young. Dimensionality matching of social
networks using motifs and eigenvalues, PLOS ONE, 9(9):e106052, 2014.

[5] Keyou You, Roberto Tempo, Li Qiu (2016), "Distributed Algorithms for Computation of Centrality Measures
in Complex Networks", May 30, 2016.

[6] Michele Benzi, Christine Klymko(2014) "A Matrix Analysis of Different Centrality Measures, Available at:
2019 (Accessed: 2019).
