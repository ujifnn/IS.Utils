/**********************************************************************************
 *
 * Copyright (C) 2013 - 2013 IT-Solutions. All rights reserved.
 * 
 *********************************************************************************/

using System;

namespace IS.Utils.Common.Asserts
{
    /// <summary>
    /// Включает в себя методы валидации аргументов.
    /// <br />
    /// Данный класс полезен для валидации аргументов публичных методов других классов.
    /// </summary>
    /// <remarks>
    /// Все бросаемые исключения - производные от <see cref="ArgumentException"/>.
    /// <p><i>Не используйте данный класс в тестах.</i></p>
    /// </remarks>
    public static class AssertArg
    {
        /// <summary>
        /// Бросает <see cref="ArgumentNullException"/> если аргумент равен <c>null</c>.
        /// </summary>
        /// <param name="argValue">значение аргумента</param>
        /// <param name="argName">имя аргумента</param>
        /// <param name="errorMessage">текст сообщения об ошибке (по умолчанию <c>null</c>)</param>
        public static void NotNull(object argValue, string argName, string errorMessage = null)
        {
            if (argValue == null)
            {
                throw new ArgumentNullException(argName, errorMessage);
            }
        }

        /// <summary>
        /// Бросает <see cref="ArgumentException"/> если аргумент - <c>null</c> или пустая строка.
        /// </summary>
        /// <param name="argValue">значение аргумента</param>
        /// <param name="argName">имя аргумента</param>
        /// <param name="errorMessage">текст сообщения об ошибке (по умолчанию <c>null</c>)</param>
        public static void HasText(string argValue, string argName, string errorMessage = null)
        {
            if (string.IsNullOrEmpty(argValue))
            {
                throw new ArgumentException(argName, errorMessage);
            }
        }

        /// <summary>
        /// Бросает <see cref="ArgumentException"/> если условие, наложенное на аргумент, равно <c>false</c>.
        /// </summary>
        /// <param name="condition">условие на аргумент</param>
        /// <param name="argName">имя аргумента</param>
        /// <param name="errorMessage">текст сообщения об ошибке (по умолчанию <c>null</c>)</param>
        public static void IsTrue(bool condition, string argName, string errorMessage = null)
        {
            if (!condition)
            {
                throw new ArgumentException(argName, errorMessage);
            }
        }
    }
}
