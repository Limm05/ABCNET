using System;
using System.Collections.Generic;

namespace ABCNETRUS.�������
{
    /// <summary>
    /// ������������� ���������� ��� ������ � ��������������������.
    /// </summary>
    public static class ������������������
    {
        /// <summary>
        /// ������ ������������������ �� ������ ������� ���������.
        /// </summary>
        /// <param name="�����">���������� ���������.</param>
        /// <param name="�����������">������� ��������.</param>
        /// <param name="������������">��������� ������.</param>
        /// <returns>������������������.</returns>
        public static IEnumerable<T> ������������<T>(int �����, Func<int, T> �����������, int ������������ = 0)
        {
            if (����� < 0)
                throw new �������������������������������������(nameof(�����));
            if (����������� == null)
                throw new ����������������Null������(nameof(�����������));

            for (int i = 0; i < �����; i++)
                yield return �����������(i + ������������);
        }

        /// <summary>
        /// ������ ������������������ ��������� ����� ���� Integer.
        /// </summary>
        /// <param name="�����">���������� ���������.</param>
        /// <param name="������">������ ������� ���������.</param>
        /// <param name="�������">������� ������� ���������.</param>
        /// <returns>������������������.</returns>
        public static IEnumerable<int> ���������(int �����, int ������ = ��������������������.������, int ������� = ��������������������.�������)
        {
            if (����� < 0)
                throw new �������������������������������������(nameof(�����));
            if (������ > �������)
                throw new ����������������������(nameof(������));

            for (int i = 0; i < �����; i++)
                yield return ��������.���������(������, �������);
        }

        /// <summary>
        /// ������ ������������������ ��������� ����� ���� Real.
        /// </summary>
        /// <param name="�����">���������� ���������.</param>
        /// <param name="������">������ ������� ���������.</param>
        /// <param name="�������">������� ������� ���������.</param>
        /// <returns>������������������.</returns>
        public static IEnumerable<double> ���������(int �����, double ������ = �������������������.������, double ������� = �������������������.�������)
        {
            if (����� < 0)
                throw new �������������������������������������(nameof(�����));
            if (������ > �������)
                throw new ����������������������(nameof(������));

            for (int i = 0; i < �����; i++)
                yield return ��������.���������(������, �������);
        }

        /// <summary>
        /// ������ ������������������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="�����">���������� ���������.</param>
        /// <param name="��������">��������.</param>
        /// <returns>������������������.</returns>
        public static IEnumerable<T> ���������<T>(int �����, T ��������)
        {
            if (����� < 0)
                throw new �������������������������������������(nameof(�����));

            for (int i = 0; i < �����; i++)
                yield return ��������;
        }
    }
}