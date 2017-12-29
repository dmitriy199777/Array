﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    abstract class AbstractClass<T>
    {
        protected T[] _array;
        protected const int defaultCapacity = 10; //вместимость по умолчанию, потом можно расширить
        protected static int CUT_RATE = 2; //Метка
        public int pointer = 0; // Размер

        public virtual int Count //параметр для вывода размера 
        {
            get
            {
                return this.size();
            }
        }


        public bool isEmpty() //проверка на пустоту
        {
            return this.size() == 0;
        }



        //Возвращает элемент списка по индексу.
        public T get(int index)
        {
            return (T)_array[index];
        }


        /*Возвращает количество элементов в списке*/
        public int size()
        {
            return pointer;
        }

        /*вспомогательный метод для масштабирования.*/
        public void resize(int newlength)
        {
            T[] newarray = new T[newlength];
            System.Array.Copy(_array, 0, newarray, 0, pointer);
            _array = newarray;
        }
    }
}
