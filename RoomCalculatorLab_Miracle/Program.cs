namespace RoomCalculatorLab_Miracle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter the Length of your room in feet.");

            decimal roomLength = decimal.Parse(Console.ReadLine());
            decimal userRoomLength = (roomLength);

            Console.WriteLine("Hello, please enter the Width of your room in feet.");

            decimal roomWidth = decimal.Parse(Console.ReadLine());
            decimal userRoomWidth = (roomWidth);

            Console.WriteLine($"Your room has an area of {userRoomLength * userRoomWidth} square feet.");

            Console.WriteLine($"Your room has a perimeter of {userRoomLength * 2 + userRoomWidth * 2} feet.");

            decimal area = userRoomLength * userRoomWidth;
            if (area <= 250)

                Console.WriteLine("You have a small room.");

            else if (area > 250 && area >= 650)

                Console.WriteLine("You have a medium sized room.");

            else

                Console.WriteLine("You have a large sized room.");

            
            Console.WriteLine("Thank you for using the Room Detail Generator!");



        }

    }
}