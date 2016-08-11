using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace lua.reader
{
    /// <summary>
    ///     хелпер для работы с атрибутами членов типа
    /// </summary>
    public static class MemberInfoExtender
    {
        #region Public Methods and Operators

        /// <summary>
        ///     атрибут нужного типа члена типа. первый, если несколько
        /// </summary>
        /// <param name="memberInfo">член типа</param>
        /// <param name="inherit">с учетом наследования</param>
        /// <typeparam name="T">тип атрибута</typeparam>
        /// <returns></returns>
        public static T Attribute<T>(this MemberInfo memberInfo, bool inherit = false) //where T : Attribute
        {
            return memberInfo.AttributesByType<T>(inherit).FirstOrDefault();
        }

        /// <summary>
        ///     атрибут нужного типа члена типа. первый, если несколько
        /// </summary>
        /// <param name="memberInfo">член типа</param>
        /// <param name="attributeType">тип атрибута</param>
        /// <param name="inherit">с учетом наследования</param>
        /// <returns></returns>
        public static Attribute Attribute(this MemberInfo memberInfo, Type attributeType, bool inherit = false)
        {
            return memberInfo.Attributes(attributeType, inherit).FirstOrDefault();
        }

        /// <summary>
        ///     атрибуты нужного типа члена типа.
        /// </summary>
        /// <param name="memberInfo">член типа</param>
        /// <param name="inherit">с учетом наследования</param>
        /// <typeparam name="T">тип атрибута</typeparam>
        /// <returns></returns>
        public static IEnumerable<T> Attributes<T>(this MemberInfo memberInfo, bool inherit = false) //where T : Attribute
        {
            return memberInfo.AttributesByType<T>(inherit).ToArray();
        }

        public static object GetValue(this MemberInfo member, object component)
        {
            object memberValue;
            if (member is PropertyInfo)
            {
                memberValue = ((PropertyInfo)member).GetValue(component);
            }
            else if (member is FieldInfo)
            {
                memberValue = ((FieldInfo)member).GetValue(component);
            }
            else if (member is MethodInfo)
            {
                memberValue = ((MethodInfo)member).Invoke(component, new object[0]);
            }
            else
            {
                throw new NotImplementedException();
            }

            return memberValue;
        }

        public static bool HasAttribute<T>(this MemberInfo memberInfo, bool inherit = false)
        {
            return memberInfo.AttributesByType<T>(inherit).Any();
        }

        public static Type MemberValueType(this MemberInfo memberInfo)
        {
            switch (memberInfo.MemberType)
            {
                case MemberTypes.Method:
                    return ((MethodInfo)memberInfo).ReturnType;
                case MemberTypes.Property:
                    return ((PropertyInfo)memberInfo).PropertyType;
                case MemberTypes.Constructor:
                    return memberInfo.DeclaringType;
                case MemberTypes.Field:
                    return ((FieldInfo)memberInfo).FieldType;
                default:
                    throw new InvalidOperationException();
            }
        }

        public static void Set(this MemberInfo member, object instance, object memberValue)
        {
            switch (member.MemberType)
            {
                case MemberTypes.Field:
                    ((FieldInfo)member).SetValue(instance, memberValue);
                    break;
                case MemberTypes.Property:
                    ((PropertyInfo)member).SetValue(instance, memberValue);
                    break;
                case MemberTypes.Method:
                    ((MethodInfo)member).Invoke(instance, new[] { memberValue });
                    break;
                //case MemberTypes.Constructor:
                //    break;
                //case MemberTypes.Event:
                //    break;
                //case MemberTypes.TypeInfo:
                //    break;
                //case MemberTypes.Custom:
                //    break;
                //case MemberTypes.NestedType:
                //    break;
                //case MemberTypes.All:
                //    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static bool TryGetValue<T>(this MemberInfo member, object component, out T value)
        {
            value = default(T);

            object memberValue;
            if (member is PropertyInfo)
            {
                memberValue = ((PropertyInfo)member).GetValue(component);
            }
            else if (member is FieldInfo)
            {
                memberValue = ((FieldInfo)member).GetValue(component);
            }
            else if (member is MethodInfo)
            {
                memberValue = ((MethodInfo)member).Invoke(component, new object[0]);
            }
            else
            {
                return false;
            }

            bool valueResolved = memberValue is T;
            value = valueResolved ? (T)memberValue : default(T);
            return valueResolved;
        }

        #endregion

        #region Methods

        /// <summary>
        ///     атрибуты нужного типа члена типа
        /// </summary>
        /// <param name="memberInfo">член типа</param>
        /// <param name="attributeType">тип атрибута</param>
        /// <param name="inherit">с учетом наследования</param>
        /// <returns></returns>
        private static IEnumerable<Attribute> Attributes(this MemberInfo memberInfo, Type attributeType, bool inherit = false)
        {
            return memberInfo.GetCustomAttributes(attributeType, inherit).OfType<Attribute>().ToArray();
        }

        private static IEnumerable<T> AttributesByType<T>(this MemberInfo memberInfo, bool inherit = false)
        {
            return memberInfo.GetCustomAttributes(inherit).OfType<T>();
        }

        #endregion
    }
}