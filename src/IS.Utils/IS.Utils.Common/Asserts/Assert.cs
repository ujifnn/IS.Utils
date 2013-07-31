/**********************************************************************************
 *
 * Copyright (C) 2013 - 2013 IT-Solutions. All rights reserved.
 * 
 *********************************************************************************/

using System;

namespace IS.Utils.Common.Asserts
{
    /// <summary>
    /// Включает в себя методы валидации.
    /// </summary>
    /// <remarks>
    /// Данный класс используется для валидации выражений и объектов, <b>не являющихся аргументами</b> методов. 
    /// Для валидации аргументов рекомендуется использовать <see cref="AssertArg"/>.
    /// <p><i>Не используйте данный класс в тестах.</i></p>
    /// </remarks>
    public static class Assert
    {
        /// <summary>
        /// Бросает <see cref="NullReferenceException"/> если выражение равно <c>null</c>.
        /// </summary>
        /// <param name="obj">выражение</param>
        /// <param name="errorMessage">текст сообщения об ошибке (по умолчанию <c>null</c>)</param>
        public static void NotNull(object obj, string errorMessage = null)
        {
            if (obj == null)
            {
                throw new NullReferenceException(errorMessage);
            }
        }

        /// <summary>
        /// Бросает <see cref="InvalidOperationException"/> если условие равно <c>false</c>.
        /// </summary>
        /// <param name="condition">условие</param>
        /// <param name="errorMessage">текст сообщения об ошибке (по умолчанию <c>null</c>)</param>
        public static void IsTrue(bool condition, string errorMessage = null)
        {
            if (!condition)
            {
                throw new InvalidOperationException(errorMessage);
            }
        }
    }
}
