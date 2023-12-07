using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace Змейка
{
    internal class Игра
    {
        static readonly int x = 50;
        static readonly int y = 50;
        static Snake snake;
        static FoodFactory foodFactory;
        static Walls walls;
        static Timer time;
        static void Loop(object obj);


        static void Main()
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Rotation(key.Key);
                }

                if (walls.IsHit(snake.GetHead()) || snake.IsHit(snake.GetHead()))
                {
                    time.Change(0, Timeout.Infinite);
                }
                else if (snake.Eat(foodFactory.food))
                {
                    foodFactory.CreateFood();
                }
                else
                {
                    snake.Move();


                    Console.SetWindowSize(x + 1, y + 1);
                    Console.SetBufferSize(x + 1, y + 1);
                    Console.CursorVisible = false;
                    snake = new Snake(x / 2, y / 2, 3);
                    foodFactory = new FoodFactory(x, y, '@');
                    foodFactory.CreateFood();
                    walls = new Walls(x, y, '#');
                    time = new Timer(Loop, null, 0, 200);
                }
            }
        }

       
        struct Point
        {
            public int x;
            public int y;
            public char ch;

            public static implicit operator Point((int, int, char) value) =>
            new Point { x = value.Item1, y = value.Item2, ch = value.Item3 };

            public static bool operator ==(Point a, Point b) =>
            (a.x == b.x && a.y == b.y) ? true : false;

            public static bool operator !=(Point a, Point b) =>
           (a.x != b.x || a.y != b.y) ? true : false;
        }
    }
    public void Draw()
    {
        DrawPoint(ch);
    }

    public void Clear()
    {
        DrawPoint(' ');
    }

    private void DrawPoint(char _ch)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(_ch);
    }
    class Walls
    {

        private char ch;
        private List<Point> wall = new List<Point>();
        public bool IsHit(Point p)
        {
            foreach (var w in wall)
            {
                if (p == w)
                {
                    return true;
                }
            }
            return false;
        }
        public Walls(int x, int y, char ch)
        {
            this.ch = ch;
            DrawHorizontal(x, 0);
            DrawHorizontal(x, y);
            DrawVertical(0, y);
            DrawVertical(x, y);
        }

        private void DrawHorizontal(int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                Point p = (i, y, ch);
                p.Draw();
                wall.Add(p);
            }
        }
        private void DrawVertical(int x, int y)
        {

            for (int i = 0; i < y; i++)
            {
                Point p = (x, i, ch);
                p.Draw();
                wall.Add(p);
            }
        }


        class FoodFactory
        {
            int x;
            int y;
            char ch;
            public Point food { get; private set; }

            Random random = new Random();

            public FoodFactory(int x, int y, char ch)
            {
                this.x = x;
                this.y = y;
                this.ch = ch;
            }

            public void CreateFood()
            {
                food = (random.Next(2, x - 2), random.Next(2, y - 2), ch);
                food.Draw();
            }
        }

        class Snake
        {

            private List<Point> snake;
            private Direction direction;
            private int step = 1;
            private Point tail;
            private Point head;
            bool rotate = true;
            public Snake(int x, int y, int length)
            {
                direction = Direction.RIGHT;
                snake = new List<Point>();
                for (int i = x - length; i < x; i++)
                {
                    Point p = (i, y, '*');
                    snake.Add(p);
                    p.Draw();
                }
            }

            public void StartMoving()
            {
                Thread thread = new Thread(MoveSnake);
                thread.Start();
            }

            private void MoveSnake()
            {
                public Point GetHead() => snake.Last();
                public void Move()
                {
                    head = GetNextPoint();
                    snake.Add(head);
                    tail = snake.First();
                    snake.Remove(tail);
                    tail.Clear();
                    head.Draw();
                    rotate = true;
                }
                public Point GetNextPoint()
                {
                    Point p = GetHead();
                    switch (direction)
                    {
                        case Direction.LEFT:
                            p.x -= step;
                            break;
                        case Direction.RIGHT:
                            p.x += step;
                            break;
                        case Direction.UP:
                            p.y -= step;
                            break;
                        case Direction.DOWN:
                            p.y += step;
                            break;
                    }
                    return p;
                }

                while (true)
                {
                    Move();
                    movementTimer = new Timer(200);
                    movementTimer.Elapsed += OnTimedEvent;
                    movementTimer.AutoReset = true;
                    movementTimer.Enabled = true;
                    Thread.Sleep(200);
                }
            }
        }

        class Program
        {
            static void Main()
            {
                Snake snake = new Snake();
                
                 private Point head;
            private Direction direction;
            private List<Point> body;
            private int length;
            private double speed;
                
            public Snake(Point head, Direction direction, int length, double speed)
            {
                this.head = head;
                this.direction = direction;
                this.length = length;
                this.speed = speed;
                this.body = new List<Point>();
                this.body.Add(head);
                snake.StartMoving();
            }
                
        }   


       
    }
}




