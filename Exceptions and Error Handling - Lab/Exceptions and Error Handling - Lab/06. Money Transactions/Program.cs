namespace _06._Money_Transactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine()
             .Split(",", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<int,double>transactions= new Dictionary<int,double>();
            for (int i = 0; i < line.Length; i++)
            {
                string[] acountByBalance = line[i].Split("-");
                int accountNumber = int.Parse(acountByBalance[0]);
                double acountBalance = double.Parse(acountByBalance[1]);
                if (!transactions.ContainsKey(accountNumber))
                {
                    transactions.Add(accountNumber,0);
                }
                transactions[accountNumber] = acountBalance;

            }
            string command=Console.ReadLine();
            while(command != "End")
            {
                string[]cmdArgs=command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string typeCommand = cmdArgs[0];
                int acountNumber = int.Parse(cmdArgs[1]);
                double sum = double.Parse(cmdArgs[2]);
                try
                {
                    if (!transactions.ContainsKey(acountNumber))
                    {
                        throw new ArgumentException("Invalid account!");
                    }
                    switch(typeCommand)
                    {
                        case "Deposit":
                            transactions[acountNumber] += sum;
                            Console.WriteLine($"Account {acountNumber}" +
                                $" has new balance: {transactions[acountNumber]:f2}");
                            break;
                        case "Withdraw":
                            if (transactions[acountNumber] < sum)
                            {
                                throw new InvalidOperationException("Insufficient balance!");
                            }
                            transactions[acountNumber] -= sum;
                            Console.WriteLine($"Account {acountNumber} has new " +
                                $"balance: {transactions[acountNumber]:f2}");
                            break;
                        default:
                            throw new InvalidDataException("Invalid command!");

                    }
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidOperationException inv)
                {
                    Console.WriteLine(inv.Message);
                }
                catch (InvalidDataException inv)
                {
                    Console.WriteLine(inv.Message);
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
                command = Console.ReadLine();

            }


        }
    }
}