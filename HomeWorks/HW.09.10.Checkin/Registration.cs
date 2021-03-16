using System;

namespace HW._09._10.Checkin
{
    class Registration
    {
        private bool BaggageAdmission { get; set; }
        private bool PassportAdmission { get; set; }

        Random rand = new();

        public Registration(string fullName, string passport, string baggage, string ticket, string ticketNum, User user)
        {
            Console.WriteLine($"Hello, {fullName}, go to the baggage inspection");
            BaggageControl(user);
        }

        public Registration(string fullName, string passport, string ticket, string ticketNum, User user)
        {
            Console.WriteLine($"Hello, {fullName}, go to passport control");
            PassportControl(user);
        }

        public Registration(string fullName, string passport, string baggage, User user)
        {
            user.Ticket = "yes";
            user.TicketNum = rand.Next(9999999).ToString();
            Console.WriteLine($"{fullName}, number of your ticket {user.TicketNum}, go to the baggage inspection");
            BaggageControl(user);
        }

        public Registration(string fullName, string passport, User user)
        {
            user.Ticket = "yes";
            user.TicketNum = rand.Next(9999999).ToString();
            Console.WriteLine($"{fullName}, number of your ticket {user.TicketNum} go to passport control");
            PassportControl(user);
        }

        private void BaggageControl(User user)
        {
            BaggageAdmission = Convert.ToInt32(user.BaggageWeight) < Constants.allowableBaggageWeight ? true : false;
            if (BaggageAdmission == true)
            {
                Console.WriteLine("The inspection was successful, go to passport control");
                PassportControl(user);
            }
            else
            {
                Console.WriteLine("Unacceptable baggage weight, not approved for flight");
            }
        }

        private void PassportControl(User User)
        {
            PassportAdmission = Convert.ToBoolean(rand.Next(2));
            if (PassportAdmission == true)
            {
                Console.WriteLine("The passport control was successful, happy trip");
            }
            else
            {
                Console.WriteLine("You have not passed passport control, you are not allowed to fly");
            }
        }
    }
}