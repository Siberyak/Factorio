using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace lua.reader
{
    /// <summary>
    ///     ������ ��� ������ � ���������� ������ ����
    /// </summary>
    public static class MemberInfoExtender
    {
        #region Public Methods and Operators

        /// <summary>
        ///     ������� ������� ���� ����� ����. ������, ���� ���������
        /// </summary>
        /// <param name="memberInfo">���� ����</param>
        /// <param name="inherit">� ������ ������������</param>
        /// <typeparam name="T">��� ��������</typeparam>
        /// <returns></returns>
        public static T Attribute<T>(this MemberInfo memberInfo, bool inherit = false) //where T : Attribute
        {
            return memberInfo.AttributesByType<T>(inherit).FirstOrDefault();
        }

        /// <summary>
        ///     ������� ������� ���� ����� ����. ������, ���� ���������
        /// </summary>
        /// <param name="memberInfo">���� ����</param>
        /// <param name="attributeType">��� ��������</param>
        /// <param name="inherit">� ������ ������������</param>
        /// <returns></returns>
        public static Attribute Attribute(this MemberInfo memberInfo, Type attributeType, bool inherit = false)
        {
            return memberInfo.Attributes(attributeType, inherit).FirstOrDefault();
        }

        /// <summary>
        ///     �������� ������� ���� ����� ����.
        /// </summary>
        /// <param name="memberInfo">���� ����</param>
        /// <param name="inherit">� ������ ������������</param>
        /// <typeparam name="T">��� ��������</typeparam>
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
        ///     �������� ������� ���� ����� ����
        /// </summary>
        /// <param name="memberInfo">���� ����</param>
        /// <param name="attributeType">��� ��������</param>
        /// <param name="inherit">� ������ ������������</param>
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