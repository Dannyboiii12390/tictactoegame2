// See https://aka.ms/new-console-template for more information


using System.Security.Cryptography.X509Certificates;

void CellNumberOutput()
{
    string splitter = "-----";
                         
    string row1 = "0|1|2" ;
    string row2 = "3|4|5" ;
    string row3 = "6|7|8" ;
 
    Console.WriteLine(row1);
    Console.WriteLine(splitter);
    Console.WriteLine(row2);
    Console.WriteLine(splitter);
    Console.WriteLine(row3);

};
void OutputBoard(string [,] board)
{
    string splitter = "-----";
    Console.WriteLine(board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
    Console.WriteLine(splitter);
    Console.WriteLine(board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
    Console.WriteLine(splitter);
    Console.WriteLine(board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
}
void Main()
{
    string[,] board = {
        { " "," "," " },
        { " "," "," " },
        { " "," "," " }
    };

    string splitter = "-----";
    string splitterLong = splitter + splitter;
    int i = 0;
    string write = "X";
    while (i <= 9)
    {
        CellNumberOutput();
        Console.WriteLine("Its " + write + "'s turn, where would you like to go?");
        int Move = int.Parse(Console.ReadLine());

        int x = Move / 3;
        int y = Move % 3;

        if (board[x, y] == "X" || board[x, y] == "O")
        {
            Console.WriteLine("That Cell is already taken");
        }
        else
        {
            board[x, y] = write;
            i++;

            if (write == "X")
            {
                write = "O";
            }
            else
            {
                write = "X";
            }
        }
        OutputBoard(board);
        //win condition function call here

        Console.WriteLine(splitterLong);
    }
}

Main();

