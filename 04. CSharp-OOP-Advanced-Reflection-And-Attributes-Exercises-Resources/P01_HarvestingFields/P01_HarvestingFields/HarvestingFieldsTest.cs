 namespace P01_HarvestingFields
{
    using System;
    using System.Reflection;
    using System.Runtime.Serialization.Formatters;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            string typeAccsesModifier=Console.ReadLine();
           
            while (typeAccsesModifier!= "HARVEST")
            {
                Type typeHarvest=typeof(HarvestingFields);
                FieldInfo[] fieldInfos;
                switch (typeAccsesModifier)
                {
                    case "public":
                        fieldInfos = typeHarvest.GetFields(BindingFlags.Instance
                            | BindingFlags.Public);
                        PrintInformation(typeAccsesModifier, fieldInfos);
                        break;
                    case "protected":
                        fieldInfos = typeHarvest.GetFields(BindingFlags.Instance 
                            |BindingFlags.NonPublic);
                        PrintInformation(typeAccsesModifier, fieldInfos);
                        break;
                    case "private":
                        fieldInfos = typeHarvest.GetFields(BindingFlags.NonPublic 
                            | BindingFlags.Instance );
                        PrintInformation(typeAccsesModifier, fieldInfos);
                        break;
                    case "all":
                        fieldInfos = typeHarvest.GetFields((BindingFlags)60);
                        foreach (var item in collection)
                        {

                        }
                        break;
                      
                }
             
                typeAccsesModifier = Console.ReadLine();
                


            }

        }
        static void PrintInformation(string typeModifier,FieldInfo[]fieldInfos)
        {
            foreach (FieldInfo field in fieldInfos)
            {

                Console.WriteLine("{0} {1} {2}"
                    ,typeModifier,field.FieldType.Name,field.Name);
            }
        }
        
    }
}
