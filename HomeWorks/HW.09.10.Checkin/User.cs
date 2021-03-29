using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HW._09._10.Checkin
{
    class User : ValidationHelper
    {
        private readonly Guid id = Guid.NewGuid();
        private static List<User> listUser= new List<User>();

        [Required]
        [RegularExpression(@"^[A-ZА-Я][a-zа-я]+\s[A-ZА-Я][a-zа-я]+$", ErrorMessage = Constants.errMessName)]
        public string FullName { get; private set; }

        [Required]
        [RegularExpression(@"^[A-ZА-Я]{2}[0-9]{7}$", ErrorMessage = Constants.errMessPassport)]
        public string Passport { get; private set; }

        [Required]
        [RegularExpression(@"^yes|no$", ErrorMessage = Constants.errMessBool)]
        public string Baggage { get; private set; }

        [Required]
        [RegularExpression(@"\b([0-9]|[0-9]\d)\b", ErrorMessage = Constants.errMessBaggWeight)]
        public string BaggageWeight { get; private set; }

        [Required]
        [RegularExpression(@"^yes|no$", ErrorMessage = Constants.errMessBool)]
        public string Ticket { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{7}$", ErrorMessage = Constants.errMessTicketNum)]
        public string TicketNum { get; set; }

        public void AddUser()
        {
            Console.WriteLine("Enter first and last name in the format \"FirstName LastName\":");
            while (!Validation(new ValidationContext(this) { MemberName = "FullName" }, FullName))
            {
                FullName = Console.ReadLine();
            }

            Console.WriteLine("Enter the series and number of the passport in the format \"SSnnnnnnn\":");
            while (!Validation(new ValidationContext(this) { MemberName = "Passport" }, Passport))
            {
                Passport = Console.ReadLine();
            }

            Console.WriteLine("Do you have baggage? (yes/no):");
            while (!Validation(new ValidationContext(this) { MemberName = "Baggage" }, Baggage))
            {
                Baggage = Console.ReadLine();
            }

            if (Baggage == "yes")
            {
                Console.WriteLine("Enter the weight of your baggage");
                while (!Validation(new ValidationContext(this) { MemberName = "BaggageWeight" }, BaggageWeight))
                {
                    BaggageWeight = Console.ReadLine();
                }
            }

            Console.WriteLine("Do you have a ticket? (yes/no):");
            while (!Validation(new ValidationContext(this) { MemberName = "Ticket" }, Ticket))
            {
                Ticket = Console.ReadLine();
            }

            if (Ticket == "yes")
            {
                Console.WriteLine("Enter the seven digits of your ticket:");
                while (!Validation(new ValidationContext(this) { MemberName = "TicketNum" }, TicketNum))
                {
                    TicketNum = Console.ReadLine();
                }
            }
        }

        public void ShowCurrentUser()
        {
            Console.WriteLine($"Full name:      {FullName}\n" +
                              $"Passport:       {Passport}\n" +
                              $"Baggage:        {Baggage}\n" +
                              $"Baggage weight: {BaggageWeight}\n" +
                              $"Ticket:         {Ticket}\n" +
                              $"Ticket number:  {TicketNum}\n" +
                              $"Id:             {id}\n");
        }

        public void SaveUser(User user)
        {
            listUser.Add(user);
        }

        public static void ShowAllUser()
        {
            foreach (var item in listUser)
            {
                Console.WriteLine($"Full name:      {item.FullName}\n" +
                                  $"Passport:       {item.Passport}\n" +
                                  $"Baggage:        {item.Baggage}\n" +
                                  $"Baggage weight: {item.BaggageWeight}\n" +
                                  $"Ticket:         {item.Ticket}\n" +
                                  $"Ticket number:  {item.TicketNum}\n" +
                                  $"Id:             {item.id}\n");
            }
        }
    }
}