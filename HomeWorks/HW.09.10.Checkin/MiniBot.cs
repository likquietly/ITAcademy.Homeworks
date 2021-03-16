using System;

namespace HW._09._10.Checkin
{
    class MiniBot
    {
        private string NameBot { get; set; }
        private string Answer { get; set; }

        public void SetName()
        {
            Console.WriteLine("Enter the bot name:");
            NameBot = Console.ReadLine();
            Greeting();
        }

        private void Greeting()
        {
            Console.WriteLine($"Bot {NameBot} greets you in Minsk airport at {GetCurrentDate()}!\n" +
                              $"Would you like to fill in information about yourself so that I can help you?");

            while (Answer != "yes" && Answer != "no")
            {
                Console.WriteLine(Constants.errMessBool);
                Answer = Console.ReadLine();
            }

            Chat(Answer);
        }

        private void Chat(string answer)
        {
            if (answer.Equals("yes"))
            {
                User user = new User();
                user.AddUser();
                user.SaveUser(user);
                user.ShowCurrentUser();

                if (user.Baggage == "yes" && user.Ticket == "yes")
                {
                    Registration regUser = new(user.FullName, user.Passport, user.Baggage, user.Ticket, user.TicketNum, user);
                }
                else if (user.Baggage == "no" && user.Ticket == "yes")
                {
                    Registration regUser = new(user.FullName, user.Passport, user.Ticket, user.TicketNum, user);
                }
                else if (user.Baggage == "yes" && user.Ticket == "no")
                {
                    Registration regUser = new(user.FullName, user.Passport, user.Baggage, user);
                }
                else if (user.Baggage == "no" && user.Ticket == "no")
                {
                    Registration regUser = new(user.FullName, user.Passport, user);
                }
            }
            else
            {
                Console.WriteLine("See you again, all the best!");
            }
        }

        private string GetCurrentDate()
        {
            return $"{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}, " +
                   $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
        }
    }
}