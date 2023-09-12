

namespace Telephony.Core
{
    using System;
    using Interfaces;
    using Telephony.Exceptions;
    using Telephony.IO.Interfaces;
    using Telephony.Models;
    using Telephony.Models.Interfaces;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IStationeryPhone stationeryPhone;
        private readonly ISmartPhone smartphone;
        public Engine()
        {
            this.stationeryPhone = new StationaryPhone();
            this.smartphone = new SmartPhone();
        }
        public Engine(IReader reader, IWriter writer)
            : this() 
        {
            this.reader = reader;
            this.writer = writer;

        }
        public void Run()
        {
            string[] phoneNumbers = this.reader.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] urls = this.reader.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);
            try
            {
               
                foreach (string phoneNumber in phoneNumbers)
                {
                    if (phoneNumber.Length == 10)
                    {
                        this.writer.WriteLine(this.smartphone.Call(phoneNumber));
                    }
                    else if (phoneNumber.Length == 7)
                    {
                        this.writer.WriteLine(this.stationeryPhone.Call(phoneNumber));
                    }
                    else
                    {
                        throw new InvalidPhoneNumberException();
                    }
                }
            }
            catch(InvalidPhoneNumberException ex)
            {
                this.writer.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                throw;
            }
            try
            {
                foreach (var url in urls)
                {
                    this.writer.WriteLine(this.smartphone.BrowseURL(url));
                }
            }
            catch (InvalidURLException iue) 
            {
                this.writer.WriteLine(iue.Message);
            }
            catch (Exception )
            {
                throw;
            }

               
                

            
           
           
        }
    }
}
