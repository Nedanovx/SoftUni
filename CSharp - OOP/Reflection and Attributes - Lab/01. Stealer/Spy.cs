using System.Reflection;
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
    }
}
