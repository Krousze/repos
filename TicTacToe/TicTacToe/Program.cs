using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public enum State { empty, X, O }

    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Renderer renderer = new Renderer();
            //Player player = new Player();
            Outcome outcome = new Outcome();
            Player player1 = new Player();
            Player player2 = new Player();

            while(!outcome.IsDraw(board) && outcome.Check(board) == State.empty)
            {
                renderer.Render(board);
                Position nextMove;
                if (board.NextTurn == State.X)
                    nextMove = player1.GetPosition(board);
                else
                    nextMove = player2.GetPosition(board);
                if (!board.SetState(nextMove, board.NextTurn))
                    Console.WriteLine("That is not a legal Move.");
            }
            renderer.Render(board);
            renderer.RenderResults(outcome.Check(board));

            Console.ReadKey();
        }
    }
    public class Board
    {
        private State[,] boardState;
        public State NextTurn { get; private set; }

        public Board()
        {
            boardState = new State[3, 3];
            NextTurn = State.X;
        }
        public State GetState(Position position)
        {
            return boardState[position.Row, position.Column];
        }
        public bool SetState(Position position, State newboardState)
        {
            if (newboardState != NextTurn) return false;
            if (boardState[position.Row, position.Column] != State.empty) return false;

            boardState[position.Row, position.Column] = newboardState;
            SwitchNextTurn();
            return true;
        }
        private void SwitchNextTurn()
        {
            if (NextTurn == State.X) NextTurn = State.O;
            else NextTurn = State.X;
        }
    }
    public class Position
    {
        public int Row { get; }
        public int Column { get; }

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
    public class Player
    {
        public Position GetPosition(Board board)
        {
            int position = Convert.ToInt32(Console.ReadLine());
            Position desiredCoordinate = PositionForNumber(position);
            return desiredCoordinate;
        }
        private Position PositionForNumber(int position)
        {
            switch (position)
            {
                case 1: return new Position(0, 0);
                case 2: return new Position(0, 1);
                case 3: return new Position(0, 2);
                case 4: return new Position(1, 0);
                case 5: return new Position(1, 1);
                case 6: return new Position(1, 2);
                case 7: return new Position(2, 0);
                case 8: return new Position(2, 1);
                case 9: return new Position(2, 2);
                default: return null;

            }
        }
    }
    public class Outcome
    {
        public State Check(Board board)
        {
            if (CheckForOutcome(board, State.X)) return State.X;
            if (CheckForOutcome(board, State.O)) return State.O;
            return State.empty;
        }
        private bool CheckForOutcome(Board board, State player)
        {
            for (int row = 0; row < 3; row++)
                if (AreAll(board, new Position[] {
                            new Position(row, 0),
                            new Position(row, 1),
                            new Position(row, 2) }, player))
                    return true;
            for (int column = 0; column < 3; column++)
                if (AreAll(board, new Position[] {
                            new Position(0, column),
                            new Position(1, column),
                            new Position(2, column) }, player))
                    return true;
            if (AreAll(board, new Position[] {
                        new Position(0, 0),
                        new Position(1, 1),
                        new Position(2, 2) }, player))
                    return true;
            if (AreAll(board, new Position[] {
                        new Position(2, 0),
                        new Position(1, 1),
                        new Position(0, 2) }, player))
                    return true;

            return false;
        }
        private bool AreAll(Board board, Position[] positions, State state)
        {
            foreach (Position position in positions)
                if (board.GetState(position) != state) return false;

            return true;
        }
        public bool IsDraw(Board board)
        {
            for (int row = 0; row < 3; row++)
                for (int column = 0; column < 3; column++)
                    if (board.GetState(new Position(row, column)) == State.empty) return false;

            return true;
        }
    }
    public class Renderer
    {
        public void Render(Board board)
        {
            char[,] symbols = new char[3, 3];
            for (int row = 0; row < 3; row++)
                for (int column = 0; column < 3; column++)
                    symbols[row, column] = SymbolFor(board.GetState(new Position(row, column)));
        
            Console.WriteLine($" { symbols[0,0]} | {symbols[0,1]} | {symbols[0,2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" { symbols[1, 0]} | {symbols[1, 1]} | {symbols[1, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" { symbols[2, 0]} | {symbols[2, 1]} | {symbols[2, 2]} ");
        }
        private char SymbolFor(State state)
        {
            switch (state)
            {
                case State.O: return 'O';
                case State.X: return 'X';
                default: return ' ';
            }
        }
        public void RenderResults(State winner)
        {
            switch (winner)
            {
                case State.O:
                case State.X:
                    Console.WriteLine(SymbolFor(winner) + "Wins!");
                    break;
                case State.empty:
                    Console.WriteLine("Draw!");
                    break;
            }
        }
    }
}
