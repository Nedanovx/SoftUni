﻿using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public Spy()
        {

        }
        public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
        {
            Type classType = Type.GetType(investigatedClass);

            FieldInfo[] fieldsInfo = classType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic
                | BindingFlags.Static);

            StringBuilder sb = new StringBuilder();

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            sb.AppendLine($"Class under investigation: {investigatedClass}");

            foreach(FieldInfo field in fieldsInfo.Where(x=>requestedFields.Contains(x.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }
            return sb.ToString().Trim();
        }
        public string AnalyzeAccessModifiers(string investigatedClass)
        {
            Type classType = Type.GetType(investigatedClass);

            FieldInfo[] fieldInfos = classType.GetFields(BindingFlags.Public | BindingFlags.Instance 
                | BindingFlags.Static | BindingFlags.NonPublic);
            MethodInfo[] nonPublicMethods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            MethodInfo[] publicMethods = classType.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            StringBuilder sb = new StringBuilder();
            

            foreach(FieldInfo field in fieldInfos)
            {
                if(!field.IsPrivate)
                {
                    sb.AppendLine($"{field.Name} must be private!");
                }
            }   

            foreach (MethodInfo method in nonPublicMethods.Where(x => x.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }

            foreach(MemberInfo publicMethod in publicMethods.Where(x=>x.Name.StartsWith("set")))
            {
                sb.AppendLine($"{publicMethod.Name} have to be private!");
            }

            return sb.ToString().Trim();
        }
        
        public string CollectGetterAndSetter(string investigatedClass)
        {
            Type classType = Type.GetType(investigatedClass);

            MethodInfo[] methodInfos = classType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            StringBuilder sb = new StringBuilder();

            foreach (MethodInfo method in methodInfos.Where(x => x.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }
            foreach (MethodInfo method in methodInfos.Where(x => x.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }
            return sb.ToString().Trim();
        }
    }
}
