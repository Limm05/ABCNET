﻿using ABCNET.Utils;
using System;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с массивами.
    /// </summary>
    public static partial class ArrExt
    {
        #region public
        /// <summary>
        /// Заполняет массив на основе функции селектора.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="selector">Функция селектор.</param>
        /// <param name="firstIndex">Начальный индекс.</param>
        public static void Gen<T>(this T[] array, Func<int, T> selector, int firstIndex = 0)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            for (int i = 0; i < array.Length; i++)
                array[i] = selector(i + firstIndex);
        }

        /// <summary>
        /// Заполняет массив на основе функции селектора.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="first">Первый элемент.</param>
        /// <param name="next">Функция получения следующего элемента.</param>
        public static void Gen<T>(this T[] array, T first, Func<T, T> next)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));
            if (next == null)
                throw new ArgumentNullException(nameof(next));

            array[0] = first;
            for (int i = 1; i < array.Length; i++)
                array[i] = next(array[i - 1]);
        }

        /// <summary>
        /// Заполняет массив случайными числами типа Int32.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        public static void Rand(this int[] array, int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));
            if (low > high)
                throw new ArgumentException(nameof(low));

            for (int i = 0; i < array.Length; i++)
                array[i] = Base.Rand(low, high);
        }

        /// <summary>
        /// Заполняет массив случайными числами типа Double.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="low">Нижняя граница диапазона.</param>
        /// <param name="high">Верхняя граница диапазона.</param>
        public static void Rand(this double[] array, double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));
            if (low > high)
                throw new ArgumentException(nameof(low));

            for (int i = 0; i < array.Length; i++)
                array[i] = Base.Rand(low, high);
        }

        /// <summary>
        /// Заполняет массив указанным значением.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="value">Значение.</param>
        public static void Fill<T>(this T[] array, T value)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            for (int i = 0; i < array.Length; i++)
                array[i] = value;
        }
        #endregion public
    }
}
