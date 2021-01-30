using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyserUnitTest
{
    class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyser(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalysetype = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalysetype);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
                }
            }
            else
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "Constructor not found");

            }
        }
        public static object CreateMoodAnalyseUsingParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyser);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructors = type.GetConstructor(new[] { typeof(string) });
                    object instance = constructors.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "Constructor not found");

                }
            }

            else
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
            }
        }

    }
}
    

