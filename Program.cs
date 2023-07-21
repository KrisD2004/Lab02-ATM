namespace Lab02_ATM

{
    public static class Program
    {
        // Declare a static variable to store the balance
        public static decimal Balance;
        public static void Main(string[] args)
        {
            //Im calling the userinterface method to boot up my ATM program
            UserInterface();



        }


        static void UserInterface()
        {
            //should display current balance when you first run it
            Balance = ViewBalance(Balance);


            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Press V to view balance");
                Console.WriteLine("Press W to withdraw");
                Console.WriteLine("Press D to deposit");
                Console.WriteLine("Press E to Exit Bank");
                string input = Console.ReadLine();

                //view balance
                if (input == "V" || input == "v")
                {
                    Balance = ViewBalance(Balance); //calls my method to view the current balance
                }
                // making withdrawal
                else if (input == "W" || input == "w")
                {
                    if (Balance != 0)
                    {
                        Console.Write("How much you would want to withdraw? ");
                        int withdraw = Convert.ToInt32(Console.ReadLine());
                        if (withdraw > Balance)
                        {
                            Console.WriteLine("You have insufficent funds.");
                        }
                        else
                        {
                            Balance = Withdraw(Balance, withdraw); // Calls a method to perform a withdrawal
                            Console.WriteLine("You now have $" + Balance);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Insufficent funds cant withdraw ");
                    }
                }

                // Make Deposit
                else if (input == "D" || input == "d")
                {
                    Console.WriteLine("How much you would want to Deposit? ");
                    int deposit = Convert.ToInt32(Console.ReadLine());

                    if (deposit > 0)
                    {
                        Balance = Deposit(Balance, deposit); // Calls a method to perform a deposit
                        Console.WriteLine("You now have $" + Balance + " in your bank account .");
                    }
                }

                // Exit Bank
                else if (input == "E" || input == "e")
                {
                    return;
                }

            }
        }

        // Method to withdraw from the balance
        public static decimal ViewBalance(decimal Balance)
        {
            Console.WriteLine("You have $" + Balance + " in your bank.");
            return Balance;


        }
        // Method to withdraw from the balance
        public static decimal Withdraw(decimal Balance, decimal withdraw)
        {
            Balance -= withdraw;

            return Balance;
        }

        // Method to deposit into the balance
        public static decimal Deposit(decimal Balance, decimal deposit)
        {

            Balance += deposit;

            return Balance;
        }

        // Testing method for withdrawal 
        // This method serves as a testing method for withdrawing. It calculates the new balance after withdrawing the specific amount.
        public static decimal WithdrawTest(decimal withdrawalAmount, decimal decimalBalance)
        {
            decimal newBalance = Withdraw(withdrawalAmount, decimalBalance);
            return newBalance;
        }

        //testing method for depositing
        // This method serves as a testing method for depositing. It calculates the new balance after depositing the specified amount.
        public static decimal DepositTest(decimal decimalBalance, decimal depositAmount)
        {
            decimal newBalance = Deposit(depositAmount, decimalBalance);
            return newBalance;

        }

        //test method for viewing the balance
        // the method serves as a wrapper for the ViewBalance method, passing the balance parameter and returning the result.
        public static decimal ViewBalanceTest(decimal balance)
        {
            return ViewBalance(balance);
        }
    }




}

