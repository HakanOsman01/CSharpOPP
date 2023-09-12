namespace FindAllPathsInLabirinth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] maze = new string[]
            {
                "010011",
                "00110E",
                "011000",
                "000001"
            };
            bool[,]visited=new bool[maze.Length,maze[0].Length];
            string path = string.Empty;
            FindPathsInLabirinth(maze,0,0,visited,path);
            

        }
        static void FindPathsInLabirinth(string[] maze,int row,int col, bool[,] visited,string path)
        {

            if (maze[row][col] == 'E')
            {
                Console.WriteLine(path);
                return;
            }
            visited[row,col] =true;
            if (IsSafe(maze, row+1, col, visited))
            {
               FindPathsInLabirinth(maze,row+1,col, visited,path+'D');
            }
            if (IsSafe(maze, row - 1, col, visited))
            {
                FindPathsInLabirinth(maze, row - 1, col, visited, path + 'U');
            }
            if (IsSafe(maze, row, col+1, visited))
            {
                FindPathsInLabirinth(maze, row , col+1, visited, path + 'R');
            }
            if (IsSafe(maze, row, col-1, visited))
            {
                FindPathsInLabirinth(maze, row, col-1, visited, path + 'L');
            }
            visited[row,col] =false;


        }
        static bool IsSafe(string[]maze,int row,int col, bool[,]visited)
        {
            if(row<0 || col < 0 || row>=maze.Length || col >= maze[0].Length)
            {
                return false;
            }
            if (visited[row,col]==true || maze[row][col]=='1')
            {
                return false;
            }
            return true;

        }
    }
}