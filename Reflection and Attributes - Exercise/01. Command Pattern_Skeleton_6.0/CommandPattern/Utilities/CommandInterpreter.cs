

namespace CommandPattern.Utilities
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[]array=args.Split(' ');
            string commandName = array[0];
            string[]cmdArgs=array.Skip(1).ToArray();
            Assembly assembly= Assembly.GetEntryAssembly();
            Type intendetCommandType= assembly.GetTypes()
             .FirstOrDefault(t=>t.Name==$"{commandName}Command");
            if( intendetCommandType == null )
            {
                throw new InvalidOperationException("InvalidCommandType!!!");
            }
            MethodInfo executeMethod = intendetCommandType
           .GetMethods(BindingFlags.Instance | BindingFlags.Public)
           .FirstOrDefault(m => m.Name == "Execute");
            if( executeMethod == null )
            {
                throw new InvalidOperationException("Command doesnt implement!!!");

            }
           
           object cmdInterpretator=Activator.CreateInstance(intendetCommandType);
            string result = (string)executeMethod.Invoke(cmdInterpretator, new object[] { });
            return result;

           

        }
    }
}
